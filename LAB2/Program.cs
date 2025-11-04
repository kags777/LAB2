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
Console.WriteLine("Добавляю в начало списка новый элемент:");
list = list + 4;

Console.WriteLine("Второй список:");
MyList<int> list1 = new MyList<int>();
list1.Add(4);
list1.Add(5);
list1.Add(3);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("Удаляем первый элемент из второго списка");
list--;
Console.WriteLine();

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine();

foreach (var item in list1)
{
    Console.WriteLine(item);
}

Console.WriteLine(list == list1 ? "списки равны" : "списки не равны");

Console.WriteLine();

MyList<int> multList = new MyList<int>();
multList = list * list1;

foreach (var item in multList)
{
    Console.WriteLine(item);
}

MyList<string> strList = new MyList<string>();
strList.Add("Привет");
strList.Add("gока");
strList.Add("Здравствуйте РАПАПАМ РАПАПАМ");
strList.Add("hello");

Console.WriteLine();
int count = MyListExtensions.CountWordsStartingWithUpper(strList);
Console.WriteLine(count);