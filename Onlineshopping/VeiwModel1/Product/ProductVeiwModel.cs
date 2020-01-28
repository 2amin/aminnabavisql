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
    }
}
