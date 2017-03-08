using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MinStack obj = new MinStack();
            obj.Push(0);
            obj.Push(1);
            obj.Push(0);
            
            int param_4 = obj.GetMin();
            
            Console.WriteLine("Min: {0}", param_4);
            
            obj.Pop();
            int param_3 = obj.GetMin();
            Console.WriteLine("Top: {0}", param_3);
            
            
        }
        
        public class MinStack {
            
            Stack<int> sta;
            Stack<int> min;
            
            /** initialize your data structure here. */
            public MinStack() {
                sta=new Stack<int>();
                min=new Stack<int>();
            }
            
            public void Push(int x) {
                sta.Push(x);
                if(min.Count==0)
                {
                    min.Push(x);
                }else
                {
                    if(x<=min.Peek())
                    {
                        min.Push(x);
                    }
                }
            }
            
            public void Pop() {
                if(sta.Count==0 || min.Count==0){
                    
                }else
                {
                    int pop=sta.Pop();
                    if(pop==min.Peek())
                    {
                        min.Pop();
                    }
                }
            }
            
            public int Top() {
                int top=sta.Peek();
                return top;
            }
            
            public int GetMin() {
                return min.Peek();
            }
        }
    }
}
