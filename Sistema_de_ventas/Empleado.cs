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

namespace Sistema_de_ventas
{
    public partial class Empleado : MetroFramework.Forms.MetroForm
    {
        public Empleado()
        {
            InitializeComponent();
            SqlConnection conexion = new SqlConnection("server =DAVID\\SQLEXPRESS; database=sistema_ventas;User Id=dav;Password=123456");

            conexion.Open();
        }

        private void Empleado_Load(object sender, EventArgs e)


        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server =DAVID\\SQLEXPRESS; database=sistema_ventas;User Id=dav;Password=123456");

            conexion.Open();

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {

                MessageBox.Show("Llenar campos requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("InsertarEmpleado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                cmd.Parameters.AddWithValue("@apellido", textBox2.Text);
                cmd.Parameters.AddWithValue("@direccion", textBox3.Text);
                cmd.Parameters.AddWithValue("@telefono", textBox4.Text);
                
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro almacenado correctamente", "ASD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    dataGridView1

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.ToString());
                    throw;
                }
                conexion.Close();
            }

  
        }
    }
}
