using Inscricao_Matricula.acessoBaseDeDados;
using Inscricao_Matricula.bean;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inscricao_Matricula
{
    public partial class AtualizeForm : Form
    {
        private Estudante student;

        private Conexao conexao;
        private EstudanteDao estudanteDao;
        private ListaEstudantes listaEstudantes;

        public AtualizeForm(Estudante student, ListaEstudantes listaEstudantes)
        {
            InitializeComponent();
            estudanteDao = new EstudanteDao();
            this.student = student;
            conexao = new Conexao();



            this.listaEstudantes = listaEstudantes;
            facul.Text = student.Faculdade;
            grauc.Text = student.Grau;
            turno.Text = student.Turno;
            nome.Text = student.Nome;
            apelido.Text = student.Apelido;
            paisNasc.Text = student.PaisNascimento;
            dataNasc.Text = student.DataNascimento.ToString("yyyy-MM-dd");
            provNasc.Text = student.ProvinciaNascimento;
            localNasc.Text = student.LocalNascimento;
            docum.Text = student.TipoDocumento;
            numDoc.Text = student.NumeroDocumento;
            nuit.Text = student.Nuit;
            genero.Text = student.Genero;
            celular.Text = student.Celular;
            curso.Text = student.NomeCurso;

        }

        private void atualizar_Click_1(object sender, EventArgs e)
        {
            if (student == null)
            {
                MessageBox.Show("Student information is not available.");
                return;
            }

            try
            {
                string updatedCursoNome = curso.Text; // Get the updated course name.

                // Consulta SQL to get the CursoID for the updated course name.
                string queryObterCursoID = "SELECT CursoID FROM cursos WHERE NomeCurso = @NomeCurso";

                using (var connection = conexao.AbrirConexao())
                {
                    MySqlCommand cmdObterCursoID = new MySqlCommand(queryObterCursoID, connection);
                    cmdObterCursoID.Parameters.AddWithValue("@NomeCurso", updatedCursoNome);

                    int cursoIDSelecionado = Convert.ToInt32(cmdObterCursoID.ExecuteScalar());

                    if (cursoIDSelecionado > 0)
                    {
                        string updatedFacul = facul.Text;
                        string updatedGrau = grauc.Text;
                        string updatedTurno = turno.Text;
                        string updatedApelido = apelido.Text;
                        string updatedNome = nome.Text;
                        DateTime updatedDataNascimento = Convert.ToDateTime(dataNasc.Text);
                        string updatedPaisNascimento = paisNasc.Text;
                        string updatedProvinciaNascimento = provNasc.Text;
                        string updatedLocalNascimento = localNasc.Text;
                        string updatedTipoDocumento = docum.Text;
                        string updatedNumeroDocumento = numDoc.Text;
                        string updatedNuit = nuit.Text;
                        string updatedGenero = genero.Text;
                        string updatedCelular = celular.Text;

                        // Create an Estudante object with the updated information
                        Estudante updatedStudent = new Estudante
                        {
                            EstudanteID = student.EstudanteID,
                            Faculdade = updatedFacul,
                            Grau = updatedGrau,
                            Turno = updatedTurno,
                            Apelido = updatedApelido,
                            Nome = updatedNome,
                            DataNascimento = updatedDataNascimento,
                            PaisNascimento = updatedPaisNascimento,
                            ProvinciaNascimento = updatedProvinciaNascimento,
                            LocalNascimento = updatedLocalNascimento,
                            TipoDocumento = updatedTipoDocumento,
                            NumeroDocumento = updatedNumeroDocumento,
                            Nuit = updatedNuit,
                            Genero = updatedGenero,
                            Celular = updatedCelular,
                            CursoID = cursoIDSelecionado // Use the updated CursoID.
                        };

                        // Call the update method in your EstudanteDao to update the student's information in the database
                        estudanteDao.AtualizarEstudante(updatedStudent);

                        listaEstudantes.PreencherTabela();

                        MessageBox.Show("Autalização realizada com sucesso!");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("O curso selecionado não é válido. Por favor, escolha um curso válido.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro MySQL: " + ex.Message);
                Console.WriteLine("Código de erro: " + ex.ErrorCode);
                MessageBox.Show("Ocorreu um erro ao tentar realizar a atualização.\nDetalhes: " + ex.Message + "\nCódigo de erro: " + ex.ErrorCode);
            }
        }



        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void facul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
