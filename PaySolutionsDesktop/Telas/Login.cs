using PaySolutionsDesktop.Modelo;
using PaySolutionsDesktop.Telas;
using System.Threading;
using System.Windows.Forms;

namespace PaySolutionsDesktop
{
    public partial class Login : Form
    {
        Thread t1;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ControleLogin controle = new ControleLogin();
            bool confirmado = controle.Acessar(txtUsuario.Text, txtSenha.Text);

            if (confirmado)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaPrincipal principal = new TelaPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha estão incorretos");
            }
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new TelaPrincipal());
        }
    }
}
