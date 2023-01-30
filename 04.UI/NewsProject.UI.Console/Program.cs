using NewsProject.DataBase.EF.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new NewsDbContext())
            {
                ctx.Keywords.Add(new Domain.Entities.Entities.Keyword
                {
                    Title = "sdsd",
                    InsertDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    InsertBy = 1,
                    UpdateBy =1
                });
                ctx.SaveChanges();
            }
        }
    }
}
