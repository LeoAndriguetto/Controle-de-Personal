
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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void F_NovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.FirstName = txt_FirstName.Text;
            usuario.LastName = txt_LastName.Text;
            usuario.DataNascimento = txt_Nascimento.Value;
            usuario.Responsavel = txt_Responsavel.Text;
            usuario.Telefone = txt_Telefone.Text;
            usuario.Email = txt_Email.Text;
            usuario.TipoContrato = txt_TipoContrato.Text;
            usuario.ValorMensal = txt_ValorMensal.Text;
            Random codigo = new Random();
            usuario.CodigoAcesso = codigo.Next(1000, 2000);
            if (Verifica(usuario))
            {
                Class1.NovoUsuario(usuario);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para prosseguir!");
            }
            
            
         
            
        }

        public static bool Verifica(Usuario u)
        {
            bool res;
            if (u.FirstName == "" || 
                u.LastName == "" || 
                u.Responsavel == "" ||
                u.Telefone == "" ||
                u.Email == "" ||
                u.TipoContrato == "" ||
                u.ValorMensal == "")
            {
                res = false;
            }
            else { res = true; } return res;
 

        }
    }
}
