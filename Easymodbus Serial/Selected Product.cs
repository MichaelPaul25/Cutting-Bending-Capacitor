using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easymodbus_Serial
{
    public partial class Selected_Product : Form
    {
        public Selected_Product()
        {
            InitializeComponent();
        }
        public string product
        {
            get; set;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.product = cb_product.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Selected_Product_Load(object sender, EventArgs e)
        {
            string[] product_list = File_Handler.PopulateProduct();
            cb_product.Items.Clear();
            cb_product.Items.AddRange(product_list);
        }
    }
}
