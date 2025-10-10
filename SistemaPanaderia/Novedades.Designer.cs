namespace SistemaPanaderia
{
    partial class Novedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novedades));
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 57);
            label1.Name = "label1";
            label1.Size = new Size(684, 99);
            label1.TabIndex = 0;
            label1.Text = "“Pan + Chocolate = Amor a primera mordida.”\r\n\r\nDisfruta nuestro nuevo porducto en cualquiero resaurante o para llevar.";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Panaderia4;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(93, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 232);
            panel1.TabIndex = 1;
            // 
            // Novedades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Novedades";
            Text = "Novedades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
    }
}