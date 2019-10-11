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
        bool AbrirArchivo(string Ruta, string Nombre);
        void GuardarArchivo();
        void EscribirCelda(int columna, int fila, string valor);
        void Cerrar();
        string AbrirExcel();
        string LeerExcel(int FilaInicio, int ColumnaInicio);
    }
}
