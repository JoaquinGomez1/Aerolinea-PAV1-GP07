
namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ModificarAvion
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
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.txt_numero_modelo = new System.Windows.Forms.TextBox();
            this.cmb_MOdelo = new Clase.ComboBox_Aerolinea();
            this.SuspendLayout();
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Salmon;
            this.btn_Modificar.Location = new System.Drawing.Point(274, 133);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 0;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 231);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(57, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(261, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Ingrese los nuevos datos del avion";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(73, 82);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "Numero";
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(73, 140);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_Modelo.TabIndex = 4;
            this.lbl_Modelo.Text = "Modelo";
            // 
            // txt_numero_modelo
            // 
            this.txt_numero_modelo.Location = new System.Drawing.Point(130, 75);
            this.txt_numero_modelo.Name = "txt_numero_modelo";
            this.txt_numero_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_numero_modelo.TabIndex = 5;
            this.txt_numero_modelo.TextChanged += new System.EventHandler(this.txt_numero_modelo_TextChanged);
            // 
            // cmb_MOdelo
            // 
            this.cmb_MOdelo.FormattingEnabled = true;
            this.cmb_MOdelo.Location = new System.Drawing.Point(130, 132);
            this.cmb_MOdelo.Name = "cmb_MOdelo";
            this.cmb_MOdelo.Size = new System.Drawing.Size(100, 21);
            this.cmb_MOdelo.TabIndex = 6;
            // 
            // Frm_ModificarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(386, 260);
            this.Controls.Add(this.cmb_MOdelo);
            this.Controls.Add(this.txt_numero_modelo);
            this.Controls.Add(this.lbl_Modelo);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ModificarAvion";
            this.Text = "Modificar Avion";
            this.Load += new System.EventHandler(this.Frm_ModificarAvion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.TextBox txt_numero_modelo;
        private Clase.ComboBox_Aerolinea cmb_MOdelo;
    }
}