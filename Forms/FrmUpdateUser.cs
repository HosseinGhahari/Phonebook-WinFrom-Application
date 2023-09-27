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
    public partial class FrmUpdateUser : Form
    {
        // این متغیر مشخص کننده این است که دقیقا چه ردیفی انتخاب شده
        // تا در قسمت دکمه ویرایش این ای دی به متد اپدیت بانک ارسال شود
        // this variable specify that which row is selected
        // so in update part of the user this id will send to update method of database

        public int UserId = 0;

        public bool IsValid()
        {
            bool isValid = true;

            if (UpdateTxtUser.Text == "")
            {
                MessageBox.Show("Please Enter User Name");
                isValid = false;
                return isValid;
            }
            if (UpdateTxtPass.Text == "")
            {
                MessageBox.Show("Please Enter Your Password");
                isValid = false;
                return isValid;
            }
            if (UpdateTxtPassRepeated.Text == "")
            {
                MessageBox.Show("Please Enter Your Repeat Password");
                isValid = false;
                return isValid;
            }
            if (UpdateTxtPass.Text != UpdateTxtPassRepeated.Text)
            {
                MessageBox.Show("Password and password repeat are not match");
                isValid = false;
                return isValid;
            }
            else
            {
                return isValid;
            }
        }



        IContactRepository repository;
        public FrmUpdateUser()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUserUpdate_Click(object sender, EventArgs e)
        {
            // در این قسمت هم اگر متد ولیدیت پر بودن تکست باکس ها اوکی بود
            // عمل ویرایش را انجام میدهیم
            // check the textboxs being fill validation
            // and do the edit

            if (IsValid())
            {

                repository.UpdateUser(UserId, UpdateTxtUser.Text, UpdateTxtPass.Text);
                MessageBox.Show("Edit is done , Program will be restarted");
                DialogResult = DialogResult.OK;
                Application.Restart();

            }
        }
    }
}
