using LAB2;

MyList<int> list = new MyList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
Console.WriteLine("Первый список:");
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("\nДобавляю в начало списка новый элемент:");
list = list + 4;
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nВторой список:");
MyList<int> list1 = new MyList<int>();
list1.Add(4);
list1.Add(5);
list1.Add(3);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nУдаляем первый элемент из второго списка:");
list--;

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine(list == list1 ? "Первый и второй списки равны." : "Первый и второй списки не равны.");

Console.WriteLine();

Console.WriteLine("Два списка соединенных вместе:");
MyList<int> multList = new MyList<int>();
multList = list * list1;

foreach (var item in multList)
{
    Console.WriteLine(item);
}

MyList<string> strList = new MyList<string>();
strList.Add("Привет");
strList.Add("hello сергей Здравствуйте");
strList.Add("Здравствуйте Сергей");
strList.Add("hello");

Console.WriteLine("\nСтроковый список:");
foreach (var item in strList)
{
    Console.WriteLine(item);
}
Console.WriteLine("\nКоличество заглавных букв в словах:");
int count = MyListExtensions.CountWordsStartingWithUpper(strList);
Console.WriteLine(count);
MyListExtensions.CountRepeatedWords(strList);

Console.WriteLine("\n-------------------------------------------------------\n");
Console.WriteLine("Работа с испытаниями:\n");

Trial[] trials = new Trial[4];

trials[0] = new Exam
{
    Name = "Annual Exam",
    Subject = "Math",
    QuestionCount = 10,
    MaxScore = 100,
    Time = "10:00",
    Examiner = "Prof. Ivanov"
};

trials[1] = new FinalExam
{
    Name = "Final Physics",
    Subject = "physics",
    QuestionCount = 15,
    MaxScore = 150,
    GraduationLevel = "University",
    Commission = "Physics Dept.",
    Time = "30:00",
    Examiner = "Dr. Petrov"
};

trials[2] = new Test
{
    Name = "Chemistry Test",
    Subject = "Chemistry",
    QuestionCount = 5,
    PassScore = 60,
    Time = "12:00",
    Examiner = "Prof. Sidorov"
};

trials[3] = new Question
{
    Text = "Что такое наследование в программировании?",
    Options = "A) Механизм, позволяющий одному классу использовать свойства и методы другого класса. \n" +
    "B) Процесс, при котором программа автоматически копирует весь код из одного проекта в другой. \n" +
     "C) Способ организации данных в базе данных через таблицы и связи.",
    CorrectAnswer = "A",
    Points = 4
};

foreach (var trial in trials)
{
    trial.ShowInfo();

    Console.WriteLine("\nПереопределенный метод ToString():\n" + trial.ToString());

    Console.WriteLine();
    Console.WriteLine("------------------------------------------------");
}      