namespace WindowsFormsApplication1
{
    partial class FJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJuego));
            this.listJuego = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTurno = new System.Windows.Forms.Label();
            this.btnTirar = new System.Windows.Forms.Button();
            this.lbDado = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbP0 = new System.Windows.Forms.Label();
            this.lbP1 = new System.Windows.Forms.Label();
            this.lbP2 = new System.Windows.Forms.Label();
            this.lbP3 = new System.Windows.Forms.Label();
            this.labC = new System.Windows.Forms.Label();
            this.lbD0 = new System.Windows.Forms.Label();
            this.lbD1 = new System.Windows.Forms.Label();
            this.lbD2 = new System.Windows.Forms.Label();
            this.lbD3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listJuego
            // 
            this.listJuego.BackColor = System.Drawing.Color.White;
            this.listJuego.ForeColor = System.Drawing.Color.Black;
            this.listJuego.FormattingEnabled = true;
            this.listJuego.ItemHeight = 23;
            this.listJuego.Location = new System.Drawing.Point(304, 22);
            this.listJuego.Margin = new System.Windows.Forms.Padding(5);
            this.listJuego.Name = "listJuego";
            this.listJuego.Size = new System.Drawing.Size(727, 349);
            this.listJuego.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turno";
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.BackColor = System.Drawing.Color.Transparent;
            this.lbTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTurno.Location = new System.Drawing.Point(116, 83);
            this.lbTurno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(40, 23);
            this.lbTurno.TabIndex = 2;
            this.lbTurno.Text = "111";
            // 
            // btnTirar
            // 
            this.btnTirar.Location = new System.Drawing.Point(32, 139);
            this.btnTirar.Margin = new System.Windows.Forms.Padding(5);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(149, 41);
            this.btnTirar.TabIndex = 3;
            this.btnTirar.Text = "Tirar";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // lbDado
            // 
            this.lbDado.AutoSize = true;
            this.lbDado.BackColor = System.Drawing.Color.Transparent;
            this.lbDado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDado.Location = new System.Drawing.Point(73, 227);
            this.lbDado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDado.Name = "lbDado";
            this.lbDado.Size = new System.Drawing.Size(0, 23);
            this.lbDado.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNombre.Location = new System.Drawing.Point(384, 423);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(72, 23);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(533, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "PC 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(656, 423);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "PC 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(779, 423);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "PC 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(237, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Posicion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(237, 530);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Dragones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(900, 423);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Calabozos";
            // 
            // lbP0
            // 
            this.lbP0.AutoSize = true;
            this.lbP0.BackColor = System.Drawing.Color.Transparent;
            this.lbP0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbP0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbP0.Location = new System.Drawing.Point(384, 468);
            this.lbP0.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP0.Name = "lbP0";
            this.lbP0.Size = new System.Drawing.Size(20, 23);
            this.lbP0.TabIndex = 12;
            this.lbP0.Text = "1";
            // 
            // lbP1
            // 
            this.lbP1.AutoSize = true;
            this.lbP1.BackColor = System.Drawing.Color.Transparent;
            this.lbP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbP1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbP1.Location = new System.Drawing.Point(533, 468);
            this.lbP1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP1.Name = "lbP1";
            this.lbP1.Size = new System.Drawing.Size(20, 23);
            this.lbP1.TabIndex = 12;
            this.lbP1.Text = "1";
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.BackColor = System.Drawing.Color.Transparent;
            this.lbP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbP2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbP2.Location = new System.Drawing.Point(656, 468);
            this.lbP2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(16, 23);
            this.lbP2.TabIndex = 12;
            this.lbP2.Text = "-";
            // 
            // lbP3
            // 
            this.lbP3.AutoSize = true;
            this.lbP3.BackColor = System.Drawing.Color.Transparent;
            this.lbP3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbP3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbP3.Location = new System.Drawing.Point(779, 468);
            this.lbP3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP3.Name = "lbP3";
            this.lbP3.Size = new System.Drawing.Size(16, 23);
            this.lbP3.TabIndex = 12;
            this.lbP3.Text = "-";
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.BackColor = System.Drawing.Color.Transparent;
            this.labC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labC.Location = new System.Drawing.Point(900, 468);
            this.labC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(16, 23);
            this.labC.TabIndex = 12;
            this.labC.Text = "-";
            // 
            // lbD0
            // 
            this.lbD0.AutoSize = true;
            this.lbD0.BackColor = System.Drawing.Color.Transparent;
            this.lbD0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbD0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbD0.Location = new System.Drawing.Point(384, 530);
            this.lbD0.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbD0.Name = "lbD0";
            this.lbD0.Size = new System.Drawing.Size(16, 23);
            this.lbD0.TabIndex = 12;
            this.lbD0.Text = "-";
            // 
            // lbD1
            // 
            this.lbD1.AutoSize = true;
            this.lbD1.BackColor = System.Drawing.Color.Transparent;
            this.lbD1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbD1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbD1.Location = new System.Drawing.Point(533, 530);
            this.lbD1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbD1.Name = "lbD1";
            this.lbD1.Size = new System.Drawing.Size(16, 23);
            this.lbD1.TabIndex = 12;
            this.lbD1.Text = "-";
            // 
            // lbD2
            // 
            this.lbD2.AutoSize = true;
            this.lbD2.BackColor = System.Drawing.Color.Transparent;
            this.lbD2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbD2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbD2.Location = new System.Drawing.Point(656, 530);
            this.lbD2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbD2.Name = "lbD2";
            this.lbD2.Size = new System.Drawing.Size(16, 23);
            this.lbD2.TabIndex = 12;
            this.lbD2.Text = "-";
            // 
            // lbD3
            // 
            this.lbD3.AutoSize = true;
            this.lbD3.BackColor = System.Drawing.Color.Transparent;
            this.lbD3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbD3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbD3.Location = new System.Drawing.Point(779, 530);
            this.lbD3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbD3.Name = "lbD3";
            this.lbD3.Size = new System.Drawing.Size(16, 23);
            this.lbD3.TabIndex = 12;
            this.lbD3.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(900, 530);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 23);
            this.label20.TabIndex = 12;
            this.label20.Text = "-";
            // 
            // FJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.transcoder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 621);
            this.Controls.Add(this.labC);
            this.Controls.Add(this.lbP3);
            this.Controls.Add(this.lbP2);
            this.Controls.Add(this.lbP1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lbD3);
            this.Controls.Add(this.lbD2);
            this.Controls.Add(this.lbD1);
            this.Controls.Add(this.lbD0);
            this.Controls.Add(this.lbP0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDado);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.lbTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listJuego);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mathematica6", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calabozos y Dragones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FJuego_FormClosed);
            this.Load += new System.EventHandler(this.FJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.Label lbDado;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbP0;
        private System.Windows.Forms.Label lbP1;
        private System.Windows.Forms.Label lbP2;
        private System.Windows.Forms.Label lbP3;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.Label lbD0;
        private System.Windows.Forms.Label lbD1;
        private System.Windows.Forms.Label lbD2;
        private System.Windows.Forms.Label lbD3;
        private System.Windows.Forms.Label label20;
    }
}