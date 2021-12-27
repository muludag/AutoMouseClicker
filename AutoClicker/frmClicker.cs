using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class frmClicker : Form
    {
        Random rand = new Random();
        System.Windows.Forms.Timer mytimer = new System.Windows.Forms.Timer();

        public frmClicker()
        {
            InitializeComponent();
            txtLocX.KeyPress += txtbx_KeyPress;
            txtLocY.KeyPress += txtbx_KeyPress;
            mytimer.Tick += new EventHandler(TimerEventProcessor);
        }

        delegate void UpdateMouseCoords(string xCord, string yCord);
        Thread mouseCoordinateThread = null;
        private void UpdateMouseCoordLabel(int ms)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(ms);

                UpdateMouseCoords updateMouseCoordInvoker = new UpdateMouseCoords(SetMouseCoordLabels);

                string currentXCoord = Cursor.Position.X.ToString();
                string currentYCoord = Cursor.Position.Y.ToString();

                try
                {
                    this.Invoke(updateMouseCoordInvoker, new object[] { currentXCoord, currentYCoord });
                }
                catch (Exception) { };
            }
        }

        private void SetMouseCoordLabels(string xPos, string yPos)
        {
            this.txtLocX.Text = xPos;
            this.txtLocY.Text = yPos;
        }

        private void ChkTopmost_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTopmost.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void BtnLocateFinder_Click(object sender, EventArgs e)
        {
            this.KeyUp += FrmClicker_KeyUp;
            this.ActiveControl = null;

            //Mouse coordinate
            mouseCoordinateThread = new Thread(() => UpdateMouseCoordLabel(100));
            mouseCoordinateThread.IsBackground = true;
            mouseCoordinateThread.Start();
            txtLocX.BackColor = Color.White;
            txtLocY.BackColor = Color.White;
        }

        private void FrmClicker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (mouseCoordinateThread.IsBackground)
                {
                    mouseCoordinateThread.Abort();
                }
                SetMouseCoordLabels(Cursor.Position.X.ToString(), Cursor.Position.Y.ToString());
                txtLocX.BackColor = Color.LightGreen;
                txtLocY.BackColor = Color.LightGreen;
                this.KeyUp -= FrmClicker_KeyUp;
            }
        }

        private void txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            int delay = 0;
            int randomdelay = 0;
            try
            {
                delay = Int32.Parse(txtdelay.Text);
                randomdelay = Int32.Parse(txtrandomdelay.Text);
            }
            catch (Exception)
            {
                throw;
            }
            if (delay == 0)
            {
                delay = 1000;
            }
            if (mytimer.Enabled==true)
            {
                mytimer.Enabled = false;
                mytimer.Stop();
                btnRun.Text = "START";

            }
            else
            {
                int fortimerinterval = rand.Next(1000, 3000);
                mytimer.Interval = fortimerinterval;
                mytimer.Enabled = true;
                mytimer.Start();
                btnRun.Text = "STOP";
            }

        }
        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            int delay = 0;
            int randomdelay = 0;
            int posx = 0;
            int posy = 0;
            try
            {
                delay = Int32.Parse(txtdelay.Text);
                randomdelay = Int32.Parse(txtrandomdelay.Text);
                posx = Int32.Parse(txtLocX.Text);
                posy = Int32.Parse(txtLocY.Text);
            }
            catch (Exception)
            {
                throw;
            }
            if (delay == 0)
            {
                delay = 1000;
            }
            int fortimerinterval = rand.Next(delay, delay + randomdelay);
            mytimer.Interval = fortimerinterval;
            LeftMouseClick(posx, posy);
        }

        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

    }
}