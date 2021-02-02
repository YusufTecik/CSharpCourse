using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //İntro();
            string sentence = "My name is Yusuf";

            var result = sentence.Length; //kaç karakterden oluşuyoru bulur
            var result2 = sentence.Clone();//klon oluşturur
            sentence = "My name is Ayşe";

            bool result3 = sentence.EndsWith("e");// f ile bitip bitmediğini bulur
            bool result4 = sentence.StartsWith("My");//my name ile başlayıp başlamadığını bulur

            var result5 = sentence.IndexOf("name");//name içerip içermediğini bulur
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2,5);

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void İntro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
