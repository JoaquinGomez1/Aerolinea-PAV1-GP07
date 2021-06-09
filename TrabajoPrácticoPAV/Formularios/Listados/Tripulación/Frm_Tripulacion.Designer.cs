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
            this.labelText021 = new Clase11.Clases.LabelText02();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu_Todos = new System.Windows.Forms.RadioButton();
            this.rbu_RangoId = new System.Windows.Forms.RadioButton();
            this.rbu_Cargo = new System.Windows.Forms.RadioButton();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Cargo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Tripulación.ReporteTripulacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 296);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(641, 77);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Pp_Presionado = false;
            this.btn_Calcular.Size = new System.Drawing.Size(81, 26);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // labelText021
            // 
            this.labelText021.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText021.Location = new System.Drawing.Point(-1, 12);
            this.labelText021.Margin = new System.Windows.Forms.Padding(4);
            this.labelText021.Name = "labelText021";
            this.labelText021.Pp_ancho = 10;
            this.labelText021.Pp_decimales = 2;
            this.labelText021.Pp_Etiqueta = "label1";
            this.labelText021.Pp_mensajeError = null;
            this.labelText021.Pp_nombre_campo = null;
            this.labelText021.Pp_nombre_tabla = null;
            this.labelText021.Pp_ReadOnly = false;
            this.labelText021.Pp_Text = "";
            this.labelText021.Pp_tipoDato = Clase11.Clases.LabelText02.TipoDato.texto;
            this.labelText021.Pp_validable = false;
            this.labelText021.Size = new System.Drawing.Size(228, 28);
            this.labelText021.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_RangoId);
            this.groupBox1.Controls.Add(this.rbu_Cargo);
            this.groupBox1.Location = new System.Drawing.Point(435, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Búsqueda";
            // 
            // rbu_Todos
            // 
            this.rbu_Todos.AutoSize = true;
            this.rbu_Todos.Location = new System.Drawing.Point(30, 74);
            this.rbu_Todos.Name = "rbu_Todos";
            this.rbu_Todos.Size = new System.Drawing.Size(69, 21);
            this.rbu_Todos.TabIndex = 2;
            this.rbu_Todos.TabStop = true;
            this.rbu_Todos.Text = "Todos";
            this.rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // rbu_RangoId
            // 
            this.rbu_RangoId.AutoSize = true;
            this.rbu_RangoId.Location = new System.Drawing.Point(31, 48);
            this.rbu_RangoId.Name = "rbu_RangoId";
            this.rbu_RangoId.Size = new System.Drawing.Size(112, 21);
            this.rbu_RangoId.TabIndex = 1;
            this.rbu_RangoId.TabStop = true;
            this.rbu_RangoId.Text = "Por Rango Id";
            this.rbu_RangoId.UseVisualStyleBackColor = true;
            // 
            // rbu_Cargo
            // 
            this.rbu_Cargo.AutoSize = true;
            this.rbu_Cargo.Location = new System.Drawing.Point(31, 21);
            this.rbu_Cargo.Name = "rbu_Cargo";
            this.rbu_Cargo.Size = new System.Drawing.Size(93, 21);
            this.rbu_Cargo.TabIndex = 0;
            this.rbu_Cargo.TabStop = true;
            this.rbu_Cargo.Text = "Por Cargo";
            this.rbu_Cargo.UseVisualStyleBackColor = true;
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(260, 107);
            this.Txt_Hasta.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(56, 22);
            this.Txt_Hasta.TabIndex = 49;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(186, 107);
            this.Txt_Desde.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(56, 22);
            this.Txt_Desde.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(238, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 36);
            this.label5.TabIndex = 50;
            this.label5.Text = "-";
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.Location = new System.Drawing.Point(194, 73);
            this.cmb_Cargo.Name = "cmb_Cargo";
            this.cmb_Cargo.Pp_CampoAceptaNull = true;
            this.cmb_Cargo.Pp_EsPk = false;
            this.cmb_Cargo.Pp_MensajeError = null;
            this.cmb_Cargo.Pp_NombreCampo = "nombre";
            this.cmb_Cargo.Pp_NombreCampoInsert = null;
            this.cmb_Cargo.Pp_NombreTabla = "Cargo_Tripulacion";
            this.cmb_Cargo.Pp_PkTabla = "idCargoTripulacion";
            this.cmb_Cargo.Size = new System.Drawing.Size(121, 24);
            this.cmb_Cargo.TabIndex = 51;
            // 
            // Frm_Tripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Cargo);
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelText021);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.reportViewer1);
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
        private Clase11.Clases.LabelText02 labelText021;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu_Todos;
        private System.Windows.Forms.RadioButton rbu_RangoId;
        private System.Windows.Forms.RadioButton rbu_Cargo;
        private Clase.TextBox_Aerolinea Txt_Hasta;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label5;
        private Clase.ComboBox_Aerolinea cmb_Cargo;
    }
}