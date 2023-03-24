using System;

namespace Farmacisti
{
    public class Farmacist
    {

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int VARSTA = 3;

        private string nume, prenume;
        private int varsta;
        private int idFarmacist;

        //	Constructor fara parametri
        public Farmacist()
        {
            nume = prenume = string.Empty;
            varsta = 0;
        }

        //	Constructor cu parametri
        public Farmacist(int _idFarmacist, string _nume, string _prenume, int _varsta)
        {
            idFarmacist = _idFarmacist;
            nume = _nume;
            prenume = _prenume;
            varsta = _varsta;
        }

        //constructor cu un singur parametru de prenume string care reprezinta o linie dintr-un fisier text
        public Farmacist(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idFarmacist = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
            varsta = Convert.ToInt32(dateFisier[VARSTA]);
        }

        public string Info()
        {
            string info = string.Format("Id:{0} Nume:{1} Prenume: {2} Varsta: {3}",
                idFarmacist.ToString(),
                (nume ?? " NECUNOSCUT "),
                (prenume ?? " NECUNOSCUT "),
                varsta);

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectFarmacistPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idFarmacist.ToString(),
                (nume ?? " NECUNOSCUT "),
                (prenume ?? " NECUNOSCUT "),
                varsta);

            return obiectFarmacistPentruFisier;
        }

        public int GetIdFarmacist()
        {
            return idFarmacist;
        }

        public string GetNume()
        {
            return nume;
        }

        public string GetPrenume()
        {
            return prenume;
        }

        public string GetVarsta()
        {
            return Convert.ToString(varsta);
        }
    }


}
