using JobBoard.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Data.Common;

namespace JobBoard.UnitTests
{
    [TestClass]
    public class JobOpeningTests
    {
        // [Ignore]
        // [TestMethod]
        // public void JobOpeningConstructor_AddInstanceToList_JobOpeningList()
        // {
        //     string name1 = "Maria";
        //     string name2 = "Parker";
        //     JobOpening job1 = new (name1);
        //     JobOpening job2 = new (name2);
        //     List<JobOpening> expectedList = new() { job1, job2 };

        //     List<JobOpening> result = JobOpening.GetAll();


        //     CollectionAssert.AreEqual(expectedList, result);
        //  }

        [TestMethod]
        public void JobOpeningConstructor_GeneratingUniqueId_JobOpeningId()
        {
            //Arrange
            int expectedID = 1;
            JobOpening testJob = new("Erik", "erik@gmail.com", "1", "Male");

            //Act
            int result = testJob.Id;

            //Assert
            Assert.AreEqual(expectedID, result);
        }

        [TestMethod]
        public void GetJobById_FindJobByIdInList_JobOpeningObject()
        {
            // Arrange
            JobOpening.ClearAll();
            JobOpening testJob = new("Pier", "Perik@gmail.com", "11", "Female");

            // Act
            JobOpening result = JobOpening.GetJobById(1);

            // Assert
            Assert.AreEqual(testJob, result);
        }
    }
}