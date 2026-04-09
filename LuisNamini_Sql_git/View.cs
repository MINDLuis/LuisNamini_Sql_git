using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuisNamini_Sql_git

{
    public partial class View : Form, IView
    {
        private IController controller;

        public View(IController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }







        private void buttonSpeichern_Click_1(object sender, EventArgs e)
        {
            controller.workshopErstellen(titelEinlesen());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSchwerpunkt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLaden_Click_1(object sender, EventArgs e)
        {
            controller.ladeWorkshops();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        public void workshopsAnzeigen(List<Workshop> liste)
        {
            listWorkshops.Items.Clear();

            foreach (var w in liste)
            {
                listWorkshops.Items.Add(w.Titel);
            }
        }

        public int nrEinlesen()
        {
            return int.Parse(textboxNr.Text);
        }

        public string titelEinlesen()
        {
            return textboxTitel.Text;
        }

        public int kostenEinlesen()
        {
            return int.Parse(textboxKosten.Text);
        }

        public string beschreibungEinlesen()
        {
            return textboxBeschreibung.Text;
        }

        public string voraussetzungenEinlesen()
        {
            return textboxVoraussetzungen.Text;
        }

        public int teilnehmerMinEinlesen()
        {
            return int.Parse(textboxTeilnehmerMin.Text);
        }

        public int teilnehmerMaxEinlesen()
        {
            return int.Parse(textboxTeilnehmerMax.Text);
        }

        public string schwerpunktEinlesen()
        {
            return textboxSchwerpunkt.Text;
        }
        public void meldung(string text)
        {
            MessageBox.Show(text);
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {

        }

        private void listWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


