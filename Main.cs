using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaLuk
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        void ShowChildForm(Main form)
        {
            form.MdiParent = this;
            form.Show();
        }
       
        private void buttonGoToTeam_Click(object sender, EventArgs e)
        {
            Team f = new Team();
            this.Hide();
            f.ShowDialog();
        }

        private void buttonGoToMatch_Click(object sender, EventArgs e)
        {
            Match f = new Match();
            this.Hide();
            f.ShowDialog();
            
        }

    }
}
