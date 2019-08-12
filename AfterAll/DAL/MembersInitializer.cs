using AfterAll.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfterAll.DAL {
    public class MembersInitializer : DropCreateDatabaseAlways<AfterAllContext> {

        protected override void Seed(AfterAllContext context) {
            base.Seed(context);

            context.Members.Add(new Member() {
                Name = "Eric",
                Email = "eric@gmail.com",
                Password = "123456",
                Phone = 0912345678,
                Birth = DateTime.Now,
                AccessLevel = 5
            });

            context.SaveChanges();
        }

    }
}