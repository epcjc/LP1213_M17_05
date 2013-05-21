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
            this.críticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCriticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirCriticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // restaurantesToolStripMenuItem
            // 
            this.restaurantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirAlterarEEliminarToolStripMenuItem,
            this.pesquisarRestauranteToolStripMenuItem,
            this.classificação5ToolStripMenuItem});
            this.restaurantesToolStripMenuItem.Name = "restaurantesToolStripMenuItem";
            this.restaurantesToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.restaurantesToolStripMenuItem.Text = "Selos";
            this.restaurantesToolStripMenuItem.Click += new System.EventHandler(this.restaurantesToolStripMenuItem_Click);
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
            this.pesquisarRestauranteToolStripMenuItem.Text = "Pesquisar Selo";
            this.pesquisarRestauranteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarseloToolStripMenuItem_Click);
            // 
            // classificação5ToolStripMenuItem
            // 
            this.classificação5ToolStripMenuItem.Name = "classificação5ToolStripMenuItem";
            this.classificação5ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.classificação5ToolStripMenuItem.Text = "Coleção";
            this.classificação5ToolStripMenuItem.Click += new System.EventHandler(this.classificação5ToolStripMenuItem_Click);
            // 
            // críticaToolStripMenuItem
            // 
            this.críticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCriticasToolStripMenuItem,
            this.inserirCriticaToolStripMenuItem});
            this.críticaToolStripMenuItem.Name = "críticaToolStripMenuItem";
            this.críticaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.críticaToolStripMenuItem.Text = "Coleção";
            this.críticaToolStripMenuItem.Click += new System.EventHandler(this.críticaToolStripMenuItem_Click);
            // 
            // listarCriticasToolStripMenuItem
            // 
            this.listarCriticasToolStripMenuItem.Name = "listarCriticasToolStripMenuItem";
            this.listarCriticasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarCriticasToolStripMenuItem.Text = "Listar Coleção";
            // 
            // inserirCriticaToolStripMenuItem
            // 
            this.inserirCriticaToolStripMenuItem.Name = "inserirCriticaToolStripMenuItem";
            this.inserirCriticaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inserirCriticaToolStripMenuItem.Text = "Inserir Coleção";
            this.inserirCriticaToolStripMenuItem.Click += new System.EventHandler(this.inserirCriticaToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(938, 505);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.monthCalendar1.TodayDate = new System.DateTime(2013, 5, 30, 0, 0, 0, 0);
            this.monthCalendar1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(90, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome de Utilizador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(455, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome de Utilizador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(483, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(367, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 20);
            this.textBox3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1181, 688);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

