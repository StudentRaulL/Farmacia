using System;

public class Medicament
{
	public Medicament()
	{
		string denumire, tip, prospect;
		float pret;
        //	Constructor fara parametri
        public Medicament()
        {
            denumire = string.Empty;
            pret = 0;
        }

        //	Constructor cu parametri
        public Medicament(string _denumire, string _tip, string _prospect, float _pret)
        {
            denumire = _denumire;
            tip = _tip;
            pret = _pret;
            prospect = _prospect:
        }
    }
}
