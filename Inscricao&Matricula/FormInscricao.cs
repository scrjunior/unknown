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
            // Validação para garantir que nenhum dos campos obrigatórios esteja em branco
            if (string.IsNullOrWhiteSpace(facul.Text) ||
                string.IsNullOrWhiteSpace(grauc.Text) ||
                string.IsNullOrWhiteSpace(turno.Text) ||
                string.IsNullOrWhiteSpace(apelido.Text) ||
                string.IsNullOrWhiteSpace(nome.Text) ||
                string.IsNullOrWhiteSpace(dataNasc.Text) ||
                string.IsNullOrWhiteSpace(paisNasc.Text) ||
                string.IsNullOrWhiteSpace(provNasc.Text) ||
                string.IsNullOrWhiteSpace(localNasc.Text) ||
                string.IsNullOrWhiteSpace(docum.Text) ||
                string.IsNullOrWhiteSpace(numDoc.Text) ||
                string.IsNullOrWhiteSpace(nuit.Text) ||
                string.IsNullOrWhiteSpace(genero.Text) ||
                string.IsNullOrWhiteSpace(celular.Text) ||
                string.IsNullOrWhiteSpace(curso.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios antes de continuar.");
                return; // Sai do evento se a validação falhar.
            }

            if (!long.TryParse(nuit.Text, out _))
            {
                MessageBox.Show("O campo Nuit deve conter apenas números.");
                return; // Sai do evento se a validação falhar.
            }

            // Validação para garantir que "Celular" contenha apenas números
            if (!int.TryParse(celular.Text, out _))
            {
                MessageBox.Show("O campo Celular deve conter apenas números.");
                return; // Sai do evento se a validação falhar.
            }

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
