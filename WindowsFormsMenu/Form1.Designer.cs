namespace WindowsFormsMenu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCua = new System.Windows.Forms.Button();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonCirc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Aceptarop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCua
            // 
            this.buttonCua.Location = new System.Drawing.Point(513, 12);
            this.buttonCua.Name = "buttonCua";
            this.buttonCua.Size = new System.Drawing.Size(75, 23);
            this.buttonCua.TabIndex = 0;
            this.buttonCua.Text = "Cuadrado ";
            this.buttonCua.UseVisualStyleBackColor = true;
            this.buttonCua.Click += new System.EventHandler(this.buttonCua_Click);
            // 
            // buttonRect
            // 
            this.buttonRect.Location = new System.Drawing.Point(615, 12);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(75, 23);
            this.buttonRect.TabIndex = 1;
            this.buttonRect.Text = "Rectangulo";
            this.buttonRect.UseVisualStyleBackColor = true;
            this.buttonRect.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCirc
            // 
            this.buttonCirc.Location = new System.Drawing.Point(734, 12);
            this.buttonCirc.Name = "buttonCirc";
            this.buttonCirc.Size = new System.Drawing.Size(75, 23);
            this.buttonCirc.TabIndex = 2;
            this.buttonCirc.Text = "Circulo";
            this.buttonCirc.UseVisualStyleBackColor = true;
            this.buttonCirc.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(164, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 368);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rectangulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Circulo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(842, 12);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(75, 23);
            this.Line.TabIndex = 4;
            this.Line.Text = "Linea";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(28, 237);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 59);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Limpiar";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Verde"});
            this.comboBox1.Location = new System.Drawing.Point(12, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Colores";
            // 
            // Aceptarop
            // 
            this.Aceptarop.Location = new System.Drawing.Point(37, 68);
            this.Aceptarop.Name = "Aceptarop";
            this.Aceptarop.Size = new System.Drawing.Size(75, 23);
            this.Aceptarop.TabIndex = 8;
            this.Aceptarop.Text = "Aceptar ";
            this.Aceptarop.UseVisualStyleBackColor = true;
            this.Aceptarop.Click += new System.EventHandler(this.Aceptarop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 464);
            this.Controls.Add(this.Aceptarop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCirc);
            this.Controls.Add(this.buttonRect);
            this.Controls.Add(this.buttonCua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRect;
        private System.Windows.Forms.Button buttonCirc;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Aceptarop;
    }
}

