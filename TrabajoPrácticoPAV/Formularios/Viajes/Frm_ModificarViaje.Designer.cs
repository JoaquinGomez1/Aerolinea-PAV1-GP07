
namespace TrabajoPrácticoPAV.Formularios.Viajes
{
    partial class Frm_ModificarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificarViaje));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_duracionEstimada = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_numero_viaje = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.mtb_presencia = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.mtb_salida = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.mtb_llegada = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horario de Presencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Viaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horario de Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horario de Llegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(19, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duración Estimada";
            // 
            // lbl_duracionEstimada
            // 
            this.lbl_duracionEstimada.AutoSize = true;
            this.lbl_duracionEstimada.Location = new System.Drawing.Point(159, 172);
            this.lbl_duracionEstimada.Name = "lbl_duracionEstimada";
            this.lbl_duracionEstimada.Size = new System.Drawing.Size(25, 13);
            this.lbl_duracionEstimada.TabIndex = 10;
            this.lbl_duracionEstimada.Text = "???";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_modificar.Location = new System.Drawing.Point(160, 238);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(90, 28);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(49, 238);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 28);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_numero_viaje);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.mtb_presencia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_duracionEstimada);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mtb_salida);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mtb_llegada);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 293);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Btn_Minimizar);
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 32);
            this.panel2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "MODIFICAR VIAJE";
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(282, 4);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Minimizar.TabIndex = 3;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(308, 4);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 320);
            this.panel3.TabIndex = 15;
            // 
            // cmb_numero_viaje
            // 
            this.cmb_numero_viaje.FormattingEnabled = true;
            this.cmb_numero_viaje.Location = new System.Drawing.Point(162, 43);
            this.cmb_numero_viaje.Name = "cmb_numero_viaje";
            this.cmb_numero_viaje.Pp_CampoAceptaNull = false;
            this.cmb_numero_viaje.Pp_EsPk = false;
            this.cmb_numero_viaje.Pp_MensajeError = "Seleccionar un campo";
            this.cmb_numero_viaje.Pp_NombreCampo = "numeroDeViaje";
            this.cmb_numero_viaje.Pp_NombreCampoInsert = null;
            this.cmb_numero_viaje.Pp_NombreTabla = "Viaje";
            this.cmb_numero_viaje.Pp_PkTabla = "numeroDeViaje";
            this.cmb_numero_viaje.Size = new System.Drawing.Size(88, 21);
            this.cmb_numero_viaje.TabIndex = 6;
            this.cmb_numero_viaje.SelectedIndexChanged += new System.EventHandler(this.numero_viaje_SelectedIndexChanged);
            // 
            // mtb_presencia
            // 
            this.mtb_presencia.Location = new System.Drawing.Point(162, 74);
            this.mtb_presencia.Mask = "00:00";
            this.mtb_presencia.Name = "mtb_presencia";
            this.mtb_presencia.Pp_EsPk = false;
            this.mtb_presencia.Pp_NombreCampo = null;
            this.mtb_presencia.Pp_NombreTabla = null;
            this.mtb_presencia.Size = new System.Drawing.Size(34, 20);
            this.mtb_presencia.TabIndex = 7;
            this.mtb_presencia.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_salida
            // 
            this.mtb_salida.Location = new System.Drawing.Point(162, 108);
            this.mtb_salida.Mask = "00:00";
            this.mtb_salida.Name = "mtb_salida";
            this.mtb_salida.Pp_EsPk = false;
            this.mtb_salida.Pp_NombreCampo = null;
            this.mtb_salida.Pp_NombreTabla = null;
            this.mtb_salida.Size = new System.Drawing.Size(34, 20);
            this.mtb_salida.TabIndex = 9;
            this.mtb_salida.ValidatingType = typeof(System.DateTime);
            this.mtb_salida.TextChanged += new System.EventHandler(this.mtb_salida_TextChanged);
            // 
            // mtb_llegada
            // 
            this.mtb_llegada.Location = new System.Drawing.Point(162, 134);
            this.mtb_llegada.Mask = "00:00";
            this.mtb_llegada.Name = "mtb_llegada";
            this.mtb_llegada.Pp_EsPk = false;
            this.mtb_llegada.Pp_NombreCampo = null;
            this.mtb_llegada.Pp_NombreTabla = null;
            this.mtb_llegada.Size = new System.Drawing.Size(34, 20);
            this.mtb_llegada.TabIndex = 8;
            this.mtb_llegada.ValidatingType = typeof(System.DateTime);
            this.mtb_llegada.TextChanged += new System.EventHandler(this.mtb_llegada_TextChanged);
            // 
            // Frm_ModificarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(334, 352);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ModificarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Viaje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clase.ComboBox_Aerolinea cmb_numero_viaje;
        private Clase.MaskedTextBox_Aerolinea mtb_presencia;
        private Clase.MaskedTextBox_Aerolinea mtb_llegada;
        private Clase.MaskedTextBox_Aerolinea mtb_salida;
        private System.Windows.Forms.Label lbl_duracionEstimada;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.Panel panel3;
    }
}