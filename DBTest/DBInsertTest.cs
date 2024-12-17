using Database.Context;
using Database.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DBTest
{
    class DBInsertTest
    {
        private EntityEntry<User> User;

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


            /* db.User.Add(new User
            {
                UserName = "Admin",
                UserEmail = "admin@admin.com",
                UserPasswordHash = "Hash",
                IsUserActive = true,

            });
            for (int i = 0; i < 1000; i++)
            {
                db.User.Add(new User
                {
                    UserName = "Client-" + i,
                    UserEmail = "client" + i + "@client.client",
                    PasswordHash = "Hash" + i,
                    IsActive = i % 2 == 0,
                    RoleId = 3
                });
            }
            db.SaveChanges();
            Console.WriteLine(DateTime.Now);
        }
    } */

    /*
    class DBReadTest
    {
        public DBReadTest()
        {
            var db = new CourseManagementSystemContext();
            List<Instructor> Instructor = db.Instructor.ToList();
            foreach (User user in Users)
            {
                Console.WriteLine(User.);
            }
            Console.WriteLine("---------------------------------");
            List<User> users = db.User.ToList();
            List<User> Admin = users.Where(x => x.UserName == "Mraadiyat").ToList();
            List<User> Instructor = users.Where(x => x.UserName == "MRana").ToList();
            List<User> Student = users.Where(x => x.UserName == "MR").ToList();
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

        public IEnumerable<User> Users { get; private set; }
    } */
};
