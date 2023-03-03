using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Let me tell you about my friends: ");

        string[] friendsName = { "Vasya", "Kasee", "Valya" };

        int[] friendsAge = { 3, 2, 1 };

        // System.Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} year(s) old!");

        // Using while loop

        // short count = 0;

        // while (count<3)
        // {
        //     System.Console.WriteLine($"\nIsm: {friendsName[count]}, \nYosh: {friendsAge[count]}\n");
        //     count++;
        // }

        // Using do

        // short count2 = 0;
        // do
        // {
        //     System.Console.WriteLine($"\nIsm: {friendsName[count2]}\nYosh: {friendsAge[count2]}");
        //     count2++;
        // }while(count2<3);

        //  Using while loop

        // Console.Write("Please enter friends number: ");
        // short numberFriends = Convert.ToInt16(Console.ReadLine());

        // short countName = 0;

        // string[] newFriendName = new string[numberFriends];
        // short[] newFriendAge = new short[numberFriends];

        // while (countName<numberFriends)
        // {
        //     System.Console.Write($"\n\nPlease enter {countName+1} friend's name: \n");
        //     newFriendName[countName] = Convert.ToString(Console.ReadLine());
        //     System.Console.Write($"Enter {newFriendName[countName]}'s age: \n");
        //     newFriendAge[countName] = Convert.ToInt16(Console.ReadLine());
        //     countName++;
        // }

        // short countList = 0;
        // while (countName>countList)
        // {
        //     System.Console.WriteLine($"\nName: {newFriendName[countList]}");
        //     System.Console.WriteLine($"Age: {newFriendAge[countList]}");
        //     countList++;
        // }

        // Using do

        // System.Console.Write("Please enter your friends number: ");
        // short numberFriends = Convert.ToInt16(Console.ReadLine());

        // string[] nameList = new string[numberFriends];
        // short[] ageList =new short[numberFriends];
        // short countAdding = 0;
        // do
        // {
        //     System.Console.Write($"\n\nEnter {countAdding+1}-friend's name: ");
        //     nameList[countAdding] = Convert.ToString(Console.ReadLine());

        //     System.Console.Write($"\nEnter {nameList[countAdding]}'s age: ");
        //     ageList[countAdding] = Convert.ToInt16(Console.ReadLine());

        //     countAdding++;
        // }while(countAdding<numberFriends);

        // short countPrint = 0;
        // do
        // {
        //     System.Console.WriteLine($"\n\nName: {nameList[countPrint]}");
        //     System.Console.WriteLine($"\nAge: {ageList[countPrint]}");
        //     countPrint++;
        // }while(numberFriends!=countPrint);

        // System.Console.WriteLine("Enter number");
        // short number = Convert.ToInt16(Console.ReadLine());
        // for (short i=1; number>i; i++)
        // {
        //     System.Console.WriteLine(i);
        // }


        // Multiplication table

        for (short i=1; i<10; i++)
        {
            for (short i2=1; i2<10; i2++){
                System.Console.WriteLine($"{i} * {i2} = {i*i2}");
            }
        }
    }
}