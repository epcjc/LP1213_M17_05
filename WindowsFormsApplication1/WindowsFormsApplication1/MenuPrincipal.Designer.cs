namespace WindowsFormsApplication1
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAlterarEEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarRestauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificação5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.críticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCriticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirCriticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurantesToolStripMenuItem,
            this.críticaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restaurantesToolStripMenuItem
            // 
            this.restaurantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirAlterarEEliminarToolStripMenuItem,
            this.pesquisarRestauranteToolStripMenuItem,
            this.classificação5ToolStripMenuItem});
            this.restaurantesToolStripMenuItem.Name = "restaurantesToolStripMenuItem";
            this.restaurantesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.restaurantesToolStripMenuItem.Text = "Restaurantes";
            // 
            // inserirAlterarEEliminarToolStripMenuItem
            // 
            this.inserirAlterarEEliminarToolStripMenuItem.Name = "inserirAlterarEEliminarToolStripMenuItem";
            this.inserirAlterarEEliminarToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inserirAlterarEEliminarToolStripMenuItem.Text = "Inserir, Alterar e Eliminar";
            this.inserirAlterarEEliminarToolStripMenuItem.Click += new System.EventHandler(this.inserirAlterarEEliminarToolStripMenuItem_Click);
            // 
            // pesquisarRestauranteToolStripMenuItem
            // 
            this.pesquisarRestauranteToolStripMenuItem.Name = "pesquisarRestauranteToolStripMenuItem";
            this.pesquisarRestauranteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.pesquisarRestauranteToolStripMenuItem.Text = "Pesquisar Restaurante";
            this.pesquisarRestauranteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarRestauranteToolStripMenuItem_Click);
            // 
            // classificação5ToolStripMenuItem
            // 
            this.classificação5ToolStripMenuItem.Name = "classificação5ToolStripMenuItem";
            this.classificação5ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.classificação5ToolStripMenuItem.Text = "Classificação 5";
            this.classificação5ToolStripMenuItem.Click += new System.EventHandler(this.classificação5ToolStripMenuItem_Click);
            // 
            // críticaToolStripMenuItem
            // 
            this.críticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCriticasToolStripMenuItem,
            this.inserirCriticaToolStripMenuItem});
            this.críticaToolStripMenuItem.Name = "críticaToolStripMenuItem";
            this.críticaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.críticaToolStripMenuItem.Text = "Crítica";
            // 
            // listarCriticasToolStripMenuItem
            // 
            this.listarCriticasToolStripMenuItem.Name = "listarCriticasToolStripMenuItem";
            this.listarCriticasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarCriticasToolStripMenuItem.Text = "Listar Criticas";
            this.listarCriticasToolStripMenuItem.Click += new System.EventHandler(this.listarCriticasToolStripMenuItem_Click);
            // 
            // inserirCriticaToolStripMenuItem
            // 
            this.inserirCriticaToolStripMenuItem.Name = "inserirCriticaToolStripMenuItem";
            this.inserirCriticaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inserirCriticaToolStripMenuItem.Text = "Inserir Critica";
            this.inserirCriticaToolStripMenuItem.Click += new System.EventHandler(this.inserirCriticaToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirAlterarEEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarRestauranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificação5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem críticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCriticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirCriticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}