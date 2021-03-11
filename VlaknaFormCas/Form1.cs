using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VlaknaFormCas.implementace;

namespace VlaknaFormCas
{
    public partial class frmOvladaciPanel : Form

    {
        private Hodiny hod; 
        

        public frmOvladaciPanel(Hodiny hodiny)
        {
            InitializeComponent();
            this.hod = hodiny;
        }


        private void tlKonec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlZobrazuj_Click(object sender, EventArgs e)
        {
           hod.Zobrazuj();

        }

        private void tlNezobrazuj_Click(object sender, EventArgs e)
        {
            hod.Nezobrazuj();

        }
    }
}
