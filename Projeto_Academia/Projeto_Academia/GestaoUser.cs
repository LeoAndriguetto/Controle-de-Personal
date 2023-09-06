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
    public partial class GestaoUser : Form
    {
        public GestaoUser()
        {
            InitializeComponent();
        }

        private void GestaoUser_Load(object sender, EventArgs e)
        {
            dgv_Usuarios.DataSource = Class1.ObterTodosUsuarios();
        }

        private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[12].Value.ToString();
                dt = Class1.ObterDadosUsuario(vId);
                txt_ID.Text = dt.Rows[0].Field<Int32>("ID").ToString();
                txt_FirstName.Text = dt.Rows[0].Field<string>("FirstName");
                txt_LastName.Text = dt.Rows[0].Field<string>("LastName");
                txt_Responsavel.Text = dt.Rows[0].Field<string>("Responsavel");
                txt_Email.Text = dt.Rows[0].Field<string>("Email");
                txt_Telefone.Text = dt.Rows[0].Field<string>("Telefone");
                txt_TipoContrato.Text = dt.Rows[0].Field<string>("TipoContrato");
                txt_ValorMensal.Text = dt.Rows[0].Field<string>("ValorMensal");

            }
        }

        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                    dgv_Usuarios.DataSource = Class1.ObterTodosUsuarios();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_Usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.ID = txt_ID.Text;
            u.FirstName = txt_FirstName.Text;
            u.LastName = txt_LastName.Text;
            u.Responsavel = txt_Responsavel.Text;
            u.Telefone = txt_Telefone.Text;
            u.Email = txt_Email.Text;
            u.TipoContrato = txt_TipoContrato.Text;
            u.ValorMensal = txt_ValorMensal.Text;
            Class1.AtualizarDadosUsuario(u);
            dgv_Usuarios.DataSource = Class1.ObterTodosUsuarios();
            dgv_Usuarios.CurrentCell = dgv_Usuarios[0, linha];
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir este aluno?","Excluir?",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) 
            { Class1.DeletarUsuario(txt_ID.Text);
              dgv_Usuarios.DataSource = Class1.ObterTodosUsuarios();
            }  
        }
    }
}
