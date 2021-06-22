
namespace TrabajoPrácticoPAV.Formularios.Listados.Factura
{
    partial class Frm_Reporte_FacturasPorFecha
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
            this.rv_Facturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_idFactura = new Clase11.Clases.LabelText02();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.rb_buscarPorFechas = new System.Windows.Forms.RadioButton();
            this.rb_buscarTodas = new System.Windows.Forms.RadioButton();
            this.rb_buscarPorId = new System.Windows.Forms.RadioButton();
            this.txt_fecha_desde = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fecha_hasta = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_Facturas
            // 
            this.rv_Facturas.Location = new System.Drawing.Point(12, 117);
            this.rv_Facturas.Name = "rv_Facturas";
            this.rv_Facturas.ServerReport.BearerToken = null;
            this.rv_Facturas.Size = new System.Drawing.Size(757, 309);
            this.rv_Facturas.TabIndex = 0;
            // 
            // txt_idFactura
            // 
            this.txt_idFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idFactura.Location = new System.Drawing.Point(-5, 31);
            this.txt_idFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idFactura.Name = "txt_idFactura";
            this.txt_idFactura.Pp_ancho = 10;
            this.txt_idFactura.Pp_decimales = 2;
            this.txt_idFactura.Pp_Etiqueta = "ID Factura";
            this.txt_idFactura.Pp_mensajeError = null;
            this.txt_idFactura.Pp_nombre_campo = null;
            this.txt_idFactura.Pp_nombre_tabla = null;
            this.txt_idFactura.Pp_ReadOnly = false;
            this.txt_idFactura.Pp_Text = "";
            this.txt_idFactura.Pp_tipoDato = Clase11.Clases.LabelText02.TipoDato.texto;
            this.txt_idFactura.Pp_validable = false;
            this.txt_idFactura.Size = new System.Drawing.Size(234, 28);
            this.txt_idFactura.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_buscarTodas);
            this.groupBox1.Controls.Add(this.rb_buscarPorId);
            this.groupBox1.Controls.Add(this.rb_buscarPorFechas);
            this.groupBox1.Location = new System.Drawing.Point(472, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo búsqueda";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(677, 88);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // rb_buscarPorFechas
            // 
            this.rb_buscarPorFechas.AutoSize = true;
            this.rb_buscarPorFechas.Location = new System.Drawing.Point(6, 21);
            this.rb_buscarPorFechas.Name = "rb_buscarPorFechas";
            this.rb_buscarPorFechas.Size = new System.Drawing.Size(111, 17);
            this.rb_buscarPorFechas.TabIndex = 1;
            this.rb_buscarPorFechas.TabStop = true;
            this.rb_buscarPorFechas.Text = "Buscar por fechas";
            this.rb_buscarPorFechas.UseVisualStyleBackColor = true;
            // 
            // rb_buscarTodas
            // 
            this.rb_buscarTodas.AutoSize = true;
            this.rb_buscarTodas.Location = new System.Drawing.Point(6, 67);
            this.rb_buscarTodas.Name = "rb_buscarTodas";
            this.rb_buscarTodas.Size = new System.Drawing.Size(87, 17);
            this.rb_buscarTodas.TabIndex = 4;
            this.rb_buscarTodas.TabStop = true;
            this.rb_buscarTodas.Text = "Buscar todas";
            this.rb_buscarTodas.UseVisualStyleBackColor = true;
            // 
            // rb_buscarPorId
            // 
            this.rb_buscarPorId.AutoSize = true;
            this.rb_buscarPorId.Location = new System.Drawing.Point(6, 44);
            this.rb_buscarPorId.Name = "rb_buscarPorId";
            this.rb_buscarPorId.Size = new System.Drawing.Size(90, 17);
            this.rb_buscarPorId.TabIndex = 3;
            this.rb_buscarPorId.TabStop = true;
            this.rb_buscarPorId.Text = "Buscar por id ";
            this.rb_buscarPorId.UseVisualStyleBackColor = true;
            // 
            // txt_fecha_desde
            // 
            this.txt_fecha_desde.Location = new System.Drawing.Point(146, 76);
            this.txt_fecha_desde.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fecha_desde.Mask = "9999-99-99";
            this.txt_fecha_desde.Name = "txt_fecha_desde";
            this.txt_fecha_desde.Pp_EsPk = false;
            this.txt_fecha_desde.Pp_MensajeError = null;
            this.txt_fecha_desde.Pp_NombreCampo = "fechaNacimiento";
            this.txt_fecha_desde.Pp_NombreTabla = "Pasajero";
            this.txt_fecha_desde.Size = new System.Drawing.Size(68, 20);
            this.txt_fecha_desde.TabIndex = 60;
            this.txt_fecha_desde.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-19, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha Desde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha Hasta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_fecha_hasta
            // 
            this.txt_fecha_hasta.Location = new System.Drawing.Point(383, 74);
            this.txt_fecha_hasta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fecha_hasta.Mask = "9999-99-99";
            this.txt_fecha_hasta.Name = "txt_fecha_hasta";
            this.txt_fecha_hasta.Pp_EsPk = false;
            this.txt_fecha_hasta.Pp_MensajeError = null;
            this.txt_fecha_hasta.Pp_NombreCampo = "fechaNacimiento";
            this.txt_fecha_hasta.Pp_NombreTabla = "Pasajero";
            this.txt_fecha_hasta.Size = new System.Drawing.Size(68, 20);
            this.txt_fecha_hasta.TabIndex = 62;
            this.txt_fecha_hasta.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_Reporte_FacturasPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fecha_hasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha_desde);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_idFactura);
            this.Controls.Add(this.rv_Facturas);
            this.Name = "Frm_Reporte_FacturasPorFecha";
            this.Text = "Frm_Reporte_FacturasPorFecha";
            this.Load += new System.EventHandler(this.Frm_Reporte_FacturasPorFecha_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_Facturas;
        private Clase11.Clases.LabelText02 txt_idFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clase.Button_Aerolinea btn_buscar;
        private System.Windows.Forms.RadioButton rb_buscarPorFechas;
        private System.Windows.Forms.RadioButton rb_buscarTodas;
        private System.Windows.Forms.RadioButton rb_buscarPorId;
        private Clase.MaskedTextBox_Aerolinea txt_fecha_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.MaskedTextBox_Aerolinea txt_fecha_hasta;
    }
}