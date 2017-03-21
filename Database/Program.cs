using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new StocktradingDBContext())
            {
                context.RegisterUsers.Add(new RegisterUser() { EmailId = "sdfsdfasf@gmai.com" });
                context.SaveChanges();
            }
        }
    }
}
