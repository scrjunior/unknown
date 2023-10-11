using Inscricao_Matricula.acessoBaseDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscricao_Matricula
{
    public partial class ListaEstudantes : Form
    {
        private Conexao conexao;
        private EstudanteDao estudanteDao;
        public ListaEstudantes()
        {
            InitializeComponent();
            conexao = new Conexao();
            estudanteDao = new EstudanteDao();
        }

        private void PreencherTabela()
        {
            // Limpe a tabela antes de preenchê-la
            guna2DataGridView1.Rows.Clear();

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
            }
        }


        private void ListaEstudantes_Load(object sender, EventArgs e)
        {
            PreencherTabela(); // Preencha a tabela quando o formulário for carregado
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tabela
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Chama o método para preencher a tabela
            PreencherTabela();
        }

    }
}
