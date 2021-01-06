namespace PresentationLayer
{
    partial class newsongs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newsongs));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRatingSort = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAZSort = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDateSort = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowListSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRatingSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAZSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDateSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.flowListSongs);
            this.bunifuGradientPanel1.Controls.Add(this.textBoxSearch);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(948, 633);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRatingSort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAZSort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDateSort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(228, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 100);
            this.panel1.TabIndex = 11;
            // 
            // btnRatingSort
            // 
            this.btnRatingSort.BackColor = System.Drawing.Color.Transparent;
            this.btnRatingSort.Image = ((System.Drawing.Image)(resources.GetObject("btnRatingSort.Image")));
            this.btnRatingSort.ImageActive = null;
            this.btnRatingSort.Location = new System.Drawing.Point(248, 16);
            this.btnRatingSort.Name = "btnRatingSort";
            this.btnRatingSort.Size = new System.Drawing.Size(38, 38);
            this.btnRatingSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRatingSort.TabIndex = 5;
            this.btnRatingSort.TabStop = false;
            this.btnRatingSort.Zoom = 10;
            this.btnRatingSort.Click += new System.EventHandler(this.btnRatingSort_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // btnAZSort
            // 
            this.btnAZSort.BackColor = System.Drawing.Color.Transparent;
            this.btnAZSort.Image = ((System.Drawing.Image)(resources.GetObject("btnAZSort.Image")));
            this.btnAZSort.ImageActive = null;
            this.btnAZSort.Location = new System.Drawing.Point(161, 16);
            this.btnAZSort.Name = "btnAZSort";
            this.btnAZSort.Size = new System.Drawing.Size(38, 38);
            this.btnAZSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAZSort.TabIndex = 4;
            this.btnAZSort.TabStop = false;
            this.btnAZSort.Zoom = 10;
            this.btnAZSort.Click += new System.EventHandler(this.btnAZSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(235, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rating";
            // 
            // btnDateSort
            // 
            this.btnDateSort.BackColor = System.Drawing.Color.Transparent;
            this.btnDateSort.Image = ((System.Drawing.Image)(resources.GetObject("btnDateSort.Image")));
            this.btnDateSort.ImageActive = null;
            this.btnDateSort.Location = new System.Drawing.Point(340, 17);
            this.btnDateSort.Name = "btnDateSort";
            this.btnDateSort.Size = new System.Drawing.Size(38, 38);
            this.btnDateSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDateSort.TabIndex = 6;
            this.btnDateSort.TabStop = false;
            this.btnDateSort.Zoom = 10;
            this.btnDateSort.Click += new System.EventHandler(this.btnDateSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "A-Z";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort By";
            // 
            // flowListSongs
            // 
            this.flowListSongs.AutoScroll = true;
            this.flowListSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.flowListSongs.Location = new System.Drawing.Point(3, 114);
            this.flowListSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowListSongs.Name = "flowListSongs";
            this.flowListSongs.Size = new System.Drawing.Size(957, 519);
            this.flowListSongs.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.textBoxSearch.BorderColorFocused = System.Drawing.Color.Transparent;
            this.textBoxSearch.BorderColorIdle = System.Drawing.Color.Transparent;
            this.textBoxSearch.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.textBoxSearch.BorderThickness = 3;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.White;
            this.textBoxSearch.isPassword = false;
            this.textBoxSearch.Location = new System.Drawing.Point(703, 38);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.textBoxSearch.Size = new System.Drawing.Size(210, 37);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.OnValueChanged += new System.EventHandler(this.textBoxSearch_OnValueChanged);
            // 
            // newsongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "newsongs";
            this.Size = new System.Drawing.Size(948, 633);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRatingSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAZSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDateSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxSearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FlowLayoutPanel flowListSongs;
        private SongCard songCard1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnDateSort;
        private Bunifu.Framework.UI.BunifuImageButton btnRatingSort;
        private Bunifu.Framework.UI.BunifuImageButton btnAZSort;
        private System.Windows.Forms.Panel panel1;
    }
}
