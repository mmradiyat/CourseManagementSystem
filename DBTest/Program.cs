using Database.Context;
using Database.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;

namespace DBTest
{
    internal class Program
    {
        class DBInsertTest
        {
            public DBInsertTest()
            {
                var db = new CourseManagementSystemContext();
                Console.WriteLine(DateTime.Now);

                User myUser = new User();
                myUser.UserName = null;
                myUser.UserEmail = "admin@admin.admin";
                myUser.UserType = "admin";
                myUser.UserPasswordHash = "Hash";
                myUser.IsUserActive = true;

                db.User.Add(myUser);
                int row = db.SaveChanges();
            }

            static void Main(string[] args)
            {
                CourseManagementSystemContext db = new CourseManagementSystemContext();

                var AllUser = db.User.ToList();
            }
        }
    }
}
