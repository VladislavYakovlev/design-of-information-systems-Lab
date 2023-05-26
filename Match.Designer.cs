namespace LabaLuk
{
    partial class Match
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableMatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new LabaLuk.TestDataSet1();
            this.tableMatchTableAdapter = new LabaLuk.TestDataSet1TableAdapters.TableMatchTableAdapter();
            this.buttonUpdateMatch = new System.Windows.Forms.Button();
            this.buttonGoToAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMain.Location = new System.Drawing.Point(364, 374);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(170, 64);
            this.buttonBackToMain.TabIndex = 3;
            this.buttonBackToMain.Text = "Назад";
            this.buttonBackToMain.UseVisualStyleBackColor = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.homeDataGridViewTextBoxColumn,
            this.awayDataGridViewTextBoxColumn,
            this.winnerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableMatchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // homeDataGridViewTextBoxColumn
            // 
            this.homeDataGridViewTextBoxColumn.DataPropertyName = "home";
            this.homeDataGridViewTextBoxColumn.HeaderText = "home";
            this.homeDataGridViewTextBoxColumn.Name = "homeDataGridViewTextBoxColumn";
            this.homeDataGridViewTextBoxColumn.Width = 150;
            // 
            // awayDataGridViewTextBoxColumn
            // 
            this.awayDataGridViewTextBoxColumn.DataPropertyName = "away";
            this.awayDataGridViewTextBoxColumn.HeaderText = "away";
            this.awayDataGridViewTextBoxColumn.Name = "awayDataGridViewTextBoxColumn";
            this.awayDataGridViewTextBoxColumn.Width = 150;
            // 
            // winnerDataGridViewTextBoxColumn
            // 
            this.winnerDataGridViewTextBoxColumn.DataPropertyName = "winner";
            this.winnerDataGridViewTextBoxColumn.HeaderText = "winner";
            this.winnerDataGridViewTextBoxColumn.Name = "winnerDataGridViewTextBoxColumn";
            this.winnerDataGridViewTextBoxColumn.Width = 150;
            // 
            // tableMatchBindingSource
            // 
            this.tableMatchBindingSource.DataMember = "TableMatch";
            this.tableMatchBindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableMatchTableAdapter
            // 
            this.tableMatchTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdateMatch
            // 
            this.buttonUpdateMatch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateMatch.Location = new System.Drawing.Point(188, 374);
            this.buttonUpdateMatch.Name = "buttonUpdateMatch";
            this.buttonUpdateMatch.Size = new System.Drawing.Size(170, 64);
            this.buttonUpdateMatch.TabIndex = 5;
            this.buttonUpdateMatch.Text = "Обновить";
            this.buttonUpdateMatch.UseVisualStyleBackColor = false;
            this.buttonUpdateMatch.Click += new System.EventHandler(this.buttonUpdateMatch_Click);
            // 
            // buttonGoToAdd
            // 
            this.buttonGoToAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGoToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoToAdd.Location = new System.Drawing.Point(12, 374);
            this.buttonGoToAdd.Name = "buttonGoToAdd";
            this.buttonGoToAdd.Size = new System.Drawing.Size(170, 64);
            this.buttonGoToAdd.TabIndex = 6;
            this.buttonGoToAdd.Text = "Добавить";
            this.buttonGoToAdd.UseVisualStyleBackColor = false;
            this.buttonGoToAdd.Click += new System.EventHandler(this.buttonGoToAdd_Click);
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoToAdd);
            this.Controls.Add(this.buttonUpdateMatch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBackToMain);
            this.Name = "Match";
            this.Text = "Матчи";
            this.Load += new System.EventHandler(this.Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMain;
        public System.Windows.Forms.DataGridView dataGridView1;
        public TestDataSet1 testDataSet1;
        public System.Windows.Forms.BindingSource tableMatchBindingSource;
        public TestDataSet1TableAdapters.TableMatchTableAdapter tableMatchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdateMatch;
        private System.Windows.Forms.Button buttonGoToAdd;
    }
}