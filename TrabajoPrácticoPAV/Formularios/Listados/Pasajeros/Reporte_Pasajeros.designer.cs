namespace TrabajoPrácticoPAV.Formularios.Listados.Pasajeros
{
    partial class Reporte_Pasajeros
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
            this.RepoFamPasajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds_ReporteFamiliareXPasajero = new TrabajoPrácticoPAV.Formularios.Listados.Pasajeros.Ds_ReporteFamiliareXPasajero();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu04 = new System.Windows.Forms.RadioButton();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_ciudad = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_consultar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.RepoFamPasajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ReporteFamiliareXPasajero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepoFamPasajBindingSource
            // 
            this.RepoFamPasajBindingSource.DataMember = "RepoFamPasaj";
            this.RepoFamPasajBindingSource.DataSource = this.Ds_ReporteFamiliareXPasajero;
            // 
            // Ds_ReporteFamiliareXPasajero
            // 
            this.Ds_ReporteFamiliareXPasajero.DataSetName = "Ds_ReporteFamiliareXPasajero";
            this.Ds_ReporteFamiliareXPasajero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Reporte de pasajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(136, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Documento pasajero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu04);
            this.groupBox1.Controls.Add(this.rbu01);
            this.groupBox1.Controls.Add(this.rbu03);
            this.groupBox1.Controls.Add(this.rbu02);
            this.groupBox1.Location = new System.Drawing.Point(552, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(281, 135);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Cálculo";
            // 
            // rbu04
            // 
            this.rbu04.AutoSize = true;
            this.rbu04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu04.Location = new System.Drawing.Point(8, 101);
            this.rbu04.Margin = new System.Windows.Forms.Padding(4);
            this.rbu04.Name = "rbu04";
            this.rbu04.Size = new System.Drawing.Size(76, 24);
            this.rbu04.TabIndex = 3;
            this.rbu04.Text = "Todos";
            this.rbu04.UseVisualStyleBackColor = true;
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu01.Location = new System.Drawing.Point(8, 23);
            this.rbu01.Margin = new System.Windows.Forms.Padding(4);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(212, 24);
            this.rbu01.TabIndex = 0;
            this.rbu01.Text = "Por documento pasajero";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu03.Location = new System.Drawing.Point(8, 75);
            this.rbu03.Margin = new System.Windows.Forms.Padding(4);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(113, 24);
            this.rbu03.TabIndex = 1;
            this.rbu03.Text = "Por Ciudad";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu02.Location = new System.Drawing.Point(8, 49);
            this.rbu02.Margin = new System.Windows.Forms.Padding(4);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(118, 24);
            this.rbu02.TabIndex = 2;
            this.rbu02.Text = "Por apellido";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "FamiliarXPasajero";
            reportDataSource1.Value = this.RepoFamPasajBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Pasajeros.ReporteFamiliareXPasajero.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 162);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 329);
            this.reportViewer1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(128, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(381, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 36);
            this.label6.TabIndex = 54;
            this.label6.Text = "-";
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(415, 61);
            this.Txt_Hasta.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(74, 22);
            this.Txt_Hasta.TabIndex = 53;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(295, 61);
            this.Txt_Desde.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(80, 22);
            this.Txt_Desde.TabIndex = 52;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(298, 91);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_EsPk = false;
            this.txt_apellido.Pp_MensajeError = null;
            this.txt_apellido.Pp_NombreCampo = null;
            this.txt_apellido.Pp_NombreTabla = null;
            this.txt_apellido.Size = new System.Drawing.Size(191, 22);
            this.txt_apellido.TabIndex = 43;
            // 
            // cmb_ciudad
            // 
            this.cmb_ciudad.FormattingEnabled = true;
            this.cmb_ciudad.Location = new System.Drawing.Point(298, 121);
            this.cmb_ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ciudad.Name = "cmb_ciudad";
            this.cmb_ciudad.Pp_CampoAceptaNull = false;
            this.cmb_ciudad.Pp_EsPk = false;
            this.cmb_ciudad.Pp_MensajeError = null;
            this.cmb_ciudad.Pp_NombreCampo = "nombreCiudad";
            this.cmb_ciudad.Pp_NombreCampoInsert = null;
            this.cmb_ciudad.Pp_NombreTabla = "Ciudad";
            this.cmb_ciudad.Pp_PkTabla = "idCiudad";
            this.cmb_ciudad.Size = new System.Drawing.Size(191, 24);
            this.cmb_ciudad.TabIndex = 41;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(865, 55);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(100, 41);
            this.btn_cerrar.TabIndex = 36;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(865, 104);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Pp_Presionado = false;
            this.btn_consultar.Size = new System.Drawing.Size(100, 41);
            this.btn_consultar.TabIndex = 27;
            this.btn_consultar.Text = "Calcular";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Reporte_Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_ciudad);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reporte_Pasajeros";
            this.Text = "Reporte_Pasajeros";
            this.Load += new System.EventHandler(this.Reporte_Pasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepoFamPasajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ReporteFamiliareXPasajero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu04;
        private System.Windows.Forms.RadioButton rbu01;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu02;
        private Clase.Button_Aerolinea btn_consultar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.ComboBox_Aerolinea cmb_ciudad;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_apellido;
        private System.Windows.Forms.BindingSource RepoFamPasajBindingSource;
        private Ds_ReporteFamiliareXPasajero Ds_ReporteFamiliareXPasajero;
        private Clase.TextBox_Aerolinea Txt_Hasta;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label6;
    }
}