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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void calculateButton_Click(object sender, EventArgs e)
        {
            // try function
            try
            {
                if (int.TryParse(birthYearTextBox.Text, out int year))
                {
                    if (year < DateTime.Today.Year - 119 || year > DateTime.Today.Year)
                    {
                        MessageBox.Show("Enter a valid year.");
                    }
                    if (int.TryParse(birthMonthTextBox.Text, out int month))
                    {
                        if (month > 12 || month < 1)
                        {
                            MessageBox.Show("Enter a valid month (1 - 12).");
                        }
                        if (int.TryParse(birthDayTextBox.Text, out int day))
                        {
                            if (day > 31 || day < 0)
                            {
                                MessageBox.Show("Enter a valid day (1 - 31)");
                            }

                            Year birthYear = new Year
                            {
                                BirthYear = int.Parse(birthYearTextBox.Text)
                            };

                            Month birthMonth = new Month
                            {
                                BirthMonth = int.Parse(birthMonthTextBox.Text)
                            };

                            Day birthDay = new Day
                            {
                                BirthDay = int.Parse(birthDayTextBox.Text)
                            };

                            Color favoriteColor = new Color
                            {
                                FavoriteColor = favoriteColorTextBox.Text.Length
                            };

                           
                            int luckyNumber = Random(
                                birthYear.BirthYear,
                                birthMonth.BirthMonth,
                                birthDay.BirthDay,
                                favoriteColor.FavoriteColor);

                         
                            HideShowForm(luckyNumber);
                        }
                        else
                        {
                            MessageBox.Show("Enter valid birth day (1 - 31).");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter valid birth month (1 - 12).");
                    }
                }
                else
                {
                    MessageBox.Show("Enter valid birth year.");
                }
            }
            // throws Exception message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // random number generator method based on the user input
        public int Random(int year, int month, int day, int color)
        {
            
            const int MIN_VALUE = 0;
            const int MAX_VALUE = 11;

           
            int value = year + month + day + color;

           
            Random random = new Random(value);

            int outputValue = random.Next(MIN_VALUE, MAX_VALUE);

            return outputValue;
        }

        // method to hide this form and show the Results Form
        public void HideShowForm(int luckyNumber)
        {
            // create a new results form
            Form2 results = new Form2(luckyNumber);

            // hides this form
            this.Hide();

            // shows the results form
            results.ShowDialog();
        }
    }
}

