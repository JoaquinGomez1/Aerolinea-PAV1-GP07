
namespace TrabajoPrácticoPAV.Formularios.Tripulacion_x_vuelo
{
    partial class Frm_Eliminar_TripulacionxVuelo
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(80, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "ID vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(80, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID tripulación";
            // 
            // txt_idTripulacion
            // 
            this.txt_idTripulacion.Enabled = false;
            this.txt_idTripulacion.Location = new System.Drawing.Point(225, 98);
            this.txt_idTripulacion.Name = "txt_idTripulacion";
            this.txt_idTripulacion.Pp_EsPk = false;
            this.txt_idTripulacion.Pp_MensajeError = null;
            this.txt_idTripulacion.Pp_NombreCampo = null;
            this.txt_idTripulacion.Pp_NombreTabla = null;
            this.txt_idTripulacion.Size = new System.Drawing.Size(100, 20);
            this.txt_idTripulacion.TabIndex = 55;
            // 
            // txt_idVuelo
            // 
            this.txt_idVuelo.Enabled = false;
            this.txt_idVuelo.Location = new System.Drawing.Point(225, 124);
            this.txt_idVuelo.Name = "txt_idVuelo";
            this.txt_idVuelo.Pp_EsPk = false;
            this.txt_idVuelo.Pp_MensajeError = null;
            this.txt_idVuelo.Pp_NombreCampo = null;
            this.txt_idVuelo.Pp_NombreTabla = null;
            this.txt_idVuelo.Size = new System.Drawing.Size(100, 20);
            this.txt_idVuelo.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(87, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Eliminar tripulación por vuelo";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(235, 176);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 28);
            this.btn_cancelar.TabIndex = 53;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(84, 176);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 52;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Frm_Eliminar_TripulacionxVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(410, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idTripulacion);
            this.Controls.Add(this.txt_idVuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Eliminar_TripulacionxVuelo";
            this.Text = "Frm_Modificar_TripulacionxVuelo";
            this.Load += new System.EventHandler(this.Frm_Modificar_TripulacionxVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_idTripulacion;
        private Clase.TextBox_Aerolinea txt_idVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}