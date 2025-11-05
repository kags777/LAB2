using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Trial
    {
        public string Name { get; set; }    
        public string Time { get; set; }
        public Trial() { }
    }

    public class Exam : Trial 
    {
        public int QuestionCount { get; set; }
        public int Subject { get; set; }
    }

    public class FinalExam : Exam
    {
        
    }

    public class Test : Trial
    {
        public int QuestionCount { get; set; }
    }

    public class Question : Test
    {

    }
}
