using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inscricao_Matricula.acessoBaseDeDados;
using Inscricao_Matricula.bean;

namespace Inscricao_Matricula
{
    public partial class Matriculados : Form
    {
        private EstudanteDao matriculadosDao;

        public Matriculados()
        {
            InitializeComponent();
            matriculadosDao = new EstudanteDao();
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
    }
}
