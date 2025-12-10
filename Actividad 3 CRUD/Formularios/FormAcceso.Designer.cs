namespace Actividad_3_CRUD.Formularios
{
    partial class FormAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcceso));
            this.buttonAccederClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAccederClientes
            // 
            this.buttonAccederClientes.Location = new System.Drawing.Point(112, 159);
            this.buttonAccederClientes.Name = "buttonAccederClientes";
            this.buttonAccederClientes.Size = new System.Drawing.Size(104, 35);
            this.buttonAccederClientes.TabIndex = 0;
            this.buttonAccederClientes.Text = "Acceder";
            this.buttonAccederClientes.UseVisualStyleBackColor = true;
            this.buttonAccederClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA CONTRASEÑA";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(116, 104);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseña.TabIndex = 2;
            // 
            // FormAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 267);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAccederClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAcceso";
            this.Text = "ACCESO A CLIENTES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAcceso_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAcceso_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccederClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContraseña;
    }
}