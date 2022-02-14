using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbers
{
    public partial class UserInput : Form
    {
        public UserInput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void UserInput_Load(object sender, EventArgs e)
        {
            List<city> cities = new List<city>();
            cities.Add(new city() { ID = 1, Name = "Select City" });
            cities.Add(new city() { ID = 2, Name = "New York"});
            cities.Add(new city() { ID = 3, Name = "San Francisco" });
            cities.Add(new city() { ID = 4, Name = "Los Angeles" });
            cities.Add(new city() { ID = 5, Name = "San Diego" });
            cities.Add(new city() { ID = 6, Name = "Chicago" });
            cities.Add(new city() { ID = 7, Name = "New York" });
            cities.Add(new city() { ID = 8, Name = "Dallas" });
            city_cB.DataSource = cities;
            city_cB.ValueMember = "ID";
            city_cB.DisplayMember = "Name";

        }

        private void city_cB_SelectedIndexChanged(object sender, EventArgs e)
        {
            city obj = city_cB.SelectedItem as city;

        }

        private void Team_cB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }


}
