namespace TrabajoPrácticoPAV.Formularios.Estadisticas.TripulacionXcargo
{
    partial class Frm_TripulacionXcargo
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
            this.Rbu_tripulacion = new System.Windows.Forms.RadioButton();
            this.Rbu_porLetra = new System.Windows.Forms.RadioButton();
            this.Rbutodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_letra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombreT = new System.Windows.Forms.TextBox();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(708, 230);
            this.reportViewer1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbu_tripulacion);
            this.groupBox1.Controls.Add(this.Rbu_porLetra);
            this.groupBox1.Controls.Add(this.Rbutodos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(409, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // Rbu_tripulacion
            // 
            this.Rbu_tripulacion.AutoSize = true;
            this.Rbu_tripulacion.Location = new System.Drawing.Point(18, 55);
            this.Rbu_tripulacion.Name = "Rbu_tripulacion";
            this.Rbu_tripulacion.Size = new System.Drawing.Size(191, 24);
            this.Rbu_tripulacion.TabIndex = 2;
            this.Rbu_tripulacion.TabStop = true;
            this.Rbu_tripulacion.Text = "Tripulacion con nombre";
            this.Rbu_tripulacion.UseVisualStyleBackColor = true;
            // 
            // Rbu_porLetra
            // 
            this.Rbu_porLetra.AutoSize = true;
            this.Rbu_porLetra.Location = new System.Drawing.Point(18, 29);
            this.Rbu_porLetra.Name = "Rbu_porLetra";
            this.Rbu_porLetra.Size = new System.Drawing.Size(212, 24);
            this.Rbu_porLetra.TabIndex = 1;
            this.Rbu_porLetra.TabStop = true;
            this.Rbu_porLetra.Text = "Cargos que empiecen con";
            this.Rbu_porLetra.UseVisualStyleBackColor = true;
            // 
            // Rbutodos
            // 
            this.Rbutodos.AutoSize = true;
            this.Rbutodos.Location = new System.Drawing.Point(18, 81);
            this.Rbutodos.Name = "Rbutodos";
            this.Rbutodos.Size = new System.Drawing.Size(71, 24);
            this.Rbutodos.TabIndex = 0;
            this.Rbutodos.TabStop = true;
            this.Rbutodos.Text = "Todos";
            this.Rbutodos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cargo que empiece con";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estadistica de porcetnaje de Tripulacion por Cargo";
            // 
            // txt_letra
            // 
            this.txt_letra.Location = new System.Drawing.Point(232, 45);
            this.txt_letra.Name = "txt_letra";
            this.txt_letra.Size = new System.Drawing.Size(117, 20);
            this.txt_letra.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(38, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tripulacion con nombres";
            // 
            // txt_nombreT
            // 
            this.txt_nombreT.Location = new System.Drawing.Point(232, 79);
            this.txt_nombreT.Name = "txt_nombreT";
            this.txt_nombreT.Size = new System.Drawing.Size(117, 20);
            this.txt_nombreT.TabIndex = 12;
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(645, 79);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(75, 33);
            this.button_Aerolinea1.TabIndex = 8;
            this.button_Aerolinea1.Text = "Buscar";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // Frm_TripulacionXcargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 385);
            this.Controls.Add(this.txt_nombreT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_letra);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_TripulacionXcargo";
            this.Text = "Frm_TripulacionXcargo";
            this.Load += new System.EventHandler(this.Frm_TripulacionXcargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbutodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rbu_tripulacion;
        private System.Windows.Forms.RadioButton Rbu_porLetra;
        private System.Windows.Forms.TextBox txt_letra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombreT;
    }
}