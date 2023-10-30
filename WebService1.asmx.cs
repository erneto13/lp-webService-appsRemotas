using System;
using System.Diagnostics;
using System.Web.Services;

namespace lp_webService_appsRemotas
{
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string CPUz(string nombreApp)
        {
            try
            {
                string rutaApp = @"C:\Program Files\CPUID\CPU-Z\" + nombreApp;

                if (System.IO.File.Exists(rutaApp))
                {
                    Process.Start(rutaApp);
                    return "Aplicación " + nombreApp + " iniciada correctamente.";
                }
                else
                {
                    return "La aplicación " + nombreApp + " no se encontró en la ruta especificada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al intentar ejecutar la aplicación: " + ex.Message;
            }
        }

        [WebMethod]
        public string WinRAR(string nombreApp)
        {
            try
            {
                string rutaApp = @"C:\Program Files\WinRAR\" + nombreApp;

                if (System.IO.File.Exists(rutaApp))
                {
                    Process.Start(rutaApp);
                    return "Aplicación " + nombreApp + " iniciada correctamente.";
                }
                else
                {
                    return "La aplicación " + nombreApp + " no se encontró en la ruta especificada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al intentar ejecutar la aplicación: " + ex.Message;
            }
        }

        [WebMethod]
        public string NotepadPlusPlus(string nombreApp)
        {
            try
            {
                string rutaApp = @"C:\Program Files\Notepad++\" + nombreApp; // Agrega la ruta base donde se encuentran tus aplicaciones

                if (System.IO.File.Exists(rutaApp))
                {
                    Process.Start(rutaApp);
                    return "Aplicación " + nombreApp + " iniciada correctamente.";
                }
                else
                {
                    return "La aplicación " + nombreApp + " no se encontró en la ruta especificada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al intentar ejecutar la aplicación: " + ex.Message;
            }
        }

        [WebMethod]
        public string JFLAP(string nombreApp)
        {
            try
            {
                string rutaApp = @"C:\Users\Ernesto Amaral\Desktop\" + nombreApp; // Agrega la ruta base donde se encuentran tus aplicaciones

                if (System.IO.File.Exists(rutaApp))
                {
                    Process.Start(rutaApp);
                    return "Aplicación " + nombreApp + " iniciada correctamente.";
                }
                else
                {
                    return "La aplicación " + nombreApp + " no se encontró en la ruta especificada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al intentar ejecutar la aplicación: " + ex.Message;
            }
        }

        [WebMethod]
        public string Brave(string nombreApp)
        {
            try
            {
                string rutaApp = @"C:\Users\Ernesto Amaral\Desktop\ㅤ\" + nombreApp; // Agrega la ruta base donde se encuentran tus aplicaciones

                if (System.IO.File.Exists(rutaApp))
                {
                    Process.Start(rutaApp);
                    return "Aplicación " + nombreApp + " iniciada correctamente.";
                }
                else
                {
                    return "La aplicación " + nombreApp + " no se encontró en la ruta especificada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al intentar ejecutar la aplicación: " + ex.Message;
            }
        }
    }
}
