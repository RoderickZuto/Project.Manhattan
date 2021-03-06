﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Manhattan1.Models;
using Project.Manhattan1.Services;

namespace UnitTests.Services.SendMessage
{
    [TestClass]
   public class WhenSendingAMessage
    {
        [TestMethod]
        public void TheMessageIsSentToTheDatabase()
        {
            var testModel = new MessageModel
            {
                DateTime = DateTime.Now.ToString(),
                Message = "Bye World!",
                UserTo = "Jack Smack"
            };
            var testClass = new MessageSend();

           Assert.AreEqual(testClass.SendMessages(testModel), true); 
        }

        [TestMethod]
        public void TheMessageIsSerializedCorrectly()
        {
            var testModel = new MessageModel
            {
                DateTime = DateTime.Now.ToString(),
                Message = "Hello World!",
                UserTo = "Jack Black"
            };
            var testClass = new MessageSend();

            Assert.IsInstanceOfType(testClass.SerializeModel(testModel), typeof(string));

        }
    }
}
