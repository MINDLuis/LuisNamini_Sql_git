namespace LuisNamini_Sql_git
{
    partial class View
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxNr = new System.Windows.Forms.TextBox();
            this.textboxTitel = new System.Windows.Forms.TextBox();
            this.textboxKosten = new System.Windows.Forms.TextBox();
            this.textboxBeschreibung = new System.Windows.Forms.TextBox();
            this.textboxVoraussetzungen = new System.Windows.Forms.TextBox();
            this.textboxTeilnehmerMin = new System.Windows.Forms.TextBox();
            this.textboxTeilnehmerMax = new System.Windows.Forms.TextBox();
            this.textboxSchwerpunkt = new System.Windows.Forms.TextBox();
            this.buttonAnlegen = new System.Windows.Forms.Button();
            this.listWorkshops = new System.Windows.Forms.ListBox();
            this.buttonLaden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxNr
            // 
            this.textboxNr.Location = new System.Drawing.Point(47, 265);
            this.textboxNr.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNr.Name = "textboxNr";
            this.textboxNr.Size = new System.Drawing.Size(39, 22);
            this.textboxNr.TabIndex = 0;
            this.textboxNr.TextChanged += new System.EventHandler(this.txtNr_TextChanged);
            // 
            // textboxTitel
            // 
            this.textboxTitel.Location = new System.Drawing.Point(145, 265);
            this.textboxTitel.Margin = new System.Windows.Forms.Padding(4);
            this.textboxTitel.Name = "textboxTitel";
            this.textboxTitel.Size = new System.Drawing.Size(79, 22);
            this.textboxTitel.TabIndex = 1;
            // 
            // textboxKosten
            // 
            this.textboxKosten.Location = new System.Drawing.Point(281, 263);
            this.textboxKosten.Margin = new System.Windows.Forms.Padding(4);
            this.textboxKosten.Name = "textboxKosten";
            this.textboxKosten.Size = new System.Drawing.Size(88, 22);
            this.textboxKosten.TabIndex = 2;
            // 
            // textboxBeschreibung
            // 
            this.textboxBeschreibung.Location = new System.Drawing.Point(409, 263);
            this.textboxBeschreibung.Margin = new System.Windows.Forms.Padding(4);
            this.textboxBeschreibung.Multiline = true;
            this.textboxBeschreibung.Name = "textboxBeschreibung";
            this.textboxBeschreibung.Size = new System.Drawing.Size(132, 45);
            this.textboxBeschreibung.TabIndex = 3;
            // 
            // textboxVoraussetzungen
            // 
            this.textboxVoraussetzungen.Location = new System.Drawing.Point(577, 263);
            this.textboxVoraussetzungen.Margin = new System.Windows.Forms.Padding(4);
            this.textboxVoraussetzungen.Name = "textboxVoraussetzungen";
            this.textboxVoraussetzungen.Size = new System.Drawing.Size(84, 22);
            this.textboxVoraussetzungen.TabIndex = 4;
            // 
            // textboxTeilnehmerMin
            // 
            this.textboxTeilnehmerMin.Location = new System.Drawing.Point(724, 268);
            this.textboxTeilnehmerMin.Margin = new System.Windows.Forms.Padding(4);
            this.textboxTeilnehmerMin.Name = "textboxTeilnehmerMin";
            this.textboxTeilnehmerMin.Size = new System.Drawing.Size(101, 22);
            this.textboxTeilnehmerMin.TabIndex = 5;
            // 
            // textboxTeilnehmerMax
            // 
            this.textboxTeilnehmerMax.Location = new System.Drawing.Point(868, 265);
            this.textboxTeilnehmerMax.Margin = new System.Windows.Forms.Padding(4);
            this.textboxTeilnehmerMax.Name = "textboxTeilnehmerMax";
            this.textboxTeilnehmerMax.Size = new System.Drawing.Size(101, 22);
            this.textboxTeilnehmerMax.TabIndex = 6;
            // 
            // textboxSchwerpunkt
            // 
            this.textboxSchwerpunkt.Location = new System.Drawing.Point(1033, 265);
            this.textboxSchwerpunkt.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSchwerpunkt.Name = "textboxSchwerpunkt";
            this.textboxSchwerpunkt.Size = new System.Drawing.Size(84, 22);
            this.textboxSchwerpunkt.TabIndex = 7;
            this.textboxSchwerpunkt.TextChanged += new System.EventHandler(this.txtSchwerpunkt_TextChanged);
            // 
            // buttonAnlegen
            // 
            this.buttonAnlegen.Location = new System.Drawing.Point(1168, 262);
            this.buttonAnlegen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnlegen.Name = "buttonAnlegen";
            this.buttonAnlegen.Size = new System.Drawing.Size(100, 28);
            this.buttonAnlegen.TabIndex = 8;
            this.buttonAnlegen.Text = "speichern";
            this.buttonAnlegen.UseVisualStyleBackColor = true;
            this.buttonAnlegen.Click += new System.EventHandler(this.buttonSpeichern_Click_1);
            // 
            // listWorkshops
            // 
            this.listWorkshops.FormattingEnabled = true;
            this.listWorkshops.ItemHeight = 16;
            this.listWorkshops.Location = new System.Drawing.Point(47, 370);
            this.listWorkshops.Margin = new System.Windows.Forms.Padding(4);
            this.listWorkshops.Name = "listWorkshops";
            this.listWorkshops.Size = new System.Drawing.Size(159, 116);
            this.listWorkshops.TabIndex = 9;
            this.listWorkshops.SelectedIndexChanged += new System.EventHandler(this.listWorkshops_SelectedIndexChanged);
            // 
            // buttonLaden
            // 
            this.buttonLaden.Location = new System.Drawing.Point(263, 458);
            this.buttonLaden.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLaden.Name = "buttonLaden";
            this.buttonLaden.Size = new System.Drawing.Size(100, 28);
            this.buttonLaden.TabIndex = 10;
            this.buttonLaden.Text = "Laden";
            this.buttonLaden.UseVisualStyleBackColor = true;
            this.buttonLaden.Click += new System.EventHandler(this.buttonLaden_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "nr";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kosten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Beschreibung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Voraussetzungen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(721, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "TeilnehmerMin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "TeilnehmerMax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1029, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Schwerpunkt";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLaden);
            this.Controls.Add(this.listWorkshops);
            this.Controls.Add(this.buttonAnlegen);
            this.Controls.Add(this.textboxSchwerpunkt);
            this.Controls.Add(this.textboxTeilnehmerMax);
            this.Controls.Add(this.textboxTeilnehmerMin);
            this.Controls.Add(this.textboxVoraussetzungen);
            this.Controls.Add(this.textboxBeschreibung);
            this.Controls.Add(this.textboxKosten);
            this.Controls.Add(this.textboxTitel);
            this.Controls.Add(this.textboxNr);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxNr;
        private System.Windows.Forms.TextBox textboxTitel;
        private System.Windows.Forms.TextBox textboxKosten;
        private System.Windows.Forms.TextBox textboxBeschreibung;
        private System.Windows.Forms.TextBox textboxVoraussetzungen;
        private System.Windows.Forms.TextBox textboxTeilnehmerMin;
        private System.Windows.Forms.TextBox textboxTeilnehmerMax;
        private System.Windows.Forms.TextBox textboxSchwerpunkt;
        private System.Windows.Forms.Button buttonAnlegen;
        private System.Windows.Forms.ListBox listWorkshops;
        private System.Windows.Forms.Button buttonLaden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

