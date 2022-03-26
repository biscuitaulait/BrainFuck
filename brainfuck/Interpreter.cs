using System;

namespace BrainFuck
{
    class Interpreter
    {
        public void BuildAndRun(string code)
        {
            char[] memory = new char[30000];
            int pointer = 0;
            int level = 0;

            for (int i = 0; i < code.Length; i++)
            {
                switch (code[i])
                {
                    case '+':
                        memory[pointer]++;
                        break;
                    case '-':
                        memory[pointer]--;
                        break;
                    case '[':
                        level = 1;
                        if (memory[pointer] == 0)
                        {
                            while (level > 0)
                            {
                                i++;
                                if (code[i] == '[')
                                    level++;
                                else if (code[i] == ']')
                                    level--;
                            }
                        }
                        break;
                    case ']':
                        level = 1;
                        if (memory[pointer] != 0)
                        {
                            while (level > 0)
                            {
                                i--;
                                if (code[i] == '[')
                                    level--;
                                else if (code[i] == ']')
                                    level++;
                            }
                        }
                        break;
                    case '<':
                        pointer--;
                        break;
                    case '>':
                        pointer++;
                        break;
                    case '.':
                        Console.Write(memory[pointer]);
                        break;
                    case ',':
                        memory[pointer] = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}