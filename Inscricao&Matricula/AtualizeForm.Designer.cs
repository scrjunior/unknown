namespace Inscricao_Matricula
{
    partial class AtualizeForm
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
            this.curso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.genero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.celular = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nuit = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numDoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.docum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.localNasc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.provNasc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataNasc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.paisNasc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.turno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grauc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facul = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.apelido = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // curso
            // 
            this.curso.BackColor = System.Drawing.Color.Transparent;
            this.curso.BorderRadius = 5;
            this.curso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curso.FillColor = System.Drawing.SystemColors.Control;
            this.curso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.curso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.curso.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.curso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.curso.ItemHeight = 30;
            this.curso.Items.AddRange(new object[] {
            "Tecnologias de informação",
            "Construção Civil",
            "Agronomia",
            "Mecatronica",
            "Psicologia"});
            this.curso.Location = new System.Drawing.Point(53, 366);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(310, 36);
            this.curso.TabIndex = 98;
            // 
            // atualizar
            // 
            this.atualizar.BorderRadius = 5;
            this.atualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.atualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.atualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.atualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.atualizar.FillColor = System.Drawing.Color.RoyalBlue;
            this.atualizar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.ForeColor = System.Drawing.Color.White;
            this.atualizar.Location = new System.Drawing.Point(454, 541);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(180, 45);
            this.atualizar.TabIndex = 97;
            this.atualizar.Text = "Atualizar";
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click_1);
            // 
            // genero
            // 
            this.genero.BackColor = System.Drawing.Color.Transparent;
            this.genero.BorderRadius = 5;
            this.genero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genero.FillColor = System.Drawing.SystemColors.Control;
            this.genero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genero.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genero.ItemHeight = 30;
            this.genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminio"});
            this.genero.Location = new System.Drawing.Point(718, 366);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(310, 36);
            this.genero.TabIndex = 96;
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(53, 337);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(51, 23);
            this.guna2HtmlLabel15.TabIndex = 95;
            this.guna2HtmlLabel15.Text = "Curso";
            // 
            // celular
            // 
            this.celular.BorderRadius = 5;
            this.celular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.celular.DefaultText = "";
            this.celular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.celular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.celular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.celular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.celular.FillColor = System.Drawing.SystemColors.Control;
            this.celular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.celular.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.celular.ForeColor = System.Drawing.Color.Black;
            this.celular.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.celular.Location = new System.Drawing.Point(718, 464);
            this.celular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.celular.Name = "celular";
            this.celular.PasswordChar = '\0';
            this.celular.PlaceholderForeColor = System.Drawing.Color.Black;
            this.celular.PlaceholderText = "";
            this.celular.SelectedText = "";
            this.celular.Size = new System.Drawing.Size(310, 36);
            this.celular.TabIndex = 94;
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(718, 435);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(62, 23);
            this.guna2HtmlLabel14.TabIndex = 93;
            this.guna2HtmlLabel14.Text = "Celular";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(718, 337);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(63, 23);
            this.guna2HtmlLabel13.TabIndex = 92;
            this.guna2HtmlLabel13.Text = "Genero";
            // 
            // nuit
            // 
            this.nuit.BorderRadius = 5;
            this.nuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nuit.DefaultText = "";
            this.nuit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nuit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nuit.FillColor = System.Drawing.SystemColors.Control;
            this.nuit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nuit.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.nuit.ForeColor = System.Drawing.Color.Black;
            this.nuit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nuit.Location = new System.Drawing.Point(718, 286);
            this.nuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuit.Name = "nuit";
            this.nuit.PasswordChar = '\0';
            this.nuit.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nuit.PlaceholderText = "";
            this.nuit.SelectedText = "";
            this.nuit.Size = new System.Drawing.Size(310, 36);
            this.nuit.TabIndex = 91;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(718, 257);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(46, 23);
            this.guna2HtmlLabel12.TabIndex = 90;
            this.guna2HtmlLabel12.Text = "NUIT";
            // 
            // numDoc
            // 
            this.numDoc.BorderRadius = 5;
            this.numDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDoc.DefaultText = "";
            this.numDoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numDoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numDoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numDoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numDoc.FillColor = System.Drawing.SystemColors.Control;
            this.numDoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numDoc.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.numDoc.ForeColor = System.Drawing.Color.Black;
            this.numDoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numDoc.Location = new System.Drawing.Point(718, 197);
            this.numDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDoc.Name = "numDoc";
            this.numDoc.PasswordChar = '\0';
            this.numDoc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.numDoc.PlaceholderText = "";
            this.numDoc.SelectedText = "";
            this.numDoc.Size = new System.Drawing.Size(310, 36);
            this.numDoc.TabIndex = 89;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(718, 168);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(194, 23);
            this.guna2HtmlLabel11.TabIndex = 88;
            this.guna2HtmlLabel11.Text = "Número de Documento";
            // 
            // docum
            // 
            this.docum.BackColor = System.Drawing.Color.Transparent;
            this.docum.BorderRadius = 5;
            this.docum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.docum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docum.FillColor = System.Drawing.SystemColors.Control;
            this.docum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.docum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.docum.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.docum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.docum.ItemHeight = 30;
            this.docum.Items.AddRange(new object[] {
            "BI",
            "Passaporte",
            "DIRE"});
            this.docum.Location = new System.Drawing.Point(718, 102);
            this.docum.Name = "docum";
            this.docum.Size = new System.Drawing.Size(310, 36);
            this.docum.TabIndex = 87;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(718, 73);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(165, 23);
            this.guna2HtmlLabel10.TabIndex = 86;
            this.guna2HtmlLabel10.Text = "Tipo de Documento";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(386, 435);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(178, 23);
            this.guna2HtmlLabel9.TabIndex = 85;
            this.guna2HtmlLabel9.Text = "Local de Nascimento";
            // 
            // localNasc
            // 
            this.localNasc.BorderRadius = 5;
            this.localNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.localNasc.DefaultText = "";
            this.localNasc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.localNasc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.localNasc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.localNasc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.localNasc.FillColor = System.Drawing.SystemColors.Control;
            this.localNasc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.localNasc.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.localNasc.ForeColor = System.Drawing.Color.Black;
            this.localNasc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.localNasc.Location = new System.Drawing.Point(386, 464);
            this.localNasc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.localNasc.Name = "localNasc";
            this.localNasc.PasswordChar = '\0';
            this.localNasc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.localNasc.PlaceholderText = "";
            this.localNasc.SelectedText = "";
            this.localNasc.Size = new System.Drawing.Size(310, 36);
            this.localNasc.TabIndex = 84;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(386, 337);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(210, 23);
            this.guna2HtmlLabel8.TabIndex = 83;
            this.guna2HtmlLabel8.Text = "Província de Nascimento";
            // 
            // provNasc
            // 
            this.provNasc.BorderRadius = 5;
            this.provNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.provNasc.DefaultText = "";
            this.provNasc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.provNasc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.provNasc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.provNasc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.provNasc.FillColor = System.Drawing.SystemColors.Control;
            this.provNasc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.provNasc.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.provNasc.ForeColor = System.Drawing.Color.Black;
            this.provNasc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.provNasc.Location = new System.Drawing.Point(386, 366);
            this.provNasc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.provNasc.Name = "provNasc";
            this.provNasc.PasswordChar = '\0';
            this.provNasc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.provNasc.PlaceholderText = "";
            this.provNasc.SelectedText = "";
            this.provNasc.Size = new System.Drawing.Size(310, 36);
            this.provNasc.TabIndex = 82;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(386, 257);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(169, 23);
            this.guna2HtmlLabel7.TabIndex = 81;
            this.guna2HtmlLabel7.Text = "País de Nascimento";
            // 
            // dataNasc
            // 
            this.dataNasc.Animated = true;
            this.dataNasc.BorderRadius = 5;
            this.dataNasc.Checked = true;
            this.dataNasc.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataNasc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataNasc.Location = new System.Drawing.Point(386, 197);
            this.dataNasc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataNasc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(310, 36);
            this.dataNasc.TabIndex = 80;
            this.dataNasc.Value = new System.DateTime(2023, 10, 7, 22, 8, 18, 109);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(386, 168);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(173, 23);
            this.guna2HtmlLabel6.TabIndex = 79;
            this.guna2HtmlLabel6.Text = "Data de Nascimento";
            // 
            // paisNasc
            // 
            this.paisNasc.BorderRadius = 5;
            this.paisNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paisNasc.DefaultText = "";
            this.paisNasc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paisNasc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.paisNasc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paisNasc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paisNasc.FillColor = System.Drawing.SystemColors.Control;
            this.paisNasc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paisNasc.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.paisNasc.ForeColor = System.Drawing.Color.Black;
            this.paisNasc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paisNasc.Location = new System.Drawing.Point(386, 286);
            this.paisNasc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paisNasc.Name = "paisNasc";
            this.paisNasc.PasswordChar = '\0';
            this.paisNasc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.paisNasc.PlaceholderText = "";
            this.paisNasc.SelectedText = "";
            this.paisNasc.Size = new System.Drawing.Size(310, 36);
            this.paisNasc.TabIndex = 78;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(386, 73);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(51, 23);
            this.guna2HtmlLabel5.TabIndex = 77;
            this.guna2HtmlLabel5.Text = "Nome";
            // 
            // nome
            // 
            this.nome.BorderRadius = 5;
            this.nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nome.DefaultText = "";
            this.nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nome.FillColor = System.Drawing.SystemColors.Control;
            this.nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nome.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.nome.ForeColor = System.Drawing.Color.Black;
            this.nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nome.Location = new System.Drawing.Point(386, 102);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nome.Name = "nome";
            this.nome.PasswordChar = '\0';
            this.nome.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nome.PlaceholderText = "";
            this.nome.SelectedText = "";
            this.nome.Size = new System.Drawing.Size(310, 36);
            this.nome.TabIndex = 76;
            // 
            // turno
            // 
            this.turno.BackColor = System.Drawing.Color.Transparent;
            this.turno.BorderRadius = 5;
            this.turno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turno.FillColor = System.Drawing.SystemColors.Control;
            this.turno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.turno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.turno.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.turno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.turno.ItemHeight = 30;
            this.turno.Items.AddRange(new object[] {
            "Laboral",
            "Pos Laboral"});
            this.turno.Location = new System.Drawing.Point(53, 286);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(310, 36);
            this.turno.TabIndex = 75;
            // 
            // grauc
            // 
            this.grauc.BackColor = System.Drawing.Color.Transparent;
            this.grauc.BorderRadius = 5;
            this.grauc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grauc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grauc.FillColor = System.Drawing.SystemColors.Control;
            this.grauc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grauc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grauc.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.grauc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.grauc.ItemHeight = 30;
            this.grauc.Items.AddRange(new object[] {
            "Bacharel",
            "Licenciatura",
            "Mestrado",
            "Doutorado"});
            this.grauc.Location = new System.Drawing.Point(53, 197);
            this.grauc.Name = "grauc";
            this.grauc.Size = new System.Drawing.Size(310, 36);
            this.grauc.TabIndex = 74;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(53, 168);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(43, 23);
            this.guna2HtmlLabel4.TabIndex = 73;
            this.guna2HtmlLabel4.Text = "Grau";
            // 
            // facul
            // 
            this.facul.BackColor = System.Drawing.Color.Transparent;
            this.facul.BorderRadius = 5;
            this.facul.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.facul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facul.FillColor = System.Drawing.SystemColors.Control;
            this.facul.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facul.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.facul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.facul.ItemHeight = 30;
            this.facul.Items.AddRange(new object[] {
            "Faculdade de Engenharia",
            "Faculdade de Ciencias",
            "Faculdade de Informática e Turismo"});
            this.facul.Location = new System.Drawing.Point(53, 102);
            this.facul.Name = "facul";
            this.facul.Size = new System.Drawing.Size(310, 36);
            this.facul.TabIndex = 72;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(53, 73);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(88, 23);
            this.guna2HtmlLabel3.TabIndex = 71;
            this.guna2HtmlLabel3.Text = "Faculdade";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(53, 435);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 23);
            this.guna2HtmlLabel2.TabIndex = 70;
            this.guna2HtmlLabel2.Text = "Apelido";
            // 
            // apelido
            // 
            this.apelido.BorderRadius = 5;
            this.apelido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apelido.DefaultText = "";
            this.apelido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.apelido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.apelido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apelido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apelido.FillColor = System.Drawing.SystemColors.Control;
            this.apelido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apelido.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
            this.apelido.ForeColor = System.Drawing.Color.Black;
            this.apelido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apelido.Location = new System.Drawing.Point(53, 464);
            this.apelido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apelido.Name = "apelido";
            this.apelido.PasswordChar = '\0';
            this.apelido.PlaceholderForeColor = System.Drawing.Color.Black;
            this.apelido.PlaceholderText = "";
            this.apelido.SelectedText = "";
            this.apelido.Size = new System.Drawing.Size(310, 36);
            this.apelido.TabIndex = 69;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(53, 257);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(51, 23);
            this.guna2HtmlLabel1.TabIndex = 68;
            this.guna2HtmlLabel1.Text = "Turno";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(16)))), ((int)(((byte)(145)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1046, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 23);
            this.guna2ControlBox1.TabIndex = 99;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(471, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 100;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // AtualizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1080, 659);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.curso);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.guna2HtmlLabel15);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.guna2HtmlLabel14);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.nuit);
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.numDoc);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.docum);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.localNasc);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.provNasc);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.paisNasc);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.grauc);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.facul);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.apelido);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtualizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtualizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox curso;
        private Guna.UI2.WinForms.Guna2Button atualizar;
        private Guna.UI2.WinForms.Guna2ComboBox genero;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2TextBox celular;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2TextBox nuit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2TextBox numDoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2ComboBox docum;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox localNasc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox provNasc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dataNasc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox paisNasc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox nome;
        private Guna.UI2.WinForms.Guna2ComboBox turno;
        private Guna.UI2.WinForms.Guna2ComboBox grauc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox facul;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox apelido;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}