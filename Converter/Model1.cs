using System;

namespace Converter
{
    using System.Data;
    using System.Data.Entity;
    using System.Linq;

    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        { }

        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string surName { get; set; }
        public string city { get; set; }
        public string country { get; set; }

        public User() { }

        public void SetFields(DateTime cdate, String cfirstName, String clastName, String cpatronymicName, String ccity, String ccountry)
        {
            this.date = cdate;
            this.firstName = cfirstName;
            this.surName = cpatronymicName;
            this.lastName = clastName;
            this.city = ccity;
            this.country = ccountry;
        }
    }
}