
namespace TrabajoPrácticoPAV.Formularios.Listados.Viajes
{
    partial class Frm_ListadoViajes
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.rbu04 = new System.Windows.Forms.RadioButton();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.rv_01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.msk_txt2 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.msk_txt1 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(88, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Horario  Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(88, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Horario Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbu02);
            this.groupBox2.Controls.Add(this.rbu04);
            this.groupBox2.Controls.Add(this.rbu01);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 114);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Busqueda";
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu02.Location = new System.Drawing.Point(6, 56);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(256, 24);
            this.rbu02.TabIndex = 3;
            this.rbu02.TabStop = true;
            this.rbu02.Text = "Buscar por franja horaria llegada";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // rbu04
            // 
            this.rbu04.AutoSize = true;
            this.rbu04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu04.Location = new System.Drawing.Point(6, 79);
            this.rbu04.Name = "rbu04";
            this.rbu04.Size = new System.Drawing.Size(188, 24);
            this.rbu04.TabIndex = 2;
            this.rbu04.TabStop = true;
            this.rbu04.Text = "Buscar todos los viajes";
            this.rbu04.UseVisualStyleBackColor = true;
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbu01.Location = new System.Drawing.Point(6, 31);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(246, 24);
            this.rbu01.TabIndex = 0;
            this.rbu01.TabStop = true;
            this.rbu01.Text = "Buscar por franja horaria salida";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // rv_01
            // 
            this.rv_01.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Viajes.ReporteViajes.rdlc";
            this.rv_01.Location = new System.Drawing.Point(12, 132);
            this.rv_01.Name = "rv_01";
            this.rv_01.ServerReport.BearerToken = null;
            this.rv_01.Size = new System.Drawing.Size(725, 276);
            this.rv_01.TabIndex = 18;
            this.rv_01.ZoomPercent = 75;
            // 
            // msk_txt2
            // 
            this.msk_txt2.Location = new System.Drawing.Point(206, 76);
            this.msk_txt2.Mask = "00:00";
            this.msk_txt2.Name = "msk_txt2";
            this.msk_txt2.Pp_EsPk = false;
            this.msk_txt2.Pp_MensajeError = null;
            this.msk_txt2.Pp_NombreCampo = null;
            this.msk_txt2.Pp_NombreTabla = null;
            this.msk_txt2.Size = new System.Drawing.Size(32, 20);
            this.msk_txt2.TabIndex = 27;
            this.msk_txt2.ValidatingType = typeof(System.DateTime);
            // 
            // msk_txt1
            // 
            this.msk_txt1.Location = new System.Drawing.Point(206, 47);
            this.msk_txt1.Mask = "00:00";
            this.msk_txt1.Name = "msk_txt1";
            this.msk_txt1.Pp_EsPk = false;
            this.msk_txt1.Pp_MensajeError = null;
            this.msk_txt1.Pp_NombreCampo = null;
            this.msk_txt1.Pp_NombreTabla = null;
            this.msk_txt1.Size = new System.Drawing.Size(32, 20);
            this.msk_txt1.TabIndex = 27;
            this.msk_txt1.ValidatingType = typeof(System.DateTime);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(642, 85);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(95, 41);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Listados de viajes";
            // 
            // Frm_ListadoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_txt2);
            this.Controls.Add(this.msk_txt1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.rv_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListadoViajes";
            this.Text = "Frm_ListadoViajes";
            this.Load += new System.EventHandler(this.Frm_ListadoViajes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbu04;
        private System.Windows.Forms.RadioButton rbu01;
        private Clase.Button_Aerolinea btn_buscar;
        private Microsoft.Reporting.WinForms.ReportViewer rv_01;
        private Clase.MaskedTextBox_Aerolinea msk_txt1;
        private Clase.MaskedTextBox_Aerolinea msk_txt2;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.Label label1;
    }
}