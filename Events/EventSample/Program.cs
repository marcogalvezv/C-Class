using System;

namespace EventSample
{
    delegate void myEventHandler( string s);
    class EventExample
    {
        public event myEventHandler StrChanged;

        private string strValue;
        public string StrValue
        {
            get { return strValue; }
            set { strValue = value;
                StrChanged(strValue);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            EventExample myEvt = new EventExample();
            myEvt.StrChanged += new myEventHandler(myEvt_valueChanged);
            myEvt.StrChanged += delegate { Console.WriteLine("Anonimous method"); };
            string str;
            do
            {
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                    myEvt.StrValue = str;
            } while (!str.Equals("exit"));


            Console.ReadLine();
        }

        static void myEvt_valueChanged(string newValue)
        {
            Console.WriteLine("The value changed to {0}", newValue);
        }
    }
}