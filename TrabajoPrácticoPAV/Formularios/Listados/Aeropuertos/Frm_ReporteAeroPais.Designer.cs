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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RepAeroPaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds_ReporteAeroPais = new TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos.Ds_ReporteAeroPais();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu04 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pais = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_codigo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_nombres = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
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
            this.label1.Location = new System.Drawing.Point(100, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(118, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(138, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "País";
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu01.Location = new System.Drawing.Point(18, 19);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(100, 21);
            this.rbu01.TabIndex = 0;
            this.rbu01.TabStop = true;
            this.rbu01.Text = "Por nombre";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu02.Location = new System.Drawing.Point(18, 43);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(78, 21);
            this.rbu02.TabIndex = 1;
            this.rbu02.TabStop = true;
            this.rbu02.Text = "Por país";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu03.Location = new System.Drawing.Point(17, 66);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(94, 21);
            this.rbu03.TabIndex = 2;
            this.rbu03.TabStop = true;
            this.rbu03.Text = "Por código";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu04
            // 
            this.rbu04.AutoSize = true;
            this.rbu04.Checked = true;
            this.rbu04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu04.Location = new System.Drawing.Point(17, 91);
            this.rbu04.Name = "rbu04";
            this.rbu04.Size = new System.Drawing.Size(66, 21);
            this.rbu04.TabIndex = 3;
            this.rbu04.TabStop = true;
            this.rbu04.Text = "Todos";
            this.rbu04.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu04);
            this.groupBox1.Controls.Add(this.rbu01);
            this.groupBox1.Controls.Add(this.rbu02);
            this.groupBox1.Controls.Add(this.rbu03);
            this.groupBox1.Location = new System.Drawing.Point(422, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Cálculo";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(183, 72);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Pp_EsPk = false;
            this.txt_pais.Pp_MensajeError = null;
            this.txt_pais.Pp_NombreCampo = null;
            this.txt_pais.Pp_NombreTabla = null;
            this.txt_pais.Size = new System.Drawing.Size(100, 20);
            this.txt_pais.TabIndex = 7;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(183, 48);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Pp_EsPk = false;
            this.txt_codigo.Pp_MensajeError = null;
            this.txt_codigo.Pp_NombreCampo = null;
            this.txt_codigo.Pp_NombreTabla = null;
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // Txt_nombres
            // 
            this.Txt_nombres.Location = new System.Drawing.Point(183, 23);
            this.Txt_nombres.Name = "Txt_nombres";
            this.Txt_nombres.Pp_EsPk = false;
            this.Txt_nombres.Pp_MensajeError = null;
            this.Txt_nombres.Pp_NombreCampo = null;
            this.Txt_nombres.Pp_NombreTabla = null;
            this.Txt_nombres.Size = new System.Drawing.Size(100, 20);
            this.Txt_nombres.TabIndex = 5;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet01";
            reportDataSource1.Value = this.RepAeroPaisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos.ReporteAeroPais.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(708, 246);
            this.reportViewer1.TabIndex = 8;
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(629, 75);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(75, 23);
            this.button_Aerolinea1.TabIndex = 9;
            this.button_Aerolinea1.Text = "button_Aerolinea1";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // Frm_ReporteAeroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 379);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.Txt_nombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
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
        private Clase.TextBox_Aerolinea txt_codigo;
        private Clase.TextBox_Aerolinea txt_pais;
        private System.Windows.Forms.RadioButton rbu01;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu04;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepAeroPaisBindingSource;
        private Ds_ReporteAeroPais Ds_ReporteAeroPais;
        private Clase.Button_Aerolinea button_Aerolinea1;
    }
}