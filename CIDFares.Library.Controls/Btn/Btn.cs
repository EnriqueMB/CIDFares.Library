using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace CIDFares.Library.Controls.Btn
{
    public partial class Btn : ButtonAdv
    {
        public Color MouseHoverBackColor { get; set; }
        public Color MouseHoverForeColor { get; set; }
        public Color MouseLeaveForeColor { get; set; }
        public Btn()
        {
            InitializeComponent();
            this.Inicial();
        }
        private void Inicial()
        {
            this.BackColor = System.Drawing.Color.White;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(176, 209);
            this.Size = new System.Drawing.Size(110, 29);
            this.MouseHoverBackColor = Color.FromArgb(46, 166, 48);
            this.MouseHoverForeColor = Color.White;
            this.MouseLeaveForeColor = Color.Black;
            this.MouseLeave += new System.EventHandler(this.buttonAdv1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.buttonAdv1_MouseHover);
        }
        private void buttonAdv1_MouseHover(object sender, EventArgs e)
        {
            this.FlatAppearance.MouseOverBackColor = MouseHoverBackColor;
            this.ForeColor = MouseHoverForeColor;
        }

        private void buttonAdv1_MouseLeave(object sender, EventArgs e)
        {
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.ForeColor = MouseLeaveForeColor;
        }
    }
}
