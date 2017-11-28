namespace Snake
{
    partial class Menu
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
            this.b_about = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.lb_Menu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_hr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r_classic = new System.Windows.Forms.RadioButton();
            this.r_foot = new System.Windows.Forms.RadioButton();
            this.r_mine = new System.Windows.Forms.RadioButton();
            this.b_game = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_about
            // 
            this.b_about.Location = new System.Drawing.Point(96, 242);
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(143, 46);
            this.b_about.TabIndex = 2;
            this.b_about.Text = "About";
            this.b_about.UseVisualStyleBackColor = true;
            this.b_about.Click += new System.EventHandler(this.b_about_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(96, 314);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(143, 46);
            this.b_exit.TabIndex = 3;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // lb_Menu
            // 
            this.lb_Menu.AutoSize = true;
            this.lb_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Menu.Location = new System.Drawing.Point(127, 22);
            this.lb_Menu.Name = "lb_Menu";
            this.lb_Menu.Size = new System.Drawing.Size(112, 37);
            this.lb_Menu.TabIndex = 4;
            this.lb_Menu.Text = "Snake";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Snake.Properties.Resources.snake;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 59);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lb_hr
            // 
            this.lb_hr.AutoSize = true;
            this.lb_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hr.Location = new System.Drawing.Point(-8, 75);
            this.lb_hr.Name = "lb_hr";
            this.lb_hr.Size = new System.Drawing.Size(352, 13);
            this.lb_hr.TabIndex = 6;
            this.lb_hr.Text = "                                                                                 " +
    "                                  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose a Game :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "                                                                                 " +
    "           ";
            // 
            // r_classic
            // 
            this.r_classic.AutoSize = true;
            this.r_classic.Location = new System.Drawing.Point(36, 138);
            this.r_classic.Name = "r_classic";
            this.r_classic.Size = new System.Drawing.Size(58, 17);
            this.r_classic.TabIndex = 9;
            this.r_classic.TabStop = true;
            this.r_classic.Text = "Classic";
            this.r_classic.UseVisualStyleBackColor = true;
            this.r_classic.CheckedChanged += new System.EventHandler(this.r_classic_CheckedChanged);
            // 
            // r_foot
            // 
            this.r_foot.AutoSize = true;
            this.r_foot.Location = new System.Drawing.Point(121, 139);
            this.r_foot.Name = "r_foot";
            this.r_foot.Size = new System.Drawing.Size(84, 17);
            this.r_foot.TabIndex = 10;
            this.r_foot.TabStop = true;
            this.r_foot.Text = "Football field";
            this.r_foot.UseVisualStyleBackColor = true;
            this.r_foot.CheckedChanged += new System.EventHandler(this.r_foot_CheckedChanged);
            // 
            // r_mine
            // 
            this.r_mine.AutoSize = true;
            this.r_mine.Location = new System.Drawing.Point(231, 138);
            this.r_mine.Name = "r_mine";
            this.r_mine.Size = new System.Drawing.Size(88, 17);
            this.r_mine.TabIndex = 11;
            this.r_mine.TabStop = true;
            this.r_mine.Text = "Minesweeper";
            this.r_mine.UseVisualStyleBackColor = true;
            this.r_mine.CheckedChanged += new System.EventHandler(this.r_mine_CheckedChanged);
            // 
            // b_game
            // 
            this.b_game.Location = new System.Drawing.Point(96, 175);
            this.b_game.Name = "b_game";
            this.b_game.Size = new System.Drawing.Size(143, 46);
            this.b_game.TabIndex = 12;
            this.b_game.Text = "New game";
            this.b_game.UseVisualStyleBackColor = true;
            this.b_game.Click += new System.EventHandler(this.b_game_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 372);
            this.Controls.Add(this.b_game);
            this.Controls.Add(this.r_mine);
            this.Controls.Add(this.r_foot);
            this.Controls.Add(this.r_classic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_hr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Menu);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_about);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_about;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label lb_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_hr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton r_classic;
        private System.Windows.Forms.RadioButton r_foot;
        private System.Windows.Forms.RadioButton r_mine;
        private System.Windows.Forms.Button b_game;
    }
}