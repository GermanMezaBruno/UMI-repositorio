namespace Actividad_3_CRUD.Formularios
{
    partial class FormAccesoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccesoProducto));
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccederProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(116, 95);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseña.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESA CONTRASEÑA";
            // 
            // buttonAccederProductos
            // 
            this.buttonAccederProductos.Location = new System.Drawing.Point(112, 150);
            this.buttonAccederProductos.Name = "buttonAccederProductos";
            this.buttonAccederProductos.Size = new System.Drawing.Size(104, 35);
            this.buttonAccederProductos.TabIndex = 6;
            this.buttonAccederProductos.Text = "Acceder";
            this.buttonAccederProductos.UseVisualStyleBackColor = true;
            this.buttonAccederProductos.Click += new System.EventHandler(this.buttonAccederProductos_Click);
            // 
            // FormAccesoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 249);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAccederProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccesoProducto";
            this.Text = "ACCESO A PRODUCTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccesoProducto_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccederProductos;
    }
}