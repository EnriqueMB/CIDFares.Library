using CIDFares.Library.Code.Utilities.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace CIDFares.Library.Code.Utilities.Implements
{
    public class Excel : IExcel
    {
        Application xlsApp = new Application();
        Workbook Libro;
        Sheets Hojas;//conjunto de hojas
        Worksheet Hoja;//hoja de trabajo    
        
        /// <summary>
        /// Recibe la ruta y el nombre que deseé que tenga la hoja de trabajo
        /// </summary>
        /// <param name="Ruta"></param>
        /// <param name="Nombre"></param>
        public void AbrirArchivo(string Ruta, string Nombre)
        {
            xlsApp.DisplayAlerts = false;
            xlsApp.Visible = false;
            Libro = xlsApp.Workbooks.Open(Ruta);//se abre e libro en la ruta recibida
            Hojas = Libro.Sheets;
            Hoja = (Worksheet)Hojas[Nombre]; //se agrega el nombre que recibe a la hoja
        }
        /// <summary>
        /// Recibe columna y fila inicial con el valor que tendra en esa posicion para llenar el excel
        /// </summary>
        /// <param name="columna"></param>
        /// <param name="fila"></param>
        /// <param name="valor"></param>
        public void EscribirCelda(int columna, int fila, string valor)
        {
            Hoja.Cells[fila, columna]= valor;
        }
        /// <summary>
        /// Se cierran el libro, app, la coleccion de hojas y la hoja de trabajo mediante el recolector de basura o garbage collector
        /// </summary>
        public void Cerrar()
        {
            try
            {
                Libro.Close();
                xlsApp.Quit();
                releaseObject(Hoja);
                releaseObject(Libro);
                releaseObject(Hojas);
                releaseObject(xlsApp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void releaseObject(object obj)//Recolector de basura para no espera 
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                
                obj = null;
                throw ex ;
            }
            finally
            {
                GC.Collect();
            }
        }

        public void GuardarArchivo(string Nombre)
        {
            Libro.SaveAs(Nombre);
        }
    }
}
