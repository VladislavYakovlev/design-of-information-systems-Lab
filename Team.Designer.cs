namespace LabaLuk
{
    partial class Team
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
            this.buttonGoToAdd = new System.Windows.Forms.Button();
            this.buttonUpdateTeam = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new LabaLuk.TestDataSet();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.tableTeamTableAdapter = new LabaLuk.TestDataSetTableAdapters.TableTeamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGoToAdd
            // 
            this.buttonGoToAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGoToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoToAdd.Location = new System.Drawing.Point(12, 374);
            this.buttonGoToAdd.Name = "buttonGoToAdd";
            this.buttonGoToAdd.Size = new System.Drawing.Size(170, 64);
            this.buttonGoToAdd.TabIndex = 10;
            this.buttonGoToAdd.Text = "Добавить";
            this.buttonGoToAdd.UseVisualStyleBackColor = false;
            this.buttonGoToAdd.Click += new System.EventHandler(this.buttonGoToAdd_Click);
            // 
            // buttonUpdateTeam
            // 
            this.buttonUpdateTeam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateTeam.Location = new System.Drawing.Point(188, 374);
            this.buttonUpdateTeam.Name = "buttonUpdateTeam";
            this.buttonUpdateTeam.Size = new System.Drawing.Size(170, 64);
            this.buttonUpdateTeam.TabIndex = 9;
            this.buttonUpdateTeam.Text = "Обновить";
            this.buttonUpdateTeam.UseVisualStyleBackColor = false;
            this.buttonUpdateTeam.Click += new System.EventHandler(this.buttonUpdateTeam_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableTeamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // tableTeamBindingSource
            // 
            this.tableTeamBindingSource.DataMember = "TableTeam";
            this.tableTeamBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMain.Location = new System.Drawing.Point(364, 374);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(170, 64);
            this.buttonBackToMain.TabIndex = 7;
            this.buttonBackToMain.Text = "Назад";
            this.buttonBackToMain.UseVisualStyleBackColor = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // tableTeamTableAdapter
            // 
            this.tableTeamTableAdapter.ClearBeforeFill = true;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoToAdd);
            this.Controls.Add(this.buttonUpdateTeam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBackToMain);
            this.Name = "Team";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToAdd;
        private System.Windows.Forms.Button buttonUpdateTeam;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBackToMain;
        public TestDataSet testDataSet;
        public System.Windows.Forms.BindingSource tableTeamBindingSource;
        public TestDataSetTableAdapters.TableTeamTableAdapter tableTeamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}