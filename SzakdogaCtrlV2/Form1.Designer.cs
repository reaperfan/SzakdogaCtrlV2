namespace SzakdogaCtrlV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timeLbl = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sessionLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.totalHrLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.prevSess = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Idő:";
            // 
            // timeLbl
            // 
            this.timeLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLbl.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.timeLbl.Appearance.Options.UseFont = true;
            this.timeLbl.Appearance.Options.UseForeColor = true;
            this.timeLbl.Location = new System.Drawing.Point(113, 97);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(80, 25);
            this.timeLbl.TabIndex = 1;
            this.timeLbl.Text = "00:00:00";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 262);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(99, 30);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Start";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sessionLbl
            // 
            this.sessionLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sessionLbl.Appearance.ForeColor = System.Drawing.Color.Red;
            this.sessionLbl.Appearance.Options.UseFont = true;
            this.sessionLbl.Appearance.Options.UseForeColor = true;
            this.sessionLbl.Location = new System.Drawing.Point(113, 46);
            this.sessionLbl.Name = "sessionLbl";
            this.sessionLbl.Size = new System.Drawing.Size(80, 25);
            this.sessionLbl.TabIndex = 5;
            this.sessionLbl.Text = "00:00:00";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 25);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Session:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(218, 262);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 29);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // totalHrLbl
            // 
            this.totalHrLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalHrLbl.Appearance.ForeColor = System.Drawing.Color.DarkViolet;
            this.totalHrLbl.Appearance.Options.UseFont = true;
            this.totalHrLbl.Appearance.Options.UseForeColor = true;
            this.totalHrLbl.Location = new System.Drawing.Point(113, 157);
            this.totalHrLbl.Name = "totalHrLbl";
            this.totalHrLbl.Size = new System.Drawing.Size(80, 25);
            this.totalHrLbl.TabIndex = 8;
            this.totalHrLbl.Text = "00:00:00";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 157);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 25);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Órában:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 25);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Előző:";
            // 
            // prevSess
            // 
            this.prevSess.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevSess.Appearance.ForeColor = System.Drawing.Color.DeepPink;
            this.prevSess.Appearance.Options.UseFont = true;
            this.prevSess.Appearance.Options.UseForeColor = true;
            this.prevSess.Location = new System.Drawing.Point(113, 213);
            this.prevSess.Name = "prevSess";
            this.prevSess.Size = new System.Drawing.Size(80, 25);
            this.prevSess.TabIndex = 10;
            this.prevSess.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 304);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.prevSess);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.totalHrLbl);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.sessionLbl);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximumSize = new System.Drawing.Size(336, 336);
            this.MinimumSize = new System.Drawing.Size(336, 336);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szakdoga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl timeLbl;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl sessionLbl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl totalHrLbl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl prevSess;
    }
}

