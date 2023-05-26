using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Farm;

using Farmacisti;

using NivelStocareDate;


namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicament medicament = new Medicament();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareMedicamente_FisierText adminMedicamenti = new AdministrareMedicamente_FisierText(numeFisier);
            int nrMedicamente = 0;
            adminMedicamenti.GetMedicamente();

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii medicament");
                Console.WriteLine("A. Afisare medicamente");
                Console.WriteLine("F. Afisare medicamente din fisier");
                Console.WriteLine("S. Salvare medicament in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        medicament = CitireMedicamentTastatura(nrMedicamente);
                        nrMedicamente++;
                        break;
                    case "A":
                        string infoMedicament = medicament.Info();
                        Console.WriteLine("Medicamentul {0}", infoMedicament);

                        break;
                    case "F":
                        ArrayList medicamente = adminMedicamenti.GetMedicamente();
                        AfisareMedicamente(medicamente, nrMedicamente);

                        break;
                    case "S":
                        int idMedicament = nrMedicamente + 1;
                        medicament = new Medicament(idMedicament, "Paracetamol", "Pastila", "Fain", 23);
                        //adaugare medicament in fisier
                        adminMedicamenti.AddMedicament(medicament);
                        nrMedicamente++;

                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisareMedicament(Medicament medicament)
        {
            string infoMedicament = string.Format("Medicamentul cu id-ul #{0} are denumirea: {1} {2} {3} {4}",
               medicament.idMedicament,
               medicament.denumire ?? " NECUNOSCUT ",
               medicament.tip ?? " NECUNOSCUT ",
               medicament.prospect ?? " NECUNOSCUT ",
               medicament.pret.ToString() ?? " NECUNOSCUT ");

            Console.WriteLine(infoMedicament);
        }

        public static void AfisareMedicamente(ArrayList medicamente, int nrMedicamente)
        {
            Console.WriteLine("Medicamentele sunt:");
            for (int contor = 0; contor < nrMedicamente; contor++)
            {
                AfisareMedicament((Medicament)medicamente[contor]);
            }
        }

        public static Medicament CitireMedicamentTastatura(int nrMedicamente)
        {

            int idMedicament = nrMedicamente + 1;

            Console.WriteLine("Introdu denumirea medicamentului {0}: ", idMedicament);
            string denumire = Console.ReadLine();
            Console.WriteLine("Introdu tipul medicamentului {0}: ", idMedicament);
            string tip = Console.ReadLine();
            Console.WriteLine("Introdu prospectul medicamentului {0}: ", idMedicament);
            string prospect = Console.ReadLine();
            Console.WriteLine("Introdu pretul medicamentului {0}: ", idMedicament);
            float pret = Convert.ToSingle(Console.ReadLine());
            Medicament medicament = new Medicament(idMedicament, denumire, tip, prospect, pret);

            return medicament;
        }
    }
}
