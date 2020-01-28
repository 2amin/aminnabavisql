using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onlineshopping.Veiw.DBA
{
    public partial class InserProduct : Form
    {
        public InserProduct()
        {
            InitializeComponent();
        }
        public VeiwModel1.Product.ProductVeiwModel Ref_ProductVeiwModel { get; set; }
       public Model.Helper.SpHelper.Product1.Insertproduct InsertProduct { get; set; }
        private void btn_save_Click(object sender, EventArgs e)
        {
            Ref_ProductVeiwModel = new VeiwModel1.Product.ProductVeiwModel();
            InsertProduct = new Model.Helper.SpHelper.Product1.Insertproduct();
            InsertProduct.Productname = txt_Productname.Text;
            InsertProduct.Productunitprice = Convert.ToDecimal(txt_ProductUnitPrice.Text);
            InsertProduct.Productdiscount = Convert.ToDecimal(txt_Productdiscount.Text);
            InsertProduct.ProductStuck = Convert.ToInt32(txt_ProductStock.Text);
            InsertProduct.Supplierid = Convert.ToInt32(txt_Productsupplierid.Text);
            InsertProduct.Categoryid = Convert.ToInt32(txt_Productcategoryid.Text);
            dataGridView1.Rows.Add(InsertProduct.Productname,InsertProduct.Productunitprice,InsertProduct.Productdiscount,InsertProduct.ProductStuck,
                InsertProduct.Supplierid,InsertProduct.Categoryid);
        }
        public List<Model.Helper.SpHelper.Product1.Insertproduct> list_InsertProduct{ get; set; }
        private void btn_saveindatabase_Click(object sender, EventArgs e)
        {


            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("table is empty");
            }
            if (dataGridView1.RowCount != 0)
            {
                InsertProduct = new Model.Helper.SpHelper.Product1.Insertproduct();
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    InsertProduct = new Model.Helper.SpHelper.Product1.Insertproduct();
                    list_InsertProduct = new List<Model.Helper.SpHelper.Product1.Insertproduct>();
                    InsertProduct.Productname = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    InsertProduct.Productunitprice = Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value);
                    InsertProduct.Productdiscount = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    InsertProduct.ProductStuck = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    InsertProduct.Supplierid = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    InsertProduct.Categoryid = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    
                    list_InsertProduct.Add(InsertProduct);
                    MessageBox.Show(Ref_ProductVeiwModel.SaveProduct(list_InsertProduct));

                }

                
           
            }
        }
    }
}
