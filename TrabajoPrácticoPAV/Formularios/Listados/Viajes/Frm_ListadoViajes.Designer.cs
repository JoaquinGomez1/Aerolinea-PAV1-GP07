
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu04 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.rv_01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mtxt_hora2 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.mtxt_hora1 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.cmb_destino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "y el";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Entre el";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Destino";
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
            this.groupBox2.Controls.Add(this.rbu03);
            this.groupBox2.Controls.Add(this.rbu04);
            this.groupBox2.Controls.Add(this.rbu02);
            this.groupBox2.Controls.Add(this.rbu01);
            this.groupBox2.Location = new System.Drawing.Point(528, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 114);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Busqueda";
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Location = new System.Drawing.Point(6, 65);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(151, 17);
            this.rbu03.TabIndex = 3;
            this.rbu03.TabStop = true;
            this.rbu03.Text = "Buscar por fecha y destino";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu04
            // 
            this.rbu04.AutoSize = true;
            this.rbu04.Location = new System.Drawing.Point(6, 88);
            this.rbu04.Name = "rbu04";
            this.rbu04.Size = new System.Drawing.Size(133, 17);
            this.rbu04.TabIndex = 2;
            this.rbu04.TabStop = true;
            this.rbu04.Text = "Buscar todos los viajes";
            this.rbu04.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Location = new System.Drawing.Point(6, 42);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(113, 17);
            this.rbu02.TabIndex = 1;
            this.rbu02.TabStop = true;
            this.rbu02.Text = "Buscar por destino";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Location = new System.Drawing.Point(6, 19);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(106, 17);
            this.rbu01.TabIndex = 0;
            this.rbu01.TabStop = true;
            this.rbu01.Text = "Buscar por fecha";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // rv_01
            // 
            this.rv_01.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Viajes.ReporteViajes.rdlc";
            this.rv_01.Location = new System.Drawing.Point(83, 166);
            this.rv_01.Name = "rv_01";
            this.rv_01.ServerReport.BearerToken = null;
            this.rv_01.Size = new System.Drawing.Size(639, 321);
            this.rv_01.TabIndex = 18;
            this.rv_01.Load += new System.EventHandler(this.rv_01_Load);
            // 
            // mtxt_hora2
            // 
            this.mtxt_hora2.Location = new System.Drawing.Point(309, 31);
            this.mtxt_hora2.Name = "mtxt_hora2";
            this.mtxt_hora2.Pp_EsPk = false;
            this.mtxt_hora2.Pp_MensajeError = null;
            this.mtxt_hora2.Pp_NombreCampo = null;
            this.mtxt_hora2.Pp_NombreTabla = null;
            this.mtxt_hora2.Size = new System.Drawing.Size(64, 20);
            this.mtxt_hora2.TabIndex = 27;
            // 
            // mtxt_hora1
            // 
            this.mtxt_hora1.Location = new System.Drawing.Point(173, 31);
            this.mtxt_hora1.Name = "mtxt_hora1";
            this.mtxt_hora1.Pp_EsPk = false;
            this.mtxt_hora1.Pp_MensajeError = null;
            this.mtxt_hora1.Pp_NombreCampo = null;
            this.mtxt_hora1.Pp_NombreTabla = null;
            this.mtxt_hora1.Size = new System.Drawing.Size(68, 20);
            this.mtxt_hora1.TabIndex = 22;
            // 
            // cmb_destino
            // 
            this.cmb_destino.FormattingEnabled = true;
            this.cmb_destino.Location = new System.Drawing.Point(173, 64);
            this.cmb_destino.Name = "cmb_destino";
            this.cmb_destino.Pp_CampoAceptaNull = false;
            this.cmb_destino.Pp_EsPk = false;
            this.cmb_destino.Pp_MensajeError = null;
            this.cmb_destino.Pp_NombreCampo = null;
            this.cmb_destino.Pp_NombreCampoInsert = null;
            this.cmb_destino.Pp_NombreTabla = null;
            this.cmb_destino.Pp_PkTabla = null;
            this.cmb_destino.Size = new System.Drawing.Size(247, 21);
            this.cmb_destino.TabIndex = 21;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(647, 137);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // Frm_ListadoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 499);
            this.Controls.Add(this.mtxt_hora2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxt_hora1);
            this.Controls.Add(this.cmb_destino);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.rv_01);
            this.Name = "Frm_ListadoViajes";
            this.Text = "Frm_ListadoViajes";
            this.Load += new System.EventHandler(this.Frm_ListadoViajes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.MaskedTextBox_Aerolinea mtxt_hora2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clase.MaskedTextBox_Aerolinea mtxt_hora1;
        private Clase.ComboBox_Aerolinea cmb_destino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu04;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.RadioButton rbu01;
        private Clase.Button_Aerolinea btn_buscar;
        private Microsoft.Reporting.WinForms.ReportViewer rv_01;
    }
}