﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshopping.Model.DomainModel.POCO
{
    public class ProductCrud
    {
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
                        (Model.Helper.SpHelper.Product1.Productsphelper.Usp_Getproduct,new SqlParameter("@categoryname",name)).ToList();



                }
                catch (Exception)
                {


                    throw;


                }
               
            }
        }
     
    }
}