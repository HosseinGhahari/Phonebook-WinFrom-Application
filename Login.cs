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
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // در این قسمت در صورت مقایرت اطلاعات داده شده با بانک عمل لوگین انجام میشود
            // if the info that user entered are connrect and same as databse , login happen

            if (IsValid())
            {

                if (repository.Login(TxtUser.Text.Trim(), TxtPassword.Text.Trim()))
                {
                    string NameView = TxtUser.Text;
                    MessageBox.Show($"{NameView} Signed in");
                    this.Hide();
                    FrmMain form1 = new FrmMain(TxtUser.Text);
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("UserName or Password is Incorrect");
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            // در اینجا یک نمونه از فورم اصلی ایجاد میکنیم 
            // و جای پارامتر آن مقدار تکست باکس یوزر نیم را وارد میکنیم
            // و این مقدار به پارامتر فورم اصلی انتقال داده میشود
            // و در لیبل نمایش داده میشه
            // we made a sample of main form
            // and we gave it a parameter , and that parameter is
            // user name textbox , data of that will be transfer to
            // label of main form for showing welcome to entered user


            FrmMain frm = new FrmMain(TxtUser.Text);  

        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
