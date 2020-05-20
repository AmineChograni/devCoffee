namespace devCoffee
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cocktail = new System.Windows.Forms.Button();
            this.btn_chocolat = new System.Windows.Forms.Button();
            this.btn_jusDorange = new System.Windows.Forms.Button();
            this.btn_jusDePomme = new System.Windows.Forms.Button();
            this.btn_leauGazouse = new System.Windows.Forms.Button();
            this.btn_cafe = new System.Windows.Forms.Button();
            this.btn_the = new System.Windows.Forms.Button();
            this.btn_lait = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(472, 54);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(207, 60);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "devCoffee";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_cocktail, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_chocolat, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_jusDorange, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_jusDePomme, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_leauGazouse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_cafe, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_the, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_lait, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 314);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_cocktail
            // 
            this.btn_cocktail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cocktail.BackgroundImage")));
            this.btn_cocktail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cocktail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cocktail.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cocktail.Location = new System.Drawing.Point(704, 212);
            this.btn_cocktail.Name = "btn_cocktail";
            this.btn_cocktail.Size = new System.Drawing.Size(341, 96);
            this.btn_cocktail.TabIndex = 8;
            this.btn_cocktail.Text = "Cocktail";
            this.btn_cocktail.UseVisualStyleBackColor = true;
            // 
            // btn_chocolat
            // 
            this.btn_chocolat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chocolat.BackgroundImage")));
            this.btn_chocolat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chocolat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_chocolat.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chocolat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_chocolat.Location = new System.Drawing.Point(355, 212);
            this.btn_chocolat.Name = "btn_chocolat";
            this.btn_chocolat.Size = new System.Drawing.Size(340, 96);
            this.btn_chocolat.TabIndex = 6;
            this.btn_chocolat.Text = "Chocolat";
            this.btn_chocolat.UseVisualStyleBackColor = true;
            // 
            // btn_jusDorange
            // 
            this.btn_jusDorange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_jusDorange.BackgroundImage")));
            this.btn_jusDorange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_jusDorange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_jusDorange.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jusDorange.Location = new System.Drawing.Point(704, 109);
            this.btn_jusDorange.Name = "btn_jusDorange";
            this.btn_jusDorange.Size = new System.Drawing.Size(341, 94);
            this.btn_jusDorange.TabIndex = 5;
            this.btn_jusDorange.Text = "Jus d\'orange";
            this.btn_jusDorange.UseVisualStyleBackColor = true;
            // 
            // btn_jusDePomme
            // 
            this.btn_jusDePomme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_jusDePomme.BackgroundImage")));
            this.btn_jusDePomme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_jusDePomme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_jusDePomme.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jusDePomme.Location = new System.Drawing.Point(355, 109);
            this.btn_jusDePomme.Name = "btn_jusDePomme";
            this.btn_jusDePomme.Size = new System.Drawing.Size(340, 94);
            this.btn_jusDePomme.TabIndex = 4;
            this.btn_jusDePomme.Text = "Jus de pomme";
            this.btn_jusDePomme.UseVisualStyleBackColor = true;
            // 
            // btn_leauGazouse
            // 
            this.btn_leauGazouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_leauGazouse.BackgroundImage")));
            this.btn_leauGazouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_leauGazouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_leauGazouse.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leauGazouse.Location = new System.Drawing.Point(6, 109);
            this.btn_leauGazouse.Name = "btn_leauGazouse";
            this.btn_leauGazouse.Size = new System.Drawing.Size(340, 94);
            this.btn_leauGazouse.TabIndex = 3;
            this.btn_leauGazouse.Text = "L\'eau gazeuse";
            this.btn_leauGazouse.UseVisualStyleBackColor = true;
            // 
            // btn_cafe
            // 
            this.btn_cafe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cafe.BackgroundImage")));
            this.btn_cafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cafe.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cafe.Location = new System.Drawing.Point(704, 6);
            this.btn_cafe.Name = "btn_cafe";
            this.btn_cafe.Size = new System.Drawing.Size(341, 94);
            this.btn_cafe.TabIndex = 2;
            this.btn_cafe.Text = "Café";
            this.btn_cafe.UseVisualStyleBackColor = true;
            // 
            // btn_the
            // 
            this.btn_the.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_the.BackgroundImage")));
            this.btn_the.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_the.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_the.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_the.Location = new System.Drawing.Point(355, 6);
            this.btn_the.Name = "btn_the";
            this.btn_the.Size = new System.Drawing.Size(340, 94);
            this.btn_the.TabIndex = 1;
            this.btn_the.Text = "Thé";
            this.btn_the.UseVisualStyleBackColor = true;
            // 
            // btn_lait
            // 
            this.btn_lait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_lait.BackgroundImage")));
            this.btn_lait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_lait.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lait.Location = new System.Drawing.Point(6, 6);
            this.btn_lait.Name = "btn_lait";
            this.btn_lait.Size = new System.Drawing.Size(340, 94);
            this.btn_lait.TabIndex = 0;
            this.btn_lait.Text = "Lait";
            this.btn_lait.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Mistral", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 96);
            this.button1.TabIndex = 9;
            this.button1.Text = "Soda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "devCoffe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_lait;
        private System.Windows.Forms.Button btn_cocktail;
        private System.Windows.Forms.Button btn_chocolat;
        private System.Windows.Forms.Button btn_jusDorange;
        private System.Windows.Forms.Button btn_jusDePomme;
        private System.Windows.Forms.Button btn_leauGazouse;
        private System.Windows.Forms.Button btn_cafe;
        private System.Windows.Forms.Button btn_the;
        private System.Windows.Forms.Button button1;
    }
}

