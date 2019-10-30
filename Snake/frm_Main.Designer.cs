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
            this.PanelEnd = new System.Windows.Forms.Panel();
            this.PicPlayAgain = new System.Windows.Forms.PictureBox();
            this.PanelEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayAgain)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEnd
            // 
            this.PanelEnd.BackColor = System.Drawing.Color.Transparent;
            this.PanelEnd.Controls.Add(this.PicPlayAgain);
            this.PanelEnd.Location = new System.Drawing.Point(11, 12);
            this.PanelEnd.Name = "PanelEnd";
            this.PanelEnd.Size = new System.Drawing.Size(85, 56);
            this.PanelEnd.TabIndex = 0;
            // 
            // PicPlayAgain
            // 
            this.PicPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayAgain.Image = global::Snake.Properties.Resources.game_over;
            this.PicPlayAgain.Location = new System.Drawing.Point(246, 93);
            this.PicPlayAgain.Name = "PicPlayAgain";
            this.PicPlayAgain.Size = new System.Drawing.Size(225, 225);
            this.PicPlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPlayAgain.TabIndex = 0;
            this.PicPlayAgain.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.PanelEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.PanelEnd.ResumeLayout(false);
            this.PanelEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayAgain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEnd;
        private System.Windows.Forms.PictureBox PicPlayAgain;
    }
}

