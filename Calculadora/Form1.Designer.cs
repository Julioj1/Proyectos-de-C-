namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnuno = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btncambiodesigno = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btncuadrado = new System.Windows.Forms.Button();
            this.btnraizcuadrada = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(0, 0);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(358, 57);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnuno
            // 
            this.btnuno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnuno.Location = new System.Drawing.Point(12, 406);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(80, 80);
            this.btnuno.TabIndex = 1;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btndos
            // 
            this.btndos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndos.Location = new System.Drawing.Point(98, 406);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(80, 80);
            this.btndos.TabIndex = 2;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btntres
            // 
            this.btntres.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntres.Location = new System.Drawing.Point(184, 406);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(80, 80);
            this.btntres.TabIndex = 3;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnseis
            // 
            this.btnseis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnseis.Location = new System.Drawing.Point(184, 320);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(80, 80);
            this.btnseis.TabIndex = 6;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btncinco
            // 
            this.btncinco.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncinco.Location = new System.Drawing.Point(98, 320);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(80, 80);
            this.btncinco.TabIndex = 5;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btncuatro
            // 
            this.btncuatro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncuatro.Location = new System.Drawing.Point(12, 320);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(80, 80);
            this.btncuatro.TabIndex = 4;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpunto.Location = new System.Drawing.Point(184, 492);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(80, 80);
            this.btnpunto.TabIndex = 9;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btncero
            // 
            this.btncero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncero.Location = new System.Drawing.Point(98, 492);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(80, 80);
            this.btncero.TabIndex = 8;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btncambiodesigno
            // 
            this.btncambiodesigno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncambiodesigno.Location = new System.Drawing.Point(12, 492);
            this.btncambiodesigno.Name = "btncambiodesigno";
            this.btncambiodesigno.Size = new System.Drawing.Size(80, 80);
            this.btncambiodesigno.TabIndex = 7;
            this.btncambiodesigno.Text = "±";
            this.btncambiodesigno.UseVisualStyleBackColor = true;
            this.btncambiodesigno.Click += new System.EventHandler(this.btncambiodesigno_Click);
            // 
            // btnnueve
            // 
            this.btnnueve.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnnueve.Location = new System.Drawing.Point(184, 235);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(80, 80);
            this.btnnueve.TabIndex = 12;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnocho
            // 
            this.btnocho.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnocho.Location = new System.Drawing.Point(98, 235);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(80, 80);
            this.btnocho.TabIndex = 11;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnsiete
            // 
            this.btnsiete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsiete.Location = new System.Drawing.Point(12, 235);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(80, 80);
            this.btnsiete.TabIndex = 10;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnborrartodo.Location = new System.Drawing.Point(184, 63);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(80, 80);
            this.btnborrartodo.TabIndex = 14;
            this.btnborrartodo.Text = "C";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnborrar.Location = new System.Drawing.Point(98, 63);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(80, 80);
            this.btnborrar.TabIndex = 13;
            this.btnborrar.Text = "CE";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbackspace
            // 
            this.btnbackspace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbackspace.Location = new System.Drawing.Point(270, 63);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(80, 80);
            this.btnbackspace.TabIndex = 15;
            this.btnbackspace.Text = "<-";
            this.btnbackspace.UseVisualStyleBackColor = true;
            this.btnbackspace.Click += new System.EventHandler(this.btnbackspace_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmultiplicacion.Location = new System.Drawing.Point(270, 234);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(80, 80);
            this.btnmultiplicacion.TabIndex = 16;
            this.btnmultiplicacion.Tag = "x";
            this.btnmultiplicacion.Text = "×";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            this.btnmultiplicacion.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnresta.Location = new System.Drawing.Point(270, 320);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(80, 80);
            this.btnresta.TabIndex = 17;
            this.btnresta.Tag = "-";
            this.btnresta.Text = "−";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsuma.Location = new System.Drawing.Point(270, 406);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(80, 80);
            this.btnsuma.TabIndex = 18;
            this.btnsuma.Tag = "+";
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResultado.Location = new System.Drawing.Point(270, 492);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(80, 80);
            this.btnResultado.TabIndex = 19;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btncuadrado
            // 
            this.btncuadrado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncuadrado.Location = new System.Drawing.Point(98, 149);
            this.btncuadrado.Name = "btncuadrado";
            this.btncuadrado.Size = new System.Drawing.Size(80, 80);
            this.btncuadrado.TabIndex = 20;
            this.btncuadrado.Tag = "²";
            this.btncuadrado.Text = "x²";
            this.btncuadrado.UseVisualStyleBackColor = true;
            this.btncuadrado.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnraizcuadrada
            // 
            this.btnraizcuadrada.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnraizcuadrada.Location = new System.Drawing.Point(184, 149);
            this.btnraizcuadrada.Name = "btnraizcuadrada";
            this.btnraizcuadrada.Size = new System.Drawing.Size(80, 80);
            this.btnraizcuadrada.TabIndex = 21;
            this.btnraizcuadrada.Tag = "*";
            this.btnraizcuadrada.Text = "√";
            this.btnraizcuadrada.UseVisualStyleBackColor = true;
            this.btnraizcuadrada.Click += new System.EventHandler(this.clickoperador);
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndivision.Location = new System.Drawing.Point(270, 148);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(80, 80);
            this.btndivision.TabIndex = 22;
            this.btndivision.Tag = "/";
            this.btndivision.Text = "∕";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.clickoperador);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 576);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnraizcuadrada);
            this.Controls.Add(this.btncuadrado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btnbackspace);
            this.Controls.Add(this.btnborrartodo);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btncambiodesigno);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator by Jbunny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResultado;
        private Button btnuno;
        private Button btndos;
        private Button btntres;
        private Button btnseis;
        private Button btncinco;
        private Button btncuatro;
        private Button btnpunto;
        private Button btncero;
        private Button btncambiodesigno;
        private Button btnnueve;
        private Button btnocho;
        private Button btnsiete;
        private Button btnborrartodo;
        private Button btnborrar;
        private Button btnbackspace;
        private Button btnmultiplicacion;
        private Button btnresta;
        private Button btnsuma;
        private Button btnResultado;
        private Button btncuadrado;
        private Button btnraizcuadrada;
        private Button btndivision;
    }
}