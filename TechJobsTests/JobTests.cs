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
            Employer e1 = new Employer("ACME");
            Location l1 = new Location("desert");
            PositionType p1 = new PositionType("Quality Control");
            CoreCompetency c1 = new CoreCompetency("Persistance");

            Job ProductTester = new Job("Product Tester", e1, l1, p1, c1); // Sub for e1, l1, p1, c1, --> new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            Assert.AreEqual(ProductTester.Name, "Product Tester");
            Assert.AreEqual(ProductTester.EmployerName, e1);
            Assert.AreEqual(ProductTester.EmployerLocation, l1);
            Assert.AreEqual(ProductTester.JobType, p1);
            Assert.AreEqual(ProductTester.JobCoreCompetency, c1);

           }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job = new Job("I am a job", new Employer("JobPlace"), new Location("job location"), new PositionType("working job"), new CoreCompetency("Hardwork"));

            Job test_job2 = new Job("I am a job", new Employer("JobPlace"), new Location("job location"), new PositionType("working job"), new CoreCompetency("Hardwork"));

            Assert.AreNotEqual(test_job, test_job2); //JOBS ARE NOT EQUAL
        }











    }
}
