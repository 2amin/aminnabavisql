using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshopping.VeiwModel1.Product
{
   public class ProductVeiwModel
    {
        #region [-Ctor-]
        public ProductVeiwModel()
        {
            Ref_ProductCrud = new Model.DomainModel.POCO.ProductCrud();
        }
        #endregion
        public Model.DomainModel.POCO.ProductCrud Ref_ProductCrud { get; set; }
    
        #region [-SaveProduct(List<Model.Helper.SpHelper.Product1.Insertproduct> InsertProducts)-]
        public string SaveProduct(List<Model.Helper.SpHelper.Product1.Insertproduct> InsertProducts)
        {
          
            return Ref_ProductCrud.InsertProduct(InsertProducts);
        }
        #endregion
        #region [-UpdateProduct(List<Model.Helper.SpHelper.Product1.UpdatProduct> listupdeteproduct)-]
        public void UpdateProduct(List<Model.Helper.SpHelper.Product1.UpdatProduct> listupdeteproduct)
        {
            Ref_ProductCrud.UpdateProduct(listupdeteproduct);

        }
        #endregion
        #region [-RefereshProduct(string name)-]
        public List<Model.Helper.SpHelper.Product1.Getproducthelper> RefereshProduct(string name)
        {
            return Ref_ProductCrud.Select(name);
        }
    } 
    #endregion
}
