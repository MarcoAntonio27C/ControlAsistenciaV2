
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControlAsistencia_.Models;

namespace ReportePDF
{
    public class CrearReporte
    {
         public FileStreamResult Crear(DatosEmpleado datos ,List<DateTime> entradas, List<DateTime> salidas,List<Incidencia> incidencias, string path)
        {
            Document doc = new Document(PageSize.LETTER);
            MemoryStream workStream = new MemoryStream();
            // PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream(path, FileMode.Create));
            PdfWriter writer = PdfWriter.GetInstance(doc, workStream);
            writer.CloseStream = false;
            string NombreEmpleado = datos.NombreCompleto;
            doc.AddTitle("");
            doc.AddCreator("");

            doc.Open();

            var imgFiscalia = global::ReportePDF.Properties.Resources.LogoFiscalia;
            var imgLogoPuebla = global::ReportePDF.Properties.Resources.escudoPuebla;
            var marcaAgua = global::ReportePDF.Properties.Resources.fondo_smll;


            iTextSharp.text.Image imagen1 = iTextSharp.text.Image.GetInstance(imgFiscalia);
            iTextSharp.text.Image imagen2 = iTextSharp.text.Image.GetInstance(imgLogoPuebla);
            iTextSharp.text.Image imagen3 = iTextSharp.text.Image.GetInstance(marcaAgua);

            imagen1.ScalePercent(75);
            imagen1.SetAbsolutePosition(440, 690);
            doc.Add(imagen1);

            imagen2.ScalePercent(5);
            imagen2.SetAbsolutePosition(20, 685);
            doc.Add(imagen2);

            imagen3.ScalePercent(140);
            imagen3.SetAbsolutePosition(125, 180);
            doc.Add(imagen3);

            var ColorBorder = new BaseColor(69, 69, 70);
            //  Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _span = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font _dato = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 9, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font _encabezado = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font _fecha = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //  Escribimos el encabezamiento en el documento
            var titulo = new Paragraph("Fiscalía General del Estado \nOficialía Mayor \nDirección de Administración \nSubdireccíon de Servicios Personales \nControl de Asistencia", _encabezado);

            PdfPTable tablaDatos = new PdfPTable(10);
            tablaDatos.WidthPercentage = 100;

            PdfPCell cellExpediente = new PdfPCell(new Phrase("Expediente: " + datos.NumeroExpediente, _span));
            cellExpediente.Colspan = 3;
            cellExpediente.Padding = 5;
            cellExpediente.BorderWidth = 0;
            cellExpediente.BorderWidthBottom = 1;
            tablaDatos.AddCell(cellExpediente);
            PdfPCell cellNombre = new PdfPCell(new Phrase("Nombre: " + NombreEmpleado, _span));
            cellNombre.Colspan = 5;
            cellNombre.Padding = 5;
            cellNombre.BorderWidthBottom = 1;
            cellNombre.BorderWidth = 0;
            tablaDatos.AddCell(cellNombre);
            PdfPCell cellMes = new PdfPCell(new Phrase("Mes: " + entradas.ElementAt(0).ToString("Y"), _span));
            cellMes.Colspan = 2;
            cellMes.Padding = 5;
            cellMes.BorderWidthBottom = 1;
            cellMes.BorderWidth = 0;
            tablaDatos.AddCell(cellMes);
            //*****************************************************************************
            PdfPCell cellUR = new PdfPCell(new Phrase("UR: "+datos.UR, _span));
            cellUR.Colspan = 1;
            cellUR.BorderWidth = 0;
            cellUR.BorderWidthBottom = 1;
            cellUR.Padding = 6;
            tablaDatos.AddCell(cellUR);
            PdfPCell cellCategoria = new PdfPCell(new Phrase("Cargo: "+datos.Cargo, _span));
            cellCategoria.Colspan = 6;
            cellCategoria.Padding = 5;
            cellCategoria.BorderWidthBottom = 1;
            cellCategoria.BorderWidth = 0;
            tablaDatos.AddCell(cellCategoria);
            PdfPCell cellHorario = new PdfPCell(new Phrase("Horario: "+datos.Horario, _span));
            cellHorario.Colspan = 3;
            cellHorario.Padding = 5;
            cellHorario.BorderWidthBottom = 1;
            cellHorario.BorderWidth = 0;
            tablaDatos.AddCell(cellHorario);
            //*****************************************************************************
            PdfPCell cellCentroTrabajo = new PdfPCell(new Phrase("Centro de Trabajo: "+ConvertirCadenada(datos.CentroTrabajo), _span));
            cellCentroTrabajo.Colspan = 7;
            cellCentroTrabajo.BorderWidth = 0;
            cellCentroTrabajo.BorderWidthBottom = 1;
            cellCentroTrabajo.Padding = 5;
            tablaDatos.AddCell(cellCentroTrabajo);
            PdfPCell cellContratacion = new PdfPCell(new Phrase("Contratación: "+datos.Contratacion, _span));
            cellContratacion.Colspan = 3;
            cellContratacion.Padding = 5;
            cellContratacion.BorderWidth = 0;
            cellContratacion.BorderWidthBottom = 1;
            tablaDatos.AddCell(cellContratacion);
            //*****************************************************************************
            PdfPCell cellInmueble = new PdfPCell(new Phrase("Inmueble: "+ConvertirCadenada(datos.Direccion), _span));
            cellInmueble.Colspan = 10;
            cellInmueble.BorderWidth = 0;
            cellInmueble.BorderWidthBottom = 1;
            cellInmueble.Padding = 5;
            tablaDatos.AddCell(cellInmueble);
            //PdfPCell cellTelefono = new PdfPCell(new Phrase("Teléfono:", _span));
            //cellTelefono.Colspan = 3;
            //cellTelefono.Padding = 5;
            //cellTelefono.BorderWidth = 0;
            //cellTelefono.BorderWidthBottom = 1;
            //tablaDatos.AddCell(cellTelefono);


            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(Chunk.NEWLINE);
            doc.Add(tablaDatos);
            doc.Add(Chunk.NEWLINE);

            PdfPTable tablaCalendario = new PdfPTable(7);
            tablaCalendario.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla

            PdfPCell columDomingo = new PdfPCell(new Phrase("Domingo", _fecha));
            columDomingo.HorizontalAlignment = Element.ALIGN_CENTER;
            columDomingo.BorderWidth = 1;
            columDomingo.BorderColor = ColorBorder;
            columDomingo.Padding = 5;
            columDomingo.BorderWidthBottom = 1f;
            PdfPCell columLunes = new PdfPCell(new Phrase("Lunes", _fecha));
            columLunes.BorderWidth = 1;
            columLunes.HorizontalAlignment = Element.ALIGN_CENTER;
            columLunes.BorderColor = ColorBorder;
            columLunes.Padding = 5;
            columLunes.BorderWidthBottom = 1f;
            PdfPCell columMartes = new PdfPCell(new Phrase("Martes", _fecha));
            columMartes.BorderWidth = 1;
            columMartes.HorizontalAlignment = Element.ALIGN_CENTER;
            columMartes.BorderColor = ColorBorder;
            columMartes.Padding = 5;
            columMartes.BorderWidthBottom = 1f;
            PdfPCell columMiercoles = new PdfPCell(new Phrase("Miercoles", _fecha));
            columMiercoles.BorderWidth = 1;
            columMiercoles.Padding = 5;
            columMiercoles.BorderColor = ColorBorder;
            columMiercoles.HorizontalAlignment = Element.ALIGN_CENTER;
            columMiercoles.BorderWidthBottom = 1f;
            PdfPCell columJueves = new PdfPCell(new Phrase("Jueves", _fecha));
            columJueves.BorderWidth = 1;
            columJueves.Padding = 5;
            columJueves.BorderColor = ColorBorder;
            columJueves.HorizontalAlignment = Element.ALIGN_CENTER;
            columJueves.BorderWidthBottom = 1f;
            PdfPCell columViernes = new PdfPCell(new Phrase("Viernes", _fecha));
            columViernes.BorderWidth = 1;
            columViernes.Padding = 5;
            columViernes.BorderColor = ColorBorder;
            columViernes.HorizontalAlignment = Element.ALIGN_CENTER;
            columViernes.BorderWidthBottom = 1f;
            PdfPCell columSabado = new PdfPCell(new Phrase("Sabado", _fecha));
            columSabado.BorderWidth = 1;
            columSabado.Padding = 5;
            columSabado.BorderColor = ColorBorder;
            columSabado.HorizontalAlignment = Element.ALIGN_CENTER;
            columSabado.BorderWidthBottom = 1f;

            tablaCalendario.AddCell(columDomingo);
            tablaCalendario.AddCell(columLunes);
            tablaCalendario.AddCell(columMartes);
            tablaCalendario.AddCell(columMiercoles);
            tablaCalendario.AddCell(columJueves);
            tablaCalendario.AddCell(columViernes);
            tablaCalendario.AddCell(columSabado);

            //Obtenemos el primer dia del mes y numero de Dias
            DateTime date1 = entradas.ElementAt(0);
            DateTime date2 = new DateTime(date1.Year, date1.Month, 1);
            string primerDiaMes = new DateTime(date2.Year, date2.Month, 1).DayOfWeek.ToString();
            int numeroDias = date2.AddMonths(1).AddDays(-1).Day;

            //Dias de la Semana
            List<String> semana = new List<string>(7);
            semana.Add("Sunday");
            semana.Add("Monday");
            semana.Add("Tuesday");
            semana.Add("Wednesday");
            semana.Add("Thursday");
            semana.Add("Friday");
            semana.Add("Saturday");

            List<Mes> mes = new List<Mes>(42);
            // Ponemos el Nombre de los dias al mes
            for (int i = 0; i < 6; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    Mes diaMes = new Mes();
                    diaMes.nombreDia = semana.ElementAt(x);
                    mes.Add(diaMes);
                }
            }

