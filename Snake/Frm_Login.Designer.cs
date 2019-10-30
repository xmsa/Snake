namespace Snake
{
    partial class Frm_Login
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
            this.PicSnake2 = new System.Windows.Forms.PictureBox();
            this.PicSnake1 = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicSnake2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSnake1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicSnake2
            // 
            this.PicSnake2.Image = global::Snake.Properties.Resources.snake1;
            this.PicSnake2.Location = new System.Drawing.Point(12, 14);
            this.PicSnake2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PicSnake2.Name = "PicSnake2";
            this.PicSnake2.Size = new System.Drawing.Size(270, 295);
            this.PicSnake2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSnake2.TabIndex = 0;
            this.PicSnake2.TabStop = false;
            // 
            // PicSnake1
            // 
            this.PicSnake1.Image = global::Snake.Properties.Resources.snake2;
            this.PicSnake1.Location = new System.Drawing.Point(138, 146);
            this.PicSnake1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PicSnake1.Name = "PicSnake1";
            this.PicSnake1.Size = new System.Drawing.Size(28, 192);
            this.PicSnake1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSnake1.TabIndex = 1;
            this.PicSnake1.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(12, 323);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(120, 158);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(172, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 158);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 493);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PicSnake2);
            this.Controls.Add(this.PicSnake1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.PicSnake2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSnake1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicSnake2;
        private System.Windows.Forms.PictureBox PicSnake1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}