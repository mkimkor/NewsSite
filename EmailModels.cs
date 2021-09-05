using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsSite.Models
{
    public class Email
    {
        public Email()
        {
            this.Recipients = new List<Journalist>();
        }
        public List<Journalist> Recipients { get; set; }

    }
}