
namespace TrabajoPrácticoPAV.Formularios.Listados.Tripulacion_Por_Vuelo
{
    partial class Frm_ListadoTripPorVuelo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rb_Todos = new System.Windows.Forms.RadioButton();
            this.Rb_tripulante = new System.Windows.Forms.RadioButton();
            this.Rb_Vuelo = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Mtxt_tripulante = new System.Windows.Forms.MaskedTextBox();
            this.Mtxt_vuelo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(160, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Vuelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(133, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Tripulante";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Rb_Todos);
            this.panel1.Controls.Add(this.Rb_tripulante);
            this.panel1.Controls.Add(this.Rb_Vuelo);
            this.panel1.Location = new System.Drawing.Point(414, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 77);
            this.panel1.TabIndex = 11;
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
            // Rb_tripulante
            // 
            this.Rb_tripulante.AutoSize = true;
            this.Rb_tripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rb_tripulante.Location = new System.Drawing.Point(18, 3);
            this.Rb_tripulante.Name = "Rb_tripulante";
            this.Rb_tripulante.Size = new System.Drawing.Size(118, 24);
            this.Rb_tripulante.TabIndex = 2;
            this.Rb_tripulante.TabStop = true;
            this.Rb_tripulante.Text = "ID Tripulante";
            this.Rb_tripulante.UseVisualStyleBackColor = true;
            // 
            // Rb_Vuelo
            // 
            this.Rb_Vuelo.AutoSize = true;
            this.Rb_Vuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rb_Vuelo.Location = new System.Drawing.Point(18, 26);
            this.Rb_Vuelo.Name = "Rb_Vuelo";
            this.Rb_Vuelo.Size = new System.Drawing.Size(89, 24);
            this.Rb_Vuelo.TabIndex = 1;
            this.Rb_Vuelo.TabStop = true;
            this.Rb_Vuelo.Text = "ID Vuelo";
            this.Rb_Vuelo.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_search.Location = new System.Drawing.Point(642, 60);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 41);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReservasPorPasajeros";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Reservas.ReporteReservasPorPasajeros.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(12, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(726, 301);
            this.reportViewer1.TabIndex = 9;
            // 
            // Mtxt_tripulante
            // 
            this.Mtxt_tripulante.Location = new System.Drawing.Point(230, 46);
            this.Mtxt_tripulante.Mask = "00000";
            this.Mtxt_tripulante.Name = "Mtxt_tripulante";
            this.Mtxt_tripulante.Size = new System.Drawing.Size(53, 20);
            this.Mtxt_tripulante.TabIndex = 14;
            this.Mtxt_tripulante.ValidatingType = typeof(int);
            // 
            // Mtxt_vuelo
            // 
            this.Mtxt_vuelo.Location = new System.Drawing.Point(229, 72);
            this.Mtxt_vuelo.Mask = "00000";
            this.Mtxt_vuelo.Name = "Mtxt_vuelo";
            this.Mtxt_vuelo.Size = new System.Drawing.Size(54, 20);
            this.Mtxt_vuelo.TabIndex = 15;
            this.Mtxt_vuelo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(420, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo Calculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Listado de tripulación por cargo";
            // 
            // Frm_ListadoTripPorVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mtxt_vuelo);
            this.Controls.Add(this.Mtxt_tripulante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListadoTripPorVuelo";
            this.Text = "Frm_ListadoTripPorVuelo";
            this.Load += new System.EventHandler(this.Frm_ListadoTripPorVuelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rb_Todos;
        private System.Windows.Forms.RadioButton Rb_tripulante;
        private System.Windows.Forms.RadioButton Rb_Vuelo;
        private System.Windows.Forms.Button btn_search;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MaskedTextBox Mtxt_tripulante;
        private System.Windows.Forms.MaskedTextBox Mtxt_vuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}