using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Repository
{
    interface IContactRepository
    {

        // در این برنامه ما از تکنولوژی ای دیو دات نت استفاده میکنیم برای دسترسی به بانک اطلاعاتی
        // مجموعه کار هایی که ما نیاز داریم بر اساس یک قرار داد در اینترفیس مینویسیم
        // in this program we use Ado.Net technology for accessing to database
        // We write the set of tasks we need based on a contract in the interface

        bool Insert(string Name, string Family, string Age, string Phone, string Email, string Address , string LinkName);
        bool AddUser(string username, string password);
        bool Update(int ContactId, string Name, string Family, string Age, string Phone, string Email, string Address);
        bool UpdateUser(int UserId, string UserName, string Password);
        bool Delete(int ContactId);
        bool DeleteUser(int UserId ,string Username,string LinkName);
        bool Login(string UserName, string Password);
        bool AddUserCheck(string username);
        DataTable SelectAll(string LinkName);
        DataTable SelectUsers();
        DataTable Search(string LinkName,string Item);
       
       
        
    }
}
