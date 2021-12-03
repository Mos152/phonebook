using System;
namespace phonebook
{
    public class Contact
    {
        public Contact()
        {
            Active = true;
        }
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public bool Favorite { get; set; }
        public bool Emergency { get; set; }

        public void definirContacto()
        {
            Console.WriteLine("defina el contacto nuevo:");
            Console.WriteLine("=========================");
            Console.WriteLine("nombre:");
            this.Name = Console.ReadLine();
            Console.WriteLine("numero:");
            this.Number = Console.ReadLine();
            Console.WriteLine("guardar como favorito? ( 1-yes / 2-no ):");
            ConsoleKeyInfo res;
            do
            {
                res = Console.ReadKey(true);
            } while (res.KeyChar < '1' || res.KeyChar > '2');

            switch (res.KeyChar)
            {
                case '1':
                    this.Favorite = true;
                    break;
                case '2':
                    this.Favorite = false;
                    break;
            }
            
            Console.WriteLine("guardar como contacto de emergencia? (y/n):");
            ConsoleKeyInfo res2;
            do
            {
                res2 = Console.ReadKey(true);
            } while (res2.KeyChar < '1' || res2.KeyChar > '2');
            switch (res2.KeyChar)
            {
                case '1':
                    this.Emergency = true;
                    break;
                case '2':
                    this.Emergency = false;
                    break;
            }
            
            
            
        }

        
        
        
    }
}