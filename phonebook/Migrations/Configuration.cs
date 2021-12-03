
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace phonebook.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<phonebook.phonebookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}