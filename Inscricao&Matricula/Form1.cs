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

            // Oculte o FormInscricao no construtor
            formInscricao.Hide();
        }


        private void inscricao_Click(object sender, EventArgs e)
        {
            // Certifique-se de que o FormListaEstudantes também está oculto
            listaEstudantes.Hide();

            // Exiba o FormInscricao
            formInscricao.Show();
            formInscricao.Dock = DockStyle.Fill;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Certifique-se de que o FormInscricao também está oculto
            formInscricao.Hide();

            // Exiba o FormListaEstudantes
            listaEstudantes.Show();
            listaEstudantes.Dock = DockStyle.Fill;
        }
    }
}
