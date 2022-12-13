using Homework_Reflection_Mail.Models;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {

        Console.Write("Please enter your name: ");
        string userFrstName = Console.ReadLine();

        Console.Write("Please enter your lastname: ");
        string userLstName = Console.ReadLine();


        Mail mail = new Mail();

        // MethodInfo ile de getirile biler. GetMethod() istifade ederek
        // MethodInfo daha oxunaqli, amma rahat istifade ucun bu uygun geldi mene

        mail.GetType().GetMethods().ToList().ForEach(method =>
        {
            if (method.Name.Equals("MailCreator"))
            {
                string userMail = method.Invoke(mail, new object[] { 
                    Regex.Replace(userFrstName, @"[^0-9a-zA-Z]+", ""), Regex.Replace(userLstName, @"[^0-9a-zA-Z]+", "")
                }).ToString();
                /*Console.WriteLine(userMail);*/
            }
        });


        // Properties
        mail.GetType().GetProperties().ToList().ForEach(property => {

            Console.WriteLine(property.Name + ": " + property.GetValue(mail));
        });


    }
}