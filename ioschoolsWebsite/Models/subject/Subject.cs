using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ioschoolsWebsite.Models.subject.viewmodels;

namespace ioschoolsWebsite.Models.subject
{
    public class Subject
    {
        public long id { get; set; }
        public string name { get; set; }
        public byte? position { get; set; }

        public Subject(long id, string name, byte? position)
        {
            this.id = id;
            this.name = name;
            this.position = position;
        }
    }

    
}