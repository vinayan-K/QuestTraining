using Assesment3.Entities;
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

namespace Assesment3.NoteService
{
    internal class NoteServices
    {
        private readonly INoteRepository _noteRepository;
        private static readonly ILog log = LogManager.GetLogger(typeof(NoteServices));

        public NoteServices(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public void AddNotes()
        {
            try
            {
                var note = new Notes();
                Console.WriteLine("Enter the Title :");
                var title = Console.ReadLine();
                ValidateInput(title);
                note.Title = title;
                Console.WriteLine("Enter Content :");
                var content = Console.ReadLine();
                ValidateInput(content);
                note.Content = content;
                note.CreatedAt = DateTime.Now;
                note.UpdatedAt = DateTime.Now;
                _noteRepository.AddNote(note);
                log.Info("Added a new Note.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                log.Error(ex.StackTrace);
            }
        }

        public void DeleteNote()
        {
            try
            {
                Console.WriteLine("Enter the Id to delete: ");
                var idToDelete = int.Parse(Console.ReadLine());
                ValidateInput(idToDelete);
                var exist = _noteRepository.CheckId(idToDelete);
                if (exist)
                {
                    _noteRepository.DeleteNote(idToDelete);
                    log.Info("Deleted a Note.");
                }
                else
                {
                    Console.WriteLine("ID NOT FOUND");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                log.Error(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                log.Error(ex.StackTrace);
            }
        }

        public void ViewAllNotes()
        {
            _noteRepository.ViewAllNotes();
            log.Info("Listed all Notes.");
        }

        public void UpdateNote()
        {
            try
            {
                Console.WriteLine("Enter id : ");
                var idToUpdate = int.Parse(Console.ReadLine());
                ValidateInput(idToUpdate);
                var exist = _noteRepository.CheckId(idToUpdate);
                if (exist)
                {
                    Console.WriteLine("Enter new content : ");
                    var newContent = Console.ReadLine();
                    ValidateInput(newContent);
                    var updateTime = DateTime.Now;
                    _noteRepository.UpdateNote(idToUpdate, newContent, updateTime);
                    log.Info("Updated content of Note.");
                }
                else
                {
                    Console.WriteLine("ID NOT FOUND");
                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                log.Error(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                log.Error(ex.StackTrace);
            }
        }

        static void ValidateInput(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");
            }
        }
        static void ValidateInput(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id), "Input cannot be null.");
            }
        }

    }
}
