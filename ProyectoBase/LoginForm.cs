using ProyectoBase.Entidades;

namespace ProyectoBase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(txtUser.Text, txtPassword.Text);
            string usuarioCorrecto = "Nicolas";
            string passCorrecto = "1234";
            if (txtUser.Text.Equals(usuarioCorrecto) && txtPassword.Text.Equals(passCorrecto))
            {
                PrincipalForm ventana = new PrincipalForm(user);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalida");
            }
        }
    }
}