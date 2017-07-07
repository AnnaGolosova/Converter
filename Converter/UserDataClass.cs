using System;
using System.Data.Entity;

namespace UserClass
{
    public class User
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string patronymicName { get; set; }
        public string sity { get; set; }
        public string country { get; set; }

        public User() {}

        public void SetFields(DateTime cdate, String cfirstName, String clastName, String cpatronymicName, String csity, String ccountry)
        {
            this.date = cdate;
            this.firstName = cfirstName;
            this.patronymicName = cpatronymicName;
            this.lastName = clastName;
            this.sity = csity;
            this.country = ccountry;
        }
    }

    public class UserContext : DbContext
    {
        public UserContext() : base("connectionString")
        { }

        public DbSet<User> Users { get; set; }
    }
}

