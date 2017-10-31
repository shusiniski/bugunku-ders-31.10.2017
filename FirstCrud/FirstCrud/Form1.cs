using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FirstCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
       

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            var comment = new Comment(nameBox.Text, surNameBox.Text, CommentBox.Text);
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P203\Documents\QuestBook.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            var insertQuery = "INSERT INTO userMessages(userName,userSurname, userMessage) VALUES ('" + comment.userName + "','" + comment.userSurname + "', '" + comment.userMessage + "')";
            SqlCommand command = new SqlCommand(insertQuery, conn);
            var result = command.ExecuteNonQuery();
            if (result != 0)
            {
                MessageBox.Show("Tesekkur edirik" + result);

            }
            else
            {
                MessageBox.Show("Error ucun tesekkur edirik");

            }
        }       
    }

    class Comment
    {
        public string userName;
        public string userSurname;
        public string userMessage;

        public Comment(string _name, string _surname, string _message)
        {
            userName = _name;
            userSurname = _surname;
            userMessage = _message;
        }
    }
}


