using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using System.IO;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
          
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                
                    {
                    
                        var youTube = YouTube.Default; // starting point for YouTube actions
                        var video = youTube.GetVideo(textBox1.Text); // gets a Video object with info about the video
                        File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName,video.GetBytes());
                    MessageBox.Show("Done");
                    textBox1.Text = "";
                        
                }
                }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

       
    }
}
