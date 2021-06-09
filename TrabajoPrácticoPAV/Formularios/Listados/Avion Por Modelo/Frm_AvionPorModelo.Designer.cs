
namespace TrabajoPrácticoPAV.Formularios.Listados.Avion_Por_Modelo
{
    partial class Frm_AvionPorModelo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mtxt_reserva
            // 
            this.Mtxt_reserva.Location = new System.Drawing.Point(167, 84);
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
            this.Mtxt_documento.Location = new System.Drawing.Point(167, 51);
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
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero Reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero Documento";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Rb_Todos);
            this.panel1.Controls.Add(this.Rb_documento);
            this.panel1.Controls.Add(this.Rb_reserva);
            this.panel1.Location = new System.Drawing.Point(266, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 74);
            this.panel1.TabIndex = 13;
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
            this.btn_search.Location = new System.Drawing.Point(676, 129);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 30);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "ReservasPorPasajeros";
            reportDataSource2.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Reservas.ReporteReservasPorPasajeros.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(22, 165);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(756, 246);
            this.reportViewer1.TabIndex = 11;
            // 
            // Frm_AvionPorModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mtxt_reserva);
            this.Controls.Add(this.Mtxt_documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_AvionPorModelo";
            this.Text = "Frm_AvionPorModelo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}