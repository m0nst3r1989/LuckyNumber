using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbers
{
    public partial class Form2 : Form
    {
        public Form2(int luckyNumber)
        {
            InitializeComponent();
            resultLabel.Text = luckyNumber.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void resultsButton_Click(object sender, EventArgs e)
        {
            // creates a new luckyNumber form
            Form1 luckyNumber = new Form1();
            // hides this from
            this.Hide();
            // shows the luckyNumber form
            luckyNumber.Show();
        }
    }
}
