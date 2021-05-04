namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_Configuracion
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
            this.Btn_Forest = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Salir = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_BlueB = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Mostaza = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.SuspendLayout();
            // 
            // Btn_Forest
            // 
            this.Btn_Forest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(171)))), ((int)(((byte)(118)))));
            this.Btn_Forest.Location = new System.Drawing.Point(268, 68);
            this.Btn_Forest.Name = "Btn_Forest";
            this.Btn_Forest.Pp_Presionado = false;
            this.Btn_Forest.Size = new System.Drawing.Size(210, 59);
            this.Btn_Forest.TabIndex = 0;
            this.Btn_Forest.Text = "Snowy Forest";
            this.Btn_Forest.UseVisualStyleBackColor = false;
            this.Btn_Forest.Click += new System.EventHandler(this.Btn_Forest_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(268, 263);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Pp_Presionado = false;
            this.Btn_Salir.Size = new System.Drawing.Size(210, 59);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "Guardar y salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_BlueB
            // 
            this.Btn_BlueB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(79)))), ((int)(((byte)(148)))));
            this.Btn_BlueB.Location = new System.Drawing.Point(268, 198);
            this.Btn_BlueB.Name = "Btn_BlueB";
            this.Btn_BlueB.Pp_Presionado = false;
            this.Btn_BlueB.Size = new System.Drawing.Size(210, 59);
            this.Btn_BlueB.TabIndex = 2;
            this.Btn_BlueB.Text = "Blueberry Mora";
            this.Btn_BlueB.UseVisualStyleBackColor = false;
            this.Btn_BlueB.Click += new System.EventHandler(this.Btn_BlueB_Click);
            // 
            // Btn_Mostaza
            // 
            this.Btn_Mostaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Mostaza.Location = new System.Drawing.Point(268, 133);
            this.Btn_Mostaza.Name = "Btn_Mostaza";
            this.Btn_Mostaza.Pp_Presionado = false;
            this.Btn_Mostaza.Size = new System.Drawing.Size(210, 59);
            this.Btn_Mostaza.TabIndex = 3;
            this.Btn_Mostaza.Text = "Mostaza Tefi";
            this.Btn_Mostaza.UseVisualStyleBackColor = false;
            this.Btn_Mostaza.Click += new System.EventHandler(this.Btn_Mostaza_Click);
            // 
            // Frm_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Mostaza);
            this.Controls.Add(this.Btn_BlueB);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Forest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Configuracion";
            this.Text = "Frm_Configuracion";
            this.ResumeLayout(false);

        }

        #endregion

        private Clase.Button_Aerolinea Btn_Forest;
        private Clase.Button_Aerolinea Btn_Salir;
        private Clase.Button_Aerolinea Btn_BlueB;
        private Clase.Button_Aerolinea Btn_Mostaza;
    }
}