using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synic_v2
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            this.TopMost = true;
            enabledCheckBox.Checked = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(Features.Macro.AutoClick);
            Thread Mining = new Thread(Features.Mining.Mine);
            backgroundWorker1.RunWorkerAsync();
            Mining.Start();
            AC.Start();

        }
        #region Vars
        public int interval = 1000 / 13;
        public bool enabled = false;
        public bool bindsEnabled = true;
        public bool bindsEnabled2 = true;
        public bool miningEnabled = true;
        public bool rightClicking = false;
        #endregion
        #region UI
        private void cpsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            interval = 1000 / cpsTrackBar.Value;
            Features.Macro.setInterval(1000 / cpsTrackBar.Value);
            cpsLabel.Text = "CPSy (" + cpsTrackBar.Value + "): ";
        }

        private void enabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            enabled = enabledCheckBox.Checked;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ppmMacroCB_CheckedChanged(object sender, EventArgs e)
        {
            rightClicking = ppmMacroCB.Checked;
            if (ppmMacroCB.Checked)
            {
                Features.Macro.enableRMB();
            }
            else
            {
                Features.Macro.disableRMB();
            }
        }

        private void All_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private Point lastPoint;

        private void All_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bindsButton_Click(object sender, EventArgs e)
        {
            bindsPanel.Visible = true;
            macroPanel.Visible = false;
        }

        private void macroButton_Click(object sender, EventArgs e)
        {
            bindsPanel.Visible = false;
            macroPanel.Visible = true;
        }
        private void disableBinds_CheckedChanged(object sender, EventArgs e)
        {
            bindsEnabled2 = disableBinds.Checked;
        }
        #endregion

        #region BackgroundTasks
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        private async void bgTask_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!this.enabled && this.bindsEnabled && this.bindsEnabled2)
                {
                    if (GetAsyncKeyState(Keys.K) < 0)
                    {
                        Features.Binds.FishingRod();
                        Thread.Sleep(5);
                    }
                    else if (GetAsyncKeyState(Keys.V) < 0)
                    {
                        Features.Binds.Punch();
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(20);
                }

                if (!this.enabled && !this.miningEnabled && !Features.Mining.isMining() && this.bindsEnabled2)
                {
                    if (GetAsyncKeyState(Keys.L) < 0)
                    {
                        Features.Mining.startMining();
                        this.miningEnabled = true;
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(20);
                }
                if (!this.enabled && this.miningEnabled && Features.Mining.isMining() && this.bindsEnabled2)
                {
                    if (GetAsyncKeyState(Keys.L) < 0)
                    {
                        Features.Mining.stopMining();
                        this.miningEnabled = false;
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(20);
                }

                if (this.enabled)
                {
                    if (GetAsyncKeyState(Keys.R) < 0)
                    {
                        Features.Macro.disableClicking();
                        this.enabled = false;
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(20);
                }
                if (!this.enabled)
                {
                    if (GetAsyncKeyState(Keys.R) < 0)
                    {
                        Features.Macro.enableClicking();
                        this.enabled = true;
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(20);
                }
            }
            await Task.Delay(1);

        }
        #endregion
    }
}
