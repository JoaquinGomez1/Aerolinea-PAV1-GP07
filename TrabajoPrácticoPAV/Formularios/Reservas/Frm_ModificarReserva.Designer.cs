
namespace TrabajoPrácticoPAV.Formularios.Reservas
{
    partial class Frm_ModificarReserva
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
            this.textBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_claseAsiento = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.maskedTextBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Aerolinea2
            // 
            this.textBox_Aerolinea2.Location = new System.Drawing.Point(145, 166);
            this.textBox_Aerolinea2.Name = "textBox_Aerolinea2";
            this.textBox_Aerolinea2.Pp_EsPk = false;
            this.textBox_Aerolinea2.Pp_MensajeError = null;
            this.textBox_Aerolinea2.Pp_NombreCampo = null;
            this.textBox_Aerolinea2.Pp_NombreTabla = null;
            this.textBox_Aerolinea2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Aerolinea2.TabIndex = 97;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(144, 130);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = null;
            this.textBox_Aerolinea1.Pp_NombreCampo = null;
            this.textBox_Aerolinea1.Pp_NombreTabla = null;
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Aerolinea1.TabIndex = 96;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(33, 166);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 95;
            this.label13.Text = "Destino del viaje";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.Location = new System.Drawing.Point(33, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 94;
            this.label12.Text = "Origen del viaje";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.Location = new System.Drawing.Point(39, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 93;
            this.label9.Text = "Clase de asiento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_claseAsiento
            // 
            this.cmb_claseAsiento.FormattingEnabled = true;
            this.cmb_claseAsiento.Location = new System.Drawing.Point(144, 94);
            this.cmb_claseAsiento.Name = "cmb_claseAsiento";
            this.cmb_claseAsiento.Pp_CampoAceptaNull = false;
            this.cmb_claseAsiento.Pp_EsPk = false;
            this.cmb_claseAsiento.Pp_MensajeError = "Cargar clase de asiento";
            this.cmb_claseAsiento.Pp_NombreCampo = "nombre";
            this.cmb_claseAsiento.Pp_NombreCampoInsert = null;
            this.cmb_claseAsiento.Pp_NombreTabla = "Tipo_Asiento";
            this.cmb_claseAsiento.Pp_PkTabla = "idTipo";
            this.cmb_claseAsiento.Size = new System.Drawing.Size(101, 21);
            this.cmb_claseAsiento.TabIndex = 92;
            // 
            // maskedTextBox_Aerolinea2
            // 
            this.maskedTextBox_Aerolinea2.Location = new System.Drawing.Point(144, 63);
            this.maskedTextBox_Aerolinea2.Mask = "00/00/0000";
            this.maskedTextBox_Aerolinea2.Name = "maskedTextBox_Aerolinea2";
            this.maskedTextBox_Aerolinea2.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea2.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea2.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBox_Aerolinea2.TabIndex = 91;
            this.maskedTextBox_Aerolinea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Aerolinea2.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.Location = new System.Drawing.Point(33, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 90;
            this.label11.Text = "Asignar fecha viaje";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Modificar Reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox_Aerolinea1
            // 
            this.maskedTextBox_Aerolinea1.Location = new System.Drawing.Point(145, 237);
            this.maskedTextBox_Aerolinea1.Mask = "00000000";
            this.maskedTextBox_Aerolinea1.Name = "maskedTextBox_Aerolinea1";
            this.maskedTextBox_Aerolinea1.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea1.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea1.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox_Aerolinea1.TabIndex = 101;
            this.maskedTextBox_Aerolinea1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Numero Documento";
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(145, 267);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Pp_CampoAceptaNull = false;
            this.cmb_tipoDoc.Pp_EsPk = false;
            this.cmb_tipoDoc.Pp_MensajeError = "Cargar tipo doc";
            this.cmb_tipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.cmb_tipoDoc.Pp_NombreCampoInsert = null;
            this.cmb_tipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.cmb_tipoDoc.Pp_PkTabla = "tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(60, 21);
            this.cmb_tipoDoc.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 105;
            this.label4.Text = "Datos de pasajero";
            // 
            // Frm_ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipoDoc);
            this.Controls.Add(this.maskedTextBox_Aerolinea1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Aerolinea2);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_claseAsiento);
            this.Controls.Add(this.maskedTextBox_Aerolinea2);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ModificarReserva";
            this.Text = "Frm_ModificarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.TextBox_Aerolinea textBox_Aerolinea2;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private Clase.ComboBox_Aerolinea cmb_claseAsiento;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea1;
        private System.Windows.Forms.Label label3;
        private Clase.ComboBox_Aerolinea cmb_tipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}