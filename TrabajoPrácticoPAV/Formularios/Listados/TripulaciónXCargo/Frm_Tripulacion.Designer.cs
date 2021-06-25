namespace TrabajoPrácticoPAV.Formularios.Listados.Tripulación
{
    partial class Frm_Tripulacion
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
            this.btn_Calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu_Todos = new System.Windows.Forms.RadioButton();
            this.rbu_RangoId = new System.Windows.Forms.RadioButton();
            this.rbu_Cargo = new System.Windows.Forms.RadioButton();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Cargo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Tripulación.ReporteTripulacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 102);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(727, 305);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Calcular.Location = new System.Drawing.Point(643, 57);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Pp_Presionado = false;
            this.btn_Calcular.Size = new System.Drawing.Size(95, 41);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Buscar";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_RangoId);
            this.groupBox1.Controls.Add(this.rbu_Cargo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(423, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // rbu_Todos
            // 
            this.rbu_Todos.AutoSize = true;
            this.rbu_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_Todos.Location = new System.Drawing.Point(22, 60);
            this.rbu_Todos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbu_Todos.Name = "rbu_Todos";
            this.rbu_Todos.Size = new System.Drawing.Size(71, 24);
            this.rbu_Todos.TabIndex = 2;
            this.rbu_Todos.TabStop = true;
            this.rbu_Todos.Text = "Todos";
            this.rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // rbu_RangoId
            // 
            this.rbu_RangoId.AutoSize = true;
            this.rbu_RangoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_RangoId.Location = new System.Drawing.Point(23, 39);
            this.rbu_RangoId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbu_RangoId.Name = "rbu_RangoId";
            this.rbu_RangoId.Size = new System.Drawing.Size(121, 24);
            this.rbu_RangoId.TabIndex = 1;
            this.rbu_RangoId.TabStop = true;
            this.rbu_RangoId.Text = "Por Rango Id";
            this.rbu_RangoId.UseVisualStyleBackColor = true;
            // 
            // rbu_Cargo
            // 
            this.rbu_Cargo.AutoSize = true;
            this.rbu_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_Cargo.Location = new System.Drawing.Point(23, 17);
            this.rbu_Cargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbu_Cargo.Name = "rbu_Cargo";
            this.rbu_Cargo.Size = new System.Drawing.Size(98, 24);
            this.rbu_Cargo.TabIndex = 0;
            this.rbu_Cargo.TabStop = true;
            this.rbu_Cargo.Text = "Por Cargo";
            this.rbu_Cargo.UseVisualStyleBackColor = true;
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(242, 69);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(43, 20);
            this.Txt_Hasta.TabIndex = 49;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(184, 69);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(43, 20);
            this.Txt_Desde.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(226, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "-";
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.Location = new System.Drawing.Point(184, 39);
            this.cmb_Cargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Cargo.Name = "cmb_Cargo";
            this.cmb_Cargo.Pp_CampoAceptaNull = true;
            this.cmb_Cargo.Pp_EsPk = false;
            this.cmb_Cargo.Pp_MensajeError = null;
            this.cmb_Cargo.Pp_NombreCampo = "nombre";
            this.cmb_Cargo.Pp_NombreCampoInsert = null;
            this.cmb_Cargo.Pp_NombreTabla = "Cargo_Tripulacion";
            this.cmb_Cargo.Pp_PkTabla = "idCargoTripulacion";
            this.cmb_Cargo.Size = new System.Drawing.Size(101, 21);
            this.cmb_Cargo.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(80, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Rango de ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Listado de tripulación";
            // 
            // Frm_Tripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Cargo);
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Tripulacion";
            this.Text = "Frm_Tripulacion";
            this.Load += new System.EventHandler(this.Frm_Tripulacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.Button_Aerolinea btn_Calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu_Todos;
        private System.Windows.Forms.RadioButton rbu_RangoId;
        private System.Windows.Forms.RadioButton rbu_Cargo;
        private Clase.TextBox_Aerolinea Txt_Hasta;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label5;
        private Clase.ComboBox_Aerolinea cmb_Cargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}