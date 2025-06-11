const int minNumber = 1;

const int maxNumber = 7;

bool continueProgram = true;



while (continueProgram)
{

    Console.WriteLine($"\nHello, please enter a number between {minNumber} and {maxNumber}:");

    var key = Console.ReadKey(intercept: true);

    switch (key.KeyChar.ToString())

    {
        case "1":

            Console.WriteLine("\nThe first day in the week is Monday.");
            break;


        case "2":

            Console.WriteLine("\nThe second day in the week is Tuesday.");
            break;

        case "3":

            Console.WriteLine("\nThe third day in the week is Wednesday.");
            break;

        case "4":

            Console.WriteLine("\nThe fourth day in the week is Thursday.");
            break;

        case "5":

            Console.WriteLine("\nThe fifth day in the week is Friday.");
            break;

        case "6":

            Console.WriteLine("\nThe sixth day in the week is Saturday.");
            break;

        case "7":
            Console.WriteLine("\nThe seventh day in the week is Sunday.");
            break;

        default:
            Console.WriteLine($"\nINVALID INPUT!! Please enter a number between {minNumber} and {maxNumber}:");

            // запитуємо користувача, чи хоче він продовжити
            { Console.WriteLine("\nDo you want to continue? (Y/N):"); }

            var answer = Console.ReadKey(intercept: true);

            // перевіряємо, чи користувач хоче продовжити
            if (answer.KeyChar != 'Y' && answer.KeyChar != 'y' && answer.KeyChar != 'н' && answer.KeyChar != 'Н')


            {
                continueProgram = false;

                Console.WriteLine("\nThank you for using the program. Goodbye!");
            }
            else
            {
                continueProgram = true;
            }

            break;

    }

}
