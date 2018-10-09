namespace ProjetoBimestral_1
{
    partial class ClienteFem
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
            this.txtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtFixo = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEst = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNasc
            // 
            this.txtNasc.Location = new System.Drawing.Point(125, 77);
            this.txtNasc.Mask = "00/00/0000";
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(116, 22);
            this.txtNasc.TabIndex = 4;
            this.txtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtFixo
            // 
            this.txtFixo.Location = new System.Drawing.Point(218, 45);
            this.txtFixo.Mask = "(99) 0000-0000";
            this.txtFixo.Name = "txtFixo";
            this.txtFixo.Size = new System.Drawing.Size(116, 22);
            this.txtFixo.TabIndex = 3;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(55, 45);
            this.txtCel.Mask = "(99) 00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(116, 22);
            this.txtCel.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Complemento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Data de Nascimento:";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnos.ForeColor = System.Drawing.Color.Red;
            this.lblAnos.Location = new System.Drawing.Point(260, 78);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(0, 19);
            this.lblAnos.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fixo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Celular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome:";
            // 
            // txtEst
            // 
            this.txtEst.Location = new System.Drawing.Point(234, 209);
            this.txtEst.Name = "txtEst";
            this.txtEst.Size = new System.Drawing.Size(100, 22);
            this.txtEst.TabIndex = 10;
            this.txtEst.Validating += new System.ComponentModel.CancelEventHandler(this.txtEst_Validating);
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(65, 209);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(107, 22);
            this.txtCid.TabIndex = 9;
            this.txtCid.Validating += new System.ComponentModel.CancelEventHandler(this.txtCid_Validating);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(66, 173);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(268, 22);
            this.txtBairro.TabIndex = 8;
            this.txtBairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtBairro_Validating);
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(249, 141);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(84, 22);
            this.txtComp.TabIndex = 7;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(66, 141);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(84, 22);
            this.txtNum.TabIndex = 6;
            this.txtNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(85, 109);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(249, 22);
            this.txtLogra.TabIndex = 5;
            this.txtLogra.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogra_Validating);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(278, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // ltbNomes
            // 
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 16;
            this.ltbNomes.Location = new System.Drawing.Point(340, 12);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(137, 228);
            this.ltbNomes.TabIndex = 50;
            // 
            // btnZA
            // 
            this.btnZA.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZA.Location = new System.Drawing.Point(413, 255);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(62, 54);
            this.btnZA.TabIndex = 54;
            this.btnZA.Text = "Z/A";
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // btnAZ
            // 
            this.btnAZ.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAZ.Location = new System.Drawing.Point(340, 255);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(65, 54);
            this.btnAZ.TabIndex = 53;
            this.btnAZ.Text = "A/Z";
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(193, 255);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 54);
            this.btnRemover.TabIndex = 52;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(64, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 54);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ClienteFem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 321);
            this.Controls.Add(this.btnZA);
            this.Controls.Add(this.btnAZ);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ltbNomes);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.txtFixo);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEst);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtLogra);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ClienteFem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Feminino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNasc;
        private System.Windows.Forms.MaskedTextBox txtFixo;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEst;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdd;
    }
}