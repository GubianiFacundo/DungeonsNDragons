namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labJugar = new System.Windows.Forms.Label();
            this.labDemo = new System.Windows.Forms.Label();
            this.labSalir = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labJugar
            // 
            this.labJugar.BackColor = System.Drawing.Color.Transparent;
            this.labJugar.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJugar.ForeColor = System.Drawing.Color.LightGray;
            this.labJugar.Location = new System.Drawing.Point(69, 276);
            this.labJugar.Name = "labJugar";
            this.labJugar.Size = new System.Drawing.Size(100, 48);
            this.labJugar.TabIndex = 3;
            this.labJugar.Text = "Jugar";
            this.labJugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labJugar.Click += new System.EventHandler(this.labJugar_Click);
            this.labJugar.MouseEnter += new System.EventHandler(this.labJugar_MouseEnter);
            this.labJugar.MouseLeave += new System.EventHandler(this.labJugar_MouseLeave);
            // 
            // labDemo
            // 
            this.labDemo.BackColor = System.Drawing.Color.Transparent;
            this.labDemo.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDemo.ForeColor = System.Drawing.Color.LightGray;
            this.labDemo.Location = new System.Drawing.Point(235, 276);
            this.labDemo.Name = "labDemo";
            this.labDemo.Size = new System.Drawing.Size(100, 48);
            this.labDemo.TabIndex = 4;
            this.labDemo.Text = "Demo";
            this.labDemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labDemo.Click += new System.EventHandler(this.labDemo_Click);
            this.labDemo.MouseEnter += new System.EventHandler(this.labDemo_MouseEnter);
            this.labDemo.MouseLeave += new System.EventHandler(this.labDemo_MouseLeave);
            // 
            // labSalir
            // 
            this.labSalir.BackColor = System.Drawing.Color.Transparent;
            this.labSalir.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSalir.ForeColor = System.Drawing.Color.LightGray;
            this.labSalir.Location = new System.Drawing.Point(401, 276);
            this.labSalir.Name = "labSalir";
            this.labSalir.Size = new System.Drawing.Size(100, 48);
            this.labSalir.TabIndex = 5;
            this.labSalir.Text = "Salir";
            this.labSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labSalir.Click += new System.EventHandler(this.labSalir_Click);
            this.labSalir.MouseEnter += new System.EventHandler(this.labSalir_MouseEnter);
            this.labSalir.MouseLeave += new System.EventHandler(this.labSalir_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.musicON;
            this.pictureBox1.Location = new System.Drawing.Point(502, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.transcoder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labSalir);
            this.Controls.Add(this.labDemo);
            this.Controls.Add(this.labJugar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labJugar;
        private System.Windows.Forms.Label labDemo;
        private System.Windows.Forms.Label labSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

