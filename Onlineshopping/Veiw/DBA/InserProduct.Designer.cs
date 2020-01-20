namespace Onlineshopping.Veiw.DBA
{
    partial class InserProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Productname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_ProductStock = new System.Windows.Forms.TextBox();
            this.txt_Productdiscount = new System.Windows.Forms.TextBox();
            this.txt_ProductUnitPrice = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Productcategoryid = new System.Windows.Forms.TextBox();
            this.txt_Productsupplierid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Productname
            // 
            this.txt_Productname.Location = new System.Drawing.Point(78, 9);
            this.txt_Productname.Name = "txt_Productname";
            this.txt_Productname.Size = new System.Drawing.Size(203, 22);
            this.txt_Productname.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_ProductStock
            // 
            this.txt_ProductStock.Location = new System.Drawing.Point(78, 93);
            this.txt_ProductStock.Name = "txt_ProductStock";
            this.txt_ProductStock.Size = new System.Drawing.Size(203, 22);
            this.txt_ProductStock.TabIndex = 4;
            // 
            // txt_Productdiscount
            // 
            this.txt_Productdiscount.Location = new System.Drawing.Point(78, 65);
            this.txt_Productdiscount.Name = "txt_Productdiscount";
            this.txt_Productdiscount.Size = new System.Drawing.Size(203, 22);
            this.txt_Productdiscount.TabIndex = 3;
            // 
            // txt_ProductUnitPrice
            // 
            this.txt_ProductUnitPrice.Location = new System.Drawing.Point(78, 37);
            this.txt_ProductUnitPrice.Name = "txt_ProductUnitPrice";
            this.txt_ProductUnitPrice.Size = new System.Drawing.Size(203, 22);
            this.txt_ProductUnitPrice.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(313, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(246, 61);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save Product";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "UnitPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock";
            // 
            // txt_Productcategoryid
            // 
            this.txt_Productcategoryid.Location = new System.Drawing.Point(78, 149);
            this.txt_Productcategoryid.Name = "txt_Productcategoryid";
            this.txt_Productcategoryid.Size = new System.Drawing.Size(203, 22);
            this.txt_Productcategoryid.TabIndex = 6;
            // 
            // txt_Productsupplierid
            // 
            this.txt_Productsupplierid.Location = new System.Drawing.Point(78, 121);
            this.txt_Productsupplierid.Name = "txt_Productsupplierid";
            this.txt_Productsupplierid.Size = new System.Drawing.Size(203, 22);
            this.txt_Productsupplierid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Supplierid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoryid";
            // 
            // InserProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Productsupplierid);
            this.Controls.Add(this.txt_Productcategoryid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_ProductUnitPrice);
            this.Controls.Add(this.txt_Productdiscount);
            this.Controls.Add(this.txt_ProductStock);
            this.Controls.Add(this.txt_Productname);
            this.Name = "InserProduct";
            this.Text = "InserProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Productname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_ProductStock;
        private System.Windows.Forms.TextBox txt_Productdiscount;
        private System.Windows.Forms.TextBox txt_ProductUnitPrice;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Productcategoryid;
        private System.Windows.Forms.TextBox txt_Productsupplierid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}