using Assesment3.Entities;
using Assesment3.NoteService;
using Assesment3.Repositories;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
    internal class NoteManager
    {
        private readonly NoteServices _noteService;
        private static readonly ILog log = LogManager.GetLogger(typeof(NoteManager));
        public NoteManager(INoteRepository noteRepository)
        {
            _noteService = new NoteServices(noteRepository);
        }
        public void Run()
        {
            ConfigureLogging();
            log.Info("Starting up the application.");
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1.AddNote");
                Console.WriteLine("2.Listing all Notes");
                Console.WriteLine("3.Update Note");
                Console.WriteLine("4.Delete Note");
                Console.WriteLine("5.Exit");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        _noteService.AddNotes();
                        break;
                    case "2":
                        _noteService.ViewAllNotes();
                        break;
                    case "3":
                        _noteService.UpdateNote();
                        break;
                    case "4":
                        _noteService.DeleteNote();
                        break;
                    case "5":
                        Console.WriteLine("Closing the application");
                        log.Info("Closing the Application");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invaild option");
                        log.Info("User Selected an invalid option");
                        break;
                }
            }
        }
        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();
            var fileAppender = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NoteApp.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Info
            };
            BasicConfigurator.Configure(repository, fileAppender);
        }

    }
}
