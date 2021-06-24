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
            this.reportViewer1.Location = new System.Drawing.Point(12, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(928, 295);
            this.reportViewer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rango de DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Número Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Documento";
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(235, 42);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.cmb_TipoDoc.Pp_EsPk = false;
            this.cmb_TipoDoc.Pp_MensajeError = null;
            this.cmb_TipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.cmb_TipoDoc.Pp_NombreCampoInsert = null;
            this.cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(150, 24);
            this.cmb_TipoDoc.TabIndex = 13;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(673, 114);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Pp_Presionado = false;
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(452, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Búsqueda";
            // 
            // rbu_Todos
            // 
            this.rbu_Todos.AutoSize = true;
            this.rbu_Todos.Location = new System.Drawing.Point(32, 93);
            this.rbu_Todos.Name = "rbu_Todos";
            this.rbu_Todos.Size = new System.Drawing.Size(69, 21);
            this.rbu_Todos.TabIndex = 2;
            this.rbu_Todos.TabStop = true;
            this.rbu_Todos.Text = "Todos";
            this.rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // rbu_Rango
            // 
            this.rbu_Rango.AutoSize = true;
            this.rbu_Rango.Location = new System.Drawing.Point(32, 66);
            this.rbu_Rango.Name = "rbu_Rango";
            this.rbu_Rango.Size = new System.Drawing.Size(97, 21);
            this.rbu_Rango.TabIndex = 1;
            this.rbu_Rango.TabStop = true;
            this.rbu_Rango.Text = "Por Rango";
            this.rbu_Rango.UseVisualStyleBackColor = true;
            // 
            // rbu_Pasajero
            // 
            this.rbu_Pasajero.AutoSize = true;
            this.rbu_Pasajero.Location = new System.Drawing.Point(32, 39);
            this.rbu_Pasajero.Name = "rbu_Pasajero";
            this.rbu_Pasajero.Size = new System.Drawing.Size(111, 21);
            this.rbu_Pasajero.TabIndex = 0;
            this.rbu_Pasajero.TabStop = true;
            this.rbu_Pasajero.Text = "Por Pasajero";
            this.rbu_Pasajero.UseVisualStyleBackColor = true;
            // 
            // txt_Hasta
            // 
            this.txt_Hasta.Location = new System.Drawing.Point(235, 108);
            this.txt_Hasta.Mask = "99999999";
            this.txt_Hasta.Name = "txt_Hasta";
            this.txt_Hasta.Pp_EsPk = false;
            this.txt_Hasta.Pp_MensajeError = null;
            this.txt_Hasta.Pp_NombreCampo = null;
            this.txt_Hasta.Pp_NombreTabla = null;
            this.txt_Hasta.Size = new System.Drawing.Size(72, 22);
            this.txt_Hasta.TabIndex = 20;
            // 
            // txt_Desde
            // 
            this.txt_Desde.Location = new System.Drawing.Point(313, 108);
            this.txt_Desde.Mask = "99999999";
            this.txt_Desde.Name = "txt_Desde";
            this.txt_Desde.Pp_EsPk = false;
            this.txt_Desde.Pp_MensajeError = null;
            this.txt_Desde.Pp_NombreCampo = null;
            this.txt_Desde.Pp_NombreTabla = null;
            this.txt_Desde.Size = new System.Drawing.Size(72, 22);
            this.txt_Desde.TabIndex = 20;
            // 
            // msk_NroDoc
            // 
            this.msk_NroDoc.Location = new System.Drawing.Point(235, 80);
            this.msk_NroDoc.Mask = "99999999";
            this.msk_NroDoc.Name = "msk_NroDoc";
            this.msk_NroDoc.Pp_EsPk = false;
            this.msk_NroDoc.Pp_MensajeError = null;
            this.msk_NroDoc.Pp_NombreCampo = null;
            this.msk_NroDoc.Pp_NombreTabla = null;
            this.msk_NroDoc.Size = new System.Drawing.Size(150, 22);
            this.msk_NroDoc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "Reporte de factura por pasajero";
            // 
            // Frm_facturaXPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
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