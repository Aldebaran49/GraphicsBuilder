using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursachGraphics
{
    internal class EquationSolver
    {
        string Equation;
        char[] infixArray;
        EquationSolver() { }
        public void getFromString(string s)
        {
            Equation = s;
        }
        public void buildEquation()
        {
            infixArray = Equation.ToCharArray();
            
        }
        public double calculate(double x)
        {
            return 0.1;
        }
        private static int getPriority (string s)
        {
            if (s.Equals("+") || s.Equals("-"))
                return 1;
            else if (s.Equals("*") || s.Equals("/"))
                return 2;
            else if (s.Equals("^"))
                return 3;
            else
                return 0;
        }
        public string[] InfixToPostfix()
        {
            var stack = new Stack<string>();
            var postfix = new Stack<string>();

            string st;
            int ln_spotted = 0;

            for (int i = 0; i < infixArray.Length; i++)
            {
                if (!("()*/+-^".Contains(infixArray[i])))
                {
                    if (infixArray[i].Equals("l") && infixArray[i].Equals("n")) // ОБНАРУЖЕН ln
                    {
                        i++;
                        ln_spotted++;
                        continue;
                    }
                    else
                    {
                        postfix.Push(infixArray[i].ToString());
                    }
                }
                else // ОБНАРУЖЕН БИНАРНЫЙ ОПЕРАТОР
                {
                    if (infixArray[i].Equals("("))
                    {
                        stack.Push("(");
                    }
                    else if (infixArray[i].Equals(")"))
                    {
                        st = stack.Pop();
                        while (!(st.Equals("(")))
                        {
                            postfix.Push(st);
                            st = stack.Pop();
                        }
                        if (ln_spotted > 0)
                        {
                            ln_spotted--;
                            postfix.Push("ln");
                        }
                    }
                    else
                    {
                        while (stack.Count > 0)
                        {
                            st = stack.Pop();
                            if (getPriority(st) >= getPriority(infixArray[i].ToString()))
                            {
                                postfix.Push(st);
                            }
                            else
                            {
                                stack.Push(st);
                                break;
                            }
                        }
                        stack.Push(infixArray[i].ToString());
                    }
                }
            }
            while (stack.Count > 0)
            {
                postfix.Push(stack.Pop());
            }

            return postfix.Reverse().ToArray();
        }
    }
}

