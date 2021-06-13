using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4SOSAPR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> l1 = Config.GetFrequency();
            List<int> l2 = Config.GetTheAmountOfTheDays();
            List<string> l3 = Config.GetTheDayOfTheStart();
            List<decimal> l4 = Config.GetStartUpCapital();
            foreach (int i in l1)
                selectionOfOrdersFrequency.Items.Add(i);
            foreach (int i in l2)
                selectionOfDaysNumbers.Items.Add(i);
            foreach (string i in l3)
                selectionTheDayOfModeling.Items.Add(i);
            foreach (decimal i in l4)
                selectionOfTheStartUpCapital.Items.Add(i);
        }

        private void ClickBtnEnter(object sender, EventArgs e)
        {
            //прогон моделирования по неделям
            for (int i = 0; i < Utils.GetNumberOfWeeks(Int32.Parse(selectionOfDaysNumbers.SelectedValue.ToString())); i++)
            {
                //
            }
        }
    }
}
