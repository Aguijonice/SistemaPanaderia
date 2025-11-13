namespace SistemaPanaderia
{
    partial class Ventas
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombreCliente = new TextBox();
            CantidadPan = new NumericUpDown();
            ckChocolate = new CheckBox();
            groupBox1 = new GroupBox();
            cmpan1 = new ComboBox();
            groupBox2 = new GroupBox();
            cmpan2 = new ComboBox();
            groupBox3 = new GroupBox();
            cmpan3 = new ComboBox();
            btBorrar = new Button();
            btFFinalizarVenta = new Button();
            lbSubtotal = new Label();
            lbventas = new Label();
            lbTotal = new Label();
            btnAgregarCarrito = new Button();
            ((System.ComponentModel.ISupportInitialize)CantidadPan).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 29);
            label1.Name = "label1";
            label1.Size = new Size(414, 54);
            label1.TabIndex = 0;
            label1.Text = "CONACI PAN Y AMOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 116);
            label2.Name = "label2";
            label2.Size = new Size(963, 64);
            label2.TabIndex = 1;
            label2.Text = "“Descubre el sabor que alegra tus mañanas: un pan suave, recién horneado \r\n                            y con el toque irresistible del mejor chocolate.”";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Panaderia5;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(27, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 489);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 242);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre del Cliente: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 286);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 4;
            label4.Text = "Cantidad de PAN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 339);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Sub Tota: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 376);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 6;
            label6.Text = "IVA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(530, 416);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 7;
            label7.Text = "Total:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(696, 242);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(342, 27);
            txtNombreCliente.TabIndex = 8;
            // 
            // CantidadPan
            // 
            CantidadPan.Location = new Point(696, 284);
            CantidadPan.Name = "CantidadPan";
            CantidadPan.Size = new Size(141, 27);
            CantidadPan.TabIndex = 9;
            CantidadPan.ValueChanged += CantidadPan_ValueChanged;
            // 
            // ckChocolate
            // 
            ckChocolate.AutoSize = true;
            ckChocolate.Location = new Point(845, 287);
            ckChocolate.Name = "ckChocolate";
            ckChocolate.Size = new Size(193, 24);
            ckChocolate.TabIndex = 10;
            ckChocolate.Text = "Nuevo pan de chocolate";
            ckChocolate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmpan1);
            groupBox1.Location = new Point(530, 482);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 74);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pan 1";
            // 
            // cmpan1
            // 
            cmpan1.FormattingEnabled = true;
            cmpan1.Location = new Point(12, 35);
            cmpan1.Name = "cmpan1";
            cmpan1.Size = new Size(113, 28);
            cmpan1.TabIndex = 0;
            cmpan1.SelectedIndexChanged += cmpan1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmpan2);
            groupBox2.Location = new Point(714, 482);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 74);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pan 2";
            // 
            // cmpan2
            // 
            cmpan2.FormattingEnabled = true;
            cmpan2.Location = new Point(6, 35);
            cmpan2.Name = "cmpan2";
            cmpan2.Size = new Size(111, 28);
            cmpan2.TabIndex = 0;
            cmpan2.SelectedIndexChanged += cmpan2_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmpan3);
            groupBox3.Location = new Point(906, 479);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(132, 77);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pan 3";
            // 
            // cmpan3
            // 
            cmpan3.FormattingEnabled = true;
            cmpan3.Location = new Point(6, 38);
            cmpan3.Name = "cmpan3";
            cmpan3.Size = new Size(101, 28);
            cmpan3.TabIndex = 0;
            cmpan3.SelectedIndexChanged += cmpan3_SelectedIndexChanged;
            // 
            // btBorrar
            // 
            btBorrar.Location = new Point(495, 608);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(169, 79);
            btBorrar.TabIndex = 14;
            btBorrar.Text = "🗑️ Borrar";
            btBorrar.UseVisualStyleBackColor = true;
            btBorrar.Click += btBorrar_Click;
            // 
            // btFFinalizarVenta
            // 
            btFFinalizarVenta.Location = new Point(674, 608);
            btFFinalizarVenta.Name = "btFFinalizarVenta";
            btFFinalizarVenta.Size = new Size(179, 74);
            btFFinalizarVenta.TabIndex = 15;
            btFFinalizarVenta.Text = "✅ Finalizar Venta";
            btFFinalizarVenta.UseVisualStyleBackColor = true;
            btFFinalizarVenta.Click += btFFinalizarVenta_Click;
            // 
            // lbSubtotal
            // 
            lbSubtotal.AutoSize = true;
            lbSubtotal.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubtotal.Location = new Point(610, 337);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(22, 24);
            lbSubtotal.TabIndex = 16;
            lbSubtotal.Text = "$";
            lbSubtotal.Click += lbSubtotal_Click;
            // 
            // lbventas
            // 
            lbventas.AutoSize = true;
            lbventas.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbventas.Location = new Point(610, 372);
            lbventas.Name = "lbventas";
            lbventas.Size = new Size(22, 24);
            lbventas.TabIndex = 17;
            lbventas.Text = "$";
            lbventas.Click += label8_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(610, 412);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(22, 24);
            lbTotal.TabIndex = 18;
            lbTotal.Text = "$";
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(878, 608);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(160, 72);
            btnAgregarCarrito.TabIndex = 19;
            btnAgregarCarrito.Text = "Agregar Carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1064, 763);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(lbTotal);
            Controls.Add(lbventas);
            Controls.Add(lbSubtotal);
            Controls.Add(btFFinalizarVenta);
            Controls.Add(btBorrar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ckChocolate);
            Controls.Add(CantidadPan);
            Controls.Add(txtNombreCliente);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)CantidadPan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombreCliente;
        private NumericUpDown CantidadPan;
        private CheckBox ckChocolate;
        private GroupBox groupBox1;
        private ComboBox cmpan1;
        private GroupBox groupBox2;
        private ComboBox cmpan2;
        private GroupBox groupBox3;
        private ComboBox cmpan3;
        private Button btBorrar;
        private Button btFFinalizarVenta;
        private Label lbSubtotal;
        private Label lbventas;
        private Label lbTotal;
        private Button btnAgregarCarrito;
    }
}