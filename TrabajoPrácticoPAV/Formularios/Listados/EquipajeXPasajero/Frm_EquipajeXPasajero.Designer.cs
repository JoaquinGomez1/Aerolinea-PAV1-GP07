namespace TrabajoPrácticoPAV.Formularios.Listados.EquipajeXPasajero
{
    partial class Frm_EquipajeXPasajero
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
            this.EquipajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds_EquipajeXPasajero = new TrabajoPrácticoPAV.Formularios.Listados.EquipajeXPasajero.Ds_EquipajeXPasajero();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu_Todos = new System.Windows.Forms.RadioButton();
            this.rbu_Peso = new System.Windows.Forms.RadioButton();
            this.rbu_Pasajero = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_NroDoc = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_Buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.EquipajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_EquipajeXPasajero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EquipajeBindingSource
            // 
            this.EquipajeBindingSource.DataMember = "Equipaje";
            this.EquipajeBindingSource.DataSource = this.Ds_EquipajeXPasajero;
            // 
            // Ds_EquipajeXPasajero
            // 
            this.Ds_EquipajeXPasajero.DataSetName = "Ds_EquipajeXPasajero";
            this.Ds_EquipajeXPasajero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EquipajeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.EquipajeXPasajero.ReporteEquipaje.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 173);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(796, 275);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_Peso);
            this.groupBox1.Controls.Add(this.rbu_Pasajero);
            this.groupBox1.Location = new System.Drawing.Point(443, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 134);
            this.groupBox1.TabIndex = 1;
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
            // rbu_Peso
            // 
            this.rbu_Peso.AutoSize = true;
            this.rbu_Peso.Location = new System.Drawing.Point(32, 66);
            this.rbu_Peso.Name = "rbu_Peso";
            this.rbu_Peso.Size = new System.Drawing.Size(87, 21);
            this.rbu_Peso.TabIndex = 1;
            this.rbu_Peso.TabStop = true;
            this.rbu_Peso.Text = "Por Peso";
            this.rbu_Peso.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rango de Peso";
            // 
            // msk_NroDoc
            // 
            this.msk_NroDoc.Location = new System.Drawing.Point(226, 88);
            this.msk_NroDoc.Name = "msk_NroDoc";
            this.msk_NroDoc.Pp_EsPk = false;
            this.msk_NroDoc.Pp_MensajeError = null;
            this.msk_NroDoc.Pp_NombreCampo = null;
            this.msk_NroDoc.Pp_NombreTabla = null;
            this.msk_NroDoc.Size = new System.Drawing.Size(128, 22);
            this.msk_NroDoc.TabIndex = 10;
            // 
            // txt_Hasta
            // 
            this.txt_Hasta.Location = new System.Drawing.Point(306, 119);
            this.txt_Hasta.Name = "txt_Hasta";
            this.txt_Hasta.Pp_EsPk = false;
            this.txt_Hasta.Pp_MensajeError = null;
            this.txt_Hasta.Pp_NombreCampo = null;
            this.txt_Hasta.Pp_NombreTabla = null;
            this.txt_Hasta.Size = new System.Drawing.Size(48, 22);
            this.txt_Hasta.TabIndex = 9;
            // 
            // txt_Desde
            // 
            this.txt_Desde.Location = new System.Drawing.Point(226, 119);
            this.txt_Desde.Name = "txt_Desde";
            this.txt_Desde.Pp_EsPk = false;
            this.txt_Desde.Pp_MensajeError = null;
            this.txt_Desde.Pp_NombreCampo = null;
            this.txt_Desde.Pp_NombreTabla = null;
            this.txt_Desde.Size = new System.Drawing.Size(50, 22);
            this.txt_Desde.TabIndex = 8;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(226, 51);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.cmb_TipoDoc.Pp_EsPk = false;
            this.cmb_TipoDoc.Pp_MensajeError = null;
            this.cmb_TipoDoc.Pp_NombreCampo = "tipoDoc";
            this.cmb_TipoDoc.Pp_NombreCampoInsert = null;
            this.cmb_TipoDoc.Pp_NombreTabla = "Equipaje";
            this.cmb_TipoDoc.Pp_PkTabla = "idEquipaje";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(128, 24);
            this.cmb_TipoDoc.TabIndex = 3;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(664, 123);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Pp_Presionado = false;
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(17, 407);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = null;
            this.textBox_Aerolinea1.Pp_NombreCampo = null;
            this.textBox_Aerolinea1.Pp_NombreTabla = null;
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(121, 22);
            this.textBox_Aerolinea1.TabIndex = 7;
            // 
            // Frm_EquipajeXPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msk_NroDoc);
            this.Controls.Add(this.txt_Hasta);
            this.Controls.Add(this.txt_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_TipoDoc);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EquipajeXPasajero";
            this.Text = "Frm_EquipajeXPasajero";
            this.Load += new System.EventHandler(this.Frm_EquipajeXPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_EquipajeXPasajero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EquipajeBindingSource;
        private Ds_EquipajeXPasajero Ds_EquipajeXPasajero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu_Todos;
        private System.Windows.Forms.RadioButton rbu_Peso;
        private System.Windows.Forms.RadioButton rbu_Pasajero;
        private Clase.Button_Aerolinea btn_Buscar;
        private Clase.ComboBox_Aerolinea cmb_TipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private Clase.TextBox_Aerolinea txt_Desde;
        private Clase.TextBox_Aerolinea txt_Hasta;
        private Clase.MaskedTextBox_Aerolinea msk_NroDoc;
    }
}