﻿
namespace evaluacion
{
    partial class dividir
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
            this.Bttlimpiar = new System.Windows.Forms.Button();
            this.Bttsumar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblNumero2 = new System.Windows.Forms.Label();
            this.LblNumero1 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bttlimpiar
            // 
            this.Bttlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttlimpiar.Location = new System.Drawing.Point(32, 272);
            this.Bttlimpiar.Name = "Bttlimpiar";
            this.Bttlimpiar.Size = new System.Drawing.Size(116, 46);
            this.Bttlimpiar.TabIndex = 20;
            this.Bttlimpiar.Text = "Limpiar";
            this.Bttlimpiar.UseVisualStyleBackColor = true;
            this.Bttlimpiar.Click += new System.EventHandler(this.Bttlimpiar_Click_1);
            // 
            // Bttsumar
            // 
            this.Bttsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttsumar.Location = new System.Drawing.Point(200, 102);
            this.Bttsumar.Name = "Bttsumar";
            this.Bttsumar.Size = new System.Drawing.Size(83, 71);
            this.Bttsumar.TabIndex = 19;
            this.Bttsumar.Text = "/";
            this.Bttsumar.UseVisualStyleBackColor = true;
            this.Bttsumar.Click += new System.EventHandler(this.Bttsumar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(11, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 30);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 30);
            this.textBox1.TabIndex = 17;
            // 
            // LblNumero2
            // 
            this.LblNumero2.AutoSize = true;
            this.LblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero2.Location = new System.Drawing.Point(12, 125);
            this.LblNumero2.Name = "LblNumero2";
            this.LblNumero2.Size = new System.Drawing.Size(167, 25);
            this.LblNumero2.TabIndex = 16;
            this.LblNumero2.Text = "Ingrese Numero 2";
            // 
            // LblNumero1
            // 
            this.LblNumero1.AutoSize = true;
            this.LblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero1.Location = new System.Drawing.Point(12, 27);
            this.LblNumero1.Name = "LblNumero1";
            this.LblNumero1.Size = new System.Drawing.Size(167, 25);
            this.LblNumero1.TabIndex = 15;
            this.LblNumero1.Text = "Ingrese Numero 1";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(313, 125);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 25);
            this.LblResultado.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cerrar Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dividir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.Bttlimpiar);
            this.Controls.Add(this.Bttsumar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblNumero2);
            this.Controls.Add(this.LblNumero1);
            this.Name = "dividir";
            this.Text = "dividir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bttlimpiar;
        private System.Windows.Forms.Button Bttsumar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblNumero2;
        private System.Windows.Forms.Label LblNumero1;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button button1;
    }
}