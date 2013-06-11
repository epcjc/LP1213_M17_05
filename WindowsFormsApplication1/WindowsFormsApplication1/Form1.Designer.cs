namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAlterarEEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarRestauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificação5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.críticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCriticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurantesToolStripMenuItem,
            this.críticaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restaurantesToolStripMenuItem
            // 
            this.restaurantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirAlterarEEliminarToolStripMenuItem,
            this.pesquisarRestauranteToolStripMenuItem,
            this.classificação5ToolStripMenuItem,
            this.inserirToolStripMenuItem});
            this.restaurantesToolStripMenuItem.Name = "restaurantesToolStripMenuItem";
            this.restaurantesToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.restaurantesToolStripMenuItem.Text = "Selos";
            // 
            // inserirAlterarEEliminarToolStripMenuItem
            // 
            this.inserirAlterarEEliminarToolStripMenuItem.Name = "inserirAlterarEEliminarToolStripMenuItem";
            this.inserirAlterarEEliminarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.inserirAlterarEEliminarToolStripMenuItem.Text = "Alterar e Eliminar";
            this.inserirAlterarEEliminarToolStripMenuItem.Click += new System.EventHandler(this.inserirAlterarEEliminarToolStripMenuItem_Click);
            // 
            // pesquisarRestauranteToolStripMenuItem
            // 
            this.pesquisarRestauranteToolStripMenuItem.Name = "pesquisarRestauranteToolStripMenuItem";
            this.pesquisarRestauranteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pesquisarRestauranteToolStripMenuItem.Text = "Pesquisar Selo";
            this.pesquisarRestauranteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarRestauranteToolStripMenuItem_Click);
            // 
            // classificação5ToolStripMenuItem
            // 
            this.classificação5ToolStripMenuItem.Name = "classificação5ToolStripMenuItem";
            this.classificação5ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.classificação5ToolStripMenuItem.Text = "Listar";
            this.classificação5ToolStripMenuItem.Click += new System.EventHandler(this.classificação5ToolStripMenuItem_Click);
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // críticaToolStripMenuItem
            // 
            this.críticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCriticasToolStripMenuItem});
            this.críticaToolStripMenuItem.Name = "críticaToolStripMenuItem";
            this.críticaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.críticaToolStripMenuItem.Text = "Coleção";
            // 
            // listarCriticasToolStripMenuItem
            // 
            this.listarCriticasToolStripMenuItem.Name = "listarCriticasToolStripMenuItem";
            this.listarCriticasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarCriticasToolStripMenuItem.Text = "Listar Coleção";
            this.listarCriticasToolStripMenuItem.Click += new System.EventHandler(this.listarCriticasToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(666, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Menu ";
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}