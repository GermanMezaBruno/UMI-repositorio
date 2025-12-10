namespace Actividad_3_CRUD
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bienvenidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajeBienvenidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.damasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caballerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienvenidaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bienvenidaToolStripMenuItem
            // 
            this.bienvenidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensajeBienvenidaToolStripMenuItem,
            this.quiToolStripMenuItem,
            this.misiónToolStripMenuItem,
            this.visiónToolStripMenuItem});
            this.bienvenidaToolStripMenuItem.Name = "bienvenidaToolStripMenuItem";
            this.bienvenidaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.bienvenidaToolStripMenuItem.Text = "Bienvenida";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.damasToolStripMenuItem,
            this.caballerosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mensajeBienvenidaToolStripMenuItem
            // 
            this.mensajeBienvenidaToolStripMenuItem.Name = "mensajeBienvenidaToolStripMenuItem";
            this.mensajeBienvenidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mensajeBienvenidaToolStripMenuItem.Text = "Mensaje Bienvenida";
            this.mensajeBienvenidaToolStripMenuItem.Click += new System.EventHandler(this.mensajeBienvenidaToolStripMenuItem_Click);
            // 
            // quiToolStripMenuItem
            // 
            this.quiToolStripMenuItem.Name = "quiToolStripMenuItem";
            this.quiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quiToolStripMenuItem.Text = "¿Quiénes somos?";
            this.quiToolStripMenuItem.Click += new System.EventHandler(this.quiToolStripMenuItem_Click);
            // 
            // misiónToolStripMenuItem
            // 
            this.misiónToolStripMenuItem.Name = "misiónToolStripMenuItem";
            this.misiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.misiónToolStripMenuItem.Text = "Misión";
            this.misiónToolStripMenuItem.Click += new System.EventHandler(this.misiónToolStripMenuItem_Click);
            // 
            // visiónToolStripMenuItem
            // 
            this.visiónToolStripMenuItem.Name = "visiónToolStripMenuItem";
            this.visiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visiónToolStripMenuItem.Text = "Visión";
            this.visiónToolStripMenuItem.Click += new System.EventHandler(this.visiónToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // damasToolStripMenuItem
            // 
            this.damasToolStripMenuItem.Name = "damasToolStripMenuItem";
            this.damasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.damasToolStripMenuItem.Text = "Damas";
            this.damasToolStripMenuItem.Click += new System.EventHandler(this.damasToolStripMenuItem_Click);
            // 
            // caballerosToolStripMenuItem
            // 
            this.caballerosToolStripMenuItem.Name = "caballerosToolStripMenuItem";
            this.caballerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caballerosToolStripMenuItem.Text = "Caballeros";
            this.caballerosToolStripMenuItem.Click += new System.EventHandler(this.caballerosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.RightToLeftLayout = true;
            this.Text = "CALZADO GERMAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bienvenidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajeBienvenidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem damasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caballerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
    }
}

