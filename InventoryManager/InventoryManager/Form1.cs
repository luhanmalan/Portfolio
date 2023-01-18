using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InventoryManagementStudio : Form
    {

        DataTable inventory = new DataTable();
        public InventoryManagementStudio()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            skuTxt.Text = "";
            nameTxt.Text = "";
            priceTxt.Text = "";
            descriptionTxt.Text = "";
            quantityTxt.Text = "";
            categoryBox.SelectedIndex = -1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Save all the values from our fields into variables
            String sku = skuTxt.Text; 
            String name = nameTxt.Text;
            String price = priceTxt.Text;
            String description = descriptionTxt.Text;
            String quantity = quantityTxt.Text;
            String category = (string)categoryBox.SelectedItem;
            
            // Add values to the datatable
            inventory.Rows.Add(sku, name, category, price, description, quantity);

            // Clear fields after save
            newBtn_Click(sender, e);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTxt.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTxt.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTxt.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTxt.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantityTxt.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                String itemToLookFor = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryBox.SelectedIndex = categoryBox.Items.IndexOf(itemToLookFor);
            }
            catch(Exception err)
            {
                Console.WriteLine ("There has been an error" + err);
            }
        }

        private void InventoryManagementStudio_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            inventoryGridView.DataSource = inventory;
        }
    }
}
