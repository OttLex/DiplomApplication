using Model.ModelSpr;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoSpr
{
    public class BlockRepository : IRepository<Block>
    {
        const string _tableName = "Block";
        string connectionString = null;
        public BlockRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"insert into {_tableName} values({obj.IdScript} , '{obj.Description}', '{obj.Name}')");
                //db.Query($@"insert into {_tableName} values('{obj.Name}', '{obj.Description}')");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where Id= {id}");
            }
        }

        public Block GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Block>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<Block> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Block>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public List<Block> GetObjects(int idScript)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Block>("SELECT * FROM " + _tableName + " where IdScript= "+ idScript).ToList();
            }
        }

        public void Update(Block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET IdScript= {obj.IdScript}, Name= '{obj.Name}', Description= '{obj.Description}' WHERE id={obj.Id}");
                //db.Query($@"UPDATE {_tableName} SET  Name= '{obj.Name}', Description= '{obj.Description}' WHERE id={obj.Id}");
            }
        }
    }
}
