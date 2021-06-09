
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Rb_Todos = new System.Windows.Forms.RadioButton();
            this.Rb_numModelo = new System.Windows.Forms.RadioButton();
            this.Rb_idModelo = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.rv_avionPorModelo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_idModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_numModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "idModelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero por Modelo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Rb_Todos);
            this.panel1.Controls.Add(this.Rb_numModelo);
            this.panel1.Controls.Add(this.Rb_idModelo);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(379, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 143);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de calculo";
            // 
            // Rb_Todos
            // 
            this.Rb_Todos.AutoSize = true;
            this.Rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Rb_Todos.Location = new System.Drawing.Point(49, 82);
            this.Rb_Todos.Name = "Rb_Todos";
            this.Rb_Todos.Size = new System.Drawing.Size(66, 21);
            this.Rb_Todos.TabIndex = 3;
            this.Rb_Todos.TabStop = true;
            this.Rb_Todos.Text = "Todos";
            this.Rb_Todos.UseVisualStyleBackColor = true;
            // 
            // Rb_numModelo
            // 
            this.Rb_numModelo.AutoSize = true;
            this.Rb_numModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Rb_numModelo.Location = new System.Drawing.Point(49, 28);
            this.Rb_numModelo.Name = "Rb_numModelo";
            this.Rb_numModelo.Size = new System.Drawing.Size(175, 21);
            this.Rb_numModelo.TabIndex = 2;
            this.Rb_numModelo.TabStop = true;
            this.Rb_numModelo.Text = "Por numero por modelo";
            this.Rb_numModelo.UseVisualStyleBackColor = true;
            // 
            // Rb_idModelo
            // 
            this.Rb_idModelo.AutoSize = true;
            this.Rb_idModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Rb_idModelo.Location = new System.Drawing.Point(49, 55);
            this.Rb_idModelo.Name = "Rb_idModelo";
            this.Rb_idModelo.Size = new System.Drawing.Size(109, 21);
            this.Rb_idModelo.TabIndex = 1;
            this.Rb_idModelo.TabStop = true;
            this.Rb_idModelo.Text = "Por idModelo";
            this.Rb_idModelo.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_search.Location = new System.Drawing.Point(222, 101);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 28);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // rv_avionPorModelo
            // 
            reportDataSource4.Name = "ReservasPorPasajeros";
            reportDataSource4.Value = null;
            this.rv_avionPorModelo.LocalReport.DataSources.Add(reportDataSource4);
            this.rv_avionPorModelo.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Reservas.ReporteReservasPorPasajeros.rdlc" +
    "";
            this.rv_avionPorModelo.Location = new System.Drawing.Point(12, 173);
            this.rv_avionPorModelo.Name = "rv_avionPorModelo";
            this.rv_avionPorModelo.ServerReport.BearerToken = null;
            this.rv_avionPorModelo.Size = new System.Drawing.Size(709, 197);
            this.rv_avionPorModelo.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmb_idModelo);
            this.panel2.Controls.Add(this.cmb_numModelo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 143);
            this.panel2.TabIndex = 18;
            // 
            // cmb_idModelo
            // 
            this.cmb_idModelo.FormattingEnabled = true;
            this.cmb_idModelo.Location = new System.Drawing.Point(172, 74);
            this.cmb_idModelo.Name = "cmb_idModelo";
            this.cmb_idModelo.Pp_CampoAceptaNull = false;
            this.cmb_idModelo.Pp_EsPk = false;
            this.cmb_idModelo.Pp_MensajeError = "Error al cargar el idModelo";
            this.cmb_idModelo.Pp_NombreCampo = "idModelo";
            this.cmb_idModelo.Pp_NombreCampoInsert = null;
            this.cmb_idModelo.Pp_NombreTabla = "Avion";
            this.cmb_idModelo.Pp_PkTabla = "numeroPorModelo";
            this.cmb_idModelo.Size = new System.Drawing.Size(121, 21);
            this.cmb_idModelo.TabIndex = 20;
            // 
            // cmb_numModelo
            // 
            this.cmb_numModelo.FormattingEnabled = true;
            this.cmb_numModelo.Location = new System.Drawing.Point(172, 45);
            this.cmb_numModelo.Name = "cmb_numModelo";
            this.cmb_numModelo.Pp_CampoAceptaNull = false;
            this.cmb_numModelo.Pp_EsPk = true;
            this.cmb_numModelo.Pp_MensajeError = "Error al cargar el numero por modelo";
            this.cmb_numModelo.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_numModelo.Pp_NombreCampoInsert = null;
            this.cmb_numModelo.Pp_NombreTabla = "Avion";
            this.cmb_numModelo.Pp_PkTabla = "numeroPorModelo";
            this.cmb_numModelo.Size = new System.Drawing.Size(121, 21);
            this.cmb_numModelo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Reporte de avion por modelo";
            // 
            // Frm_AvionPorModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rv_avionPorModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AvionPorModelo";
            this.Text = "Frm_AvionPorModelo";
            this.Load += new System.EventHandler(this.Frm_AvionPorModelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rb_Todos;
        private System.Windows.Forms.RadioButton Rb_numModelo;
        private System.Windows.Forms.RadioButton Rb_idModelo;
        private System.Windows.Forms.Button btn_search;
        private Microsoft.Reporting.WinForms.ReportViewer rv_avionPorModelo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.ComboBox_Aerolinea cmb_idModelo;
        private Clase.ComboBox_Aerolinea cmb_numModelo;
    }
}