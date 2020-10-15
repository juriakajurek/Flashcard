using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.Core.ViewModels
{
    public class GameViewModel
    {

        public int Level { get; set; }
        public IEnumerable<Flashcard> Flashcards { get; set; }
    }
}
