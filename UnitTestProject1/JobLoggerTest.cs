using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Belatrix.Logger.Interfaces;
using Autofac;
using Belatrix.Logger.Domain.Entities;
using Belatrix.Logger.Transversal;
using Presentacion.LoggerService;
using Belatrix.Logger.Service.DTO;

namespace Belatrix.Logger.UnitTest
{
    [TestClass]
    public class JobLoggerTest
    {
        [TestMethod]
        public void TestSaveDB()
        {
            JobLoggerDTO objJobLogger = new JobLoggerDTO();
            objJobLogger.Message = "Test database " + DateTime.Now.ToLongDateString() + "Message";
            objJobLogger.Configuration = (int)Configuration.Database;
            objJobLogger.TypeMessage = (int)TypeMessage.Error;
            
            JobLoggerServiceClient srv = new JobLoggerServiceClient();
            Assert.AreEqual(true, srv.SaveLogger(objJobLogger).Success);
        }
        
        [TestMethod]
        public void TestSaveFile()
        {
            JobLoggerDTO objJobLogger = new JobLoggerDTO();
            objJobLogger.Message = "Test file " + DateTime.Now.ToLongDateString() + "Message";
            objJobLogger.Configuration = (int)Configuration.File;
            objJobLogger.TypeMessage = (int)TypeMessage.Error;
            
            JobLoggerServiceClient srv = new JobLoggerServiceClient();
            Assert.AreEqual(true, srv.SaveLogger(objJobLogger).Success);

        }

    }
}
