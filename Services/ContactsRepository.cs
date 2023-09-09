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
        public bool Insert(string Name, string Family, int Age, string Phone, string Email, string Address)
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
                string query = "Insert Into MyContacts (Name,Family,Age,Phone,Email,Address) values (@Name ,@Family , @Age ,@Phone ,@Email ,@Address)";
                SqlCommand Commander = new SqlCommand(query, Connection);
                Commander.Parameters.AddWithValue("@Name", Name);
                Commander.Parameters.AddWithValue("@Family", Family);
                Commander.Parameters.AddWithValue("@Age", Age);
                Commander.Parameters.AddWithValue("@Phone", Phone);
                Commander.Parameters.AddWithValue("@Email", Email);
                Commander.Parameters.AddWithValue("@Address", Address);
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

        // این متد قابلیت بروزرسانی مخاطب را به برنامه ما اضافه میکند
        // this method do the update of contacts in our program
        public bool Update(int ContactId, string Name, string Family, int Age, string Phone, string Email, string Address)
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
        public DataTable SelectAll()
        {
            string query = "Select * From MyContacts";
            SqlConnection ConnectionDoor = new SqlConnection(ConnectionString);
            SqlDataAdapter adapterCar = new SqlDataAdapter(query, ConnectionDoor);
            DataTable DataReceiver = new DataTable();
            adapterCar.Fill(DataReceiver);
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
        public DataTable Search(string item)
        {
            // کلمه کلیدی لایک در بانک عمل جتسجو را انجام میدهد
            // علامت % در اخر متغیر به معنی جستجوی اولین حروف کلمه میباشد
            // like word do the search in database 
            // and % in the end of variable means search the first letter of word

            string query = "Select * From MyContacts Where Name like @item or Family like @item ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@item", "%" + item + "%");
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

        // این متد عمل درج کاربر به برنامه برای لوگین کردن را امکان پذیر میکند
        // this method do the add users
        public bool AddUser(string username, string password)
        {

            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "Insert Into Login (UserName , Password) values (@username , @password)";
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
                SqlCommand commander = new SqlCommand(query,Connection);
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
        // this method delete the user we want
        public bool DeleteUser(int UserId)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                string query = "delete from Login where UserId = @UserId";
                SqlCommand commander = new SqlCommand(query, Connection);
                commander.Parameters.AddWithValue("@UserId", UserId);
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