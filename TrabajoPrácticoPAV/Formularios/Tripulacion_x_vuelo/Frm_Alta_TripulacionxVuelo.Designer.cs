
namespace TrabajoPrácticoPAV.Formularios.Tripulacion_x_vuelo
{
    partial class Frm_Alta_TripulacionxVuelo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idTripulacion = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_idVuelo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(72, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "ID vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(72, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID tripulación";
            // 
            // txt_idTripulacion
            // 
            this.txt_idTripulacion.Location = new System.Drawing.Point(217, 99);
            this.txt_idTripulacion.Name = "txt_idTripulacion";
            this.txt_idTripulacion.Pp_EsPk = false;
            this.txt_idTripulacion.Pp_MensajeError = null;
            this.txt_idTripulacion.Pp_NombreCampo = null;
            this.txt_idTripulacion.Pp_NombreTabla = null;
            this.txt_idTripulacion.Size = new System.Drawing.Size(100, 20);
            this.txt_idTripulacion.TabIndex = 46;
            // 
            // txt_idVuelo
            // 
            this.txt_idVuelo.Location = new System.Drawing.Point(217, 125);
            this.txt_idVuelo.Name = "txt_idVuelo";
            this.txt_idVuelo.Pp_EsPk = false;
            this.txt_idVuelo.Pp_MensajeError = null;
            this.txt_idVuelo.Pp_NombreCampo = null;
            this.txt_idVuelo.Pp_NombreTabla = null;
            this.txt_idVuelo.Size = new System.Drawing.Size(100, 20);
            this.txt_idVuelo.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Registrar tripulación por vuelo";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.Location = new System.Drawing.Point(227, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(76, 177);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(90, 28);
            this.btn_registrar.TabIndex = 43;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // Frm_Alta_TripulacionxVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(415, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idTripulacion);
            this.Controls.Add(this.txt_idVuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Alta_TripulacionxVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Alta_TripulacionxVuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_idTripulacion;
        private Clase.TextBox_Aerolinea txt_idVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_registrar;
    }
}