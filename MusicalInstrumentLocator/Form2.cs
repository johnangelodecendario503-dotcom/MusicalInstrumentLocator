using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MusicalInstrumentLocator.Models;
using System.Linq;



namespace MusicalInstrumentLocator
{


    public partial class Form2 : Form
    {

        public Form2()

        {
            InitializeComponent();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {

            Graph.InstrumentsToBuy.Clear();

            string[] items = txtInstrumentBuy.Text.Split(',');

            foreach (string item in items)
            {
                if (!string.IsNullOrWhiteSpace(item))
                    Graph.InstrumentsToBuy.Add(item.Trim().ToLower());
            }

            Graph.UserName = txtUserName.Text;
            Graph.UserLocation = txtUserLocation.Text;


            


            Graph.InstrumentsToBuy = txtInstrumentBuy.Text
                .Split(',')
                .Select(x => x.Trim())
                .ToList();

            Graph.UserLocation = txtUserLocation.Text.Trim();
            Graph.UserPosition = Graph.GetPositionFromLocation(Graph.UserLocation);
            // SET USER DATA
            Graph.UserName = txtUserName.Text.Trim();
            Graph.UserLocation = txtUserLocation.Text.Trim();

            // 🔴 THIS IS THE MISSING LINE
            Graph.UserPosition = Graph.GetPositionFromLocation(Graph.UserLocation);


            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
