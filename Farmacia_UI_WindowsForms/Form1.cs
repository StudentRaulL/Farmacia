using Farm;
using Farm.Enumerari;
using NivelStocareDate;
using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Farmacia_UI_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareMedicamente_FisierText adminMedicamente;

        private Label lblHeaderDenumire;
        private Label lblHeaderTip;
        private Label lblHeaderFurnizori;
        private Label lblHeaderPret;

        private Label[] lblsDenumire;
        private Label[] lblsTip;
        private Label[] lblsFurnizori;
        private Label[] lblsPret;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
	    private const int OFFSET_X = 600;
        string caleCompletaFisier;

        ArrayList furnizoriSelectati = new ArrayList();

        public Form1()
        {
            string numeFisier = ConfigurationManager.AppSettings["DenumireFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMedicamente = new AdministrareMedicamente_FisierText(caleCompletaFisier);
            InitializeComponent();
            
            //setare proprietati
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Informatii medicamente";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaMedicamente();
        }

        public void CautaMedicament(string denumire)
        {

            bool found = false;
            using (StreamReader streamReader = new StreamReader(caleCompletaFisier))
            {
                string linieFisier;

                // citeste cate o linie si verifica daca numele cautat se potriveste
                // cu cel al produsului din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Medicament medicament = new Medicament(linieFisier);
                    if (medicament.denumire == denumire)
                    {
                        MessageBox.Show(medicament.Info());
                        found = true;
                    }
                }
            }
            if(!found)
            MessageBox.Show("Medicamentul nu a fost gasit");
        }

        private void AfiseazaMedicamente()
        {
            this.Height = 700;
            //adaugare control de tip Label pentru 'Denumire';
            lblHeaderDenumire = new Label();
            lblHeaderDenumire.Width = LATIME_CONTROL;
            lblHeaderDenumire.Text = "Denumire";
            lblHeaderDenumire.Left = OFFSET_X + 0;
            lblHeaderDenumire.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderDenumire);

            //adaugare control de tip Label pentru 'Tip';
            lblHeaderTip = new Label();
            lblHeaderTip.Width = LATIME_CONTROL;
            lblHeaderTip.Text = "Tip";
            lblHeaderTip.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderTip.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderTip);

            //adaugare control de tip Label pentru 'Pret';
            lblHeaderPret = new Label();
            lblHeaderPret.Width = LATIME_CONTROL;
            lblHeaderPret.Text = "Pret";
            lblHeaderPret.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderPret.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderPret);

            //adaugare control de tip Label pentru 'Furnizori';
            lblHeaderFurnizori = new Label();
            lblHeaderFurnizori.Width = LATIME_CONTROL;
            lblHeaderFurnizori.Text = "Furnizori";
            lblHeaderFurnizori.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderFurnizori.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderFurnizori);

            ArrayList medicamente = adminMedicamente.GetMedicamente();

            int nrMedicamente = medicamente.Count;
            lblsDenumire = new Label[nrMedicamente];
            lblsTip = new Label[nrMedicamente];
            lblsFurnizori = new Label[nrMedicamente];
            lblsPret = new Label[nrMedicamente];

            int i = 0;
            foreach (Medicament medicament in medicamente)
            {
                //adaugare control de tip Label pentru denumirea medicamentelor;
                lblsDenumire[i] = new Label();
                lblsDenumire[i].Width = LATIME_CONTROL;
                lblsDenumire[i].Text = medicament.denumire;
                lblsDenumire[i].Left = OFFSET_X + 0;
                lblsDenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDenumire[i]);

                //adaugare control de tip Label pentru tipul medicamentelor
                lblsTip[i] = new Label();
                lblsTip[i].Width = LATIME_CONTROL;
                lblsTip[i].Text = medicament.tip;
                lblsTip[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsTip[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTip[i]);

                //adaugare control de tip Label pentru pretul medicamentelor
                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = medicament.pret.ToString();
                lblsPret[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsPret[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPret[i]);

                //adaugare control de tip Label pentru furnizorii medicamentelor
                lblsFurnizori[i] = new Label();
                lblsFurnizori[i].Width = LATIME_CONTROL;
                lblsFurnizori[i].Text = string.Join(",", (string[])medicament.furnizori.ToArray(Type.GetType("System.String")));
                lblsFurnizori[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsFurnizori[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsFurnizori[i]);
                i++;
            }
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValideProspect())
            {
                lblProspect.ForeColor = Color.Red;

                return;
            }
            if (!DateIntrareValidePret())
            {
                lblPret.ForeColor = Color.Red;

                return;
            }
            if (!DateIntrareValideDenumire())
            {
                lblDenumire.ForeColor = Color.Red;

                return;
            }

            Tip tipSelectat = GetTipSelectat();
            
            Medicament s = new Medicament(0, txtDenumire.Text, tipSelectat.ToString(), txtProspect.Text, float.Parse(txtPret.Text));

            //set Furnizori
            GetFurnizoriSelectati();
            s.furnizori = furnizoriSelectati;
            adminMedicamente.AddMedicament(s);
            lblMesaj.Text = "Medicamentul a fost adaugat";

            //resetarea controalelor pentru a introduce datele unui medicament nou
            ResetareControale();
        }

        private bool DateIntrareValideProspect()
        {
            string prospect = txtProspect.Text;
            if (prospect.Length > 500 || prospect.Length < 20)
            {
                return false;
            }

            return true;
        }

        private bool DateIntrareValideDenumire()
        {
             string denumire = txtDenumire.Text;
            if (denumire.Length > 30 || denumire.Length < 4)
            {
                 return false;
             }

            return true;
        }
        private bool DateIntrareValidePret()
        {
            string pret = txtPret.Text;
            if (float.TryParse(pret, out float s))
            {
                return true;
            }

            return false;
        }

        private void CkbFurnizori_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string furnizorSelectat = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                furnizoriSelectati.Add(furnizorSelectat);
            else
                furnizoriSelectati.Remove(furnizorSelectat);
        }

        private void ResetareControale()
        {
            txtDenumire.Text = txtProspect.Text = txtPret.Text = string.Empty;

            lblDenumire.ForeColor = lblPret.ForeColor = lblProspect.ForeColor = Color.Green;

            rdbPastila.Checked = false;
            rdbSirop.Checked = false;
            rdbPraf.Checked = false;
            
            ckbMediPlus.Checked = false;
            ckbFildas.Checked = false;
            ckbFarmexim.Checked = false;
           
            furnizoriSelectati.Clear();
            lblMesaj.Text = string.Empty;
        }

        private Tip GetTipSelectat()
        {
            if (rdbPastila.Checked)
                return Tip.Pastila;
            if (rdbSirop.Checked)
                return Tip.Sirop;
            if (rdbPraf.Checked)
                return Tip.Praf;

            return Tip.Pastila;
        }

        private void GetFurnizoriSelectati()
        {
            if (ckbMediPlus.Checked)
                furnizoriSelectati.Add(ckbMediPlus.Text);
            if (ckbFarmexim.Checked)
                furnizoriSelectati.Add(ckbFarmexim.Text);
            if (ckbFildas.Checked)
                furnizoriSelectati.Add(ckbFildas.Text);
        }

        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaMedicamente();
            this.Width = 1200;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            CautaMedicament(txtCauta.Text);
        }
    }
}
