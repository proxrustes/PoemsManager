using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.ModelsObject;

namespace WpfApp1
{
    public class Author
    {
        public int autorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Poem> poems { get; set; }
    }
}
