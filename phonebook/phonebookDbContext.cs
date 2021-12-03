using System;
using System.Data.Entity;

namespace phonebook
{
    public class phonebookDbContext : DbContext
    {
        public phonebookDbContext(): base("mssql")
        {
            
        }
        
        public DbSet<Contact> Contacts { get; set; }

        public void Contactos()
        {
            Console.WriteLine("Mi lista de contactos:");
            Console.WriteLine("======================");
            foreach(Contact c in Contacts){
                if (c.Active)
                {
                    Console.WriteLine(c.Name);    
                }
            }
        }

        public void contactosFavoritos()
        {
            Console.WriteLine("Mi contactos favoritos:");
            Console.WriteLine("=======================");
            foreach(Contact c in Contacts){
                if (c.Favorite && c.Active)
                {
                    Console.WriteLine(c.Name);    
                }
            }
        }

        public void contactosEmergencias()
        {
            Console.WriteLine("Mi contactos de emergencia:");
            Console.WriteLine("===========================");
            foreach(Contact c in Contacts){
                if (c.Favorite && c.Active)
                {
                    Console.WriteLine(c.Name);    
                }
            }
        }
        
    }

    
}