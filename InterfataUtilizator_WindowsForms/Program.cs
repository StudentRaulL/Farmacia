using System;
using System.Windows.Forms;
using System.Windows;
using Farm;
using System.Drawing;

namespace GenerareControaleDinCod
{
    
    class Program
    {
        [STAThread]
        static void Main()
        {
            FormularMedicament form1 = new FormularMedicament();
            form1.Show();
            Application.Run();
        }
    }

    //clasa FormularMedicament este derivata din clasa Form
    public class FormularMedicament : Form
    {
        private int ID = 0;
        private Label lblDenumire;
        private TextBox txtDenumire;

        private Label lblPret;
        private TextBox txtPret;

        private Button btnAdauga;

        public FormularMedicament()
        {
            //setare proprietati
            this.Size = new System.Drawing.Size(400, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "REDIMENSIONEAZA-MA";

            //adaugare control de tip Label pentru 'Lungime';
            lblDenumire= new Label();
            lblDenumire.BackColor = Color.LightYellow;
            this.Controls.Add(lblDenumire);

            //adaugare control de tip TextBox pentru 'Lungime';
            txtDenumire= new TextBox();
            this.Controls.Add(txtDenumire);


            //adaugare control de tip Label pentru 'Pret';
            lblPret = new Label();
            lblPret.Text = "Pret:";
            lblPret.BackColor = Color.LightYellow;
            this.Controls.Add(lblPret);

            //adaugare control de tip TextBox pentru 'Pret'
            txtPret = new TextBox();
            this.Controls.Add(txtPret);

            //adaugare control de tip Button
            btnAdauga = new Button();btnAdauga.Text = "Adauga perimetrul";
            // "Click" este un *event* in clasa Button
            // si poate avea atasat unul sau mai multe handlere de eveniment (adrese de functii)
            // Acesta este motivul utilizarii operatorului +=
            btnAdauga.Click += OnButtonClicked; // numele metodei este utilizat fara ()
                                                    // pentru a indica ca se transmite adresa functiei si nu este un apel de functie
            this.Controls.Add(btnAdauga);

            // adaugare handlere pentru evenimentele SizeChanged si FormClosed ale formei
            this.SizeChanged += OnFormSizeChanged;
            this.FormClosed += OnFormClosed;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // obiectul *sender* este butonul btnAdauga
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button
            // catre subscriber-ul curent care este forma FormularMedicament 
            float pret = float.Parse(txtPret.Text);
            //int _idMedicament, string _denumire, string _tip, string _prospect, float _pret
            Medicament d = new Medicament(ID++, txtDenumire.Text, "pastila", "sanatos", pret);
        }

        private void OnFormSizeChanged(object sender, EventArgs e)
        {
            // obiectul *sender* este FormularMedicament
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului SizeChanged
            // al clasei FormularMedicament catre subscriber-ul curent care este tot forma FormularMedicament 
            txtDenumire.Text = this.Width.ToString();
            txtPret.Text = this.Height.ToString();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
