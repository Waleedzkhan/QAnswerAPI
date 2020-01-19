using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAnswerAPI.Models
{
    public class Answer
    {
        public long Id { get; set; }
        public String Body { get; set; }
        public bool Accepted { get; set; }
    }
}
