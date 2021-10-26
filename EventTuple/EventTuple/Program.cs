using System;
using System.Reflection;

namespace EventTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Event

            //Student s1 = new Student("Emil Kerimov", 80);
            //s1.SendMessageEvent += SendMessageForStudent1;

            //Student s2 = new Student("Perviz Asadov", 80);
            //s2.SendMessageEvent += (score) =>
            //{
            //    if (score > 65)
            //    {
            //        Console.WriteLine("MashAllah");
            //        return;
            //    }

            //    Console.WriteLine("Teessuf");
            //};

            //s2.SendMessageEvent += (score) => Console.WriteLine("Score: " + score);

            ////s1.SendMessage();
            ////s2.SendMessage();

            //s1.NotifyEvent += (text) =>
            //{
            //    Console.WriteLine("Send as Email " + text);
            //};
            //s2.NotifyEvent += (text) => Console.WriteLine($"Send as Sms {text}");
            //s2.NotifyEvent += (text) => Console.WriteLine($"Send as Email {text}");

            //s1.Notify();
            //s2.Notify();

            #endregion

            #region Tuple - reference type

            //Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Idris", "Jafarzade");
            //Tuple<int, string, string> person = Tuple.Create(1, "Idris", "Jafarzade");
            //var person = Tuple.Create(1, "Idris", "Jafarzade");
            //Console.WriteLine(person.Item1);
            //Console.WriteLine(person.Item2);
            //Console.WriteLine(person.Item3);
            //Console.WriteLine(person);

            //var person2 = GetTuple();
            //Console.WriteLine(person2);

            #endregion

            #region ValueTuple

            //ValueTuple<int, string, string> person = (1, "Azim", "Memmedhesenov");
            //var person = (1, "Azim", "Memmedhesenov");
            //Console.WriteLine(person.Item1);
            //var person = (id: 1, name: "Azim", surname: "Memmedhesenov");
            //Console.WriteLine(person.id);
            //Console.WriteLine(person.name);

            //(int id, string name, string surname) person = GetValueTuple();
            //Console.WriteLine(person.name);

            #endregion

            #region Reflection

            //String text = "";
            //string text2 = "";
            //Int32 a = 10;
            //int b = 10;

            //Assembly assembly = Assembly.GetExecutingAssembly();

            //foreach (var item in assembly.GetTypes())
            //{
            //    Console.WriteLine(item.Namespace + "-" + item.Name);

            //    foreach (var propertyInfo in item.GetProperties())
            //    {
            //        Console.WriteLine(propertyInfo.PropertyType + ": " + propertyInfo.Name);
            //    }
            //}

            #endregion

            //GameType enum olsun, oyunlarin type-larin saxlasin ozunde,
            //ozunuz dushunun hansi type-lar.
            //Game class-i olsun(string Name ve GameType Type)
            //property-leri olsun, yalniz ctor-da set olsun.
            //Bir event PlayGameEvent olsun return type=in ozunuz dushunun.
            //Ve bir method yazin PlayGame() hansindaki PlayGameEvent chagirilir.
            //Program.cs-de obyekt yaradib hemde
            //PlayGameEvent-e qeyd etmelisizki meselen
            //(Console.WriteLine("Bu oyun PS4-de oynanila biler."),
            //Console.WriteLine("Bu oyun PS3-de oynanila biler."),
            //Console.WriteLine("Bu oyun Xbox-da oynanila biler."),
            //Console.WriteLine("Bu oyun PC-de oynanila biler.")).
            //Ve sonra PlayGame() methodunu chagiranda sizin Event-e
            //hansi methodu verdiyinizden asili olaraq cavabi gostersin.
        }

        //static (int, string, string) GetValueTuple()
        //{
        //    return (1, "Azim", "Memmedhesenov");
        //}

        //static ValueTuple<int, string, string> GetValueTuple()
        //{
        //    return (id: 1, name: "Azim", surname: "Memmedhesenov");
        //}

        //static Tuple<int, string, string> GetTuple()
        //{
        //    return Tuple.Create(2, "Alisimran", "Memmedli");
        //}

        //static void SendMessageForStudent1(int score)
        //{
        //    if (score > 65)
        //    {
        //        Console.WriteLine("Aferin");
        //        return;
        //    }

        //    Console.WriteLine("Teessuf");
        //}
    }

    class Student
    {
        public string Fullname { get; }

        public int Score { get; }

        public event Action<int> SendMessageEvent;

        public event Action<string> NotifyEvent;

        public Student(string fullname, int score)
        {
            Fullname = fullname;
            Score = score;
        }

        public void SendMessage()
        {
            SendMessageEvent(Score);
        }

        public void Notify()
        {
            NotifyEvent(Fullname);
        }
    }

    class Person
    {

    }

    class Test
    {
        public int Id { get; set; }
    }
}
