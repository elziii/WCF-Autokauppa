using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFAutokauppaApp.ServiceReference1;

namespace WCFAutokauppaApp
{
    public partial class MainMenu : Form
    {
        bool next = false, prev = false;
        int autoId;
        Service1Client service = new Service1Client();
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            MerkitCB();
            PolttoaineCB();
            VariCB();
            autoId = service.GetMinId();
        }

        private void MerkitCB()
        {
            List<AutonMerkki> merkit = service.getAllAutoMakers();
            cbMerkki.DataSource = merkit;
            cbMerkki.DisplayMember = "Merkki1";
            cbMerkki.ValueMember = "ID1";
            MallitCB();
        }

        private void cbMerkki_DropDownClosed(object sender, EventArgs e)
        {
            MallitCB();
        }

        private void MallitCB()
        {
            int autonMerkkiID = (int)cbMerkki.SelectedValue;
            List<AutonMalli> mallit = service.getAutoModels(autonMerkkiID);
            cbMalli.DataSource = mallit;
            cbMalli.DisplayMember = "Auton_mallin_nimi1";
            cbMalli.ValueMember = "ID1";
        }

        private void PolttoaineCB()
        {
            List<Polttoaineet> polttoaineet = service.GetPolttoaine();
            cbPolttoaine.DataSource = polttoaineet;
            cbPolttoaine.DisplayMember = "Polttoaineen_nimi1";
            cbPolttoaine.ValueMember = "ID1";
        }

        private void VariCB()
        {
            List<Varit> varit = service.GetVari();
            cbVarit.DataSource = varit;
            cbVarit.DisplayMember = "Varin_nimi1";
            cbVarit.ValueMember = "ID1";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void testaaTietokantayhteysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (service.TestDatabaseConnection())
            {
                MessageBox.Show("Yhteys toimii");
            }
            else
            {
                MessageBox.Show("Yhteys ei toimi");
            }
        }

        private void btnTietue_Click(object sender, EventArgs e)
        {
            UusiTietue();
        }

        private void UusiTietue()
        {
            cbMerkki.SelectedIndex = 0;
            MallitCB();
            cbPolttoaine.SelectedIndex = 0;
            cbVarit.SelectedIndex = 0;
            tbHinta.Text = null;
            tbMittarilukema.Text = null;
            tbTilavuus.Text = null;
            datePvm.Text = null;
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                Auto auto = new Auto();
                auto.Hinta1 = decimal.Parse(tbHinta.Text);
                auto.Rekisteri_paivamaara1 = DateTime.Parse(datePvm.Text);
                auto.Moottorin_tilavuus1 = decimal.Parse(tbTilavuus.Text);
                auto.Mittarilukema1 = int.Parse(tbMittarilukema.Text);
                auto.AutonMerkkiID1 = (int)cbMerkki.SelectedValue;
                auto.AutonMalliID1 = (int)cbMalli.SelectedValue;
                auto.PolttoaineID1 = (int)cbPolttoaine.SelectedValue;
                auto.VaritID1 = (int)cbVarit.SelectedValue;
                bool onnistuiko = service.saveAuto(auto);
                MessageBox.Show("Auto tallennettu tietokantaan");

            }
            catch
            {
                MessageBox.Show("tarkista kentät");
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (autoId > 1)
            {
                service.DeleteAuto(autoId);
                next = true;
                prev = false;
                Auto auto = service.NextPrevAuto(autoId, next, prev);
                AutonTiedot(auto);
                MessageBox.Show("Auto poistettu");
            }
            else
            {
                MessageBox.Show("Etsi poistettava auto");
            }
        }

        private void AutonTiedot(Auto auto)
        {
            autoId = auto.ID1;
            cbMerkki.SelectedValue = auto.AutonMerkkiID1;
            MallitCB();
            cbMalli.SelectedValue = auto.AutonMalliID1;
            cbPolttoaine.SelectedValue = auto.PolttoaineID1;
            cbVarit.SelectedValue = auto.VaritID1;
            tbMittarilukema.Text = auto.Mittarilukema1.ToString();
            tbTilavuus.Text = auto.Moottorin_tilavuus1.ToString();
            tbHinta.Text = auto.Hinta1.ToString();
            datePvm.Text = auto.Rekisteri_paivamaara1.ToString();
        }

        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            next = true;
            prev = false;
            Auto auto = service.NextPrevAuto(autoId, next, prev);
            AutonTiedot(auto);
        }

        private void btnEdellinen_Click(object sender, EventArgs e)
        {
            prev = true;
            next = false;
            Auto auto = service.NextPrevAuto(autoId, next, prev);
            AutonTiedot(auto);
        }
    }
}
