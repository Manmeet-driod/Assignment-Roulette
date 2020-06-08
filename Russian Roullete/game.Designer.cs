namespace Russian_Roullete
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.load = new System.Windows.Forms.Button();
            this.spin = new System.Windows.Forms.Button();
            this.shoot = new System.Windows.Forms.Button();
            this.Retrygame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Black;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.SandyBrown;
            this.load.Location = new System.Drawing.Point(18, 168);
            this.load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(190, 108);
            this.load.TabIndex = 1;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // spin
            // 
            this.spin.BackColor = System.Drawing.Color.Black;
            this.spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spin.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin.ForeColor = System.Drawing.Color.Yellow;
            this.spin.Location = new System.Drawing.Point(18, 541);
            this.spin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spin.Name = "spin";
            this.spin.Size = new System.Drawing.Size(190, 112);
            this.spin.TabIndex = 2;
            this.spin.Text = "Spin";
            this.spin.UseVisualStyleBackColor = false;
            this.spin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // shoot
            // 
            this.shoot.BackColor = System.Drawing.Color.Black;
            this.shoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoot.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot.ForeColor = System.Drawing.Color.SpringGreen;
            this.shoot.Location = new System.Drawing.Point(530, 562);
            this.shoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(197, 112);
            this.shoot.TabIndex = 3;
            this.shoot.Text = "Shoot";
            this.shoot.UseVisualStyleBackColor = false;
            this.shoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // Retrygame
            // 
            this.Retrygame.BackColor = System.Drawing.Color.Black;
            this.Retrygame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retrygame.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrygame.ForeColor = System.Drawing.Color.Tomato;
            this.Retrygame.Location = new System.Drawing.Point(1052, 562);
            this.Retrygame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Retrygame.Name = "Retrygame";
            this.Retrygame.Size = new System.Drawing.Size(198, 112);
            this.Retrygame.TabIndex = 5;
            this.Retrygame.Text = "Retry";
            this.Retrygame.UseVisualStyleBackColor = false;
            this.Retrygame.Click += new System.EventHandler(this.button5_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Plum;
            this.Exit.Location = new System.Drawing.Point(1078, 168);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 108);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 703);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Retrygame);
            this.Controls.Add(this.shoot);
            this.Controls.Add(this.spin);
            this.Controls.Add(this.load);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "game";
            this.Text = "Russian Game";
            this.Load += new System.EventHandler(this.game_Load);
            this.Click += new System.EventHandler(this.button5_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button spin;
        private System.Windows.Forms.Button shoot;
        private System.Windows.Forms.Button Retrygame;
        private System.Windows.Forms.Button Exit;
    }
}