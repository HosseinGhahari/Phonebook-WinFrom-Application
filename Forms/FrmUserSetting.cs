using MyContacts.Repository;
using MyContacts.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyContacts
{

    public partial class FrmUserSetting : Form
    {


        // متد ریفرش شدن دیتاگرید 
        // همچنین وقتی کاربری رو حذف میکنیم دیتا گرید اپدیت میشود تا مخاطب هایی که این کاربر اضافه کرده هم حذف شوند
        // refresh the datagird
        // also update main contacts datagrid , cos if user is deleted his data also be removed from datagrid
        public void DbUpdate()
        {
            DgUsers.AutoGenerateColumns = false;
            DgUsers.DataSource = repository.SelectUsers();    
        }
        
        
        IContactRepository repository;
        public FrmUserSetting()
        {
            repository = new ContactsRepository();
            InitializeComponent();
        }

        private void FrmUserSetting_Load(object sender, EventArgs e)
        {
            DbUpdate();
        }

        private void BtnUpdateUsers_Click(object sender, EventArgs e)
        {
            // این کد مشخص میکند بر روی یک ردیف از دیتا گرید کلیک شده
            // check if row of data grid is selected
            if (DgUsers.CurrentRow != null) 
            {

                // در این بخش بررسی میشود که کاربری که انتخاب میکنید
                // همان کاربری باشد که وارد برنامه شده تا اجازه بروز رسانی بدهد
                // this section check the user you wanna edit is the same user
                // who logged inside the app , otherwise you can't edit it

                if (DgUsers.CurrentCell.Value.ToString().ToLower() != FrmLogin.SendText.ToLower())
                {
                    MessageBox.Show("You can't edit other Users information");
                }

                // فورم اپدیت را فراخوانی میکنیم و یوزر ای دی انتخاب شده را انتقال میدهیم به فورم اپدیت مشخصات
                // we call update form and send the user for updating
                else
                {
                    //FrmUserCheck frmUserCheck = new FrmUserCheck();
                    //frmUserCheck.ShowDialog();

                    FrmUpdateUser frm = new FrmUpdateUser();
                    int UserId = int.Parse(DgUsers.CurrentRow.Cells[0].Value.ToString());
                    frm.UserId = UserId;
                    frm.UpdateTxtUser.Text = DgUsers.CurrentRow.Cells[1].Value.ToString();
                    frm.UpdateTxtPass.Text = DgUsers.CurrentRow.Cells[2].Value.ToString();
                    frm.UpdateTxtPassRepeated.Text = DgUsers.CurrentRow.Cells[2].Value.ToString();
                    frm.ShowDialog();
                    DbUpdate();

                }


            }

        }

        private void BtnRemoveUsers_Click(object sender, EventArgs e)
        {

            // در این قسمت ما عمل حذف کاربرهای نرم افزار را انجام میدهیم
            // همچنین بعد حذف کاربر ، مخاطب هایی که او اضافه کرده هم حذف میشود
            // in this section we do user delete
            // also delete the contacts that this user added to program


            // در قسمت بعدی شرط چک میکند اگر کاربری که قرار است حذف شود کاربری باشد که به برنامه ورود کرده
            // اخطار میدهد در صورت حذف این کاربر از برنامه خروج پیدا میکند و کاربر حذف میشود
            // همچنین بخش بعدی دستور شرطی مشخص میکند که شما اجازه ندارید کاربرهای دیگر را حذف کنید
            //also check if the the user you want delete is the user that is login now
            // it alarm that this action remove your info and account and you will be log out
            // also in else if says that you can't delete other users from application

            if (DgUsers.CurrentRow != null)
            {
                if (DgUsers.CurrentCell.Value.ToString().ToLower() != FrmLogin.SendText.ToLower())
                {
                    MessageBox.Show("You can't Delete other Users information");
                }
                else
                {
                    int UserId = int.Parse(DgUsers.CurrentRow.Cells[0].Value.ToString());
                    string UserName = DgUsers.CurrentRow.Cells[1].Value.ToString();     
                    string LoginUserName = FrmLogin.SendText;

                    if (LoginUserName.ToLower() == UserName.ToLower())
                    {
                        if (MessageBox.Show("If you Delete this user you will log out are you sure ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            repository.DeleteUser(UserId, UserName, LoginUserName);
                            DbUpdate();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are You Sure About Delete?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            repository.DeleteUser(UserId, UserName, LoginUserName);
                            DbUpdate();
                        }
                    }
                }
            }
        }

        // در این بخش ما به ایونت دیتا گرید کاربر ها دسترسی پیدا کردیم و مشخص کردیم که ستون دوم 
        // که رمز عبور ها مشخص شده به صورت نامشخص باشند تا امنیت فراهم شود
        // in this section we called CellFormatting Even of users datagird 
        // to hash the password part with * so other users can't see the password

        private void DgUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int PassLength = 7;
            string LoginUserName = FrmLogin.SendText;
            if (e.ColumnIndex == 2 && e.Value != null)
            {              
                e.Value = new string('*', PassLength);
            }


        }
    }
}
