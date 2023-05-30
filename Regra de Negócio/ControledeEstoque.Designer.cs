namespace Casamento
{
    partial class ControledeEstoque
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantProd = new System.Windows.Forms.TextBox();
            this.txtestmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultProd = new System.Windows.Forms.TextBox();
            this.btnSelectPro = new System.Windows.Forms.Button();
            this.btnCadEst = new System.Windows.Forms.Button();
            this.btnConsuEst = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodEst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Estoque Minimo:";
            // 
            // txtQuantProd
            // 
            this.txtQuantProd.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantProd.Location = new System.Drawing.Point(296, 151);
            this.txtQuantProd.Name = "txtQuantProd";
            this.txtQuantProd.Size = new System.Drawing.Size(201, 31);
            this.txtQuantProd.TabIndex = 88;
            // 
            // txtestmin
            // 
            this.txtestmin.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestmin.Location = new System.Drawing.Point(296, 199);
            this.txtestmin.Name = "txtestmin";
            this.txtestmin.Size = new System.Drawing.Size(201, 31);
            this.txtestmin.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 93;
            this.label1.Text = "Produto:";
            // 
            // txtConsultProd
            // 
            this.txtConsultProd.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultProd.Location = new System.Drawing.Point(296, 100);
            this.txtConsultProd.Name = "txtConsultProd";
            this.txtConsultProd.Size = new System.Drawing.Size(201, 31);
            this.txtConsultProd.TabIndex = 92;
            // 
            // btnSelectPro
            // 
            this.btnSelectPro.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPro.Location = new System.Drawing.Point(503, 55);
            this.btnSelectPro.Name = "btnSelectPro";
            this.btnSelectPro.Size = new System.Drawing.Size(82, 31);
            this.btnSelectPro.TabIndex = 104;
            this.btnSelectPro.Text = "Selecionar";
            this.btnSelectPro.UseVisualStyleBackColor = true;
            this.btnSelectPro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCadEst
            // 
            this.btnCadEst.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadEst.Location = new System.Drawing.Point(397, 260);
            this.btnCadEst.Name = "btnCadEst";
            this.btnCadEst.Size = new System.Drawing.Size(116, 65);
            this.btnCadEst.TabIndex = 109;
            this.btnCadEst.Text = "Cadastrar Estoque";
            this.btnCadEst.UseVisualStyleBackColor = true;
            this.btnCadEst.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnConsuEst
            // 
            this.btnConsuEst.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsuEst.Location = new System.Drawing.Point(142, 260);
            this.btnConsuEst.Name = "btnConsuEst";
            this.btnConsuEst.Size = new System.Drawing.Size(116, 65);
            this.btnConsuEst.TabIndex = 108;
            this.btnConsuEst.Text = "Consultar Produto";
            this.btnConsuEst.UseVisualStyleBackColor = true;
            this.btnConsuEst.Click += new System.EventHandler(this.btnConsuEst_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 111;
            this.label5.Text = "Código do Produto:";
            // 
            // txtCodEst
            // 
            this.txtCodEst.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEst.Location = new System.Drawing.Point(296, 52);
            this.txtCodEst.Name = "txtCodEst";
            this.txtCodEst.Size = new System.Drawing.Size(201, 31);
            this.txtCodEst.TabIndex = 110;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 65);
            this.button1.TabIndex = 112;
            this.button1.Text = "Consultar Estoque ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControledeEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1067, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodEst);
            this.Controls.Add(this.btnCadEst);
            this.Controls.Add(this.btnConsuEst);
            this.Controls.Add(this.btnSelectPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsultProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantProd);
            this.Controls.Add(this.txtestmin);
            this.Name = "ControledeEstoque";
            this.Text = "ControledeEstoque";
            this.Load += new System.EventHandler(this.ControledeEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantProd;
        private System.Windows.Forms.TextBox txtestmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultProd;
        private System.Windows.Forms.Button btnSelectPro;
        private System.Windows.Forms.Button btnCadEst;
        private System.Windows.Forms.Button btnConsuEst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodEst;
        private System.Windows.Forms.Button button1;
    }
}