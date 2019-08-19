namespace CIDFares.Library.Controls.CIDMessageBox.Forms
{
    partial class FrmMessageBox
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
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSi = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.ptBIcono = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.TxtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.ForeColor = System.Drawing.Color.White;
            this.TxtTitulo.Location = new System.Drawing.Point(0, 0);
            this.TxtTitulo.Multiline = true;
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.ReadOnly = true;
            this.TxtTitulo.Size = new System.Drawing.Size(412, 23);
            this.TxtTitulo.TabIndex = 8;
            this.TxtTitulo.Text = "¿Estas seguro de cancelar esta operación?\r\n\r\n";
            this.TxtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSi);
            this.flowLayoutPanel1.Controls.Add(this.BtnConfirmar);
            this.flowLayoutPanel1.Controls.Add(this.BtnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(412, 43);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(101)))));
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.White;
            this.btnSi.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSi.Location = new System.Drawing.Point(259, 13);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(130, 28);
            this.btnSi.TabIndex = 11;
            this.btnSi.Text = "Aceptar";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.BtnSi_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(101)))));
            this.BtnConfirmar.FlatAppearance.BorderSize = 0;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnConfirmar.Location = new System.Drawing.Point(123, 13);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(130, 28);
            this.BtnConfirmar.TabIndex = 15;
            this.BtnConfirmar.Text = "Si";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(259, 47);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 28);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "No";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOpcion);
            this.panel1.Controls.Add(this.ptBIcono);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 96);
            this.panel1.TabIndex = 10;
            // 
            // txtOpcion
            // 
            this.txtOpcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.txtOpcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcion.ForeColor = System.Drawing.Color.White;
            this.txtOpcion.Location = new System.Drawing.Point(98, 32);
            this.txtOpcion.Multiline = true;
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.ReadOnly = true;
            this.txtOpcion.Size = new System.Drawing.Size(216, 40);
            this.txtOpcion.TabIndex = 13;
            this.txtOpcion.Text = "¿Estas seguro de cancelar esta operación?\r\n\r\n";
            this.txtOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptBIcono
            // 
            this.ptBIcono.Location = new System.Drawing.Point(12, 6);
            this.ptBIcono.Name = "ptBIcono";
            this.ptBIcono.Size = new System.Drawing.Size(80, 80);
            this.ptBIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptBIcono.TabIndex = 12;
            this.ptBIcono.TabStop = false;
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(412, 162);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TxtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAlert";
            this.Load += new System.EventHandler(this.FrmMessageBox_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.PictureBox ptBIcono;
        public System.Windows.Forms.Button btnSi;
        public System.Windows.Forms.Button BtnConfirmar;
        public System.Windows.Forms.Button BtnCancelar;
    }
}