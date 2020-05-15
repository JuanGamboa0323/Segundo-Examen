namespace FrmPrincipal
{
    partial class FrmInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbConsultaFiltro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpConsultaFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalServicios = new System.Windows.Forms.Label();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.lblTotalPagos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Entidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(181, 69);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(212, 20);
            this.txtNit.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(181, 190);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(139, 20);
            this.txtValor.TabIndex = 8;
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "--- SELECCIONE ---",
            "Servicios Publicos",
            "Compras a Provedores",
            "Pagos a Contratistas"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(181, 31);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(212, 21);
            this.cmbTipoServicio.TabIndex = 9;
            this.cmbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.CmbTipoServicio_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(181, 152);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(212, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(62, 251);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(537, 189);
            this.dtgDatos.TabIndex = 11;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(432, 29);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // cmbConsultaFiltro
            // 
            this.cmbConsultaFiltro.FormattingEnabled = true;
            this.cmbConsultaFiltro.Items.AddRange(new object[] {
            "--- Consultar por tipo ----",
            "Servicios Publicos",
            "Compras a Provedores",
            "Pagos a Contratistas",
            "Todos"});
            this.cmbConsultaFiltro.Location = new System.Drawing.Point(432, 108);
            this.cmbConsultaFiltro.Name = "cmbConsultaFiltro";
            this.cmbConsultaFiltro.Size = new System.Drawing.Size(213, 21);
            this.cmbConsultaFiltro.TabIndex = 15;
            this.cmbConsultaFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbConsultaFiltro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Consulta por Filtro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Consulta Por Fecha";
            // 
            // dtpConsultaFecha
            // 
            this.dtpConsultaFecha.Location = new System.Drawing.Point(432, 188);
            this.dtpConsultaFecha.Name = "dtpConsultaFecha";
            this.dtpConsultaFecha.Size = new System.Drawing.Size(213, 20);
            this.dtpConsultaFecha.TabIndex = 18;
            this.dtpConsultaFecha.ValueChanged += new System.EventHandler(this.DtpConsultaFecha_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total de servicios";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(178, 482);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Servicios Publicos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total Compras a Provedores";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total Pagos a Contratistas";
            // 
            // lblTotalServicios
            // 
            this.lblTotalServicios.AutoSize = true;
            this.lblTotalServicios.Location = new System.Drawing.Point(558, 457);
            this.lblTotalServicios.Name = "lblTotalServicios";
            this.lblTotalServicios.Size = new System.Drawing.Size(0, 13);
            this.lblTotalServicios.TabIndex = 24;
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.Location = new System.Drawing.Point(559, 487);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCompras.TabIndex = 25;
            // 
            // lblTotalPagos
            // 
            this.lblTotalPagos.AutoSize = true;
            this.lblTotalPagos.Location = new System.Drawing.Point(558, 521);
            this.lblTotalPagos.Name = "lblTotalPagos";
            this.lblTotalPagos.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPagos.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Numero de Registros";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(177, 524);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(0, 13);
            this.lblRegistros.TabIndex = 28;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 561);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalPagos);
            this.Controls.Add(this.lblTotalCompras);
            this.Controls.Add(this.lblTotalServicios);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpConsultaFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbConsultaFiltro);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbConsultaFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpConsultaFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalServicios;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.Label lblTotalPagos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRegistros;
    }
}