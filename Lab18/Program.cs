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
            try
            {

                Stack<char> stack1 = new Stack<char>();
                foreach (char skb in str)
                {


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

                        default:
                            if (stack1.Peek() == skb)
                            {
                                stack1.Pop();
                            }
                            else
                            {
                                Exception ex = new Exception("Скобки расставлены НЕ корректно");
                                throw ex;

                            }
                            break;
                    }
                }
                if (stack1.Count() == 0)
                {
                    Console.WriteLine("Скобки расставлены корректно");
                }
                else
                {
                    Console.WriteLine("Скобки расставлены не корректно");
                }
                Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}




//Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить,
//    корректно ли в ней расставлены скобки. Например, в строке ([]{ })[] скобки расставлены корректно, а в строке ([]] — нет.
//    Указание: задача решается однократным проходом по символам заданной строки слева направо; для каждой открывающей скобки в с
//    троке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека 
//    (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.


//case '}':
//    char i = stack1.Peek();
//    if (i == skb)
//    {
//        stack1.Pop();
//    }



//    break;
//case ')':
//    char j = stack1.Peek();
//    if (j == skb)
//    {
//        stack1.Pop();
//    }

//    break;
//case ']':
//    char n = stack1.Peek();
//    if (n == skb)
//    {
//        stack1.Pop();
//    }

//    break;



