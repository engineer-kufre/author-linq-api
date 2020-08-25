using author_linq_api_ClassLib;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
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
            CreateAuthorsList(all);

            //create the connection between the UI and the library
            DISocket.PlugSocket();
            ILinqOperations operations = DISocket.Isocket;

            //run Form app
            Application.Run(new Form1(all, operations));
        }

        //method to make GET requests and save author objects to author repository list
        private static async void CreateAuthorsList(AuthorDb all)
        {
            for (int i = 1; i < 3; i++)
            {
                Task<Page> page = GetAuthorRequest("https://jsonmock.hackerrank.com/api/article_users/search?page=" + i);
                Page apiPage = await page;

                foreach (var author in apiPage.data)
                {
                    all.allAuthors.Add(author);
                }
            }
        }

        //method for making GET request
        async static Task<Page> GetAuthorRequest(string url)
        {
            //create HttpClient instance
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            //deserialize string to get page object
            Page page = JsonSerializer.Deserialize<Page>(content);
            return page;
        }
    }
}
