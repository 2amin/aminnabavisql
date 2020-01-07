using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onlineshopping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Model.Helper.SpHelper.Category.Getcategoryhelper> list_category = new List<Model.Helper.SpHelper.Category.Getcategoryhelper>();

        private void Form1_Load(object sender, EventArgs e)
        {
            list_category = Model.DomainModel.POCO.CategoryCrud.Select();
            for (int i = 0; i < list_category.Count; i++)
            {
                comboBox1.Items.Add(list_category[i].Categoryname);
            }

        }
      
        private void btn_click_Click(object sender, EventArgs e)
        {
       


            dataGridView1.DataSource = Model.DomainModel.POCO.ProductCrud.Select(comboBox1.Text);

        }
    }
}
