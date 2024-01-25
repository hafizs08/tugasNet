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
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private int editIDKaryawan;

        public Form2()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        public Form2(int idKaryawan)
        {
            InitializeComponent();
            InitializeDatabase();
            editIDKaryawan = idKaryawan;
            LoadDataToEdit();
        }

        private void InitializeDatabase()
        {
            string serverName = "YOUR_SERVER_NAME";
            string databaseName = "YOUR_DATABASE_NAME";
            string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True;";

            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            new SqlCommandBuilder(adapter);

            dataSet = new DataSet();
        }

        private void LoadDataToEdit()
        {
            try
            {
                string query = "SELECT * FROM Karyawan WHERE IDKaryawan = @IDKaryawan";
                adapter.SelectCommand = new SqlCommand(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@IDKaryawan", editIDKaryawan);

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                adapter.Fill(dataSet, "Karyawan");

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                if (dataSet.Tables["Karyawan"].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables["Karyawan"].Rows[0];
                    textBox1.Text = row["IDKaryawan"].ToString();
                    textBox2.Text = row["NmKaryawan"].ToString();
                    numericUpDown1.Value = Convert.ToDecimal(row["Usia"]);
                    dateTimePicker1.Value = Convert.ToDateTime(row["TglMasukKerja"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (editIDKaryawan == 0)
                {
                    // Insert new data
                    string query = "INSERT INTO Karyawan (IDKaryawan, NmKaryawan, Usia, TglMasukKerja) VALUES (@IDKaryawan, @NmKaryawan, @Usia, @TglMasukKerja)";
                    adapter.InsertCommand = new SqlCommand(query, connection);
                }
                else
                {
                    // Update existing data
                    string query = "UPDATE Karyawan SET NmKaryawan = @NmKaryawan, Usia = @Usia, TglMasukKerja = @TglMasukKerja WHERE IDKaryawan = @IDKaryawan";
                    adapter.UpdateCommand = new SqlCommand(query, connection);
                    adapter.UpdateCommand.Parameters.AddWithValue("@IDKaryawan", editIDKaryawan);
                }

                adapter.UpdateCommand.Parameters.AddWithValue("@NmKaryawan", textBox2.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@Usia", numericUpDown1.Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@TglMasukKerja", dateTimePicker1.Value);

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                adapter.UpdateCommand.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                MessageBox.Show("Data berhasil disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close(); // Tutup formulir setelah menyimpan data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close(); // Tutup formulir tanpa menyimpan data
        }
    }
}
