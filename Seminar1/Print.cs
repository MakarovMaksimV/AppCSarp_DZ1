using System;
namespace Seminar1
{
	public class Print
	{
        public static void PrintMembers(FamilyMembers[] familyMembers)
        {
            string str;
            if (familyMembers != null)
            {
                foreach (var el in familyMembers)
                {
                    if (el != null)
                    {
                        str = $"{el.Relationship}: {el.FullName}, возраст:{el.Age}";
                        DrawFrame(str);
                    }
                    else
                        break;
                }
            }
            else
                Console.WriteLine("Неn данных");
        }

        public static void PrintConsort(FamilyMembers familyMembers)
        {
            string str;
            if (familyMembers.gender == Gender.male)
            {
                str = $"Муж: {familyMembers.FullName}";
                DrawFrame(str);
            }
            else
            {
                str = $"Жена: {familyMembers.FullName}";
                DrawFrame(str);
            }
        }

        public static void DrawFrame(string text)
        {
            char horizontal = '-';
            char vertical = '|';
            char corner = '+';
            int length = text.Length+2;
            Console.WriteLine(corner + new string(horizontal, length) + corner);
            Console.WriteLine(vertical + " " + text + " " + vertical);
            Console.WriteLine(corner + new string(horizontal, length) + corner);
        }
    }
}

