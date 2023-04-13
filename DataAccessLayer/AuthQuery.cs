﻿using Dapper;
using Microsoft.Data.SqlClient;
using Model.ModelSpr;
using Model.ModelsSpr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace DataAccessLayer
{
    public class AuthQuery
    {
        const string _tableName = "User";
        string connectionString = null;
        public AuthQuery(string conn)
        {
            connectionString = conn;
        }

        public User GetUser(string userName, string password)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var parameters = new { UserName = userName, Password = password };
                var sql = "SELECT * from Users where UserName = @UserName and Password = @Password";
                var result = db.Query<User>(sql, parameters).FirstOrDefault();

                return result;
            }

        }

    }
}
