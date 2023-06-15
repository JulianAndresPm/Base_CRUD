using AdminEmpleados.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEmpleados.Vistas
{
    public partial class Form_users : Form
    {
        public Form_users()
        {
            InitializeComponent();
        }

        private void Form_users_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            conexionDB conex = new conexionDB();
            conex.establecerConexion();
        }
    }
}
