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
        private AtualizeForm atualizeForm = null;
        public ListaEstudantes()
        {
            InitializeComponent();
            conexao = new Conexao();
            estudanteDao = new EstudanteDao();
            guna2DataGridView1.CellClick -= DataGridViewButton_Click;


        }

        public void PreencherTabela()
        {
           
            guna2DataGridView1.Rows.Clear();
            guna2DataGridView1.CellContentClick += DataGridViewButton_Click;

            
            var listaEstudantes = estudanteDao.SelecionarEstudantesComCurso();

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
                        estudante.Faculdade,
                        estudante.Matricula
                    );
                }

                guna2DataGridView1.AutoResizeColumns();
            }
        }

        private List<int> estudantesParaExcluir = new List<int>();
        private bool deleting = false;
        private void DataGridViewButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < guna2DataGridView1.Rows.Count)
            {
            
                if (e.ColumnIndex == guna2DataGridView1.Columns["Detalhes"].Index)
                {
                    int estudanteID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["EstudanteID"].Value);

                    if (detalhesForm == null || detalhesForm.IsDisposed)
                    {
                        
                        Estudante student = estudanteDao.SelecionarEstudantePorID(estudanteID);
                        detalhesForm = new DetalhesForm(student, this);
                    }

                    detalhesForm.Show();
                }else if (e.ColumnIndex == guna2DataGridView1.Columns["atualiza"].Index)
                {
                    int estudanteID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["EstudanteID"].Value);

                    if (atualizeForm == null || atualizeForm.IsDisposed)
                    {
                        
                        Estudante student = estudanteDao.SelecionarEstudantePorID(estudanteID);
                        atualizeForm = new AtualizeForm(student, this);
                    }

                    atualizeForm.Show();
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
                return -1; 
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

            var termoPesquisaLower = termoPesquisa.ToLower(); 

            var listaEstudantes = estudanteDao.SelecionarEstudantesComCurso().Where(estudante =>
                estudante.Nome.ToLower().Contains(termoPesquisaLower) ||
                estudante.Apelido.ToLower().Contains(termoPesquisaLower) ||
                estudante.Grau.ToLower().Contains(termoPesquisaLower) ||
                estudante.NomeCurso.ToLower().Contains(termoPesquisaLower) ||
                estudante.Faculdade.ToLower().Contains(termoPesquisaLower) ||
                estudante.Matricula.ToLower().Contains(termoPesquisaLower) ||
                estudante.EstudanteID.ToString().Contains(termoPesquisa) 
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
                        estudante.Faculdade,
                        estudante.Matricula
                    );
                }

                guna2DataGridView1.AutoResizeColumns();
            }
        }



        private void pesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Matricula_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                int rowIndex = selectedRow.Index;
                string nomeCurso = selectedRow.Cells["CursoID"].Value.ToString();
                int codigoEstudante = Convert.ToInt32(selectedRow.Cells["EstudanteID"].Value);

                
                int cursoID = ObterIDDoCursoPeloNome(nomeCurso);

                if (cursoID > 0)
                {
                    
                    bool jaMatriculado = estudanteDao.VerificarMatriculaExistente(codigoEstudante, cursoID);

                    if (!jaMatriculado)
                    {
                        
                        estudanteDao.MatricularEstudante(codigoEstudante, cursoID, DateTime.Now.Year);
                        MessageBox.Show("Estudante matriculado com sucesso!");
                        PreencherTabela();
                        
                        
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



        private void Ação_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                int estudanteID = Convert.ToInt32(selectedRow.Cells["EstudanteID"].Value);

                
                estudanteDao.DeletarEstudante(estudanteID);

                
                guna2DataGridView1.Rows.Remove(selectedRow);
            }
        }

    }
}
