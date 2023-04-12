using System;
using DataAccessLayer;
using DataAccessLayer.RepoSpr;
using Model;
using Model.ModelSpr;

namespace Service
{
    public class TestService
    {
        string connectionString = "";
        public TestService(string connStr)
        {
            connectionString = connStr;
        }

        public string GetObjectName(int id)
        {
            IRepository<Objects> repo = new ObjectsRepository(connectionString);
            return repo.GetObject(id).Name;             
        }

    }
}
