using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Projeto_Academia;
using System.Windows.Forms;


namespace Projeto_Academia
{
    public class Class1
    {
        private static SqlConnection conexao;
        private static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            conexao.Open();
            return conexao;
        }

        public static bool existeUsername(Usuario u) 
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT Usuario FROM person WHERE Usuario = '" + u.User + "'";
            da = new SqlDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if(dt.Rows.Count > 0) {res = true; } else { res = false;}
            vcon.Close();
            return res;
        }

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Nome de Usuário indisponível!");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO person (FirstName,LastName,Responsavel, ValorMensal,TipoContrato,DataNascimento,Email,Telefone,Codigo) VALUES (@nome,@sobrenome,@responsavel,@valor,@contrato,@nascimento,@email,@telefone,@Codigo)";
                cmd.Parameters.AddWithValue("@nome", u.FirstName);
                cmd.Parameters.AddWithValue("@sobrenome", u.LastName);
                cmd.Parameters.AddWithValue("@responsavel", u.Responsavel);
                cmd.Parameters.AddWithValue("@valor", u.ValorMensal);
                cmd.Parameters.AddWithValue("@contrato", u.TipoContrato);
                cmd.Parameters.AddWithValue("@nascimento", u.DataNascimento);
                cmd.Parameters.AddWithValue("@email", u.Email);
                cmd.Parameters.AddWithValue("@telefone", u.Telefone);
                cmd.Parameters.AddWithValue("@Codigo", u.CodigoAcesso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo aluno cadastrado com sucesso." + $"\nCódigo para cadastro de usuário: {u.CodigoAcesso}");
                vcon.Close();

            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo aluno!");
            }
        }

        public static DataTable ObterTodosUsuarios()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                
                {
                    var vcon = ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "SELECT * FROM person";
                    da = new SqlDataAdapter(cmd.CommandText,vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                
                {
                    var vcon = ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = sql;
                    da = new SqlDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                {
                    var vcon = ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "SELECT * FROM person WHERE ID="+id;
                    da = new SqlDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarDadosUsuario(Usuario u)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {

                {
                    var vcon = ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE person SET FirstName='" + u.FirstName + "',LastName='" + u.LastName + "',Responsavel='" + u.Responsavel + "',Email='" + u.Email + "',Telefone='" + u.Telefone + "',TipoContrato='" + u.TipoContrato + "',ValorMensal='" + u.ValorMensal + "' WHERE ID="+ u.ID;
                    da = new SqlDataAdapter(cmd.CommandText, vcon);
               
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                {
                    var vcon = ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM person WHERE ID=" + id;
                    da = new SqlDataAdapter(cmd.CommandText, vcon);
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}