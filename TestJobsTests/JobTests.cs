using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TestJobsTests
{

    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Employer acme;
        Location desert;
        PositionType qa;
        CoreCompetency persistence;

        [TestInitialize]
        public void CreateTestJobAndFields()
        {
            acme = new Employer("ACME");
            desert = new Location("Desert");
            qa = new PositionType("Quality Control");
            persistence = new CoreCompetency("Persistence");

            testJob1 = new Job("Product tester", acme, desert, qa, persistence);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id - job1.Id == 1);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Assert.IsTrue(testJob1.Name == "Product tester");
            Assert.IsTrue(testJob1.EmployerName.Value == "ACME");
            Assert.IsTrue(testJob1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob1.JobCoreCompetency.Value == "Persistence");
            Assert.IsTrue(testJob1.JobType.Value == "Quality Control");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Value", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Job testJob2 = new Job("Value", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Assert.AreNotEqual(testJob1, testJob2);
        }

        [TestMethod]
        public void TostringHasNewLine()
        {
            string hold = testJob1.ToString();
            Assert.IsTrue(hold.StartsWith("\n"));
            Assert.IsTrue(hold.EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobsToString()
        {
            string expectedOutput = $"\nID: {testJob1.Id}\nName: {testJob1.Name}\nEmployer: {testJob1.EmployerName}\nLocation: {testJob1.EmployerLocation}\nPosition Type: {testJob1.JobType}\nCore Competency: {testJob1.JobCoreCompetency}\n";
            string actualOutput = testJob1.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestJobsDataGone()
        {
            Job jobgone = new Job("", new Employer (""), new Location (""), new PositionType (""), new CoreCompetency(""));
            string nodata = $"\nID: {jobgone.Id}\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n";
            string actualdata = jobgone.ToString();
            Assert.AreEqual(nodata, actualdata);
        }
    }



}