            // Inicio de la semana

            int positionInicio = 0;
            int numeroDia = 1;

            for (int x = 0; x < 6; x++)
            {
                if (mes.ElementAt(x).nombreDia.Equals(primerDiaMes))
                {
                    mes.ElementAt(x).numeroDia = "" + numeroDia;
                    mes.ElementAt(x).asistenciaEntrada = "\nEntrada";
                    mes.ElementAt(x).asistenciaSalida = "\n\nSalida";

                    numeroDia++;
                    positionInicio = x;
                    break;
                }
                else
                {
                    mes.ElementAt(x).numeroDia = "";
                }
            }

            //Llenar Resto Calendario Solo con el numero de Dia
            for (int i = positionInicio + 1; i < 42; i++)
            {
                if (numeroDia <= numeroDias)
                {
                    mes.ElementAt(i).numeroDia = "" + numeroDia;
                    mes.ElementAt(i).asistenciaEntrada = "\nEntrada";
                    mes.ElementAt(i).asistenciaSalida = "\n\nSalida";
                    numeroDia++;
                }
            }

            //Agregamos las asistencias de Entrada al Calendario

            string diaAsistenciaEntrada = "";
            for (int i = 0; i < 42; i++)
            {
                if (entradas.Count > 0)
                {
                    diaAsistenciaEntrada = "" + entradas.ElementAt(0).Day;
                    if (mes.ElementAt(i).numeroDia.Equals(diaAsistenciaEntrada))
                    {
                        mes.ElementAt(i).asistenciaEntrada += "\n" + entradas.ElementAt(0).ToString("t");
                        entradas.RemoveAt(0);
                    }
                }
                diaAsistenciaEntrada = "";
            }

