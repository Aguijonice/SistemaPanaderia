namespace SistemaPanaderia
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            menuStrip1 = new MenuStrip();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            sobreNosotrosToolStripMenuItem = new ToolStripMenuItem();
            novedadesToolStripMenuItem = new ToolStripMenuItem();
            productosYMásToolStripMenuItem = new ToolStripMenuItem();
            descubreNuevosProductosToolStripMenuItem1 = new ToolStripMenuItem();
            ventasToolStripMenuItem1 = new ToolStripMenuItem();
            btnNuevaventa = new Button();
            label1 = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, productosYMásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1329, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreNosotrosToolStripMenuItem, novedadesToolStripMenuItem });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(80, 24);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // sobreNosotrosToolStripMenuItem
            // 
            sobreNosotrosToolStripMenuItem.Name = "sobreNosotrosToolStripMenuItem";
            sobreNosotrosToolStripMenuItem.Size = new Size(224, 26);
            sobreNosotrosToolStripMenuItem.Text = "Sobre nosotros";
            sobreNosotrosToolStripMenuItem.Click += sobreNosotrosToolStripMenuItem_Click;
            // 
            // novedadesToolStripMenuItem
            // 
            novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            novedadesToolStripMenuItem.Size = new Size(224, 26);
            novedadesToolStripMenuItem.Text = "Novedades";
            novedadesToolStripMenuItem.Click += novedadesToolStripMenuItem_Click;
            // 
            // productosYMásToolStripMenuItem
            // 
            productosYMásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { descubreNuevosProductosToolStripMenuItem1, ventasToolStripMenuItem1 });
            productosYMásToolStripMenuItem.Name = "productosYMásToolStripMenuItem";
            productosYMásToolStripMenuItem.Size = new Size(131, 24);
            productosYMásToolStripMenuItem.Text = "Productos y más";
            // 
            // descubreNuevosProductosToolStripMenuItem1
            // 
            descubreNuevosProductosToolStripMenuItem1.Name = "descubreNuevosProductosToolStripMenuItem1";
            descubreNuevosProductosToolStripMenuItem1.Size = new Size(275, 26);
            descubreNuevosProductosToolStripMenuItem1.Text = "Descubre nuevos productos";
            descubreNuevosProductosToolStripMenuItem1.Click += descubreNuevosProductosToolStripMenuItem1_Click;
            // 
            // ventasToolStripMenuItem1
            // 
            ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            ventasToolStripMenuItem1.Size = new Size(275, 26);
            ventasToolStripMenuItem1.Text = "Ventas";
            ventasToolStripMenuItem1.Click += ventasToolStripMenuItem1_Click;
            // 
            // btnNuevaventa
            // 
            btnNuevaventa.BackColor = Color.Peru;
            btnNuevaventa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaventa.Location = new Point(254, 243);
            btnNuevaventa.Name = "btnNuevaventa";
            btnNuevaventa.Size = new Size(337, 166);
            btnNuevaventa.TabIndex = 1;
            btnNuevaventa.Text = "🛍️ ¡Realiza tu compra!";
            btnNuevaventa.UseVisualStyleBackColor = false;
            btnNuevaventa.Click += btnNuevaventa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 446);
            label1.Name = "label1";
            label1.Size = new Size(623, 124);
            label1.TabIndex = 2;
            label1.Text = "\U0001f950 “Horneamos con amor\r\n        servimos con sabor.”";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Panaderia1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(842, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 499);
            panel1.TabIndex = 3;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Panaderia2;
            ClientSize = new Size(1329, 740);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnNuevaventa);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Bienvenida";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem productosYMásToolStripMenuItem;
        private ToolStripMenuItem descubreNuevosProductosToolStripMenuItem1;
        private ToolStripMenuItem sobreNosotrosToolStripMenuItem;
        private ToolStripMenuItem novedadesToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem1;
        private Button btnNuevaventa;
        private Label label1;
        private Panel panel1;
    }
}
