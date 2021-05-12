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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Btn_ABM = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_ABM_Viaje = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Configuracion = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_ABM_Vuelo = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_ABM_Tramo = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aeropuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aviónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeAsientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoFamiliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tramosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tripulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripulaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.Timer_Expandir = new System.Windows.Forms.Timer(this.components);
            this.Timer_Contraer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelFormularios.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.MouseSalioDeMenu);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(208, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "AEROLÍNEA AEROLIMPO";
            this.Titulo.MouseEnter += new System.EventHandler(this.MouseSalioDeMenu);
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
            this.PanelMenu.Controls.Add(this.Btn_ABM);
            this.PanelMenu.Controls.Add(this.Btn_ABM_Viaje);
            this.PanelMenu.Controls.Add(this.Btn_Configuracion);
            this.PanelMenu.Controls.Add(this.Btn_ABM_Vuelo);
            this.PanelMenu.Controls.Add(this.Btn_ABM_Tramo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.PanelMenu.Location = new System.Drawing.Point(0, 32);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.MaximumSize = new System.Drawing.Size(150, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(150, 417);
            this.PanelMenu.TabIndex = 1;
            this.PanelMenu.MouseEnter += new System.EventHandler(this.PanelMenu_MouseEnter);
            this.PanelMenu.MouseLeave += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // Btn_ABM
            // 
            this.Btn_ABM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM.FlatAppearance.BorderSize = 2;
            this.Btn_ABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_ABM.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM.Image = global::TrabajoPrácticoPAV.Properties.Resources.Cliente_Icono;
            this.Btn_ABM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM.Location = new System.Drawing.Point(2, 2);
            this.Btn_ABM.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM.Name = "Btn_ABM";
            this.Btn_ABM.Pp_Presionado = false;
            this.Btn_ABM.Size = new System.Drawing.Size(146, 41);
            this.Btn_ABM.TabIndex = 2;
            this.Btn_ABM.Text = "Registros";
            this.Btn_ABM.UseVisualStyleBackColor = false;
            this.Btn_ABM.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM.MouseEnter += new System.EventHandler(this.PanelMenu_MouseEnter);
            this.Btn_ABM.MouseLeave += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // Btn_ABM_Viaje
            // 
            this.Btn_ABM_Viaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Viaje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Viaje.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Viaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Viaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_ABM_Viaje.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Viaje.Image = global::TrabajoPrácticoPAV.Properties.Resources.Mundo_Icono;
            this.Btn_ABM_Viaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Viaje.Location = new System.Drawing.Point(2, 49);
            this.Btn_ABM_Viaje.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Viaje.Name = "Btn_ABM_Viaje";
            this.Btn_ABM_Viaje.Pp_Presionado = false;
            this.Btn_ABM_Viaje.Size = new System.Drawing.Size(146, 41);
            this.Btn_ABM_Viaje.TabIndex = 8;
            this.Btn_ABM_Viaje.Text = "Viajes";
            this.Btn_ABM_Viaje.UseVisualStyleBackColor = false;
            this.Btn_ABM_Viaje.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Viaje.MouseEnter += new System.EventHandler(this.PanelMenu_MouseEnter);
            this.Btn_ABM_Viaje.MouseLeave += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // Btn_Configuracion
            // 
            this.Btn_Configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Configuracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Configuracion.FlatAppearance.BorderSize = 2;
            this.Btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Configuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_Configuracion.ForeColor = System.Drawing.Color.White;
            this.Btn_Configuracion.Image = global::TrabajoPrácticoPAV.Properties.Resources.gear_wheel_304395_960_720__1___1_;
            this.Btn_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Configuracion.Location = new System.Drawing.Point(2, 385);
            this.Btn_Configuracion.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Configuracion.Name = "Btn_Configuracion";
            this.Btn_Configuracion.Pp_Presionado = false;
            this.Btn_Configuracion.Size = new System.Drawing.Size(157, 30);
            this.Btn_Configuracion.TabIndex = 3;
            this.Btn_Configuracion.Text = "     Configuración";
            this.Btn_Configuracion.UseVisualStyleBackColor = false;
            this.Btn_Configuracion.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_Configuracion.MouseEnter += new System.EventHandler(this.PanelMenu_MouseEnter);
            this.Btn_Configuracion.MouseLeave += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // Btn_ABM_Vuelo
            // 
            this.Btn_ABM_Vuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Vuelo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Vuelo.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Vuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Vuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_ABM_Vuelo.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Vuelo.Image = global::TrabajoPrácticoPAV.Properties.Resources.Vuelo_Icono;
            this.Btn_ABM_Vuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Vuelo.Location = new System.Drawing.Point(2, 97);
            this.Btn_ABM_Vuelo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Vuelo.Name = "Btn_ABM_Vuelo";
            this.Btn_ABM_Vuelo.Pp_Presionado = false;
            this.Btn_ABM_Vuelo.Size = new System.Drawing.Size(146, 41);
            this.Btn_ABM_Vuelo.TabIndex = 7;
            this.Btn_ABM_Vuelo.Text = "Vuelos";
            this.Btn_ABM_Vuelo.UseVisualStyleBackColor = false;
            this.Btn_ABM_Vuelo.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Vuelo.MouseEnter += new System.EventHandler(this.PanelMenu_MouseEnter);
            this.Btn_ABM_Vuelo.MouseLeave += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // Btn_ABM_Tramo
            // 
            this.Btn_ABM_Tramo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM_Tramo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM_Tramo.FlatAppearance.BorderSize = 2;
            this.Btn_ABM_Tramo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM_Tramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_ABM_Tramo.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM_Tramo.Image = global::TrabajoPrácticoPAV.Properties.Resources.Ubicacion_Icono;
            this.Btn_ABM_Tramo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ABM_Tramo.Location = new System.Drawing.Point(2, 145);
            this.Btn_ABM_Tramo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ABM_Tramo.Name = "Btn_ABM_Tramo";
            this.Btn_ABM_Tramo.Pp_Presionado = false;
            this.Btn_ABM_Tramo.Size = new System.Drawing.Size(146, 41);
            this.Btn_ABM_Tramo.TabIndex = 6;
            this.Btn_ABM_Tramo.Text = "Tramos";
            this.Btn_ABM_Tramo.UseVisualStyleBackColor = false;
            this.Btn_ABM_Tramo.Click += new System.EventHandler(this.MouseClickButton);
            this.Btn_ABM_Tramo.MouseEnter += new System.EventHandler(this.PanelMenu_MouseEnter);
            this.Btn_ABM_Tramo.MouseLeave += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelFormularios.BackgroundImage = global::TrabajoPrácticoPAV.Properties.Resources.ElbpHR6W0AAInBS;
            this.PanelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelFormularios.Controls.Add(this.menuStrip1);
            this.PanelFormularios.Controls.Add(this.pictureBox1);
            this.PanelFormularios.Controls.Add(this.Btn_Menu);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(150, 32);
            this.PanelFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(750, 417);
            this.PanelFormularios.TabIndex = 2;
            this.PanelFormularios.MouseEnter += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aeropuertosToolStripMenuItem,
            this.avionesToolStripMenuItem,
            this.pasajerosToolStripMenuItem,
            this.ubicacionesToolStripMenuItem,
            this.viajesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.menuStrip1.Size = new System.Drawing.Size(129, 417);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // aeropuertosToolStripMenuItem
            // 
            this.aeropuertosToolStripMenuItem.Name = "aeropuertosToolStripMenuItem";
            this.aeropuertosToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.aeropuertosToolStripMenuItem.Text = "Aeropuertos";
            this.aeropuertosToolStripMenuItem.Click += new System.EventHandler(this.aeropuertosToolStripMenuItem_Click);
            // 
            // avionesToolStripMenuItem
            // 
            this.avionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aviónToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.modeloToolStripMenuItem1});
            this.avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.avionesToolStripMenuItem.Text = "Aviones";
            // 
            // aviónToolStripMenuItem
            // 
            this.aviónToolStripMenuItem.Name = "aviónToolStripMenuItem";
            this.aviónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aviónToolStripMenuItem.Text = "Avión";
            this.aviónToolStripMenuItem.Click += new System.EventHandler(this.aviónToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeAsientosToolStripMenuItem,
            this.asientosToolStripMenuItem});
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modeloToolStripMenuItem.Text = "Asientos";
            // 
            // tipoDeAsientosToolStripMenuItem
            // 
            this.tipoDeAsientosToolStripMenuItem.Name = "tipoDeAsientosToolStripMenuItem";
            this.tipoDeAsientosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.tipoDeAsientosToolStripMenuItem.Text = "Tipo de Asientos";
            this.tipoDeAsientosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeAsientosToolStripMenuItem_Click);
            // 
            // asientosToolStripMenuItem
            // 
            this.asientosToolStripMenuItem.Name = "asientosToolStripMenuItem";
            this.asientosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.asientosToolStripMenuItem.Text = "Asientos";
            this.asientosToolStripMenuItem.Click += new System.EventHandler(this.asientosToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem1
            // 
            this.modeloToolStripMenuItem1.Name = "modeloToolStripMenuItem1";
            this.modeloToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modeloToolStripMenuItem1.Text = "Modelo";
            this.modeloToolStripMenuItem1.Click += new System.EventHandler(this.modeloToolStripMenuItem1_Click);
            // 
            // pasajerosToolStripMenuItem
            // 
            this.pasajerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasajeroToolStripMenuItem,
            this.grupoFamiliarToolStripMenuItem,
            this.tipoDeDocumentosToolStripMenuItem});
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            // 
            // pasajeroToolStripMenuItem
            // 
            this.pasajeroToolStripMenuItem.Name = "pasajeroToolStripMenuItem";
            this.pasajeroToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.pasajeroToolStripMenuItem.Text = "Pasajero";
            this.pasajeroToolStripMenuItem.Click += new System.EventHandler(this.pasajeroToolStripMenuItem_Click);
            // 
            // grupoFamiliarToolStripMenuItem
            // 
            this.grupoFamiliarToolStripMenuItem.Name = "grupoFamiliarToolStripMenuItem";
            this.grupoFamiliarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.grupoFamiliarToolStripMenuItem.Text = "Grupo Familiar";
            this.grupoFamiliarToolStripMenuItem.Click += new System.EventHandler(this.grupoFamiliarToolStripMenuItem_Click);
            // 
            // tipoDeDocumentosToolStripMenuItem
            // 
            this.tipoDeDocumentosToolStripMenuItem.Name = "tipoDeDocumentosToolStripMenuItem";
            this.tipoDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.tipoDeDocumentosToolStripMenuItem.Text = "Tipo de Documentos";
            this.tipoDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeDocumentosToolStripMenuItem_Click);
            // 
            // ubicacionesToolStripMenuItem
            // 
            this.ubicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paísToolStripMenuItem,
            this.provinciaToolStripMenuItem,
            this.ciudadToolStripMenuItem});
            this.ubicacionesToolStripMenuItem.Name = "ubicacionesToolStripMenuItem";
            this.ubicacionesToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.ubicacionesToolStripMenuItem.Text = "Ubicaciones";
            // 
            // paísToolStripMenuItem
            // 
            this.paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            this.paísToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paísToolStripMenuItem.Text = "País";
            this.paísToolStripMenuItem.Click += new System.EventHandler(this.paísToolStripMenuItem_Click);
            // 
            // provinciaToolStripMenuItem
            // 
            this.provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            this.provinciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.provinciaToolStripMenuItem.Text = "Provincia";
            this.provinciaToolStripMenuItem.Click += new System.EventHandler(this.provinciaToolStripMenuItem_Click);
            // 
            // ciudadToolStripMenuItem
            // 
            this.ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            this.ciudadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ciudadToolStripMenuItem.Text = "Ciudad";
            this.ciudadToolStripMenuItem.Click += new System.EventHandler(this.ciudadToolStripMenuItem_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vueloToolStripMenuItem,
            this.tramosToolStripMenuItem,
            this.viajesToolStripMenuItem1,
            this.tripulaciónToolStripMenuItem});
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // vueloToolStripMenuItem
            // 
            this.vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            this.vueloToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.vueloToolStripMenuItem.Text = "Vuelo";
            this.vueloToolStripMenuItem.Click += new System.EventHandler(this.vueloToolStripMenuItem_Click);
            // 
            // tramosToolStripMenuItem
            // 
            this.tramosToolStripMenuItem.Name = "tramosToolStripMenuItem";
            this.tramosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tramosToolStripMenuItem.Text = "Tramos";
            this.tramosToolStripMenuItem.Click += new System.EventHandler(this.tramosToolStripMenuItem_Click);
            // 
            // viajesToolStripMenuItem1
            // 
            this.viajesToolStripMenuItem1.Name = "viajesToolStripMenuItem1";
            this.viajesToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.viajesToolStripMenuItem1.Text = "Viajes";
            this.viajesToolStripMenuItem1.Click += new System.EventHandler(this.viajesToolStripMenuItem1_Click);
            // 
            // tripulaciónToolStripMenuItem
            // 
            this.tripulaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargosToolStripMenuItem,
            this.tripulaciónToolStripMenuItem1});
            this.tripulaciónToolStripMenuItem.Name = "tripulaciónToolStripMenuItem";
            this.tripulaciónToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tripulaciónToolStripMenuItem.Text = "Tripulación";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // tripulaciónToolStripMenuItem1
            // 
            this.tripulaciónToolStripMenuItem1.Name = "tripulaciónToolStripMenuItem1";
            this.tripulaciónToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.tripulaciónToolStripMenuItem1.Text = "Tripulación";
            this.tripulaciónToolStripMenuItem1.Click += new System.EventHandler(this.tripulaciónToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::TrabajoPrácticoPAV.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-110, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.MouseSalioDeMenu);
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Menu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Menu.FlatAppearance.BorderSize = 2;
            this.Btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Menu.Location = new System.Drawing.Point(0, 385);
            this.Btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(35, 30);
            this.Btn_Menu.TabIndex = 0;
            this.Btn_Menu.Text = "←";
            this.Btn_Menu.UseVisualStyleBackColor = false;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Timer_Expandir
            // 
            this.Timer_Expandir.Interval = 15;
            this.Timer_Expandir.Tick += new System.EventHandler(this.Timer_Expandir_Tick);
            // 
            // Timer_Contraer
            // 
            this.Timer_Contraer.Interval = 15;
            this.Timer_Contraer.Tick += new System.EventHandler(this.Timer_Contraer_Tick);
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
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelFormularios.ResumeLayout(false);
            this.PanelFormularios.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelFormularios;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Btn_Menu;
        private Clase.Button_Aerolinea Btn_ABM_Viaje;
        private Clase.Button_Aerolinea Btn_ABM_Vuelo;
        private Clase.Button_Aerolinea Btn_ABM_Tramo;
        private Clase.Button_Aerolinea Btn_Configuracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Clase.Button_Aerolinea Btn_ABM;
        private System.Windows.Forms.Timer Timer_Expandir;
        private System.Windows.Forms.Timer Timer_Contraer;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aeropuertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aviónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeAsientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoFamiliarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tramosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tripulaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripulaciónToolStripMenuItem1;

    }
}

