namespace Projeto_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ms_Login_Click(object sender, EventArgs e)
        {
            F_Login ms_Login = new F_Login(this);
            ms_Login.ShowDialog();
        }

        private void ms_Logoff_Click(object sender, EventArgs e)
        {
            Label_Acesso.Text = "0";
            lb_Usuario.Text = "---";
            pictureBox1.Image = Properties.Resources.ledvermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void cadastrarLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado para acessar !");
                F_Login f_Login = new F_Login(this);
                f_Login.ShowDialog();
            }
        }

        private void ambienteDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

            }
            else
            {
                MessageBox.Show("É necessário estar logado para acessar !");
                F_Login f_Login = new F_Login(this);
                f_Login.ShowDialog();


            }
        }

        private void gestãoUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    GestaoUser f_GestaoUsuarios = new GestaoUser();
                    f_GestaoUsuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado para acessar !");
                F_Login f_Login = new F_Login(this);
                f_Login.ShowDialog();
            }
        }
    }
}