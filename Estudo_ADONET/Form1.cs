using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace Estudo_ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSqlServer_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Server=localhost;Database=Cliente01;User Id=sa;Password=Raw@123!;TrustServerCertificate=True;";

            conn.Open();

            MessageBox.Show("Abrir conexão com SqlServer");

            conn.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Server=localhost;Database=Cliente01;User Id=sa;Password=Raw@123!;TrustServerCertificate=True;";

            conn.Open();

            SqlCommand comn = new SqlCommand();

            comn.CommandText = "SELECT * FROM Clientes";
            comn.Connection = conn;

            SqlDataReader reader = comn.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add($"{reader.GetInt32(0)}, {reader.GetString(1)}, {reader.GetString(2)}, {reader.GetString(3)},{reader.GetDateTime(4)}");
            }

            conn.Close();
        }

        private void btnDataset_Click(object sender, EventArgs e)
        {
            string connection = "Server=localhost;Database=Cliente01;User Id=sa;Password=Raw@123!;TrustServerCertificate=True;";

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clientes", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            form2.Show();
        }
    }
}
