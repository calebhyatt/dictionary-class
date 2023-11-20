namespace Project1
{
    internal class Webster
    {
        /* Properties */

        public enum States { ReadWrite, ReadOnly, Disabled };
        private List<string> Words { get; }
        private States State { get; set; } = States.ReadWrite;

        /* Initialization */

        // Initialize empty object
        public Webster()
        {
            this.Words = new List<string>();
        }

        // Initialize object with one word
        public Webster(string word)
        {
            this.Words = new List<string>() { word };
        }

        // Initialize object with array of words
        public Webster(string[] words)
        {
            var temp = new List<string>();

            foreach (string word in words)
            {
                temp.Add(word);
            }

            this.Words = temp;
        }

        // Initialize object with list of words
        public Webster(List<string> words)
        {
            this.Words = words;
        }

        /* Methods */

        public List<string> GetWordsForPrefix(string prefix)
        {
            if (this.State == States.Disabled)
            {
                return new List<string>();
            }

            var temp = this.Words.Where(w => w.StartsWith(prefix)).ToList();

            return temp;
        }

        public List<string> GetAllWords()
        {
            if (this.State == States.Disabled)
            {
                return new List<string>();
            }

            return this.Words;
        }

        // Add one word
        public void Add(string word)
        {
            if (this.State == States.ReadWrite)
            {
                if (this.Words.IndexOf(word) > -1)
                {
                    throw new Exception($"{word} is already in this instance of Webster.");
                }

                this.Words.Add(word);
                this.Words.Sort();
            }
        }

        // Add array of words
        public void Add(string[] words)
        {
            if (this.State == States.ReadWrite)
            {
                foreach (string word in words)
                {
                    if (this.Words.IndexOf(word) > -1)
                    {
                        throw new Exception($"{word} is already in this instance of Webster.");
                    }
                }

                this.Words.AddRange(words);
                this.Words.Sort();
            }
        }

        // Add list of words
        public void Add(List<string> words)
        {
            foreach (string word in words)
            {
                if (this.Words.IndexOf(word) > -1)
                {
                    throw new Exception($"{word} is already in this instance of Webster.");
                }
            }

            if (this.State == States.ReadWrite)
            {
                this.Words.AddRange(words);
                this.Words.Sort();
            }
        }

        // Delete one word
        public void Delete(string word)
        {
            if (this.State == States.ReadWrite)
            {
                var index = this.Words.IndexOf(word);

                if (index > -1)
                {
                    this.Words.RemoveAt(index);
                    this.Words.Sort();
                }
                else
                {
                    throw new Exception($"{word} was not found in this instance of Webster.");
                }
            }
        }

        // Delete array of words
        public void Delete(string[] words)
        {
            if (this.State == States.ReadWrite)
            {
                foreach (string word in words)
                {
                    var index = this.Words.IndexOf(word);

                    if (index > -1)
                    {
                        this.Words.RemoveAt(index);
                        this.Words.Sort();
                    }
                    else
                    {
                        throw new Exception($"{word} was not found in this instance of Webster.");
                    }
                }
            }

        }

        // Delete list of words
        public void Delete(List<string> words)
        {
            if (this.State == States.ReadWrite)
            {
                foreach (string word in words)
                {
                    var index = this.Words.IndexOf(word);

                    if (index > -1)
                    {
                        this.Words.RemoveAt(index);
                        this.Words.Sort();
                    }
                    else
                    {
                        throw new Exception($"{word} was not found in this instance of Webster.");
                    }
                }
            }

        }

        // Added "confirm" for an extra level of security
        public bool DeleteAllWords(bool confirm)
        {
            if (this.State == States.ReadWrite)
            {
                if (!confirm)
                {
                    return false;
                }

                this.Words.Clear();
                return true;
            }

            return false;
        }

        public int Size()
        {
            return this.Words.Count;
        }

        public void SetState(States state)
        {
            this.State = state;
        }
    }
}
