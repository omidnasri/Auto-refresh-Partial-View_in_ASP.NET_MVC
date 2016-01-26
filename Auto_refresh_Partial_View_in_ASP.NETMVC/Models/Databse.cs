using System;

namespace Auto_refresh_Partial_View_in_ASP.NETMVC.Models
{
    public class Databse
    {
        public UsersViewModel RandomUser()
        {
            // به ازای هر درخواست یک کاربر جدید ایجاد می‌شود
            return new UsersViewModel() { Id = 0, FullName = "Sadar"+ DateTime.Now.Second };
        }
    }
}