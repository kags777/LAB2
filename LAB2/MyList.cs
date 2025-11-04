using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class MyList<T> : IEnumerable<T>
    {
        private List<T> objects;
        int Count { get { return objects.Count; } }
        public MyList()
        {
            objects = new List<T>();
        }
        // индексатор
        public T this[int index]
        {
            get => objects[index];
            set => objects[index] = value;
        }
        public void Add(T item)
        {
            objects.Add(item);
        }
        public void Clear()
        {
            objects.Clear();
        }
        public bool Remove(T item)
        {
            return objects.Remove(item);
        }
        public void RemoveAt(int index)
        {
            objects.RemoveAt(index);
        }
        public bool Contains(T item)
        {
            return objects.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static MyList<T> operator +(MyList<T> list, T item)
        {
            MyList<T> newList = new MyList<T>();
            newList.Add(item);
            foreach (T obj in list.objects)
            {
                newList.Add(obj);
            }
            return newList;
        }
        public static MyList<T> operator --(MyList<T> list)
        {
            if (list.Count == 0)
                Console.WriteLine("Ошибка! Список пустой!");
            else list.RemoveAt(0);
            return list;
        }
        public static MyList<T> operator *(MyList<T> list, MyList<T> otherList)
        {
            MyList<T> newList = new MyList<T>();
            foreach (T obj in list.objects)
            {
                newList.Add(obj);
            }
            foreach (T obj in otherList.objects)
            {
                newList.Add(obj);
            }
            return newList;
        }

        public static bool operator ==(MyList<T> list, MyList<T> otherList)
        {
            if (ReferenceEquals(list, otherList)) return true;
            if (list is null || otherList is null) return false;
            return list.objects.SequenceEqual(otherList.objects);
        }

        public static bool operator !=(MyList<T> list, MyList<T> otherList)
        {
            return !(list == otherList);
        }


    }
}
