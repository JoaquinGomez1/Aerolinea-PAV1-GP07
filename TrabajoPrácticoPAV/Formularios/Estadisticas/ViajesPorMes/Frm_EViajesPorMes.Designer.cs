
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.maskedTextBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 111);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(725, 295);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_Fechas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // rbu_Todos
            // 
            this.rbu_Todos.AutoSize = true;
            this.rbu_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_Todos.Location = new System.Drawing.Point(15, 43);
            this.rbu_Todos.Name = "rbu_Todos";
            this.rbu_Todos.Size = new System.Drawing.Size(71, 24);
            this.rbu_Todos.TabIndex = 1;
            this.rbu_Todos.TabStop = true;
            this.rbu_Todos.Text = "Todos";
            this.rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // rbu_Fechas
            // 
            this.rbu_Fechas.AutoSize = true;
            this.rbu_Fechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_Fechas.Location = new System.Drawing.Point(15, 16);
            this.rbu_Fechas.Name = "rbu_Fechas";
            this.rbu_Fechas.Size = new System.Drawing.Size(117, 24);
            this.rbu_Fechas.TabIndex = 0;
            this.rbu_Fechas.TabStop = true;
            this.rbu_Fechas.Text = "Entre meses";
            this.rbu_Fechas.UseVisualStyleBackColor = true;
            // 
            // btn_accept
            // 
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_accept.Location = new System.Drawing.Point(642, 64);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Pp_Presionado = false;
            this.btn_accept.Size = new System.Drawing.Size(95, 41);
            this.btn_accept.TabIndex = 4;
            this.btn_accept.Text = "Buscar";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(111, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entre meses:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estadistica de Viajes por Mes";
            // 
            // maskedTextBox_Aerolinea2
            // 
            this.maskedTextBox_Aerolinea2.Location = new System.Drawing.Point(290, 59);
            this.maskedTextBox_Aerolinea2.Mask = "00";
            this.maskedTextBox_Aerolinea2.Name = "maskedTextBox_Aerolinea2";
            this.maskedTextBox_Aerolinea2.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea2.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea2.Size = new System.Drawing.Size(27, 20);
            this.maskedTextBox_Aerolinea2.TabIndex = 6;
            this.maskedTextBox_Aerolinea2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_Aerolinea1
            // 
            this.maskedTextBox_Aerolinea1.Location = new System.Drawing.Point(235, 59);
            this.maskedTextBox_Aerolinea1.Mask = "00";
            this.maskedTextBox_Aerolinea1.Name = "maskedTextBox_Aerolinea1";
            this.maskedTextBox_Aerolinea1.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea1.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea1.Size = new System.Drawing.Size(29, 20);
            this.maskedTextBox_Aerolinea1.TabIndex = 5;
            this.maskedTextBox_Aerolinea1.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(269, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // Frm_EViajesPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_Aerolinea1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_Aerolinea2);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EViajesPorMes";
            this.Text = "Frm_EViajesPorMes";
            this.Load += new System.EventHandler(this.Frm_EViajesPorMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu_Todos;
        private System.Windows.Forms.RadioButton rbu_Fechas;
        private Clase.Button_Aerolinea btn_accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea2;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea1;
        private System.Windows.Forms.Label label2;
    }
}