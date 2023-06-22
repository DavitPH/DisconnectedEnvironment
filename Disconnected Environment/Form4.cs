using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'disconnected_EnvironmentDataSet.Status_Mahasiswa' table. You can move, or remove it, as needed.
            this.status_MahasiswaTableAdapter.Fill(this.disconnected_EnvironmentDataSet.Status_Mahasiswa);

        }
    }
}
