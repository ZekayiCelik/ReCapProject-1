using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //var en = customerManager.GetAll();
            //foreach (var item in en.Data )
            //{
            //    Console.WriteLine(item.UserId);
            //}

            //UserAaddTest();



            UserManager userManager = new UserManager(new EfUserDal());
            var en = userManager.GetById(1);
            foreach (var item in en.Data)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.Email);
            }

        }







        //private static void UserAaddTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    var newUser = new User
        //    {
               
        //        FirstName = "Burak",
        //        LastName = "Kalaycı",
        //        Email = "tbyte@gmail.com",
        //        Password = "5581475315"
        //    };
        //    userManager.Add(newUser);


        //}
    }
}
