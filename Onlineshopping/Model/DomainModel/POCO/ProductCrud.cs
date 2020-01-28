using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshopping.Model.DomainModel.POCO
{
    public class ProductCrud
    {
        #region [-Select Product-]
        public static List<Helper.SpHelper.Product1.Getproducthelper>
   Select(string name)

        {

            using (var Context = new Model.DomainModel.DTO.EF.onlineshopingEntities())

            {
                List<Model.Helper.SpHelper.Product1.Getproducthelper> listproduct
                   = new List<Helper.SpHelper.Product1.Getproducthelper>();
                try
                {


                    return Context.Database.SqlQuery
                         <Model.Helper.SpHelper.Product1.Getproducthelper>
                         (Model.Helper.SpHelper.Product1.Productsphelper.Usp_Getproduct, new SqlParameter("@categoryname", name)).ToList();



                }
                catch (Exception)
                {


                    throw;


                }

            }
        }
        #endregion

        #region [-Insert Product-]
        public  string InsertProduct(List<Helper.SpHelper.Product1.Insertproduct> insertproducts)
        {
            using (var context = new DomainModel.DTO.EF.onlineshopingEntities())
            {
                try
                {
                  return (context.Database.ExecuteSqlCommand
                         (Model.Helper.SpHelper.Product1.Productsphelper.Usp_InsertProduct,
                           Model.Helper.SpHelper.Product1.Productsphelper.SetInsertParameters(insertproducts))).ToString();
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                   
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }

            }

        } 
        #endregion

    }
}
