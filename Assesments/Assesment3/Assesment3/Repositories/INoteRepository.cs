using Assesment3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3.Repositories
{
    internal interface INoteRepository
    {
        void AddNote(Notes note);
        List<Notes> ViewAllNotes();
        void UpdateNote(int id, string newContent, DateTime updatedAt);
        void DeleteNote(int id);
        bool CheckId(int id);
    }
}
