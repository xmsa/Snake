namespace Snake
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.PanelEnd = new System.Windows.Forms.Panel();
            this.Lbl_star = new System.Windows.Forms.Label();
            this.PicPlayAgain = new System.Windows.Forms.PictureBox();
            this.TimerSpeed = new System.Windows.Forms.Timer(this.components);
            this.TimerShiftFood = new System.Windows.Forms.Timer(this.components);
            this.Lblscore = new System.Windows.Forms.Label();
            this.PanelEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayAgain)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEnd
            // 
            this.PanelEnd.BackColor = System.Drawing.Color.Transparent;
            this.PanelEnd.Controls.Add(this.Lbl_star);
            this.PanelEnd.Controls.Add(this.PicPlayAgain);
            this.PanelEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEnd.Location = new System.Drawing.Point(0, 0);
            this.PanelEnd.Name = "PanelEnd";
            this.PanelEnd.Size = new System.Drawing.Size(704, 441);
            this.PanelEnd.TabIndex = 0;
            // 
            // Lbl_star
            // 
            this.Lbl_star.AutoSize = true;
            this.Lbl_star.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_star.Location = new System.Drawing.Point(323, 240);
            this.Lbl_star.Name = "Lbl_star";
            this.Lbl_star.Size = new System.Drawing.Size(63, 38);
            this.Lbl_star.TabIndex = 1;
            this.Lbl_star.Text = "label1";
            // 
            // PicPlayAgain
            // 
            this.PicPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayAgain.Image = global::Snake.Properties.Resources.game_over;
            this.PicPlayAgain.Location = new System.Drawing.Point(244, 12);
            this.PicPlayAgain.Name = "PicPlayAgain";
            this.PicPlayAgain.Size = new System.Drawing.Size(225, 225);
            this.PicPlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayAgain.TabIndex = 0;
            this.PicPlayAgain.TabStop = false;
            this.PicPlayAgain.Click += new System.EventHandler(this.PicPlayAgain_Click);
            // 
            // TimerSpeed
            // 
            this.TimerSpeed.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TimerShiftFood
            // 
            this.TimerShiftFood.Interval = 2000;
            this.TimerShiftFood.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Lblscore
            // 
            this.Lblscore.AutoSize = true;
            this.Lblscore.BackColor = System.Drawing.Color.Transparent;
            this.Lblscore.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblscore.ForeColor = System.Drawing.Color.Black;
            this.Lblscore.Location = new System.Drawing.Point(663, 417);
            this.Lblscore.Name = "Lblscore";
            this.Lblscore.Size = new System.Drawing.Size(19, 26);
            this.Lblscore.TabIndex = 1;
            this.Lblscore.Text = "0";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.PanelEnd);
            this.Controls.Add(this.Lblscore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Main_KeyDown);
            this.PanelEnd.ResumeLayout(false);
            this.PanelEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayAgain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PicPlayAgain;
        public System.Windows.Forms.Panel PanelEnd;
        public System.Windows.Forms.Timer TimerSpeed;
        public System.Windows.Forms.Timer TimerShiftFood;
        public System.Windows.Forms.Label Lbl_star;
        public System.Windows.Forms.Label Lblscore;
    }
}

