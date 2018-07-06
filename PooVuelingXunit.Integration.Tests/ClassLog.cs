using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PooVuelingXunit.Integration.Tests
{
    class ClassLog
    {

        public static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void LogSuma()
        {
            var secs = 3;
            Log.Info("Se ha iniciado el metodo Suma");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs
        }

        public void LogMulti()
        {
            var secs = 3;
            Log.Info("Se ha iniciado el metodo Multiplicación");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

        }
        public void LogResta()
        {
            var secs = 3;
            Log.Info("Se ha iniciado el metodo Resta");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

        }
        public void LogDivi()
        {
            var secs = 3;
            Log.Info("Se ha iniciado el metodo División");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

        }

        public void LogSumaError()
        {
            var secs = 3;
            Log.Error("Error en el metodo Suma");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs
        }

        public void LogMultiError()
        {
            var secs = 3;
            Log.Error("Error en el metodo Multiplicación");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

        }
        public void LogRestaError()
        {
            var secs = 3;
            Log.Error("Error en el metodo Resta");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

        }
        public void LogDiviError()
        {
            var secs = 3;
            Log.Error("Error en el metodo División");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs
        }
    }
}
