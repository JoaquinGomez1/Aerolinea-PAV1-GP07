namespace TrabajoPrácticoPAV.Formularios.Listados.FacturasXPasajero
{
    partial class Frm_facturaXPasajero
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_Buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu_Todos = new System.Windows.Forms.RadioButton();
            this.rbu_Rango = new System.Windows.Forms.RadioButton();
            this.rbu_Pasajero = new System.Windows.Forms.RadioButton();
            this.txt_Hasta = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.txt_Desde = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.msk_NroDoc = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(9, 116);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(729, 291);
            this.reportViewer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(92, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rango de DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Número Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Documento";
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(218, 34);
            this.cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.cmb_TipoDoc.Pp_EsPk = false;
            this.cmb_TipoDoc.Pp_MensajeError = null;
            this.cmb_TipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.cmb_TipoDoc.Pp_NombreCampoInsert = null;
            this.cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(114, 21);
            this.cmb_TipoDoc.TabIndex = 13;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Buscar.Location = new System.Drawing.Point(643, 71);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Pp_Presionado = false;
            this.btn_Buscar.Size = new System.Drawing.Size(95, 41);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_Rango);
            this.groupBox1.Controls.Add(this.rbu_Pasajero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(432, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(172, 109);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Búsqueda";
            // 
            // rbu_Todos
            // 
            this.rbu_Todos.AutoSize = true;
            this.rbu_Todos.Location = new System.Drawing.Point(24, 76);
            this.rbu_Todos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbu_Todos.Name = "rbu_Todos";
            this.rbu_Todos.Size = new System.Drawing.Size(71, 24);
            this.rbu_Todos.TabIndex = 2;
            this.rbu_Todos.TabStop = true;
            this.rbu_Todos.Text = "Todos";
            this.rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // rbu_Rango
            // 
            this.rbu_Rango.AutoSize = true;
            this.rbu_Rango.Location = new System.Drawing.Point(24, 54);
            this.rbu_Rango.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbu_Rango.Name = "rbu_Rango";
            this.rbu_Rango.Size = new System.Drawing.Size(103, 24);
            this.rbu_Rango.TabIndex = 1;
            this.rbu_Rango.TabStop = true;
            this.rbu_Rango.Text = "Por Rango";
            this.rbu_Rango.UseVisualStyleBackColor = true;
            // 
            // rbu_Pasajero
            // 
            this.rbu_Pasajero.AutoSize = true;
            this.rbu_Pasajero.Location = new System.Drawing.Point(24, 32);
            this.rbu_Pasajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbu_Pasajero.Name = "rbu_Pasajero";
            this.rbu_Pasajero.Size = new System.Drawing.Size(117, 24);
            this.rbu_Pasajero.TabIndex = 0;
            this.rbu_Pasajero.TabStop = true;
            this.rbu_Pasajero.Text = "Por Pasajero";
            this.rbu_Pasajero.UseVisualStyleBackColor = true;
            // 
            // txt_Hasta
            // 
            this.txt_Hasta.Location = new System.Drawing.Point(218, 88);
            this.txt_Hasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Hasta.Mask = "99999999";
            this.txt_Hasta.Name = "txt_Hasta";
            this.txt_Hasta.Pp_EsPk = false;
            this.txt_Hasta.Pp_MensajeError = null;
            this.txt_Hasta.Pp_NombreCampo = null;
            this.txt_Hasta.Pp_NombreTabla = null;
            this.txt_Hasta.Size = new System.Drawing.Size(55, 20);
            this.txt_Hasta.TabIndex = 20;
            // 
            // txt_Desde
            // 
            this.txt_Desde.Location = new System.Drawing.Point(277, 88);
            this.txt_Desde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Desde.Mask = "99999999";
            this.txt_Desde.Name = "txt_Desde";
            this.txt_Desde.Pp_EsPk = false;
            this.txt_Desde.Pp_MensajeError = null;
            this.txt_Desde.Pp_NombreCampo = null;
            this.txt_Desde.Pp_NombreTabla = null;
            this.txt_Desde.Size = new System.Drawing.Size(55, 20);
            this.txt_Desde.TabIndex = 20;
            // 
            // msk_NroDoc
            // 
            this.msk_NroDoc.Location = new System.Drawing.Point(218, 61);
            this.msk_NroDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msk_NroDoc.Mask = "99999999";
            this.msk_NroDoc.Name = "msk_NroDoc";
            this.msk_NroDoc.Pp_EsPk = false;
            this.msk_NroDoc.Pp_MensajeError = null;
            this.msk_NroDoc.Pp_NombreCampo = null;
            this.msk_NroDoc.Pp_NombreTabla = null;
            this.msk_NroDoc.Size = new System.Drawing.Size(114, 20);
            this.msk_NroDoc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Reporte de factura por pasajero";
            // 
            // Frm_facturaXPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msk_NroDoc);
            this.Controls.Add(this.txt_Desde);
            this.Controls.Add(this.txt_Hasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_TipoDoc);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_facturaXPasajero";
            this.Text = "Frm_facturaXPasajero";
            this.Load += new System.EventHandler(this.Frm_facturaXPasajero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clase.ComboBox_Aerolinea cmb_TipoDoc;
        private Clase.Button_Aerolinea btn_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu_Todos;
        private System.Windows.Forms.RadioButton rbu_Rango;
        private System.Windows.Forms.RadioButton rbu_Pasajero;
        private Clase.MaskedTextBox_Aerolinea txt_Hasta;
        private Clase.MaskedTextBox_Aerolinea txt_Desde;
        private Clase.MaskedTextBox_Aerolinea msk_NroDoc;
        private System.Windows.Forms.Label label4;
    }
}