using ProyectoBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario user)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido " + user.NombreDeUsuario;
            lblBienvenida.Visible = true;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
