
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new TrabajoPrácticoPAV.Formularios.Listados.Aviones.DataSet1();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_modelos = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 554);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.cmb_modelos);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aviones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Aviones.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 246);
            this.reportViewer1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "modelo";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(159, 42);
            this.txt_id.Name = "txt_id";
            this.txt_id.Pp_EsPk = false;
            this.txt_id.Pp_MensajeError = null;
            this.txt_id.Pp_NombreCampo = null;
            this.txt_id.Pp_NombreTabla = null;
            this.txt_id.Size = new System.Drawing.Size(169, 20);
            this.txt_id.TabIndex = 11;
            // 
            // cmb_modelos
            // 
            this.cmb_modelos.FormattingEnabled = true;
            this.cmb_modelos.Location = new System.Drawing.Point(159, 70);
            this.cmb_modelos.Name = "cmb_modelos";
            this.cmb_modelos.Pp_CampoAceptaNull = false;
            this.cmb_modelos.Pp_EsPk = false;
            this.cmb_modelos.Pp_MensajeError = null;
            this.cmb_modelos.Pp_NombreCampo = "nombre";
            this.cmb_modelos.Pp_NombreCampoInsert = null;
            this.cmb_modelos.Pp_NombreTabla = "Modelo";
            this.cmb_modelos.Pp_PkTabla = "idModelo";
            this.cmb_modelos.Size = new System.Drawing.Size(169, 21);
            this.cmb_modelos.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu03);
            this.groupBox1.Controls.Add(this.rbu02);
            this.groupBox1.Controls.Add(this.rbu01);
            this.groupBox1.Location = new System.Drawing.Point(516, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Busqueda";
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Location = new System.Drawing.Point(6, 65);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(87, 17);
            this.rbu03.TabIndex = 2;
            this.rbu03.TabStop = true;
            this.rbu03.Text = "Buscar todos";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Location = new System.Drawing.Point(6, 42);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(90, 17);
            this.rbu02.TabIndex = 1;
            this.rbu02.TabStop = true;
            this.rbu02.Text = "Buscar por id ";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Location = new System.Drawing.Point(6, 19);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(113, 17);
            this.rbu01.TabIndex = 0;
            this.rbu01.TabStop = true;
            this.rbu01.Text = "Buscar por modelo";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(733, 96);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // Frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Reportes";
            this.Text = "Frm_Reportes";
            this.Load += new System.EventHandler(this.Frm_Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clase.TextBox_Aerolinea txt_id;
        private Clase.ComboBox_Aerolinea cmb_modelos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.RadioButton rbu01;
        private Clase.Button_Aerolinea btn_buscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Aviones.DataSet1 DataSet1;
    }
}