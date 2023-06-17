using Farm;

using System.Collections;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareMedicamente_FisierText
    {
        private const int NR_MAX_MEDICAMENTE = 50;
        private string numeFisier;

        public AdministrareMedicamente_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddMedicament(Medicament medicament)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(medicament.ConversieLaSir_PentruFisier());
            }
        }

        public ArrayList GetMedicamente()
        {
            ArrayList medicamente = new ArrayList();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Medicament
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Medicament medicament = new Medicament(linieFisier);
                    medicamente.Add(medicament);
                }
            }

            return medicamente;
        }
        
    }
}