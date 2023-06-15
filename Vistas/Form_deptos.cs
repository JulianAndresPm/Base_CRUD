using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.BLL;
using AdminEmpleados.DB;

namespace AdminEmpleados.Vistas
{
    public partial class Form_deptos : Form
    {
        public Form_deptos()
        {
            InitializeComponent();
        }

        private void btnAgregarDepto_Click(object sender, EventArgs e)
        {
            traerInformacion();

            conexionDB conex = new conexionDB();
            conex.establecerConexion();
        }

        private void traerInformacion()
        {
            Departamento oDepartamento = new Departamento();

            int id = 0; int.TryParse(txtIdDepto.Text, out id);
            oDepartamento.IdDepto = (int)id;

            oDepartamento.nomDepto = txtNomDepto.Text;

            MessageBox.Show(oDepartamento.IdDepto.ToString());
            MessageBox.Show(oDepartamento.nomDepto.ToString());


        }
    }
}
