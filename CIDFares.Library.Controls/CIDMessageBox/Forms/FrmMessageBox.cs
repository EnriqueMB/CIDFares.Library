using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Library.Controls.CIDMessageBox.Forms
{
    public partial class FrmMessageBox : Form
    {

        #region Private properties

        private SoundPlayer sound = new SoundPlayer();

        #endregion

        #region Public properties

        public string Message { get; set; }
        public string Title { get; set; }
        public TypeMessage typeMessage { get; set; }

        #endregion

        #region Constructor

        public FrmMessageBox()
        {
            InitializeComponent();
            Message = string.Empty;
            Title = string.Empty;
        }

        #endregion

        #region Eventos

        private void FrmMessageBox_Load(object sender, System.EventArgs e)
        {
            TxtTitulo.Text = Title;
            txtOpcion.Text = Message;
            switch (typeMessage)
            {
                case TypeMessage.correcto:
                    ptBIcono.Image =  Properties.Resources.check;
                    this.Size = new Size(412, 140);
                    this.btnSi.Visible = true;
                    this.BtnCancelar.Visible = false;
                    this.BtnConfirmar.Visible = false;
                    sound.Stream = Properties.Resources.successuno;
                    sound.Play();
                    break;
                case TypeMessage.error:
                    ptBIcono.Image = Properties.Resources.eliminar;
                    this.Size = new Size(412, 140);
                    this.btnSi.Visible = true;
                    this.BtnCancelar.Visible = false;
                    this.BtnConfirmar.Visible = false;
                    sound.Stream = Properties.Resources.incorrect;
                    sound.Play();
                    break;
                case TypeMessage.informacion:
                    ptBIcono.Image = Properties.Resources.exclamaciontriangulo;
                    this.Size = new Size(412, 140);
                    this.btnSi.Visible = true;
                    this.BtnCancelar.Visible = false;
                    this.BtnConfirmar.Visible = false;
                    sound.Stream = Properties.Resources.Ding;
                    sound.Play();
                    break;
                case TypeMessage.confirmacion:
                    ptBIcono.Image = CIDFares.Library.Controls.Properties.Resources.informacion;
                    this.Size = new Size(412, 140);
                    this.btnSi.Visible = false;
                    this.BtnCancelar.Visible = true;
                    this.BtnConfirmar.Visible = true;
                    this.txtOpcion.Location = new Point(151, 29);
                    sound.Stream = CIDFares.Library.Controls.Properties.Resources.collect;
                    sound.Play();
                    break;
                case TypeMessage.listaError:
                    ptBIcono.Image = CIDFares.Library.Controls.Properties.Resources.exclamaciontriangulo;
                    this.Size = new Size(412, 200);
                    this.txtOpcion.Size = new Size(291, 95);
                    this.txtOpcion.ScrollBars = ScrollBars.Vertical;
                    this.btnSi.Visible = true;
                    this.BtnCancelar.Visible = false;
                    this.BtnConfirmar.Visible = false;
                    break;
            }
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnSi_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
