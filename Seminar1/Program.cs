namespace Seminar1;
class Program
{
    static void Main(string[] args)
    {
        FamilyMembers gFather1 = new FamilyMembers("Дедушка",80,Gender.male,"Додонов Павел Петрович");
        FamilyMembers gFather2 = new FamilyMembers("Дедушка",88, Gender.male, "Макаров Юрий Анатольевич");
        FamilyMembers gMother1 = new FamilyMembers("Бабушка",90, Gender.famale, "Додонова Вера Петровна");
        FamilyMembers gMother2 = new FamilyMembers("Бабушка",85, Gender.famale, "Макарова Маргарита Афанасьевна");
        FamilyMembers Father = new FamilyMembers("Папа",61, Gender.male, "Макаров Владимир Юрьевич", gMother2, gFather2);
        FamilyMembers Mother = new FamilyMembers("Мама",60, Gender.famale, "Макаров Елена Павловна", gMother1, gFather1);
        FamilyMembers Son = new FamilyMembers("Сын",32, Gender.male, "Макаров Максим Владимрович", Mother, Father);
        FamilyMembers Doughter = new FamilyMembers("Дочь",35, Gender.famale, "Кондратьева Екатерина Владимировна", Mother, Father);
        
        // Определение бабушек и дедушек
        var GrandMothers = Son.GetGrandParents(Gender.male);
        Print.PrintMembers(GrandMothers);
        var GrandFather = Son.GetGrandParents(Gender.famale);
        Print.PrintMembers(GrandFather);

        // Определение родителей
        var SonMother = Son.GetParents(Gender.male);
        Print.PrintMembers(SonMother);
        var DoughterFather = Doughter.GetParents(Gender.famale);
        Print.PrintMembers(DoughterFather);

        //Определение детей
        FamilyMembers[] children = { Son, Doughter };
        Mother.Children = children;
        Print.PrintMembers(children);

        //Определение мужа/жены
        gFather1.Consort = gMother1;
        var ConsortGrandParents1 = gFather1.GetConsort();
        Print.PrintConsort(ConsortGrandParents1);
        Console.ReadKey();
    }

}



