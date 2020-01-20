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
        private void btn_save_Click(object sender, EventArgs e)
        {
            Ref_ProductVeiwModel = new VeiwModel1.Product.ProductVeiwModel();
            
            

        }
    }
}
