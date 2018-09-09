using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.DAL
{
    public class UserInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var Users = new List<UserLogin>
            {
            new UserLogin{UserName="Suyash",Password="Password"},
            new UserLogin{UserName="Yash",Password="Alonso"}
            };

            Users.ForEach(s => context.UserLogin.Add(s));
            context.SaveChanges();
            var userDetails = new List<UserDetails>
            {
            new UserDetails{UserID=1,FirstName="Suyash",LastName="Mehrotra",Class=4},
            new UserDetails{UserID=2,FirstName="Yash",LastName="Sharma",Class=4}
           
            };
            userDetails.ForEach(s => context.UserDetails.Add(s));
            context.SaveChanges();
            
            
        }
    }

}
