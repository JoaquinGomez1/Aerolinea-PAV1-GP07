namespace TrabajoPrácticoPAV
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Btn_ABM_Tripulacion = new System.Windows.Forms.Button();
            this.Btn_Configuracion = new System.Windows.Forms.Button();
            this.Btn_ABM_Avion = new System.Windows.Forms.Button();
            this.Btn_ABM_Tramo = new System.Windows.Forms.Button();
            this.Btn_ABM_Vuelo = new System.Windows.Forms.Button();
            this.Btn_ABM_Viaje = new System.Windows.Forms.Button();
            this.Btn_ABMClientes = new System.Windows.Forms.Button();
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "AEROLÍNEA AEROLIMPO";
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(848, 4);
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(874, 4);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.PanelMenu.Controls.Add(this.Btn_ABM_Tripulacion);
            this.PanelMenu.Controls.Add(this.Btn_Configuracion);
            this.PanelMenu.Controls.Add(this.Btn_ABM_Avion);
            this.PanelMenu.Controls.Add(this.Btn_ABM_Tramo);
            this.PanelMenu.Controls.Add(this.Btn_ABM_Vuelo);
            this.PanelMenu.Controls.Add(this.Btn_ABM_Viaje);
            this.PanelMenu.Controls.Add(this.Btn_ABMClientes);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.PanelMenu.Location = new System.Drawing.Point(0, 32);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.MaximumSize = new System.Drawing.Size(150, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(150, 417);
            this.PanelMenu.TabIndex = 1;
            // 
            // Btn_ABM_Tripulacion
            // 
            this.Btn_ABM_Tripulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Tripulacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ABM_Tripulacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Tripulacion.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Tripulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Tripulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_ABM_Tripulacion.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Tripulacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ABM_Tripulacion.Image")));
            this.Btn_ABM_Tripulacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Tripulacion.Location = new System.Drawing.Point(2, 239);
            this.Btn_ABM_Tripulacion.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Tripulacion.Name = "Btn_ABM_Tripulacion";
            this.Btn_ABM_Tripulacion.Size = new System.Drawing.Size(146, 44);
            this.Btn_ABM_Tripulacion.TabIndex = 5;
            this.Btn_ABM_Tripulacion.Text = "   Tripulación";
            this.Btn_ABM_Tripulacion.UseVisualStyleBackColor = false;
            this.Btn_ABM_Tripulacion.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Tripulacion.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            // 
            // Btn_Configuracion
            // 
            this.Btn_Configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Configuracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Configuracion.FlatAppearance.BorderSize = 2;
            this.Btn_Configuracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.Btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Configuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Configuracion.ForeColor = System.Drawing.Color.White;
            this.Btn_Configuracion.Image = global::TrabajoPrácticoPAV.Properties.Resources.gear_wheel_304395_960_720__1___1_;
            this.Btn_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Configuracion.Location = new System.Drawing.Point(0, 370);
            this.Btn_Configuracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 244);
            this.Btn_Configuracion.Name = "Btn_Configuracion";
            this.Btn_Configuracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Configuracion.Size = new System.Drawing.Size(154, 30);
            this.Btn_Configuracion.TabIndex = 7;
            this.Btn_Configuracion.Text = "Configuración";
            this.Btn_Configuracion.UseVisualStyleBackColor = false;
            // 
            // Btn_ABM_Avion
            // 
            this.Btn_ABM_Avion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Avion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ABM_Avion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Avion.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Avion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Avion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_ABM_Avion.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Avion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ABM_Avion.Image")));
            this.Btn_ABM_Avion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Avion.Location = new System.Drawing.Point(2, 190);
            this.Btn_ABM_Avion.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Avion.Name = "Btn_ABM_Avion";
            this.Btn_ABM_Avion.Size = new System.Drawing.Size(146, 45);
            this.Btn_ABM_Avion.TabIndex = 6;
            this.Btn_ABM_Avion.Text = "Aviones";
            this.Btn_ABM_Avion.UseVisualStyleBackColor = false;
            this.Btn_ABM_Avion.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Avion.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            // 
            // Btn_ABM_Tramo
            // 
            this.Btn_ABM_Tramo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Tramo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ABM_Tramo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Tramo.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Tramo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Tramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_ABM_Tramo.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Tramo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ABM_Tramo.Image")));
            this.Btn_ABM_Tramo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Tramo.Location = new System.Drawing.Point(2, 142);
            this.Btn_ABM_Tramo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Tramo.Name = "Btn_ABM_Tramo";
            this.Btn_ABM_Tramo.Size = new System.Drawing.Size(146, 44);
            this.Btn_ABM_Tramo.TabIndex = 4;
            this.Btn_ABM_Tramo.Text = "Tramos";
            this.Btn_ABM_Tramo.UseVisualStyleBackColor = false;
            this.Btn_ABM_Tramo.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Tramo.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            // 
            // Btn_ABM_Vuelo
            // 
            this.Btn_ABM_Vuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Vuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ABM_Vuelo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Vuelo.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Vuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Vuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_ABM_Vuelo.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Vuelo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ABM_Vuelo.Image")));
            this.Btn_ABM_Vuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Vuelo.Location = new System.Drawing.Point(2, 94);
            this.Btn_ABM_Vuelo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Vuelo.Name = "Btn_ABM_Vuelo";
            this.Btn_ABM_Vuelo.Size = new System.Drawing.Size(146, 44);
            this.Btn_ABM_Vuelo.TabIndex = 3;
            this.Btn_ABM_Vuelo.Text = "Vuelos";
            this.Btn_ABM_Vuelo.UseVisualStyleBackColor = false;
            this.Btn_ABM_Vuelo.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Vuelo.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            // 
            // Btn_ABM_Viaje
            // 
            this.Btn_ABM_Viaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Viaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ABM_Viaje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Viaje.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Viaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Viaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_ABM_Viaje.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Viaje.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ABM_Viaje.Image")));
            this.Btn_ABM_Viaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Viaje.Location = new System.Drawing.Point(2, 47);
            this.Btn_ABM_Viaje.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Viaje.Name = "Btn_ABM_Viaje";
            this.Btn_ABM_Viaje.Size = new System.Drawing.Size(146, 43);
            this.Btn_ABM_Viaje.TabIndex = 2;
            this.Btn_ABM_Viaje.Text = "Viajes";
            this.Btn_ABM_Viaje.UseVisualStyleBackColor = false;
            this.Btn_ABM_Viaje.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Viaje.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            // 
            // Btn_ABMClientes
            // 
            this.Btn_ABMClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABMClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ABMClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABMClientes.FlatAppearance.BorderSize = 2;
            this.Btn_ABMClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABMClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ABMClientes.ForeColor = System.Drawing.Color.White;
            this.Btn_ABMClientes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ABMClientes.Image")));
            this.Btn_ABMClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABMClientes.Location = new System.Drawing.Point(2, 2);
            this.Btn_ABMClientes.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABMClientes.Name = "Btn_ABMClientes";
            this.Btn_ABMClientes.Size = new System.Drawing.Size(146, 41);
            this.Btn_ABMClientes.TabIndex = 0;
            this.Btn_ABMClientes.Text = "Clientes";
            this.Btn_ABMClientes.UseVisualStyleBackColor = false;
            this.Btn_ABMClientes.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABMClientes.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelFormularios.BackgroundImage = global::TrabajoPrácticoPAV.Properties.Resources.ElbpHR6W0AAInBS;
            this.PanelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelFormularios.Controls.Add(this.label2);
            this.PanelFormularios.Controls.Add(this.Btn_Menu);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(150, 32);
            this.PanelFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(750, 417);
            this.PanelFormularios.TabIndex = 2;
            this.PanelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFormularios_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(178, 169);
=======
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(169, 157);
>>>>>>> c0467c38f859ceed1b205f660777594ab978726a
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "AerOlimpo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Menu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Menu.FlatAppearance.BorderSize = 2;
            this.Btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Menu.Location = new System.Drawing.Point(0, 370);
            this.Btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(35, 30);
            this.Btn_Menu.TabIndex = 0;
            this.Btn_Menu.Text = "←";
            this.Btn_Menu.UseVisualStyleBackColor = false;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 449);
            this.Controls.Add(this.PanelFormularios);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1440, 878);
            this.MinimumSize = new System.Drawing.Size(720, 390);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelFormularios.ResumeLayout(false);
            this.PanelFormularios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelFormularios;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.Button Btn_ABMClientes;
        private System.Windows.Forms.Button Btn_Configuracion;
        private System.Windows.Forms.Button Btn_ABM_Avion;
        private System.Windows.Forms.Button Btn_ABM_Tripulacion;
        private System.Windows.Forms.Button Btn_ABM_Tramo;
        private System.Windows.Forms.Button Btn_ABM_Vuelo;
        private System.Windows.Forms.Button Btn_ABM_Viaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.Label label2;
    }
}

