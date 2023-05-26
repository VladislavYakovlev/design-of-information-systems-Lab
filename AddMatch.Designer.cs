namespace LabaLuk
{
    partial class AddMatch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAway = new System.Windows.Forms.ComboBox();
            this.comboBoxHome = new System.Windows.Forms.ComboBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.labelAway = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCLose = new System.Windows.Forms.Button();
            this.textBoxWinner = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.textBoxWinner);
            this.groupBox1.Controls.Add(this.comboBoxAway);
            this.groupBox1.Controls.Add(this.comboBoxHome);
            this.groupBox1.Controls.Add(this.labelWinner);
            this.groupBox1.Controls.Add(this.labelAway);
            this.groupBox1.Controls.Add(this.labelHome);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // comboBoxAway
            // 
            this.comboBoxAway.FormattingEnabled = true;
            this.comboBoxAway.Location = new System.Drawing.Point(254, 63);
            this.comboBoxAway.Name = "comboBoxAway";
            this.comboBoxAway.Size = new System.Drawing.Size(155, 32);
            this.comboBoxAway.TabIndex = 7;
            // 
            // comboBoxHome
            // 
            this.comboBoxHome.FormattingEnabled = true;
            this.comboBoxHome.Location = new System.Drawing.Point(254, 25);
            this.comboBoxHome.Name = "comboBoxHome";
            this.comboBoxHome.Size = new System.Drawing.Size(155, 32);
            this.comboBoxHome.TabIndex = 6;
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Location = new System.Drawing.Point(6, 98);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(121, 24);
            this.labelWinner.TabIndex = 5;
            this.labelWinner.Text = "Победитель";
            // 
            // labelAway
            // 
            this.labelAway.AutoSize = true;
            this.labelAway.Location = new System.Drawing.Point(6, 63);
            this.labelAway.Name = "labelAway";
            this.labelAway.Size = new System.Drawing.Size(201, 24);
            this.labelAway.TabIndex = 4;
            this.labelAway.Text = "Команда соперников";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Location = new System.Drawing.Point(6, 28);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(184, 24);
            this.labelHome.TabIndex = 3;
            this.labelHome.Text = "Домашняя команда";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(12, 162);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCLose
            // 
            this.buttonCLose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCLose.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCLose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCLose.Location = new System.Drawing.Point(266, 162);
            this.buttonCLose.Name = "buttonCLose";
            this.buttonCLose.Size = new System.Drawing.Size(161, 35);
            this.buttonCLose.TabIndex = 2;
            this.buttonCLose.Text = "Назад";
            this.buttonCLose.UseVisualStyleBackColor = false;
            this.buttonCLose.Click += new System.EventHandler(this.buttonCLose_Click);
            // 
            // textBoxWinner
            // 
            this.textBoxWinner.Location = new System.Drawing.Point(254, 101);
            this.textBoxWinner.Name = "textBoxWinner";
            this.textBoxWinner.Size = new System.Drawing.Size(155, 29);
            this.textBoxWinner.TabIndex = 8;
            // 
            // AddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(432, 201);
            this.Controls.Add(this.buttonCLose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMatch";
            this.Text = "Добавить матч";
            this.Load += new System.EventHandler(this.AddMatch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Label labelAway;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCLose;
        private System.Windows.Forms.ComboBox comboBoxAway;
        private System.Windows.Forms.ComboBox comboBoxHome;
        private System.Windows.Forms.TextBox textBoxWinner;
    }
}