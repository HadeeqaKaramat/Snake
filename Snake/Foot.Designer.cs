namespace Snake
{
    partial class Foot
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
            this.pbfoot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoot)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfoot
            // 
            this.pbfoot.Location = new System.Drawing.Point(13, 13);
            this.pbfoot.Name = "pbfoot";
            this.pbfoot.Size = new System.Drawing.Size(500, 625);
            this.pbfoot.TabIndex = 0;
            this.pbfoot.TabStop = false;
            // 
            // Foot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 652);
            this.Controls.Add(this.pbfoot);
            this.Name = "Foot";
            this.Text = "Foot";
            ((System.ComponentModel.ISupportInitialize)(this.pbfoot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbfoot;
    }
}