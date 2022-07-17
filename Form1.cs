using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //navigate functionn that is custom by us
        private void NavigateToPage() {
            toolStripStatusLabel1.Text = "Searching in progress";
           button1.Enabled = false;
           textBox1.Enabled = false;
            webBrowser3.Navigate(textBox1.Text);
        }


        //display in webroser website by clicking button, website from browser
        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPage(); 


        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           button1.Enabled = true;
           textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Search Done!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        //fire this every single time key is pressed and relased
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter) {
                NavigateToPage();
           }
        }

        private void webBrowser3_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
           if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                 toolStripProgressBar1.ProgressBar.Value = (int) (e.CurrentProgress * 100 / e.MaximumProgress);
           }
            
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e) {
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser was made by Pavol ref. Barnacules");
        }

        private void pleaseReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser is relatively outdated and does not work with modern websites that require advanced scripting like yahoo.com or youtube.com. Please feel free to test it with bing and simple websites.\n\nGuide: type the website's URL address into the URL bar in the format 'https://www.websitename.com'\nThen hit Enter or click Search\n\nHave a nice day, you're a legend for checking out this project!\n\nMade in C# with .NET framework\n\n@Pavol Lantaj 2022\nContact: pavol.lantaj@gmail.com");
        }
    }
}
