using System;
using System.Collections;

namespace Farm
{
    public class Medicament
    {
        
    private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int DENUMIRE = 1;
        private const int TIP = 2;
        private const int PROSPECT = 3;
        private const int PRET = 4;
        private const int FURNIZORI = 5;

        public string denumire { get; set; }
        public string tip { get; set; }
        public string prospect { get; set; }
        public int idMedicament { get; set; }
        public float pret { get; set; }
        public ArrayList furnizori { get; set; }

        //	Constructor fara parametri
        public Medicament()
        {
            denumire = tip = prospect = string.Empty;
            pret = 0;
            furnizori = new ArrayList();
        }

        //	Constructor cu parametri
        public Medicament(int _idMedicament, string _denumire, string _tip, string _prospect, float _pret)
        {
            idMedicament = _idMedicament;
            denumire = _denumire;
            tip = _tip;
            pret = _pret;
            prospect = _prospect;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Medicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            ArrayList furnizList = new ArrayList();

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idMedicament = Convert.ToInt32(dateFisier[ID]);
            denumire = dateFisier[DENUMIRE];
            tip = dateFisier[TIP];
            pret = Convert.ToSingle(dateFisier[PRET]);
            prospect = dateFisier[PROSPECT];
            furnizList.AddRange(dateFisier[FURNIZORI].Split(','));
            furnizori = furnizList;
        }

        public string Info()
        {
            string info = string.Format("Id:{0} Denumire:{1} Tip: {2} Prospect: {3} Pret: {4}",
                idMedicament.ToString(),
                (denumire ?? " NECUNOSCUT "),
                (tip ?? " NECUNOSCUT "),
                (prospect ?? " NECUNOSCUT "),
                pret);

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                idMedicament.ToString(),
                (denumire ?? " NECUNOSCUT "),
                (tip ?? " NECUNOSCUT "),
                (prospect ?? " NECUNOSCUT "),
                pret,
                string.Join(",", (string[])furnizori.ToArray(Type.GetType("System.String"))));

            return obiectMedicamentPentruFisier;
        }
    }


}
