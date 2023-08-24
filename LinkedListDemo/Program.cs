using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Important points of LinkedList
            ///1. It implements ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
            ///2. it also supports enumerators (count the sequence)
            ///3. Every Node in a LinkedList<T> object is of the tpye LinkedListNode<T>
            ///4. If the LinkedList is empty, the first and last properties contain null.
            ///5.  It does not support chaining, splitting, cycles or other feautres that can leave the list in an inconsistent state.
            ///6. store duplicates elemenets of the same type.
            ///7. you can remove nodes and reinsert them, either in the same list or in other list, which results in no additional objects allocated on the heap.

            LinkedList<string> linklistObj = new LinkedList<string>()

                int[] vs = new int[10];

            
            linklistObj.AddLast("Rock");
            linklistObj.AddLast("Leo");
           var nodetoadd =  linklistObj.AddLast("Soni");

            var nodetoRemove = linklistObj.AddFirst("test data");


            linklistObj.AddAfter(linklistObj.AddFirst("test data"), "test data 123");



            

            foreach (var item in linklistObj)
            {
                Console.WriteLine(item);

                //TYPECASTING CODE HERE
            }


            linklistObj.Remove(nodetoRemove);
            



        }
    }
}