            //Agregamos las asistencias de Salidas al Calendario

            string diaAsistenciaSalida = "";
            for (int i = 0; i < 42; i++)
            {
                if (salidas.Count > 0)
                {
                    diaAsistenciaSalida = "" + salidas.ElementAt(0).Day;
                    if (mes.ElementAt(i).numeroDia.Equals(diaAsistenciaSalida))
                    {
                        mes.ElementAt(i).asistenciaSalida += "\n" + salidas.ElementAt(0).ToString("t");
                        salidas.RemoveAt(0);
                    }

                }
                diaAsistenciaSalida = "";
            }

            //Agregamos las Incidencias al Calendario

            string diaIncidencia = "";
            for (int i = 0; i < 42; i++)
            {
                if (incidencias.Count > 0)
                {
                    diaIncidencia = "" + incidencias.ElementAt(0).FechaHora.Day;
                    if (mes.ElementAt(i).numeroDia.Equals(diaIncidencia))
                    {
                        mes.ElementAt(i).asistenciaEntrada = "\n\n" + incidencias.ElementAt(0).Tipo+"\n\n";
                        mes.ElementAt(i).asistenciaSalida = "";
                        incidencias.RemoveAt(0);
                    }
                }
                diaIncidencia = "";
            }


            //Crear Calendario
            string nombre = "";
            string numero = "";
            string asistenciaEntrada = "";
            string asistenciaSalida = "";
            for (int i = 0; i < 42; i++)
            {

                nombre = mes.ElementAt(i).nombreDia;
                numero = mes.ElementAt(i).numeroDia;
                asistenciaEntrada = mes.ElementAt(i).asistenciaEntrada;
                asistenciaSalida = mes.ElementAt(i).asistenciaSalida;

                PdfPCell cellDia = new PdfPCell(new Phrase("" + numero + asistenciaEntrada + asistenciaSalida, _fecha));
                //PdfPCell cellDia = new PdfPCell(new Phrase(nombre+ "\n"+numero, _fecha));
                // mes.RemoveAt(0);
                cellDia.BorderWidth = 1;
                cellDia.Padding = 5;
                cellDia.BorderColor = ColorBorder;
                cellDia.HorizontalAlignment = Element.ALIGN_CENTER;
                cellDia.BorderWidthBottom = 1f;
                tablaCalendario.AddCell(cellDia);
                nombre = "";
                numero = "";
                asistenciaEntrada = "";
                asistenciaSalida = "";
            }

