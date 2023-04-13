using System;
using System.Collections.Generic;
using DataAccessLayer;
using DataAccessLayer.RepoSpr;
using DataAccessLayer.RepoRel;
using Model;
using Model.ModelSpr;
using Model.ModelRelations;

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

        public List<ListOfScripts> GetAllScripts()
        {
            return new List<ListOfScripts>();
        }

    }
}
