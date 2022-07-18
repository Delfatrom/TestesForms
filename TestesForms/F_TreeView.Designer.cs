namespace TestesForms
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Patins");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Moto");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Bicicleta");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("2 Rodas", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Carro");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("4 Rodas", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.btn_adicionarRaiz = new System.Windows.Forms.Button();
            this.btn_removerSelecionado = new System.Windows.Forms.Button();
            this.btn_adicionarFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(45, 40);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "patins";
            treeNode1.Text = "Patins";
            treeNode2.Name = "moto";
            treeNode2.Text = "Moto";
            treeNode3.Name = "bicicleta";
            treeNode3.Text = "Bicicleta";
            treeNode4.Name = "2rodas";
            treeNode4.Text = "2 Rodas";
            treeNode5.Name = "carro";
            treeNode5.Text = "Carro";
            treeNode6.Name = "4rodas";
            treeNode6.Text = "4 Rodas";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(130, 123);
            this.treeView1.TabIndex = 0;
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Location = new System.Drawing.Point(181, 98);
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.Size = new System.Drawing.Size(157, 20);
            this.tb_veiculos.TabIndex = 1;
            // 
            // btn_adicionarRaiz
            // 
            this.btn_adicionarRaiz.Location = new System.Drawing.Point(181, 40);
            this.btn_adicionarRaiz.Name = "btn_adicionarRaiz";
            this.btn_adicionarRaiz.Size = new System.Drawing.Size(157, 23);
            this.btn_adicionarRaiz.TabIndex = 2;
            this.btn_adicionarRaiz.Text = "Adicionar Raiz";
            this.btn_adicionarRaiz.UseVisualStyleBackColor = true;
            this.btn_adicionarRaiz.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_removerSelecionado
            // 
            this.btn_removerSelecionado.Location = new System.Drawing.Point(181, 124);
            this.btn_removerSelecionado.Name = "btn_removerSelecionado";
            this.btn_removerSelecionado.Size = new System.Drawing.Size(157, 23);
            this.btn_removerSelecionado.TabIndex = 2;
            this.btn_removerSelecionado.Text = "Remover Selecionado";
            this.btn_removerSelecionado.UseVisualStyleBackColor = true;
            this.btn_removerSelecionado.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_adicionarFilho
            // 
            this.btn_adicionarFilho.Location = new System.Drawing.Point(181, 69);
            this.btn_adicionarFilho.Name = "btn_adicionarFilho";
            this.btn_adicionarFilho.Size = new System.Drawing.Size(157, 23);
            this.btn_adicionarFilho.TabIndex = 2;
            this.btn_adicionarFilho.Text = "Adicionar Filho";
            this.btn_adicionarFilho.UseVisualStyleBackColor = true;
            this.btn_adicionarFilho.Click += new System.EventHandler(this.btn_adicionarFilho_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 220);
            this.Controls.Add(this.btn_removerSelecionado);
            this.Controls.Add(this.btn_adicionarFilho);
            this.Controls.Add(this.btn_adicionarRaiz);
            this.Controls.Add(this.tb_veiculos);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_TreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tb_veiculos;
        private System.Windows.Forms.Button btn_adicionarRaiz;
        private System.Windows.Forms.Button btn_removerSelecionado;
        private System.Windows.Forms.Button btn_adicionarFilho;
    }
}