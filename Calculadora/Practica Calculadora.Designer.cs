namespace Calculadora
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.retroceso = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.cuadrado = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(180, 22);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(13, 42);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pantalla.Size = new System.Drawing.Size(412, 131);
            this.Pantalla.TabIndex = 2;
            this.Pantalla.Text = "0";
            // 
            // retroceso
            // 
            this.retroceso.Location = new System.Drawing.Point(13, 190);
            this.retroceso.Name = "retroceso";
            this.retroceso.Size = new System.Drawing.Size(155, 46);
            this.retroceso.TabIndex = 3;
            this.retroceso.Text = "Retroceso";
            this.retroceso.UseVisualStyleBackColor = true;
            this.retroceso.Click += new System.EventHandler(this.retroceso_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(176, 190);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 46);
            this.borrar.TabIndex = 4;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(260, 190);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(75, 46);
            this.multiplicacion.TabIndex = 6;
            this.multiplicacion.Text = "*";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(260, 246);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 46);
            this.division.TabIndex = 10;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(174, 247);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 46);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(93, 247);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 46);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(13, 246);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 46);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(260, 361);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 101);
            this.suma.TabIndex = 18;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(174, 361);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 46);
            this.num3.TabIndex = 17;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(93, 361);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 46);
            this.num2.TabIndex = 16;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(13, 360);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 46);
            this.num1.TabIndex = 15;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(260, 304);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(75, 46);
            this.resta.TabIndex = 14;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(174, 305);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 46);
            this.num6.TabIndex = 13;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(93, 305);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 46);
            this.num5.TabIndex = 12;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(13, 304);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 46);
            this.num4.TabIndex = 11;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(13, 416);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(153, 46);
            this.num0.TabIndex = 19;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // punto
            // 
            this.punto.Location = new System.Drawing.Point(174, 416);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(75, 46);
            this.punto.TabIndex = 20;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            // 
            // cuadrado
            // 
            this.cuadrado.Location = new System.Drawing.Point(350, 190);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(75, 46);
            this.cuadrado.TabIndex = 21;
            this.cuadrado.Text = "x^2";
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.Click += new System.EventHandler(this.cuadrado_Click);
            // 
            // raiz
            // 
            this.raiz.Location = new System.Drawing.Point(350, 246);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(75, 46);
            this.raiz.TabIndex = 22;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(350, 305);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 157);
            this.igual.TabIndex = 23;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(441, 485);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.cuadrado);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.division);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.retroceso);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button retroceso;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button cuadrado;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button igual;
    }
}

