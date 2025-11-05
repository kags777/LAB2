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
Console.WriteLine(list == list1 ? "первый и второй списки равны." : "первый и второй списки не равны.");

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
