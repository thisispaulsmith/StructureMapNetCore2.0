using ClassLibrary1;
using Shouldly;
using StructureMap;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var registry = new TestRegistry();
            var container = new Container(registry);


            container.GetAllInstances<IApplicationEventHandler<Created>>().Count().ShouldBe(2); 
        }
    }
}
