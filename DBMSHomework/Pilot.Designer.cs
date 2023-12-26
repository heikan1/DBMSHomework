namespace DBMSHomework
{
    partial class Pilot
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
            this.label3 = new System.Windows.Forms.Label();
            this.staffmaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staffboss = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.staffno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pilottype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "boss";
            // 
            // staffmaas
            // 
            this.staffmaas.Location = new System.Drawing.Point(172, 45);
            this.staffmaas.Name = "staffmaas";
            this.staffmaas.Size = new System.Drawing.Size(173, 27);
            this.staffmaas.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "maaş";
            // 
            // staffboss
            // 
            this.staffboss.FormattingEnabled = true;
            this.staffboss.Location = new System.Drawing.Point(172, 78);
            this.staffboss.Name = "staffboss";
            this.staffboss.Size = new System.Drawing.Size(173, 28);
            this.staffboss.TabIndex = 8;
            this.staffboss.SelectedIndexChanged += new System.EventHandler(this.staffboss_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "staff no";
            // 
            // staffno
            // 
            this.staffno.Location = new System.Drawing.Point(172, 12);
            this.staffno.Name = "staffno";
            this.staffno.Size = new System.Drawing.Size(173, 27);
            this.staffno.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "pilot type";
            // 
            // pilottype
            // 
            this.pilottype.FormattingEnabled = true;
            this.pilottype.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.pilottype.Location = new System.Drawing.Point(172, 112);
            this.pilottype.Name = "pilottype";
            this.pilottype.Size = new System.Drawing.Size(173, 28);
            this.pilottype.TabIndex = 14;
            this.pilottype.SelectedIndexChanged += new System.EventHandler(this.pilottype_SelectedIndexChanged);
            // 
            // Pilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(357, 185);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pilottype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffmaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffboss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pilot";
            this.Text = "Pilot";
            this.Load += new System.EventHandler(this.Pilot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        public TextBox staffmaas;
        private Label label2;
        public ComboBox staffboss;
        private Label label1;
        public TextBox staffno;
        private Label label5;
        public ComboBox pilottype;
    }
}