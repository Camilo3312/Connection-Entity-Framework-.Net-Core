using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Test_Connection_Entity_Framework.Models;

namespace Test_Connection_Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new cursomvcContext())
            {
                var pt = new User();

                pt.Email = "newemail@gmail.com";
                pt.Password = "contraseñamuysegura";

                context.Users.Add(pt);

                var updateUser = context.Users.Find(1);
                updateUser.Password = "nuevacontraseña123";

                context.Entry(updateUser).State = EntityState.Modified;

                var removeThisUser = context.Users.Find(3);

                context.Remove(removeThisUser);
              
                context.SaveChanges();

                foreach (var post in context.Users.ToList())
                {
                    Console.WriteLine(post.Email);
                }
            }
        }
    }
}
