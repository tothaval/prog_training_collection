using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNote
{
    public class NoteData
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime dateTime { get; set; }
        public StringBuilder content { get; set; }

        public NoteData()
        {
            this.id= 0;
            this.dateTime = DateTime.Now;

            this.title = $"title";
            content = new StringBuilder();
        }

    }
}
