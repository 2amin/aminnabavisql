using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshopping.VeiwModel1.Category
{
  public  class CategoryViewModel
    {
        #region [-Ctor-]
        public CategoryViewModel()
        {


        } 
        #endregion
        Model.DomainModel.POCO.CategoryCrud Ref_Categorycrud;
        List<Model.Helper.SpHelper.Category.Getcategoryhelper> list_Getcategory;
        public List<Model.Helper.SpHelper.Category.Getcategoryhelper>Refereshcategory()
        {
            list_Getcategory = new List<Model.Helper.SpHelper.Category.Getcategoryhelper>();
            Ref_Categorycrud = new Model.DomainModel.POCO.CategoryCrud();
            list_Getcategory= Ref_Categorycrud.Select();
            return list_Getcategory;
        }
    }
}
