namespace biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.LblLibro = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dataGridViewVista = new System.Windows.Forms.DataGridView();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(407, 12);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(220, 33);
            this.btnconsultar.TabIndex = 0;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(9, 12);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(106, 33);
            this.btnactualizar.TabIndex = 1;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(124, 12);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(106, 33);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(245, 12);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 33);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // LblLibro
            // 
            this.LblLibro.AutoSize = true;
            this.LblLibro.Location = new System.Drawing.Point(36, 60);
            this.LblLibro.Name = "LblLibro";
            this.LblLibro.Size = new System.Drawing.Size(34, 15);
            this.LblLibro.TabIndex = 5;
            this.LblLibro.Text = "Libro";
            this.LblLibro.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Location = new System.Drawing.Point(178, 60);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(37, 15);
            this.LblAutor.TabIndex = 6;
            this.LblAutor.Text = "Autor";
            this.LblAutor.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Location = new System.Drawing.Point(20, 131);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(60, 15);
            this.LblUbicacion.TabIndex = 7;
            this.LblUbicacion.Text = "Ubicación";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(175, 131);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(55, 15);
            this.LblCantidad.TabIndex = 8;
            this.LblCantidad.Text = "Cantidad";
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(3, 78);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(100, 23);
            this.txtLibro.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(148, 78);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 23);
            this.txtAutor.TabIndex = 10;
            this.txtAutor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(3, 162);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 23);
            this.txtUbicacion.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(148, 162);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridViewVista
            // 
            this.dataGridViewVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVista.Location = new System.Drawing.Point(407, 78);
            this.dataGridViewVista.Name = "dataGridViewVista";
            this.dataGridViewVista.RowTemplate.Height = 25;
            this.dataGridViewVista.Size = new System.Drawing.Size(478, 134);
            this.dataGridViewVista.TabIndex = 13;
            this.dataGridViewVista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVista_CellContentClick);
            this.dataGridViewVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVista_CellContentClick);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(691, 18);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(194, 23);
            this.txtconsulta.TabIndex = 14;
            this.txtconsulta.TextChanged += new System.EventHandler(this.txtconsulta_TextChanged);
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(605, 219);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(126, 33);
            this.btnlistar.TabIndex = 15;
            this.btnlistar.Text = "Listar Datos";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 110);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(275, 127);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 19;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(305, 109);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 469);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.dataGridViewVista);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblUbicacion);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblLibro);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnconsultar);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnconsultar;
        private Button btnactualizar;
        private Button btnagregar;
        private Button btneliminar;
        private Label LblLibro;
        private Label LblAutor;
        private Label LblUbicacion;
        private Label LblCantidad;
        private TextBox txtLibro;
        private TextBox txtAutor;
        private TextBox txtUbicacion;
        private TextBox txtCantidad;
        private DataGridView dataGridViewVista;
        private TextBox txtconsulta;
        private Button btnlistar;
        private PictureBox pictureBox2;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}