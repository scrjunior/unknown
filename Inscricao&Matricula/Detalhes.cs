using Inscricao_Matricula.acessoBaseDeDados;
using Inscricao_Matricula.bean;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;






namespace Inscricao_Matricula
{
    public partial class DetalhesForm : Form
    {
        private Estudante student;
        

        private Conexao conexao;
        private EstudanteDao estudanteDao;
        private ListaEstudantes listaEstudantes;
        private Matriculados matriculados;

        public DetalhesForm(Estudante student, ListaEstudantes listaEstudantes)
        {
            InitializeComponent();
            estudanteDao = new EstudanteDao();
            this.student = student;

            conexao = new Conexao();

            this.listaEstudantes = listaEstudantes;
            dataGridView.CellFormatting += dataGridView_CellFormatting;

            
            PreencherDataGridView();
        }

        public DetalhesForm(Estudante student, Matriculados matriculados)
        {
            InitializeComponent();
            estudanteDao = new EstudanteDao();
            this.student = student;
            conexao = new Conexao();
            this.matriculados = matriculados;

            
            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            
            dataGridView.ReadOnly = true;

            
            dataGridView.Columns.Add("", "");
            dataGridView.Columns.Add("", "");

            
            dataGridView.Rows.Add("Faculdade", student.Faculdade);
            dataGridView.Rows.Add("Grau", student.Grau);
            dataGridView.Rows.Add("Turno", student.Turno);
            dataGridView.Rows.Add("Codigo", student.EstudanteID);
            dataGridView.Rows.Add("Nome", student.Nome);
            dataGridView.Rows.Add("Apelido", student.Apelido);
            dataGridView.Rows.Add("País de Nascimento", student.PaisNascimento);
            dataGridView.Rows.Add("Data de Nascimento", student.DataNascimento.ToString("yyyy-MM-dd"));
            dataGridView.Rows.Add("Província de Nascimento", student.ProvinciaNascimento);
            dataGridView.Rows.Add("Local de Nascimento", student.LocalNascimento);
            dataGridView.Rows.Add("Tipo de Documento", student.TipoDocumento);
            dataGridView.Rows.Add("Número de Documento", student.NumeroDocumento);
            dataGridView.Rows.Add("Nuit", student.Nuit);
            dataGridView.Rows.Add("Gênero", student.Genero);
            dataGridView.Rows.Add("Celular", student.Celular);
            dataGridView.Rows.Add("Curso", student.NomeCurso);
            


            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoResizeColumns();
        }

        

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {
                
                e.CellStyle.Font = new Font("Arial", 13, FontStyle.Bold); 
                e.CellStyle.ForeColor = Color.Black;

                
            }
            else
            {
                
                e.CellStyle.Font = new Font("Arial", 12); 
                e.CellStyle.ForeColor = Color.Black; 
            }
        }



        private void Imprimir_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar Ficheiro PDF";
                saveFileDialog.FileName = "Detalhes do Estudante.pdf"; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    PdfSharp.Pdf.PdfDocument pdfDocument = new PdfSharp.Pdf.PdfDocument();
                    PdfSharp.Pdf.PdfPage page = pdfDocument.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Arial", 12);

                    int y = 20; 

                    
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        string column1 = row.Cells[0].Value?.ToString() ?? "";
                        string column2 = row.Cells[1].Value?.ToString() ?? "";
                        gfx.DrawString($"{column1}: {column2}", font, XBrushes.Black, new XRect(20, y, page.Width, page.Height), XStringFormats.TopLeft);
                        y += 20; 
                    }

                    
                    pdfDocument.Save(saveFileDialog.FileName);

                    
                    MessageBox.Show($"PDF gerado com sucesso em: {saveFileDialog.FileName}", "PDF Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    Process.Start(saveFileDialog.FileName);
                }
            }
        }




        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void facul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    }
}
