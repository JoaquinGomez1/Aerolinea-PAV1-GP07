namespace TrabajoPrácticoPAV.Formularios.Estadisticas.VueloPorAvion
{
    partial class Frm_EVueloPorAvion
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
            this.label1 = new System.Windows.Forms.Label();
            this.rd_PorModelo = new System.Windows.Forms.RadioButton();
            this.rd_Todos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_NomModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_Calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.VueloPorAvion.Estadistica_VueloPorAvi" +
    "on.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(129, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelo";
            // 
            // rd_PorModelo
            // 
            this.rd_PorModelo.AutoSize = true;
            this.rd_PorModelo.Location = new System.Drawing.Point(59, 32);
            this.rd_PorModelo.Name = "rd_PorModelo";
            this.rd_PorModelo.Size = new System.Drawing.Size(101, 21);
            this.rd_PorModelo.TabIndex = 4;
            this.rd_PorModelo.TabStop = true;
            this.rd_PorModelo.Text = "Por Modelo";
            this.rd_PorModelo.UseVisualStyleBackColor = true;
            // 
            // rd_Todos
            // 
            this.rd_Todos.AutoSize = true;
            this.rd_Todos.Location = new System.Drawing.Point(59, 59);
            this.rd_Todos.Name = "rd_Todos";
            this.rd_Todos.Size = new System.Drawing.Size(69, 21);
            this.rd_Todos.TabIndex = 5;
            this.rd_Todos.TabStop = true;
            this.rd_Todos.Text = "Todos";
            this.rd_Todos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de Vuelos por Avión";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_PorModelo);
            this.groupBox1.Controls.Add(this.rd_Todos);
            this.groupBox1.Location = new System.Drawing.Point(457, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas";
            // 
            // cmb_NomModelo
            // 
            this.cmb_NomModelo.FormattingEnabled = true;
            this.cmb_NomModelo.Location = new System.Drawing.Point(207, 55);
            this.cmb_NomModelo.Name = "cmb_NomModelo";
            this.cmb_NomModelo.Pp_CampoAceptaNull = false;
            this.cmb_NomModelo.Pp_EsPk = false;
            this.cmb_NomModelo.Pp_MensajeError = null;
            this.cmb_NomModelo.Pp_NombreCampo = "nombre";
            this.cmb_NomModelo.Pp_NombreCampoInsert = null;
            this.cmb_NomModelo.Pp_NombreTabla = "Modelo";
            this.cmb_NomModelo.Pp_PkTabla = "idModelo";
            this.cmb_NomModelo.Size = new System.Drawing.Size(165, 24);
            this.cmb_NomModelo.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(762, 73);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Pp_Presionado = false;
            this.btn_Calcular.Size = new System.Drawing.Size(109, 35);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Frm_EVueloPorAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_NomModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EVueloPorAvion";
            this.Text = "Frm_EVueloPorAvion";
            this.Load += new System.EventHandler(this.Frm_EVueloPorAvion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.Button_Aerolinea btn_Calcular;
        private System.Windows.Forms.Label label1;
        private Clase.ComboBox_Aerolinea cmb_NomModelo;
        private System.Windows.Forms.RadioButton rd_PorModelo;
        private System.Windows.Forms.RadioButton rd_Todos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}