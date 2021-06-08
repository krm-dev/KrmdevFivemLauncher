//KrmDev Launcher

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace KrmDevFivemlauncher
{
    public partial class KrmDevLauncher : Form
    {
        int mov;
        int movX;
        int movY;
        public KrmDevLauncher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            foreach (var islem in Process.GetProcessesByName("Fivem"))
                islem.Kill();
            Application.Exit();
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnts_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ts3server://{ts3serverip}/?9987&nickname="); //ts3 server ip yazın. nickname bölümüne de oyuncular =*** yazdığınız nickname ile ts3 e bağlanırlar. 
        }

        private void btndc_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/DAVETLİNK"); //discord davet linkiniz ile değiştirin.
        }

        private void btnoyna_Click(object sender, EventArgs e)
        {
            Process.Start("https://cfx.re/join/SERVERBAĞLANTIURLSİ"); //fivem short urlniz ile değiştirin.
        }
    }
}




//KrmDev Launcher