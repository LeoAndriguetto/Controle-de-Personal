
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Academia
{
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();

        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string senha = txt_senha.Text;
            if (username =="" || senha == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
                txt_user.Focus();
                return;
            }
            string sql = "SELECT * FROM person WHERE Usuario= '" + username + "' AND Senha='" + senha + "'";
            dt=Class1.consulta(sql);
            if(dt.Rows.Count == 1 ) 
            {
                form1.Label_Acesso.Text = dt.Rows[0].ItemArray[10].ToString();
                form1.lb_Usuario.Text = dt.Rows[0].Field<string>("Usuario");
                form1.pictureBox1.Image = Properties.Resources.lerdverde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int32>("NivelAcesso").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }
    }
}
