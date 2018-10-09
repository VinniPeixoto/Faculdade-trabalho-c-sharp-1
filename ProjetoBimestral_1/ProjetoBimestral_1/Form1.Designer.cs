namespace ProjetoBimestral_1
{
    partial class frmMenu
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
            this.btnMasc = new System.Windows.Forms.Button();
            this.btnFem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMasc
            // 
            this.btnMasc.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasc.Location = new System.Drawing.Point(40, 136);
            this.btnMasc.Name = "btnMasc";
            this.btnMasc.Size = new System.Drawing.Size(81, 82);
            this.btnMasc.TabIndex = 0;
            this.btnMasc.Text = "MASCULINO";
            this.btnMasc.UseVisualStyleBackColor = true;
            this.btnMasc.Click += new System.EventHandler(this.btnMasc_Click);
            // 
            // btnFem
            // 
            this.btnFem.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFem.Location = new System.Drawing.Point(168, 136);
            this.btnFem.Name = "btnFem";
            this.btnFem.Size = new System.Drawing.Size(79, 82);
            this.btnFem.TabIndex = 1;
            this.btnFem.Text = "FEMININO";
            this.btnFem.UseVisualStyleBackColor = true;
            this.btnFem.Click += new System.EventHandler(this.btnFem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha um Perfil";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFem);
            this.Controls.Add(this.btnMasc);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMasc;
        private System.Windows.Forms.Button btnFem;
        private System.Windows.Forms.Label label1;
    }
}

