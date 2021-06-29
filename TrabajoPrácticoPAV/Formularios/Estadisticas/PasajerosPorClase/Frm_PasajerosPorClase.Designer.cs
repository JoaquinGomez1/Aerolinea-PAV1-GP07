
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosPorViaje
{
    partial class Frm_PasajerosPorViaje
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
            this.rv_pasajerosPorViaje = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxt_año = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.lbl_año = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.rbu_año = new System.Windows.Forms.RadioButton();
            this.rbu_todos = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_pasajerosPorViaje
            // 
            this.rv_pasajerosPorViaje.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosPorViaje.EstadisticaPasajero" +
    "sPorViaje.rdlc";
            this.rv_pasajerosPorViaje.Location = new System.Drawing.Point(12, 118);
            this.rv_pasajerosPorViaje.Name = "rv_pasajerosPorViaje";
            this.rv_pasajerosPorViaje.ServerReport.BearerToken = null;
            this.rv_pasajerosPorViaje.Size = new System.Drawing.Size(727, 249);
            this.rv_pasajerosPorViaje.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mtxt_año);
            this.panel1.Controls.Add(this.lbl_año);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 86);
            this.panel1.TabIndex = 18;
            // 
            // mtxt_año
            // 
            this.mtxt_año.Location = new System.Drawing.Point(116, 37);
            this.mtxt_año.Mask = "0000";
            this.mtxt_año.Name = "mtxt_año";
            this.mtxt_año.Pp_EsPk = false;
            this.mtxt_año.Pp_MensajeError = null;
            this.mtxt_año.Pp_NombreCampo = null;
            this.mtxt_año.Pp_NombreTabla = null;
            this.mtxt_año.Size = new System.Drawing.Size(61, 20);
            this.mtxt_año.TabIndex = 14;
            // 
            // lbl_año
            // 
            this.lbl_año.AutoSize = true;
            this.lbl_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_año.Location = new System.Drawing.Point(73, 37);
            this.lbl_año.Name = "lbl_año";
            this.lbl_año.Size = new System.Drawing.Size(42, 20);
            this.lbl_año.TabIndex = 12;
            this.lbl_año.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por año";
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_calcular.Location = new System.Drawing.Point(642, 71);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Pp_Presionado = false;
            this.btn_calcular.Size = new System.Drawing.Size(95, 41);
            this.btn_calcular.TabIndex = 15;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cerrar.Location = new System.Drawing.Point(644, 373);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(95, 41);
            this.btn_cerrar.TabIndex = 17;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // rbu_año
            // 
            this.rbu_año.AutoSize = true;
            this.rbu_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_año.Location = new System.Drawing.Point(28, 24);
            this.rbu_año.Name = "rbu_año";
            this.rbu_año.Size = new System.Drawing.Size(82, 24);
            this.rbu_año.TabIndex = 16;
            this.rbu_año.Text = "Por año";
            this.rbu_año.UseVisualStyleBackColor = true;
            // 
            // rbu_todos
            // 
            this.rbu_todos.AutoSize = true;
            this.rbu_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu_todos.Location = new System.Drawing.Point(28, 48);
            this.rbu_todos.Name = "rbu_todos";
            this.rbu_todos.Size = new System.Drawing.Size(71, 24);
            this.rbu_todos.TabIndex = 17;
            this.rbu_todos.Text = "Todos";
            this.rbu_todos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbu_todos);
            this.panel2.Controls.Add(this.rbu_año);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(390, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 86);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selección";
            // 
            // Frm_PasajerosPorViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.rv_pasajerosPorViaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PasajerosPorViaje";
            this.Text = "Frm_PasajerosPorViaje";
            this.Load += new System.EventHandler(this.Frm_PasajerosPorViaje_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_pasajerosPorViaje;
        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_año;
        private Clase.Button_Aerolinea btn_calcular;
        private Clase.MaskedTextBox_Aerolinea mtxt_año;
        private System.Windows.Forms.RadioButton rbu_año;
        private System.Windows.Forms.RadioButton rbu_todos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}