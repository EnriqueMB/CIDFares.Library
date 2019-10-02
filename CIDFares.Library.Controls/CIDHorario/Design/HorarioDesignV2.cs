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
    public partial class HorarioDesignV2 : UserControl
    {
        
        public HorarioDesignV2()
        {
            InitializeComponent();
        }

        private void ConfigurarTabla()
        {
            tblContainer.Name = "tblContainer";
            tblContainer.Dock = DockStyle.Fill;
            tblContainer.Location = new Point(0, 0);
            //tblContainer.Size = new Size(702, 372);
        }
        public void Configurar(DaysNumber days)
        {
            switch (days)
            {
                case DaysNumber.LuVi:
                    //Iniciamos la configuracion de la tabla para 5 días
                    ConfigurarTabla();
                    //Contamos las filas 
                    tblContainer.RowCount = 2;
                    //Agregamos las filas con una distribucion porcentual de acuerdo al tamaño del control
                    tblContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 10.38462F)); //La primera fila sera para el encabezado
                    tblContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 89.61538F)); //La segunda fila es para el cuerpo del horario(las horas)
                    //Contamos 5 columnas
                    tblContainer.ColumnCount = 5;
                    //Agregamos las 5 columnas con un distribucion porcentual de acuerdo al tamaño del control
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    //Agregamos los paneles del encabezado
                    tblContainer.Controls.Add(pnlViernes, 4, 0);
                    tblContainer.Controls.Add(pnlJueves, 3, 0);
                    tblContainer.Controls.Add(pnlMiercoles, 2, 0);
                    tblContainer.Controls.Add(pnlMartes, 1, 0);
                    tblContainer.Controls.Add(pnlLunes, 0, 0);
                    //Agregamos los paneles para las horas
                    tblContainer.Controls.Add(pnlHoraLunes, 0, 1);
                    tblContainer.Controls.Add(pnlHoraMartes, 1, 1);
                    tblContainer.Controls.Add(pnlHoraMiercoles, 2, 1);
                    tblContainer.Controls.Add(pnlHoraJueves, 3, 1);
                    tblContainer.Controls.Add(pnlHoraViernes, 4, 1);
                    //Agregamos la tabla al formulario
                    Controls.Add(tblContainer);
                    break;
                case DaysNumber.LuSa:
                    //Iniciamos la configuracion de la tabla para 6 días
                    ConfigurarTabla();
                    //Contamos las filas 
                    tblContainer.RowCount = 2;
                    //Agregamos las filas con una distribucion porcentual de acuerdo al tamaño del control
                    tblContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 10.38462F)); //La primera fila sera para el encabezado
                    tblContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 89.61538F)); //La segunda fila es para el cuerpo del horario(las horas)
                    //Contamos 6 columnas
                    tblContainer.ColumnCount = 6;
                    //Agregamos las 6 columnas con un distribucion porcentual de acuerdo al tamaño del control
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
                    //Agregamos los paneles del encabezado
                    tblContainer.Controls.Add(pnlSabado, 5, 0);
                    tblContainer.Controls.Add(pnlViernes, 4, 0);
                    tblContainer.Controls.Add(pnlJueves, 3, 0);
                    tblContainer.Controls.Add(pnlMiercoles, 2, 0);
                    tblContainer.Controls.Add(pnlMartes, 1, 0);
                    tblContainer.Controls.Add(pnlLunes, 0, 0);
                    //Agregamos los paneles para las horas
                    tblContainer.Controls.Add(pnlHoraLunes, 0, 1);
                    tblContainer.Controls.Add(pnlHoraMartes, 1, 1);
                    tblContainer.Controls.Add(pnlHoraMiercoles, 2, 1);
                    tblContainer.Controls.Add(pnlHoraJueves, 3, 1);
                    tblContainer.Controls.Add(pnlHoraViernes, 4, 1);
                    tblContainer.Controls.Add(pnlHoraSabado, 5, 1);
                    //Agregamos la tabla al formulario
                    Controls.Add(tblContainer);
                    break;
                case DaysNumber.LuDo:
                    //Iniciamos la configuracion de la tabla para 6 días
                    ConfigurarTabla();
                    //Contamos las filas 
                    tblContainer.RowCount = 2;
                    //Agregamos las filas con una distribucion porcentual de acuerdo al tamaño del control
                    tblContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 10.38462F)); //La primera fila sera para el encabezado
                    tblContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 89.61538F)); //La segunda fila es para el cuerpo del horario(las horas)
                    //Contamos 7 columnas
                    tblContainer.ColumnCount = 7;
                    //Agregamos las 7 columnas con un distribucion porcentual de acuerdo al tamaño del control
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
                    tblContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
                    //Agregamos los paneles del encabezado
                    tblContainer.Controls.Add(pnlDomingo, 6, 0);
                    tblContainer.Controls.Add(pnlSabado, 5, 0);
                    tblContainer.Controls.Add(pnlViernes, 4, 0);
                    tblContainer.Controls.Add(pnlJueves, 3, 0);
                    tblContainer.Controls.Add(pnlMiercoles, 2, 0);
                    tblContainer.Controls.Add(pnlMartes, 1, 0);
                    tblContainer.Controls.Add(pnlLunes, 0, 0);
                    //Agregamos los paneles para las horas
                    tblContainer.Controls.Add(pnlHoraLunes, 0, 1);
                    tblContainer.Controls.Add(pnlHoraMartes, 1, 1);
                    tblContainer.Controls.Add(pnlHoraMiercoles, 2, 1);
                    tblContainer.Controls.Add(pnlHoraJueves, 3, 1);
                    tblContainer.Controls.Add(pnlHoraViernes, 4, 1);
                    tblContainer.Controls.Add(pnlHoraSabado, 5, 1);
                    tblContainer.Controls.Add(pnlHoraDomingo, 6, 1);
                    //Agregamos la tabla al formulario
                    Controls.Add(tblContainer);
                    break;
                default:
                    break;
            }
        }
        public void AgregarHora(DaysHour daysHour, string horario)
        {
            switch (daysHour)
            {
                case DaysHour.Lunes:
                    txtLunes.Text = horario;
                    break;
                case DaysHour.Martes:
                    txtMartes.Text = horario;
                    break;
                case DaysHour.Miercoles:
                    txtMiercoles.Text = horario;
                    break;
                case DaysHour.Jueves:
                    txtJueves.Text = horario;
                    break;
                case DaysHour.Viernes:
                    txtViernes.Text = horario;
                    break;
                case DaysHour.Sabado:
                    txtSabado.Text = horario;
                    break;
                case DaysHour.Domingo:
                    txtDomingo.Text = horario;
                    break;
                default:
                    break;
            }
        }

        public void EliminarHora(DaysHour daysHour)
        {
            switch (daysHour)
            {
                case DaysHour.Lunes:
                    txtLunes.Text = string.Empty;
                    break;
                case DaysHour.Martes:
                    txtMartes.Text = string.Empty;
                    break;
                case DaysHour.Miercoles:
                    txtMiercoles.Text = string.Empty;
                    break;
                case DaysHour.Jueves:
                    txtJueves.Text = string.Empty;
                    break;
                case DaysHour.Viernes:
                    txtViernes.Text = string.Empty;
                    break;
                case DaysHour.Sabado:
                    txtSabado.Text = string.Empty;
                    break;
                case DaysHour.Domingo:
                    txtDomingo.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }
    }
}
