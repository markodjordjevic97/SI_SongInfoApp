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
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGenre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPerformer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRating = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lblIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(246, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(575, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Red;
            this.lblGenre.Location = new System.Drawing.Point(246, 51);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(210, 30);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            // 
            // lblPerformer
            // 
            this.lblPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformer.Location = new System.Drawing.Point(242, 106);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(214, 34);
            this.lblPerformer.TabIndex = 3;
            this.lblPerformer.Text = "Perfomer";
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(780, 106);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(110, 34);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Rating";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblIcon);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 153);
            this.panel1.TabIndex = 7;
            // 
            // SongCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblPerformer);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "SongCard";
            this.Size = new System.Drawing.Size(933, 153);
            ((System.ComponentModel.ISupportInitialize)(this.lblIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGenre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPerformer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRating;
        private System.Windows.Forms.PictureBox lblIcon;
        private System.Windows.Forms.Panel panel1;
    }
}
