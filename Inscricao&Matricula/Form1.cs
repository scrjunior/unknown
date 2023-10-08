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
        public Form1()
        {
            InitializeComponent();
            formInscricao = new FormInscricao();
            formInscricao.TopLevel = false;
            PainelControl.Controls.Add(formInscricao);
        }

        
        private void inscricao_Click(object sender, EventArgs e)
        {
            // Exibe o formulário de inscrição
            formInscricao.Show();

            // Posicione o formulário de inscrição dentro do painel
            formInscricao.Dock = DockStyle.Fill;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
