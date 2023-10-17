using Inscricao_Matricula.acessoBaseDeDados;
using Inscricao_Matricula.bean;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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

        public DetalhesForm(Estudante student, ListaEstudantes listaEstudantes)
        {
            InitializeComponent();
            estudanteDao = new EstudanteDao();
            this.student = student;
            conexao = new Conexao();

            

            this.listaEstudantes = listaEstudantes;
            dataGridView.CellFormatting += dataGridView_CellFormatting;

            // Chame a função para preencher o DataGridView com os detalhes do estudante.
            PreencherDataGridView();
        }



        private void PreencherDataGridView()
        {
            // Defina o DataGridView como somente leitura para exibição de dados.
            dataGridView.ReadOnly = true;

            // Adicione as colunas necessárias ao DataGridView.
            dataGridView.Columns.Add("", "");
            dataGridView.Columns.Add("", "");

            // Adicione as linhas com as propriedades e valores do estudante.
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

            // Ajuste as propriedades de exibição do DataGridView, se necessário.
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoResizeColumns();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifique se a célula é da coluna "Faculdade" (ou qualquer outra que você queira destacar).
            if (e.ColumnIndex == 0) // 0 é o índice da coluna "Faculdade"
            {
                // Defina um estilo diferente para a célula da coluna "Faculdade".
                e.CellStyle.Font = new Font("Arial", 13, FontStyle.Bold); // Use a fonte Arial, tamanho 14 e negrito
                e.CellStyle.ForeColor = Color.Black;

                // Você também pode ajustar outras propriedades de estilo, como fundo, bordas, etc., conforme necessário.
            }
            else
            {
                // Defina o estilo para outras colunas (valores).
                e.CellStyle.Font = new Font("Arial", 12); // Use a fonte Arial, tamanho 12 (ou outro tamanho desejado)
                e.CellStyle.ForeColor = Color.Black; // Pode ajustar a cor da fonte conforme necessário
            }
        }



        private void Imprimir_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "DataGridViewContent.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a PDF document
                    PdfSharp.Pdf.PdfDocument pdfDocument = new PdfSharp.Pdf.PdfDocument();
                    PdfSharp.Pdf.PdfPage page = pdfDocument.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Arial", 12);

                    int y = 20; // Initial Y position for text

                    // Loop through the DataGridView rows and add their content to the PDF
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        string column1 = row.Cells[0].Value?.ToString() ?? "";
                        string column2 = row.Cells[1].Value?.ToString() ?? "";
                        gfx.DrawString($"{column1}: {column2}", font, XBrushes.Black, new XRect(20, y, page.Width, page.Height), XStringFormats.TopLeft);
                        y += 20; // Increase Y position for the next line
                    }

                    // Save the PDF to the selected location
                    pdfDocument.Save(saveFileDialog.FileName);

                    // Notify the user that the PDF was created and offer to open it
                    MessageBox.Show($"PDF created successfully at: {saveFileDialog.FileName}", "PDF Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the saved PDF file
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
