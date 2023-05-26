namespace Farmacia_UI_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbProgrameStudiu = new System.Windows.Forms.GroupBox();
            this.rdbPraf = new System.Windows.Forms.RadioButton();
            this.rdbPastila = new System.Windows.Forms.RadioButton();
            this.rdbSirop = new System.Windows.Forms.RadioButton();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblProspect = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.txtProspect = new System.Windows.Forms.RichTextBox();
            this.lblFurnizori = new System.Windows.Forms.Label();
            this.ckbMediPlus = new System.Windows.Forms.CheckBox();
            this.ckbFildas = new System.Windows.Forms.CheckBox();
            this.ckbFarmexim = new System.Windows.Forms.CheckBox();
            this.gpbProgrameStudiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbProgrameStudiu
            // 
            this.gpbProgrameStudiu.Controls.Add(this.rdbPraf);
            this.gpbProgrameStudiu.Controls.Add(this.rdbPastila);
            this.gpbProgrameStudiu.Controls.Add(this.rdbSirop);
            this.gpbProgrameStudiu.Location = new System.Drawing.Point(147, 113);
            this.gpbProgrameStudiu.Margin = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Name = "gpbProgrameStudiu";
            this.gpbProgrameStudiu.Padding = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Size = new System.Drawing.Size(277, 77);
            this.gpbProgrameStudiu.TabIndex = 39;
            this.gpbProgrameStudiu.TabStop = false;
            // 
            // rdbPraf
            // 
            this.rdbPraf.AutoSize = true;
            this.rdbPraf.Location = new System.Drawing.Point(20, 39);
            this.rdbPraf.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPraf.Name = "rdbPraf";
            this.rdbPraf.Size = new System.Drawing.Size(59, 21);
            this.rdbPraf.TabIndex = 10;
            this.rdbPraf.TabStop = true;
            this.rdbPraf.Text = "Praf";
            this.rdbPraf.UseVisualStyleBackColor = true;
            // 
            // rdbPastila
            // 
            this.rdbPastila.AutoSize = true;
            this.rdbPastila.Location = new System.Drawing.Point(20, 11);
            this.rdbPastila.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPastila.Name = "rdbPastila";
            this.rdbPastila.Size = new System.Drawing.Size(78, 21);
            this.rdbPastila.TabIndex = 8;
            this.rdbPastila.TabStop = true;
            this.rdbPastila.Text = "Pastila";
            this.rdbPastila.UseVisualStyleBackColor = true;
            // 
            // rdbSirop
            // 
            this.rdbSirop.AutoSize = true;
            this.rdbSirop.Location = new System.Drawing.Point(140, 11);
            this.rdbSirop.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSirop.Name = "rdbSirop";
            this.rdbSirop.Size = new System.Drawing.Size(67, 21);
            this.rdbSirop.TabIndex = 9;
            this.rdbSirop.TabStop = true;
            this.rdbSirop.Text = "Sirop";
            this.rdbSirop.UseVisualStyleBackColor = true;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(43, 127);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(31, 17);
            this.lblTip.TabIndex = 38;
            this.lblTip.Text = "Tip";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(135, 449);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 36;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(287, 483);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(139, 28);
            this.btnAfiseaza.TabIndex = 34;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(147, 71);
            this.txtPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(277, 23);
            this.txtPret.TabIndex = 32;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(147, 36);
            this.txtDenumire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(277, 23);
            this.txtDenumire.TabIndex = 31;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(147, 483);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 28);
            this.btnAdauga.TabIndex = 30;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // lblProspect
            // 
            this.lblProspect.AutoSize = true;
            this.lblProspect.Location = new System.Drawing.Point(43, 220);
            this.lblProspect.Name = "lblProspect";
            this.lblProspect.Size = new System.Drawing.Size(72, 17);
            this.lblProspect.TabIndex = 29;
            this.lblProspect.Text = "Prospect";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(43, 80);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(38, 17);
            this.lblPret.TabIndex = 28;
            this.lblPret.Text = "Pret";
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(43, 44);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(77, 17);
            this.lblDenumire.TabIndex = 27;
            this.lblDenumire.Text = "Denumire";
            // 
            // txtProspect
            // 
            this.txtProspect.Location = new System.Drawing.Point(147, 217);
            this.txtProspect.Name = "txtProspect";
            this.txtProspect.Size = new System.Drawing.Size(279, 125);
            this.txtProspect.TabIndex = 40;
            this.txtProspect.Text = "";
            // 
            // lblFurnizori
            // 
            this.lblFurnizori.AutoSize = true;
            this.lblFurnizori.Location = new System.Drawing.Point(43, 384);
            this.lblFurnizori.Name = "lblFurnizori";
            this.lblFurnizori.Size = new System.Drawing.Size(72, 17);
            this.lblFurnizori.TabIndex = 41;
            this.lblFurnizori.Text = "Furnizori";
            // 
            // ckbMediPlus
            // 
            this.ckbMediPlus.AutoSize = true;
            this.ckbMediPlus.Location = new System.Drawing.Point(167, 383);
            this.ckbMediPlus.Name = "ckbMediPlus";
            this.ckbMediPlus.Size = new System.Drawing.Size(95, 21);
            this.ckbMediPlus.TabIndex = 42;
            this.ckbMediPlus.Text = "MediPlus";
            this.ckbMediPlus.UseVisualStyleBackColor = true;
            // 
            // ckbFildas
            // 
            this.ckbFildas.AutoSize = true;
            this.ckbFildas.Location = new System.Drawing.Point(287, 384);
            this.ckbFildas.Name = "ckbFildas";
            this.ckbFildas.Size = new System.Drawing.Size(73, 21);
            this.ckbFildas.TabIndex = 43;
            this.ckbFildas.Text = "Fildas";
            this.ckbFildas.UseVisualStyleBackColor = true;
            // 
            // ckbFarmexim
            // 
            this.ckbFarmexim.AutoSize = true;
            this.ckbFarmexim.Location = new System.Drawing.Point(167, 424);
            this.ckbFarmexim.Name = "ckbFarmexim";
            this.ckbFarmexim.Size = new System.Drawing.Size(98, 21);
            this.ckbFarmexim.TabIndex = 44;
            this.ckbFarmexim.Text = "Farmexim";
            this.ckbFarmexim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.ckbFarmexim);
            this.Controls.Add(this.ckbFildas);
            this.Controls.Add(this.ckbMediPlus);
            this.Controls.Add(this.lblFurnizori);
            this.Controls.Add(this.txtProspect);
            this.Controls.Add(this.gpbProgrameStudiu);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblProspect);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblDenumire);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbProgrameStudiu.ResumeLayout(false);
            this.gpbProgrameStudiu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbProgrameStudiu;
        private System.Windows.Forms.RadioButton rdbPraf;
        private System.Windows.Forms.RadioButton rdbPastila;
        private System.Windows.Forms.RadioButton rdbSirop;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblProspect;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.RichTextBox txtProspect;
        private System.Windows.Forms.Label lblFurnizori;
        private System.Windows.Forms.CheckBox ckbMediPlus;
        private System.Windows.Forms.CheckBox ckbFildas;
        private System.Windows.Forms.CheckBox ckbFarmexim;
    }
}

