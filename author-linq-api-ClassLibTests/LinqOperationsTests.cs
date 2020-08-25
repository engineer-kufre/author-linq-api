using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace author_linq_api_ClassLib.Tests
{
    [TestClass()]
    public class LinqOperationsTests
    {
        List<Author> allAuthors = new List<Author>()
        {
            new Author(){id = 1, username = "Denrele Edun", about = "crazy", comment_count = 20000, created_at = 1258937599, submission_count = 250, submitted = 335, updated_at = DateTime.Now},
            new Author(){id = 2, username = "Childish Gambino", about = "musician", comment_count = 35000, created_at = 1358930927, submission_count = 150, submitted = 235, updated_at = DateTime.Now},
            new Author(){id = 3, username = "Kofo Baker", about = "actor", comment_count = 1000, created_at = 1442875986, submission_count = 50, submitted = 135, updated_at = DateTime.Now},
            new Author(){id = 4, username = "Segun Arinze", about = "actor", comment_count = 20000, created_at = 1287564398, submission_count = 220, submitted = 305, updated_at = DateTime.Now}
        };
        LinqOperations operations = new LinqOperations();

        [TestMethod()]
        public void GetUsernamesTest()
        {
            //Arrange
            int threshold = 120;
            int expected = 3;

            //Act
            int actual = operations.GetUsernames(threshold, allAuthors).Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetUsernameWithHighestCommentCountTest()
        {
            //Arrange
            string expected = "Childish Gambino";

            //Act
            string actual = operations.GetUsernameWithHighestCommentCount(allAuthors);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetUsernamesSortedByRecordDateTest()
        {
            //Arrange
            long threshold = 1290000000;
            int expected = 2;

            //Act
            int actual = operations.GetUsernamesSortedByRecordDate(threshold, allAuthors).Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}