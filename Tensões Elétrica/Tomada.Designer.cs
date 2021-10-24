
namespace Tensões_Elétrica
{
    partial class Tomada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFT = new System.Windows.Forms.TextBox();
            this.textTN = new System.Windows.Forms.TextBox();
            this.textFN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você selecionou á tomada. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verifica com o multimetro a tomada do cliente e informa nos campos abaixo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textFT
            // 
            this.textFT.Location = new System.Drawing.Point(327, 113);
            this.textFT.Name = "textFT";
            this.textFT.Size = new System.Drawing.Size(55, 20);
            this.textFT.TabIndex = 3;
            // 
            // textTN
            // 
            this.textTN.Location = new System.Drawing.Point(327, 139);
            this.textTN.Name = "textTN";
            this.textTN.Size = new System.Drawing.Size(55, 20);
            this.textTN.TabIndex = 4;
            // 
            // textFN
            // 
            this.textFN.Location = new System.Drawing.Point(457, 125);
            this.textFN.Name = "textFN";
            this.textFN.Size = new System.Drawing.Size(55, 20);
            this.textFN.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Averiguar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(579, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(582, 125);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(206, 245);
            this.Resultado.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tensões_Elétrica.Properties.Resources.tomada1;
            this.pictureBox1.Location = new System.Drawing.Point(44, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Tomada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFN);
            this.Controls.Add(this.textTN);
            this.Controls.Add(this.textFT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Tomada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFT;
        private System.Windows.Forms.TextBox textTN;
        private System.Windows.Forms.TextBox textFN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resultado;
    }
}