using System.Windows.Forms;
using MusicalInstrumentLocator.Models;
using System;


namespace MusicalInstrumentLocator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            // Get instruments and prices
            string[] instruments = txtInstrument.Text.Split(',');
            string[] prices = txtPrice.Text.Split(',');

            if (instruments.Length != prices.Length || instruments.Length > 4)
            {
                MessageBox.Show("Enter max 4 instruments and matching prices.");
                return;
            }

            Store store = new Store
            {
                StoreName = txtStoreName.Text.Trim(),
                Location = txtStoreLocation.Text.Trim(),
                Position = Graph.GetPositionFromLocation(txtStoreLocation.Text)
            };

            // Optional: assign random color
            Random rnd = new Random();
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Brown, Color.DarkCyan };
            store.StoreColor = colors[rnd.Next(colors.Length)];

            // Add instruments
            for (int i = 0; i < instruments.Length; i++)
            {
                if (!double.TryParse(prices[i], out double price))
                {
                    MessageBox.Show($"Invalid price for {instruments[i]}");
                    return;
                }

                store.Instruments.Add(new Instrument
                {
                    Name = instruments[i].Trim().ToLower(),
                    Price = price
                });
            }

            Graph.Stores.Add(store);

            MessageBox.Show("Store added successfully!");

            // Clear inputs
            txtStoreName.Clear();
            txtStoreLocation.Clear();
            txtInstrument.Clear();
            txtPrice.Clear();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInstrument_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStoreName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStoreLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
