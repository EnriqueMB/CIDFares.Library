using CIDFares.Library.Controls.Properties;
using System.Drawing;

namespace CIDFares.Library.Controls.CIDDataGridsf
{
    partial class DataGridsf
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // sfDataGrid
            // 
            this.AccessibleName = "Table";
            this.AllowDraggingColumns = true;
            this.AllowEditing = false;
            this.AllowFiltering = true;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoExpandGroups = true;
            this.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Location = new System.Drawing.Point(7, 5);
            this.Name = "dataGridMain1";
            this.RowHeight = 21;
            this.ShowGroupDropArea = true;
            this.Size = new System.Drawing.Size(792, 382);
            this.TabIndex = 1;

            this.GroupPanel.GroupDropAreaText = "";
            this.TableControl.BackColor = Color.FromArgb(250, 252, 251);
            this.Style.GroupDropAreaStyle.BackColor = Color.FromArgb(250, 252, 251);
            this.Style.GroupDropAreaStyle.TextColor = Color.Black;
            this.Style.GroupDropAreaItemStyle.TextColor = Color.Black;
            this.Style.GroupDropAreaItemStyle.BackColor = Color.FromArgb(250, 252, 251);
            this.BackColor = Color.FromArgb(250, 252, 251);
            this.Style.CellStyle.TextColor = Color.Black;
            this.Style.HeaderStyle.BackColor = Color.FromArgb(250, 252, 251);
            this.Style.HeaderStyle.Font.Bold = false;

            this.Style.GroupDropAreaItemStyle.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            this.Style.GroupDropAreaItemStyle.TextColor = ColorTranslator.FromHtml("#000000");
            this.Style.HeaderStyle.BackColor = ColorTranslator.FromHtml("#2EA630");
            this.Style.HeaderStyle.TextColor = ColorTranslator.FromHtml("#ffffff");

            this.Style.IndentCellStyle.BackColor = Color.FromArgb(250, 252, 251);

            this.Style.HeaderStyle.FilterIcon = new Bitmap(Resources.filtroblanco);

            this.Style.HeaderStyle.HoverBackColor = ColorTranslator.FromHtml("#234017");
            this.Style.HeaderStyle.HoverTextColor = ColorTranslator.FromHtml("#ffffff");
        }

        #endregion
    }
}