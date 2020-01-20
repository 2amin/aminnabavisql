using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshopping.Model.DomainModel.POCO
{
   public class CategoryCrud
    {
        #region [-Select Category-]
        static public List<Model.Helper.SpHelper.Category.Getcategoryhelper> Select()
        {
            using (var Context = new Model.DomainModel.DTO.EF.onlineshopingEntities())
            {
                List<Helper.SpHelper.Category.Getcategoryhelper>
                    list_Category = new List
                    <Helper.SpHelper.Category.Getcategoryhelper>();
                try
                {


                    list_Category = Context.Database.SqlQuery
                        <Model.Helper.SpHelper.Category.Getcategoryhelper>
                        (Model.Helper.SpHelper.Category.Categorysphelper.
                        Usp_getcategory).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return list_Category;
            }

        } 
        #endregion

    }
}
