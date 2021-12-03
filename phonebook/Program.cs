using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using phonebook.Migrations;

namespace phonebook
{
    internal class Program
    {
        public void nuevoContacto(ref phonebookDbContext db)
        {
            Contact c = new Contact();
            c.definirContacto();
            db.Contacts.Add(c); 
            db.SaveChanges();
            Console.WriteLine("Contacto agendado!!");
        }
        
        public void elegirContacto(ref phonebookDbContext db)
        {
            Console.WriteLine("nombre del contacto");
            var res = Console.ReadLine();
            try
                {
                    var personaEditas = db.Contacts.FirstOrDefault(x => x.Name == res && x.Active == true);
                    Console.WriteLine("usuario encontrado...");
                    Console.WriteLine("nombre:{0}",personaEditas.Name);
                    Console.WriteLine("numero:{0}",personaEditas.Number);
                    Console.WriteLine("favorito:{0}",personaEditas.Favorite);
                    Console.WriteLine("emergencia:{0}",personaEditas.Emergency);
                    Console.WriteLine("===============================");
                    Console.WriteLine("que desea hacer?");
                    Console.WriteLine("1 - eliminar");
                    Console.WriteLine("2 - editar");
                    ConsoleKeyInfo res2;
                    do
                        res2 = Console.ReadKey(true);
                    while (res2.KeyChar < '1' || res2.KeyChar > '2');
                    switch (res2.KeyChar)
                    {
                        case '1':
                            personaEditas.Active = false;
                            db.SaveChanges();
                            Console.WriteLine("contacto eliminado...");
                            break;
                        case '2' :
                            Console.WriteLine("===============================");
                            personaEditas.definirContacto();
                            db.SaveChanges();
                            Console.WriteLine("===============================");
                            Console.WriteLine("Contacto modificado...");
                            break;
                    }

                }catch(NullReferenceException e)
                {
                    Console.WriteLine("el usuario no fue encontrado, intente de nuevo...");
                    this.elegirContacto(ref db);
                }
        }

        public static void Main(string[] args)
        {

            Program p = new Program();
            phonebookDbContext db = new phonebookDbContext();
                
                Console.WriteLine("seleccionar una opcion:");
                Console.WriteLine("1 - mostrar contactos");
                Console.WriteLine("2 - mostrar contactos favoritos");
                Console.WriteLine("3 - mostrar contactos de emergencia");
                Console.WriteLine("4 - agregar un contacto nuevo");
                Console.WriteLine("5 - seleccionar un contacto");
                ConsoleKeyInfo res;
                do
                    res = Console.ReadKey(true);
                while (res.KeyChar < '1' || res.KeyChar > '5');
                
                switch (res.KeyChar)
                {
                    case '1':
                        db.Contactos();
                        break;
                    case '2':
                        db.contactosFavoritos();
                        break;
                    case '3':
                        db.contactosEmergencias();;
                        break;
                    case '4':
                        p.nuevoContacto(ref db);
                        break;
                    case '5':
                        p.elegirContacto(ref db);
                        break;
                }
        }
    }
}