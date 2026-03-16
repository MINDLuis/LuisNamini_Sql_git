using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//hallo
namespace LuisNamini_Sql_git
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private WorkshopController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new WorkshopController();
        }

        private void btnSpeichern_Click(object sender, System.EventArgs e)
        {
            controller.WorkshopSpeichern(
                int.Parse(txtNr.Text),
                txtTitel.Text,
                int.Parse(txtKosten.Text),
                txtBeschreibung.Text,
                txtVoraussetzungen.Text,
                int.Parse(txtTeilnehmerMin.Text),
                int.Parse(txtTeilnehmerMax.Text),
                txtSchwerpunkt.Text
            );

            txtNr.Clear();
            txtTitel.Clear();
            txtKosten.Clear();
            txtBeschreibung.Clear();
            txtVoraussetzungen.Clear();
            txtTeilnehmerMin.Clear();
            txtTeilnehmerMax.Clear();
            txtSchwerpunkt.Clear();
        }

        private void btnLaden_Click(object sender, System.EventArgs e)
        {
            listWorkshops.Items.Clear();
            var liste = controller.LadeWorkshops();
            foreach (Workshop w in liste)
            {
                listWorkshops.Items.Add(
                    $"Nr:{w.Nr}, Titel:{w.Titel}, Kosten:{w.Kosten}, Teilnehmer:{w.TeilnehmerMin}-{w.TeilnehmerMax}, Schwerpunkt:{w.Schwerpunkt}"
                );
            }
        }
    }
}
