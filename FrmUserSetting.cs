using MyContacts.Repository;
using MyContacts.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{

    public partial class FrmUserSetting : Form
    {

        // متد ریفرش شدن دیتاگرید 
        // refresh the datagird
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

                // فورم اپدیت را فراخوانی میکنیم و یوزر ای دی انتخاب شده را انتقال میدهیم به فورم اپدیت مشخصات
                // we call update form and send the user for updating 

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

        private void BtnRemoveUsers_Click(object sender, EventArgs e)
        {

            // در این قسمت ما عمل حذف کاربرهای نرم افزار را انجام میدهیم
            // اگر دیتا گرید ما تنها یک عضو یا کاربر داشته باشد امکان حذف ان وجود ندارد
            // delete happen and if the datagird only have one user , delete can't happen

            if (DgUsers.CurrentRow != null)
            {
                if (DgUsers.Rows.Count <= 1 )
                {
                    MessageBox.Show("You Can't Delete All The Users");
                }
                else
                {
                    if (MessageBox.Show("Are You Sure About Delete?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int UserId = int.Parse(DgUsers.CurrentRow.Cells[0].Value.ToString());
                        repository.DeleteUser(UserId);
                        DbUpdate();
                    }

                }



            }
        }
    }
}
