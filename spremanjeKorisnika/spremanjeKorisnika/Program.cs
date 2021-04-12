using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace spremanjeKorisnika
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = "$My Documents/testNiOP";
            if (!Directory.Exists(putanja))
            {
                // Ako ne postoji, kreiramo ga
                Directory.CreateDirectory(putanja);
            }
            string podputanja = "$My Documents/testNiOP/PrezimeImeSystemNiOP.txt";
            if (!Directory.Exists(podputanja))
            {
                // Ako ne postoji, kreiramo ga
                Directory.CreateDirectory(podputanja);
            }
            Console.Write("Unesite Vaše ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite Vaše prezime: ");
            string prezime = Console.ReadLine();
            Console.Write("Unesite vašu godinu rođenja: ");
            int godRod = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite vašu e-mail adresu: ");
            string email = Console.ReadLine();

            StreamWriter sw = new StreamWriter("PrezimeImeSystemNiOP.txt");
            sw.WriteLine("Ime: "+ime, ime);
            sw.WriteLine("Prezime: "+prezime, prezime);
            sw.WriteLine("Godina rođenja"+godRod, godRod);
            sw.WriteLine("E-mail: "+email, email);
            sw.Close();

            Console.ReadKey();



        }
    }
}
