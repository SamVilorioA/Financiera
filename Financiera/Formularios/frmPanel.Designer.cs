﻿namespace Financiera
{
    partial class frmPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanel));
            this.BtnInteresSimple = new System.Windows.Forms.Button();
            this.BtnDescuentos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMontoSimple = new System.Windows.Forms.Button();
            this.btnInteresCompuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInteresSimple
            // 
            this.BtnInteresSimple.Location = new System.Drawing.Point(171, 174);
            this.BtnInteresSimple.Name = "BtnInteresSimple";
            this.BtnInteresSimple.Size = new System.Drawing.Size(195, 80);
            this.BtnInteresSimple.TabIndex = 0;
            this.BtnInteresSimple.Text = "Interes Simple";
            this.BtnInteresSimple.UseVisualStyleBackColor = true;
            this.BtnInteresSimple.Click += new System.EventHandler(this.BtnInteresSimple_Click);
            // 
            // BtnDescuentos
            // 
            this.BtnDescuentos.Location = new System.Drawing.Point(388, 174);
            this.BtnDescuentos.Name = "BtnDescuentos";
            this.BtnDescuentos.Size = new System.Drawing.Size(195, 80);
            this.BtnDescuentos.TabIndex = 1;
            this.BtnDescuentos.Text = "Descuentos";
            this.BtnDescuentos.UseVisualStyleBackColor = true;
            this.BtnDescuentos.Click += new System.EventHandler(this.BtnDescuentos_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(825, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 80);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matematica Financiera 1430";
            // 
            // btnMontoSimple
            // 
            this.btnMontoSimple.Location = new System.Drawing.Point(171, 260);
            this.btnMontoSimple.Name = "btnMontoSimple";
            this.btnMontoSimple.Size = new System.Drawing.Size(195, 80);
            this.btnMontoSimple.TabIndex = 5;
            this.btnMontoSimple.Text = "Monto Simple";
            this.btnMontoSimple.UseVisualStyleBackColor = true;
            this.btnMontoSimple.Click += new System.EventHandler(this.btnMontoSimple_Click);
            // 
            // btnInteresCompuesto
            // 
            this.btnInteresCompuesto.Location = new System.Drawing.Point(388, 260);
            this.btnInteresCompuesto.Name = "btnInteresCompuesto";
            this.btnInteresCompuesto.Size = new System.Drawing.Size(195, 80);
            this.btnInteresCompuesto.TabIndex = 6;
            this.btnInteresCompuesto.Text = "Interes Compuesto";
            this.btnInteresCompuesto.UseVisualStyleBackColor = true;
            this.btnInteresCompuesto.Click += new System.EventHandler(this.btnInteresCompuesto_Click);
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 567);
            this.Controls.Add(this.btnInteresCompuesto);
            this.Controls.Add(this.btnMontoSimple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnDescuentos);
            this.Controls.Add(this.BtnInteresSimple);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPanel";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Financiera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInteresSimple;
        private System.Windows.Forms.Button BtnDescuentos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMontoSimple;
        private System.Windows.Forms.Button btnInteresCompuesto;
    }
}

