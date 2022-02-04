using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionToContentType
{
    public class Program
    {
        //can check for sample
        static void Main(string[] args)
        {
            int choice;
            Program program = new Program();
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\tExtension To ContentType and ContentType To Extension");
                Console.WriteLine("\t Enter 1 To Choose Extension To ContentType");
                Console.WriteLine("\t Enter 2 To Choose ContentType To Extension");
                Console.WriteLine("\t Enter 0 To Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    Console.Write("\t Enter The Extension : - ");
                    string extension = Console.ReadLine();
                    Console.WriteLine(program.GetContentTypeByExtension(extension));
                    Console.WriteLine("\t Press Any Key To Continue");
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.Write("\t Enter The ContentType : - ");
                    string extension = Console.ReadLine();
                    Console.WriteLine(program.GetExtensionByContentType(extension));
                    Console.WriteLine("\t Press Any Key To Continue");
                    Console.ReadKey();
                }

                Console.WriteLine("\n\n Enter 1 To Continue or Enter 0 To Exit");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice != 0);
            
        }

        /// <summary>
        /// Get Content Type FOr Extension By Passing Extenion As Parameter
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public string GetContentTypeByExtension(string extension)
        {
            if (!string.IsNullOrEmpty(extension))
            {
                Dictionary<string, string> contentDictionary = Content.GetContentData();
                if (contentDictionary.ContainsKey(extension))
                    return contentDictionary[extension];

                return "ContentType Isn't Available";
            }

            return "Given Extension Is Null Or Empty";
        }
        /// <summary>
        /// Get Extension For Content Type By Passing Content Type As Parameter
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public string GetExtensionByContentType(string contentType)
        {
            if (!string.IsNullOrEmpty(contentType))
            {
                Dictionary<string, string> contentDictionary = Content.GetContentData();
                if (contentDictionary.ContainsValue(contentType))
                    return contentDictionary.FirstOrDefault(x=> x.Value == contentType).Key;

                return "Extension Isn't Available";
            }

            return "Given ContentType Is Null or Empty";
        }
    }
}
