namespace WF_Livraria
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.bntCadastrarPedido = new System.Windows.Forms.Button();
            this.cbxLivros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPagamento = new System.Windows.Forms.ComboBox();
            this.cbxParcelas = new System.Windows.Forms.ComboBox();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxQuantidade = new System.Windows.Forms.ComboBox();
            this.btnListaPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(106, 93);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(327, 28);
            this.cbxClientes.TabIndex = 1;
            // 
            // bntCadastrarPedido
            // 
            this.bntCadastrarPedido.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntCadastrarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntCadastrarPedido.Location = new System.Drawing.Point(234, 272);
            this.bntCadastrarPedido.Name = "bntCadastrarPedido";
            this.bntCadastrarPedido.Size = new System.Drawing.Size(125, 60);
            this.bntCadastrarPedido.TabIndex = 2;
            this.bntCadastrarPedido.Text = "Enviar";
            this.bntCadastrarPedido.UseVisualStyleBackColor = false;
            this.bntCadastrarPedido.Click += new System.EventHandler(this.bntCadastrarPedido_Click);
            // 
            // cbxLivros
            // 
            this.cbxLivros.FormattingEnabled = true;
            this.cbxLivros.Location = new System.Drawing.Point(106, 153);
            this.cbxLivros.Name = "cbxLivros";
            this.cbxLivros.Size = new System.Drawing.Size(269, 28);
            this.cbxLivros.TabIndex = 1;
            this.cbxLivros.SelectedIndexChanged += new System.EventHandler(this.cbxLivros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Livros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pagamento:";
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.FormattingEnabled = true;
            this.cbxPagamento.Location = new System.Drawing.Point(145, 219);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(142, 28);
            this.cbxPagamento.TabIndex = 1;
            this.cbxPagamento.SelectedIndexChanged += new System.EventHandler(this.cbxPagamento_SelectedIndexChanged);
            // 
            // cbxParcelas
            // 
            this.cbxParcelas.FormattingEnabled = true;
            this.cbxParcelas.Location = new System.Drawing.Point(424, 219);
            this.cbxParcelas.Name = "cbxParcelas";
            this.cbxParcelas.Size = new System.Drawing.Size(76, 28);
            this.cbxParcelas.TabIndex = 1;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParcelas.Location = new System.Drawing.Point(324, 219);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(85, 28);
            this.lblParcelas.TabIndex = 5;
            this.lblParcelas.Text = "Parcelas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(238, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(381, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantidade:";
            // 
            // cbxQuantidade
            // 
            this.cbxQuantidade.FormattingEnabled = true;
            this.cbxQuantidade.Location = new System.Drawing.Point(506, 153);
            this.cbxQuantidade.Name = "cbxQuantidade";
            this.cbxQuantidade.Size = new System.Drawing.Size(94, 28);
            this.cbxQuantidade.TabIndex = 1;
            // 
            // btnListaPedidos
            // 
            this.btnListaPedidos.Location = new System.Drawing.Point(238, 352);
            this.btnListaPedidos.Name = "btnListaPedidos";
            this.btnListaPedidos.Size = new System.Drawing.Size(121, 60);
            this.btnListaPedidos.TabIndex = 8;
            this.btnListaPedidos.Text = "Lista Pedidos";
            this.btnListaPedidos.UseVisualStyleBackColor = true;
            this.btnListaPedidos.Click += new System.EventHandler(this.btnListaPedidos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 424);
            this.Controls.Add(this.btnListaPedidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntCadastrarPedido);
            this.Controls.Add(this.cbxQuantidade);
            this.Controls.Add(this.cbxParcelas);
            this.Controls.Add(this.cbxPagamento);
            this.Controls.Add(this.cbxLivros);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Button bntCadastrarPedido;
        private System.Windows.Forms.ComboBox cbxLivros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPagamento;
        private System.Windows.Forms.ComboBox cbxParcelas;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxQuantidade;
        private System.Windows.Forms.Button btnListaPedidos;
    }
}
