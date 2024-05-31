namespace Sistema_de_ventas
{
    partial class Menu_admin
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_DetalleVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_Ventas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Cerrar sesión";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(679, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Bienvenido!";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(776, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Bienvenido!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reportes,
            this.menu_DetalleVentas,
            this.menu_Ventas,
            this.menu_clientes});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 20, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(845, 114);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Reportes
            // 
            this.Reportes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Reportes.AutoSize = false;
            this.Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reportes.IconChar = FontAwesome.Sharp.IconChar.Supple;
            this.Reportes.IconColor = System.Drawing.Color.Black;
            this.Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportes.IconSize = 70;
            this.Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(10);
            this.Reportes.Size = new System.Drawing.Size(122, 120);
            this.Reportes.Text = "Reportes";
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_DetalleVentas
            // 
            this.menu_DetalleVentas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_DetalleVentas.AutoSize = false;
            this.menu_DetalleVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_DetalleVentas.IconChar = FontAwesome.Sharp.IconChar.Supple;
            this.menu_DetalleVentas.IconColor = System.Drawing.Color.Black;
            this.menu_DetalleVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_DetalleVentas.IconSize = 70;
            this.menu_DetalleVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_DetalleVentas.Name = "menu_DetalleVentas";
            this.menu_DetalleVentas.Padding = new System.Windows.Forms.Padding(10);
            this.menu_DetalleVentas.Size = new System.Drawing.Size(122, 120);
            this.menu_DetalleVentas.Text = "DetalleVentas";
            this.menu_DetalleVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_Ventas
            // 
            this.menu_Ventas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_Ventas.AutoSize = false;
            this.menu_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_Ventas.IconChar = FontAwesome.Sharp.IconChar.Supple;
            this.menu_Ventas.IconColor = System.Drawing.Color.Black;
            this.menu_Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Ventas.IconSize = 70;
            this.menu_Ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Ventas.Name = "menu_Ventas";
            this.menu_Ventas.Padding = new System.Windows.Forms.Padding(10);
            this.menu_Ventas.Size = new System.Drawing.Size(122, 120);
            this.menu_Ventas.Text = "Ventas";
            this.menu_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_clientes
            // 
            this.menu_clientes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.Cpanel;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.IconSize = 70;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Padding = new System.Windows.Forms.Padding(10);
            this.menu_clientes.Size = new System.Drawing.Size(122, 120);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_clientes.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 101);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_admin";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menu_DetalleVentas;
        private FontAwesome.Sharp.IconMenuItem menu_Ventas;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem Reportes;
        private System.Windows.Forms.Button button1;
    }
}

