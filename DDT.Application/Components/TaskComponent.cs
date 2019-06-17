using System;
using System.Collections.Generic;
using System.Linq;
using DDT.Application.Services;
using DDT.Domain;
using LiteDB;

namespace DDT.Application
{
    public class TaskComponent
    {
        public List<Task> GetAllTasks()
        {
            var db = new LiteDbContext();
            var collection = db.Context.GetCollection<Task>("tasks");
            return collection.FindAll().ToList();
        }

        public void Save(Task task)
        {
            var db = new LiteDbContext();
            var collection = db.Context.GetCollection<Task>("tasks");
            collection.Upsert(task);
        }

        public void Delete(ObjectId id)
        {
            var db = new LiteDbContext();
            var collection = db.Context.GetCollection<Task>("tasks");
            collection.Delete(c => c.Id == id);
        }
    }
}
