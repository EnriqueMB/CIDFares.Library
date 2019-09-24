using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Library.Controls.CIDencuestas
{
    public partial class FrmEncuesta : UserControl
    {
        #region Propiedades
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }

        #endregion

        #region Construcor
        public FrmEncuesta()
        {
            InitializeComponent();
            Pregunta = string.Empty;
            Respuesta = string.Empty;
        }
        #endregion

    }
}
