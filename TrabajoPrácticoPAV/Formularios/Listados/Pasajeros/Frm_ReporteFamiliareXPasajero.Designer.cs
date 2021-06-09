namespace TrabajoPrácticoPAV.Formularios.Listados.Pasajeros
{
    partial class Frm_ReporteFamiliareXPasajero
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu04 = new System.Windows.Forms.RadioButton();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Msktxt_NumDocFamiliar = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.Msktxt_NumDocTitular = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.txt_parentesco = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_consultar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Pasajeros.Frm_ReporteFamiliareXPasajero.r" +
    "dlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 157);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 281);
            this.reportViewer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(89, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Parentesco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Documento familiar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Documento Titular";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu04);
            this.groupBox1.Controls.Add(this.rbu01);
            this.groupBox1.Controls.Add(this.rbu03);
            this.groupBox1.Controls.Add(this.rbu02);
            this.groupBox1.Location = new System.Drawing.Point(410, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Cálculo";
            // 
            // rbu04
            // 
            this.rbu04.AutoSize = true;
            this.rbu04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu04.Location = new System.Drawing.Point(17, 83);
            this.rbu04.Name = "rbu04";
            this.rbu04.Size = new System.Drawing.Size(66, 21);
            this.rbu04.TabIndex = 3;
            this.rbu04.Text = "Todos";
            this.rbu04.UseVisualStyleBackColor = true;
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu01.Location = new System.Drawing.Point(17, 19);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(184, 21);
            this.rbu01.TabIndex = 0;
            this.rbu01.Text = "Por documento del titular";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu03.Location = new System.Drawing.Point(17, 62);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(123, 21);
            this.rbu03.TabIndex = 1;
            this.rbu03.Text = "Por parentesco";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu02.Location = new System.Drawing.Point(17, 43);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(194, 21);
            this.rbu02.TabIndex = 2;
            this.rbu02.Text = "Por documento del familiar";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Reporte de Familiares por pasajero";
            // 
            // Msktxt_NumDocFamiliar
            // 
            this.Msktxt_NumDocFamiliar.Location = new System.Drawing.Point(186, 72);
            this.Msktxt_NumDocFamiliar.Mask = "99999999";
            this.Msktxt_NumDocFamiliar.Name = "Msktxt_NumDocFamiliar";
            this.Msktxt_NumDocFamiliar.Pp_EsPk = false;
            this.Msktxt_NumDocFamiliar.Pp_MensajeError = null;
            this.Msktxt_NumDocFamiliar.Pp_NombreCampo = null;
            this.Msktxt_NumDocFamiliar.Pp_NombreTabla = null;
            this.Msktxt_NumDocFamiliar.Size = new System.Drawing.Size(56, 20);
            this.Msktxt_NumDocFamiliar.TabIndex = 20;
            // 
            // Msktxt_NumDocTitular
            // 
            this.Msktxt_NumDocTitular.Location = new System.Drawing.Point(186, 47);
            this.Msktxt_NumDocTitular.Mask = "99999999";
            this.Msktxt_NumDocTitular.Name = "Msktxt_NumDocTitular";
            this.Msktxt_NumDocTitular.Pp_EsPk = false;
            this.Msktxt_NumDocTitular.Pp_MensajeError = null;
            this.Msktxt_NumDocTitular.Pp_NombreCampo = null;
            this.Msktxt_NumDocTitular.Pp_NombreTabla = null;
            this.Msktxt_NumDocTitular.Size = new System.Drawing.Size(56, 20);
            this.Msktxt_NumDocTitular.TabIndex = 19;
            // 
            // txt_parentesco
            // 
            this.txt_parentesco.Location = new System.Drawing.Point(186, 96);
            this.txt_parentesco.Name = "txt_parentesco";
            this.txt_parentesco.Pp_EsPk = false;
            this.txt_parentesco.Pp_MensajeError = null;
            this.txt_parentesco.Pp_NombreCampo = "pais";
            this.txt_parentesco.Pp_NombreTabla = "aeropuerto";
            this.txt_parentesco.Size = new System.Drawing.Size(100, 20);
            this.txt_parentesco.TabIndex = 16;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(678, 104);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Pp_Presionado = false;
            this.btn_consultar.Size = new System.Drawing.Size(75, 33);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Calcular";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Frm_ReporteFamiliareXPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Msktxt_NumDocFamiliar);
            this.Controls.Add(this.Msktxt_NumDocTitular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_parentesco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReporteFamiliareXPasajero";
            this.Text = "Frm_ReporteFamiliareXPasajero";
            this.Load += new System.EventHandler(this.Frm_ReporteFamiliareXPasajero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.Button_Aerolinea btn_consultar;
        private Clase.TextBox_Aerolinea txt_parentesco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu04;
        private System.Windows.Forms.RadioButton rbu01;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.Label label4;
        private Clase.MaskedTextBox_Aerolinea Msktxt_NumDocTitular;
        private Clase.MaskedTextBox_Aerolinea Msktxt_NumDocFamiliar;
    }
}