namespace SA_Trainer_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.processinfo1 = new System.Windows.Forms.Label();
            this.processinfo2 = new System.Windows.Forms.Label();
            this.moneylabel = new System.Windows.Forms.Label();
            this.moneytext = new System.Windows.Forms.TextBox();
            this.moneychangebtn = new System.Windows.Forms.Button();
            this.healthlabel = new System.Windows.Forms.Label();
            this.healthmaxbtn = new System.Windows.Forms.Button();
            this.moneyinfinitecheck = new System.Windows.Forms.CheckBox();
            this.moneyinfinitethread = new System.ComponentModel.BackgroundWorker();
            this.healthinfinitecheck = new System.Windows.Forms.CheckBox();
            this.healthinfinitethread = new System.ComponentModel.BackgroundWorker();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.processinfo3 = new System.Windows.Forms.Label();
            this.processrestartbtn = new System.Windows.Forms.Button();
            this.buildinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // processinfo1
            // 
            this.processinfo1.AutoSize = true;
            this.processinfo1.Location = new System.Drawing.Point(13, 13);
            this.processinfo1.Name = "processinfo1";
            this.processinfo1.Size = new System.Drawing.Size(68, 13);
            this.processinfo1.TabIndex = 0;
            this.processinfo1.Text = "Process INfo";
            // 
            // processinfo2
            // 
            this.processinfo2.AutoSize = true;
            this.processinfo2.Location = new System.Drawing.Point(13, 36);
            this.processinfo2.Name = "processinfo2";
            this.processinfo2.Size = new System.Drawing.Size(58, 13);
            this.processinfo2.TabIndex = 1;
            this.processinfo2.Text = "Process iD";
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Location = new System.Drawing.Point(13, 92);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(48, 13);
            this.moneylabel.TabIndex = 2;
            this.moneylabel.Text = "Money =";
            // 
            // moneytext
            // 
            this.moneytext.Location = new System.Drawing.Point(67, 89);
            this.moneytext.Name = "moneytext";
            this.moneytext.Size = new System.Drawing.Size(100, 20);
            this.moneytext.TabIndex = 3;
            // 
            // moneychangebtn
            // 
            this.moneychangebtn.Location = new System.Drawing.Point(182, 86);
            this.moneychangebtn.Name = "moneychangebtn";
            this.moneychangebtn.Size = new System.Drawing.Size(75, 23);
            this.moneychangebtn.TabIndex = 4;
            this.moneychangebtn.Text = "Change";
            this.moneychangebtn.UseVisualStyleBackColor = true;
            this.moneychangebtn.Click += new System.EventHandler(this.Moneybtn_Click);
            // 
            // healthlabel
            // 
            this.healthlabel.AutoSize = true;
            this.healthlabel.Location = new System.Drawing.Point(13, 120);
            this.healthlabel.Name = "healthlabel";
            this.healthlabel.Size = new System.Drawing.Size(47, 13);
            this.healthlabel.TabIndex = 5;
            this.healthlabel.Text = "Health =";
            // 
            // healthmaxbtn
            // 
            this.healthmaxbtn.Location = new System.Drawing.Point(66, 115);
            this.healthmaxbtn.Name = "healthmaxbtn";
            this.healthmaxbtn.Size = new System.Drawing.Size(75, 23);
            this.healthmaxbtn.TabIndex = 8;
            this.healthmaxbtn.Text = "Max";
            this.healthmaxbtn.UseVisualStyleBackColor = true;
            this.healthmaxbtn.Click += new System.EventHandler(this.Healthmaxbtn_Click);
            // 
            // moneyinfinitecheck
            // 
            this.moneyinfinitecheck.AutoSize = true;
            this.moneyinfinitecheck.Location = new System.Drawing.Point(263, 90);
            this.moneyinfinitecheck.Name = "moneyinfinitecheck";
            this.moneyinfinitecheck.Size = new System.Drawing.Size(57, 17);
            this.moneyinfinitecheck.TabIndex = 10;
            this.moneyinfinitecheck.Text = "Infinite";
            this.moneyinfinitecheck.UseVisualStyleBackColor = true;
            this.moneyinfinitecheck.CheckedChanged += new System.EventHandler(this.Moneyinfinitecheck_CheckedChanged);
            // 
            // moneyinfinitethread
            // 
            this.moneyinfinitethread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Moneyinfinitethread_DoWork);
            // 
            // healthinfinitecheck
            // 
            this.healthinfinitecheck.AutoSize = true;
            this.healthinfinitecheck.Location = new System.Drawing.Point(147, 119);
            this.healthinfinitecheck.Name = "healthinfinitecheck";
            this.healthinfinitecheck.Size = new System.Drawing.Size(57, 17);
            this.healthinfinitecheck.TabIndex = 11;
            this.healthinfinitecheck.Text = "Infinite";
            this.healthinfinitecheck.UseVisualStyleBackColor = true;
            this.healthinfinitecheck.CheckedChanged += new System.EventHandler(this.Healthinfinitecheck_CheckedChanged);
            // 
            // healthinfinitethread
            // 
            this.healthinfinitethread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Healthinfinitethread_DoWork);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Location = new System.Drawing.Point(537, 338);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(75, 23);
            this.aboutbtn.TabIndex = 12;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.Aboutbtn_Click);
            // 
            // processinfo3
            // 
            this.processinfo3.AutoSize = true;
            this.processinfo3.ForeColor = System.Drawing.Color.Red;
            this.processinfo3.Location = new System.Drawing.Point(179, 13);
            this.processinfo3.Name = "processinfo3";
            this.processinfo3.Size = new System.Drawing.Size(80, 13);
            this.processinfo3.TabIndex = 13;
            this.processinfo3.Text = "Process Closed";
            // 
            // processrestartbtn
            // 
            this.processrestartbtn.Location = new System.Drawing.Point(288, 8);
            this.processrestartbtn.Name = "processrestartbtn";
            this.processrestartbtn.Size = new System.Drawing.Size(75, 23);
            this.processrestartbtn.TabIndex = 14;
            this.processrestartbtn.Text = "Check again";
            this.processrestartbtn.UseVisualStyleBackColor = true;
            this.processrestartbtn.Click += new System.EventHandler(this.Processrestartbtn_Click);
            // 
            // buildinfo
            // 
            this.buildinfo.AutoSize = true;
            this.buildinfo.Location = new System.Drawing.Point(12, 326);
            this.buildinfo.Name = "buildinfo";
            this.buildinfo.Size = new System.Drawing.Size(46, 13);
            this.buildinfo.TabIndex = 15;
            this.buildinfo.Text = "buildinfo";
            this.buildinfo.Click += new System.EventHandler(this.Buildinfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 373);
            this.Controls.Add(this.buildinfo);
            this.Controls.Add(this.processrestartbtn);
            this.Controls.Add(this.processinfo3);
            this.Controls.Add(this.aboutbtn);
            this.Controls.Add(this.healthinfinitecheck);
            this.Controls.Add(this.moneyinfinitecheck);
            this.Controls.Add(this.healthmaxbtn);
            this.Controls.Add(this.healthlabel);
            this.Controls.Add(this.moneychangebtn);
            this.Controls.Add(this.moneytext);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.processinfo2);
            this.Controls.Add(this.processinfo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GTA SA Trainer 1.0 - Shahriar - Dark Chokolate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label processinfo1;
        private System.Windows.Forms.Label processinfo2;
        private System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.TextBox moneytext;
        private System.Windows.Forms.Button moneychangebtn;
        private System.Windows.Forms.Label healthlabel;
        private System.Windows.Forms.Button healthmaxbtn;
        private System.Windows.Forms.CheckBox moneyinfinitecheck;
        private System.ComponentModel.BackgroundWorker moneyinfinitethread;
        private System.Windows.Forms.CheckBox healthinfinitecheck;
        private System.ComponentModel.BackgroundWorker healthinfinitethread;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Label processinfo3;
        private System.Windows.Forms.Button processrestartbtn;
        private System.Windows.Forms.Label buildinfo;
    }
}

