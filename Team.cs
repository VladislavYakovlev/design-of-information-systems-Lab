using LabaLuk.TestDataSetTableAdapters;
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
        public partial class Team : Form
        {
            public Team()
            {
                InitializeComponent();
            }
            private void buttonBackToMain_Click(object sender, EventArgs e)
            {
                Main form = new Main();
                this.Hide();
                form.ShowDialog();
            }

            private void Team_Load(object sender, EventArgs e)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.TableTeam". При необходимости она может быть перемещена или удалена.
                this.tableTeamTableAdapter.Fill(this.testDataSet.TableTeam);

            }
            private void buttonUpdateTeam_Click(object sender, EventArgs e)
            {
                tableTeamTableAdapter.Update(testDataSet);
            }

            private void buttonGoToAdd_Click(object sender, EventArgs e)
            {
                AddTeam af = new AddTeam();
                af.Owner = this;
                af.Show();
            }

        }
    }


