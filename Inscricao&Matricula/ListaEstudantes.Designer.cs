namespace Inscricao_Matricula
{
    partial class ListaEstudantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.campo = new Guna.UI2.WinForms.Guna2TextBox();
            this.EstudanteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ação = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Snow;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(37, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(185, 26);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Lista dos Estudantes";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstudanteID,
            this.Nome,
            this.Apelido,
            this.Grau,
            this.CursoID,
            this.Faculdade,
            this.Detalhes,
            this.Ação,
            this.Matricula});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(52, 206);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gadugi", 14.25F);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowTemplate.Height = 40;
            this.guna2DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1016, 328);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // campo
            // 
            this.campo.BorderRadius = 2;
            this.campo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.campo.DefaultText = "";
            this.campo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.campo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.campo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.campo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.campo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.campo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.campo.Location = new System.Drawing.Point(55, 123);
            this.campo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campo.Name = "campo";
            this.campo.PasswordChar = '\0';
            this.campo.PlaceholderText = "Buscar Estudante";
            this.campo.SelectedText = "";
            this.campo.Size = new System.Drawing.Size(288, 38);
            this.campo.TabIndex = 1;
            this.campo.TextChanged += new System.EventHandler(this.campo_TextChanged);
            // 
            // EstudanteID
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudanteID.DefaultCellStyle = dataGridViewCellStyle3;
            this.EstudanteID.HeaderText = "Codigo";
            this.EstudanteID.Name = "EstudanteID";
            this.EstudanteID.ReadOnly = true;
            this.EstudanteID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nome
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.Nome.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Apelido
            // 
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            // 
            // Grau
            // 
            this.Grau.HeaderText = "Grau";
            this.Grau.Name = "Grau";
            this.Grau.ReadOnly = true;
            // 
            // CursoID
            // 
            this.CursoID.HeaderText = "Curso";
            this.CursoID.Name = "CursoID";
            this.CursoID.ReadOnly = true;
            // 
            // Faculdade
            // 
            this.Faculdade.HeaderText = "Faculdade";
            this.Faculdade.Name = "Faculdade";
            this.Faculdade.ReadOnly = true;
            // 
            // Detalhes
            // 
            this.Detalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalhes.DefaultCellStyle = dataGridViewCellStyle5;
            this.Detalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalhes.HeaderText = "Detalhes";
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.ReadOnly = true;
            this.Detalhes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalhes.Text = "Ver";
            this.Detalhes.UseColumnTextForButtonValue = true;
            this.Detalhes.Width = 80;
            // 
            // Ação
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ação.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ação.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ação.HeaderText = "Ação";
            this.Ação.Name = "Ação";
            this.Ação.ReadOnly = true;
            this.Ação.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ação.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ação.Text = "Apagar";
            this.Ação.UseColumnTextForButtonValue = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Text = "Matricular";
            this.Matricula.UseColumnTextForButtonValue = true;
            // 
            // ListaEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 659);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.campo);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaEstudantes";
            this.Text = "ListaEstudantes";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox campo;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudanteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grau;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculdade;
        private System.Windows.Forms.DataGridViewButtonColumn Detalhes;
        private System.Windows.Forms.DataGridViewButtonColumn Ação;
        private System.Windows.Forms.DataGridViewButtonColumn Matricula;
    }
}