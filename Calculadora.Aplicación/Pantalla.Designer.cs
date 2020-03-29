namespace Calculadora.Aplicación
{
    partial class Pantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnResiduo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.mstContenedor = new System.Windows.Forms.MenuStrip();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mstContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(6, 34);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(245, 39);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            // 
            // btnSumar
            // 
            this.btnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumar.Location = new System.Drawing.Point(191, 234);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(60, 50);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.TabStop = false;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Location = new System.Drawing.Point(191, 286);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(60, 50);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.TabStop = false;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestar.Location = new System.Drawing.Point(191, 182);
            this.btnRestar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(60, 50);
            this.btnRestar.TabIndex = 0;
            this.btnRestar.TabStop = false;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Location = new System.Drawing.Point(191, 130);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(60, 50);
            this.btnMultiplicar.TabIndex = 0;
            this.btnMultiplicar.TabStop = false;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Location = new System.Drawing.Point(67, 78);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(60, 50);
            this.btnRetroceder.TabIndex = 0;
            this.btnRetroceder.TabStop = false;
            this.btnRetroceder.Text = "R";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnResiduo
            // 
            this.btnResiduo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResiduo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResiduo.Location = new System.Drawing.Point(191, 78);
            this.btnResiduo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnResiduo.Name = "btnResiduo";
            this.btnResiduo.Size = new System.Drawing.Size(60, 50);
            this.btnResiduo.TabIndex = 0;
            this.btnResiduo.TabStop = false;
            this.btnResiduo.Text = "%";
            this.btnResiduo.UseVisualStyleBackColor = true;
            this.btnResiduo.Click += new System.EventHandler(this.btnResiduo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(5, 78);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 50);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "L";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcho.Location = new System.Drawing.Point(67, 130);
            this.btnOcho.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(60, 50);
            this.btnOcho.TabIndex = 0;
            this.btnOcho.TabStop = false;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiete.Location = new System.Drawing.Point(5, 130);
            this.btnSiete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(60, 50);
            this.btnSiete.TabIndex = 0;
            this.btnSiete.TabStop = false;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueve.Location = new System.Drawing.Point(129, 130);
            this.btnNueve.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(60, 50);
            this.btnNueve.TabIndex = 0;
            this.btnNueve.TabStop = false;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Location = new System.Drawing.Point(67, 182);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(60, 50);
            this.btnCinco.TabIndex = 0;
            this.btnCinco.TabStop = false;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuatro.Location = new System.Drawing.Point(5, 182);
            this.btnCuatro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(60, 50);
            this.btnCuatro.TabIndex = 0;
            this.btnCuatro.TabStop = false;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Location = new System.Drawing.Point(129, 182);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(60, 50);
            this.btnSeis.TabIndex = 0;
            this.btnSeis.TabStop = false;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnDos
            // 
            this.btnDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDos.Location = new System.Drawing.Point(67, 234);
            this.btnDos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(60, 50);
            this.btnDos.TabIndex = 0;
            this.btnDos.TabStop = false;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUno.Location = new System.Drawing.Point(5, 234);
            this.btnUno.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(60, 50);
            this.btnUno.TabIndex = 0;
            this.btnUno.TabStop = false;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnTres
            // 
            this.btnTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Location = new System.Drawing.Point(129, 234);
            this.btnTres.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(60, 50);
            this.btnTres.TabIndex = 0;
            this.btnTres.TabStop = false;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCero
            // 
            this.btnCero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCero.Location = new System.Drawing.Point(5, 286);
            this.btnCero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(122, 50);
            this.btnCero.TabIndex = 0;
            this.btnCero.TabStop = false;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunto.Location = new System.Drawing.Point(129, 286);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(60, 50);
            this.btnPunto.TabIndex = 0;
            this.btnPunto.TabStop = false;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Location = new System.Drawing.Point(129, 78);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(60, 50);
            this.btnDividir.TabIndex = 0;
            this.btnDividir.TabStop = false;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // mstContenedor
            // 
            this.mstContenedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAyuda});
            this.mstContenedor.Location = new System.Drawing.Point(0, 0);
            this.mstContenedor.Name = "mstContenedor";
            this.mstContenedor.Size = new System.Drawing.Size(257, 27);
            this.mstContenedor.TabIndex = 6;
            this.mstContenedor.Text = "menuStrip1";
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(66, 23);
            this.tsmAyuda.Text = "Ayuda";
            this.tsmAyuda.Click += new System.EventHandler(this.tsmAyuda_Click);
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(257, 341);
            this.Controls.Add(this.mstContenedor);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnResiduo);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtResultado);
            this.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.mstContenedor.ResumeLayout(false);
            this.mstContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnResiduo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.MenuStrip mstContenedor;
        private System.Windows.Forms.ToolStripMenuItem tsmAyuda;
    }
}

