
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorMes
{
    partial class Frm_EViajesPorMes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu_Todos = new System.Windows.Forms.RadioButton();
            this.rbu_Fechas = new System.Windows.Forms.RadioButton();
            this.btn_accept = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.maskedTextBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.maskedTextBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(710, 295);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_Fechas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(330, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbu_Todos
            // 
            this.rbu_Todos.AutoSize = true;
            this.rbu_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_Todos.Location = new System.Drawing.Point(129, 16);
            this.rbu_Todos.Name = "rbu_Todos";
            this.rbu_Todos.Size = new System.Drawing.Size(66, 21);
            this.rbu_Todos.TabIndex = 1;
            this.rbu_Todos.TabStop = true;
            this.rbu_Todos.Text = "Todos";
            this.rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // rbu_Fechas
            // 
            this.rbu_Fechas.AutoSize = true;
            this.rbu_Fechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_Fechas.Location = new System.Drawing.Point(15, 16);
            this.rbu_Fechas.Name = "rbu_Fechas";
            this.rbu_Fechas.Size = new System.Drawing.Size(105, 21);
            this.rbu_Fechas.TabIndex = 0;
            this.rbu_Fechas.TabStop = true;
            this.rbu_Fechas.Text = "Entre meses";
            this.rbu_Fechas.UseVisualStyleBackColor = true;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(611, 37);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Pp_Presionado = false;
            this.btn_accept.Size = new System.Drawing.Size(111, 23);
            this.btn_accept.TabIndex = 4;
            this.btn_accept.Text = "Buscar";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // maskedTextBox_Aerolinea1
            // 
            this.maskedTextBox_Aerolinea1.Location = new System.Drawing.Point(28, 3);
            this.maskedTextBox_Aerolinea1.Mask = "00";
            this.maskedTextBox_Aerolinea1.Name = "maskedTextBox_Aerolinea1";
            this.maskedTextBox_Aerolinea1.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea1.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea1.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox_Aerolinea1.TabIndex = 5;
            this.maskedTextBox_Aerolinea1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_Aerolinea2
            // 
            this.maskedTextBox_Aerolinea2.Location = new System.Drawing.Point(70, 3);
            this.maskedTextBox_Aerolinea2.Mask = "00";
            this.maskedTextBox_Aerolinea2.Name = "maskedTextBox_Aerolinea2";
            this.maskedTextBox_Aerolinea2.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea2.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea2.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox_Aerolinea2.TabIndex = 6;
            this.maskedTextBox_Aerolinea2.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBox_Aerolinea1);
            this.panel1.Controls.Add(this.maskedTextBox_Aerolinea2);
            this.panel1.Location = new System.Drawing.Point(98, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 27);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entre meses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // Frm_EViajesPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EViajesPorMes";
            this.Text = "Frm_EViajesPorMes";
            this.Load += new System.EventHandler(this.Frm_EViajesPorMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu_Todos;
        private System.Windows.Forms.RadioButton rbu_Fechas;
        private Clase.Button_Aerolinea btn_accept;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea1;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}