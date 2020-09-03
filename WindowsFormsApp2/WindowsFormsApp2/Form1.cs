using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int countCharacter()
        {
           
            
            int count = 0;

            using (StreamReader read = new StreamReader(@"C:\Users\ssmoh\Downloads\Training document.txt"))
            {
                string v = read.ReadToEnd();

                count = v.Length;
                Thread.Sleep(10000);
                
            }
            return count;
        }

        private async void processer_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(countCharacter);
            task.Start();
            lblCount.Text = "process file request";
            int count = await task;
            lblCount.Text = count.ToString() + "character of file";
        }
    }
}
