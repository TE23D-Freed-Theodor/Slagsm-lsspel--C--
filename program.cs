using System;
using System.ComponentModel.DataAnnotations;

int conqueror1health = 100; // Spelarens hälsa
int conqueror2health = 100; // Fiendens hälsa

Console.WriteLine("Vad vill du heta?");
string conqueror1 = Console.ReadLine(); 
while (conqueror1.Length > 20 || conqueror1.Length < 2) {
    Console.WriteLine("Ditt namn bör vara mellan 2 och 20 karaktärer långt!");
    conqueror1 = Console.ReadLine(); 
}


Console.WriteLine("Vad ska fienden heta?");
string conqueror2 = Console.ReadLine(); 
while (conqueror2.Length > 20 || conqueror2.Length < 2) {
    Console.WriteLine("Fiendens namn bör vara mellan 2 och 20 karaktärer långt!");
    conqueror2 = Console.ReadLine(); 
}
while (conqueror2 == conqueror1) {
    Console.WriteLine("Fiendens namn får inte vara samma som ditt namn!");
    conqueror2 = Console.ReadLine(); 
}

int damage = 0;
int chance;

int roundnmr = 1;

Random generator = new Random(); // Slumptal

while (conqueror1health > 0 && conqueror2health > 0)
{
    Console.WriteLine();
    Console.WriteLine($"Runda {roundnmr}:");
    Console.WriteLine($"{conqueror1} har {conqueror1health} hälsa och {conqueror2} har {conqueror2health} hälsa");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Vilken attack vill du använda? Skriv 1, 2 eller 3 och tryck enter! \n1. Punch \n2. Kick \n3. Atomic Bomb");
    
    Console.WriteLine("");
    string attack = Console.ReadLine();
    while (attack != "1" && attack != "2" && attack != "3") {
        Console.WriteLine("");
        Console.WriteLine("Nu skrev du varken 1, 2 eller 3! \n1. Punch \n2. Kick \n3. Atomic Bomb");
        Console.WriteLine();
        attack = Console.ReadLine();
    }
    Console.WriteLine("");

    if (attack == "1") {
        damage = 10;
        Console.WriteLine($"Du använder din PUNCH och gör {damage} skada på {conqueror2}");
        Console.WriteLine();
    }
    else if (attack == "2") {
        chance = generator.Next(1, 100);
        if (chance < 50) {
            damage = 30;
            Console.WriteLine($"Du använder din KICK och gör {damage} skada på {conqueror2}");
            Console.WriteLine();
        }
        else {
            damage = 0;
            Console.WriteLine($"Du missar din KICK och gör {damage} skada på {conqueror2}");
            Console.WriteLine();
        }
    }
    else if (attack == "3") {
        chance = generator.Next(1, 100);
        if (chance < 10) {
            damage = conqueror2health;
            Console.WriteLine($"Du är president och trycker på den röda knappen \nDin atombomb tar sig fram och gör {damage} skada på {conqueror2}");
            Console.WriteLine();
        }
        else {
            damage = 0;
            Console.WriteLine($"Din atombomb missar målet och gör {damage} skada på {conqueror2}");
            Console.WriteLine();
        }
    }

    conqueror2health -= damage; // Gör skada på Mike Tyson

    int counterdamage = generator.Next(0, 10);
    conqueror1health -= counterdamage; 

    Console.WriteLine($"{conqueror2} gör {counterdamage} skada på dig, {conqueror1}");
    Console.WriteLine();

    Console.WriteLine("Tryck på enter för nästa runda");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    Console.ReadLine();
    
    roundnmr++; // Nästa runda
}

if (conqueror2health <= 0) {
    Console.WriteLine($"Du, {conqueror1} har vunnit (som vanligt)"); // Lez goooo
    Console.ReadLine();
    Console.WriteLine($"{conqueror2} förs snabbt till sjukhus");
    Console.ReadLine();
    Console.WriteLine("Du gäspar och går vidare med ditt liv");
    Console.ReadLine();
}
