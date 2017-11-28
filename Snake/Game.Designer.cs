namespace Snake
{
    partial class Game
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
            this.b_close = new System.Windows.Forms.Button();
            this.l_score = new System.Windows.Forms.Label();
            this.b_game = new System.Windows.Forms.Button();
            this.pbSnake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // b_close
            // 
            this.b_close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_close.ForeColor = System.Drawing.Color.Transparent;
            this.b_close.Location = new System.Drawing.Point(561, 376);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(121, 46);
            this.b_close.TabIndex = 2;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = false;
            this.b_close.Visible = false;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // l_score
            // 
            this.l_score.AutoSize = true;
            this.l_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_score.Location = new System.Drawing.Point(565, 177);
            this.l_score.Name = "l_score";
            this.l_score.Size = new System.Drawing.Size(107, 25);
            this.l_score.TabIndex = 3;
            this.l_score.Text = "Score : 0";
            // 
            // b_game
            // 
            this.b_game.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_game.ForeColor = System.Drawing.Color.Transparent;
            this.b_game.Location = new System.Drawing.Point(561, 261);
            this.b_game.Name = "b_game";
            this.b_game.Size = new System.Drawing.Size(121, 46);
            this.b_game.TabIndex = 1;
            this.b_game.Text = "Return to the Menu";
            this.b_game.UseVisualStyleBackColor = false;
            this.b_game.Visible = false;
            this.b_game.Click += new System.EventHandler(this.b_game_Click);
            // 
            // pbSnake
            // 
            this.pbSnake.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSnake.Location = new System.Drawing.Point(13, 13);
            this.pbSnake.Margin = new System.Windows.Forms.Padding(4);
            this.pbSnake.Name = "pbSnake";
            this.pbSnake.Size = new System.Drawing.Size(500, 625);
            this.pbSnake.TabIndex = 0;
            this.pbSnake.TabStop = false;
            this.pbSnake.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSnake_Paint);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 652);
            this.Controls.Add(this.l_score);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_game);
            this.Controls.Add(this.pbSnake);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSnake;
        private System.Windows.Forms.Button b_game;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Label l_score;
    }
}