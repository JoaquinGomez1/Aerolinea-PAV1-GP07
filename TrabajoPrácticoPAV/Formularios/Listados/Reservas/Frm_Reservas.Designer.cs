
namespace TrabajoPrácticoPAV.Formularios.Listados.Reservas
{
    partial class Frm_Reservas
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
            this.dsReservasPorPasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ReservasPorPasajeros = new TrabajoPrácticoPAV.Formularios.Listados.Reservas.Ds_ReservasPorPasajeros();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rb_Todos = new System.Windows.Forms.RadioButton();
            this.Rb_documento = new System.Windows.Forms.RadioButton();
            this.Rb_reserva = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Mtxt_reserva = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.Mtxt_documento = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservasPorPasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReservasPorPasajeros)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsReservasPorPasajerosBindingSource
            // 
            this.dsReservasPorPasajerosBindingSource.DataSource = this.ds_ReservasPorPasajeros;
            this.dsReservasPorPasajerosBindingSource.Position = 0;
            // 
            // ds_ReservasPorPasajeros
            // 
            this.ds_ReservasPorPasajeros.DataSetName = "Ds_ReservasPorPasajeros";
            this.ds_ReservasPorPasajeros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Mtxt_reserva);
            this.tabPage1.Controls.Add(this.Mtxt_documento);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Pasajero";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero Reserva";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Documento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Rb_Todos);
            this.panel1.Controls.Add(this.Rb_documento);
            this.panel1.Controls.Add(this.Rb_reserva);
            this.panel1.Location = new System.Drawing.Point(250, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 74);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Rb_Todos
            // 
            this.Rb_Todos.AutoSize = true;
            this.Rb_Todos.Location = new System.Drawing.Point(18, 52);
            this.Rb_Todos.Name = "Rb_Todos";
            this.Rb_Todos.Size = new System.Drawing.Size(55, 17);
            this.Rb_Todos.TabIndex = 3;
            this.Rb_Todos.TabStop = true;
            this.Rb_Todos.Text = "Todos";
            this.Rb_Todos.UseVisualStyleBackColor = true;
            // 
            // Rb_documento
            // 
            this.Rb_documento.AutoSize = true;
            this.Rb_documento.Location = new System.Drawing.Point(18, 3);
            this.Rb_documento.Name = "Rb_documento";
            this.Rb_documento.Size = new System.Drawing.Size(99, 17);
            this.Rb_documento.TabIndex = 2;
            this.Rb_documento.TabStop = true;
            this.Rb_documento.Text = "Por Documento";
            this.Rb_documento.UseVisualStyleBackColor = true;
            // 
            // Rb_reserva
            // 
            this.Rb_reserva.AutoSize = true;
            this.Rb_reserva.Location = new System.Drawing.Point(18, 26);
            this.Rb_reserva.Name = "Rb_reserva";
            this.Rb_reserva.Size = new System.Drawing.Size(84, 17);
            this.Rb_reserva.TabIndex = 1;
            this.Rb_reserva.TabStop = true;
            this.Rb_reserva.Text = "Por Reserva";
            this.Rb_reserva.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(660, 112);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 30);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReservasPorPasajeros";
            reportDataSource1.Value = this.dsReservasPorPasajerosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Reservas.ReporteReservasPorPasajeros.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(6, 148);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(756, 246);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Mtxt_reserva
            // 
            this.Mtxt_reserva.Location = new System.Drawing.Point(151, 67);
            this.Mtxt_reserva.Mask = "00000";
            this.Mtxt_reserva.Name = "Mtxt_reserva";
            this.Mtxt_reserva.Pp_EsPk = false;
            this.Mtxt_reserva.Pp_MensajeError = null;
            this.Mtxt_reserva.Pp_NombreCampo = null;
            this.Mtxt_reserva.Pp_NombreTabla = null;
            this.Mtxt_reserva.Size = new System.Drawing.Size(57, 20);
            this.Mtxt_reserva.TabIndex = 10;
            this.Mtxt_reserva.ValidatingType = typeof(int);
            this.Mtxt_reserva.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtxt_reserva_MaskInputRejected);
            // 
            // Mtxt_documento
            // 
            this.Mtxt_documento.Location = new System.Drawing.Point(151, 34);
            this.Mtxt_documento.Mask = "00000000";
            this.Mtxt_documento.Name = "Mtxt_documento";
            this.Mtxt_documento.Pp_EsPk = false;
            this.Mtxt_documento.Pp_MensajeError = null;
            this.Mtxt_documento.Pp_NombreCampo = null;
            this.Mtxt_documento.Pp_NombreTabla = null;
            this.Mtxt_documento.Size = new System.Drawing.Size(57, 20);
            this.Mtxt_documento.TabIndex = 9;
            this.Mtxt_documento.ValidatingType = typeof(int);
            this.Mtxt_documento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtxt_documento_MaskInputRejected);
            // 
            // Frm_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Reservas";
            this.Text = "Frm_Reservas";
            this.Load += new System.EventHandler(this.Frm_ListadoReservasPorPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReservasPorPasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReservasPorPasajeros)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dsReservasPorPasajerosBindingSource;
        private Ds_ReservasPorPasajeros ds_ReservasPorPasajeros;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rb_Todos;
        private System.Windows.Forms.RadioButton Rb_documento;
        private System.Windows.Forms.RadioButton Rb_reserva;
        private System.Windows.Forms.Button btn_search;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.MaskedTextBox_Aerolinea Mtxt_reserva;
        private Clase.MaskedTextBox_Aerolinea Mtxt_documento;
    }
}