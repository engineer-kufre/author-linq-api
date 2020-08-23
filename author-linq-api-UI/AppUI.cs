using author_linq_api_ClassLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace author_linq_api_UI
{
    public partial class Form1 : Form
    {
        public AuthorDb All { get; set; }

        //form constructor
        public Form1(AuthorDb all)
        {
            InitializeComponent();
            All = all;
        }

        //click event handler for getUsernameByCountListBoxButton
        private void getUsernameByCountListBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold = int.Parse(getUsernameByCountListBoxThreshold.Text);
                List<string> result = LinqOperations.GetUsernames(threshold, All.allAuthors);
                getUsernamesByCountListBox.DataSource = result;
                getUsernamesByCountListBox.DisplayMember = "username";
            }
            catch
            {
                return;
            }
        }

        //click event handler for getUsernameByDateListBoxButton
        private void getUsernameByDateListBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold = int.Parse(getUsernameByDateListBoxThreshold.Text);
                List<string> result = LinqOperations.GetUsernamesSortedByRecordDate(threshold, All.allAuthors);
                getUsernamesByDateListBox.DataSource = result;
                getUsernamesByDateListBox.DisplayMember = "username";
            }
            catch
            {
                return;
            }
        }

        //click event handler for getUsernameByCommentCountButton
        private void getUsernameByCommentCountButton_Click(object sender, EventArgs e)
        {
            highestCommentCountTextBox.Text = LinqOperations.GetUsernameWithHighestCommentCount(All.allAuthors);
        }

        //click event handler for resetButton
        private void resetButton_Click(object sender, EventArgs e)
        {
            getUsernamesByDateListBox.DataSource = null;
            getUsernamesByDateListBox.DisplayMember = "username";
            getUsernamesByCountListBox.DataSource = null;
            getUsernamesByCountListBox.DisplayMember = "username";
            highestCommentCountTextBox.Text = "";
        }
    }
}
