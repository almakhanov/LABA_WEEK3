using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{

    class State
    {
        private int index;
        private DirectoryInfo folder;
        public DirectoryInfo Folder
        {
            get { return folder; }
            set
            {
                folder = value;
                MaxIndex = folder.GetDirectories().Length;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value >= 0 && value < MaxIndex)
                {
                    index = value;
                }
            }
        }
        public int MaxIndex { get; set; }

        public void Rec(State state)
        {

        }
    }

    class Program
    {
        static void ShowFolderContent(State state)
        {
            Console.Clear();
            DirectoryInfo[] list = state.Folder.GetDirectories();
            for (int i = 0; i < list.Length; ++i)
            {
                if (i == state.Index)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(list[i].Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Stack<State> layers = new Stack<State>();
            bool alive = true;
            State state = new State { Folder = new DirectoryInfo(@"C:\Users\n_almakhanov\Documents\Visual Studio 2013"), Index = 0 };
            layers.Push(state);

            while (alive)
            {
                ShowFolderContent(layers.Peek());

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Enter:
                        DirectoryInfo f = layers.Peek().Folder.GetDirectories()[layers.Peek().Index];
                        State substate = new State
                        {
                            Folder = f,
                            Index = 0
                        };
                        layers.Push(substate);
                        break;
                    case ConsoleKey.Backspace:
                        layers.Pop();
                        break;
                    case ConsoleKey.Escape:
                        alive = false;
                        break;
                    case ConsoleKey.DownArrow:
                        layers.Peek().Index++;
                        break;
                    case ConsoleKey.UpArrow:
                        layers.Peek().Index--;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
