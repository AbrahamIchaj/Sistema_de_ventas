using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    public partial class Menu_admin : MetroFramework.Forms.MetroForm
    {
      
        public Menu_admin()
        {
            InitializeComponent();
           
            SqlConnection conexion = new SqlConnection("server =DAVID\\SQLEXPRESS; database=sistema_ventas;User Id=dav;Password=123456");

            conexion.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show(this);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
        }
    }
}
