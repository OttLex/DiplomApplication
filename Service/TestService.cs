using System;
using DataAccessLayer;
using Model;

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
            var repo = new ObjectsRepository(connectionString);
            return repo.GetObject(id).Name;             
        }

    }
}
