﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DI03_2
{
    class DataAcces
    {
        public static ProductModel GetProductModel(int productModelID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal))
            {
                string sql = "SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto " +
                    "FROM Production.ProductModel " +
                    "JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID " +
                    "JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID " +
                    "JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID " +
                    $"WHERE Product.ProductModelID = {productModelID}";
                return connection.Query<ProductModel>(sql).FirstOrDefault();
            }
        }

        public static List<Product> GetProducts(int productModelID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal))
            {
                string sql = "SELECT ProductId, Size, ListPrice FROM Production.Product " +
                    $"WHERE Product.ProductModelID = {productModelID}";
                return connection.Query<Product>(sql).ToList();
            }
        }

        public static int CountModel()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal))
            {
                string sql = "SELECT DISTINCT ProductModel.ProductModelID " +
                    "FROM Production.ProductModel " +
                    "JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID " +
                    "JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID " +
                    "JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID";
                return connection.Query<ProductModel>(sql).Count();
            }
        }
    }
}
