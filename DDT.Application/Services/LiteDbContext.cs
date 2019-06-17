using System;
using LiteDB;

namespace DDT.Application.Services
{
    public class LiteDbContext
    {
        public readonly LiteDatabase Context;

        public LiteDbContext()
        {
            try
            {
                var filename = "test.db";
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("LITEDBCONNECTIONSTRING")))
                {
                    filename = Environment.GetEnvironmentVariable("LITEDBCONNECTIONSTRING");
                }
                var db = new LiteDatabase(filename);
                Context = db;
            }
            catch (Exception ex)
            {
                throw new Exception("Cant find or create LiteDb database.", ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
