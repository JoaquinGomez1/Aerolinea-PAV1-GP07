
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
            this.Mtxt_reserva = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.Mtxt_documento = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rb_Todos = new System.Windows.Forms.RadioButton();
            this.Rb_documento = new System.Windows.Forms.RadioButton();
            this.Rb_reserva = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservasPorPasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReservasPorPasajeros)).BeginInit();
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
            // Mtxt_reserva
            // 
            this.Mtxt_reserva.Location = new System.Drawing.Point(282, 77);
            this.Mtxt_reserva.Mask = "00000";
            this.Mtxt_reserva.Name = "Mtxt_reserva";
            this.Mtxt_reserva.Pp_EsPk = false;
            this.Mtxt_reserva.Pp_MensajeError = null;
            this.Mtxt_reserva.Pp_NombreCampo = null;
            this.Mtxt_reserva.Pp_NombreTabla = null;
            this.Mtxt_reserva.Size = new System.Drawing.Size(57, 20);
            this.Mtxt_reserva.TabIndex = 17;
            this.Mtxt_reserva.ValidatingType = typeof(int);
            // 
            // Mtxt_documento
            // 
            this.Mtxt_documento.Location = new System.Drawing.Point(282, 44);
            this.Mtxt_documento.Mask = "00000000";
            this.Mtxt_documento.Name = "Mtxt_documento";
            this.Mtxt_documento.Pp_EsPk = false;
            this.Mtxt_documento.Pp_MensajeError = null;
            this.Mtxt_documento.Pp_NombreCampo = null;
            this.Mtxt_documento.Pp_NombreTabla = null;
            this.Mtxt_documento.Size = new System.Drawing.Size(57, 20);
            this.Mtxt_documento.TabIndex = 16;
            this.Mtxt_documento.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(139, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero Reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero Documento";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Rb_Todos);
            this.panel1.Controls.Add(this.Rb_documento);
            this.panel1.Controls.Add(this.Rb_reserva);
            this.panel1.Location = new System.Drawing.Point(399, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 82);
            this.panel1.TabIndex = 13;
            // 
            // Rb_Todos
            // 
            this.Rb_Todos.AutoSize = true;
            this.Rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rb_Todos.Location = new System.Drawing.Point(18, 52);
            this.Rb_Todos.Name = "Rb_Todos";
            this.Rb_Todos.Size = new System.Drawing.Size(71, 24);
            this.Rb_Todos.TabIndex = 3;
            this.Rb_Todos.TabStop = true;
            this.Rb_Todos.Text = "Todos";
            this.Rb_Todos.UseVisualStyleBackColor = true;
            // 
            // Rb_documento
            // 
            this.Rb_documento.AutoSize = true;
            this.Rb_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rb_documento.Location = new System.Drawing.Point(18, 3);
            this.Rb_documento.Name = "Rb_documento";
            this.Rb_documento.Size = new System.Drawing.Size(138, 24);
            this.Rb_documento.TabIndex = 2;
            this.Rb_documento.TabStop = true;
            this.Rb_documento.Text = "Por Documento";
            this.Rb_documento.UseVisualStyleBackColor = true;
            // 
            // Rb_reserva
            // 
            this.Rb_reserva.AutoSize = true;
            this.Rb_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rb_reserva.Location = new System.Drawing.Point(18, 26);
            this.Rb_reserva.Name = "Rb_reserva";
            this.Rb_reserva.Size = new System.Drawing.Size(114, 24);
            this.Rb_reserva.TabIndex = 1;
            this.Rb_reserva.TabStop = true;
            this.Rb_reserva.Text = "Por Reserva";
            this.Rb_reserva.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_search.Location = new System.Drawing.Point(642, 66);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 41);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReservasPorPasajeros";
            reportDataSource1.Value = this.dsReservasPorPasajerosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Reservas.ReporteReservasPorPasajeros.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(12, 113);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(726, 288);
            this.reportViewer1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reporte de reservas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(395, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Selección";
            // 
            // Frm_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Mtxt_reserva);
            this.Controls.Add(this.Mtxt_documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reservas";
            this.Text = "Frm_Reservas";
            this.Load += new System.EventHandler(this.Frm_ListadoReservasPorPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReservasPorPasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReservasPorPasajeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dsReservasPorPasajerosBindingSource;
        private Ds_ReservasPorPasajeros ds_ReservasPorPasajeros;
        private Clase.MaskedTextBox_Aerolinea Mtxt_reserva;
        private Clase.MaskedTextBox_Aerolinea Mtxt_documento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rb_Todos;
        private System.Windows.Forms.RadioButton Rb_documento;
        private System.Windows.Forms.RadioButton Rb_reserva;
        private System.Windows.Forms.Button btn_search;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}