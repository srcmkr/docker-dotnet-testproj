using LiteDB;

namespace DDT.Domain
{
    public class Task
    {
        public ObjectId Id { get; set; }
        public string TaskItem { get; set; }
    }
}
