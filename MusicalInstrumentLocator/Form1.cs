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

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show(
                    "Invalid price. Please enter a number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning

                );
                txtPrice.Focus();
                return;
            }


            Store store = new Store
            {
                StoreName = txtStoreName.Text.Trim(),
                Location = txtStoreLocation.Text.Trim(),
                Instrument = txtInstrument.Text.Trim().ToLower(),
                Price = price,

                //  VERY IMPORTANT
                Position = Graph.GetPositionFromLocation(txtStoreLocation.Text)
            };
            Random rnd = new Random();

            Color[] colors =
            {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Orange,
            Color.Purple,
            Color.Brown,
            Color.DarkCyan
            };

            store.StoreColor = colors[rnd.Next(colors.Length)];

            Instrument instrument = new Instrument
            {
                Name = txtInstrument.Text,

                Price = price


            };

            store.Instruments.Add(instrument);
            Graph.Stores.Add(store);

            MessageBox.Show(" Successfully Added :) ");

            // RESET TEXTBOXES
            txtStoreName.Clear();
            txtStoreLocation.Clear();
            txtInstrument.Clear();
            txtPrice.Clear();

            Random rand = new Random();
            const int MAP_MARGIN = 20;


            int x = rnd.Next(
                MAP_MARGIN,
                 Graph.MapWidth - MAP_MARGIN
            );

            int y = rnd.Next(
                MAP_MARGIN,
                Graph.MapWidth - MAP_MARGIN
            );

            store.Position = new Point(x, y);

            store.Instrument = txtInstrument.Text.Trim();
            store.Price = price;


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
    }
}
