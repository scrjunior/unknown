using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inscricao_Matricula.acessoBaseDeDados;
using Inscricao_Matricula.bean;

namespace Inscricao_Matricula
{
    public partial class Matriculados : Form
    {
        private Conexao conexao;
        private EstudanteDao matriculadosDao;
        private DetalhesForm detalhesForm = null;
        private EstudanteDao estudanteDao;

        public Matriculados()
        {
            InitializeComponent();
            estudanteDao = new EstudanteDao(); 
            matriculadosDao = new EstudanteDao();
            conexao = new Conexao();
            PreencherTabela();
        }

        public void PreencherTabela()
        {
            guna2DataGridView1.Rows.Clear();

            var listaEstudantesMatriculados = matriculadosDao.SelecionarEstudantesMatriculados();

            if (listaEstudantesMatriculados != null && listaEstudantesMatriculados.Count > 0)
            {
                foreach (var estudante in listaEstudantesMatriculados)
                {
                    guna2DataGridView1.Rows.Add(
                        estudante.Codigo,
                        estudante.Nome,
                        estudante.Apelido,
                        estudante.Curso,
                        estudante.Faculdade,
                        estudante.IDMatricula,
                        estudante.Ano
                        
                    );
                }

                guna2DataGridView1.AutoResizeColumns();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == guna2DataGridView1.Columns["Detalhes"].Index)
            {
                int estudanteID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["EstudanteID"].Value);

                if (detalhesForm == null || detalhesForm.IsDisposed)
                {
                    Estudante student = estudanteDao.SelecionarEstudantePorID(estudanteID);
                    detalhesForm = new DetalhesForm(student, this);
                }

                if (detalhesForm != null)
                {
                    detalhesForm.Show();
                }
            }
        }

        private void IDMatricula_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                
                int matriculaID = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["MatriculaID"].Value);

                
                estudanteDao.ApagarEstudanteDaMatricula(matriculaID);

                
                PreencherTabela();
            }
            else
            {
                MessageBox.Show("Selecione uma linha na tabela de Matrícula antes de clicar no botão de apagar.");
            }
        }

        private void campo_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = campo.Text;
            PreencherTabelaComFiltro(termoPesquisa);
        }

        private void PreencherTabelaComFiltro(string termoPesquisa, int idMatricula = -1, int ano = -1)
        {
            guna2DataGridView1.Rows.Clear();

            var termoPesquisaLower = termoPesquisa.ToLower(); 

            var listaEstudantes = estudanteDao.SelecionarEstudantesMatriculados().Where(estudante =>
                (idMatricula == -1 || estudante.IDMatricula == idMatricula) &&
                (ano == -1 || estudante.Ano == ano) &&
                estudante.Nome.ToLower().Contains(termoPesquisaLower) ||
                estudante.Apelido.ToLower().Contains(termoPesquisaLower) ||
                estudante.Curso.ToLower().Contains(termoPesquisaLower) ||
                estudante.Faculdade.ToLower().Contains(termoPesquisaLower) ||
                estudante.Ano.ToString().Contains(termoPesquisa) ||
                estudante.IDMatricula.ToString().Contains(termoPesquisa) ||
                estudante.Codigo.ToString().Contains(termoPesquisa)
            ).ToList();

            if (listaEstudantes != null && listaEstudantes.Count > 0)
            {
                foreach (var estudante in listaEstudantes)
                {
                    guna2DataGridView1.Rows.Add(
                        estudante.Codigo,
                        estudante.Nome,
                        estudante.Apelido,
                        estudante.Curso,
                        estudante.Faculdade,
                        estudante.IDMatricula,
                        estudante.Ano
                    );
                }

                guna2DataGridView1.AutoResizeColumns();
            }
        }


    }
}
