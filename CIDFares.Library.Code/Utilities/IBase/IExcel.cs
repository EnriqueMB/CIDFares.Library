using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Library.Code.Utilities.IBase
{
    public interface IExcel
    {
        void AbrirArchivo(/*string[,] Datos*/string Ruta, string Nombre);
        void GuardarArchivo(string Nombre);
        void EscribirCelda(int columna, int fila, string valor);
     
    }
}
