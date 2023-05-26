using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace LabaLuk
{
    public partial class AddMatch : Form
    {

        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MAA00FA\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        public AddMatch()
        {
            InitializeComponent();
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadComboBox()
        {
            string sql = "SELECT * FROM [dbo].[TableTeam]";
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                comboBoxHome.DisplayMember = "name";
                comboBoxHome.DataSource = table;
                

            }
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);            
                comboBoxAway.DisplayMember = "name";
                comboBoxAway.DataSource = table;

            }
        }

        private void AddMatch_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Match main = this.Owner as Match;
            if (main != null)
            {

                DataRow nRow = main.testDataSet1.Tables[0].NewRow();
                if ((comboBoxHome.Text == comboBoxAway.Text))
                {
                    DialogResult dr = MessageBox.Show("Вы ввели одинаковые команды!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }else if((comboBoxHome.Text == "") || (comboBoxAway.Text == "") || (textBoxWinner.Text == ""))
                {
                    DialogResult dr = MessageBox.Show("Вы не заполнили все строчки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nRow[1] = comboBoxHome.Text;
                    nRow[2] = comboBoxAway.Text;
                    nRow[3] = textBoxWinner.Text;
                    main.testDataSet1.Tables[0].Rows.Add(nRow);
                    main.tableMatchTableAdapter.Update(main.testDataSet1.TableMatch);
                    main.testDataSet1.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                    comboBoxHome.Text = "";
                    comboBoxAway.Text = "";
                    textBoxWinner.Text = "";
                }
              
            }
        }
      
    }
}
