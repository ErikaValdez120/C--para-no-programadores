namespace Desafios
{
    partial class Desafio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreAl = new System.Windows.Forms.TextBox();
            this.fechaReg = new System.Windows.Forms.DateTimePicker();
            this.estadoCiv = new System.Windows.Forms.ComboBox();
            this.hom = new System.Windows.Forms.RadioButton();
            this.muj = new System.Windows.Forms.RadioButton();
            this.nogen = new System.Windows.Forms.RadioButton();
            this.esEx = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsExtrangero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.Alerta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del alumno: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrador de alumnos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha del registro: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado civil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Es extranjero: ";
            // 
            // nombreAl
            // 
            this.nombreAl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAl.Location = new System.Drawing.Point(186, 70);
            this.nombreAl.Name = "nombreAl";
            this.nombreAl.Size = new System.Drawing.Size(340, 31);
            this.nombreAl.TabIndex = 6;
            // 
            // fechaReg
            // 
            this.fechaReg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaReg.Location = new System.Drawing.Point(186, 105);
            this.fechaReg.Name = "fechaReg";
            this.fechaReg.Size = new System.Drawing.Size(340, 31);
            this.fechaReg.TabIndex = 7;
            // 
            // estadoCiv
            // 
            this.estadoCiv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCiv.FormattingEnabled = true;
            this.estadoCiv.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Divorciado"});
            this.estadoCiv.Location = new System.Drawing.Point(186, 140);
            this.estadoCiv.Name = "estadoCiv";
            this.estadoCiv.Size = new System.Drawing.Size(340, 31);
            this.estadoCiv.TabIndex = 8;
            // 
            // hom
            // 
            this.hom.AutoSize = true;
            this.hom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hom.Location = new System.Drawing.Point(186, 178);
            this.hom.Name = "hom";
            this.hom.Size = new System.Drawing.Size(91, 27);
            this.hom.TabIndex = 9;
            this.hom.TabStop = true;
            this.hom.Text = "Hombre";
            this.hom.UseVisualStyleBackColor = true;
            // 
            // muj
            // 
            this.muj.AutoSize = true;
            this.muj.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muj.Location = new System.Drawing.Point(289, 178);
            this.muj.Name = "muj";
            this.muj.Size = new System.Drawing.Size(75, 27);
            this.muj.TabIndex = 10;
            this.muj.TabStop = true;
            this.muj.Text = "Mujer";
            this.muj.UseVisualStyleBackColor = true;
            this.muj.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // nogen
            // 
            this.nogen.AutoSize = true;
            this.nogen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nogen.Location = new System.Drawing.Point(371, 178);
            this.nogen.Name = "nogen";
            this.nogen.Size = new System.Drawing.Size(129, 27);
            this.nogen.TabIndex = 11;
            this.nogen.TabStop = true;
            this.nogen.Text = "No especifica";
            this.nogen.UseVisualStyleBackColor = true;
            // 
            // esEx
            // 
            this.esEx.AutoSize = true;
            this.esEx.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esEx.Location = new System.Drawing.Point(186, 212);
            this.esEx.Name = "esEx";
            this.esEx.Size = new System.Drawing.Size(42, 27);
            this.esEx.TabIndex = 12;
            this.esEx.Text = "Si";
            this.esEx.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(428, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechaDeRegistro,
            this.EstadoCivil,
            this.Genero,
            this.EsExtrangero});
            this.dataGrid.Location = new System.Drawing.Point(12, 314);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(548, 298);
            this.dataGrid.TabIndex = 14;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaDeRegistro
            // 
            this.FechaDeRegistro.HeaderText = "Fecha De Registro";
            this.FechaDeRegistro.Name = "FechaDeRegistro";
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.Name = "EstadoCivil";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // EsExtrangero
            // 
            this.EsExtrangero.HeaderText = "Es Extranjero";
            this.EsExtrangero.Name = "EsExtrangero";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(245, 622);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Alerta
            // 
            this.Alerta.AutoSize = true;
            this.Alerta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alerta.ForeColor = System.Drawing.Color.Red;
            this.Alerta.Location = new System.Drawing.Point(214, 267);
            this.Alerta.Name = "Alerta";
            this.Alerta.Size = new System.Drawing.Size(0, 23);
            this.Alerta.TabIndex = 16;
            // 
            // Desafio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 673);
            this.Controls.Add(this.Alerta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.esEx);
            this.Controls.Add(this.nogen);
            this.Controls.Add(this.muj);
            this.Controls.Add(this.hom);
            this.Controls.Add(this.estadoCiv);
            this.Controls.Add(this.fechaReg);
            this.Controls.Add(this.nombreAl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Desafio1";
            this.Text = "Registrador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreAl;
        private System.Windows.Forms.DateTimePicker fechaReg;
        private System.Windows.Forms.ComboBox estadoCiv;
        private System.Windows.Forms.RadioButton hom;
        private System.Windows.Forms.RadioButton muj;
        private System.Windows.Forms.RadioButton nogen;
        private System.Windows.Forms.CheckBox esEx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsExtrangero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Alerta;
    }
}

