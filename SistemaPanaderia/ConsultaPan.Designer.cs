namespace SistemaPanaderia
{
    partial class ConsultaPan
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
            groupBox1 = new GroupBox();
            lbStock = new Label();
            lbPrecio = new Label();
            lable34 = new Label();
            label = new Label();
            groupBox2 = new GroupBox();
            btnAceptar = new Button();
            cmbNombre = new ComboBox();
            ptbpanes = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbpanes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ptbpanes);
            groupBox1.Controls.Add(lbStock);
            groupBox1.Controls.Add(lbPrecio);
            groupBox1.Controls.Add(lable34);
            groupBox1.Controls.Add(label);
            groupBox1.Font = new Font("Segoe UI Variable Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 577);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "¡Consulta por aqui!";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(493, 254);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(33, 37);
            lbStock.TabIndex = 4;
            lbStock.Text = "0";
            lbStock.Click += label4_Click;
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrecio.Location = new Point(494, 201);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(32, 37);
            lbPrecio.TabIndex = 3;
            lbPrecio.Text = "$";
            // 
            // lable34
            // 
            lable34.AutoSize = true;
            lable34.Location = new Point(376, 254);
            lable34.Name = "lable34";
            lable34.Size = new Size(97, 37);
            lable34.TabIndex = 2;
            lable34.Text = "Stock:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(376, 203);
            label.Name = "label";
            label.Size = new Size(122, 37);
            label.TabIndex = 1;
            label.Text = "Precio:  ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAceptar);
            groupBox2.Controls.Add(cmbNombre);
            groupBox2.Font = new Font("Segoe UI Variable Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(669, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 569);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "¿Que deseas Ordenar?";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(89, 310);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(227, 137);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbNombre
            // 
            cmbNombre.FormattingEnabled = true;
            cmbNombre.Items.AddRange(new object[] { "Quesadia", "Peperecha", "Simeta alta", "Concha ", "Salpor", "Poleada", "Nuevo de chocolate" });
            cmbNombre.Location = new Point(63, 60);
            cmbNombre.Name = "cmbNombre";
            cmbNombre.Size = new Size(229, 44);
            cmbNombre.TabIndex = 0;
            // 
            // ptbpanes
            // 
            ptbpanes.Image = Properties.Resources.Panaderia4;
            ptbpanes.Location = new Point(22, 121);
            ptbpanes.Name = "ptbpanes";
            ptbpanes.Size = new Size(351, 373);
            ptbpanes.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbpanes.TabIndex = 5;
            ptbpanes.TabStop = false;
            // 
            // ConsultaPan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1066, 608);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ConsultaPan";
            Text = "ConsultaPan";
            Load += ConsultaPan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbpanes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbStock;
        private Label lbPrecio;
        private Label lable34;
        private Label label;
        private GroupBox groupBox2;
        private Button btnAceptar;
        private ComboBox cmbNombre;
        private PictureBox ptbpanes;
    }
}