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
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbutodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 304);
            this.reportViewer1.TabIndex = 9;
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(702, 89);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(75, 23);
            this.button_Aerolinea1.TabIndex = 8;
            this.button_Aerolinea1.Text = "Buscar";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbutodos);
            this.groupBox1.Location = new System.Drawing.Point(367, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // Rbutodos
            // 
            this.Rbutodos.AutoSize = true;
            this.Rbutodos.Location = new System.Drawing.Point(19, 30);
            this.Rbutodos.Name = "Rbutodos";
            this.Rbutodos.Size = new System.Drawing.Size(55, 17);
            this.Rbutodos.TabIndex = 0;
            this.Rbutodos.TabStop = true;
            this.Rbutodos.Text = "Todos";
            this.Rbutodos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estadistica de Aeropuertos Por País";
            // 
            // Frm_TripulacionXcargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}