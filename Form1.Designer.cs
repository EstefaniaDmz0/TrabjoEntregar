namespace TrabjoEntregar
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
            this.txbSexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.grpbEstu = new System.Windows.Forms.GroupBox();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.btnEnviSeg = new System.Windows.Forms.Button();
            this.txbSemestre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCarrera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstv = new System.Windows.Forms.ListView();
            this.clmNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbEstu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSexo
            // 
            this.txbSexo.Location = new System.Drawing.Point(143, 106);
            this.txbSexo.Name = "txbSexo";
            this.txbSexo.Size = new System.Drawing.Size(62, 20);
            this.txbSexo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sexo: (F o M)";
            // 
            // txbEdad
            // 
            this.txbEdad.Location = new System.Drawing.Point(16, 106);
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(62, 20);
            this.txbEdad.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre alumno:";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(16, 32);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(357, 20);
            this.txbNombre.TabIndex = 16;
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Location = new System.Drawing.Point(3, 19);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(67, 17);
            this.rbtnSi.TabIndex = 7;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "TecMVA";
            this.rbtnSi.UseVisualStyleBackColor = true;
            // 
            // grpbEstu
            // 
            this.grpbEstu.Controls.Add(this.rbtnSi);
            this.grpbEstu.Controls.Add(this.rdbtnNo);
            this.grpbEstu.Location = new System.Drawing.Point(287, 89);
            this.grpbEstu.Name = "grpbEstu";
            this.grpbEstu.Size = new System.Drawing.Size(84, 63);
            this.grpbEstu.TabIndex = 23;
            this.grpbEstu.TabStop = false;
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Location = new System.Drawing.Point(3, 40);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(48, 17);
            this.rdbtnNo.TabIndex = 8;
            this.rdbtnNo.TabStop = true;
            this.rdbtnNo.Text = "Otro.";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            // 
            // btnEnviSeg
            // 
            this.btnEnviSeg.Enabled = false;
            this.btnEnviSeg.Location = new System.Drawing.Point(649, 97);
            this.btnEnviSeg.Name = "btnEnviSeg";
            this.btnEnviSeg.Size = new System.Drawing.Size(88, 29);
            this.btnEnviSeg.TabIndex = 29;
            this.btnEnviSeg.Text = "Enviar";
            this.btnEnviSeg.UseVisualStyleBackColor = true;
            this.btnEnviSeg.Click += new System.EventHandler(this.btnEnviSeg_Click);
            // 
            // txbSemestre
            // 
            this.txbSemestre.Enabled = false;
            this.txbSemestre.Location = new System.Drawing.Point(547, 106);
            this.txbSemestre.Name = "txbSemestre";
            this.txbSemestre.Size = new System.Drawing.Size(62, 20);
            this.txbSemestre.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Semestre:";
            // 
            // txbCarrera
            // 
            this.txbCarrera.Enabled = false;
            this.txbCarrera.Location = new System.Drawing.Point(547, 32);
            this.txbCarrera.Name = "txbCarrera";
            this.txbCarrera.Size = new System.Drawing.Size(190, 20);
            this.txbCarrera.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Carrera:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(409, 48);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 29);
            this.btnEnviar.TabIndex = 24;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Estudiante:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(662, 291);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 47);
            this.btnCargar.TabIndex = 32;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(662, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 47);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstv
            // 
            this.lstv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNom,
            this.clmEda,
            this.clmSex,
            this.clmEst,
            this.clmSem,
            this.clmCar});
            this.lstv.GridLines = true;
            this.lstv.HideSelection = false;
            this.lstv.Location = new System.Drawing.Point(16, 158);
            this.lstv.Name = "lstv";
            this.lstv.Size = new System.Drawing.Size(633, 222);
            this.lstv.TabIndex = 30;
            this.lstv.UseCompatibleStateImageBehavior = false;
            this.lstv.View = System.Windows.Forms.View.Details;
            // 
            // clmNom
            // 
            this.clmNom.Text = "Nombre";
            this.clmNom.Width = 191;
            // 
            // clmEda
            // 
            this.clmEda.Text = "Edad";
            this.clmEda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clmSex
            // 
            this.clmSex.Text = "Sexo";
            this.clmSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clmEst
            // 
            this.clmEst.Text = "Estudiante Tec";
            this.clmEst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmEst.Width = 104;
            // 
            // clmSem
            // 
            this.clmSem.Text = "Semestre";
            this.clmSem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clmCar
            // 
            this.clmCar.Text = "Carrera";
            this.clmCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCar.Width = 154;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 390);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstv);
            this.Controls.Add(this.txbSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.grpbEstu);
            this.Controls.Add(this.btnEnviSeg);
            this.Controls.Add(this.txbSemestre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbCarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbEstu.ResumeLayout(false);
            this.grpbEstu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.GroupBox grpbEstu;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.Button btnEnviSeg;
        private System.Windows.Forms.TextBox txbSemestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListView lstv;
        private System.Windows.Forms.ColumnHeader clmNom;
        private System.Windows.Forms.ColumnHeader clmEda;
        private System.Windows.Forms.ColumnHeader clmSex;
        private System.Windows.Forms.ColumnHeader clmEst;
        private System.Windows.Forms.ColumnHeader clmSem;
        private System.Windows.Forms.ColumnHeader clmCar;
    }
}

