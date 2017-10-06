using System;
using Belatrix.Logger.Service.DTO;
using Belatrix.Logger.Transversal;
using Presentacion.LoggerService;

namespace Belatrix.Logger.App
{
   class Program
    {

        static void Main(string[] args)
        {
            JobLoggerApp();
        }
        private static void JobLoggerApp()
        {
            try
            {
                ConsoleConfiguration();
                Maps.register();
                var container = IocConfigApp.RegisterIoc();
                int result = 0;
                var validations = string.Empty;
                JobLoggerDTO objJobLogger = new JobLoggerDTO();
                Response<Boolean> objResponse = Response<Boolean>.GetSingleton();

                Console.WriteLine("Select configuration ");
                Console.WriteLine("1 - File");
                Console.WriteLine("2 - Database");

                int.TryParse(Console.ReadLine(), out result);
                objJobLogger.Configuration = result;

                Console.WriteLine("Select the type of message: ");
                Console.WriteLine("1 - Error");
                Console.WriteLine("2 - Warning");
                Console.WriteLine("3 - Message");
                int.TryParse(Console.ReadLine(), out result);
                objJobLogger.TypeMessage = result;

                Console.WriteLine("Type your message here : ");
                objJobLogger.Message = Console.ReadLine();

                Validar(objJobLogger);

                //Invoke WCF Service
                JobLoggerServiceClient srv = new JobLoggerServiceClient();
                srv.SaveLogger(objJobLogger);

                //ForeColor
                switch (objJobLogger.TypeMessage)
                {
                    case (int)TypeMessage.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case (int)TypeMessage.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case (int)TypeMessage.Message:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                };
                Console.WriteLine(DateTime.Now.ToShortDateString() + ": " + string.Join(string.Empty, objResponse.Message));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            JobLoggerApp();
        }

        private static void ConsoleConfiguration()
        {
            Console.Title = "Belatrix JobLogger App";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        private static void Validar(JobLoggerDTO objJobLogger)
        {
            var validations = string.Empty;
            if (!Enum.IsDefined(typeof(TypeMessage), objJobLogger.TypeMessage)) validations += "Invalid type of message \n";
            if (!Enum.IsDefined(typeof(Configuration), objJobLogger.Configuration)) validations += "Invalid configuration \n";
            if (string.IsNullOrEmpty(objJobLogger.Message)) validations += "Error or Warning or Message must be specified";
            if (!string.IsNullOrEmpty(validations)) throw new Exception(validations);
        }
    }
}
