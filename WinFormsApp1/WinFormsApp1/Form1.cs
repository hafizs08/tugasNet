
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        public Form1()
        {
 
            InitializeComponent();
            InitializeDatabase();
            dataSet = new DataSet();
            ShowDataInMessageBox();
        }

        private void InitializeDatabase()
        {
            string serverName = "IKAROS";
            string databaseName = "EmployeeDB";

            string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True;";

            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            new SqlCommandBuilder(adapter);

            dataSet = new DataSet();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ShowFilteredData();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form2 formEntryData = new Form2();
            formEntryData.ShowDialog();
            ShowFilteredData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int idKaryawan = Convert.ToInt32(dataGridView.Rows[selectedRowIndex].Cells["IDKaryawan"].Value);

                Form2 formEntryData = new Form2(idKaryawan);
                formEntryData.ShowDialog();
                ShowFilteredData();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form2 formEntryData = new Form2();
            formEntryData.ShowDialog();
            ShowFilteredData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int idKaryawan = Convert.ToInt32(dataGridView.Rows[selectedRowIndex].Cells["IDKaryawan"].Value);

                Form2 formEntryData = new Form2(idKaryawan);
                formEntryData.ShowDialog();
                ShowFilteredData();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ShowFilteredData()
        {
            try
            {
                string query = "SELECT * FROM Karyawan WHERE " +
                    "(NmKaryawan LIKE @NmKaryawan OR @NmKaryawan = '') AND " +
                    "(Usia >= @UsiaMin OR @UsiaMin IS NULL) AND (Usia <= @UsiaMax OR @UsiaMax IS NULL) AND " +
                    "(TglMasukKerja >= @TglMasukKerjaMin OR @TglMasukKerjaMin IS NULL) AND (TglMasukKerja <= @TglMasukKerjaMax OR @TglMasukKerjaMax IS NULL)";

                adapter.SelectCommand = new SqlCommand(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@NmKaryawan", textBoxNamaKaryawan.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@UsiaMin", numericUpDownUsiaMin.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@UsiaMax", numericUpDownUsiaMax.Value == 0 ? (object)DBNull.Value : numericUpDownUsiaMax.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@TglMasukKerjaMin", dateTimePickerTglMasukMin.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@TglMasukKerjaMax", dateTimePickerTglMasukMax.Value == DateTimePicker.MaximumDateTime ? (object)DBNull.Value : dateTimePickerTglMasukMax.Value);

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                dataSet.Clear();
                adapter.Fill(dataSet, "Karyawan");

                if (connection.State == ConnectionState.Open)
                    connection.Close();

                dataGridView.DataSource = dataSet.Tables["Karyawan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}