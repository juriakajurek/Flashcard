using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.Core
{
    public class Flashcard
    {
        public string Id = Guid.NewGuid().ToString();
        public string Word { get; set; }
        public string Translation { get; set; }
        public string Meaning { get; set; }

        private bool IsLearned = false;
        private int Level = 1;

        public Flashcard(string word, string translation, string meaning = null)
        {
            this.Word = word;
            this.Translation = translation;
            this.Meaning = meaning;
        }

        public void setLearned()
        {
            IsLearned = true;
        }
        public void setNotLearned()
        {
            IsLearned = false;
        }
        public void LevelUp()
        {
            if (++this.Level > 5) this.IsLearned = true;
        }

        public void LevelDown()
        {
            if (this.Level > 1) this.Level--;
        }
    }
}
