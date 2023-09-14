using MyContacts.Repository;
using MyContacts.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyContacts
{
    public partial class FrmMain : Form
    {

        // متد برای این که اول قابلیت خودکار افزودن ستون رو از بین میبریم و همینطور
        // دیتا سورس را وصل میکنیم متد دیتابیس داده ها
        // در واقع این متد برای هدف ریفرش دیتا گرید ویو ساخته شده
        // first this method disable AutoGenerateColumns
        // we connect data sourse of data gird to a method called SelectAll
        // that is method bring all data from database

        private void DbAccess()
        {
            DgContacts.AutoGenerateColumns = false;
            FrmLogin frm = new FrmLogin();
            DgContacts.DataSource = repository.SelectAll(frm.TxtUser.Text = FrmLogin.SendText);
        }


        // به اینترفیس با نام یک متغیر جدید دسترسی پیدا میکنیم
        // we get access to interface with a var name

        IContactRepository repository;


        // یک پارامتر برای فرم اصلی قرار دادیم که یک رشته میگیرد
        // این پارامتر قرار است نام کاربری را از صفحه لاگین بگیرید و به فورم اصلی انتقال دهد
        // We put a parameter for the main form that takes a string
        // This parameter is supposed to take the username from the login page
        // and transfer it to the main form

        public FrmMain()
        {
            // یک نمونه میسازیم تا بتوانیم دسترسی داشته باشیم
            // We create a sample so that we can have access

            InitializeComponent();
            repository = new ContactsRepository(); 

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            // در این قسمت متن لوگین را ما از نام کاربری میگیریم و به لیبل صفحه اصلی انتقال میدهیم برای نمایش
            // send username text to label in main form for showing welcome
         
            FrmLogin frm = new FrmLogin();
            LblUserName.Text = frm.TxtUser.Text = "Welcome " + FrmLogin.SendText;

            // این متد دیتا گرید را ریفرش میکند
            // update datagrid
            DbAccess();
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            // از همون متد برای ریفرش دیتا گرید ویو استفاده میکنیم
            // update datagrid

            DbAccess();
        }


        private void BtnNewContact_Click(object sender, EventArgs e)
        {
            // برای باز کردن فورم دیگری بعد از کلیک بر روی یک دکمه
            // opeing a new form 

            FrmAddOrUpdate Frm = new FrmAddOrUpdate();
            if (Frm.ShowDialog() == DialogResult.OK)
            {
                DbAccess();
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // اگر بر روی ردیفی از دیتا گرید کلیک شد
            // this condition check a row of datagird is selected

            if (DgContacts.CurrentRow != null)
            {
                // نام و نام خانوادگی کسی که قرار از حذف شود نمایش داده میشود
                // it will show name and last of the contact that wanna delete

                string Name = DgContacts.CurrentRow.Cells[1].Value.ToString();
                string Family = DgContacts.CurrentRow.Cells[2].Value.ToString();
                string FullName = Name + " " + Family;

                if (MessageBox.Show($"Are your sure about deleting {FullName}  ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // عمل حذف را طبق ای دی مخاطب حذف میکنیم
                    // delete opreation happen via id of contact
                    int ContactId = int.Parse(DgContacts.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(ContactId);
                    DbAccess();
                }
            }
            else
            {
                MessageBox.Show("Please Select a User");
            }
        }



        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // در این قسمت وقتی روی یک ردیف کلیک شد
            // ای دی اون ردیف گرفته میشه و به متقیر کانکت ای داده میشه
            // و در ادامه این فورم مورد نظر برای اپدیت شدن انتقال داده میشود.
            // in this section when you select a row
            // id of that row will be taken and give it to ContactId variable 
            // and send to form for updateing

            if (DgContacts.CurrentRow != null)
            {
                FrmAddOrUpdate frm = new FrmAddOrUpdate();
                int ContactId = int.Parse(DgContacts.CurrentRow.Cells[0].Value.ToString());
                frm.ContactId = ContactId;

                /// در این قسمت تمام اطلاعات دیتا گرید برای بروز رسانی درون تکست باکس قرار میگیرد
                /// in this section all the data for updating tranfer to textboxs for edit
                frm.TxtName.Text = DgContacts.CurrentRow.Cells[1].Value.ToString();
                frm.TxtFamily.Text = DgContacts.CurrentRow.Cells[2].Value.ToString();
                frm.TxtAge.Text = DgContacts.CurrentRow.Cells[3].Value.ToString();
                frm.Txtphone.Text = DgContacts.CurrentRow.Cells[4].Value.ToString();
                frm.TxtEmail.Text = DgContacts.CurrentRow.Cells[5].Value.ToString();
                frm.TxtAddress.Text = DgContacts.CurrentRow.Cells[6].Value.ToString();
                frm.ShowDialog();
                DbAccess();
            }
        }




        // عمل جستجو را انجام میدهد ، دیتا گرید را وصل میکنیم به متد سرچ و نتیجه را نشان میدهد
        // do search opreation and we connect datagrid source to search method
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgContacts.DataSource = repository.Search(TxtSearch.Text);
        }


        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
        }


        private void BtnManage_Click(object sender, EventArgs e)
        {
            FrmUserSetting frm = new FrmUserSetting();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            // این قسمت مربوط به ذخیر مخاطب است
            // در این قسمت اول پنجره سیو کردن باز میشود فورمت سیو نام ان مشخص میشود
            // و در صورت زدن دکمه ذخیر در یک حلقه تکرار تکتک سطر ها اطلاعاتشون خوانده میشود و ذخیره میشود
            // in this section we can save contacs name inside of a text file
            // first we open the save window and we specify format and name 
            // then inside of a foreach loop , we get all the rows data and save it 

            SaveFileDialog savetext = new SaveFileDialog();
            savetext.Filter = "Text File|*.txt";
            savetext.Title = "Save a Text File";
            savetext.FileName = "ContactsSave";
            if (savetext.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter write = new StreamWriter(savetext.FileName))

                {
                    write.WriteLine("Your Contact Info : ");
                    foreach (DataGridViewRow row in DgContacts.Rows)
                    {
                        write.WriteLine("");
                        write.WriteLine("Name : " + row.Cells[1].Value.ToString());
                        write.WriteLine("Last Name : " + row.Cells[2].Value.ToString());
                        write.WriteLine("Age : " + row.Cells[3].Value.ToString());
                        write.WriteLine("Phone : " + row.Cells[4].Value.ToString());
                        write.WriteLine("Email : " + row.Cells[5].Value.ToString());
                        write.WriteLine("Address : " + row.Cells[6].Value.ToString());
                        write.WriteLine("");    
                    }
                    MessageBox.Show("Data is saved");
                }
            }

           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}






