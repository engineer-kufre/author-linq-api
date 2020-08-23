using author_linq_api_ClassLib;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace author_linq_api_UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create instance of author repository list
            AuthorDb all = new AuthorDb();

            //make GET requests and save author objects to author repository list
            GetAuthorRequest("https://jsonmock.hackerrank.com/api/article_users/search?page=1", all.allAuthors);
            GetAuthorRequest("https://jsonmock.hackerrank.com/api/article_users/search?page=2", all.allAuthors);

            //delay program to allow GetAuthorRequest method calls run first
            System.Threading.Thread.Sleep(10000);

            //run Form app
            Application.Run(new Form1(all));
        }

        //method for making GET request
        async static void GetAuthorRequest(string url, List<Author> allAuthors)
        {
            //create HttpClient instance
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            //deserialize string to get root object
            Page page = JsonSerializer.Deserialize<Page>(content);

            foreach (var author in page.data)
            {
                allAuthors.Add(author);
            }
        }
    }
}
