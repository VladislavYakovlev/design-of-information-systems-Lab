using LabaLuk.TestDataSet1TableAdapters;
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
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
        }

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
        }

        private void Match_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet1.TableMatch". При необходимости она может быть перемещена или удалена.
            this.tableMatchTableAdapter.Fill(this.testDataSet1.TableMatch);

        }

        private void buttonUpdateMatch_Click(object sender, EventArgs e)
        {
            tableMatchTableAdapter.Update(testDataSet1);
        }

        private void buttonGoToAdd_Click(object sender, EventArgs e)
        {
            AddMatch af = new AddMatch();
            af.Owner = this;
            af.Show();
        }

    }
}
