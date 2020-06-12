using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job LaunchCode = new Job( );
            Job Microsoft = new Job();
            Assert.IsTrue (LaunchCode.Id != Microsoft.Id);
            Assert.IsTrue(Microsoft.Id - LaunchCode.Id == 1 );


        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

        }
    }
}
