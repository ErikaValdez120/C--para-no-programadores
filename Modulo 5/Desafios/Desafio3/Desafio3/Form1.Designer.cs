namespace Desafio3
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
            this.operacion = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacion.ForeColor = System.Drawing.Color.GreenYellow;
            this.operacion.Location = new System.Drawing.Point(436, 149);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(0, 24);
            this.operacion.TabIndex = 22;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(419, 43);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 23);
            this.resultado.TabIndex = 21;
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividir.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dividir.Location = new System.Drawing.Point(285, 196);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(51, 51);
            this.dividir.TabIndex = 20;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multiplicar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplicar.Location = new System.Drawing.Point(212, 196);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(51, 51);
            this.multiplicar.TabIndex = 19;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // restar
            // 
            this.restar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restar.Location = new System.Drawing.Point(139, 196);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(51, 51);
            this.restar.TabIndex = 18;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = false;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // sumar
            // 
            this.sumar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sumar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sumar.Location = new System.Drawing.Point(65, 196);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(51, 51);
            this.sumar.TabIndex = 17;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = false;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // numero2
            // 
            this.numero2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.Location = new System.Drawing.Point(154, 116);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(220, 30);
            this.numero2.TabIndex = 16;
            // 
            // numero1
            // 
            this.numero1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(154, 78);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(220, 30);
            this.numero1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Numero 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Calculadora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(423, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 166);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 297);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

