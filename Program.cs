using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Farm;

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
                        int idMedicament = nrMedicamente + 1;

                        Console.WriteLine("Introdu denumirea medicamentului {0} : ", idMedicament);
                        string denumire = Console.ReadLine();
                        Console.WriteLine("Introdu tipul medicamentului {0} : ", idMedicament);
                        string tip = Console.ReadLine();
                        Console.WriteLine("Introdu prospectul medicamentului {0} : ", idMedicament);
                        string prospect = Console.ReadLine();
                        Console.WriteLine("Introdu pretul medicamentului {0} : ", idMedicament);
                        float pret = Convert.ToSingle(Console.ReadLine());
                        medicament = new Medicament(idMedicament, denumire, tip, prospect, pret);
                        nrMedicamente++;

                        break;
                    case "A":
                        string infoMedicament = medicament.Info();
                        Console.WriteLine("Medicamentul {0}", infoMedicament);

                        break;
                    case "F":
                        //Medicament[] medicamente = adminMedicamenti.GetMedicamenti(out nrMedicamente);
                        //AfisareMedicamente(medicamente, nrMedicamente);

                        break;
                    case "S":
                        idMedicament = nrMedicamente + 1;
                        nrMedicamente++;
                        medicament = new Medicament(idMedicament, "Ioana", "Radu");
                        //adaugare medicament in fisier
                        adminMedicamenti.AddMedicament(medicament);

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
    }
}
