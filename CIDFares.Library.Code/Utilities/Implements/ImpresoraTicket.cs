using CIDFares.Library.Code.Utilities.IBase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Library.Code.Utilities.Implements
{

    public class ImpresoraTicket : IImpresoraTicket
    {
        //Creamos un objeto de la clase StringBuilder, en este objeto  agregaremos las lineas del ticket
        StringBuilder linea = new StringBuilder();
        //Creamos una variable  para almacenar el numero maximo de caracteres que permitiremos en el ticket.
        int maxCar = 40, cortar; //Para una impresora ticketera que imprimir a 40 columnas, la variable cortar cortara el texto cuando rebase el limite.


        /*
        public int tipo_impresion { get; set; }
        public string NombreImpresora { get; set; }
        public List<DatosLinea> Datos { get; set; }
        public int CaracteresPorLinea { get; set; }

        public ImpresoraTicket()
        {
            Datos = new List<DatosLinea>();
        }
        public void diseñoDatos(ref Graphics h, SolidBrush brush, PageSettings ps)
        {
            int incrementoy = 15;
            int tamx = 260;
            int position_y = 0;
            PointF pf = new PointF();
            StringFormat sf = new StringFormat();
            for (int i = 0; i < Datos.Count; i++)
            {
                pf.X = 10;
                sf.Alignment = Datos[i].Alineacion;
                pf.Y = position_y += incrementoy;
                if (Datos[i].Negritas)
                    h.DrawString(Datos[i].Texto, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                else
                    h.DrawString(Datos[i].Texto, new Font("Arial", 8), brush, pf, sf);
            }
        }

        public void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDocument dc = (PrintDocument)sender;
            PaperSize plantilla;
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);
            PageSettings ps;

            switch (tipo_impresion)
            {
                case 1:
                    plantilla = new PaperSize("Ticket", 280, 880);
                    dc.DefaultPageSettings.PaperSize = plantilla;
                    ps = dc.DefaultPageSettings;
                    diseñoDatos(ref g, Brush, ps);
                    break;
                default: break;
            }
        }

        public void ImprimeTiquet(int opcion)
        {
            tipo_impresion = opcion;
            PrintDocument documento = new PrintDocument();
            PaperSize plantilla = new PaperSize("Ticket", 0, 0);
            switch (tipo_impresion)
            {
                case 1:
                    plantilla = new PaperSize("Ticket", 280, 880);
                    break;
                default:

                    plantilla = new PaperSize("Ticket", 0, 0);
                    break;
            }
            documento.DefaultPageSettings.PaperSize = plantilla;
            documento.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = NombreImpresora;
            ps.DefaultPageSettings.PaperSize = plantilla;
            documento.PrinterSettings = ps;
            if (ps.IsValid)
                documento.Print();
        }
        */
        public void AbreCajon()
        {
            //Estos tambien varian, tienen que ver el manual de la impresora para poner las correctas.
            linea.AppendLine("\x18" + "p" + "\x00" + "ØxF" + "\x96");//Caracteres de apertura cajon 0
            //linea.AppendLine("\x18" + "p" + "\x01" + "\x0F" + "x96");//caracteres de apertura cajon 1
        }

        public void AgregarArticulos(string articulo, int cant, decimal precio, decimal importe)
        {
            //Valida ue cantidad precio e importe esten dentro del rango
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool bandera = false; //Indicara si es la primera linea que se escribe cuando bajemos a la segunda si el nombre del articulo no entra en la primera linea
                int nroEspacios = 0;
                //si el nombre o descripcion del articulo es mayor a 20, bajar a la siguiente linea
                if (articulo.Length > 20)
                {
                    //Colocar la cantidad a la derecha
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";//Generamos los espacios necesarios para alinear a la derecha
                    }
                    elemento += espacios + cant.ToString();//Agregamos la cantidad con los espacios

                    //Colocar el precio a la derecha.
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";//Genera los espacios
                    }
                    //El operador += indica que agregar mas cadenas a los que ya existe
                    elemento += espacios + precio.ToString();//Agregamos el precio a la variable elemento

                    //Colocar el importe a la derecha.
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";
                    }
                    elemento += espacios + importe.ToString();//Agregamos el importe alineado a la derecha

                    int caracterActual = 0; //Indicara en que caracter se quedo al bajar a la siguiente linea

                    //Por cada 20 caracteres se agregara una linea siguiente
                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandera == false)//si es false o la primera linea en recorrer, continuar..
                        {
                            //Agregamos los primeros 20 caracteres del nombre del articulo, mas lo que ya tiene la variable elemento
                            linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            bandera = true; //cambiamos su valor a verdadero
                        }
                        else
                            linea.AppendLine(articulo.Substring(caracterActual, 20));//Solo agrega el nombre del articulo

                        caracterActual += 20;//incrementa en 20 el valor de la variable caracterActual
                    }
                    //Agrega el resto del fragmento del nombre del articulo
                    linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));

                }

                else //Si no es mayor solo agregarlo, sin dar saltos de lineas
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += "";//Agrega espacios para completar los 20 caracteres
                    }
                    elemento = articulo + espacios;

                    //Colocar la cantidad a la derecha 
                    nroEspacios = (5 - cant.ToString().Length);// +(20 - elemento.Lenght
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";
                    }
                    elemento += espacios + cant.ToString();
                    //Colocar el precio a la derecha
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";
                    }
                    elemento += espacios + precio.ToString();

                    //Colocar el importe a la derecha
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";
                    }
                    elemento += espacios + importe.ToString();

                    linea.AppendLine(elemento);//Agregamos todo el elemento: nombre del articulo, cant, precio, importe
                }

            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("Superan las columnas soportadas por este.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\n superan las columnas soportadas por este.");
            }
        }

        public void AgregarTotales(string texto, decimal total)
        {
            //Variables que usaremos
            string resumen, valor, textoCompleto, espacios = "";
            if (texto.Length > 25)//Si es mayor a 25 lo cortamos 
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            {
                resumen = texto;
            }
            textoCompleto = resumen;
            valor = total.ToString("#,#.00");//Agregamos el total previo formateo
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += "";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }

        public void CortaTicket()
        {
            linea.AppendLine("\x18" + "m");//Caracteres de corte. Estos comando varian segund el tipo de impresora
            linea.AppendLine("\x18" + "d" + "\x09");//Avanza 9 regiones, tambien varian
        }

        public void EncabezadoVenta()
        {
            //Escribimo los espacios para mostrar el articulo. En total tienen que ser 40 caracteres
            linea.AppendLine("ARTICULO            |CANT|PRECIO|IMPORTE");
        }

        public void ImprimirTicket(string impresora)
        {
            //Este metodo recibe el nombre de la impresora a la cual se mandara a imprimir y el texto que se imprimira
            //Usaremos un codigo que nos proporciona Microsoft. https://support.microsoft.com/es-es/kb/322091

             RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());//imprime texto.
            //linea.Clear();//Al acabar de imprimir limpia la linea de todo el texto agregado.
        }

        public string lineasAsteriscos()
        {
            string lineasAsteriscos = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsteriscos += "*";//Agregara un asterico hasta llegar al numero maximo de caracteres.
            }

            return linea.AppendLine(lineasAsteriscos).ToString();//Devolvemos la linea de astericos
        }

        public string lineasGuiom()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";//Agregara un guio hasta llegar al numero maximo de caracteres.
            }

            return linea.AppendLine(lineasGuion).ToString();//Devolvemos la lineaGuion
        }

        public string lineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";//Agregara un igual hasta llegar al numero maximo de caracteres
            }
            return linea.AppendLine(lineasIgual).ToString();//Devolvemos la linea con iguales.
        }

        public void TextDerecha(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restantes
                string espacios = "";
                //Obtenemos la longitud del texto restante
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += "";//Agrega espacios para alinear a la derecha
                }
                //Agregamos el fragmento restante
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += "";//Agrega espacios para alinear a la derecha
                }
                //Si no es mayor solo agregarla
                linea.AppendLine(espacios + texto);
            }

        }

        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restantes
                string espacios = "";
                //Sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos;
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //Obtenemos la longitud del texto restante
                for (int i = 0; i < centrar; i++)
                {
                    espacios += "";//Agrega espacios para alinear a la derecha
                }
                //Agregamos el fragmento restante
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //Sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos;
                int centrar = (maxCar - texto.Length) / 2;
                //Obtenemos la longitud del texto restante
                for (int i = 0; i < centrar; i++)
                {
                    espacios += "";//Agrega espacios para alinear a la derecha
                }
                //Agregamos el fragmento restante
                linea.AppendLine(espacios + texto);
            }
        }

        public void TextoExtremos(string textoIzquierda, string textoDerecho)
        {
            //Variables que utilizaremos
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            //Si el testo que va a la izquierda es mayor a 18, cortamos el texto.
            if (textoIzquierda.Length > 18)
            {
                cortar = textoIzquierda.Length - 18;
                textoIzq = textoIzquierda.Remove(18, cortar);
            }
            else
            {
                textoIzq = textoIzquierda;
            }
            if (textoDerecho.Length > 20)//Si es mayor a 20 lo cortamos 
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }
            else
            {
                textoDer = textoDerecho;
            }
            //Obtenemos el numero de espacios restantes para poner textoDerecho al final
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += "";//Agrega los espacios para poner textoDerecho al final
            }
            textoCompleto += espacios + textoDerecho;//Agregamos el segundo texto con los espacios para alinearlo a la derecha
            linea.AppendLine(textoCompleto);//Agregamos la linea al ticket, al objeto en si.

        }

        public void TextoIzquierda(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Agregamos el fragmento restante
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            { //Si no es mayor solo agregarla
                linea.AppendLine(texto);
            }
        }
    }
    
}
