using System;
using System.Text;
namespace _9._1__System.String类
{
    class Program
    {
        static void Main(string[] args)
        {
            string qreetingText = "Hello from all the guys at Wrox Press. ";
            qreetingText += "We do hope you enjoy this book as much as we enjoyed writing it.";
            for(int i ='z';i>='a';i--)
            {
                char old1 = (char)i;
                char new1 = (char)(i + 1);
                qreetingText = qreetingText.Replace(old1, new1);
            }
            for(int i='z';i>='A';i--)
            {
                char old1 = (char)i;
                char new1 = (char)(i + 1);
                qreetingText = qreetingText.Replace(old1, new1);
            }
            Console.WriteLine("Encided:\n" + qreetingText);
            StringBuilder stringBuilder = new StringBuilder("Hello from all the guys at Wrox Press. ", 150);
            stringBuilder.AppendFormat("We do hope you enjoy this book as much as we " + "enjoyed writing it");
            Console.WriteLine("Not Encoded:\n" + stringBuilder);
            for (int i = 'z'; i >= 'a'; i--)
            {
                char old1 = (char)i;
                char new1 = (char)(i + 1);
                stringBuilder = stringBuilder.Replace(old1, new1);
            }
            for (int i = 'z'; i >= 'A'; i--)
            {
                char old1 = (char)i;
                char new1 = (char)(i + 1);
                stringBuilder = stringBuilder.Replace(old1, new1);
            }
            Console.WriteLine("Encided:\n" + stringBuilder);
            Console.ReadKey();
        }
    }
}
