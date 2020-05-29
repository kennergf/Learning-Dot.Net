using System;
using System.Collections.ObjectModel;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection");
            Collection<string> collection = new Collection<string>();
            collection.Insert(0, "Joe");
            collection.Insert(0, "Joe");
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Unique Collection");
            UniqueCollection<string> uniqueCollection = new UniqueCollection<string>();
            uniqueCollection.Insert(0, "Jane");
            uniqueCollection.Insert(0, "Jane");
            foreach(var item in uniqueCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class UniqueCollection<T> : Collection<T>
    {
        protected override void InsertItem(int index, T item)
        {
            if(!this.Contains(item))
            {
                base.InsertItem(index, item);
            }
        }

        protected override void SetItem(int index, T item)
        {
            if(!this.Contains(item))
            {
                base.SetItem(index, item);
            }
        }
    }
}
