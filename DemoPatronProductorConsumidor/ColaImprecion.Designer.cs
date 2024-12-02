namespace DemoPatronProductorConsumidor
{
    partial class Cola_de_Imprecion
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
            panel1 = new Panel();
            DgvPagina = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            TxtCorreo = new TextBox();
            TxtNombres = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPagina).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvPagina);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 499);
            panel1.TabIndex = 0;
            // 
            // DgvPagina
            // 
            DgvPagina.AllowUserToAddRows = false;
            DgvPagina.AllowUserToDeleteRows = false;
            DgvPagina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagina.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            DgvPagina.Location = new Point(3, 3);
            DgvPagina.Name = "DgvPagina";
            DgvPagina.ReadOnly = true;
            DgvPagina.Size = new Size(373, 493);
            DgvPagina.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Imprimir Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Datos para Imprimir:";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(72, 93);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(244, 23);
            TxtCorreo.TabIndex = 5;
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(72, 64);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(244, 23);
            TxtNombres.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 96);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Correo:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TxtCorreo);
            panel2.Controls.Add(TxtNombres);
            panel2.Location = new Point(410, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 499);
            panel2.TabIndex = 8;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(160, 473);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(241, 473);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(212, 122);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 8;
            button1.Text = "Añadir a la Cola";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cola_de_Imprecion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 523);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Cola_de_Imprecion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cola de Imprecion";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPagina).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DgvPagina;
        private Label label1;
        private Label label2;
        private TextBox TxtCorreo;
        private TextBox TxtNombres;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
    }
}