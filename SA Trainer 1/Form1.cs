using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;


namespace SA_Trainer_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buildinfo.Text = "Build version: " + buildversion + "\nBuild Date: " + builddate;
            backgroundWorker1.RunWorkerAsync();
            

        }

        public string buildversion = "1.0";
        public string builddate = "24 Aug 2019";

        

        public Mem m = new Mem();

        public string maxmoney = "999999999";
        public string moneyaddress = "00B7CE50";

        public string maxHealth = "100";
        public string infiniteHealth = "1000";
        public string healthaddress = "0B910628";

        System.Drawing.Color blue = System.Drawing.ColorTranslator.FromHtml("#311B92");
        System.Drawing.Color pink = System.Drawing.ColorTranslator.FromHtml("#E91E63");


        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int pID = m.getProcIDFromName("GTA_SA");
            m.OpenProcess(pID);

            if (processinfo1.Text == "Process INfo")
            {
                processinfo1.Invoke((MethodInvoker)delegate
                {
                    processinfo1.Text = "Open process: GTA_SA.exe";
                });
                processinfo2.Invoke((MethodInvoker)delegate
                {
                    processinfo2.Text = "Process ID: " + pID;
                });
            }
            if(pID > 0)
            {
                processinfo3.ForeColor = blue;
                processinfo3.Invoke((MethodInvoker)delegate { 
                processinfo3.Text = "Process opened";
                });
            }
            else
            {
                processinfo3.ForeColor = pink;
                processinfo3.Invoke((MethodInvoker)delegate {
                    processinfo3.Text = "Process closed";
                });
            }
            moneytext.Invoke((MethodInvoker)delegate
            {
                int moneyint = m.readInt(moneyaddress);

                moneytext.Text = moneyint.ToString();
            });
        }

        private void Moneybtn_Click(object sender, EventArgs e)
        {
            m.writeMemory(moneyaddress, "int", moneytext.Text);
        }

        private void Moneyinfinitecheck_CheckedChanged(object sender, EventArgs e)
        {
          
            if (moneyinfinitecheck.Checked)
            {

                if (moneyinfinitethread.IsBusy) {


                }


                else
                {
                    moneyinfinitethread.RunWorkerAsync();

                }

            }
            else
            {
                moneyinfinitethread.WorkerSupportsCancellation = true;
                moneyinfinitethread.CancelAsync();

                moneychangebtn.Enabled = true;
                moneytext.Enabled = true;

            }


        }

        private void Moneyinfinitethread_DoWork(object sender, DoWorkEventArgs e)
        {
            moneychangebtn.Invoke((MethodInvoker)delegate {
                moneychangebtn.Enabled = false;
            });
            moneytext.Invoke((MethodInvoker)delegate {
                moneytext.Enabled = false;
            });

            while (moneyinfinitecheck.Checked)
            {
                Thread.Sleep(500);
                m.writeMemory(moneyaddress, "int", maxmoney);
                moneytext.Invoke((MethodInvoker)delegate
                {
                    moneytext.Text = maxmoney;

                });

            }

        }

        private void Healthmaxbtn_Click(object sender, EventArgs e)
        {
            m.writeMemory(healthaddress, "float", maxHealth);

        }

        private void Healthinfinitecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (healthinfinitecheck.Checked)
            {
                healthmaxbtn.Invoke((MethodInvoker)delegate
                {
                    healthmaxbtn.Enabled = false;
                });
                if (healthinfinitethread.IsBusy) { }
                else
                {
                    healthinfinitethread.RunWorkerAsync();
                }
            }
            else
            {
                
                healthmaxbtn.Invoke((MethodInvoker)delegate
                {
                    healthmaxbtn.Enabled = true;
                });
                

            }
        }

        private void Healthinfinitethread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (healthinfinitecheck.Checked)
            {
                Thread.Sleep(50);
                float currenthealth = m.readFloat(healthaddress);

                if (currenthealth.ToString() == infiniteHealth) { }
                else
                {
                    m.writeMemory(healthaddress, "float", infiniteHealth);
                }

            }
            m.writeMemory(healthaddress, "float", maxHealth);


        }

        private void Aboutbtn_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Processrestartbtn_Click(object sender, EventArgs e)
        {
            int pID = m.getProcIDFromName("GTA_SA");
            m.OpenProcess(pID);

            if (processinfo1.Text == "Process INfo")
            {
                processinfo1.Invoke((MethodInvoker)delegate
                {
                    processinfo1.Text = "Open process: GTA_SA.exe";
                });
                processinfo2.Invoke((MethodInvoker)delegate
                {
                    processinfo2.Text = "Process ID: " + pID;
                });
            }
            if (pID > 0)
            {
                processinfo3.ForeColor = blue;
                processinfo3.Invoke((MethodInvoker)delegate {
                    processinfo3.Text = "Process opened";
                });
            }
            else
            {
                processinfo3.ForeColor = pink;
                processinfo3.Invoke((MethodInvoker)delegate {
                    processinfo3.Text = "Process closed";
                });
            }

            moneytext.Invoke((MethodInvoker)delegate
            {
                int moneyint = m.readInt(moneyaddress);

                moneytext.Text = moneyint.ToString();
            });
        }

        private void Buildinfo_Click(object sender, EventArgs e)
        {
           
        }
    }
}
