using Inscricao_Matricula.acessoBaseDeDados;
using Inscricao_Matricula.bean;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace Inscricao_Matricula
{
    public partial class ListaEstudantes : Form
    {
        private Conexao conexao;
        private EstudanteDao estudanteDao;
        private DetalhesForm detalhesForm = null;
        public ListaEstudantes()
        {
            InitializeComponent();
            conexao = new Conexao();
            estudanteDao = new EstudanteDao();
            guna2DataGridView1.CellClick -= DataGridViewButton_Click;


        }

        public void PreencherTabela()
        {
            // Limpe a tabela antes de preenchê-la
            guna2DataGridView1.Rows.Clear();
            guna2DataGridView1.CellContentClick += DataGridViewButton_Click;

            // Aqui você deve buscar a lista de estudantes com informações de curso
            var listaEstudantes = estudanteDao.SelecionarEstudantesComCurso();

            if (listaEstudantes != null && listaEstudantes.Count > 0)
            {
                foreach (var estudante in listaEstudantes)
                {
                    

                    // Adicione uma nova linha na tabela para cada estudante
                    guna2DataGridView1.Rows.Add(
                        estudante.EstudanteID,
                        estudante.Nome,
                        estudante.Apelido,
                        estudante.Grau,
                        estudante.NomeCurso, // Nome do curso
                        estudante.Faculdade
                    );
                }


               


                guna2DataGridView1.AutoResizeColumns();
            }
        }

        private void DataGridViewButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == guna2DataGridView1.Columns["Ação"].Index && e.RowIndex >= 0)
            {
                int estudanteID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["EstudanteID"].Value);

                // Call the DAO method to delete the student
                estudanteDao.DeletarEstudante(estudanteID);

                // Remove the row from the DataGridView
                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            else if (e.ColumnIndex == guna2DataGridView1.Columns["Detalhes"].Index && e.RowIndex >= 0)
            {
                int estudanteID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["EstudanteID"].Value);

                if (detalhesForm == null || detalhesForm.IsDisposed)
                {
                    // O formulário DetalhesForm ainda não está aberto ou foi fechado, então crie uma nova instância.
                    Estudante student = estudanteDao.SelecionarEstudantePorID(estudanteID);
                    detalhesForm = new DetalhesForm(student, this);
                }

                detalhesForm.Show();
            }
            else if (e.ColumnIndex == guna2DataGridView1.Columns["Matricula"].Index && e.RowIndex >= 0)
            {
                // Recuperar o nome do curso e o Código (que corresponde ao EstudanteID) da linha selecionada.
                string nomeCurso = guna2DataGridView1.Rows[e.RowIndex].Cells["CursoID"].Value.ToString();
                int codigoEstudante = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["EstudanteID"].Value);

                // Lógica para obter o ID do curso a partir do nome do curso (você precisará implementar isso).
                int cursoID = ObterIDDoCursoPeloNome(nomeCurso);

                if (cursoID > 0)
                {
                    // Verificar se o estudante já está matriculado no curso.
                    bool jaMatriculado = estudanteDao.VerificarMatriculaExistente(codigoEstudante, cursoID);

                    if (!jaMatriculado)
                    {
                        // Lógica para matricular o estudante com os IDs do curso e Código (EstudanteID).
                        estudanteDao.MatricularEstudante(codigoEstudante, cursoID, DateTime.Now.Year); // Use o ano atual como AnoMatricula
                        MessageBox.Show("Estudante matriculado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Este estudante já está matriculado neste curso. Não é permitido matricular o mesmo estudante duas vezes no mesmo curso.");
                    }
                }
                else
                {
                    MessageBox.Show("O curso selecionado não é válido. Por favor, escolha um curso válido.");
                }
            }



        }

        public int ObterIDDoCursoPeloNome(string nomeCurso)
        {
            using (var connection = conexao.AbrirConexao())
            {
                string query = "SELECT CursoID FROM cursos WHERE NomeCurso = @NomeCurso";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NomeCurso", nomeCurso);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1; // Retorne -1 se o curso não for encontrado.
            }
        }


        private void campo_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = campo.Text;
            PreencherTabelaComFiltro(termoPesquisa);
        }

        private void PreencherTabelaComFiltro(string termoPesquisa)
        {
            guna2DataGridView1.Rows.Clear();

            var termoPesquisaLower = termoPesquisa.ToLower(); // Converter o termo de pesquisa para minúsculas

            var listaEstudantes = estudanteDao.SelecionarEstudantesComCurso().Where(estudante =>
                estudante.Nome.ToLower().Contains(termoPesquisaLower) ||
                estudante.Apelido.ToLower().Contains(termoPesquisaLower) ||
                estudante.Grau.ToLower().Contains(termoPesquisaLower) ||
                estudante.NomeCurso.ToLower().Contains(termoPesquisaLower) ||
                estudante.Faculdade.ToLower().Contains(termoPesquisaLower) ||
                estudante.EstudanteID.ToString().Contains(termoPesquisa) // Pesquisa também por números
            ).ToList();

            if (listaEstudantes != null && listaEstudantes.Count > 0)
            {
                foreach (var estudante in listaEstudantes)
                {
                    guna2DataGridView1.Rows.Add(
                        estudante.EstudanteID,
                        estudante.Nome,
                        estudante.Apelido,
                        estudante.Grau,
                        estudante.NomeCurso,
                        estudante.Faculdade
                    );
                }

                guna2DataGridView1.AutoResizeColumns();
            }
        }



        private void pesquisar_Click(object sender, EventArgs e)
        {
            //botão pesquisar
        }
    }
}
