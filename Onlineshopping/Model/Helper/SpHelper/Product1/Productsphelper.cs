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
        public const string Usp_InsertProduct = "Exec dbo.InsertProduct @Productinfo";
        public const string Usp_UpdateProduct = "dbo.UpdateProduct @Productuinfo";
        #region [-SetInsertParameters(List<Insertproduct> listInsertProduct)-]
        public static object[] SetInsertParameters(List<Insertproduct> listInsertProduct)
        {
            #region [- SqlParameter -]
            SqlParameter    InsrtProductListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.Udt_InsertProduct",
                Value = listInsertProduct.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                InsrtProductListParameter
            };
            #endregion
            return parameters;
        }
        #endregion
        #region [-SetUpdateParameters(List<UpdatProduct> listupdateproduct)-]
        public static object[] SetUpdateParameters(List<UpdatProduct> listupdateproduct)
        {
            #region [-SqlParameter-]
            SqlParameter UpdateProductListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.Udt_ProductTypeForUpdate",
                Value = listupdateproduct.ToDataTable()
            };
            #endregion
            #region [-parameters-]
            object[] parameters =
                {
                UpdateProductListParameter
            };
            #endregion
            return parameters;
        } 
        #endregion

    }
}
