using Database.Context;
using Database.Model;
using System.Data;

namespace DBTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new CourseManagementSystemContext();

            User MyUser = db.User.Where(x => x.UserId == "00184282-58e1-4ff6-8987-d531f42ae4a2").FirstOrDefault();
            Console.WriteLine($"Name:{MyUser.UserName}--Email:{MyUser.UserEmail}");
            db.User.Remove(MyUser);
            db.SaveChanges();
        }
    }

    class DBInsertTest
    {
        public DBInsertTest()
        {
            var db = new CourseManagementSystemContext();
            Console.WriteLine(DateTime.Now);

            User myUser = new User();
            myUser.UserName = "Md Mashud Rana";
            myUser.UserEmail = "admin@admin.admin";
            myUser.UserPasswordHash = "123";
            myUser.IsUserActive = true;
            myUser.UserType = "Admin";

            db.User.Add(myUser);
            int row = db.SaveChanges();



            //for (int i = 0; i < 10; i++)
            //{
            //    db.UserInfo.Add(new UserInfo
            //    {
            //        FullName = "Manager-" + i,
            //        Email = "manager" + i + "@manager.manager",
            //        PasswordHash = "Hash" + i,
            //        IsActive = i % 2 == 0,
            //        RoleId = 2
            //    });
            //}
            //for (int i = 0; i < 1000; i++)
            //{
            //    db.UserInfo.Add(new UserInfo
            //    {
            //        FullName = "Client-" + i,
            //        Email = "client" + i + "@client.client",
            //        PasswordHash = "Hash" + i,
            //        IsActive = i % 2 == 0,
            //        RoleId = 3
            //    });
            //}
            //db.SaveChanges();
            Console.WriteLine(DateTime.Now);
        }
    }

    class DBReadTest
    {
        public DBReadTest()
        {
            var db = new CourseManagementSystemContext();
            List<Instructor> Instructor = db.Instructor.ToList();
            foreach (Instructor role in Instructors)
            {
                Console.WriteLine(Instructor.Name);
            }
            Console.WriteLine("---------------------------------");
            List<User> users = db.User.ToList();
            List<User> Admin = users.Where(x => x.InstructorId == 1).ToList();
            List<User> Manager = users.Where(x => x.InstructorId == 2).ToList();
            List<User> Client = users.Where(x => x.InstructorId == 3).ToList();
            Admin.ForEach(x =>
            {
                Console.WriteLine(x.UserName);
            });
            Console.WriteLine("---------------------------------");
            Manager.OrderBy(x => Convert.ToInt32(x.UserName.Split(",").LastOrDefault())).ToList()
            .ForEach(x =>
            {
                Console.WriteLine(x.UserName);
            });
            Console.WriteLine("---------------------------------");
            Client.OrderBy(x => Convert.ToInt32(x.UserName.Split("-").LastOrDefault())).ToList()
            .ForEach(x =>
            {
                Console.WriteLine(x.UserName);
            });
        }
    }
}