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
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
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
            this.Btn_ABM = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Procesos = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Configuracion = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Listado = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Estadistica = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelFormularios.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Controls.Add(this.Btn_Minimizar);
            this.BarraSuperior.Controls.Add(this.Btn_Cerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(900, 36);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.PanelMenu.Controls.Add(this.Btn_ABM);
            this.PanelMenu.Controls.Add(this.Btn_Procesos);
            this.PanelMenu.Controls.Add(this.Btn_Configuracion);
            this.PanelMenu.Controls.Add(this.Btn_Listado);
            this.PanelMenu.Controls.Add(this.Btn_Estadistica);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.PanelMenu.Location = new System.Drawing.Point(0, 36);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.MaximumSize = new System.Drawing.Size(150, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(150, 413);
            this.PanelMenu.TabIndex = 1;
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelFormularios.BackgroundImage = global::TrabajoPrácticoPAV.Properties.Resources.ElbpHR6W0AAInBS;
            this.PanelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelFormularios.Controls.Add(this.menuStrip1);
            this.PanelFormularios.Controls.Add(this.pictureBox1);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(150, 36);
            this.PanelFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(750, 413);
            this.PanelFormularios.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
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
            this.aeropuertosToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
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
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.avionesToolStripMenuItem.Text = "Aviones";
            // 
            // aviónToolStripMenuItem
            // 
            this.aviónToolStripMenuItem.Name = "aviónToolStripMenuItem";
            this.aviónToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.aviónToolStripMenuItem.Text = "Avión";
            this.aviónToolStripMenuItem.Click += new System.EventHandler(this.aviónToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeAsientosToolStripMenuItem,
            this.asientosToolStripMenuItem});
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.modeloToolStripMenuItem.Text = "Asientos";
            // 
            // tipoDeAsientosToolStripMenuItem
            // 
            this.tipoDeAsientosToolStripMenuItem.Name = "tipoDeAsientosToolStripMenuItem";
            this.tipoDeAsientosToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.tipoDeAsientosToolStripMenuItem.Text = "Tipo de Asientos";
            this.tipoDeAsientosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeAsientosToolStripMenuItem_Click);
            // 
            // asientosToolStripMenuItem
            // 
            this.asientosToolStripMenuItem.Name = "asientosToolStripMenuItem";
            this.asientosToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.asientosToolStripMenuItem.Text = "Asientos";
            this.asientosToolStripMenuItem.Click += new System.EventHandler(this.asientosToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem1
            // 
            this.modeloToolStripMenuItem1.Name = "modeloToolStripMenuItem1";
            this.modeloToolStripMenuItem1.Size = new System.Drawing.Size(148, 24);
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
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            // 
            // pasajeroToolStripMenuItem
            // 
            this.pasajeroToolStripMenuItem.Name = "pasajeroToolStripMenuItem";
            this.pasajeroToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.pasajeroToolStripMenuItem.Text = "Pasajero";
            this.pasajeroToolStripMenuItem.Click += new System.EventHandler(this.pasajeroToolStripMenuItem_Click);
            // 
            // grupoFamiliarToolStripMenuItem
            // 
            this.grupoFamiliarToolStripMenuItem.Name = "grupoFamiliarToolStripMenuItem";
            this.grupoFamiliarToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.grupoFamiliarToolStripMenuItem.Text = "Grupo Familiar";
            this.grupoFamiliarToolStripMenuItem.Click += new System.EventHandler(this.grupoFamiliarToolStripMenuItem_Click);
            // 
            // tipoDeDocumentosToolStripMenuItem
            // 
            this.tipoDeDocumentosToolStripMenuItem.Name = "tipoDeDocumentosToolStripMenuItem";
            this.tipoDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
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
            this.ubicacionesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.ubicacionesToolStripMenuItem.Text = "Ubicaciones";
            // 
            // paísToolStripMenuItem
            // 
            this.paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            this.paísToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.paísToolStripMenuItem.Text = "País";
            this.paísToolStripMenuItem.Click += new System.EventHandler(this.paísToolStripMenuItem_Click);
            // 
            // provinciaToolStripMenuItem
            // 
            this.provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            this.provinciaToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.provinciaToolStripMenuItem.Text = "Provincia";
            this.provinciaToolStripMenuItem.Click += new System.EventHandler(this.provinciaToolStripMenuItem_Click);
            // 
            // ciudadToolStripMenuItem
            // 
            this.ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            this.ciudadToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
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
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // vueloToolStripMenuItem
            // 
            this.vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            this.vueloToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.vueloToolStripMenuItem.Text = "Vuelo";
            this.vueloToolStripMenuItem.Click += new System.EventHandler(this.vueloToolStripMenuItem_Click);
            // 
            // tramosToolStripMenuItem
            // 
            this.tramosToolStripMenuItem.Name = "tramosToolStripMenuItem";
            this.tramosToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.tramosToolStripMenuItem.Text = "Tramos";
            this.tramosToolStripMenuItem.Click += new System.EventHandler(this.tramosToolStripMenuItem_Click);
            // 
            // viajesToolStripMenuItem1
            // 
            this.viajesToolStripMenuItem1.Name = "viajesToolStripMenuItem1";
            this.viajesToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.viajesToolStripMenuItem1.Text = "Viajes";
            this.viajesToolStripMenuItem1.Click += new System.EventHandler(this.viajesToolStripMenuItem1_Click);
            // 
            // tripulaciónToolStripMenuItem
            // 
            this.tripulaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargosToolStripMenuItem,
            this.tripulaciónToolStripMenuItem1});
            this.tripulaciónToolStripMenuItem.Name = "tripulaciónToolStripMenuItem";
            this.tripulaciónToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.tripulaciónToolStripMenuItem.Text = "Tripulación";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // tripulaciónToolStripMenuItem1
            // 
            this.tripulaciónToolStripMenuItem1.Name = "tripulaciónToolStripMenuItem1";
            this.tripulaciónToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
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
            this.pictureBox1.Location = new System.Drawing.Point(-110, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_ABM
            // 
            this.Btn_ABM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_ABM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ABM.FlatAppearance.BorderSize = 2;
            this.Btn_ABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_ABM.ForeColor = System.Drawing.Color.White;
            this.Btn_ABM.Image = global::TrabajoPrácticoPAV.Properties.Resources.klipartz_com__1_;
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
            // 
            // Btn_Procesos
            // 
            this.Btn_Procesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Procesos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Procesos.FlatAppearance.BorderSize = 2;
            this.Btn_Procesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Procesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_Procesos.ForeColor = System.Drawing.Color.White;
            this.Btn_Procesos.Image = global::TrabajoPrácticoPAV.Properties.Resources.reboot_arrow_3726__1_;
            this.Btn_Procesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Procesos.Location = new System.Drawing.Point(2, 49);
            this.Btn_Procesos.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Procesos.Name = "Btn_Procesos";
            this.Btn_Procesos.Pp_Presionado = false;
            this.Btn_Procesos.Size = new System.Drawing.Size(146, 41);
            this.Btn_Procesos.TabIndex = 8;
            this.Btn_Procesos.Text = "Procesos";
            this.Btn_Procesos.UseVisualStyleBackColor = false;
            this.Btn_Procesos.Click += new System.EventHandler(this.MouseClickButton);
            // 
            // Btn_Configuracion
            // 
            this.Btn_Configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Configuracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Configuracion.FlatAppearance.BorderSize = 2;
            this.Btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Configuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_Configuracion.ForeColor = System.Drawing.Color.White;
            this.Btn_Configuracion.Image = global::TrabajoPrácticoPAV.Properties.Resources.pngegg;
            this.Btn_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Configuracion.Location = new System.Drawing.Point(2, 385);
            this.Btn_Configuracion.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Configuracion.Name = "Btn_Configuracion";
            this.Btn_Configuracion.Pp_Presionado = false;
            this.Btn_Configuracion.Size = new System.Drawing.Size(146, 30);
            this.Btn_Configuracion.TabIndex = 3;
            this.Btn_Configuracion.Text = "     Configuración";
            this.Btn_Configuracion.UseVisualStyleBackColor = false;
            this.Btn_Configuracion.Click += new System.EventHandler(this.MouseClickButton);
            // 
            // Btn_Listado
            // 
            this.Btn_Listado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Listado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Listado.FlatAppearance.BorderSize = 2;
            this.Btn_Listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_Listado.ForeColor = System.Drawing.Color.White;
            this.Btn_Listado.Image = global::TrabajoPrácticoPAV.Properties.Resources._8b1a89d3f271913146d4cd63f3920464_icono_de_trazo_de_lista_de_verificaci_oacute_n_m_eacute_dica_by_vexels1;
            this.Btn_Listado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Listado.Location = new System.Drawing.Point(2, 97);
            this.Btn_Listado.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Listado.Name = "Btn_Listado";
            this.Btn_Listado.Pp_Presionado = false;
            this.Btn_Listado.Size = new System.Drawing.Size(146, 41);
            this.Btn_Listado.TabIndex = 7;
            this.Btn_Listado.Text = "Listados";
            this.Btn_Listado.UseVisualStyleBackColor = false;
            this.Btn_Listado.Click += new System.EventHandler(this.MouseClickButton);
            // 
            // Btn_Estadistica
            // 
            this.Btn_Estadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Estadistica.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Estadistica.FlatAppearance.BorderSize = 2;
            this.Btn_Estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_Estadistica.ForeColor = System.Drawing.Color.White;
            this.Btn_Estadistica.Image = global::TrabajoPrácticoPAV.Properties.Resources.Icon_66_512;
            this.Btn_Estadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Estadistica.Location = new System.Drawing.Point(2, 145);
            this.Btn_Estadistica.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Estadistica.Name = "Btn_Estadistica";
            this.Btn_Estadistica.Pp_Presionado = false;
            this.Btn_Estadistica.Size = new System.Drawing.Size(146, 41);
            this.Btn_Estadistica.TabIndex = 6;
            this.Btn_Estadistica.Text = "    Estadísticas";
            this.Btn_Estadistica.UseVisualStyleBackColor = false;
            this.Btn_Estadistica.Click += new System.EventHandler(this.MouseClickButton);
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
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 449);
            this.Controls.Add(this.PanelFormularios);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1440, 878);
            this.MinimumSize = new System.Drawing.Size(720, 390);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelFormularios.ResumeLayout(false);
            this.PanelFormularios.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelFormularios;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.Label Titulo;
        private Clase.Button_Aerolinea Btn_Procesos;
        private Clase.Button_Aerolinea Btn_Listado;
        private Clase.Button_Aerolinea Btn_Estadistica;
        private Clase.Button_Aerolinea Btn_Configuracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Clase.Button_Aerolinea Btn_ABM;

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

