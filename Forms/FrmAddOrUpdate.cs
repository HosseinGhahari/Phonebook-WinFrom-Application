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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyContacts
{


    public partial class FrmAddOrUpdate : Form
    {
        // این متغیر برای تغییر نام فورم برای اد کردن و ویرایش کردن اضافه شده است'
        // در واقع با استفاده از این متغیر ای دی دیتا گریدمون رو انتقال میدیم تا بفهمیم میخواهیم 
        // اپدیت یا اضافه کنیم
        // this variable is for changing the name of form , when it's edit and when it's add
        // in this var indeed id of datagird will sent to understand the update or add

        public int ContactId = 0;

        // متدی که تضمین میدهد تکست باکس های ما خالی نباشد
        // this method check if textboxs are empty or not
        bool TextValid()
        {
            bool IsValid = true;

            if (TxtName.Text == "")
            {
                MessageBox.Show("Please Enter Your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsValid = false;
                return IsValid;
            }
            if (TxtFamily.Text == "")
            {
                MessageBox.Show("Please Enter Your Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsValid = false;
                return IsValid;

            }
            if (TxtAge.Text  == "")
            {
                MessageBox.Show("Please Enter Your Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsValid = false;
                return IsValid;

            }
            if (Txtphone.Text == "")
            {
                MessageBox.Show("Please Enter Your Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsValid = false;
                return IsValid;

            }
            if (TxtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsValid = false;
                return IsValid;

            }

            return IsValid;
        }

        // این متد مشخص میکند که تکست باکس سن و شماره تلفن نمیتواند از نوع غیر عددی باشد
        // this method tell age and phone textbox that they only can accept numbers input
        void TextInput(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed");
                e.Handled = true;
            }
            else if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        IContactRepository repository;
        public FrmAddOrUpdate()
        {
            repository = new ContactsRepository();
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddOrUpdate_Load(object sender, EventArgs e)
        {

            // چک میکند اگر کانتکت ای دی انتخاب شده صفر بود متن فورم عوض میشود
            // ما وقتی روی ردیفی کلیک میکنیم ای دی اون ردیف یک عدد داد که مثلا صفر نیست
            // اگر صفر نبود عمل ویرایش انجام میشود
            //check if id is zero then i will be add , cos nothing is selected by use then
            // it will be add , else if user select a contact user id of that contact will go to
            // ContactId andi will be edit , when perss update

            if (ContactId == 0)
            {
                this.Text = "Add User";
            }
            else
            {
                this.Text = "Edit User";
                this.BtnSubmit.Text = "Edit";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // مربوط به متد عملیات ولیدت کردن پر بودن تکست باکس ها
            // validation method for textboxs


            if (TextValid())
            {
                if (ContactId == 0)
                {
                    // متد اینسرت فراخوانی میشود و پارامتر هایی که نیاز دارد را وارد میکنیم
                    //insert method will be call and insert will be done
                    repository.Insert(TxtName.Text, TxtFamily.Text, TxtAge.Text, Txtphone.Text, TxtEmail.Text, TxtAddress.Text, FrmLogin.SendText);
                    MessageBox.Show("The operation Add was successful");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    // متد اپدیت فراخوانی میشود و پارامتر هایی که نیاز دارد را وارد میکنیم
                    //Update method will be call and update will be done

                    repository.Update(ContactId, TxtName.Text, TxtFamily.Text, TxtAge.Text, Txtphone.Text, TxtEmail.Text, TxtAddress.Text);
                    MessageBox.Show("Edit is done");
                    DialogResult = DialogResult.OK;
                }

            }

        }

        private void TxtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // در این بخش این متدی که فراخوانی شده مشخص میکند که فقط اعداد برای تکست باکس سن و شماره قابل پذیرش است
            // in this section this method that we called tell age and phone textbox that they only can accept numbers

            TextInput(sender, e);

        }

        private void Txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // در این بخش این متدی که فراخوانی شده مشخص میکند که فقط اعداد برای تکست باکس سن و شماره قابل پذیرش است
            // in this section this method that we called tell age and phone textbox that they only can accept numbers

            TextInput(sender, e);

        }
    }
}
