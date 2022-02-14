using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Krabber_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = linktxt.Text;
            int index = input.LastIndexOf("/");
            int name_length = input.Length;
           
            string output = input.Substring(input.LastIndexOf('/')+1);
            string final=input.Substring(input.LastIndexOf('_')+1);
     
            while (output[(output.Length-1)].ToString() != "_")
            {
                output = output.Remove(output.Length - 1, 1);
                input = input.Remove(input.Length - 1, 1);
            }
            output = output.Remove(output.Length - 1, 1);
            label4.Text = output;


            int start = Int32.Parse(starttxt.Text);
            int stop = Int32.Parse(stoptxt.Text);
            while (start <= stop)
            {
                using (var client = new WebClient())
                {
                    label4.Text = input.Substring(input.LastIndexOf('_')+1);
                    client.DownloadFile(input + start,filelocal.Text+@"\"+output+"_"+ start+".cbr");
                }
                start++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); ;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             filelocal.Text = fbd.SelectedPath;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
