using System;
using System.Collections.Generic;
using System.Text;

namespace author_linq_api_ClassLib
{
    public interface ILinqOperations
    {
        List<string> GetUsernames(int threshold, List<Author> allAuthors);
        string GetUsernameWithHighestCommentCount(List<Author> allAuthors);
        List<string> GetUsernamesSortedByRecordDate(long threshold, List<Author> allAuthors);
    }
}
