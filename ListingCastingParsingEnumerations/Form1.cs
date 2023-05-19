using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListingCastingParsingEnumerations
{
    public enum Rating { None, Bad, Okay, Good, Great, Excelent };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListPossibleEnumValues();
        }

        private void ListPossibleEnumValues()
        {
            string[] names = Enum.GetNames(typeof(Rating));
            listBox1.Items.AddRange(names);
        }

        private void btnFromString_Click(object sender, EventArgs e)
        {
            Rating rating;
            Enum.TryParse<Rating>(listBox1.Text, out rating);

            this.Text = rating.ToString();
        }

        private void btnFromInt_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Rating rating = (Rating)index;

            this.Text = rating.ToString();
        }
    }
}
