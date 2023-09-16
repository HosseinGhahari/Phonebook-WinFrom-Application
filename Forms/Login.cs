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
    public partial class FrmLogin : Form
    {
        // ما این متغیر را تعریف کردیم تا بتوانیم مقدار نام کاربری صفحه لوگین را به فورم های دیگر انتقال دهیم
        // we this variable we are able to tranfer login username value to another form 
        public static string SendText = "";

        // متد بررسی پر بودن تکست باکس ها مثل همیشه
        // textboxs fill check
        public bool IsValid()
        {
            bool isValid = true;

            if (TxtUser.Text == "")
            {
                MessageBox.Show("Please Enter Your Username");
                return false;
            }
            if (TxtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password");
                return false;
            }
            return isValid;
        }


        IContactRepository repository;
        public FrmLogin()
        {
            repository = new ContactsRepository();
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // در این قسمت در صورت مقایرت اطلاعات داده شده با بانک عمل لوگین انجام میشود
            // if the info that user entered are connrect and same as databse , login happen

            if (IsValid())
            {

                if (repository.Login(TxtUser.Text.Trim(), TxtPassword.Text))
                {
                    // هر زمانی که کاربر ورود میکند نام کاربری به متغیر مورد نظر ارسال میشود
                    // eveytime user log in , the user name tranfer to SendText Variable 

                    SendText = TxtUser.Text;
                    string NameView = TxtUser.Text;
                    MessageBox.Show($"{NameView} Signed in");
                    this.Hide();
                    FrmMain form1 = new FrmMain();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("UserName or Password is Incorrect");
                }
            }


        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
        }
    }
}

