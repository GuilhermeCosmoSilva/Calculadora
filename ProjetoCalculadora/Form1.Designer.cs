﻿
namespace Projeto.Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Potencia = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Primeiro Numero";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Segundo Numero";
            // 
            // Potencia
            // 
            this.Potencia.BackColor = System.Drawing.Color.Maroon;
            this.Potencia.BackgroundImage = global::ProjetoCalculadora.Properties.Resources._32176;
            this.Potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Potencia.Location = new System.Drawing.Point(172, 203);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(95, 35);
            this.Potencia.TabIndex = 7;
            this.Potencia.UseVisualStyleBackColor = false;
            this.Potencia.Click += new System.EventHandler(this.Potencia_Click);
            // 
            // Soma
            // 
            this.Soma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Soma.BackgroundImage = global::ProjetoCalculadora.Properties.Resources._2664;
            this.Soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soma.Location = new System.Drawing.Point(45, 133);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(103, 35);
            this.Soma.TabIndex = 6;
            this.Soma.Text = "button1";
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Raiz
            // 
            this.Raiz.BackColor = System.Drawing.Color.Yellow;
            this.Raiz.BackgroundImage = global::ProjetoCalculadora.Properties.Resources._43743;
            this.Raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Raiz.Location = new System.Drawing.Point(297, 202);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(97, 36);
            this.Raiz.TabIndex = 5;
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Divisao
            // 
            this.Divisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Divisao.BackgroundImage = global::ProjetoCalculadora.Properties.Resources._43097;
            this.Divisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Divisao.Location = new System.Drawing.Point(45, 203);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(103, 35);
            this.Divisao.TabIndex = 3;
            this.Divisao.UseVisualStyleBackColor = false;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.BackColor = System.Drawing.Color.Red;
            this.Multiplicacao.BackgroundImage = global::ProjetoCalculadora.Properties.Resources._3740;
            this.Multiplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Multiplicacao.Location = new System.Drawing.Point(297, 133);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(97, 35);
            this.Multiplicacao.TabIndex = 2;
            this.Multiplicacao.UseVisualStyleBackColor = false;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Subtrair.BackgroundImage = global::ProjetoCalculadora.Properties.Resources._25232;
            this.Subtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Subtrair.Location = new System.Drawing.Point(172, 133);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(107, 35);
            this.Subtrair.TabIndex = 1;
            this.Subtrair.UseVisualStyleBackColor = false;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.Color.Salmon;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(134, 279);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(155, 33);
            this.Resultado.TabIndex = 12;
            this.Resultado.Text = "Resultado";
            this.Resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCalculadora.Properties.Resources.outrun_wallpaper__10__2017_01_25_0516;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Subtrair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultado;
    }
}

