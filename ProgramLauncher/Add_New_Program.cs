using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramLauncher
{
    public partial class Add_New_Program : Form
    {
        public Add_New_Program()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text.Length == 0 || textBox_Path.Text.Length == 0)
            {
                return;
            }

            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-7Q7V6GF; Initial Catalog=ProgramLauncherDB; Server=localhost;Trusted_Connection=True;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = $"IF NOT EXISTS (Select Name from programtb WHERE Name='{textBox_Name.Text}')" +
                $"Insert into programtb (Name, Path) values('{textBox_Name.Text}','{textBox_Path.Text}')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            //ProgramItem newItem = new ProgramItem(textBox_Name.Text, textBox_Path.Text);
            //Form1.programs.AddLast(newItem);
            command.Dispose();
            cnn.Close();
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox_Path.Text = openFileDialog1.FileName;
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
