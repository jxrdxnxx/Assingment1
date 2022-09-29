using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Channels;

//Start

Console.WriteLine("Your name is Indigo and you have a house elf called Corbey helping you. You work in the Ministry of Magic as an Auror (dark wizard catcher).");
Thread.Sleep(1500);
Console.WriteLine("Valdis (who is the Dark Wizard) has escaped from azkaban. Your job is to find him and send him back to azkaban!");
Thread.Sleep(1500);
Console.WriteLine("");
Console.WriteLine("Do you accept this task? y/n ");
string yn = Console.ReadLine();
if (yn == "y" || yn == "Y")
{
    Console.WriteLine("Good I will give you the first hint into finding him!");
}
else if (yn == "n"|| yn == "N")
{
    Console.WriteLine("Oh ok, well I hope you enjoy your life Indigo!");
    Environment.Exit(0);
}

//Story

Console.WriteLine("");
Thread.Sleep(1500);
Console.WriteLine("He is hiding in one of three places; where did you want to look first?");
Thread.Sleep(1500);
Console.WriteLine("(1) Forbidden forest, (2) London - near the Ministry of Magic, (3) Falmouth - his birth home");
string pl1 = Console.ReadLine();
if (pl1 == "1")
{
    Console.WriteLine("You look in the forbidden forest");
}



//Final Battle - Valdis

int Vhealth = 150;
int Ihealth = 100;
Random Def = new Random();
Random Att = new Random();

Console.WriteLine("You are in the final battle with Valdis, you have two options to either defend or attack.");
Thread.Sleep(1500);
Console.WriteLine("Attack generates a random number where it will take off some of Valdis' health depending on the number");
Thread.Sleep(1500);
Console.WriteLine("Defend generates a random number where you can add that number to your health");
Thread.Sleep(1500);
Console.WriteLine("You will only get to pick one every round so choose wisely, as Valdis could kill you in one turn");
Thread.Sleep(1500);
Console.WriteLine("You will be at battle until one of you has fallen.");
Thread.Sleep(1500);
Console.WriteLine("Your health starts at 100 and Valdis' starts at 120.");
Console.WriteLine("");

while (Vhealth >= 0 || Ihealth >= 0)
{
    Console.WriteLine("");
    Console.WriteLine("Do you want to attack or defend Valdis?");
    string AD = Console.ReadLine();
    if (AD == "Attack" || AD == "attack")
    {
        int Att1 = Att.Next(1, 40);
        Thread.Sleep(1500);
        Console.WriteLine("Your attack damage is " + Att1);
        int He1 = Vhealth - Att1;
        Thread.Sleep(1500);
        Console.WriteLine("Valdis' health is at " + He1);
        Vhealth = He1;
        if(Vhealth <= 0 || He1 <= 0)
        {
            break;
        }    

        int VAtt1 = Att.Next(1, 40);
        Thread.Sleep(1500);
        Console.WriteLine("Valdis had an attack of " + VAtt1);
        int YHel = Ihealth - VAtt1;
        Thread.Sleep(1500);
        Console.WriteLine("You health is at " + YHel);
        Ihealth = YHel;
        if (Ihealth <= 0 || YHel <= 0)
        {
            break;
        }
    }
    else if (AD == "defend" || AD == "Defend")
    {
        int Def1 = Def.Next(1, 50);
        int Hel2 = Def1 + Ihealth;
        Thread.Sleep(1500);
        Console.WriteLine("Your defence increased by " + Def1);
        Ihealth = Ihealth + Def1;
        Thread.Sleep(1500);
        Console.WriteLine("Your health is at " + Ihealth);
        if (Ihealth <= 0)
        {
            break;
        }

        int VAtt1 = Att.Next(1, 40);
        Thread.Sleep(1500);
        Console.WriteLine("Valdis had an attack of " + VAtt1);
        int YHel = Ihealth - VAtt1;
        Thread.Sleep(1500);
        Console.WriteLine("You health is at " + YHel);
        Ihealth = YHel;
        if (Ihealth <= 0|| YHel <= 0)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
}

if (Vhealth <= 0)
{
    Thread.Sleep(1500);
    Console.WriteLine("");
    Console.WriteLine("You have won against Valdis! He will be locked back up in azkaban!");
    Thread.Sleep(1500);
    Console.WriteLine("Your final health was: " + Ihealth);
}
else if (Ihealth <= 0)
{
    Thread.Sleep(1500);
    Console.WriteLine("");
    Console.WriteLine("You have lost, Valdis will carry on killing muggles!");
    Thread.Sleep(1500);
    Console.WriteLine("Valdis' final health was: " + Vhealth);
}