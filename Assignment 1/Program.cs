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
    Console.Clear();
}
else if (yn == "n"|| yn == "N")
{
    Console.WriteLine("Oh ok, well I hope you enjoy your life Indigo!");
    Environment.Exit(0);
}

//Story

Console.WriteLine("");
Thread.Sleep(1500);
Console.WriteLine("He is hiding in one of two places; where did you want to look first?");
Thread.Sleep(1500);
Console.WriteLine("(1)  Falmouth - his birth home, (2) Forbidden forest");
string pl1 = Console.ReadLine();
if (pl1 == "2")
{
    Thread.Sleep(1500);
    Console.WriteLine("");
    Console.WriteLine("You look in the forbidden forest..");
    Thread.Sleep(3000);
    Console.WriteLine("You find a tree that looked suspicious..");
    Thread.Sleep(3000);
    Console.WriteLine("It seems to have a small caved bit into it..");
    Thread.Sleep(3000);
    Console.WriteLine("There appears to be a light coming from the cave, the tree seems to be enchanted.");
    Thread.Sleep(3000);
    Console.WriteLine("You use the charm 'Appare Vestigium' which reveals traces of magic...");
    Thread.Sleep(3000);
    Console.WriteLine("The charm reveals that there is magic being used on the tree.");
    Thread.Sleep(3000);
    Console.WriteLine("You take a closer look and discover a secret area..");
    Thread.Sleep(3000);
    Console.WriteLine("You enter the secret cave and notice something strange..");
    Thread.Sleep(3000);
    Console.WriteLine("Someone defiently hides here so you get your wand out while looking around..");
    Thread.Sleep(3000);
    Console.WriteLine("You hear something move behind a rock, you get you wand ready to cast a spell..");
    Thread.Sleep(3000);
    Console.WriteLine("An unknown voice hissed,'I was expecting someone to come find me! I hope your ready to fight!'");
    Thread.Sleep(10000);
    Console.Clear();
    Thread.Sleep(3000);
    Console.WriteLine("Final battle loading...");
}
else if (pl1 == "1")
{
    Thread.Sleep(1500);
    Console.WriteLine("");
    Console.WriteLine("You go to Falmouth to find Valdis' birth home before being abandonned by his family.");
    Thread.Sleep(3000);
    Console.WriteLine("You look around the small town to try and find any signs of him or any suspicious..");
    Thread.Sleep(3000);
    Console.WriteLine("You come across a small little cottage where Valdis was homed until the age of 5..");
    Thread.Sleep(3000);
    Console.WriteLine("Do you want to investigate the cottage? y/n ");
    string yn2 = Console.ReadLine();
    if (yn2 == "y" || yn2 == "Y")
    {
        Console.WriteLine("");
        Thread.Sleep(3000);
        Console.WriteLine("You look inside the cottage, theres no one there but you look for clues..");
        Thread.Sleep(3000);
        Console.WriteLine("You find an old picture on the floor that has been burnt, it was a family photo of Valdis and his parents..");
        Thread.Sleep(3000);
        Console.WriteLine("Valdis must of burnt this picture when he killed his muggle parents..");
        Thread.Sleep(3000);
        Console.WriteLine("You look around a bit more but find nothing else so you exit the cottage..");
        Console.WriteLine("");
        Thread.Sleep(3000);
        Console.WriteLine("You have exited the cottage and looking around outside..");
        Thread.Sleep(3000);
        Console.WriteLine("You go to look at something that seems suspicious..");
        Thread.Sleep(3000);
        Console.WriteLine("Theres a person watching you in a black cloak..");
        Thread.Sleep(3000);
        Console.WriteLine("The person slowly walks up to you..");
        Thread.Sleep(3000);
        Console.WriteLine("He approaches you and whispers 'I know your looking for Valdis, Valdis knows this too'..");
        Thread.Sleep(3000);
        Console.WriteLine("He adds 'If you want to find him, hes no where near here. Theres a forest he used to go to a lot'..");
        Thread.Sleep(3000);
        Console.WriteLine("The only place you think of is the forbidden forest so you decide to go look there..");

        Thread.Sleep(4000);
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("You look in the forbidden forest..");
        Thread.Sleep(3000);
        Console.WriteLine("You find a tree that looked suspicious..");
        Thread.Sleep(3000);
        Console.WriteLine("It seems to have a small caved bit into it..");
        Thread.Sleep(3000);
        Console.WriteLine("There appears to be a light coming from the cave, the tree seems to be enchanted.");
        Thread.Sleep(3000);
        Console.WriteLine("You use the charm 'Appare Vestigium' which reveals traces of magic...");
        Thread.Sleep(3000);
        Console.WriteLine("The charm reveals that there is magic being used on the tree.");
        Thread.Sleep(3000);
        Console.WriteLine("You take a closer look and discover a secret area..");
        Thread.Sleep(3000);
        Console.WriteLine("You enter the secret cave and notice something strange..");
        Thread.Sleep(3000);
        Console.WriteLine("Someone defiently hides here so you get your wand out while looking around..");
        Thread.Sleep(3000);
        Console.WriteLine("You hear something move behind a rock, you get you wand ready to cast a spell..");
        Thread.Sleep(3000);
        Console.WriteLine("An unknown voice hissed,'I was expecting someone to come find me! I hope your ready to fight!'");
        Thread.Sleep(10000);
        Console.Clear();
        Thread.Sleep(3000);
        Console.WriteLine("Final battle loading...");


    }
    else if (yn2 == "n" || yn2 == "N")
    {
        Console.WriteLine("");
        Thread.Sleep(3000);
        Console.WriteLine("You decided not to look in the cottage..");
        Thread.Sleep(3000);
        Console.WriteLine("You go to look at something that seems suspicious..");
        Thread.Sleep(3000);
        Console.WriteLine("Theres a person watching you in a black cloak..");
        Thread.Sleep(3000);
        Console.WriteLine("The person slowly walks up to you..");
        Thread.Sleep(3000);
        Console.WriteLine("He approaches you and whispers 'I know your looking for Valdis, Valdis knows this too'..");
        Thread.Sleep(3000);
        Console.WriteLine("He adds 'If you want to find him, hes no where near here. Theres a forest he used to go to a lot'..");
        Thread.Sleep(3000);
        Console.WriteLine("The only place you think of is the forbidden forest so you decide to go look there..");
        Thread.Sleep(4000);

        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("You look in the forbidden forest..");
        Thread.Sleep(3000);
        Console.WriteLine("You find a tree that looked suspicious..");
        Thread.Sleep(3000);
        Console.WriteLine("It seems to have a small caved bit into it..");
        Thread.Sleep(3000);
        Console.WriteLine("There appears to be a light coming from the cave, the tree seems to be enchanted.");
        Thread.Sleep(3000);
        Console.WriteLine("You use the charm 'Appare Vestigium' which reveals traces of magic...");
        Thread.Sleep(3000);
        Console.WriteLine("The charm reveals that there is magic being used on the tree.");
        Thread.Sleep(3000);
        Console.WriteLine("You take a closer look and discover a secret area..");
        Thread.Sleep(3000);
        Console.WriteLine("You enter the secret cave and notice something strange..");
        Thread.Sleep(3000);
        Console.WriteLine("Someone defiently hides here so you get your wand out while looking around..");
        Thread.Sleep(3000);
        Console.WriteLine("You hear something move behind a rock, you get you wand ready to cast a spell..");
        Thread.Sleep(3000);
        Console.WriteLine("An unknown voice hissed,'I was expecting someone to come find me! I hope your ready to fight!");
        Thread.Sleep(10000);
        Console.Clear();
        Thread.Sleep(3000);
        Console.WriteLine("Final battle loading...");
    }
}



//Final Battle - Valdis

int Vhealth = 120;
int Ihealth = 100;
Random Def = new Random();
Random Att = new Random();

Thread.Sleep(10000);
Console.Clear();
Console.WriteLine("");
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