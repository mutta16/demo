using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDsistemleri
{
    public partial class uyeRaporPaneli : Form
    {
        public uyeRaporPaneli()
        {
            InitializeComponent();
        }

        private void raporPaneli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AtdSistemleriDatabaseDataSet.PersonelTablosu' table. You can move, or remove it, as needed.
            this.PersonelTablosuTableAdapter.Fill(this.AtdSistemleriDatabaseDataSet.PersonelTablosu);

            this.reportViewer1.RefreshReport();
        }
    }
}
