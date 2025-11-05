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
        public string GraduationLevel { get; set; } // Школьный, университетский и т.п.
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
        public int PassScore { get; set; } //Проходной балл

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
        public string Text { get; set; } // Текст вопроса
        public string Options { get; set; } // Варианты ответов (если тест)
        public string CorrectAnswer { get; set; } // Правильный ответ
        public int Points { get; set; }  // Баллы за вопрос
        public override string ToString()
        {
            return $"Text: {Text}, Options: {Options},CorrectAnswer: {CorrectAnswer},Points: {Points}";
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Text: {Text}, Options: {Options},CorrectAnswer: {CorrectAnswer},Points: {Points}");
        }
    }
}