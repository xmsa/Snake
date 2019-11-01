namespace Snake
{
    partial class Frm_Setting
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
            this.TrBarSpeed = new System.Windows.Forms.TrackBar();
            this.TrBarShiftFood = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarShiftFood)).BeginInit();
            this.SuspendLayout();
            // 
            // TrBarSpeed
            // 
            this.TrBarSpeed.Location = new System.Drawing.Point(12, 12);
            this.TrBarSpeed.Maximum = 19;
            this.TrBarSpeed.Minimum = 1;
            this.TrBarSpeed.Name = "TrBarSpeed";
            this.TrBarSpeed.Size = new System.Drawing.Size(324, 45);
            this.TrBarSpeed.TabIndex = 0;
            this.TrBarSpeed.Value = 10;
            this.TrBarSpeed.ValueChanged += new System.EventHandler(this.TrBarSpeed_ValueChanged);
            // 
            // TrBarShiftFood
            // 
            this.TrBarShiftFood.Location = new System.Drawing.Point(12, 116);
            this.TrBarShiftFood.Maximum = 19;
            this.TrBarShiftFood.Minimum = 1;
            this.TrBarShiftFood.Name = "TrBarShiftFood";
            this.TrBarShiftFood.Size = new System.Drawing.Size(324, 45);
            this.TrBarShiftFood.TabIndex = 0;
            this.TrBarShiftFood.Value = 10;
            this.TrBarShiftFood.ValueChanged += new System.EventHandler(this.TrBarShiftFood_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed: 10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shift Food: 10";
            // 
            // Speed
            // 
            this.Speed.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Uighur", 24F);
            this.BtnStart.Location = new System.Drawing.Point(41, 275);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(266, 37);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 324);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrBarShiftFood);
            this.Controls.Add(this.TrBarSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Setting";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.TrBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarShiftFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrBarSpeed;
        private System.Windows.Forms.TrackBar TrBarShiftFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Speed;
        private System.Windows.Forms.Button BtnStart;
    }
}