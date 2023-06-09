﻿using Dapper;
using Microsoft.Data.SqlClient;
using Model.ModelSpr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccessLayer.RepoSpr
{
    public class ObjectsRepository : IRepository<Objects>
    {
        const string _tableName= "Objects";
        string connectionString = null;
        public ObjectsRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Objects obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
               db.Query($@"insert into {_tableName} values({Convert.ToInt32(obj.Morph)}, N'{obj.Name}')");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where id= {id}; delete from Morph where IdObjectInTheComposition={id}");
            }
        }

        public Objects GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Objects>($"SELECT * FROM {_tableName} where id= {id}" ).FirstOrDefault();
            }
        }

        public List<Objects> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Objects>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(Objects obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET Name = N'{obj.Name}', Morph={Convert.ToInt32(obj.Morph)} WHERE id={obj.Id}");
            }
        }
    }
}
