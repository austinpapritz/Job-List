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
   
            string name1 = "Maria";
            string name2 = "Parker";
            JobOpening job1 = new(name1);
            JobOpening job2 = new(name2);
            List<JobOpening> expectedList = new() { job1, job2 };

   
            List<JobOpening> result = JobOpening.GetAll();


            CollectionAssert.AreEqual(expectedList, result);
         }
    }
}