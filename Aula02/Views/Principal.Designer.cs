namespace Aula02.Views
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPedidos = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader("(none)");
            this.colProduto = new System.Windows.Forms.ColumnHeader();
            this.colQuantidade = new System.Windows.Forms.ColumnHeader();
            this.colValor = new System.Windows.Forms.ColumnHeader();
            this.colFornecedor = new System.Windows.Forms.ColumnHeader();
            this.colData = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtFornecedor);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Pedido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bruno Henrique Martinez";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(383, 404);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 29);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.Location = new System.Drawing.Point(290, 404);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 29);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(197, 404);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 29);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(11, 404);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 29);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(104, 404);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 29);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(0, 332);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(480, 27);
            this.txtData.TabIndex = 5;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(0, 279);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(480, 27);
            this.txtFornecedor.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(0, 226);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(480, 27);
            this.txtValor.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(0, 173);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(480, 27);
            this.txtQuantidade.TabIndex = 2;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(0, 120);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(480, 27);
            this.txtProduto.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(0, 67);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(486, 27);
            this.txtId.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstPedidos);
            this.groupBox2.Location = new System.Drawing.Point(512, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 512);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Pedidos";
            // 
            // lstPedidos
            // 
            this.lstPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colProduto,
            this.colQuantidade,
            this.colValor,
            this.colFornecedor,
            this.colData});
            this.lstPedidos.FullRowSelect = true;
            this.lstPedidos.GridLines = true;
            this.lstPedidos.HideSelection = false;
            this.lstPedidos.Location = new System.Drawing.Point(6, 26);
            this.lstPedidos.MultiSelect = false;
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(474, 480);
            this.lstPedidos.TabIndex = 0;
            this.lstPedidos.UseCompatibleStateImageBehavior = false;
            this.lstPedidos.View = System.Windows.Forms.View.Details;
            this.lstPedidos.SelectedIndexChanged += new System.EventHandler(this.lstPedidos_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Name = "colId";
            this.colId.Text = "   #";
            this.colId.Width = 40;
            // 
            // colProduto
            // 
            this.colProduto.Name = "colProduto";
            this.colProduto.Text = "Produto";
            this.colProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colProduto.Width = 85;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Text = "Quantidade";
            this.colQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQuantidade.Width = 90;
            // 
            // colValor
            // 
            this.colValor.Name = "colValor";
            this.colValor.Text = "Valor";
            this.colValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colValor.Width = 80;
            // 
            // colFornecedor
            // 
            this.colFornecedor.Name = "colFornecedor";
            this.colFornecedor.Text = "Fornecedor";
            this.colFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFornecedor.Width = 90;
            // 
            // colData
            // 
            this.colData.Name = "colData";
            this.colData.Text = "Data";
            this.colData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colData.Width = 85;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstPedidos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colProduto;
        private System.Windows.Forms.ColumnHeader colQuantidade;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colFornecedor;
        private System.Windows.Forms.ColumnHeader colData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
    }
}