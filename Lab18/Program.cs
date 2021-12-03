using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{([}])";

            
            Stack <char>stack1 = new Stack<char>();
            foreach ( char skb in str)


                switch (skb)
                {
                    case '{':
                        stack1.Push('}');
                        break;
                    case '(':
                        stack1.Push(')');
                        break;
                    case '[':
                        stack1.Push(']');
                        break;
                    case '}':
                        if (stack1.Equals ('}'))
                            stack1.Pop();
                        break;
                    case ')':
                        if (stack1.Equals(')'))
                            stack1.Pop();
                        break;
                    case ']':
                        if (stack1.Equals(']'))
                            stack1.Pop();
                        break;
                }
            
            try
            {
                stack1.Pop();
                Console.WriteLine("Скобки расставлены не корректно");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Стек пуст.скобки расставлены корректно");
            }
            Console.ReadKey();
        }
    }
}



//Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить,
//    корректно ли в ней расставлены скобки. Например, в строке ([]{ })[] скобки расставлены корректно, а в строке ([]] — нет.
//    Указание: задача решается однократным проходом по символам заданной строки слева направо; для каждой открывающей скобки в с
//    троке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека 
//    (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.
