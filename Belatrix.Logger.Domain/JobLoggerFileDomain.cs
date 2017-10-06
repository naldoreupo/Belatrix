using System;
using Belatrix.Logger.Interfaces;
using System.Configuration;
using System.IO;
using Belatrix.Logger.Domain.Entities;
using Belatrix.Logger.Transversal;

namespace Belatrix.Logger.Domain
{
    public class JobLoggerFileDomain : IJobloggerDomain
    {
        private Response<Boolean> Response = Response<Boolean>.GetSingleton();

        public Response<Boolean> SaveLogger(Entities.JobLogger logger)
        {
            string l = String.Empty;
            var path = ConfigurationManager.AppSettings["LogFileDirectory"];
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var ruta = path + "LogFile_" + DateTime.Now.ToString("dd_MM_yyy") + ".txt";

            try
            {
                if (!File.Exists(ruta))
                    File.Create(ruta).Close();
                else
                    l = File.ReadAllText(ruta);

                l = string.Concat(l, DateTime.Now.ToString("ddMMyyyyHHmm"), ": ", logger.Message, Environment.NewLine);

                File.WriteAllText(ruta, l);

                Response.Success = true;
                Response.Message = "Operation Successfully Completed";
            }
            catch (Exception e)
            {
                Response.Success = false;
                Response.Message = e.Message;
            }

            return Response;
        }
    }
}
