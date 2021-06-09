
namespace TrabajoPrácticoPAV.Formularios.Listados.Viajes.Tramos
{
    partial class Frm_ListadoTramos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsReporteTramosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ReporteTramos = new TrabajoPrácticoPAV.Formularios.Listados.Viajes.Tramos.Ds_ReporteTramos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_distancia = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbu_distancia = new System.Windows.Forms.RadioButton();
            this.rbu_todos = new System.Windows.Forms.RadioButton();
            this.rbu_origen = new System.Windows.Forms.RadioButton();
            this.rbu_duracion = new System.Windows.Forms.RadioButton();
            this.rbu_destino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rv_tramos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_distancia = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_origen = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_destino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_duracion = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.rbu_duracionMayor = new System.Windows.Forms.RadioButton();
            this.rbu_duracionMenor = new System.Windows.Forms.RadioButton();
            this.rbu_distanciaMayor = new System.Windows.Forms.RadioButton();
            this.rbu_distanciaMenor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteTramosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReporteTramos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsReporteTramosBindingSource
            // 
            this.dsReporteTramosBindingSource.DataSource = this.ds_ReporteTramos;
            this.dsReporteTramosBindingSource.Position = 0;
            // 
            // ds_ReporteTramos
            // 
            this.ds_ReporteTramos.DataSetName = "Ds_ReporteTramos";
            this.ds_ReporteTramos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_distancia);
            this.panel1.Controls.Add(this.lbl_distancia);
            this.panel1.Controls.Add(this.cmb_origen);
            this.panel1.Controls.Add(this.lbl_origen);
            this.panel1.Controls.Add(this.cmb_destino);
            this.panel1.Controls.Add(this.txt_duracion);
            this.panel1.Controls.Add(this.lbl_destino);
            this.panel1.Controls.Add(this.lbl_duracion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 170);
            this.panel1.TabIndex = 0;
            // 
            // lbl_distancia
            // 
            this.lbl_distancia.AutoSize = true;
            this.lbl_distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_distancia.Location = new System.Drawing.Point(54, 119);
            this.lbl_distancia.Name = "lbl_distancia";
            this.lbl_distancia.Size = new System.Drawing.Size(70, 17);
            this.lbl_distancia.TabIndex = 15;
            this.lbl_distancia.Text = "Distancia:";
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_origen.Location = new System.Drawing.Point(68, 41);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(55, 17);
            this.lbl_origen.TabIndex = 13;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_destino.Location = new System.Drawing.Point(63, 66);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(60, 17);
            this.lbl_destino.TabIndex = 10;
            this.lbl_destino.Text = "Destino:";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_duracion.Location = new System.Drawing.Point(54, 93);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(69, 17);
            this.lbl_duracion.TabIndex = 9;
            this.lbl_duracion.Text = "Duracion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reporte de Tramos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbu_distanciaMenor);
            this.panel2.Controls.Add(this.rbu_distanciaMayor);
            this.panel2.Controls.Add(this.rbu_duracionMenor);
            this.panel2.Controls.Add(this.rbu_duracionMayor);
            this.panel2.Controls.Add(this.rbu_distancia);
            this.panel2.Controls.Add(this.btn_calcular);
            this.panel2.Controls.Add(this.rbu_todos);
            this.panel2.Controls.Add(this.rbu_origen);
            this.panel2.Controls.Add(this.rbu_duracion);
            this.panel2.Controls.Add(this.rbu_destino);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(376, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 170);
            this.panel2.TabIndex = 1;
            // 
            // rbu_distancia
            // 
            this.rbu_distancia.AutoSize = true;
            this.rbu_distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_distancia.Location = new System.Drawing.Point(23, 80);
            this.rbu_distancia.Name = "rbu_distancia";
            this.rbu_distancia.Size = new System.Drawing.Size(108, 21);
            this.rbu_distancia.TabIndex = 15;
            this.rbu_distancia.Text = "Por distancia";
            this.rbu_distancia.UseVisualStyleBackColor = true;
            // 
            // rbu_todos
            // 
            this.rbu_todos.AutoSize = true;
            this.rbu_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_todos.Location = new System.Drawing.Point(23, 134);
            this.rbu_todos.Name = "rbu_todos";
            this.rbu_todos.Size = new System.Drawing.Size(66, 21);
            this.rbu_todos.TabIndex = 13;
            this.rbu_todos.Text = "Todos";
            this.rbu_todos.UseVisualStyleBackColor = true;
            // 
            // rbu_origen
            // 
            this.rbu_origen.AutoSize = true;
            this.rbu_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_origen.Location = new System.Drawing.Point(24, 28);
            this.rbu_origen.Name = "rbu_origen";
            this.rbu_origen.Size = new System.Drawing.Size(92, 21);
            this.rbu_origen.TabIndex = 10;
            this.rbu_origen.Text = "Por origen";
            this.rbu_origen.UseVisualStyleBackColor = true;
            // 
            // rbu_duracion
            // 
            this.rbu_duracion.AutoSize = true;
            this.rbu_duracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_duracion.Location = new System.Drawing.Point(23, 107);
            this.rbu_duracion.Name = "rbu_duracion";
            this.rbu_duracion.Size = new System.Drawing.Size(107, 21);
            this.rbu_duracion.TabIndex = 11;
            this.rbu_duracion.Text = "Por duracion";
            this.rbu_duracion.UseVisualStyleBackColor = true;
            // 
            // rbu_destino
            // 
            this.rbu_destino.AutoSize = true;
            this.rbu_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_destino.Location = new System.Drawing.Point(24, 53);
            this.rbu_destino.Name = "rbu_destino";
            this.rbu_destino.Size = new System.Drawing.Size(98, 21);
            this.rbu_destino.TabIndex = 12;
            this.rbu_destino.Text = "Por destino";
            this.rbu_destino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de calculo";
            // 
            // rv_tramos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsReporteTramosBindingSource;
            this.rv_tramos.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_tramos.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Viajes.Tramos.ReporteTramos.rdlc";
            this.rv_tramos.Location = new System.Drawing.Point(15, 191);
            this.rv_tramos.Name = "rv_tramos";
            this.rv_tramos.ServerReport.BearerToken = null;
            this.rv_tramos.Size = new System.Drawing.Size(712, 182);
            this.rv_tramos.TabIndex = 2;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cerrar.Location = new System.Drawing.Point(637, 380);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(90, 28);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_calcular.Location = new System.Drawing.Point(243, 134);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Pp_Presionado = false;
            this.btn_calcular.Size = new System.Drawing.Size(90, 28);
            this.btn_calcular.TabIndex = 14;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_distancia
            // 
            this.txt_distancia.Location = new System.Drawing.Point(136, 119);
            this.txt_distancia.Name = "txt_distancia";
            this.txt_distancia.Pp_EsPk = false;
            this.txt_distancia.Pp_MensajeError = "Completar nombre";
            this.txt_distancia.Pp_NombreCampo = null;
            this.txt_distancia.Pp_NombreTabla = null;
            this.txt_distancia.Size = new System.Drawing.Size(118, 20);
            this.txt_distancia.TabIndex = 16;
            // 
            // cmb_origen
            // 
            this.cmb_origen.FormattingEnabled = true;
            this.cmb_origen.Location = new System.Drawing.Point(136, 41);
            this.cmb_origen.Name = "cmb_origen";
            this.cmb_origen.Pp_CampoAceptaNull = false;
            this.cmb_origen.Pp_EsPk = true;
            this.cmb_origen.Pp_MensajeError = "Se ha detectado un error en cargar el origen";
            this.cmb_origen.Pp_NombreCampo = "codigoAeropuertoSalida";
            this.cmb_origen.Pp_NombreCampoInsert = null;
            this.cmb_origen.Pp_NombreTabla = "Tramo";
            this.cmb_origen.Pp_PkTabla = "codigoAeropuertoSalida";
            this.cmb_origen.Size = new System.Drawing.Size(118, 21);
            this.cmb_origen.TabIndex = 14;
            // 
            // cmb_destino
            // 
            this.cmb_destino.FormattingEnabled = true;
            this.cmb_destino.Location = new System.Drawing.Point(136, 66);
            this.cmb_destino.Name = "cmb_destino";
            this.cmb_destino.Pp_CampoAceptaNull = false;
            this.cmb_destino.Pp_EsPk = false;
            this.cmb_destino.Pp_MensajeError = "Se ha detectado un error en cargar el destino";
            this.cmb_destino.Pp_NombreCampo = "codigoAeropuertoSalida";
            this.cmb_destino.Pp_NombreCampoInsert = null;
            this.cmb_destino.Pp_NombreTabla = "Tramo";
            this.cmb_destino.Pp_PkTabla = "codigoAeropuertoDestino";
            this.cmb_destino.Size = new System.Drawing.Size(118, 21);
            this.cmb_destino.TabIndex = 12;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(136, 93);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Pp_EsPk = false;
            this.txt_duracion.Pp_MensajeError = "Completar nombre";
            this.txt_duracion.Pp_NombreCampo = null;
            this.txt_duracion.Pp_NombreTabla = null;
            this.txt_duracion.Size = new System.Drawing.Size(118, 20);
            this.txt_duracion.TabIndex = 11;
            // 
            // rbu_duracionMayor
            // 
            this.rbu_duracionMayor.AutoSize = true;
            this.rbu_duracionMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_duracionMayor.Location = new System.Drawing.Point(149, 26);
            this.rbu_duracionMayor.Name = "rbu_duracionMayor";
            this.rbu_duracionMayor.Size = new System.Drawing.Size(174, 21);
            this.rbu_duracionMayor.TabIndex = 16;
            this.rbu_duracionMayor.Text = "Por duracion mayor a...";
            this.rbu_duracionMayor.UseVisualStyleBackColor = true;
            // 
            // rbu_duracionMenor
            // 
            this.rbu_duracionMenor.AutoSize = true;
            this.rbu_duracionMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_duracionMenor.Location = new System.Drawing.Point(149, 53);
            this.rbu_duracionMenor.Name = "rbu_duracionMenor";
            this.rbu_duracionMenor.Size = new System.Drawing.Size(175, 21);
            this.rbu_duracionMenor.TabIndex = 17;
            this.rbu_duracionMenor.Text = "Por duracion menor a...";
            this.rbu_duracionMenor.UseVisualStyleBackColor = true;
            // 
            // rbu_distanciaMayor
            // 
            this.rbu_distanciaMayor.AutoSize = true;
            this.rbu_distanciaMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_distanciaMayor.Location = new System.Drawing.Point(149, 80);
            this.rbu_distanciaMayor.Name = "rbu_distanciaMayor";
            this.rbu_distanciaMayor.Size = new System.Drawing.Size(175, 21);
            this.rbu_distanciaMayor.TabIndex = 18;
            this.rbu_distanciaMayor.Text = "Por distancia mayor a...";
            this.rbu_distanciaMayor.UseVisualStyleBackColor = true;
            // 
            // rbu_distanciaMenor
            // 
            this.rbu_distanciaMenor.AutoSize = true;
            this.rbu_distanciaMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_distanciaMenor.Location = new System.Drawing.Point(149, 107);
            this.rbu_distanciaMenor.Name = "rbu_distanciaMenor";
            this.rbu_distanciaMenor.Size = new System.Drawing.Size(176, 21);
            this.rbu_distanciaMenor.TabIndex = 19;
            this.rbu_distanciaMenor.Text = "Por distancia menor a...";
            this.rbu_distanciaMenor.UseVisualStyleBackColor = true;
            // 
            // Frm_ListadoTramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 427);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.rv_tramos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListadoTramos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_ListadoTramos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteTramosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReporteTramos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_distancia;
        private System.Windows.Forms.Label lbl_distancia;
        private Clase.ComboBox_Aerolinea cmb_origen;
        private System.Windows.Forms.Label lbl_origen;
        private Clase.ComboBox_Aerolinea cmb_destino;
        private Clase.TextBox_Aerolinea txt_duracion;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.RadioButton rbu_todos;
        private System.Windows.Forms.RadioButton rbu_origen;
        private System.Windows.Forms.RadioButton rbu_duracion;
        private System.Windows.Forms.RadioButton rbu_destino;
        private Microsoft.Reporting.WinForms.ReportViewer rv_tramos;
        private Clase.Button_Aerolinea btn_calcular;
        private System.Windows.Forms.RadioButton rbu_distancia;
        private System.Windows.Forms.BindingSource dsReporteTramosBindingSource;
        private Ds_ReporteTramos ds_ReporteTramos;
        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.RadioButton rbu_distanciaMenor;
        private System.Windows.Forms.RadioButton rbu_distanciaMayor;
        private System.Windows.Forms.RadioButton rbu_duracionMenor;
        private System.Windows.Forms.RadioButton rbu_duracionMayor;
    }
}