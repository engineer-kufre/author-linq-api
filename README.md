# author-linq-api
App which fetches from API and performs some LINQ extension method operations.
Done with WinForms UI, structured Class Library, loose coupling and unit test suite.

This project consumes a REST API containing information about a collection of users and the articles they created. The goal was to use the API to get the following:

* A list of most active authors according to a set threshold.
* The author with the highest comment count.
* The list of the authors sorted by when their record was created according to a set threshold date.

To access the collection of users, it performs a HTTP GET request to:
https://jsonmock.hackerrank.com/api/article_users/search?page=1 and https://jsonmock.hackerrank.com/api/article_users/search?page=2
