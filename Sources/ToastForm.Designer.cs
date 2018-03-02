namespace spotifytoaster
{
    partial class ToastForm
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
            this.albumArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // albumArt
            // 
            this.albumArt.Image = global::spotifytoaster.Properties.Resources.album_missing;
            this.albumArt.InitialImage = null;
            this.albumArt.Location = new System.Drawing.Point(15, 15);
            this.albumArt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(96, 98);
            this.albumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumArt.TabIndex = 3;
            this.albumArt.TabStop = false;
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(544, 129);
            this.Controls.Add(this.albumArt);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ToastForm";
            this.ShowInTaskbar = false;
            this.Text = "ToastForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onExit);
            this.VisibleChanged += new System.EventHandler(this.toastVisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox albumArt;
    }
}