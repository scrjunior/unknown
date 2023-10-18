using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Inscricao_Matricula.acessoBaseDeDados;

namespace Inscricao_Matricula
{
    public partial class login : Form
    {
        private Conexao conexao;

        public login()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void acessar_Click(object sender, EventArgs e)
        {
            string usuario = Usuario.Text;
            string senha = Senha.Text;

            
            string query = "SELECT * FROM administrador WHERE Usuario = @usuario AND Senha = @senha";

            try
            {
                using (MySqlConnection mySqlConnection = conexao.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@senha", senha);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                
                                MessageBox.Show("Login bem-sucedido!");

                                
                                MostrarForm1();
                            }
                            else if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
                            {
                                MessageBox.Show("Por favor, preencha ambos os campos de usuário e senha.");
                                return;  
                            }
                            else
                            {
                                MessageBox.Show("Credenciais inválidas. Tente novamente.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao autenticar: " + ex.Message);
            }
        }

        private void MostrarForm1()
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close(); 
            form1.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
