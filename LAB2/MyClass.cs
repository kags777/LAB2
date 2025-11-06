using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public abstract class Trial
    {
        public string Name { get; set; }    
        public string Time { get; set; }
        public string Examiner { get; set; }
        public Trial() { }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Trial: {Name}, Time: {Time}, Examiner: {Examiner}");
        }

        public override string ToString()
        {
            return $"Trial: {Name}, Time: {Time}, Examiner: {Examiner}";
        }
    }

    public class Exam : Trial 
    {
        public int QuestionCount { get; set; }
        public string Subject { get; set; }
        public int MaxScore { get; set; }

        public override string ToString()
        {
            return $"Exam: {Name}, Subject: {Subject}, Questions: {QuestionCount}, Max Score: {MaxScore}";
        }
        
        public override bool Equals(object obj)
        {
            if (obj is Exam other)
            {
                return Name == other.Name
                       && Subject == other.Subject &&
                       QuestionCount == other.QuestionCount &&
                       MaxScore == other.MaxScore;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Subject, QuestionCount, MaxScore);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"QuestionCount: {QuestionCount}, Subject: {Subject}, MaxScore: {MaxScore}");
        }
    }

    public sealed class FinalExam : Exam
    {
        public string GraduationLevel { get; set; }
        public string Commission { get; set; }
        public override string ToString()
        {
            return $"GraduationLevel: {GraduationLevel}, Commission: {Commission}";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"GraduationLevel: {GraduationLevel}, Commission: {Commission}");
        }
    }

    public class Test : Trial
    {
        public string Subject { get; set; }
        public int QuestionCount { get; set; }
        public int PassScore { get; set; } 

        public override string ToString()
        {
            return $"Subject: {Subject}, QuestionCount: {QuestionCount}, PassScore: {PassScore}";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Subject: {Subject}, QuestionCount: {QuestionCount}, PassScore: {PassScore}");
        }
    }

    public class Question: Trial
    {
        public string Text { get; set; } 
        public string Options { get; set; } 
        public string CorrectAnswer { get; set; } 
        public int Points { get; set; }  
        public override string ToString()
        {
            return $"Text: {Text}\nOptions:\n{Options} \nCorrectAnswer:{CorrectAnswer}\nPoints: {Points}";
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Text: {Text}\nOptions:\n{Options} \nCorrectAnswer:{CorrectAnswer}\nPoints: {Points}");
        }
    }
}