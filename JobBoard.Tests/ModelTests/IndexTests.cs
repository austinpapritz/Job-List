using JobBoard.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace JobBoard.UnitTests
{
    [TestClass]
    public class JobOpeningTests
    {
        [TestMethod]
        public void JobOpeningConstructor_AddInstanceToList_JobOpeningList()
        {
            // Arrange
            string name1 = "Maria";
            string name2 = "Parker";
            JobOpening job1 = new JobOpening(name1);
            JobOpening job2 = new JobOpening(name2);
            List<JobOpening> expectedList = new List<JobOpening> { job1, job2 };

            // Act
            List<JobOpening> result = JobOpening.GetAll();

            // Assert
            CollectionAssert.AreEqual(expectedList, result);
        }
    }
}