            doc.Add(tablaCalendario);

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            PdfPTable tablafirma = new PdfPTable(10);
            tablafirma.WidthPercentage = 100;
            PdfPCell cellempleado = new PdfPCell(new Phrase("   " + NombreEmpleado.ToUpper() + "   ", _dato));
            cellempleado.Padding = 5;
            cellempleado.Colspan = 4;
            cellempleado.HorizontalAlignment = Element.ALIGN_CENTER;
            cellempleado.BorderWidth = 0;
            cellempleado.BorderWidthBottom = 1;
            tablafirma.AddCell(cellempleado);
            PdfPCell cellEspacio = new PdfPCell(new Phrase(""));
            cellEspacio.Colspan = 2; ;
            cellEspacio.HorizontalAlignment = Element.ALIGN_CENTER;
            cellEspacio.BorderWidth = 0;
            tablafirma.AddCell(cellEspacio);
            PdfPCell cellTitular = new PdfPCell(new Phrase(""));
            cellTitular.Padding = 5;
            cellTitular.Colspan = 4;
            cellTitular.BorderWidth = 0;
            cellTitular.BorderWidthBottom = 1;
            cellTitular.HorizontalAlignment = Element.ALIGN_CENTER;
            tablafirma.AddCell(cellTitular);
            //*************************************************************************************************

            PdfPCell cellempleado1 = new PdfPCell(new Phrase("NOMBRE Y FIRMA DEL TRABAJADOR", _dato));
            cellempleado1.Padding = 5;
            cellempleado1.Colspan = 4;
            cellempleado1.HorizontalAlignment = Element.ALIGN_CENTER;
            cellempleado1.BorderWidth = 0;
            tablafirma.AddCell(cellempleado1);
            tablafirma.AddCell(cellEspacio);
            PdfPCell cellTitular1 = new PdfPCell(new Phrase("NOMBRE Y FIRMA DEL TITULAR", _dato));
            cellTitular1.Padding = 5;
            cellTitular1.Colspan = 4;
            cellTitular1.HorizontalAlignment = Element.ALIGN_CENTER;
            cellTitular1.BorderWidth = 0;
            tablafirma.AddCell(cellTitular1);

            doc.Add(tablafirma);

            doc.Close();
            //  writer.Close();

            byte[] byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;
            return new FileStreamResult(workStream, "application/pdf");

        }

        public string ConvertirCadenada(string cadena)
        {
            List<string> palabras = new List<string>();
            string salida = "";

            palabras = cadena.ToLower().Split(' ').ToList();

            foreach(var palabra in palabras)
            {
                char[] letras = palabra.ToCharArray();
                letras[0] = char.ToUpper(letras[0]);

                salida = salida + " " + new string(letras);
            }

            return salida;
        }
    }
}
