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
    public partial class Form1 : Form
    { 
        public static LinkedList<ProgramItem> programs = new LinkedList<ProgramItem>();
        public Form1()
        {
            InitializeComponent();
            updateList();
        }

        public void updateList() 
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-7Q7V6GF; Initial Catalog=ProgramLauncherDB; Server=localhost;Trusted_Connection=True;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //updateList();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";
            string outName, outPath = "";
            sql = "Select Name, Path from dbo.Programtb";


            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            listViewPrograms.Items.Clear();
            while (dataReader.Read())
            {
                outName = "";
                outName = outName + dataReader.GetValue(0);
                outPath = "";
                outPath = outPath + dataReader.GetValue(1);

                ListViewItem item = new ListViewItem(outName);
                item.SubItems.Add(outPath);
                listViewPrograms.Items.Add(item);
                
                //Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void button_add_new_Click(object sender, EventArgs e)
        {
            Add_New_Program window = new Add_New_Program();
            window.Show();
            updateList();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            updateList();           
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-7Q7V6GF; Initial Catalog=ProgramLauncherDB; Server=localhost;Trusted_Connection=True;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, path = "";

            sql = $"Select Path from dbo.Programtb where Name='{listViewPrograms.SelectedItems[0].SubItems[0].Text}'";

            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                path = path + dataReader.GetValue(0);
            }           
            System.Diagnostics.Process.Start(path);
        }

        private void button_DeleteProgram_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            string selected = "";

            connectionString = @"Data Source=DESKTOP-7Q7V6GF; Initial Catalog=ProgramLauncherDB; Server=localhost;Trusted_Connection=True;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            selected = selected + listViewPrograms.SelectedItems[0].SubItems[0].Text;

            sql = $"DELETE FROM programtb WHERE Name='{selected}'";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            //ProgramItem newItem = new ProgramItem(textBox_Name.Text, textBox_Path.Text);
            //Form1.programs.AddLast(newItem);
            command.Dispose();
            cnn.Close();
            MessageBox.Show($"Program {selected} Deleted");
            updateList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listViewPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            List<string> strlist = new List<string>();
            List<ListViewItem> list = new List<ListViewItem>();
            int i = 0;
            foreach(ListViewItem item in listViewPrograms.Items)
            {
                if (item.SubItems[0].Text.Equals(search))
                {
                    listViewPrograms.Items[i].Selected = true;
                    listViewPrograms.Select();
                    MessageBox.Show($"{search} is in the Program list");

                    return;
                }
                i++;
            }
            MessageBox.Show($"{search} was not found");
        }
    }
}
