using spotifytoaster.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spotifytoaster
{
    public partial class ToastOverlay : Form
    {
        public ToastOverlay()
        {
            InitializeComponent();
        }

        internal void initializeFormSettings(Options myOptions)
        {
            albumBox.ForeColor = myOptions.ToastForegroundColor;
            artistBox.ForeColor = myOptions.ToastForegroundColor;
            trackBox.ForeColor = myOptions.ToastForegroundColor;
        }
    }
    public partial class CustomLabel : Label
    {
        private TextRenderingHint _hint = TextRenderingHint.SingleBitPerPixelGridFit;
        public TextRenderingHint TextRenderingHint
        {
            get => this._hint;
            set => this._hint = value;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.TextRenderingHint = TextRenderingHint;
            base.OnPaint(pe);
        }
    }
}
