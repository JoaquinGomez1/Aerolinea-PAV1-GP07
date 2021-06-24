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
            this.EquipajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds_EquipajeXPasajero = new TrabajoPrácticoPAV.Formularios.Listados.EquipajeXPasajero.Ds_EquipajeXPasajero();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu_Todos = new System.Windows.Forms.RadioButton();
            this.rbu_Peso = new System.Windows.Forms.RadioButton();
            this.rbu_Pasajero = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_Buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.msk_NroDoc = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_Peso);
            this.groupBox1.Controls.Add(this.rbu_Pasajero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(332, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(160, 109);
            this.groupBox1.TabIndex = 1;
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
            // rbu_Peso
            // 
            this.rbu_Peso.AutoSize = true;
            this.rbu_Peso.Location = new System.Drawing.Point(24, 54);
            this.rbu_Peso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbu_Peso.Name = "rbu_Peso";
            this.rbu_Peso.Size = new System.Drawing.Size(91, 24);
            this.rbu_Peso.TabIndex = 1;
            this.rbu_Peso.TabStop = true;
            this.rbu_Peso.Text = "Por Peso";
            this.rbu_Peso.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(55, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(88, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rango de Peso";
            // 
            // txt_Hasta
            // 
            this.txt_Hasta.Location = new System.Drawing.Point(271, 96);
            this.txt_Hasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Hasta.Name = "txt_Hasta";
            this.txt_Hasta.Pp_EsPk = false;
            this.txt_Hasta.Pp_MensajeError = null;
            this.txt_Hasta.Pp_NombreCampo = null;
            this.txt_Hasta.Pp_NombreTabla = null;
            this.txt_Hasta.Size = new System.Drawing.Size(37, 20);
            this.txt_Hasta.TabIndex = 9;
            // 
            // txt_Desde
            // 
            this.txt_Desde.Location = new System.Drawing.Point(211, 97);
            this.txt_Desde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Desde.Name = "txt_Desde";
            this.txt_Desde.Pp_EsPk = false;
            this.txt_Desde.Pp_MensajeError = null;
            this.txt_Desde.Pp_NombreCampo = null;
            this.txt_Desde.Pp_NombreTabla = null;
            this.txt_Desde.Size = new System.Drawing.Size(38, 20);
            this.txt_Desde.TabIndex = 8;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(211, 41);
            this.cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.cmb_TipoDoc.Pp_EsPk = false;
            this.cmb_TipoDoc.Pp_MensajeError = null;
            this.cmb_TipoDoc.Pp_NombreCampo = "tipoDoc";
            this.cmb_TipoDoc.Pp_NombreCampoInsert = null;
            this.cmb_TipoDoc.Pp_NombreTabla = "Equipaje";
            this.cmb_TipoDoc.Pp_PkTabla = "idEquipaje";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(97, 21);
            this.cmb_TipoDoc.TabIndex = 3;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(544, 80);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Pp_Presionado = false;
            this.btn_Buscar.Size = new System.Drawing.Size(75, 37);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reporte de Equipaje por Pasajero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(253, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "-";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 136);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(726, 215);
            this.reportViewer1.TabIndex = 22;
            // 
            // msk_NroDoc
            // 
            this.msk_NroDoc.Location = new System.Drawing.Point(211, 71);
            this.msk_NroDoc.Mask = "99999999";
            this.msk_NroDoc.Name = "msk_NroDoc";
            this.msk_NroDoc.Pp_EsPk = false;
            this.msk_NroDoc.Pp_MensajeError = null;
            this.msk_NroDoc.Pp_NombreCampo = null;
            this.msk_NroDoc.Pp_NombreTabla = null;
            this.msk_NroDoc.Size = new System.Drawing.Size(56, 20);
            this.msk_NroDoc.TabIndex = 23;
            // 
            // Frm_EquipajeXPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 366);
            this.Controls.Add(this.msk_NroDoc);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Hasta);
            this.Controls.Add(this.txt_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_TipoDoc);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Clase.TextBox_Aerolinea txt_Desde;
        private Clase.TextBox_Aerolinea txt_Hasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.MaskedTextBox_Aerolinea msk_NroDoc;
    }
}