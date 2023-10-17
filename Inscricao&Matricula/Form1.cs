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
    public partial class Form1 : Form
    {
        private FormInscricao formInscricao;
        private Matriculados matriculados;
        private ListaEstudantes listaEstudantes;
        public Form1()
        {
            InitializeComponent();
            formInscricao = new FormInscricao();
            formInscricao.TopLevel = false;
            PainelControl.Controls.Add(formInscricao);

            listaEstudantes = new ListaEstudantes();
            listaEstudantes.TopLevel = false;
            PainelControl.Controls.Add(listaEstudantes);

            matriculados = new Matriculados();
            matriculados.TopLevel = false;
            PainelControl.Controls.Add(matriculados);

            
            formInscricao.Hide();
        }


        private void inscricao_Click(object sender, EventArgs e)
        {
            
            listaEstudantes.Hide();

           
            formInscricao.Show();
            formInscricao.Dock = DockStyle.Fill;
            seuControleDeTexto.Text = string.Empty;
            seuControleDeTexto2.Text = string.Empty;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            listaEstudantes.Hide();
            formInscricao.Hide();

            matriculados.Show();
            matriculados.Dock = DockStyle.Fill;
            matriculados.PreencherTabela();
            seuControleDeTexto.Text = string.Empty;
            seuControleDeTexto2.Text = string.Empty;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
         
            formInscricao.Hide();

            //botão que carrega o form que contem tabelas

            
            listaEstudantes.Show();
            listaEstudantes.Dock = DockStyle.Fill;
            listaEstudantes.PreencherTabela();
            seuControleDeTexto.Text = string.Empty;
            seuControleDeTexto2.Text = string.Empty;
        }

        private void PainelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
