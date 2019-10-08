using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Library.Controls.Btn
{
    public partial class Btn : Button
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
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(14, 33);
            this.Size = new System.Drawing.Size(123, 29);
            this.TabIndex = 2;
            this.UseVisualStyleBackColor = false;
            this.MouseHoverBackColor = Color.FromArgb(46, 166, 48);
            this.MouseHoverForeColor = Color.White;
            this.MouseLeaveForeColor = Color.Black;
            this.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.MouseHover += new System.EventHandler(this.btn_MouseHover);
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            this.FlatAppearance.MouseOverBackColor = MouseHoverBackColor;
            this.ForeColor = MouseHoverForeColor;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.ForeColor = MouseLeaveForeColor;
        }
    }
}
