using System.Collections.Generic;
using System.Linq;

namespace author_linq_api_ClassLib
{
    public class LinqOperations : ILinqOperations
    {
        //returns a list of names of the most active authors (using submission count criteria) according to a set threshold
        public List<string> GetUsernames(int threshold, List<Author> allAuthors)
        {
            List<string> mostActiveAuthors = new List<string>();
            var query = allAuthors.Where(a => a.submission_count > threshold)
                                            .OrderByDescending(a => a.submission_count);

            foreach (var author in query)
            {
                mostActiveAuthors.Add(author.username);
            }
            return mostActiveAuthors;
        }

        //returns the name of the author with the highest comment count
        public string GetUsernameWithHighestCommentCount(List<Author> allAuthors)
        {
            string authorWithHighestCommentCount = "";
            var query = allAuthors.OrderByDescending(a => a.comment_count)
                                            .Take(1);

            foreach (var author in query)
            {
                authorWithHighestCommentCount = author.username;
            }
            return authorWithHighestCommentCount;
        }

        //returns a list of the names of authors sorted by when their record was created according to a set threshold
        public List<string> GetUsernamesSortedByRecordDate(int threshold, List<Author> allAuthors)
        {
            List<string> authorsCreatedAfterThreshold = new List<string>();
            var query = allAuthors.Where(a => a.created_at > threshold)
                                            .OrderByDescending(a => a.created_at);

            foreach (var author in query)
            {
                authorsCreatedAfterThreshold.Add(author.username);
            }
            return authorsCreatedAfterThreshold;
        }
    }
}
