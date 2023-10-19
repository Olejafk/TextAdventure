using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 0;
            Console.WriteLine("You awake in a small dark room, despite having both your legs and hands chained they arent connected to anything.");
            Console.WriteLine("Interactions: Look, Open, Search, Items");
            Console.WriteLine();
            do
            {
                string choice1;
                choice1 = Console.ReadLine()!;
                if (choice1 == "Look" || choice1 == "look")
                {
                    Console.WriteLine("The small damp room is made up of four walls with only one having a door attached to it.");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                }
                else if (choice1 == "Open" || choice1 == "open")
                {
                    Console.WriteLine("Pushing and pulling the door yields no result, it has a keyhole.");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                }
                else if (choice1 == "Search" || choice1 == "search")
                {
                    Console.WriteLine("Aimlessly searching the room you somehow come across a small key.");
                    Console.WriteLine("(Key) added to inventory.");
                    key++;
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                }
                else if (choice1 == "Items" || choice1 == "items")
                {
                    if (key < 1)
                    {
                    Console.WriteLine("You have {0}", key + " key(s)");
                    }
                    else
                    {
                        Console.WriteLine("You have nothing.");
                    }
                }
            }
            while (key < 1);
            do
            {
                string choice2;
                choice2 = Console.ReadLine()!;
                if (choice2 == "Open" || choice2 == "open")
                {
                    Console.WriteLine("The key fits perfectly into the keyhole, allowing you to leave the room.");
                    Console.WriteLine();
                    key--;
                }
                else if (choice2 == "Items" || choice2 == "items")
                {
                    if (key == 1)
                    {
                    Console.WriteLine("You have {0}", key + " key(s)");
                    }
                    else
                    {
                        Console.WriteLine("You have nothing.");
                    }
                }
            }
            while (key == 1);
            int knife = 0;
            int hallway = 1;
            Console.WriteLine("Having left the room you are faced with a corridor lined with candles on both walls, it stretches as far as you can see.");
            Console.WriteLine("Interactions: Look, Walk, Search, Items");
            Console.WriteLine();
            do
            {
                string choice1;
                choice1 = Console.ReadLine()!;
                if (choice1 == "Look" || choice1 == "look")
                {
                    Console.WriteLine("There isnt much to look at due to how dimly lit the hallway is, however you can hear a faint heartbeat.");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                }
                else if (choice1 == "Walk" || choice1 == "walk")
                {
                    Console.WriteLine("walking down the corridor you are faced with another door, this one has no keyhole.");
                    hallway--;
                    Console.WriteLine();
                }
                else if (choice1 == "Search" || choice1 == "search")
                {
                    Console.WriteLine("Carefully searching the walls you find a small rusted knife lodged into the wall.");
                    Console.WriteLine("(Knife) added to inventory.");
                    knife++;
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                }
                else if (choice1 == "Items" || choice1 == "items")
                {
                    if (knife == 1)
                    {
                    Console.WriteLine("You have {0}", knife + " knife");
                    }
                    else
                    {
                    Console.WriteLine("You have nothing.");
                    }
                }
            }
            while (hallway == 1);
            int redRoom = 1;
            Console.WriteLine("Opening the door leads you to a large room that reeks of rotten meat.");
            Console.WriteLine("Interactions: Look, Walk, Search, Items");
            Console.WriteLine();
            do
            {
                string choice1;
                choice1 = Console.ReadLine()!;
                if (choice1 == "Look" || choice1 == "look")
                {
                    Console.WriteLine("The room seems rather plain at first, however inspecting it further everything has a slight red hue.");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                }
                else if (choice1 == "Walk" || choice1 == "walk")
                {
                    Console.WriteLine("Making your way past the suprising amount of tables and chairs in this room you end up infront of a strange man.");
                    redRoom--;
                    Console.WriteLine();
                }
                else if (choice1 == "Search" || choice1 == "search")
                {
                    Console.WriteLine("Despite your efforts, you cant find anything of note.");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                }
                else if (choice1 == "Items" || choice1 == "items")
                {
                    if (knife < 1)
                    {
                        Console.WriteLine("You have {0}", knife + " knife");
                    }
                    else
                    {
                        Console.WriteLine("You have nothing.");
                    }
                }
            }
            while (redRoom == 1);
            int combat = 1;
            int playerHP = 100;
            int enemyHP = 100;
            int talkLevel = 0;
            int rotDisciple = 0;
            int escapeEnding = 0;
            Console.WriteLine("The man stares at you");
            Console.WriteLine("'Flesh yet to rot, mother would not approve.' he says.");
            Console.WriteLine("Interactions: Attack, Defend, Speak");
            Console.WriteLine();
            do
            {
                string choice1;
                choice1 = Console.ReadLine()!;
                if (choice1 == "Attack" || choice1 == "attack")
                {
                    if (knife == 1)
                        {
                            Random rnd = new Random();
                            int num = rnd.Next(0,10);
                            int damage = num * 2;
                            enemyHP -= damage;
                            Console.WriteLine("You strike the man with your knife dealing {0}", damage + " damage to him.");

                            if (enemyHP > 0)
                            {
                            Random rnd2 = new Random();
                            int num2 = rnd2.Next(0,10);
                            int enemyDamage = num2;
                            playerHP -= enemyDamage;
                            Console.WriteLine("he strikes back dealing {0}", enemyDamage + " damage to you.");
                            Console.WriteLine("you have {0}", playerHP + " HP left.");
                            Console.WriteLine("enemy has {0}", enemyHP + " HP left.");
                            Console.WriteLine();
                            }
                            else
                            {
                            Console.WriteLine("The man falls to the ground lifeless.");
                            combat--;
                            escapeEnding++;
                            Console.WriteLine();
                            }
                    }
                    else if (knife == 0)
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(0, 10);
                        int damage = num;
                        enemyHP -= damage;
                        Console.WriteLine("You strike the man with your knife dealing {0}", damage + " damage to him.");

                        if (enemyHP > 0)
                        {
                        Random rnd2 = new Random();
                        int num2 = rnd2.Next(0, 10);
                        int enemyDamage = num2;
                        playerHP -= enemyDamage;
                        Console.WriteLine("he strikes back dealing {0}", enemyDamage + " damage to you.");
                        Console.WriteLine("you have {0}", playerHP + " HP left.");
                        Console.WriteLine("enemy has {0}", enemyHP + " HP left.");
                        Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("The man falls to the ground lifeless.");
                            combat--;
                            escapeEnding++;
                            Console.WriteLine();
                        }
                    }
                }
                else if (choice1 == "Defend" || choice1 == "defend")
                {
                    if (playerHP < 100)
                    {
                        Console.WriteLine("You successfully blocked his attack, regaining your senses slightly.");
                        playerHP += 5;
                        Console.WriteLine("healed 5 HP.");
                        Console.WriteLine("you have {0}", playerHP + " HP left.");
                        Console.WriteLine("enemy has {0}", enemyHP + " HP left.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("you block his attack.");
                        Console.WriteLine("you have {0}", playerHP + " HP left.");
                        Console.WriteLine("enemy has {0}", enemyHP + " HP left.");
                        Console.WriteLine();
                    }
                }
                else if (choice1 == "Speak" || choice1 == "speak")
                {
                    if (enemyHP == 100)
                    {
                        if (talkLevel == 0)
                        {
                            Console.WriteLine("'Who are you?' you ask the man.");
                            Console.WriteLine("'I am but a child of rot, me as anything but that is irrelevant.' he says smiling.");
                            talkLevel++;
                            Console.WriteLine();
                        }
                        else if (talkLevel == 1)
                        {
                            Console.WriteLine("'Child of rot? what do you mean?' you ask him");
                            Console.WriteLine("'The children of the putrid mother are her servants, we do all we can to bring forth the lord of rot.' he says, it seems he is enjoying talking about this.");
                            talkLevel++;
                            Console.WriteLine();
                        }
                        else if (talkLevel == 2)
                        {
                            Console.WriteLine("'Lord of rot? none of this is making any sense.' you say.");
                            Console.WriteLine("'perhaps not to them who have not had their flaws rotted away.' the man responds.");
                            talkLevel++;
                            Console.WriteLine();
                        }
                        else if (talkLevel == 3)
                        {
                            Console.WriteLine("'Keep explaining.', you ask.");
                            Console.WriteLine("He grins, 'Quite promising arent you, By rotting the flesh and mind the mother will cleanse you of your impurities.'");
                            talkLevel++;
                            Console.WriteLine();
                        }
                        else if (talkLevel == 4)
                        {
                        Console.WriteLine("'Go on.', you tell him.");
                        Console.WriteLine("'When the right one ascends through putrid rebirth, they will become the lord of rot, only mother knows what happens next.'");
                        rotDisciple++;
                        combat--;
                        Console.WriteLine();
                        }
                    }
                    else
                    {
                        Random rnd2 = new Random();
                        int num2 = rnd2.Next(0, 10);
                        int enemyDamage = num2;
                        playerHP -= enemyDamage;
                        Console.WriteLine("he hits you dealing {0}", enemyDamage + " damage to you.");
                        Console.WriteLine("You attempt speaking to the man.");
                        Console.WriteLine("'why would we have a conversation in the midst of combat.' he tells you, annoyed.");
                        Console.WriteLine("you have {0}", playerHP + "HP left.");
                        Console.WriteLine("enemy has {0}", enemyHP + "HP left.");
                        Console.WriteLine();
                    }
                }
            }
            while (combat == 1);
            if (rotDisciple == 1)
            {
                    Console.WriteLine("'Follow me, if you wish to walk the path of rot.'");
                    Console.WriteLine("After walking for a good while, the man leads you into a large room with countless men like himself.");
                    Console.WriteLine("'Speak to her, if your flesh is pure she will do the rest.', he points to a staircase leading to an altar.");
                    Console.WriteLine("Interactions: Ascend");
                    string choice1;
                    choice1 = Console.ReadLine()!;
                    if (choice1 == "Ascend" || choice1 == "ascend")
                    {
                        Console.WriteLine("Making your way up the smell gets increasingly worse, nearing the top you feel as if you are drowning in rotting corpses.");
                        Console.WriteLine("As you make the final step you feel a comforting presence followed by a voice, 'an tu es qui thronum vindicas putris?'.");
                        Console.WriteLine("In a instant you feel all your flesh and organs melting and dripping off your bones, your brain eating itself in a matter of seconds.");
                        Console.WriteLine("And then you come back, rotten and putrid. but you feel as if anything you wanted could suffer the same fate. anything or anyone could be rotted away from reality by just a thought.");
                        Console.WriteLine("You have become the lord of rot.");
                        Console.ReadKey();
                }
            }
            else if (escapeEnding == 1)
            {
                Console.WriteLine("After searching the mans corpse you find some keys.");
                Console.WriteLine("Searching the room behind him you quickly find a door which one of the keys fit into.");
                Console.WriteLine("Opening the door you are blinded by the sun.");
                Console.WriteLine("You have escaped.");
                Console.ReadKey();
            }
        }
    }
}