namespace CIDFares.Library.Controls.CIDDataGridsf
{
    partial class prueba
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.dataGridsf1 = new CIDFares.Library.Controls.CIDDataGridsf.DataGridsf();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsf1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridsf1
            // 
            this.dataGridsf1.AccessibleName = "Table";
            this.dataGridsf1.AllowDraggingColumns = true;
            this.dataGridsf1.AllowEditing = false;
            this.dataGridsf1.AllowFiltering = true;
            this.dataGridsf1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridsf1.AutoExpandGroups = true;
            this.dataGridsf1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dataGridsf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "Column1";
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Column2";
            gridTextColumn2.MappingName = "Column2";
            this.dataGridsf1.Columns.Add(gridTextColumn1);
            this.dataGridsf1.Columns.Add(gridTextColumn2);
            this.dataGridsf1.Location = new System.Drawing.Point(12, 36);
            this.dataGridsf1.Name = "dataGridsf1";
            this.dataGridsf1.RowHeight = 21;
            this.dataGridsf1.ShowGroupDropArea = true;
            this.dataGridsf1.Size = new System.Drawing.Size(792, 382);
            this.dataGridsf1.Style.CellStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsf1.Style.GroupDropAreaItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridsf1.Style.GroupDropAreaItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridsf1.Style.GroupDropAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsf1.Style.GroupDropAreaStyle.TextColor = System.Drawing.Color.Black;
            this.dataGridsf1.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridsf1.Style.HeaderStyle.Font.Bold = false;
            this.dataGridsf1.Style.HeaderStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.dataGridsf1.Style.HeaderStyle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsf1.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridsf1.Style.IndentCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dataGridsf1.TabIndex = 1;
            this.dataGridsf1.Text = "dataGridsf1";
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridsf1);
            this.Name = "prueba";
            this.Text = "prueba";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsf1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridsf dataGridsf1;
    }
}