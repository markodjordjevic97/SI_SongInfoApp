namespace PresentationLayer
{
    partial class SongCard
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
            this.lblPerformer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRating = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IconBackColor = new System.Windows.Forms.Panel();
            this.lblIcon = new System.Windows.Forms.PictureBox();
            this.lblIconRating = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGenre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IconBackColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIconRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerformer
            // 
            this.lblPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformer.Location = new System.Drawing.Point(249, 106);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(214, 34);
            this.lblPerformer.TabIndex = 3;
            this.lblPerformer.Text = "Perfomer";
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(946, 106);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(110, 34);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Rating";
            // 
            // IconBackColor
            // 
            this.IconBackColor.BackColor = System.Drawing.Color.Transparent;
            this.IconBackColor.Controls.Add(this.lblIcon);
            this.IconBackColor.ForeColor = System.Drawing.Color.Maroon;
            this.IconBackColor.Location = new System.Drawing.Point(0, 0);
            this.IconBackColor.Name = "IconBackColor";
            this.IconBackColor.Size = new System.Drawing.Size(197, 153);
            this.IconBackColor.TabIndex = 7;
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon.Location = new System.Drawing.Point(45, 32);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(102, 90);
            this.lblIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblIcon.TabIndex = 6;
            this.lblIcon.TabStop = false;
            // 
            // lblIconRating
            // 
            this.lblIconRating.Location = new System.Drawing.Point(899, 106);
            this.lblIconRating.Name = "lblIconRating";
            this.lblIconRating.Size = new System.Drawing.Size(41, 30);
            this.lblIconRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblIconRating.TabIndex = 8;
            this.lblIconRating.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(2, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 1);
            this.panel1.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 37);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(255, 61);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(66, 25);
            this.lblGenre.TabIndex = 11;
            this.lblGenre.Text = "Genre";
            // 
            // SongCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIconRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblPerformer);
            this.Controls.Add(this.IconBackColor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "SongCard";
            this.Size = new System.Drawing.Size(1070, 153);
            this.Load += new System.EventHandler(this.SongCard_Load);
            this.MouseEnter += new System.EventHandler(this.SongCard_MouseEnter_1);
            this.IconBackColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIconRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblPerformer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRating;
        private System.Windows.Forms.PictureBox lblIcon;
        private System.Windows.Forms.Panel IconBackColor;
        private System.Windows.Forms.PictureBox lblIconRating;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGenre;
    }
}
