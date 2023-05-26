namespace LabaLuk
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGoToMatch = new System.Windows.Forms.Button();
            this.buttonGoToTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoToMatch
            // 
            this.buttonGoToMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoToMatch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGoToMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoToMatch.Location = new System.Drawing.Point(12, 118);
            this.buttonGoToMatch.Name = "buttonGoToMatch";
            this.buttonGoToMatch.Size = new System.Drawing.Size(330, 64);
            this.buttonGoToMatch.TabIndex = 3;
            this.buttonGoToMatch.Text = "Перейти к матчам";
            this.buttonGoToMatch.UseVisualStyleBackColor = false;
            this.buttonGoToMatch.Click += new System.EventHandler(this.buttonGoToMatch_Click);
            // 
            // buttonGoToTeam
            // 
            this.buttonGoToTeam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGoToTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoToTeam.Location = new System.Drawing.Point(12, 48);
            this.buttonGoToTeam.Name = "buttonGoToTeam";
            this.buttonGoToTeam.Size = new System.Drawing.Size(330, 64);
            this.buttonGoToTeam.TabIndex = 2;
            this.buttonGoToTeam.Text = "Перейти к командам";
            this.buttonGoToTeam.UseVisualStyleBackColor = false;
            this.buttonGoToTeam.Click += new System.EventHandler(this.buttonGoToTeam_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(354, 224);
            this.Controls.Add(this.buttonGoToMatch);
            this.Controls.Add(this.buttonGoToTeam);
            this.Name = "Main";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToMatch;
        private System.Windows.Forms.Button buttonGoToTeam;
    }
}

