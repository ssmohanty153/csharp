using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsyncProg
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
            using(StreamReader reader=new StreamReader("C:\\Users\\ssmoh\\Downloads\\topic wise Links.txt"))
            {
                string c = reader.ReadToEnd();
                count = c.Length;
                Thread.Sleep(5000); 

            }
            return count;
        }
        private void btn_TextChanged(object sender, EventArgs e)
        {
            lblCount.Text = "process file request";
            int count = 0;
            lblCount.Text = count.ToString() + "character of file";


        }
    }
}
