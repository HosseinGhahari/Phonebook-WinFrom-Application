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
    public partial class FrmAddUser : Form
    {

       
        // متد پر بودن تکست باکس ها
        // this method check if the textboxs are fill or not

        public bool IsValid()
        {
            bool isValid = true;

            if (AddTxtUser.Text == "")
            {
                MessageBox.Show("Please Enter Your User Name");
                return false;
            }
            if (AddTxtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password");
                return false;
            }
            if (AddTxtRepeatPass.Text == "")
            {
                MessageBox.Show("Please Enter Your Repeat Password");
                return false;
            }
            if (AddTxtRepeatPass.Text != AddTxtPassword.Text)
            {
                MessageBox.Show("Password and password repeat are not match");
                return false;
            }
            else
            {
                return isValid;
            }         
        }



        IContactRepository repository;
        public FrmAddUser()
        {
            repository = new ContactsRepository();
            InitializeComponent();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // در این قسمت عمل ایجاد کاربر جدید انجام میشود و اطلاعات همچنین وارد بانک میشود
            //in this section use add happen via method inside of ContactsRepository and data add to database

            if (IsValid())
            {
                repository.AddUser(AddTxtUser.Text, AddTxtPassword.Text);
                MessageBox.Show("New Contact Added");
                this.Close(); 
            }
        }


    }
}
