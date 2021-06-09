namespace TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos
{
    partial class Frm_ReporteAeroPais
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RepAeroPaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds_ReporteAeroPais = new TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos.Ds_ReporteAeroPais();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.rbu04 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_pais = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_codigohasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_codigodesde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_nombres = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.RepAeroPaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ReporteAeroPais)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepAeroPaisBindingSource
            // 
            this.RepAeroPaisBindingSource.DataMember = "RepAeroPais";
            this.RepAeroPaisBindingSource.DataSource = this.Ds_ReporteAeroPais;
            // 
            // Ds_ReporteAeroPais
            // 
            this.Ds_ReporteAeroPais.DataSetName = "Ds_ReporteAeroPais";
            this.Ds_ReporteAeroPais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(5, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código que empiece con ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(80, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pais";
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu01.Location = new System.Drawing.Point(17, 19);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(100, 21);
            this.rbu01.TabIndex = 0;
            this.rbu01.Text = "Por nombre";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu03.Location = new System.Drawing.Point(17, 61);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(78, 21);
            this.rbu03.TabIndex = 1;
            this.rbu03.Text = "Por pais";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu02.Location = new System.Drawing.Point(17, 40);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(236, 21);
            this.rbu02.TabIndex = 2;
            this.rbu02.Text = "Empiece con la letra desde/hasta";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // rbu04
            // 
            this.rbu04.AutoSize = true;
            this.rbu04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu04.Location = new System.Drawing.Point(17, 82);
            this.rbu04.Name = "rbu04";
            this.rbu04.Size = new System.Drawing.Size(66, 21);
            this.rbu04.TabIndex = 3;
            this.rbu04.Text = "Todos";
            this.rbu04.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu04);
            this.groupBox1.Controls.Add(this.rbu01);
            this.groupBox1.Controls.Add(this.rbu03);
            this.groupBox1.Controls.Add(this.rbu02);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(401, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Cálculo";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet01";
            reportDataSource2.Value = this.RepAeroPaisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos.ReporteAeroPais.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(708, 246);
            this.reportViewer1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reporte de Aeropuerto por país";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(250, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "hasta";
            // 
            // cmb_pais
            // 
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(144, 86);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Pp_CampoAceptaNull = false;
            this.cmb_pais.Pp_EsPk = false;
            this.cmb_pais.Pp_MensajeError = null;
            this.cmb_pais.Pp_NombreCampo = "nombrePais";
            this.cmb_pais.Pp_NombreCampoInsert = null;
            this.cmb_pais.Pp_NombreTabla = "Pais";
            this.cmb_pais.Pp_PkTabla = "idPais";
            this.cmb_pais.Size = new System.Drawing.Size(99, 21);
            this.cmb_pais.TabIndex = 24;
            // 
            // txt_codigohasta
            // 
            this.txt_codigohasta.Location = new System.Drawing.Point(296, 59);
            this.txt_codigohasta.Name = "txt_codigohasta";
            this.txt_codigohasta.Pp_EsPk = false;
            this.txt_codigohasta.Pp_MensajeError = null;
            this.txt_codigohasta.Pp_NombreCampo = "codigo";
            this.txt_codigohasta.Pp_NombreTabla = "aeropuerto";
            this.txt_codigohasta.Size = new System.Drawing.Size(52, 20);
            this.txt_codigohasta.TabIndex = 23;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(646, 30);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(75, 31);
            this.btn_cerrar.TabIndex = 21;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(646, 69);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(75, 31);
            this.button_Aerolinea1.TabIndex = 9;
            this.button_Aerolinea1.Text = "Calcular";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // txt_codigodesde
            // 
            this.txt_codigodesde.Location = new System.Drawing.Point(191, 59);
            this.txt_codigodesde.Name = "txt_codigodesde";
            this.txt_codigodesde.Pp_EsPk = false;
            this.txt_codigodesde.Pp_MensajeError = null;
            this.txt_codigodesde.Pp_NombreCampo = "codigo";
            this.txt_codigodesde.Pp_NombreTabla = "aeropuerto";
            this.txt_codigodesde.Size = new System.Drawing.Size(52, 20);
            this.txt_codigodesde.TabIndex = 6;
            // 
            // Txt_nombres
            // 
            this.Txt_nombres.Location = new System.Drawing.Point(144, 34);
            this.Txt_nombres.Name = "Txt_nombres";
            this.Txt_nombres.Pp_EsPk = false;
            this.Txt_nombres.Pp_MensajeError = null;
            this.Txt_nombres.Pp_NombreCampo = "nombre";
            this.Txt_nombres.Pp_NombreTabla = "Aeropuerto";
            this.Txt_nombres.Size = new System.Drawing.Size(99, 20);
            this.Txt_nombres.TabIndex = 5;
            // 
            // Frm_ReporteAeroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 379);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.txt_codigohasta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txt_codigodesde);
            this.Controls.Add(this.Txt_nombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReporteAeroPais";
            this.Text = "Frm_ReporteAerop";
            this.Load += new System.EventHandler(this.Frm_ReporteAeroPais_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.RepAeroPaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ReporteAeroPais)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea Txt_nombres;
        private Clase.TextBox_Aerolinea txt_codigodesde;
        private System.Windows.Forms.RadioButton rbu01;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.RadioButton rbu04;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepAeroPaisBindingSource;
        private Ds_ReporteAeroPais Ds_ReporteAeroPais;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private System.Windows.Forms.Label label4;
        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.Label label5;
        private Clase.TextBox_Aerolinea txt_codigohasta;
        private Clase.ComboBox_Aerolinea cmb_pais;
    }
}