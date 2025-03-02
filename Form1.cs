using System;
using System.Windows.Forms;

namespace tp3_1302204032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            outputLabel.Text = $"Halo {input}";
        }
    }
}
