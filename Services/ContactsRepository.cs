using MyContacts.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.LinkLabel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace MyContacts.Services
{

    // ارث بری این کلاس از اینترفیس
    // This class inherits from the interface
    class ContactsRepository : IContactRepository
    {


        // آدرس های بانک اطلاعاتی ما ، که به صورت لوکال به بانک ما وصل میشود
        // address of database that connect locally to database

        private string ConnectionString = "Data Source =.; Initial Catalog = PhoneBook_Contacts_DB ; Integrated Security=True";



        // این متد قابلیت درج مخاطب را به برنامه ما اضافه میکند
        // this method do the insert in our program
        public bool Insert(string Name, string Family, string Age, string Phone, string Email, string Address, string LinkName)
        {

            // عملیاتی که میخواهیم روی بانک انجام بدیم را ایجاد میکنیم
            // در اینجا فقط اس کی یو ال کامندر اجازه دسترسی به بانک دارد و ازان استفاده میکنیم
            // این کانکشت مانند یک در برای ارتباط با بانک است
            // به کامندر میگوییم که پارامتر هامون رو بگیرد و اد کند
            // و در اخر این دستورات را اجرا میکنیم یا کوری میگیریم
            // we create the operations that we want to do in our database
            // in this part only sqlcommand can do important access that why we use it
            // SqlConnection is a for connection to your database , act like a door
            // Commander take the parameters that we want and command of qury will be called
            // then we open the connection execute the operation and in the end we have to close
            // cos if we don't close it , System resources will be involved 

            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "Insert Into MyContacts (Name,Family,Age,Phone,Email,Address,LinkId) values (@Name ,@Family , @Age ,@Phone ,@Email ,@Address ,@LinkId)";
                SqlCommand Commander = new SqlCommand(query, Connection);

                Commander.Parameters.AddWithValue("@Name", Name);
                Commander.Parameters.AddWithValue("@Family", Family);
                Commander.Parameters.AddWithValue("@Age", Age);
                Commander.Parameters.AddWithValue("@Phone", Phone);
                Commander.Parameters.AddWithValue("@Email", Email);
                Commander.Parameters.AddWithValue("@Address", Address);
                Commander.Parameters.AddWithValue("@LinkId", LinkName);
                Connection.Open();
                Commander.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }

        // این متد قابلیت حذف مخاطب را به برنامه ما اضافه میکند
        // this method do the delete in our program
        public bool Delete(int ContactId)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "Delete from MyContacts where ContactId = @id ";
                SqlCommand Commander = new SqlCommand(query, Connection);
                Commander.Parameters.AddWithValue("@id", ContactId);
                Connection.Open();
                Commander.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        // این متد قابلیت حذف تمام مخاطب های مورد نظر را امکان پذیر میکنن ، البته مخاطب های کاربری که وارد برنامه شده
        // this method can remove all the contacts , of course contacts of the user that just log in to application
        public bool DeleteAll(string LinkName)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            try
            {
                string query = "Delete from MyContacts where LinkId = @LinkName";
                SqlCommand commander = new SqlCommand(query, Connection);
                commander.Parameters.AddWithValue("@LinkName", LinkName);
                Connection.Open();
                commander.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }


        // این متد قابلیت بروزرسانی مخاطب را به برنامه ما اضافه میکند
        // this method do the update of contacts in our program
        public bool Update(int ContactId, string Name, string Family, string Age, string Phone, string Email, string Address)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "Update MyContacts set Name = @Name , Family = @Family , Age = @Age , Phone = @Phone , Email = @Email , Address = @Address Where ContactId = @ContactId";
                SqlCommand Commander = new SqlCommand(query, Connection);
                Commander.Parameters.AddWithValue("@ContactId", ContactId);
                Commander.Parameters.AddWithValue("@Name", Name);
                Commander.Parameters.AddWithValue("@Family", Family);
                Commander.Parameters.AddWithValue("@Age", Age);
                Commander.Parameters.AddWithValue("@Phone", Phone);
                Commander.Parameters.AddWithValue("@Email", Email);
                Commander.Parameters.AddWithValue("address", Address);
                Connection.Open();
                Commander.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }



        // این متد تمام اطلاعات درون بانک مخاطب ها را واکشی میکند و نشان میدهد
        // this method fetch all the data from database from contacts table
        public DataTable SelectAll(string LinkName)
        {

            string query = "Select * From MyContacts where LinkId = '"+LinkName+"' ";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable DataReceiver = new DataTable();
            adapter.Fill(DataReceiver);
            return DataReceiver;
        }

        // این متد اطلاعات درون بانک کاربران را واکشی میکند
        // this method fetch all the data from database from users table
        public DataTable SelectUsers()
        {
            string query = "Select * From Login";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable DataReceiver = new DataTable();
            adapter.Fill(DataReceiver);
            return DataReceiver;
        }

        // عمل سرچ در دفترچه تلفن بر اساس نام و نام خانوادگی
        // this method do the search in contacts
        public DataTable Search(string LinkName, string Item)
        {
            // کلمه کلیدی لایک در بانک عمل جتسجو را انجام میدهد
            // علامت % در اخر متغیر به معنی جستجوی اولین حروف کلمه میباشد
            // همچنین عمل جستجو بر اساس اطلاعات کسی که وارد برنامه شده است انجام میشود
            // like word do the search in database 
            // and % in the end of variable means search the first letter of word
            // also search work base on user that log in to applcation

            string query = "Select * From MyContacts Where LinkId = @LinkName And Name like @item UNION Select * From MyContacts Where LinkId = @LinkName And Family like @item";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@LinkName", LinkName);
            adapter.SelectCommand.Parameters.AddWithValue("@item", "%" + Item + "%");
            DataTable DataReceiver = new DataTable();
            adapter.Fill(DataReceiver);
            return DataReceiver;
        }



        // این متد برای ورود به برنامه اطلاعات درج شده در بانک رو چک میکند اگر همخواهی داشت ورود میکند
        // this method check the data from user data if exists login happen
        public bool Login(string username, string password)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                bool result = false;
                string query = "Select UserName,Password From Login where UserName=@UserName And [Password]=@Password";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);
                Connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader(); // اطلاعات درون جدول را میخواند // read the data inside of table

                // این بخش مشخص میکند که ایا اطلاعات وارد شده با اطلاعات درون بانک یکی هستن یا خیر
                // this part check if both side data are in the same page
                if (sqlDataReader.HasRows)
                {
                    result = true;
                }
                return result;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }


        // این متد بررسی میکند که آیا یوزر نیمی که از طریق پارامتر وارد شده
        // در این دیتا بیس بخش نام کاربری وجود دارد یا خیر که
        // اگر وجود نداشت نمیشود با این نام ، نام کاربری جدید ساخت
        // this method check the user that is entered via parameter
        // is already exist in database or not if it's there , you can't add that username again
        public bool AddUserCheck(string username)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                bool result = false;
                string query = "Select UserName From Login where UserName=@UserName";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@UserName", username);
                Connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader(); 

                if (sqlDataReader.HasRows)
                {
                    result = true;
                }
                return result;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        // این متد عمل درج کاربر به برنامه برای لوگین کردن را امکان پذیر میکند
        // this method do the add users
        public bool AddUser(string username, string password)
        {

            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "Insert Into Login (UserName , Password) values (@username , @password) ";
                SqlCommand commander = new SqlCommand(query, Connection);
                commander.Parameters.AddWithValue("@UserName", username);
                commander.Parameters.AddWithValue("@Password", password);
                Connection.Open();
                commander.ExecuteNonQuery();      
                return true;
            }
            catch
            {           
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        // این متد کاربران برنامه را بروزرسانی میکند
        // this method update the users
        public bool UpdateUser(int UserId, string UserName, string Password)
        {

            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "Update Login Set UserName = @UserName , Password = @Password Where UserId = @UserId";
                SqlCommand commander = new SqlCommand(query, Connection);
                commander.Parameters.AddWithValue("@UserId", UserId);
                commander.Parameters.AddWithValue("@UserName", UserName);
                commander.Parameters.AddWithValue("@Password", Password);
                Connection.Open();
                commander.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }

        // این متد کاربران اضافه شده را میتواند حذف کند
        // همینطور مخاطب هایی که این کاربر اضافه کرده است حذف میکرد
        // this method delete the user we want
        // also delete the contacts that this user added to program
        public bool DeleteUser(int UserId, string Username, string LinkName)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "delete from Login where UserId = @UserId delete from MyContacts Where LinkId = @LinkName";
                SqlCommand commander = new SqlCommand(query, Connection);
                commander.Parameters.AddWithValue("@UserId", UserId);
                commander.Parameters.AddWithValue("@LinkName", LinkName);
                Connection.Open();
                commander.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }


        }

    
       

        }
    }
