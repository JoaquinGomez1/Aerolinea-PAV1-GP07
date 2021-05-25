
namespace TrabajoPrácticoPAV.Formularios.Reservas
{
    partial class Frm_ConsultarPasajerosPorReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultarPasajerosPorReserva));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_aceptar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.dataGridView_Aerolinea1 = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Aerolinea1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Btn_Minimizar);
            this.BarraSuperior.Controls.Add(this.Btn_Cerrar);
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(427, 32);
            this.BarraSuperior.TabIndex = 108;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(368, 4);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Minimizar.TabIndex = 6;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(394, 4);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 5;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(9, 6);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(213, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "CONSULTAR PASAJEROS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Controls.Add(this.dataGridView_Aerolinea1);
            this.panel1.Controls.Add(this.comboBox_Aerolinea1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 374);
            this.panel1.TabIndex = 109;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_aceptar.Location = new System.Drawing.Point(311, 336);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Pp_Presionado = false;
            this.btn_aceptar.Size = new System.Drawing.Size(90, 28);
            this.btn_aceptar.TabIndex = 125;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // dataGridView_Aerolinea1
            // 
            this.dataGridView_Aerolinea1.AllowUserToAddRows = false;
            this.dataGridView_Aerolinea1.AllowUserToDeleteRows = false;
            this.dataGridView_Aerolinea1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Aerolinea1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.tipoDoc,
            this.numeroDoc});
            this.dataGridView_Aerolinea1.Location = new System.Drawing.Point(14, 180);
            this.dataGridView_Aerolinea1.Name = "dataGridView_Aerolinea1";
            this.dataGridView_Aerolinea1.Pp_FormatoGrid = null;
            this.dataGridView_Aerolinea1.Pp_NombreTabla = null;
            this.dataGridView_Aerolinea1.ReadOnly = true;
            this.dataGridView_Aerolinea1.Size = new System.Drawing.Size(387, 150);
            this.dataGridView_Aerolinea1.TabIndex = 116;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            // 
            // numeroDoc
            // 
            this.numeroDoc.HeaderText = "Documento";
            this.numeroDoc.Name = "numeroDoc";
            this.numeroDoc.ReadOnly = true;
            // 
            // comboBox_Aerolinea1
            // 
            this.comboBox_Aerolinea1.FormattingEnabled = true;
            this.comboBox_Aerolinea1.Location = new System.Drawing.Point(160, 25);
            this.comboBox_Aerolinea1.Name = "comboBox_Aerolinea1";
            this.comboBox_Aerolinea1.Pp_CampoAceptaNull = false;
            this.comboBox_Aerolinea1.Pp_EsPk = true;
            this.comboBox_Aerolinea1.Pp_MensajeError = "Cargar numero de Reserva";
            this.comboBox_Aerolinea1.Pp_NombreCampo = "numeroDeReserva";
            this.comboBox_Aerolinea1.Pp_NombreCampoInsert = null;
            this.comboBox_Aerolinea1.Pp_NombreTabla = "Reserva";
            this.comboBox_Aerolinea1.Pp_PkTabla = "numeroDeReserva";
            this.comboBox_Aerolinea1.Size = new System.Drawing.Size(63, 21);
            this.comboBox_Aerolinea1.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 114;
            this.label1.Text = "Numero Reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(174, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 34);
            this.label7.TabIndex = 113;
            this.label7.Text = "???";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(130, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 34);
            this.label6.TabIndex = 112;
            this.label6.Text = "???";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(132, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 34);
            this.label5.TabIndex = 111;
            this.label5.Text = "???";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 34);
            this.label4.TabIndex = 110;
            this.label4.Text = "Documento del Titular";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(11, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 34);
            this.label3.TabIndex = 109;
            this.label3.Text = "Cantidad de Pasajeros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 108;
            this.label2.Text = "Pasajero Titular";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_ConsultarPasajerosPorReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ConsultarPasajerosPorReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_ConsultarPasajerosPorReserva";
            this.Load += new System.EventHandler(this.Frm_ConsultarPasajerosPorReserva_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Aerolinea1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clase.DataGridView_Aerolinea dataGridView_Aerolinea1;
        private Clase.ComboBox_Aerolinea comboBox_Aerolinea1;
        private System.Windows.Forms.Label label1;
        private Clase.Button_Aerolinea btn_aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDoc;
    }
}