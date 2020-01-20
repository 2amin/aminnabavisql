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

       public string SaveProduct(List<Model.Helper.SpHelper.Product1.Insertproduct>InsertProducts)
        {
            Ref_ProductCrud.
        }
    }
}
