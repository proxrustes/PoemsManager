using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.ModelsObject
{
    public class Poem
    {
        public int poemId { get; set; }
        public int authorid { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public string? additional { get; set; }
    }
}
