using Inscricao_Matricula.acessoBaseDeDados;
using Inscricao_Matricula.bean;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inscricao_Matricula
{
    public partial class FormInscricao : Form
    {
        private Conexao conexao;

        public FormInscricao()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void inscrever_Click(object sender, EventArgs e)
        {
            try
            {
                string cursoSelecionado = curso.SelectedItem.ToString();

                // Consulta SQL para obter o ID do curso com base no nome
                string queryObterCursoID = "SELECT CursoID FROM cursos WHERE NomeCurso = @NomeCurso";

                using (var connection = conexao.AbrirConexao())
                {
                    MySqlCommand cmdObterCursoID = new MySqlCommand(queryObterCursoID, connection);
                    cmdObterCursoID.Parameters.AddWithValue("@NomeCurso", cursoSelecionado);

                    int cursoIDSelecionado = Convert.ToInt32(cmdObterCursoID.ExecuteScalar());

                    // Verifica se o CursoID é válido (maior que zero)
                    if (cursoIDSelecionado > 0)
                    {
                        // Cria um novo objeto Estudante com os dados do formulário
                        Estudante novoEstudante = new Estudante
                        {
                            Faculdade = facul.Text,
                            Grau = grauc.Text,
                            Turno = turno.Text,
                            Apelido = apelido.Text,
                            Nome = nome.Text,
                            DataNascimento = Convert.ToDateTime(dataNasc.Text),
                            PaisNascimento = paisNasc.Text,
                            ProvinciaNascimento = provNasc.Text,
                            LocalNascimento = localNasc.Text,
                            TipoDocumento = docum.Text,
                            NumeroDocumento = numDoc.Text,
                            Nuit = nuit.Text,
                            Genero = genero.Text,
                            Celular = celular.Text,
                            CursoID = cursoIDSelecionado
                        };

                        var estudanteDao = new EstudanteDao();
                        estudanteDao.InserirEstudante(novoEstudante, cursoIDSelecionado);

                        // Notificar o usuário que a inscrição foi realizada com sucesso
                        MessageBox.Show("Inscrição realizada com sucesso!");
                    }
                    else
                    {
                        // Exibe uma mensagem de erro se o CursoID não for válido
                        MessageBox.Show("O curso selecionado não é válido. Por favor, escolha um curso válido.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro MySQL: " + ex.Message);
                Console.WriteLine("Código de erro: " + ex.ErrorCode);
                // Exibir a mensagem completa da exceção
                MessageBox.Show("Ocorreu um erro ao tentar realizar a inscrição.\nDetalhes: " + ex.Message + "\nCódigo de erro: " + ex.ErrorCode);
            }
        }
    }
}
