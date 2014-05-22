using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tales_from_Lodoro_1___The_Demon_Spider
{
    class Program
    {
        static int Gold = 12;
        static void Main(string[] args)
        {
            TextPrint("How old art thou, Adventurer?");
            string line = Console.ReadLine();
            int age = Convert.ToInt32(line);
            Console.Clear();
            if (age < 18)
            {
                TextPrint("You are too young to continue this adventure. But you have great courage! Come back once thou art older.");
                Console.WriteLine(":Please press ENTER twice to leave:");
            }
            else
            {
                TextPrint("Art thou a man or a woman?");
            }

            string gender = Console.ReadLine();
            gender = gender.ToLower();
            Console.Clear();
            if (gender == "man" || gender == "male" || gender == "boy" || gender == "guy" || gender == "lad" || gender == "dude" || gender == "sir")
            {
                TextPrint("Welcome, brave hero!  Danger and adventure awaits!");
                Thread.Sleep(1000);
                string adventure = "begin!";
                Console.Clear();
                StoryHero(adventure);
            }
            if (gender == "woman" || gender == "female" || gender == "girl" || gender == "gal" || gender == "lass" || gender == "chick" || gender == "lady")
            {
                TextPrint("Welcome, couragous heroine! Deadly challenges and mighty rewards lie before thee!");
                Thread.Sleep(1000);
                string journey = "start!";
                Console.Clear();
                StoryHeroine(journey);
            }
            TextPrint("Press Enter to leave");
            Console.ReadKey();
        }
        static void StoryHero(string adventure)
        {
            TextPrint("Do you want to be a rogue, warrior, or mage?");
            Console.WriteLine(":Enter ONE of the three classes:");
            string role = Console.ReadLine();
            role = role.ToLower();
            Console.Clear();
            if (role == "rogue" || role == "thief" || role == "assassin" || role == "ninja")
            {
                string sneak = "stealth";
                HeroStealth(sneak);
            }
            if (role == "warrior" || role == "fighter" || role == "paladin" || role == "mercenary" || role == "barbarian" || role == "soldier")
            {
                string CQC = "hit things";
                HeroMelee(CQC);
            }
            if (role == "mage" || role == "caster" || role == "wizard" || role == "sorcerer" || role == "shaman" || role == "witch doctor")
            {
                string arcane = "notthefacenotthefaceNOTTHEFACENOTTHEFACE!";
                HeroMagic(arcane);
            }
        }
        static void StoryHeroine(string journey)
        {
            Console.WriteLine("Dost thou wish to be an assassin, valkyrie, or sorceress?");
            string role = Console.ReadLine();
            role = role.ToLower();
            Console.Clear();
            if (role == "rogue" || role == "thief" || role == "assassin" || role == "ninja")
            {
                string quiet = "no sound";
                HeroineStealth(quiet);
            }
            if (role == "warrior" || role == "fighter" || role == "valkyrie" || role == "mercenary" || role == "amazon" || role == "soldier")
            {
                string close = "Kill it now!";
                HeroineMelee(close);
            }
            if (role == "witch" || role == "caster" || role == "enchantress" || role == "sorceress" || role == "shamaness")
            {
                string spells = "power";
                HeroineMagic(spells);
            }
        }
        static void HeroStealth(string sneak)
        {
            int health = 10;
            int fightingStrength = 10;
            int lockpicks = 10;
            int throwingKnives = 20;
            var inventory = new List<string>();
            inventory.Add("short sword");
            inventory.Add("multi-colored cloths");
            inventory.Add("caltrops");
            inventory.Add("straight dagger");
            inventory.Add("curved dagger");

            TextPrint("What is thine name?");
            var name = Console.ReadLine();
            Console.Clear();
            TextPrint("You are sitting in the Naga's Rattle Inn, watching people come and go,");
            TextPrint("when a scrawny man wearing robes far too nice for this part of town bursts in.");
            Thread.Sleep(600);
            Console.WriteLine();
            TextPrint("He scans the room, frantically searching for someone or something.");
            Thread.Sleep(650);
            TextPrint("When he spots you, he clammers and stumbles his way over to you.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            TextPrint("*huff huff huff* 'You are " + name + ", yes?'");
            Console.ResetColor();
            Thread.Sleep(350);
            TextPrint("How do you respond: confirm or deny?");
            Console.WriteLine("Please enter CONFIRM or DENY, nothing else");
            var respond = Console.ReadLine();
            respond = respond.ToLower();
            Console.Clear();

            if (respond == "confirm")
            {
                Thread.Sleep(300);
                TextPrint("He fumbles himself into the chair opposite you and sighs.");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                TextPrint("'Thank goodness. I have been looking everywhere for you.");
                TextPrint("Let me catch my breath.'");
                Thread.Sleep(700);
                Console.ResetColor();
                TextPrint("After a moment he regains his composure.");
                Thread.Sleep(900);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                TextPrint("'I have been sent by the Earl of Neilhaem to retrieve you.'");
                TextPrint("'He needs you to solve a problem for him.");
                TextPrint("Gather your things and meet me at the edge of town.'");
                Thread.Sleep(800);
                Console.Clear();
                Console.ResetColor();
                TextPrint("He nods his head quickly to you as he stands back up.");
                TextPrint("Before you can say anything to him, he has disappeared from the inn.");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(400);
                TextPrint("You have two choices: gather your things or ignore his request");
                Thread.Sleep(200);
                TextPrint("what is thine decision: follow or ignore?");
                var pick = Console.ReadLine();
                pick = pick.ToLower();
                Console.Clear();

                if (pick == "follow")
                {
                    Thread.Sleep(212);
                    TextPrint("You finish off your meal and head upstairs towards your room.");
                    Thread.Sleep(500);
                    TextPrint("As you approach your room, however, you notice that the door is hanging open,");
                    TextPrint("and the lock is destroyed.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(390);
                    TextPrint("Do you draw your weapons and approach the door or go back downstairs and inform the city guard?");
                    TextPrint("Your choice: Draw or Inform");
                    var plan = Console.ReadLine();
                    plan = plan.ToLower();
                    Console.Clear();

                    if (plan == "draw")
                    {
                        TextPrint("You draw your twin daggers, and slowly approach the door.");
                        Thread.Sleep(100);
                        TextPrint("As you get closer, you hear something rustling through your clothes.");
                        Console.WriteLine();
                        Thread.Sleep(150);
                        TextPrint("When you are just outside the door, you hear a deep,");
                        TextPrint("gravelly voice come from within.");
                        Console.ForegroundColor = ConsoleColor.White;
                        TextPrint("'Argh, where's that damned ar'ifact?! I know 'e 'as it!'");
                        Thread.Sleep(100);
                        Console.ResetColor();
                        TextPrint("You peek inside to see a short and stocky man rummaging through your things.");
                        Thread.Sleep(80);
                        TextPrint("Do you try to SNEAK IN, or do you SURPRISE him by bursting in the door?");
                        var tactic = Console.ReadLine();
                        tactic = tactic.ToLower();
                        Console.Clear();

                        if (tactic == "sneak in" || tactic == "sneak")
                        {
                            TextPrint("You open the broken door without a sound.");
                            Thread.Sleep(150);
                            TextPrint("However, when you step into the room, a floorboard creaks loudly under your foot.");
                            TextPrint("The dwarf whirls around to see what the noise was.");
                            Thread.Sleep(100);
                            Console.ForegroundColor = ConsoleColor.White;
                            TextPrint("'Oi! 'U's there? Come out where I can see ye!'");
                            Console.ResetColor();
                            TextPrint("Do you STAY HIDDEN, COMPLY with him and show yourself, or RUSH him to try and knock out or kill him?");
                            var response = Console.ReadLine();
                            response = response.ToLower();
                            Console.Clear();

                            if (response == "stay hidden" || response == "stay" || response == "hidden")
                            {
                                Thread.Sleep(200);
                                TextPrint("You cover your breath and press yourself against the wall.");
                                Thread.Sleep(100);
                                TextPrint("The dwarf walks slowly over towards the door, handaxe drawn, looking around for you.");
                                Thread.Sleep(100);
                                Console.ForegroundColor = ConsoleColor.White;
                                TextPrint("'All righ', ye. How about this? I put me axe away, and the two of us talk this out like proper lads.'");
                                TextPrint("'What do ye say te tha'?'");
                                Console.ResetColor();
                                TextPrint("What do you do? try to KEEP HIDING or SHOW yourself?");
                                var reResponse = Console.ReadLine();
                                reResponse = reResponse.ToLower();
                                Console.Clear();
                            }
                            if (response == "comply" || response == "agree")
                            {
                                Thread.Sleep(200);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextPrint("'Alright, I'm coming out now. You better keep your word.'");
                                Console.ResetColor();
                                TextPrint("The dwarf places his axe back on his belt and steps back into the light.");
                                Console.ForegroundColor = ConsoleColor.White;
                                TextPrint("'Out ye come then. Nice and slow. We're just gonna talk, a'right?'");
                                Console.ResetColor();
                                TextPrint("You step out into the doorway and face the dwarf.");
                                Console.ForegroundColor = ConsoleColor.White;
                                TextPrint("'I thought ye'd be taller. And, well, not a human.'");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextPrint("'You shouldn't assume so much when you know so little.'");
                                Thread.Sleep(400);
                                TextPrint("'Like whether or not I have something.'");
                                Console.ResetColor();
                                TextPrint("The dwarf drops his gaze to the floor, and starts shifting his feet.");
                            }
                            if (response == "rush" || response == "bull rush" || response == "bum rush")
                            {
                                Thread.Sleep(200);
                                TextPrint("You launch yourself off of the wall at the dwarf.");
                                TextPrint("He turns in time for your shoulder to meet his face. Quite forcefully, at that.");
                                Thread.Sleep(350);
                                TextPrint("Neither your shoulder nor his face enjoy it,");
                                TextPrint("But you manage to knock him unconcious.");
                                Thread.Sleep(250);
                                Console.WriteLine();
                                Thread.Sleep(250);
                                TextPrint("You now have a choice: do you KILL him, TIE him up, or go and INFORM the authorities?");
                                var choice = Console.ReadLine();
                                choice = choice.ToLower();
                                Console.Clear();

                                if (choice == "kill")
                                {
                                    Thread.Sleep(200);
                                    TextPrint("You slit his throat with ease, his blood dripping off your blade.");
                                    TextPrint("As you watch, you realize that the blood is going to really be a damper");
                                    TextPrint("on you ever being able to stay here again.");
                                    Thread.Sleep(100);
                                    Console.WriteLine();
                                    Thread.Sleep(100);
                                    TextPrint("You wrap a dark cloth around his throat to hide the blood and drag him to the window.");
                                    TextPrint("You search him and find a letter, a handaxe, and two gold coins.");
                                    inventory.Add("letter");
                                    inventory.Add("handaxe");
                                    Gold = Gold + 2;
                                    Thread.Sleep(150);
                                    Console.WriteLine();
                                    Thread.Sleep(150);
                                    TextPrint("After taking those things, you heave his body up and out the window.");
                                    TextPrint("You watch his corpse thud into the garbage below.");
                                    TextPrint("Do you read the letter?");
                                    var read = Console.ReadLine();
                                    read = read.ToLower();
                                    Console.Clear();

                                    if (read == "yes")
                                    {
                                        Thread.Sleep(200);
                                        TextPrint("The letter is a plain sheet of yellowed paper.");
                                        TextPrint("The wax seal has been cleanly removed, and it is clearly wrinkled.");
                                        TextPrint("Opening the letter, you see that the handwriting is very complex and difficult to read.");

                                    }
                                }
                            }
                        }
                        if (tactic == "surprise" || tactic == "scare" || tactic == "spook")
                        {
                            TextPrint("You burst through the door with just enough force to knock it off its' already loose hinges.");
                            TextPrint("The dwarf turns around so quickly that he slips on a sock and falls on his rear.");
                            Thread.Sleep(100);
                            Console.ForegroundColor = ConsoleColor.White;
                            TextPrint("'GAH!! What in Heldars' name-!? Wait, this isn' what i' looks like, I swear!'");
                            Console.WriteLine();
                            Console.ResetColor();
                            Thread.Sleep(145);
                            TextPrint("Do you INTERROGATE the dwarf or KILL him?");
                            var decide = Console.ReadLine();
                            decide = decide.ToLower();
                            Console.Clear();

                            if (decide == "interrogate" || decide == "question")
                            {
                                TextPrint("You restrain him and tie his hands to the bedpost.");
                                Console.ForegroundColor = ConsoleColor.White;
                                TextPrint("'What's all this fer, eh? I didn't take nothin'!'");
                                Console.ResetColor();
                                TextPrint("He struggles against the bonds, but to no avail.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                TextPrint("'That's enough. Tell me why you were digging through my things.'");
                                Console.ResetColor();
                                TextPrint("The dwarf immediately averts his eyes and lowers his voice.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                TextPrint("'Th-tha's none o' yer bloody business! I thought ye had somethin' o' mine, is all.");
                                Console.ResetColor();
                                Console.WriteLine();
                                TextPrint("Do you believe him?");                                
                                TextPrint("If so, type YES. If not, type NO.");
                                var trust = Console.ReadLine();
                                trust = trust.ToLower();
                                Console.Clear();

                                if (trust == "yes")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    TextPrint("'All right, dwarf. I believe you.'");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    TextPrint("You untie him and pick him up off the floor.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    TextPrint("'Now get out of here before I change my mind.'");
                                    Console.ResetColor();
                                    Console.Clear();
                                    TextPrint("He runs out the doorway as fast as he can.");
                                    TextPrint("You hear his footsteps thunder all they way until he has");
                                    TextPrint("finally left the inn. You breathe a sigh of relief and turn to");
                                    TextPrint("see what kind of damage he did to your belongings.");
                                }
                                if (trust == "no")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    TextPrint("'Nice try, but wrong answer.'");
                                    Console.ResetColor();
                                    TextPrint("The dwarf flinches, expecting some sort of pain.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    TextPrint("'What artifact do you think I have?'");
                                    Console.ResetColor();
                                    TextPrint("He mumbles something under his breath, but you can't make anything out.");
                                    TextPrint("Do you PUSH him more or RELEASE him and move on?");
                                    var cop = Console.ReadLine();
                                    cop = cop.ToLower();
                                    Console.Clear();
                                }
                            }
                            if (decide == "kill")
                            {
                                TextPrint("The dwarf draws a handaxe and readies himself for combat.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    if (plan == "inform")
                    {
                        TextPrint("You head back downstairs and are moving towards the street,");
                        TextPrint("when three large and very burly men step into your way.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(500);
                        TextPrint("The one directly in front of you steps closer to you.");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        TextPrint("'Where do ye think yer goin?'");
                        Thread.Sleep(200);
                        Console.ResetColor();
                        TextPrint("The three men close in on you, and you have no escape route.");
                        TextPrint("The last thing you see is several vicious-looking knives speeding into your gut and face.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        TextPrint("You have been killed by the minions of evil.");
                        Thread.Sleep(800);
                        TextPrint("YOUR ADVENTURE . . .");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Thread.Sleep(500);
                        TextPrint(". . . IS OVER.");
                    }
                }
                if (pick == "ignore")
                {
                    Thread.Sleep(212);
                    TextPrint("You wholeheartedly ignore his request and continue with the rest of your day.");
                    Thread.Sleep(370);
                    TextPrint("You have ignored the issue and the world is doomed!");
                    Thread.Sleep(300);
                    TextPrint("THE ADVENTURE . . .");
                    Console.WriteLine();
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Thread.Sleep(500);
                    TextPrint(". . . HAS ENDED.");
                }
            }
            if (respond == "deny")
            {
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                TextPrint("'Oh, I'm sorry. I did not mean to disturb you. I'll be on my way then.'");
                Console.ResetColor();
                TextPrint("He leaves the inn and you eventually forget he ever spoke to you.");
                Thread.Sleep(370);
                TextPrint("You have avoided the issue and the world is doomed!");
                Thread.Sleep(300);
                TextPrint("THE ADVENTURE . . .");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.WriteLine();
                Thread.Sleep(500);
                TextPrint(". . . IS OVER.");
            }
        }
        static void HeroMelee(string CQC)
        {
            Console.WriteLine("What is thine name?");
            var name = Console.ReadLine();
        }
        static void HeroMagic(string arcane)
        {
            Console.WriteLine("What is thine name?");
            var name = Console.ReadLine();
        }
        static void HeroineStealth(string quiet)
        {
            Console.WriteLine("What is thine name?");
            var name = Console.ReadLine();
        }
        static void HeroineMelee(string close)
        {
            Console.WriteLine("What is thine name?");
            var name = Console.ReadLine();
        }
        static void HeroineMagic(string spells)
        {
            Console.WriteLine("What is thine name?");
            var name = Console.ReadLine();
        }
        static void TextPrint(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}
