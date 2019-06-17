using System.Linq;
using DDT.Application;
using DDT.Domain;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var cmp = new TaskComponent();

            var task = new Task
            {
                TaskItem = "This is a test"
            };

            var listBefore = cmp.GetAllTasks().Count();

            cmp.Save(task);

            var listAfter = cmp.GetAllTasks().Count();

            Assert.AreEqual(listBefore + 1, listAfter);

            cmp.Delete(task.Id);

            var listAfterDel = cmp.GetAllTasks().Count();

            Assert.AreEqual(listBefore, listAfterDel);
        }
    }
}