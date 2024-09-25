using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_ADONET
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connection = "Server=localhost;Database=Cliente01;User Id=sa;Password=Raw@123!;TrustServerCertificate=True;";
        void ListarTudo()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clientes", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            ListarTudo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Clientes WHERE nome like '%{txtNome.Text}%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Clientes (Nome, Email, Telefone) values (@Nome, @Email, @Telefone)";
            command.Parameters.AddWithValue("@Nome", txtNome.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);

            command.Connection.Open();

            command.ExecuteNonQuery();

            command.Connection.Close();

            ListarTudo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE Clientes SET Nome = @Nome, Email =  @Email, Telefone = @Telefone WHERE Id = @id";
            command.Parameters.AddWithValue("@id", txtId.Text);
            command.Parameters.AddWithValue("@Nome", txtNome.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            

            command.Connection.Open();

            command.ExecuteNonQuery();

            command.Connection.Close();

            ListarTudo();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            command.CommandText = "DELETE FROM Clientes WHERE Id = @id";
            command.Parameters.AddWithValue("@id", txtId.Text);

            command.Connection.Open();

            command.ExecuteNonQuery();

            command.Connection.Close();

            ListarTudo();
        }
    }
}
