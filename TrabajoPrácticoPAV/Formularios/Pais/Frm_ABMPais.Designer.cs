namespace TrabajoPrácticoPAV.Formularios.Pais
{
    partial class Frm_ABMPais
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.chb_todos_tramo = new System.Windows.Forms.CheckBox();
            this.grid_paises = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.txt_Nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_IdPais = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.grid_paises)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id país";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(186, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Consultar Países";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Cerrar.Location = new System.Drawing.Point(132, 273);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(76, 29);
            this.Btn_Cerrar.TabIndex = 34;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Limpiar.Location = new System.Drawing.Point(51, 273);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(76, 29);
            this.Btn_Limpiar.TabIndex = 33;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Eliminar.Location = new System.Drawing.Point(619, 227);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(82, 33);
            this.Btn_Eliminar.TabIndex = 32;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Modificar.Location = new System.Drawing.Point(619, 183);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(82, 33);
            this.Btn_Modificar.TabIndex = 31;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Registrar.FlatAppearance.BorderSize = 0;
            this.Btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Registrar.Location = new System.Drawing.Point(619, 138);
            this.Btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(82, 33);
            this.Btn_Registrar.TabIndex = 30;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(619, 95);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(82, 33);
            this.btn_buscar.TabIndex = 28;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // chb_todos_tramo
            // 
            this.chb_todos_tramo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chb_todos_tramo.AutoSize = true;
            this.chb_todos_tramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chb_todos_tramo.Location = new System.Drawing.Point(528, 48);
            this.chb_todos_tramo.Margin = new System.Windows.Forms.Padding(2);
            this.chb_todos_tramo.Name = "chb_todos_tramo";
            this.chb_todos_tramo.Size = new System.Drawing.Size(72, 24);
            this.chb_todos_tramo.TabIndex = 29;
            this.chb_todos_tramo.Text = "Todos";
            this.chb_todos_tramo.UseVisualStyleBackColor = true;
            // 
            // grid_paises
            // 
            this.grid_paises.AllowUserToAddRows = false;
            this.grid_paises.AllowUserToDeleteRows = false;
            this.grid_paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_paises.Location = new System.Drawing.Point(51, 95);
            this.grid_paises.Name = "grid_paises";
            this.grid_paises.Pp_FormatoGrid = "idPais, Id País, 200;nombrePais, País, 300";
            this.grid_paises.Pp_NombreTabla = "Pais";
            this.grid_paises.ReadOnly = true;
            this.grid_paises.Size = new System.Drawing.Size(549, 165);
            this.grid_paises.TabIndex = 3;
            this.grid_paises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_paises_CellContentClick);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Nombre.Location = new System.Drawing.Point(256, 46);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_EsPk = false;
            this.txt_Nombre.Pp_MensajeError = null;
            this.txt_Nombre.Pp_NombreCampo = "nombrePais";
            this.txt_Nombre.Pp_NombreTabla = "Pais";
            this.txt_Nombre.Size = new System.Drawing.Size(136, 26);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_IdPais
            // 
            this.txt_IdPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_IdPais.Location = new System.Drawing.Point(114, 46);
            this.txt_IdPais.Mask = "999";
            this.txt_IdPais.Name = "txt_IdPais";
            this.txt_IdPais.Pp_EsPk = true;
            this.txt_IdPais.Pp_MensajeError = null;
            this.txt_IdPais.Pp_NombreCampo = "idPais";
            this.txt_IdPais.Pp_NombreTabla = "Pais";
            this.txt_IdPais.Size = new System.Drawing.Size(37, 26);
            this.txt_IdPais.TabIndex = 0;
            // 
            // Frm_ABMPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.chb_todos_tramo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_paises);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_IdPais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMPais";
            this.Text = "Frm_ABMPais";
            this.Load += new System.EventHandler(this.Frm_ABMPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_paises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.MaskedTextBox_Aerolinea txt_IdPais;
        private Clase.TextBox_Aerolinea txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.DataGridView_Aerolinea grid_paises;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox chb_todos_tramo;
    }
}