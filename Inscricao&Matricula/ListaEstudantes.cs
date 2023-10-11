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
        public ListaEstudantes()
        {
            InitializeComponent();
            conexao = new Conexao();
        }
    }
}
