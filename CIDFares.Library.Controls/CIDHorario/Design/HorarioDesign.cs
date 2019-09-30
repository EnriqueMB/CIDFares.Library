using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Library.Controls.CIDHorario.Enums;

namespace CIDFares.Library.Controls.CIDHorario.Design
{
    public partial class HorarioDesign : UserControl
    {
        public DaysNumber Days { get; set; }
        public HorarioDesign()
        {
            InitializeComponent();
            
        }

        public void Configurar(DaysNumber days)
        {
            Days = days;
            try
            {
                switch (Days)
                {
                    case DaysNumber.LuVi:
                        pnlSabado.Visible = false;
                        pnlDomingo.Visible = false;
                        txtDomingo.Visible = false;
                        txtSabado.Visible = false;
                        break;
                    case DaysNumber.LuSa:
                        pnlDomingo.Visible = false;
                        txtDomingo.Visible = false;
                        break;
                    case DaysNumber.LuDo:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PintarHora(DaysHour days, string hora)
        {
            switch (days)
            {
                case DaysHour.Lunes:
                    txtLunes.Text = hora;
                    break;
                case DaysHour.Martes:
                    txtMartes.Text = hora;
                    break;
                case DaysHour.Miercoles:
                    txtMiercoles.Text = hora;
                    break;
                case DaysHour.Jueves:
                    txtJueves.Text = hora;
                    break;
                case DaysHour.Viernes:
                    txtViernes.Text = hora;
                    break;
                case DaysHour.Sabado:
                    txtSabado.Text = hora;
                    break;
                case DaysHour.Domingo:
                    txtDomingo.Text = hora;
                    break;
                default:
                    break;
            }
        }

    }
}

