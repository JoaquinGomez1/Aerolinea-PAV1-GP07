
namespace TrabajoPrácticoPAV.Formularios.Listados
{
    partial class Frm_Reportes
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new TrabajoPrácticoPAV.Formularios.Listados.Aviones.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_modelos = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Aviones.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(725, 288);
            this.reportViewer1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(131, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(93, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "modelo";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(160, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Pp_EsPk = false;
            this.txt_id.Pp_MensajeError = null;
            this.txt_id.Pp_NombreCampo = null;
            this.txt_id.Pp_NombreTabla = null;
            this.txt_id.Size = new System.Drawing.Size(169, 20);
            this.txt_id.TabIndex = 17;
            // 
            // cmb_modelos
            // 
            this.cmb_modelos.FormattingEnabled = true;
            this.cmb_modelos.Location = new System.Drawing.Point(160, 65);
            this.cmb_modelos.Name = "cmb_modelos";
            this.cmb_modelos.Pp_CampoAceptaNull = false;
            this.cmb_modelos.Pp_EsPk = false;
            this.cmb_modelos.Pp_MensajeError = null;
            this.cmb_modelos.Pp_NombreCampo = "nombre";
            this.cmb_modelos.Pp_NombreCampoInsert = null;
            this.cmb_modelos.Pp_NombreTabla = "Modelo";
            this.cmb_modelos.Pp_PkTabla = "idModelo";
            this.cmb_modelos.Size = new System.Drawing.Size(169, 21);
            this.cmb_modelos.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu03);
            this.groupBox1.Controls.Add(this.rbu02);
            this.groupBox1.Controls.Add(this.rbu01);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(385, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Busqueda";
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu03.Location = new System.Drawing.Point(6, 65);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(121, 24);
            this.rbu03.TabIndex = 2;
            this.rbu03.TabStop = true;
            this.rbu03.Text = "Buscar todos";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu02.Location = new System.Drawing.Point(6, 42);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(124, 24);
            this.rbu02.TabIndex = 1;
            this.rbu02.TabStop = true;
            this.rbu02.Text = "Buscar por id ";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu01.Location = new System.Drawing.Point(6, 19);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(160, 24);
            this.rbu01.TabIndex = 0;
            this.rbu01.TabStop = true;
            this.rbu01.Text = "Buscar por modelo";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Aerolinea1.Location = new System.Drawing.Point(642, 71);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(95, 41);
            this.button_Aerolinea1.TabIndex = 21;
            this.button_Aerolinea1.Text = "Buscar";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Reporte de aviones";
            // 
            // Frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cmb_modelos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reportes";
            this.Text = "Frm_Reportes";
            this.Load += new System.EventHandler(this.Frm_Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Aviones.DataSet1 DataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clase.TextBox_Aerolinea txt_id;
        private Clase.ComboBox_Aerolinea cmb_modelos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.RadioButton rbu01;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private System.Windows.Forms.Label label5;
    }
}