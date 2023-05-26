
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaLuk
{
    public partial class AddTeam : Form
    {

        public AddTeam()
        {
            InitializeComponent();
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            Team main = this.Owner as Team;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[0].NewRow();
                if(textBoxTeamName.Text == "")
                {
                    DialogResult dr = MessageBox.Show("Вы не ввели команду!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                nRow[1] = textBoxTeamName.Text;
                main.testDataSet.Tables[0].Rows.Add(nRow);
                main.tableTeamTableAdapter.Update(main.testDataSet.TableTeam);
                main.testDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBoxTeamName.Text = "";
                }
                

            }
        }
    }
}
