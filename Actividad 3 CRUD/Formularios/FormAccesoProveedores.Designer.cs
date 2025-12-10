namespace Actividad_3_CRUD.Formularios
{
    partial class FormAccederProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccederProveedores));
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccederClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(118, 85);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseña.TabIndex = 5;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESA CONTRASEÑA";
            // 
            // buttonAccederClientes
            // 
            this.buttonAccederClientes.Location = new System.Drawing.Point(114, 140);
            this.buttonAccederClientes.Name = "buttonAccederClientes";
            this.buttonAccederClientes.Size = new System.Drawing.Size(104, 35);
            this.buttonAccederClientes.TabIndex = 3;
            this.buttonAccederClientes.Text = "Acceder";
            this.buttonAccederClientes.UseVisualStyleBackColor = true;
            this.buttonAccederClientes.Click += new System.EventHandler(this.buttonAccederClientes_Click);
            // 
            // FormAccederProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 237);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAccederClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccederProveedores";
            this.Text = "ACCESO A PROVEEDORES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccederProveedores_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccederClientes;
    }
}