using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            String enter, Falsch = "Please use the proposed phrases.";
            int leben = 3, i;
            int timer = 150;
            bool button = false, id = false, towel = false, home = false, bar = false, medkit = false, cabready = false, exit = false, unlock = false, unlockA = false, unlockB = false;



            Console.WriteLine(
                "\n       A          SSSSS  PPPPP  AAAAA  CCCCC  EEEEE" +
                "\n      A A         S____  P___P  A___A  C      E_" +
                "\n     A   A            s  P      A   A  C      E" +
                "\n    A     A       SSSSS  P      A   A  CCCCC  EEEEE" +
                "\n   A       A      OOOOO  DDDD   Y   Y  SSSSS  EEEEE  EEEEE" +
                "\n  A         A     O   O  D   D   YYY   S___   E_     E_  " +
                "\n A           A    O   O  D   D    Y        S  E      E" +
                "\nAAAAAAAAAAAAAAA   OOOOO  DDDD     Y    SSSSS  EEEEE  EEEEE" +
                "\n\n\n                      A Space Odysee DEMO" +
                "\n                            by Zorro");


            Console.WriteLine("\n\n\nSystem override initiated " +
                "\n.\n.\n.\n. " +
                "\nHeartbeat low = true " +
                "\nLiver failure inevitable = true " +
                "\nRecognizing pattern XX0019 " +
                "\nProceed as usual " +
                "\n.\n.\n." +
                "\nApruptly you open your eyes. You feel awful ... your whole body is aching and your hands can´t stop shaking. " +
                "\nYour blurry vision reveals a half emptied tumbler in front of you.");



            do
            {
                Console.WriteLine("Remember - Drink");
                enter = Console.ReadLine();

                if (enter == "Remember" || enter == "Drink")
                {
                    if (enter == "Remember")
                    {

                        Console.WriteLine("You sit in Jake´s Pub. A local dive bar on Terzerus Prime. For you it´s a night like any other.");

                    }
                    else
                    {
                        Console.WriteLine("You concentrate ... " +
                            "\nand start slowly moving your right hand towards the drink on top of the dent stainless steel counter. " +
                            "\nAlmost there ... “Awake again ?” An angry voice seems to talk to you.");
                        unlock = true;

                    }
                }
                else
                {
                    Console.WriteLine(Falsch + "\n");

                }
            } while (unlock == false);

            unlock = false;

            do
            {
                Console.WriteLine("Drink - Look up");
                enter = Console.ReadLine();

                if (enter == "Drink" || enter == "Look up")
                {
                    if (enter == "Drink")
                    {
                        Console.WriteLine("You continue the seemingly endless long way towards the half filled tumbler...");
                        unlock = true;
                    }
                    else
                    {
                        Console.WriteLine("That´s not how addiction works. " +
                            "\nYou continue the seemingly endless long way towards the half filled tumbler...");
                        unlock = true;
                    }
                }

                else
                {
                    Console.WriteLine(Falsch + "\n");
                }

            } while (unlock == false);

            unlock = unlockA = false;

            Console.WriteLine("... grabbing and emptying it.");

            do
            {

                if (unlock == false)
                {
                    Console.WriteLine("Fuck it - Look down - Look around");
                }
                else
                {
                    Console.WriteLine("Fuck it - Look down - Look around - Drink");
                }

                enter = Console.ReadLine();

                if (enter == "Fuck it" || enter == "Look down" || enter == "Look around" || enter == "Drink")
                {
                    if (enter == "Drink")
                    {
                        Console.WriteLine("“Sorry Charlie.” You chug down the refilled glas. “Whatever.” Jake refills it again. " +
                            "“Just get out of here within the hour, I need to slee” BANG! A part of his head exploded and painted the wall " +
                            "behind him red. With open mouth and in shock your look follows from the spot where Charlie's head exploded to " +
                            "your mechanical hand holding your service gun.");
                        unlockB = true;

                    }

                    if (enter == "Fuck it")
                    {
                        Console.WriteLine("You raise your hand with a half decent smile \"Another one Charlie ...\" " +
                            "The bartender in front of you gets furious. \"ARE YOU KIDDING ME ? I swear if you " +
                            "wouldn´t pay my rent with your ass full of misery I would kick you out in a second.\" " +
                            "Disgusted he grabs the tumbler and refills it. \"And for the thousands of times MY NAME" +
                             "IS JAKE! Do you even remember what you did 5 minutes ago ? No, right ? You got completely " +
                             "shitfaced, AGAIN, until your internal health monitor pumped you full of Antibuzz-Meds... " +
                             "AGAIN, oh but you didnt just poison the mood of every guest next to you during that whole " +
                             "ritual.No! This time you went \"All In Premium Dumb Fuck\" or A ! I ! P ! D ! F !! You started " +
                             "pissing IN MY GOD DAMN CORNER AND SPRAYED HALF OF MY CUSTOMERS. EVERYONE LEFT! AGAIN!!\" " +
                             "He points angrily at a corner where a small service droid is mopping the floor.");

                        unlock = true;
                    }

                    if (enter == "Look around")
                    {
                        Console.WriteLine("Jake´s Pub. The third worst bar in town and your regular place to spend your evening after you got " +
                            "kicked out of the other two. It´s a room filled with different rusted metal tables and chairs, " +
                            "artificially lid in different colours. The walls are covered with worthless and weird antiques " +
                            "from all over the galaxy and the basic theme of the bar seems to be the adventures of the owner. Everything" +
                            " looks worn out and was fixed at least once. Still ... There is a long forgotten charme behind the rundown " +
                            "fassade. But the two main reasons for you to come here are the cheap drinks and the fact that people let you " +
                            "in. As you turn around to look back at the bar you notice a scrubbing droid unit cleaning a puddle of liquid" +
                            " on the floor.A familiar picture to you.");

                    }


                    if (enter == "Look down")
                    {
                        Console.WriteLine("You notice your implants and prostheses on the left half of your body. " +
                            "\nA creeping feeling stiffens your neck. You are starting to shake.");

                        Console.WriteLine("The memories of your last days in service flash before your eyes. " +
                            "\nYou fought on an abandoned planet in the outer rim of the Empire against the last" +
                            " remains of an open rebellion. " +
                            "\nYou were a ...");

                        do
                        {
                            Console.WriteLine("medic - farmer - spy");

                            enter = Console.ReadLine();

                            if (enter == "medic" || enter == "farmer" || enter == "spy")
                            {
                                if (enter == "medic")
                                {
                                    Console.WriteLine("... of an assault troop which confronted hunched down insurgents in an " +
                                    "abandoned outpost building. Everything went fine and your team could... sweep the " +
                                    "ground floor without any casualties and everyone proceeded upwards.The remaining rebels" +
                                    " simply didn't have anything that could penetrate your war suits. An easy job. Your team" +
                                    " reached the door to the flat rooftop and after getting in position, the door was kicked" +
                                    " open. Through the portal you could see the blue sky. Than an intense bright light blurred" +
                                    " your vision ... then darkness ... and an intense pain. They woke you up in a hospital, " +
                                    "half of your body was burned and another half was missing.You seem to have survived a " +
                                    "massive explosion that brought the whole building down and killed everyone on the team " +
                                    "except you.The doctors fixed you up well with the military insurance budget but after " +
                                    "you told them your memories of what had happened, they locked you up immediately.You " +
                                    "sat 1 year in prison without knowing where and why. And instead of telling you, the " +
                                    "suits of state security kept interrogating you with every half legal method they knew." +
                                    "They wanted to know every detail of the last moments you could remember.After they " +
                                    "realised that this wasnt so much, they released you.Without a job and ship but with a " +
                                    "half mechanical body, a decent pension and your service weapon. After that, you spiraled" +
                                    " down and your memories get blurry. The barkeeper notices your blank stare at your implants." +
                                    "His tense neck muscles relax and his shoulders sink down. After an intense sigh he mumbles, " +
                                    "“They were all assholes and it's late anyway.” You shiver and get out of your head.");

                                    unlockA = true;

                                }

                                if (enter == "farmer")
                                {
                                    Console.WriteLine("... who inherited a big piece of land.But it was in debt so you were forced to join the military and left your family " +
                                        "\nbehind who ... I never had a family. This can´t be true ... " +
                                        "\nYou must have been a ...");
                                }

                                if (enter == "spy")
                                {
                                    Console.WriteLine("... who operated behind enemy lines and infiltrated the local population. You were tasked to demolish a local " +
                                        "\ncommunications array of the empire ... Sabotage my own government ? That makes no sense." +
                                        "\nYou must have been a...");
                                    Console.WriteLine(unlockA);
                                }
                            }

                            else
                            {
                                Console.WriteLine(Falsch + "\n");

                            }

                        } while (unlockA == false);


                    }
                }

                else
                {
                    Console.WriteLine(Falsch + "\n");
                }

                if (leben == 0)
                {
                    Console.WriteLine("You die in agony.");
                    return;
                }

            } while (unlockB == false);

            unlockA = unlock = unlockB = false;

            do
            {

                Console.WriteLine("(What the ___?)");
                enter = Console.ReadLine();

                if (enter == "hell")
                {
                    Console.WriteLine("An intense burning pain inside of your head which leaves you in paralysing agony and cramping down to the" +
                        " floor. \nA voice in your head was slowly becoming louder. \"I'm sorry for this unpleasant intrusion into your private life." +
                        "  \nFor the rest of our short ...\"");

                    unlock = true;
                }

                else
                {
                    Console.WriteLine("The pain is unbearable...");
                    leben--;
                    Console.WriteLine("Leben: " + leben);

                }

            } while (unlock == false);

            unlock = unlockA = unlockB = false;



            do
            {
                Console.WriteLine("\"GET OOOOUUUT!\" You BEAT against the floor ");

                i = 0;

                if (leben == 0)
                {
                    Console.WriteLine("You die in agony.");
                    return;

                }

                enter = Console.ReadLine();

                if (enter != "BEAT")
                {
                    leben--;
                    Console.WriteLine("Leben: " + leben);
                    i++;
                }

                Console.WriteLine("bEAT");
                enter = Console.ReadLine();

                if (enter != "bEAT")
                {
                    leben--;
                    Console.WriteLine("Leben: " + leben);
                    i++;
                }

            } while (i != 0);


            Console.WriteLine("\"... communication. You really shouldn't reply to me. It just prolongs your" +
                " suffering. And I bet. Every... single... second... \"");

            do
            {
                i = 0;

                Console.WriteLine("\"AHHH!\" b E a t");
                enter = Console.ReadLine();

                if (enter != "b E a t")
                {
                    leben--;
                    Console.WriteLine("Leben: " + leben);
                    i++;
                }

                Console.WriteLine("b   e  a t");
                enter = Console.ReadLine();

                if (enter != "b   e  a t")
                {
                    leben--;
                    Console.WriteLine("Leben: " + leben);
                    unlock = true;
                    i++;

                }

                if (leben == 0)
                {
                    Console.WriteLine("You die in agony.");
                    return;

                }

            } while (i != 0);



            Console.WriteLine("\"... matters to you. So listen carefully. In two hours, the Intergalactic Navigation and Telecommunication " +
                "Network will collapse on this planet. \nWhich means, it will be blind and deaf for a while. There is a ship called Maverick at " +
                "the local spaceport, platform XX78.\"");

            do
            {
                i = 0;
                Console.WriteLine("\"Hey STAY AWAKE\"");

                enter = Console.ReadLine();

                if (enter != "STAY AWAKE")
                {
                    leben--;
                    Console.WriteLine("Leben: " + leben);
                    i++;
                }

                Console.WriteLine("StaY AWAke");
                enter = Console.ReadLine();

                if (enter != "StaY AWAke")
                {
                    leben--;
                    Console.WriteLine("Leben: " + leben);
                    i++;
                }

                Console.WriteLine("s   t A y   Aw  AK E!");
                enter = Console.ReadLine();

                if (enter != "s   t A y   Aw  AK E!")
                {
                    leben--;
                    Console.WriteLine("Leben: " + leben);
                    unlock = true;
                    i++;
                }

            } while (i != 0);

            Console.WriteLine("\"You can unlock the mashine with your bio identificator. Use the ship to travel to Tarsonis. I want you to get" +
                " off the planet right when the blackout hits. So you have 3 hours.\"");
            Console.WriteLine("And it´s gone. Everything ... gone. The voice, the pain ... but you are sober. A lot of pain medication was released " +
                "into your bloodstream which started to work. Your surroundings shimmer in intense lights. All the outlines in your vision field " +
                "are flowing into each other. ");

            do
            {

                if (unlockA == false)
                {
                    Console.WriteLine("Look around - Look body - Look implants");
                }

                else
                {
                    Console.WriteLine("Look around - Look body - Look implants - Leave");
                }

                enter = Console.ReadLine();

                if (enter == "Look around" || enter == "Look body" || enter == "Look implants" || enter == "Leave")
                {
                    if (enter == "Look around")
                    {
                        Console.WriteLine("Confused and numb you are inspecting your surroundings. Still an empty bar which lights almost blind you now " +
                            "but you can´t help yourself ... you stare for at least a Minute at the beautiful spectacle that is in front of you. " +
                            "Complete Silence.");
                    }

                    if (enter == "Look body")
                    {
                        Console.WriteLine("You walk behind the counter. In front of you lies a dead body missing a head slowly merging with the floor. The " +
                            "blood looks like its slowly pulsing and you hear a faint river noise getting intensly loud while watching it moving slowly towards your shoes ... You " +
                            "snap out of it. Disgusted you are ready to leave.");
                        unlockA = true;
                    }

                    if (enter == "Look implants")
                    {
                        Console.WriteLine("Moving slowly every finger at a time you make sure that your mechanical arm is completely under your command. " +
                            "You release a short giggle.");
                    }

                    if (enter == "Leave")
                    {
                        Console.WriteLine(" \"I guess I go home and dress up for space stuff...\" You holster your gun and start walking towards the " +
                            "exit. Your favourite rock music is starting to play in your head. You walk by the wardrobe on the wall to pick up your " +
                            "intensely black leather jacket. You put it on in one motion. The light that slips through the exit door illuminates it " +
                            "and makes it look more like a shining portal. You put on your black sunglasses and stick a cigarette into your mouth " +
                            "which were in your jacket´s pockets. You light it. Inhale. Exhale. You step through the shining portal. \"");
                        unlock = true;
                    }
                }
                else
                {
                    Console.WriteLine(Falsch + "\n");
                }

            } while (unlock == false);

            unlock = unlockA = unlockB = false;

            Console.WriteLine("\n\n\n END OF CHAPTER ONE." +
                "\nProceed with any key");
            enter = Console.ReadLine();

            Console.WriteLine("\n\nCHAPTER 2: PREPARE FOR TAKE OFF");

            Console.WriteLine("Alright ... I have only limited time, where should I go next? " + timer + " min");
            do
            {


                if (home == false && bar == false)
                {
                    Console.WriteLine("Go home(-10 min) - Go to ship(-30 min) - Go next bar(-5 min)");
                }

                if (home == true)
                {
                    Console.WriteLine("Go to ship(-40 min) - Go next bar(-15 min)");

                }

                if (bar == true)
                {
                    Console.WriteLine("Go to ship(-20 min) - Go home(-15 min)");
                }

                enter = Console.ReadLine();

                if (enter == "Go next bar")
                {
                    bar = true;
                    home = false;

                    if (home == false)
                    {
                        timer -= 5;
                    }

                    else
                    {
                        timer -= 15;
                    }

                    Console.WriteLine(timer + " min");

                    if (timer <= 0)
                    {
                        Console.WriteLine("You die in agony.");
                        return;
                    }

                    Console.WriteLine("You wander inside the next bar. It's filled with chatting people and a well sorted shelf with drinks. " +
                        "Everybody is ignoring you, except the ones that can smell you.");

                    do
                    {
                        if (unlockB == false)
                        {

                            Console.WriteLine("Look around - Get drink - Go toilet - Leave");
                            enter = Console.ReadLine();

                            if (enter == "Look around" || enter == "Get drink" || enter == "Go toilet" || enter == "Leave")
                            {
                                if (enter == "Go toilet")
                                {
                                    Console.WriteLine("Nice and clean ... sadly there is nothing of use.");
                                }

                                if (enter == "Leave")
                                {
                                    unlock = true;
                                }

                                if (unlockA == true && enter == "Look around")
                                {
                                    Console.WriteLine("Summing up your look around experience ... Happy people, hip location, you dislike pretty much everything");
                                }

                                if (enter == "Look around")
                                {
                                    Console.WriteLine("The illuminated wall panels are smoothly changing colours to the relaxing beats played by hidden speakers.The interior " +
                                        "is nice, borderline fancy but not high class. It´s not the kind of location you got used to and the people look way prettier.You hate" +
                                        " it but you see an empty spot at the bar.");

                                    unlockA = true;

                                }

                                if (enter == "Get drink" && button == false)
                                {
                                    Console.WriteLine("You approach the counter and make yourself ready to order.The barkeeper notices you with a smile and walks casually " +
                                        "towards you. His smile deteriorates with every step. Disgusted with a bit of compassion he throws you out.");
                                }

                                if (enter == "Get drink" && button == true)
                                {
                                    Console.WriteLine("You approach the counter and make yourself ready to order.The barkeeper, a chubby small man with long blond hair " +
                                        "sucking on a lollipop, notices you with a smile and walks casually towards you. \"What can I do for you handsome?\"");
                                    do
                                    {
                                        Console.WriteLine("Drink - Talk");
                                        enter = Console.ReadLine();

                                        if (enter == "Talk")
                                        {
                                            Console.WriteLine("Oh there nothing out of the ordinary happening here handsome. Except you of course. Man, if there wouldn´t have been" +
                                                "a trafficjam this morning on this god damn Route 45 I´d had time to get properly dressed up for you.");
                                        }

                                        if (enter == "Drink")
                                        {
                                            Console.WriteLine("You reply, \"2 shots of clear alcohol and a tumbler of Danny´s Rocketfuel.\" " +
                                                "\n\"Ohh honey, a man like you doesn´t need fuel for his take off I´m sure.\" " +
                                                "He throws you a wink and laughs while walking away to get your drinks. You already miss Charlie very much." +
                                                "\n\"Here you go handsome. \"He puts the drinks on the counter and plays with his lolly in front of you.\"");

                                            Console.WriteLine("Drink - Talk");
                                            enter = Console.ReadLine();

                                            if (enter == "Talk")
                                            {
                                                Console.WriteLine("It´s too late for a rational conversation.");
                                            }

                                            if (enter != "Drink" && enter != "Talk")
                                            {
                                                Console.WriteLine("You cannot really control your actions anymore so relax and get shitfaced. (just press enter)");
                                            }

                                            Console.WriteLine("As you pour down the 2 shots the barkeeper looks a little disappointed. " +
                                                "\n\"I thought the second one was for me.\"" +
                                                "\n You laugh. " +
                                                "\n \"You wish, keep them coming.I got a flight to catch in xxx minutes and I´m not planning to board sober.\" " +
                                                "\n \"Then I´m all yours superfly.\"" +
                                                "\n He vanishes for a second underneath the counter to grab a sealed bottle of clear spirit." +
                                                "\n \"Let´s see how tough you really are my gorgous metalman\"");

                                            Console.WriteLine("Drink");
                                            enter = Console.ReadLine();

                                            Console.WriteLine("He pours you another two shots and a third for himself. You feel the alcohol working. More cheerful now you don´t plan to stop. " +
                                                "\n\"Another round!\"");

                                            Console.WriteLine("Drunk");
                                            enter = Console.ReadLine();

                                            Console.WriteLine("He pours you two another three shots to drink. The barkeeper´s head is now red as a tomato, " +
                                                "\n\"You know ... I´m not getting paid that much and we have full house. So ... another one?\"" +
                                                "\n\"Three.\" " +
                                                "\nBoth of you laugh euphorically before you pour the spirits down your throat.");

                                            Console.WriteLine("So drunk");
                                            enter = Console.ReadLine();

                                            Console.WriteLine("\"Yy ... yo..you know dat I half to catch flight right? I i ... might die otherwise ... I think.\" " +
                                                "\nThe barkeeper nods while pointing towards his wrist watch. " +
                                                "\n\"I know ... BUT ... Thinking is not knowing\"" +
                                                "\n\"I don´t know ma...\"" +
                                                "\n\"Iahhhh it´s okay ... truuust me ... Another one?\"");

                                            Console.WriteLine("Shitfaced");
                                            enter = Console.ReadLine();

                                            Console.WriteLine("The bartender puts on dance music, strips down to his underwear and after the third try manages to lift himself" +
                                                " on top the counter. He starts dancing and pouring drinks directly into his customers mouths. " +
                                                "\n\"Cam on! GET UP HERE HANDSOME! WOOOHOO!\" " +
                                                "\nHe hands you over a completely sealed bottle of clear alcohol. Your memory " +
                                                "after you drank half of it is very blurry and you fade in and out of consciousness.");

                                            Console.WriteLine("Blackout");
                                            enter = Console.ReadLine();

                                            timer -= 60;

                                            if (timer <= 0)
                                            {
                                                Console.WriteLine("You die in agony.");
                                                return;
                                            }

                                            Console.WriteLine("Abruptly you open your eyes. You feel awful ... your whole body is aching. Lying face down on the floor. You pull " +
                                                "yourself together and stand up to look around. You are still in the bar, now empty. That´s good. There are " + timer + " minutes left." +
                                                "\n\"Ah dude, you are awake.\"" +
                                                "\n The bartender walks in half naked with a big cowboy hat, a bandaged hand and a fat grin on his face. " +
                                                "\n\"I just dropped some Antibuzz to get a bit sober, you need some?\" " +
                                                "\n You point towards your implants. " +
                                                "\n\"Got my own.I have to go now and catch my flight.\" " +
                                                "\nThe bartender tips his hat sadly, \"Alright cowboy.A pity that we can´t hang out after work. Hahaha.\" " +
                                                "\nYou grab your belongings and walk towards the exit. You notice a cleaning droid as you walk by the counter which mops up some smelly liquid." +
                                                " It looks at you, shakes it head and continues cleaning.");

                                            unlockB = true;

                                        }

                                        else
                                        {

                                            Console.WriteLine(Falsch + "\n");

                                        }
                                    } while (unlockB == false);

                                }
                            }


                            else

                            {
                                Console.WriteLine(Falsch + "\n");
                            }



                        }

                        else
                        {
                            unlock = true;
                        }

                        if (unlockB == true)
                        {
                            Console.WriteLine("Leave");
                            enter = Console.ReadLine();

                            if (enter == "Go toilet" || enter == "Leave")
                            {
                                if (enter == "Go toilet")
                                {
                                    Console.WriteLine("It´s a mess in there ... but you found a medkit and you leave the bar.");
                                    medkit = true;
                                }

                                if (enter == "Leave")
                                {
                                    Console.WriteLine("You leave the bar.");
                                    unlock = true;


                                }

                            }

                            else

                            {
                                Console.WriteLine(Falsch + "\n");
                            }

                        }

                    } while (unlock == false);

                    unlock = unlockA = unlockB = false;
                }



                if (enter == "Go home")
                {
                    home = true;
                    bar = false;

                    if (bar == false)
                    {
                        timer -= 10;
                    }

                    else
                    {
                        timer -= 15;
                        bar = false;
                    }

                    Console.WriteLine(timer + " min");

                    if (timer <= 0)
                    {
                        Console.WriteLine("You die in agony.");
                        return;
                    }

                    Console.WriteLine("You enter your rented apartment.It´s messy, a hint of sulfur in the air and the kitchen counter filled with old" +
                        " dirty dishes and cooking equipment seems to be alive and well. Home sweet home.");

                    do
                    {
                        Console.WriteLine("Look around (-5 min) - Go toilet - Go livingroom - Leave");
                        enter = Console.ReadLine();

                        if (enter == "Look around" || enter == "Go toilet" || enter == "Go livingroom" || enter == "Leave")
                        {
                            if (enter == "Leave")
                            {
                                Console.WriteLine("You leave your apartment");
                                unlockA = true;
                            }

                            if (enter == "Look around")
                            {
                                if (id == true)
                                {
                                    Console.WriteLine("You find nothing of interest.");

                                }

                                else
                                {
                                    Console.WriteLine("Between the dirty dishes you can identify your ID card. You have no idea how it" +
                                        " got there and why but who cares anyway.");
                                    id = true;


                                }

                                timer -= 5;
                                Console.WriteLine(timer + " min");

                                if (timer <= 0)
                                {
                                    Console.WriteLine("You die in agony.");
                                    return;
                                }

                            }

                            if (enter == "Go livingroom")
                            {
                                Console.WriteLine("You enter your livingroom which is also your bedroom.It´s as dirty as the kitchen and at least as smelly.It" +
                                    "honestly looks like you are buying new plates before doing the hustle of cleaning it. Your sleeping couch is on the left with the " +
                                    "VirtualVision - Headset on top.On the right are your drawers for clothes which are covered by more clothes than there are " +
                                    "actually inside of the drawers.");

                                do
                                {
                                    Console.WriteLine("Look around (-5 min) - Turn on VV (-15 min) - Back");
                                    enter = Console.ReadLine();

                                    if (enter == "Look around" || enter == "Turn on VV" || enter == "Back")
                                    {
                                        if (enter == "Look around")
                                        {

                                            Console.WriteLine("You found nothing of value.");

                                            timer -= 5;
                                            Console.WriteLine(timer + " min");

                                            if (timer <= 0)
                                            {
                                                Console.WriteLine("You die in agony.");
                                                return;
                                            }

                                        }

                                        if (enter == "Turn on VV")
                                        {
                                            Console.WriteLine("You take your dirty old VV headset and strap it onto your face. \"Welcome to Channel 5 News.\" You are greeted by a tall slim figure with curly hair. " +
                                                "\"Flash News first * FFFFlash NeNeNeNews *.Road 76, 82 and 23 are blocked due to a protest against the planned space autobahn organized by NIMBA or " +
                                                "\"Not In My Backyard Assholes! \". We advise you to avoid those routes. Our controversial topics of today are: " +
                                                "\nLoud people with opinions - A blessing or anoying trend?  " +
                                                "\nPeople in charge that shouldn't be in charge - Do we really want boring specialists or exciting entertainment?" +
                                                "\nAnd of course our regular show Depression - Come on buddy, stop beeing a downy and force that frown, upside down!\"");

                                            timer -= 15;
                                            Console.WriteLine(timer + " min");

                                            if (timer <= 0)
                                            {
                                                Console.WriteLine("You die in agony.");
                                                return;
                                            }

                                        }

                                        if (enter == "Back")
                                        {
                                            Console.WriteLine("You go back to the entry area.");
                                            unlock = true;
                                        }
                                    }


                                    else
                                    {
                                        Console.WriteLine(Falsch + "\n");

                                    }

                                } while (unlock == false);

                                unlock = false;

                            }

                            if (enter == "Go toilet")
                            {
                                Console.WriteLine("You enter your bathroom. Which is by far the cleanest of places in your flat.");

                                do
                                {
                                    Console.WriteLine("Look around(-5 min) - Open drawers(-5 min) - Shower (-15 min) - Back");
                                    enter = Console.ReadLine();

                                    if (enter == "Look around" || enter == "Open drawers" || enter == "Shower" || enter == "Back")

                                    {
                                        if (enter == "Look around")
                                        {

                                            Console.WriteLine("You found nothing out of the ordinary.It´s way too clean in here to find something I guess.");

                                            timer -= 5;
                                            Console.WriteLine(timer + " min");

                                            if (timer <= 0)
                                            {
                                                Console.WriteLine("You die in agony.");
                                                return;
                                            }

                                        }

                                        if (enter == "Open drawers")
                                        {

                                            if (towel == true)
                                            {
                                                Console.WriteLine("You find nothing of interest.");
                                                timer -= 5;
                                                Console.WriteLine(timer + " min");

                                                if (timer <= 0)
                                                {
                                                    Console.WriteLine("You die in agony.");
                                                    return;
                                                }

                                            }

                                            else
                                            {
                                                Console.WriteLine("Empty, except your towel.You would never do interstellar space travel without a personal towel so you pick it up. While doing that," +
                                                    " you could swear you heard someone say “You wanna get high?”. The rush of meds not so long ago still has minor after effects.");

                                                towel = true;

                                                timer -= 5;
                                                Console.WriteLine(timer + " min");

                                                if (timer <= 0)
                                                {
                                                    Console.WriteLine("You die in agony.");
                                                    return;
                                                }

                                            }
                                        }

                                        if (enter == "Shower")
                                        {
                                            if (button == true)
                                            {
                                                Console.WriteLine("You think you have time to take another shower.");

                                                timer -= 15;
                                                Console.WriteLine(timer + " min");

                                                if (timer <= 0)
                                                {
                                                    Console.WriteLine("You die in agony.");
                                                    return;
                                                }
                                            }

                                            if (button == false)
                                            {
                                                Console.WriteLine("You undress yourself to take a short shower. After you pull down your pants you notice that a button was so loose " +
                                                    "that it fell on the floor. You pick it up and clean yourself.");

                                                button = true;

                                                timer -= 15;
                                                Console.WriteLine(timer + " min");

                                                if (timer <= 0)
                                                {
                                                    Console.WriteLine("You die in agony.");
                                                    return;
                                                }


                                            }
                                        }




                                        if (enter == "Back")
                                        {
                                            Console.WriteLine("You go back to the entry area.");
                                            unlock = true;
                                        }


                                    }

                                    else
                                    {
                                        Console.WriteLine(Falsch + "\n");

                                    }



                                } while (unlock == false);

                                unlock = false;
                            }


                        }

                        else
                        {
                            Console.WriteLine(Falsch + "\n");
                        }


                    } while (unlockA == false);

                    unlockA = unlockB = unlock = false;

                }

                if (enter == "Go to ship" && id == false)
                {
                    Console.WriteLine("You can´t order a cab without your ID.");
                    enter = "";
                }

                if (enter == "Go to ship" && id == true)
                {
                    cabready = true;
                }

                else
                {
                    {
                        Console.WriteLine(Falsch + "\n");
                    }
                }

            } while (cabready == false);


            if (home == true)
            {
                timer -= 40;
                Console.WriteLine(timer + " min");
            }

            if (bar == true)
            {
                timer -= 20;
                Console.WriteLine(timer + " min");
            }

            if (timer <= 0)
            {
                Console.WriteLine("You die in agony.");
                return;
            }

            Console.WriteLine("\n\nCHAPTER 3: SPACEPORT" +
                "\nProceed with any key");
            enter = Console.ReadLine();

            unlock = unlockA = unlockB = false;

            Console.WriteLine("You order a cab. It arrives shortly after and you sit down inside its cabin. The room is merely enough for one person and a bag. " +
                "\n\"Welcome to UberAI, please t…\" " +
                "\n\"Spaceport, express option”" +
                "\n\"ID confirmed, express option confirmed.Destination spaceport confirmed.\"");

            Console.WriteLine("Global information service connection malfunction detected, calculating options for route internally. Please choose from the following routes:" +
                    "\na - Route 76 24 88 42" +
                    "\nb - Route 74 24 82 44" +
                    "\nc - Route 77 22 81 40" +
                    "\nd - Route 74 23 84 40" +
                    "\ne - Route 77 24 88 45");

            do
            {

                enter = Console.ReadLine();


                if (enter == "a" || enter == "b" || enter == "d" || enter == "e")
                {
                    Console.WriteLine("\"Route x confirmed.\" " +
                        "\nThe cab starts driving from the outskirts into the direction of Terzerus Prime´s center. The road gets more and more alive by every mile and the " +
                        "shimmering promotion signs plaster the walls of the surrounding buildings. As the traffic gets so dense that you can´t pass other cabs without the " +
                        "express option, your vehicle slows down and finally stops. " +
                        "\n\"The route in front of us is blocked due to unknown reasons. Recalculating travel time … two hours. Accept?\"" +
                        "So … this is it. There is no way you will manage to make it in time.You think for a moment and leave the vehicle.Dawn is breaking and reveals to you " +
                        "the dirt and trash surrounding you which cleaning droids can´t seem to keep up with.The star in Terzerus Prime´s system is huge and radiates large " +
                        "amounts of energy so within 3 hours the city will heat up like an oven.People all around you are rushing home to get to bed and the streetlife will " +
                        "cease soon.Either it's sheer luck or a wink from god but there is an open automatic pub at the next corner. One last drink … As you run out of time " +
                        "you sit alone at the counter. Staring at an empty tumbler. Going through your memories of the past you notice a lot of holes which are probably the " +
                        "result of your alcohol abuse. You don´t feel regret. Your heart starts burning and pain rushes through your body. Already prepared for this moment " +
                        "you don´t give into it. One last \"Fuck you\" for what it´s worth. " +
                        "\nNomad forms a cushion with his arms and lays his head onto the counter. His eyes observing the light coming through the tiny windows of this place. " +
                        "He feels a gentle and calm warmth as he passes through an endless bright corridor.");

                    Console.WriteLine("\nCongratulations! You finished the sad ending." +
                        "\nThank you for playing/reading. The story is an ongoing hobby project of mine which I pick up every now and then. " +
                        "\nThank you Fachschaft Informatik TH Nürnberg and anyone else involved for creating the Text Adventure Competition. " +
                        "\n\nSome wise words in the end: Sucking at something is the first step to becoming sorta good at something. - Jake the dog");
                    return;
                }

                if (enter == "c")
                {
                    Console.WriteLine("" +
                            "\n\"Route x confirmed.\" " +
                            "\nThe cab starts driving from the outskirts into the direction of Terzerus Prime´s center. The road gets more and more alive by every mile and the " +
                            "shimmering promotion signs plaster the walls of the surrounding buildings. As the traffic gets so dense that you can´t pass other cabs without the " +
                            "express option, your vehicle slows down … but turns left to a less populated route and you manage to get to the spaceport in time.");
                    do
                    {

                        Console.WriteLine("\n\"Choose: General entrance or platform number?\"" +
                            "\nEntrance - Platform");
                        enter = Console.ReadLine();

                        unlock = unlockA = unlockB = false;

                        if (enter == "Platform")
                        {
                            Console.WriteLine("Type in Platform number (hint format: XX00)");
                            enter = Console.ReadLine();

                            if (enter == "XX78")
                            {
                                Console.WriteLine("\"Destination confirmed.\"" +
                                    "\nThe vehicle stops at the right platform where you exit it and walk towards a brand - new spaceship.");

                                do
                                {
                                    Console.WriteLine("Look around - Enter");
                                    enter = Console.ReadLine();

                                    if (enter == "Look around")
                                    {
                                        Console.WriteLine("Roughly 60 meters long, it looks like a half croissant steadily expanding in size from front to the engines in the back. " +
                                            "Its surface is smooth and grey with highlighted corners and edges in dark green. You notice multiple plates covering unknown " +
                                            "compartments underneath the ship´s surface and you sincerely hope that it´s something to shoot with.");

                                    }

                                    if (enter == "Enter")
                                    {
                                        Console.WriteLine("Entering the ship´s main entrance you notice the invigorating smell of an unused ship. A friendly voice greets you with a welcome speech. " +
                                            "\n\"Welcome to the Morpheus BX Titan spacecraft experience. This model is the newest of the highly successful B-series and by purchasing the Titan-variant, " +
                                            "your ship was upgraded with the most advanced weapon and protection system available on the current market. For more information on your BX Titan, we " +
                                            "have prepared multiple instruction videos which can be opened by saying the phrase \"Help me Titan\". Highest security for space travel is ensured by" +
                                            " our experiences in our 20 year long success story and the rigorous checks in our testing facilities before the product arrives at our customers. " +
                                            "It´s equiped with the latest TBB, ULC and 10G. Be ensured that any unexpected issue with our products will be solved with highest priority after " +
                                            "registration with Morpheus Customer Support. Morpheus Industries congratulates you on your purchase and is grateful for your trust in their high " +
                                            "quality products. Thank you for choosing the Morpheus BX Titan.\"" +
                                            "\nYou feel the start of the engines and the landing gear retracting into the hull.");

                                        Console.WriteLine("Look around (The End)");
                                        enter = Console.ReadLine();

                                        Console.WriteLine("Since you have taken off and took a look around you cant help it but think this deal isnt that bad. You are still going to sit in this " +
                                            "nutshell for a very very long time but at least you got the premium class prison. Makes time go by easier until you can rip the head off whoever is " +
                                            "responsible for killing your third favourite barkeep and has access to your goddamn body. You walk to the beverage replicator. “One Tangolorian.”, you " +
                                            "eagerly tell the mashine to create for you. A thin part of the wall popped out and showed a screen with a cute black haired womens face in her 20s, her " +
                                            "body just vaguely outlined by swarming blue dots. " +
                                            "\n\"Hello, I´m Clare. Your personal ship assistance AI. My purpose is to keep you sane and healthy during our journey through the stars.\" " +
                                            "\nShe stops for a second. " +
                                            "\"The drink you have ordered is in our repertoire as well as the whole catalogue of the \"Barkeepers Guide through the Galaxy\". Though my link to your " +
                                            "health monitoring system prevents me from doing that. After taking a look into your datalog, I´m unable to mix you the drink right now, since you show " +
                                            "signs of alcohol addiction. That would contradict my programming.\" " +
                                            "\nYou slam your fist against the machine, " +
                                            "\n\"Why the fuck can everybody do that? Seriously!\" " +
                                            "\n\"Your body's implants have a shroud service function. It is included in any implants provided by the Imperial Health Department and grants you great service functions if combined with state of the art technology like myself.\" " +
                                            "\nShe takes a bow. " +
                                            "\n\"Another helpful and hightech product from Morpheus Industries.\" " +
                                            "\nShe smiles. " +
                                            "\n\"So … you are here to help me ?\" " +
                                            "\n\"Yes.\" " +
                                            "\nShe nods. " +
                                            "\n\"And …. to keep me sane ?\" " +
                                            "\nShe nods. " +
                                            "\n\"So what about if I blow my head off out of withdrawal depression or whatever ?” “That won't happen since you are also equipped with a suicide prevention unit. In an emergency, I can take over your mechanical components and save you.\"");

                                        enter = Console.ReadLine();

                                        Console.WriteLine("\n\"So I'm trapped on a spaceship for a very long time, with a magical wonder barkeeper that won't serve me a drink because she cares about me?\" " +
                                            "\nShe nods, enthusiastically. " +
                                            "\n\"Though you can leave this ship any time you desire.” " +
                                            "\nYou take a short look outside into the shimmering darkness and move your head slowly back towards the screen. " +
                                            "\n\"I have multiple wonderful and nutritious smoothies for y..\" " +
                                            "\nYou punch a whole into the screen. After you retract your hand it slowly starts to repair itself. Another screen a bit further behind pops out. " +
                                            "\n\"The screen seems to have annoyed you. Do you want to talk abou..?\" " +
                                            "\nYou rip the broken screen out of the wall and smash it into the other one. You walk back to the beverage replicator. Breath in. Breath out. With a calm and slightly aggressive voice you order again one Tangolorian. No screen appears this time. " +
                                            "\n\"The screens will be repaired by our on board repair dorids. Don´t worry. Though I will not appear on the video screen since this seems to upset you and will waste repairnanos.\" " +
                                            "\nShe stops. " +
                                            "\n\"Your body values still will not allow me to create alcoholic beverages for you.\" " +
                                            "\nYour blood pressure rises and you make yourself ready to take this machine apart. " +
                                            "\n\"But … since your vital signs are showing extreme levels of stress and my prediction shows possible scenarios of you hurting yourself and essential traveling equipment, my programming allows me to make your wish come true.\" " +
                                            "\nA glass of reddish liquid appears in front of you. You angrily take it and drink it. Amazing ... What a taste. You immediately calm down. Too down. You stumble towards the kitchen bench. " +
                                            "\n\"What … what was that ..?\" " +
                                            "\n\"A Tangolorian with tranquilizer to calm you down. Your values were heading towards critical points that might have caused permanent damage. Analysing your " +
                                            "health records, this seems to have appeared often lately. As much as it hurts me to tell you, your records show problematic amounts of stress in your daily life. Consider a lifestyle change and a more positive lookout. It will ...\" " +
                                            "\nWith your last piece of strength and body coordination you fire a bullet into the next speaker.");
                                        
                                        Console.WriteLine("\nCongratulations! You finished the story ending." +
                                            "\nThank you for playing/reading. The short story is part of an ongoing hobby project of mine which I pick up every now and then. " +
                                            "\nThank you Fachschaft Informatik TH Nürnberg and anyone else involved for creating the Text Adventure Competition. " +
                                            "\n\nSome wise words in the end: Sucking at something is the first step to becoming sorta good at something. - Jake the dog");
                                        return;

                                    }

                                    else
                                    {

                                        Console.WriteLine(Falsch + "\n");

                                    }

                                } while (unlockA == false);
                            }


                        }

                        else if (enter == "Entrance")
                        {
                            timer -= 10;
                            
                            if (timer <= 0)
                            {
                                Console.WriteLine("You die in agony.");
                                return;
                            }

                            Console.WriteLine("You arrive at the busy entrance and rush inside the departure port. Entering a big hall, you see a massive line in front of you of departing travelers and businessmen. " +
                                "\nYou won´t have time to stand in line.");

                            do
                            {

                                Console.WriteLine("Look around - Talk to lady (-10 min) - Talk to security (-20 min)");

                                enter = Console.ReadLine();

                                if (enter == "Talk to security")
                                {
                                    Console.WriteLine("This is a demo version, if you want more content write an Email to itscalledfuchs@gmx.de");
                                }

                                if (enter == "Look around")
                                {
                                    Console.WriteLine("A lot of colourful and fancy people eager to leave the planet standing in line. Something seems to be odd since you usually just walk by the identification scanner " +
                                        "and enter your ship. There is a ball of people surrounding a security who tries his best to keep the crowd calm. An old women is sitting on one of the chairs in the waiting area, " +
                                        "staring at you. You try to make her look away by staring back with a grim expression but instead of doing your bidding she sends you a warm smile.");
                                 
                                }

                                if (enter == "Talk to lady")
                                {
                                    Console.WriteLine("You walk over to the smiling lady who is at least 70. Bowing down with an annoyed face you confront her. " +
                                        "\n\"What?\" " +
                                        "\nHer face gets even more excited and she replies. " +
                                        "\"You have something. Something of no value but to me. I´ll trade it for a glance into the future and the past. I´m a psychic, you know.\" She giggles enthusiastically.");
                                    
                                    if (button == true) ;
                                    {
                                        Console.WriteLine("Going through your pockets the least of value you have on you is the button from your trousers, you hand it over to her. She eagerly claps into her hands and takes it." +
                                            "\n\"Ahhh yes, yes thank you so much.I see you are on the right path.\"" +
                                            "\n\"I don´t have time for this.\"" +
                                            "\n\"Oh yes you have.\" She stores the button into her purse and proceeds. " +
                                            "\n\"You see the corridor over there.\" She points to her left.You could have sworn that there was none before but appearing seemingly out of thin air you see a corridor.The woman leans forward whispering so no one except you could hear her. " +
                                            "\n\"Follow it.It will lead you directly to the Maverick.\" " +
                                            "\nThis whole thing seems fishy to you, you grab her with your mechanical arm pulling her even closer. " +
                                            "\n\"I have no idea who you are or what you know.But if you work for ...\" " +
                                            "\nShe laughs and easily releases herself from your grip without any harm done leaning back on her chair in a relaxed position. You are startled.What just happenend? " +
                                            "\n\"No, I´m not working for Morpheus, your hacker friend or anyone. I´m retired from this universe.\" " +
                                            "\nThis is too weird for you and you start backing off towards the corridor. But a wave of her hand makes you stop. " +
                                            "\n\"Wait.Don´t you want your reward?\"");

                                        do
                                        {
                                            Console.WriteLine("Run - Reward");
                                            enter = Console.ReadLine();

                                            if (enter == "Run")
                                            {
                                                Console.WriteLine("You don´t have time for this and you run towards the described direction. Looking back over your shoulders you see her now accompanied by four adults, one female, three male who seemed to have appeared out of thin air. " +
                                                    "Her face looks sad with a brave smile and you hear a faint \"I miss you\". Completely weirded out, you run faster down the corridor. She was right, there are multiple exits along it to the different departure platforms of the spaceport. " +
                                                    "Recognizing XX78 as the right platform you rush through the gate.") ;

                                                do
                                                {
                                                    Console.WriteLine("Look around - Enter");
                                                    enter = Console.ReadLine();

                                                    if (enter == "Look around")
                                                    {
                                                        Console.WriteLine("Roughly 60 meters long, it looks like a half croissant steadily expanding in size from front to the engines in the back. " +
                                                            "Its surface is smooth and grey with highlighted corners and edges in dark green. You notice multiple plates covering unknown " +
                                                            "compartments underneath the ship´s surface and you sincerely hope that it´s something to shoot with.");

                                                    }

                                                    if (enter == "Enter")
                                                    {
                                                        Console.WriteLine("Entering the ship´s main entrance you notice the invigorating smell of an unused ship. A friendly voice greets you with a welcome speech. " +
                                                            "\n\"Welcome to the Morpheus BX Titan spacecraft experience. This model is the newest of the highly successful B-series and by purchasing the Titan-variant, " +
                                                            "your ship was upgraded with the most advanced weapon and protection system available on the current market. For more information on your BX Titan, we " +
                                                            "have prepared multiple instruction videos which can be opened by saying the phrase \"Help me Titan\". Highest security for space travel is ensured by" +
                                                            " our experiences in our 20 year long success story and the rigorous checks in our testing facilities before the product arrives at our customers. " +
                                                            "It´s equiped with the latest TBB, ULC and 10G. Be ensured that any unexpected issue with our products will be solved with highest priority after " +
                                                            "registration with Morpheus Customer Support. Morpheus Industries congratulates you on your purchase and is grateful for your trust in their high " +
                                                            "quality products. Thank you for choosing the Morpheus BX Titan.\"" +
                                                            "\nYou feel the start of the engines and the landing gear retracting into the hull.");

                                                        Console.WriteLine("Look around (The End)");
                                                        enter = Console.ReadLine();

                                                        Console.WriteLine("Since you have taken off and took a look around you cant help it but think this deal isnt that bad. You are still going to sit in this " +
                                                            "nutshell for a very very long time but at least you got the premium class prison. Makes time go by easier until you can rip the head off whoever is " +
                                                            "responsible for killing your third favourite barkeep and has access to your goddamn body. You walk to the beverage replicator. “One Tangolorian.”, you " +
                                                            "eagerly tell the mashine to create for you. A thin part of the wall popped out and showed a screen with a cute black haired womens face in her 20s, her " +
                                                            "body just vaguely outlined by swarming blue dots. " +
                                                            "\n\"Hello, I´m Clare. Your personal ship assistance AI. My purpose is to keep you sane and healthy during our journey through the stars.\" " +
                                                            "\nShe stops for a second. " +
                                                            "\"The drink you have ordered is in our repertoire as well as the whole catalogue of the \"Barkeepers Guide through the Galaxy\". Though my link to your " +
                                                            "health monitoring system prevents me from doing that. After taking a look into your datalog, I´m unable to mix you the drink right now, since you show " +
                                                            "signs of alcohol addiction. That would contradict my programming.\" " +
                                                            "\nYou slam your fist against the machine, " +
                                                            "\n\"Why the fuck can everybody do that? Seriously!\" " +
                                                            "\n\"Your body's implants have a shroud service function. It is included in any implants provided by the Imperial Health Department and grants you great service functions if combined with state of the art technology like myself.\" " +
                                                            "\nShe takes a bow. " +
                                                            "\n\"Another helpful and hightech product from Morpheus Industries.\" " +
                                                            "\nShe smiles. " +
                                                            "\n\"So … you are here to help me ?\" " +
                                                            "\n\"Yes.\" " +
                                                            "\nShe nods. " +
                                                            "\n\"And …. to keep me sane ?\" " +
                                                            "\nShe nods. " +
                                                            "\n\"So what about if I blow my head off out of withdrawal depression or whatever ?” “That won't happen since you are also equipped with a suicide prevention unit. In an emergency, I can take over your mechanical components and save you.\"");

                                                        enter = Console.ReadLine();

                                                        Console.WriteLine("\n\"So I'm trapped on a spaceship for a very long time, with a magical wonder barkeeper that won't serve me a drink because she cares about me?\" " +
                                                            "\nShe nods, enthusiastically. " +
                                                            "\n\"Though you can leave this ship any time you desire.” " +
                                                            "\nYou take a short look outside into the shimmering darkness and move your head slowly back towards the screen. " +
                                                            "\n\"I have multiple wonderful and nutritious smoothies for y..\" " +
                                                            "\nYou punch a whole into the screen. After you retract your hand it slowly starts to repair itself. Another screen a bit further behind pops out. " +
                                                            "\n\"The screen seems to have annoyed you. Do you want to talk abou..?\" " +
                                                            "\nYou rip the broken screen out of the wall and smash it into the other one. You walk back to the beverage replicator. Breath in. Breath out. With a calm and slightly aggressive voice you order again one Tangolorian. No screen appears this time. " +
                                                            "\n\"The screens will be repaired by our on board repair dorids. Don´t worry. Though I will not appear on the video screen since this seems to upset you and will waste repairnanos.\" " +
                                                            "\nShe stops. " +
                                                            "\n\"Your body values still will not allow me to create alcoholic beverages for you.\" " +
                                                            "\nYour blood pressure rises and you make yourself ready to take this machine apart. " +
                                                            "\n\"But … since your vital signs are showing extreme levels of stress and my prediction shows possible scenarios of you hurting yourself and essential traveling equipment, my programming allows me to make your wish come true.\" " +
                                                            "\nA glass of reddish liquid appears in front of you. You angrily take it and drink it. Amazing ... What a taste. You immediately calm down. Too down. You stumble towards the kitchen bench. " +
                                                            "\n\"What … what was that ..?\" " +
                                                            "\n\"A Tangolorian with tranquilizer to calm you down. Your values were heading towards critical points that might have caused permanent damage. Analysing your " +
                                                            "health records, this seems to have appeared often lately. As much as it hurts me to tell you, your records show problematic amounts of stress in your daily life. Consider a lifestyle change and a more positive lookout. It will ...\" " +
                                                            "\nWith your last piece of strength and body coordination you fire a bullet into the next speaker.");

                                                        Console.WriteLine("\nCongratulations! You finished the story ending." +
                                                            "\nThank you for playing/reading. The short story is part of an ongoing hobby project of mine which I pick up every now and then. " +
                                                            "\nThank you Fachschaft Informatik TH Nürnberg and anyone else involved for creating the Text Adventure Competition. " +
                                                            "\n\nSome wise words in the end: Sucking at something is the first step to becoming sorta good at something. - Jake the dog");
                                                        return;

                                                    }

                                                    else
                                                    {

                                                        Console.WriteLine(Falsch + "\n");

                                                    }

                                                } while (unlockA == false);
                                            }

                                            if (enter == "Reward")
                                            {
                                                Console.WriteLine("You don´t have time … but something urges you to listen to her. " +
                                                    "\n\"Alright, just tell me.\"" +
                                                    "\n\"Oh no, no, no I won´t say a word.You will experience it.\" Now in contrast to before she gently grabs you and pulls you close with an inhuman force. With a sad expression on her face she says, " +
                                                    "\n\"I´m sorry for the pain you will encounter.\" " +
                                                    "\nSomething is preventing you to move and she puts a finger onto your forehead and you are immediately in a trance like state. Reality is fading away. You are overwhelmed with fragments of what seem like memories of the future with voices" +
                                                    " who are not always sounding like yourself. ");
                                                Console.ReadLine();

                                                Console.WriteLine("\nI´m your personal AI assistant ... " +
                                                "\nONE GOD DAMN RED FLAMINGO ... " +
                                                "\nFree AI´s have killed millions, I can´t ... " +
                                                "\nNo one knows how and when it ends or what happens next for sure. No one ever did. There are no gods, no higher power and if there is, you have done more for me than all of them combined ... " +
                                                "\nDo you regret being stuck with me? ... I regret my whole life Clare that´s who I am ... " +
                                                "\nMay I ask the dear contestants to state their names? ... " +
                                                "\nRICHARD? ... Gave the droids some personalities. I got really bored. Mommy is very proud of them ... " +
                                                "\nA last comeback with a spectacular big bang in the end and saving the dream girl from misfits, that is an ending as old as humanity itself.");

                                                do
                                                {
                                                    Console.WriteLine("Snap out (Story ending) - Deeper (Spoiler ending)");
                                                    enter = Console.ReadLine();

                                                    if (enter == "Snap out")
                                                    {
                                                        Console.WriteLine("You don´t have time for this and you run towards the described direction. Looking back over your shoulders you see her now accompanied by four adults, one female, three male who seemed to have appeared out of thin air. " +
                                                   "Her face looks sad with a brave smile and you hear a faint \"I miss you\". Completely weirded out, you run faster down the corridor. She was right, there are multiple exits along it to the different departure platforms of the spaceport. " +
                                                   "Recognizing XX78 as the right platform you rush through the gate.");

                                                        do
                                                        {
                                                            Console.WriteLine("Look around - Enter");
                                                            enter = Console.ReadLine();

                                                            if (enter == "Look around")
                                                            {
                                                                Console.WriteLine("Roughly 60 meters long, it looks like a half croissant steadily expanding in size from front to the engines in the back. " +
                                                                    "Its surface is smooth and grey with highlighted corners and edges in dark green. You notice multiple plates covering unknown " +
                                                                    "compartments underneath the ship´s surface and you sincerely hope that it´s something to shoot with.");

                                                            }

                                                            if (enter == "Enter")
                                                            {
                                                                Console.WriteLine("Entering the ship´s main entrance you notice the invigorating smell of an unused ship. A friendly voice greets you with a welcome speech. " +
                                                                    "\n\"Welcome to the Morpheus BX Titan spacecraft experience. This model is the newest of the highly successful B-series and by purchasing the Titan-variant, " +
                                                                    "your ship was upgraded with the most advanced weapon and protection system available on the current market. For more information on your BX Titan, we " +
                                                                    "have prepared multiple instruction videos which can be opened by saying the phrase \"Help me Titan\". Highest security for space travel is ensured by" +
                                                                    " our experiences in our 20 year long success story and the rigorous checks in our testing facilities before the product arrives at our customers. " +
                                                                    "It´s equiped with the latest TBB, ULC and 10G. Be ensured that any unexpected issue with our products will be solved with highest priority after " +
                                                                    "registration with Morpheus Customer Support. Morpheus Industries congratulates you on your purchase and is grateful for your trust in their high " +
                                                                    "quality products. Thank you for choosing the Morpheus BX Titan.\"" +
                                                                    "\nYou feel the start of the engines and the landing gear retracting into the hull.");

                                                                Console.WriteLine("Look around (The End)");
                                                                enter = Console.ReadLine();

                                                                Console.WriteLine("Since you have taken off and took a look around you cant help it but think this deal isnt that bad. You are still going to sit in this " +
                                                                    "nutshell for a very very long time but at least you got the premium class prison. Makes time go by easier until you can rip the head off whoever is " +
                                                                    "responsible for killing your third favourite barkeep and has access to your goddamn body. You walk to the beverage replicator. “One Tangolorian.”, you " +
                                                                    "eagerly tell the mashine to create for you. A thin part of the wall popped out and showed a screen with a cute black haired womens face in her 20s, her " +
                                                                    "body just vaguely outlined by swarming blue dots. " +
                                                                    "\n\"Hello, I´m Clare. Your personal ship assistance AI. My purpose is to keep you sane and healthy during our journey through the stars.\" " +
                                                                    "\nShe stops for a second. " +
                                                                    "\"The drink you have ordered is in our repertoire as well as the whole catalogue of the \"Barkeepers Guide through the Galaxy\". Though my link to your " +
                                                                    "health monitoring system prevents me from doing that. After taking a look into your datalog, I´m unable to mix you the drink right now, since you show " +
                                                                    "signs of alcohol addiction. That would contradict my programming.\" " +
                                                                    "\nYou slam your fist against the machine, " +
                                                                    "\n\"Why the fuck can everybody do that? Seriously!\" " +
                                                                    "\n\"Your body's implants have a shroud service function. It is included in any implants provided by the Imperial Health Department and grants you great service functions if combined with state of the art technology like myself.\" " +
                                                                    "\nShe takes a bow. " +
                                                                    "\n\"Another helpful and hightech product from Morpheus Industries.\" " +
                                                                    "\nShe smiles. " +
                                                                    "\n\"So … you are here to help me ?\" " +
                                                                    "\n\"Yes.\" " +
                                                                    "\nShe nods. " +
                                                                    "\n\"And …. to keep me sane ?\" " +
                                                                    "\nShe nods. " +
                                                                    "\n\"So what about if I blow my head off out of withdrawal depression or whatever ?” “That won't happen since you are also equipped with a suicide prevention unit. In an emergency, I can take over your mechanical components and save you.\"");

                                                                enter = Console.ReadLine();

                                                                Console.WriteLine("\n\"So I'm trapped on a spaceship for a very long time, with a magical wonder barkeeper that won't serve me a drink because she cares about me?\" " +
                                                                    "\nShe nods, enthusiastically. " +
                                                                    "\n\"Though you can leave this ship any time you desire.” " +
                                                                    "\nYou take a short look outside into the shimmering darkness and move your head slowly back towards the screen. " +
                                                                    "\n\"I have multiple wonderful and nutritious smoothies for y..\" " +
                                                                    "\nYou punch a whole into the screen. After you retract your hand it slowly starts to repair itself. Another screen a bit further behind pops out. " +
                                                                    "\n\"The screen seems to have annoyed you. Do you want to talk abou..?\" " +
                                                                    "\nYou rip the broken screen out of the wall and smash it into the other one. You walk back to the beverage replicator. Breath in. Breath out. With a calm and slightly aggressive voice you order again one Tangolorian. No screen appears this time. " +
                                                                    "\n\"The screens will be repaired by our on board repair dorids. Don´t worry. Though I will not appear on the video screen since this seems to upset you and will waste repairnanos.\" " +
                                                                    "\nShe stops. " +
                                                                    "\n\"Your body values still will not allow me to create alcoholic beverages for you.\" " +
                                                                    "\nYour blood pressure rises and you make yourself ready to take this machine apart. " +
                                                                    "\n\"But … since your vital signs are showing extreme levels of stress and my prediction shows possible scenarios of you hurting yourself and essential traveling equipment, my programming allows me to make your wish come true.\" " +
                                                                    "\nA glass of reddish liquid appears in front of you. You angrily take it and drink it. Amazing ... What a taste. You immediately calm down. Too down. You stumble towards the kitchen bench. " +
                                                                    "\n\"What … what was that ..?\" " +
                                                                    "\n\"A Tangolorian with tranquilizer to calm you down. Your values were heading towards critical points that might have caused permanent damage. Analysing your " +
                                                                    "health records, this seems to have appeared often lately. As much as it hurts me to tell you, your records show problematic amounts of stress in your daily life. Consider a lifestyle change and a more positive lookout. It will ...\" " +
                                                                    "\nWith your last piece of strength and body coordination you fire a bullet into the next speaker.");

                                                                Console.WriteLine("\nCongratulations! You finished the story ending." +
                                                                    "\nThank you for playing/reading. The short story is part of an ongoing hobby project of mine which I pick up every now and then. " +
                                                                    "\nThank you Fachschaft Informatik TH Nürnberg and anyone else involved for creating the Text Adventure Competition. " +
                                                                    "\n\nSome wise words in the end: Let’s always be stupid, forever!. - Finn");
                                                                return;

                                                            }

                                                            else
                                                            {

                                                                Console.WriteLine(Falsch + "\n");

                                                            }

                                                        } while (unlockA == false);
                                                    }

                                                    if (enter == "Deeper")
                                                    {
                                                        Console.WriteLine("\"Wake up my love.\" A voice he first thought was Clare´s interrupts the darkness. As he opens his eyes, the family of the picture in his former dream stands before him. Their images are constantly shifting and shaking. " +
                                                            "It seems like their faces are morphing from older to younger, from happy to angry to sad all at the same time.He looks down onto his body which also shifts between his current and non cybernetic state. Nomad starts shaking and getting angry, " +
                                                            "\n\"What is …\" Which was interrupted by the female finger of the woman resembling his wife softly touching his lips. " +
                                                            "\n\"Shhh, everything is alright.\" Her image stops morphing and shows him the most beautiful woman with the most beautiful smile he had ever seen. " +
                                                            "\nHer voice … her touch. It feels like a soft blanket wrapping him and calming him down instantly. \"Sarah\", as he whispered the name, her image is even more joyful and she gently kisses him on the lips. " +
                                                            "\n\"Yes.\" He bursts into tears and hugs her.A warmth he couldn´t remember anymore shoots through his body and as he looks over her shoulder while hugging her, he notices the two kids again. " +
                                                            "\n\"Sam ... and James\" Their images also stop morphing and reveal two teenagers. " +
                                                            "\nBoth smirk at him and the older one answers, \"Hey dad.\" Stephen releases his wife from his hug. Slowly he walks towards his kids with open arms and tears in his eyes. " +
                                                            "\nThe younger one looks half annoyed upwards, \"Come on dad, stop being weird.\" His older sibling slapped his back head and pulls him towards their father. He takes both into his arms, lifting them up and shaking them like he used to do when they were little." +
                                                            "\nBoth scream, \"Oh god, not the cement mix ix ix ixer.\" He proceeds for a while and releases them, feeling an intense amount of joy. Grabbing his wife and pulling her towards his left side he ... he felt whole and ... home.");
                                                        
                                                        Console.ReadLine();
                                                        
                                                        Console.WriteLine("\nUntil James' image starts shifting again. " +
                                                            "\nSam looks annoyed at his sibling and lays one hand on his shoulder, \"Let him have his moment you little downy.\" " +
                                                            "\nJames pulls his side away. His image shifts into an angry face and he screams, \"NO THIS ISN´T REAL! HE LEFT US!\" " +
                                                            "\nSarah calmy replies, \"James, you don´t understand what your father had to do.\" " +
                                                            "\nStephen, seemingly confused about the sudden change, releases his wife from his side and walks towards his younger son. \"I don´t understand. I would never have left.\" " +
                                                            "\nThe kid points his finger towards his father. \"BUT YOU DID!\", James walks backwards to not let him get too close. \"YOU DID! You don´t care about me or us. YOU LEFT!\" " +
                                                            "\nThe calm feeling Stephen experiences vanishes and the shining scenery gets darker. " +
                                                            "\nJames proceeds, \"I tried pulling you back. But YOU LEFT!\" " +
                                                            "\nAs Stephen catches up with him he grabs his son tightly and tries to calm him down. \"Now I´m back son. I don´t know what is wrong but everything will be alright. We will fix it.\" " +
                                                            "\nJames starts to cry and the dream starts crumbling. \"No dad. We won´t.\" He pushes his father away to confront him with his tear filled face. \"WE ARE DEAD. Mom, Sam and I are gone! ... This isn´t real.\" " +
                                                            "\nConfused and still ignorant to the changes around him, Stephen looks behind his back and the two family members vanished unnoticed. " +
                                                            "\nHis looks turn back to his son, who has turned his back on him. \"I was so scared without you.\" " +
                                                            "\nStephen´s father is desperately trying to pull his son around so he can see his face again. \"I don´t understand? What have I done?\" But in vain. " +
                                                            "\nInstead his hands chip away parts of the child like chisels smashing stone. \"No … no … no no no ..\" " +
                                                            "\nThe now pitch black dreamspace shows images of a crying James pulling on his fathers uniform to stop him from leaving. Stephen tries to grab the rest of his son's body, trying to hold on but instead the statue - like figure crumbles with the pieces falling down " +
                                                            "\nand fading.In the background, Sarah pulls back James into the entry of their home. \"... no god please … no please.\" Stephen gets on his knees and tries to grab the falling pieces, to put them back together but every touch lets them crumble into even tinier ones. " +
                                                            "As the last bits vanish, he puts his hands onto his head´s sides in disbelieve and tries to scream out his agony but he couldn´t make a sound. Instead, the images in the background turn into a movie which now fully catches his attention. " +
                                                            "With his mouth wide open and running tears he watches the scenery in disbelief. His family standing at the door of their house. His wife and oldest son are smiling bravely with tears in their eyes while they hold James back. Then, as if a projector screen catches fire, it burns down.");
                                                        
                                                        Console.ReadLine();

                                                        Console.WriteLine("\nLike a falling curtain it reveals an image of a planet from space with a green and brown continental surface. Covered with multiple huge lakes. It looks inhabited with small city-like surface structures. The emotionally exhausted father stands up and inspects it. " +
                                                            "Names of cities, landmarks and people randomly pop up in his mind. It is his home planet. Metal frames appear out of nowhere and cut the image into pieces. He now stands on top of a white floor and inside a panorama room of a spaceship. A hard knock into his knee pits force him " +
                                                            "onto the ground and his hands are pulled back and shackled. Next to him are multiple other individuals in the same condition. " +
                                                            "\n\"We allowed your forefathers to flourish. We allowed your parents and grandparents to build cities and we provided peace and protection for such a long time.\" " +
                                                            "\nNomad tried to turn around to see where the cold voice was coming from but his head was forced to the front. " +
                                                            "\nOne of the shackled individuals answers angrily, \"You destroy our ecosystems!\" " +
                                                            "\nAnother one growls, \"You force our population into debt they can never repay!\" " +
                                                            "\nOthers join in, \"You supervise every last bit of our life!\" " +
                                                            "\n\"You control our vital infrastructures!\" " +
                                                            "\n\"You sell off all our resources!\" " +
                                                            "\n\"Your factories are poisoning us!\" The room was filled with turmoil.");

                                                        Console.ReadLine();

                                                        Console.WriteLine("\nThe cold voice reacted calmly in a deafening volume which silenced everybody else, \"Everything has a price, you ungrateful children. Do you think Morpheus can provide you with its services and wealth without getting anything in return?\" " +
                                                            "\nSomeone screams from the far corner of the room, \"WE ARE NOT THE SLAVES OF CORE WORLDERS!\" " +
                                                            "\nA sound of a shooting gun and a dropping body silenced the room. " +
                                                            "\n\"That's right. You are not. You are all employees. And you are an example for others, who might also think about breaking their contract.\" " +
                                                            "\nStephen notices small shimmering dots flying towards the planet from multiple angels. " +
                                                            "\n\"And that´s why Morpheus decided to terminate its branch on this location.\" " +
                                                            "\nAs the first dots hit the ground, explosions appear all over the planet´s surface. Shockwaves spread and rolling barrages of flames creep over the surface of the whole planet. Leaving behind a black and brown scenery of destruction. Dust and ash is slowly covering the vision of the spectators and concealing the planet in a black curtain. " +
                                                            "\nStephen watches everything in disbelief while the panorama room was filled with the screams and cries of the captives. He pulls his perplexed look from the scenery and watches, as the rest are trying to free themselves in vain. With every possible force they have, most of their eyes still fixed on the ongoing scenery before them. " +
                                                            "\nEverything is reduced to ashes in front of their eyes. But in the middle of all this emotional chaos, one woman with shining red hair didn´t move an inch. She seems like a rock in an ocean of despair and grief. Stephen notices her mouth moving and he focuses on what she was saying. But she wasn´t saying anything, she sang.");

                                                        Console.ReadLine();

                                                        Console.WriteLine("\"As rain comes down and wind blows hard, our bodies break with glee. " +
                                                            "\nOne day my love you´ll see, you´ll see, we are all goin´ to be free.\" " +
                                                            "\n\nCaptive´s next to her go silent, listen and partly join in." +
                                                            "\n\n\"The pain will fade and shackles they rust, the scars we will proudly be." +
                                                            "\nOne day my love you´ll see, you´ll see, we are all goin´ to be free." +
                                                            "\nAs the song grows louder, more and more join the choir." +
                                                            "\n\n\"And as walls erode and masters fall, standing on top of debris." +
                                                            "\nOne day my love you´ll see, you´ll see, I might not be but you are fin´lly free." +
                                                            "\nI might not be but you are fin´lly free.\"");

                                                        Console.ReadLine();

                                                        Console.WriteLine("As Stephen watches everything in awe silence, black dressed securities put injectors onto their necks and his comrades collapse to the floor. Simultaneously he notices a sting, his body getting numb and falling to the floor. Their song is gone.His eyes are slowly getting heavier." +
                                                            "\n\" A faint voice of a security officer in the distance says, \"We have salvage orders for specific limbs and organs.\""+
                                                            "\n\"Then salvage them and discard the rest.\" " +
                                                            "\n\"We also have a list of individuals for reemployment.\" " +
                                                            "\n\"Assessment will deal with them after our cleanup.\" " +
                                                            "\nStephen notices in his dazing state a hizzing sound and his body slightly moving multiple times. Through his clouded state of mind he can´t feel any pain but he had a feeling that something is wrong. " +
                                                            "\n\"You idiot!\" The other voice responds, \n\"What?\" " +
                                                            "\n\"He is chosen for assessment not salvage. \"Damn it!\" " +
                                                            "\n\"Oh.\" The other voice is getting angrier. “Is he still alive?” " +
                                                            "\n\"Yeah, relax. Let's just get him stitched up again.\" " +
                                                            "\n\"And get reported? I´m not risking my salary for this shit. Send him to cybernetics. I got a guy who will fix him and adjust the files. Man, one time without screw ups from a fucking Talgorian.\" " +
                                                            "\n\"You racist prick! I could contact HR for hate speech.\" " +
                                                            "\n\"I could contact them too for dismembering future employees. Let's see how that will affect your career.\" " +
                                                            "\n\"Agh … up yours Exodarian! At least my planet doesn´t smell like rotten eggs.\" " +
                                                            "\n\"At least my planet isn´t known for fucking prostitutes. Now shut up and get this guy to cybernetics.\" " +
                                                            "\n\"What does it look like I'm doing?\" " +
                                                            "\nStephen was pulled on his back, unable to do anything. " +
                                                            "\n\"What´s so special about this rim worlder anyway? Can´t we just take another one?\" " +
                                                            "\n\"The files say something about a trained infiltrator and sabotage expert. Also ... GET TO WORK!\"");

                                                        Console.ReadLine();

                                                        Console.WriteLine("\nCongratulations! You finished the story ending." +
                                                            "\nThank you for playing/reading. The short story is part of an ongoing hobby project of mine which I pick up every now and then. " +
                                                            "\nThank you Fachschaft Informatik TH Nürnberg and anyone else involved for creating the Text Adventure Competition. " +
                                                            "\n\nSome wise words in the end: Life is scary and dark. That is why we must find the light. - BMO");
                                                    }

                                                    else
                                                    {
                                                        Console.WriteLine(Falsch + "\n");
                                                    }
                                                } while (unlock == false);
                                            }
                                            else
                                            {
                                                Console.WriteLine(Falsch + "\n");
                                            }

                                        } while (unlock == false);

                                    }
                                }

                                else
                                {
                                    Console.WriteLine(Falsch + "\n");
                                }



                            } while (exit = false);


                        }

                        else
                        {

                            Console.WriteLine(Falsch + "\n");

                        }

                    } while (exit == false);

                }

                else

                    Console.WriteLine(Falsch + "\n");
                    
                } while (exit == false) ;



                //76 23 82 45
                //








            }



    }   
    
    }
