using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticShop
{
    public partial class AddProductForm : Form
    {

        public  Model1 db { get; set; }
        public Product pr { get; set; }

        public AddProductForm()
        { 
            

            InitializeComponent();
           

        }

        private void AddProduct_button_Click(object sender, EventArgs e)
        {
            pr.Title = titleTextBox.Text;
            pr.Cost = Convert.ToDecimal(costTextBox.Text);
            pr.Description = descriptionTextBox.Text;
            pr.MainImagePath = mainImagePathTextBox.Text;
            pr.IsActive = isActiveCheckBox.Checked;
            pr.ManufacturerID = manufacturerIDComboBox.SelectedIndex;
            db.Product.Add(pr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void AddProduct_Closing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = db.Product.ToList();
            manufacturerBindingSource.DataSource = db.Manufacturer.ToList();
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {

        }
    }
}
