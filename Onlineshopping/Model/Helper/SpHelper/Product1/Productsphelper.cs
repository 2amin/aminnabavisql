using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Onlineshopping.Model.Helper.SpHelper.Product1
{
   public class Productsphelper
    {
        public const string Usp_Getproduct = " dbo.Getproduct  @Categoryname ";

        public const string Usp_InsertProduct = "dbo.InsertProduct @ProductInfo";
        #region [-SetInsertParameters(List<Insertproduct> listInsertProduct)-]
        public static object[] SetInsertParameters(List<Insertproduct> listInsertProduct)
        {
            #region [- SqlParameter -]
            SqlParameter    ProductListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.Udt_ProductTypeForInsert",
                Value = listInsertProduct.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                ProductListParameter
            };
            #endregion
            return parameters;
        } 
        #endregion

    }
}
