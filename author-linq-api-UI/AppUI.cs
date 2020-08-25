using author_linq_api_ClassLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace author_linq_api_UI
{
    public partial class Form1 : Form
    {
        private readonly ILinqOperations Operation;
        public AuthorDb All { get; set; }

        //form constructor
        public Form1(AuthorDb all, ILinqOperations operations)
        {
            InitializeComponent();
            All = all;
            Operation = operations;
        }

        //click event handler for getUsernameByCountListBoxButton
        private void getUsernameByCountListBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold = int.Parse(getUsernameByCountListBoxThreshold.Text);
                List<string> result = Operation.GetUsernames(threshold, All.allAuthors);
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
                long threshold = (dateTimePicker.Value.Ticks - 621356166000000000) / 10000000;
                List<string> result = Operation.GetUsernamesSortedByRecordDate(threshold, All.allAuthors);
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
            highestCommentCountTextBox.Text = Operation.GetUsernameWithHighestCommentCount(All.allAuthors);
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
