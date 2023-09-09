using MyContacts.Repository;
using MyContacts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
   
    internal static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // در این قسمت ما به متد های بخش سرویس ها دسترسی پیدا میکنیم
            // get access to services methods 

            IContactRepository repository;
            repository = new ContactsRepository();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // در این بخش ما چک میکنیم اگر دیتا گرید کاربر ها خالی بود فورم اصلی باز شود
            // تا بتوان کاربر جدید اضافه کرد ، در صورت وجود کاربر در دیتا گرید کاربر 
            // صفحه لوگین بالا می آید
            // in this section we check if the datagird has data or not 
            // if data is there , login come up and user have to sign in
            // else main form come up, then we can add user for login 

            FrmUserSetting frmUserSettings = new FrmUserSetting();
            FrmLogin FrmLogn = new FrmLogin();
            frmUserSettings.DgUsers.DataSource = repository.SelectUsers();

            if (frmUserSettings.DgUsers.Rows.Count == 0)
            {
                Application.Run(new FrmMain(FrmLogn.TxtUser.Text));
            }
            else
            {
                Application.Run(new FrmLogin());
            }

        }
    }
}
