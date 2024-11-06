using Assesment3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noteRrpository = new NoteRepository();
            var noteManger = new NoteManager(noteRrpository);
            noteManger.Run();
        }
    }
}
