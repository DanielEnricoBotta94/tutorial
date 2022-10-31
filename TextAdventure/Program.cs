namespace Basics;

class Program
{
    #region RegionExampla

    //Here you can hide code

    #endregion

    static void Main(string[] args)
    {
        gameTitle();
    }
    
    #region secret
    /* this section will demonstrate writing to the console 6/11*/
    public static void gameTitle()
    {
        Console.WriteLine("Ciao! Questo è l'inizio dell'avventura");
        Console.WriteLine("Premere 'Enter' per iniziare.");
        Console.ReadLine();
        Console.Clear();
        first();

    }
    /* this section will demonstrate switches 6/11*/
    public static void first()
    {
        Console.WriteLine("Hai il telefono scarico e sei perso in una foresta");
        Console.WriteLine("Cosa fai?");
        Console.WriteLine("1. Cerchi aiuto");
        Console.WriteLine("2. Cerchi dell'acqua");
        Console.WriteLine("3. Costruisci un riparo");
        Console.Write("scelta: ");
        var choice = Console.ReadLine().ToLower();
        Console.Clear();

        switch (choice)
        {
            case "1":
            case "seek out help":
            case "seek":
            {
                Console.WriteLine("Cammini e cerchi aiuto");
                Console.WriteLine("Cominci ad urlare e riesci a sentire il tuo eco che torna idietro");
                Console.WriteLine("Gli uccelli volano sopra di te, e senti rumori di bestie selvagge");
                Console.WriteLine("Noti che un orso sta correndo verso di te");
                Console.WriteLine("Purtroppo non ci sono vie di fuga");
                Console.ReadLine();
                gameOver();
                break;
            }
            case "2":
            case "look for water":
            {
                Console.WriteLine("Cerchi dell'acqua nell'area");
                Console.WriteLine("Trovi un ruscello e cominci a bere");
                Console.WriteLine("Dopo aver bevuto un po', non hai più sete e continui la tua avventura");
                Console.ReadLine();
                second();
                break;
            }
            case "3":
            case "build":
            case "build a shelter":
            {
                Console.WriteLine("Trovi i materiali necessari e inizi a costruire");
                Console.WriteLine("Dopo un paio di ore hai costruito il riparo.");
                Console.WriteLine("Ti senti più al sicuro ma la notte si avvicina"); ;
                Console.ReadLine();
                second();
                break;
            }
            default:
            {

                Console.WriteLine("Comando invalido");
                Console.WriteLine("Premi Enter per ricominciare");
                Console.ReadLine();
                first();
                break;
            }
        }
    }
    /* this section will demonstrate using random number generator and also allowing player to enter text response 6/18*/
    public static void second()
    {
        Random rnd = new Random();
        string[] secondOptions = { "Vedi tuoni nell'orizzonte, vuoi prendere riparo?",
            "Inizi ad avere fame, vuoi cercare del cibo?",
            "Senti della musica in lontananza, vuoi avvicinarti?"};
        int randomNumber = rnd.Next(0, 3);
        string secText = secondOptions[randomNumber];

        string secChoice;

        Console.WriteLine(secText);
        Console.Write("Choice [y/n]: ");
        secChoice = Console.ReadLine().ToLower();

        if (secChoice == "yes" || secChoice == "y")
        {
            Console.WriteLine("Senti che qualcuno ti sta seguendo, ma decidi di proseguire");
            Console.ReadLine();
            Console.Clear();
            third();

        }
        else if (secChoice == "no" || secChoice == "n")
        {
            Console.WriteLine("Improvvisamente ti senti colpito alla schiena da una potente lacerata di un orso");
            Console.WriteLine("Ti senti come svenire e diventa tutto buio");
            Console.ReadLine();
            gameOver();

        }
        else
        {
            Console.WriteLine("Devi inserire [y/n]");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            second();
        }

    }

    /* this section demonstrates the use of loops 7/16/2019 */

    public static void third()

    {
        int Decision;
        Console.WriteLine("Senti un ululato tra gli alberi");
        Console.WriteLine("Rabbrividisci e cerchi di capire da dove viene il suono");
        Console.WriteLine("1. Combatti");
        Console.WriteLine("2. Scappa");
        Console.Write("");
        int.TryParse(Console.ReadLine(), out Decision);
        int loop = 0;
        bool dead = false;
        while (Decision != 1 && dead == false)
        {
            if (loop <= 0)
            {
                Console.WriteLine("Sei troppo lento, l'orso ti attacca");
                Console.WriteLine("Sei molto danneggiato...");
                Console.WriteLine("1. Combatti");
                Console.WriteLine("2. Scappa");
                Console.Write("");
                int.TryParse(Console.ReadLine(), out Decision);
                loop ++ ;
            }
            else if (loop >= 1)
            {
                Console.WriteLine("L'orso ti prende dalle gambe e cerchi di liberarti");
                Console.WriteLine("Sei molto danneggiato...");
                Console.WriteLine("1. Combatti");
                Console.WriteLine("2. Scappa");
                Console.Write("");
                int.TryParse(Console.ReadLine(), out Decision);
                dead = true;
            }
               
        }
        if (dead == true )
        {
            Console.WriteLine("Vieni colpito e cadi a terra");
            Console.ReadLine();
            gameOver();
        }
        else 

        {
            Console.WriteLine("Combatti ferocemente e spaventi l'orso!");
            Console.ReadLine();
            youWin();
        }
    }


    public static void gameOver()
    {
        Console.Clear();
        Console.WriteLine("Sei morto.");
        Console.WriteLine("Vuoi riprovare?");
        Console.ReadLine();
        Console.Clear();
        gameTitle();
    }

    public static void youWin()
    {
        Console.Clear();
        Console.WriteLine("Sei soppravissuto!");
        Console.WriteLine("Sei salvo");
        Console.ReadLine();
        Console.Clear();
        gameTitle();
    }
    #endregion
}