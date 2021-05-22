
namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMViajes
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.datagrid_viajes = new System.Windows.Forms.DataGridView();
            this.numeroDeViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioPresencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_duracionEstimada = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mtxt_presencia = new System.Windows.Forms.MaskedTextBox();
            this.Mtxt_horarioLlegada = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mtxt_horarioSalida = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_viajes)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Viaje";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_refrescar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.datagrid_viajes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 391);
            this.panel1.TabIndex = 2;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Location = new System.Drawing.Point(549, 359);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(75, 23);
            this.btn_refrescar.TabIndex = 24;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "btn_borrar_Click";
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(152, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(71, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_modificar1_Click);
            // 
            // datagrid_viajes
            // 
            this.datagrid_viajes.AllowUserToAddRows = false;
            this.datagrid_viajes.AllowUserToDeleteRows = false;
            this.datagrid_viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_viajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDeViaje,
            this.horarioPresencia,
            this.horarioSalida,
            this.horarioLlegada,
            this.duracionEstimada});
            this.datagrid_viajes.Location = new System.Drawing.Point(67, 203);
            this.datagrid_viajes.Name = "datagrid_viajes";
            this.datagrid_viajes.ReadOnly = true;
            this.datagrid_viajes.Size = new System.Drawing.Size(557, 150);
            this.datagrid_viajes.TabIndex = 21;
            // 
            // numeroDeViaje
            // 
            this.numeroDeViaje.HeaderText = "Id";
            this.numeroDeViaje.Name = "numeroDeViaje";
            this.numeroDeViaje.ReadOnly = true;
            this.numeroDeViaje.Width = 50;
            // 
            // horarioPresencia
            // 
            this.horarioPresencia.HeaderText = "H. de Presencia";
            this.horarioPresencia.Name = "horarioPresencia";
            this.horarioPresencia.ReadOnly = true;
            // 
            // horarioSalida
            // 
            this.horarioSalida.HeaderText = "H. de Salida";
            this.horarioSalida.Name = "horarioSalida";
            this.horarioSalida.ReadOnly = true;
            // 
            // horarioLlegada
            // 
            this.horarioLlegada.HeaderText = "H. de Llegada";
            this.horarioLlegada.Name = "horarioLlegada";
            this.horarioLlegada.ReadOnly = true;
            // 
            // duracionEstimada
            // 
            this.duracionEstimada.HeaderText = "Duracion Estimada";
            this.duracionEstimada.Name = "duracionEstimada";
            this.duracionEstimada.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Consultar Viajes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(433, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Duración Estimada:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_duracionEstimada);
            this.panel3.Location = new System.Drawing.Point(424, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 59);
            this.panel3.TabIndex = 19;
            // 
            // lbl_duracionEstimada
            // 
            this.lbl_duracionEstimada.AutoSize = true;
            this.lbl_duracionEstimada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_duracionEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_duracionEstimada.Location = new System.Drawing.Point(86, 25);
            this.lbl_duracionEstimada.Name = "lbl_duracionEstimada";
            this.lbl_duracionEstimada.Size = new System.Drawing.Size(34, 19);
            this.lbl_duracionEstimada.TabIndex = 9;
            this.lbl_duracionEstimada.Text = "???";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button2.Location = new System.Drawing.Point(424, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(76, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Horarios";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.Location = new System.Drawing.Point(534, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Mtxt_presencia);
            this.panel2.Controls.Add(this.Mtxt_horarioLlegada);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Mtxt_horarioSalida);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(67, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 138);
            this.panel2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(58, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Horario de Llegada";
            // 
            // Mtxt_presencia
            // 
            this.Mtxt_presencia.Location = new System.Drawing.Point(194, 17);
            this.Mtxt_presencia.Mask = "00:00";
            this.Mtxt_presencia.Name = "Mtxt_presencia";
            this.Mtxt_presencia.Size = new System.Drawing.Size(37, 20);
            this.Mtxt_presencia.TabIndex = 0;
            this.Mtxt_presencia.ValidatingType = typeof(System.DateTime);
            // 
            // Mtxt_horarioLlegada
            // 
            this.Mtxt_horarioLlegada.Location = new System.Drawing.Point(194, 100);
            this.Mtxt_horarioLlegada.Mask = "00:00";
            this.Mtxt_horarioLlegada.Name = "Mtxt_horarioLlegada";
            this.Mtxt_horarioLlegada.Size = new System.Drawing.Size(37, 20);
            this.Mtxt_horarioLlegada.TabIndex = 2;
            this.Mtxt_horarioLlegada.ValidatingType = typeof(System.DateTime);
            this.Mtxt_horarioLlegada.TextChanged += new System.EventHandler(this.maskedTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Mtxt_horarioSalida
            // 
            this.Mtxt_horarioSalida.Location = new System.Drawing.Point(194, 60);
            this.Mtxt_horarioSalida.Mask = "00:00";
            this.Mtxt_horarioSalida.Name = "Mtxt_horarioSalida";
            this.Mtxt_horarioSalida.Size = new System.Drawing.Size(37, 20);
            this.Mtxt_horarioSalida.TabIndex = 1;
            this.Mtxt_horarioSalida.ValidatingType = typeof(System.DateTime);
            this.Mtxt_horarioSalida.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(70, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horario de Salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(46, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horario de Presencia";
            // 
            // Frm_ABMViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(754, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Frm_ABMViajes";
            this.Text = "Cargar Viaje";
            this.Load += new System.EventHandler(this.Frm_ABMViajes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_viajes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Mtxt_horarioLlegada;
        private System.Windows.Forms.MaskedTextBox Mtxt_horarioSalida;
        private System.Windows.Forms.Label lbl_duracionEstimada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox Mtxt_presencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagrid_viajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioPresencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionEstimada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_refrescar;
    }
}