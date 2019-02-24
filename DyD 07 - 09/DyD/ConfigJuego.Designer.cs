namespace WindowsFormsApplication1
{
    partial class ConfigJuego
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.comboMapa = new System.Windows.Forms.ComboBox();
            this.nroOp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labComenzar = new System.Windows.Forms.Label();
            this.labVolver = new System.Windows.Forms.Label();
            this.lbestadis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nroOp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mathematica6", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Jugador:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(245, 56);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // comboMapa
            // 
            this.comboMapa.FormattingEnabled = true;
            this.comboMapa.Items.AddRange(new object[] {
            "Principiante",
            "Intermedio",
            "Avanzado"});
            this.comboMapa.Location = new System.Drawing.Point(245, 119);
            this.comboMapa.Name = "comboMapa";
            this.comboMapa.Size = new System.Drawing.Size(121, 21);
            this.comboMapa.TabIndex = 4;
            // 
            // nroOp
            // 
            this.nroOp.Location = new System.Drawing.Point(245, 183);
            this.nroOp.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nroOp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nroOp.Name = "nroOp";
            this.nroOp.Size = new System.Drawing.Size(45, 20);
            this.nroOp.TabIndex = 8;
            this.nroOp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mathematica6", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mathematica6", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nro. de Oponentes:";
            // 
            // labComenzar
            // 
            this.labComenzar.BackColor = System.Drawing.Color.Transparent;
            this.labComenzar.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComenzar.ForeColor = System.Drawing.Color.LightGray;
            this.labComenzar.Location = new System.Drawing.Point(32, 247);
            this.labComenzar.Name = "labComenzar";
            this.labComenzar.Size = new System.Drawing.Size(128, 48);
            this.labComenzar.TabIndex = 10;
            this.labComenzar.Text = "Comenzar";
            this.labComenzar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labComenzar.Click += new System.EventHandler(this.labComenzar_Click);
            this.labComenzar.MouseEnter += new System.EventHandler(this.labComenzar_MouseEnter);
            this.labComenzar.MouseLeave += new System.EventHandler(this.labComenzar_MouseLeave);
            // 
            // labVolver
            // 
            this.labVolver.BackColor = System.Drawing.Color.Transparent;
            this.labVolver.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVolver.ForeColor = System.Drawing.Color.LightGray;
            this.labVolver.Location = new System.Drawing.Point(305, 247);
            this.labVolver.Name = "labVolver";
            this.labVolver.Size = new System.Drawing.Size(100, 48);
            this.labVolver.TabIndex = 11;
            this.labVolver.Text = "Volver";
            this.labVolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labVolver.Click += new System.EventHandler(this.labVolver_Click);
            this.labVolver.MouseEnter += new System.EventHandler(this.labVolver_MouseEnter);
            this.labVolver.MouseLeave += new System.EventHandler(this.labVolver_MouseLeave);
            // 
            // lbestadis
            // 
            this.lbestadis.BackColor = System.Drawing.Color.Transparent;
            this.lbestadis.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestadis.ForeColor = System.Drawing.Color.LightGray;
            this.lbestadis.Location = new System.Drawing.Point(166, 259);
            this.lbestadis.Name = "lbestadis";
            this.lbestadis.Size = new System.Drawing.Size(128, 48);
            this.lbestadis.TabIndex = 12;
            this.lbestadis.Text = "Estadisticas";
            this.lbestadis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbestadis.Click += new System.EventHandler(this.lbestadis_Click);
            // 
            // ConfigJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1415126646370;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 337);
            this.Controls.Add(this.lbestadis);
            this.Controls.Add(this.labVolver);
            this.Controls.Add(this.labComenzar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nroOp);
            this.Controls.Add(this.comboMapa);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ConfigJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nroOp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox comboMapa;
        private System.Windows.Forms.NumericUpDown nroOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labComenzar;
        private System.Windows.Forms.Label labVolver;
        private System.Windows.Forms.Label lbestadis;
    }
}