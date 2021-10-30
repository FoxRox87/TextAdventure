using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            String enter, Falsch = "Please use the proposed phrases.";
            int leben = 3, i;
            bool unlock = false, unlockA = false, unlockB = false;


            Console.WriteLine(
                "\n       A          SSSSS  PPPPP  AAAAA  CCCCC  EEEEE" +
                "\n      A A         S____  P___P  A___A  C      E_" +
                "\n     A   A            s  P      A   A  C      E" +
                "\n    A     A       SSSSS  P      A   A  CCCCC  EEEEE" +
                "\n   A       A      OOOOO  DDDD   Y   Y  SSSSS  EEEEE  EEEEE" +
                "\n  A         A     O   O  D   D   YYY   S___   E_     E_  " +
                "\n A           A    O   O  D   D    Y        S  E      E"+
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
                "Your blurry vision reveals a half emptied tumbler in front of you.");
           

           
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
            
            Console.WriteLine("... grabbing and emptying it.  " +
                "\nA warm feeling, followed by a smile on your face which radiates your satisfaction through the completely empty half run down bar. " +
                "\nYour life is a ball of shit. " +
                "\nEveryone sucks. " +
                "\nThe meds are working.");

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
                            "A creeping feeling stiffens your neck ... you are starting to shake.");

                        Console.WriteLine("The memories of your last days in service flash before your eyes. " +
                            "You fought on an abandoned planet in the outer rim of the Empire against the last" +
                            " remains of an open rebellion. You were a ...");

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
                                    Console.WriteLine("... who inherited a big piece of land.But it was in debt so you were " +
                                    "forced to join the military and left your family behind who ... I never had a family." +
                                    "This can´t be true ... You must have been a ...");


                                }

                                if (enter == "spy")
                                {
                                    Console.WriteLine("... who operated behind enemy lines and infiltrated the local population." +
                                    "You were tasked to demolish a local communications array of the empire ... Sabotage my own " +
                                    "government ? That makes no sense.You must have been a...");
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
                        " floor. A voice in your head was slowly becoming louder. \"I'm sorry for this unpleasant intrusion into your private life." +
                        "  For the rest of our short ...\"");

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
                "Network will collapse on this planet. Which means, it will be blind and deaf for a while. There is a ship called Maverick at " +
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

            Console.WriteLine(unlock);
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
            
            Console.WriteLine("\n\nCHAPTER 2: Take off");

            int timer = 150;
            bool button = false, id = false, towel = false, home = false, bar = false, medkit = false;
            unlock = unlockA = unlockB = false;


            Console.WriteLine("Alright ... I have only limited time, where should I go next? " + timer +" min");
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

                if (enter =="Go next bar")
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
                                        "sucking on a lollipop, notices you with a smile and walks casually towards you. \"What can I do for you handsome?\"") ;
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

                    unlock = unlockA = unlockB= false;
                }



                else
                {
                    {
                        Console.WriteLine(Falsch + "\n");
                    }
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

                else
                {
                    {
                        Console.WriteLine(Falsch + "\n");
                    }
                }


            } while (enter != "Go to ship");


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

            Console.WriteLine("");
            //Test

            //76 23 82 45
            //








        }



    }   
    
    }
