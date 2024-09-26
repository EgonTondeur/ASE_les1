// // See https://aka.ms/new-console-template for more information

// Console.WriteLine("Geef getal1: ");
// int getal1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Geef getal2: ");
// int getal2 = int.Parse(Console.ReadLine());

// Console.WriteLine("\nKies een operatie:");
// Console.WriteLine("1 - Optellen");
// Console.WriteLine("2 - Aftrekken");
// Console.WriteLine("3 - Delen");
// Console.WriteLine("4 - Vermenigvuldigen");

// string keuze = Console.ReadLine();

// if (keuze == "1")
// {
//     Console.WriteLine("Resultaat: " + (getal1 + getal2));
// }
// else if (keuze == "2")
// {
//     Console.WriteLine("Resultaat: " + (getal1 - getal2));
// }
// else if (keuze == "3")
// {
//     if (getal2 == 0)
//     {
//         Console.WriteLine("Fout: delen door nul is niet toegestaan.");
//     }
//     else
//     {
//         Console.WriteLine("Resultaat: " + (getal1 / (double)getal2));
//     }
// }
// else if (keuze == "4")
// {
//     Console.WriteLine("Resultaat: " + (getal1 * getal2));
// }
// else
// {
//     Console.WriteLine("Ongeldige keuze");
// }


//Ex1

//Console.WriteLine("Hello, World!");
//String? nameUser = Console.ReadLine();
//Console.WriteLine("Given name: " + nameUser);



//Ex2

// class Program
// {
//     static void Main(string[] args)
//     {
//         WriteLine("Gimme numero uno:");
//         string? number1 = ReadLine();
//         WriteLine("Gimme nummero dos:");
//         string? number2 = ReadLine();

//         if (number1 == null) { return; }
//         if (number2 == null) { return; }

//         int number3 = int.Parse(number1) + int.Parse(number2);
//         WriteLine("Result is:" + number3);

//     }
// }




//Ex3

// class Program
// {
//     static void Main(string[] args)
//     {


//         static void Sum(int a, int b)
//         {
//             WriteLine("Adding both numbers together");
//             int answer = a + b;
//             WriteLine("Result is: " + answer);

//         }

//         static void Subtraction(int a, int b)
//         {
//             WriteLine("Subtracting both numbers from ecah other");
//             int answer = a - b;
//             WriteLine("Result is: " + answer);

//         }

//         static void Multiplication(int a, int b)
//         {
//             WriteLine("Multiplying both numbers with each other");
//             int answer = a * b;
//             WriteLine("Result is: " + answer);

//         }

//         static void Division(float a, int b)
//         {
//             WriteLine("Dividing both numbers with each other");
//             float answer = a / b;
//             WriteLine("Result is: " + answer);

//         }

//         WriteLine("Give your first number");
//         int.TryParse(ReadLine(), out int firstNumber);
//         WriteLine("Give your second number");
//         int.TryParse(ReadLine(), out int secondNumber);

//         WriteLine("What would you like to do with those numbers?");
//         WriteLine("Type 1 to get the sum");
//         WriteLine("Type 2 to get the subtraction");
//         WriteLine("Type 3 to get the multiplation");
//         WriteLine("Type 4 to get the division");

//         int.TryParse(ReadLine(), out int choice);

//         switch (choice)
//         {
//             case 1:
//                 Sum(firstNumber, secondNumber);
//                 break;

//             case 2:
//                 Subtraction(firstNumber, secondNumber);
//                 break;

//             case 3:
//                 Multiplication(firstNumber, secondNumber);
//                 break;

//             case 4:
//                 Division(firstNumber, secondNumber);
//                 break;

//             default:
//                 WriteLine("This choice does not exist...");
//                 break;

//         }


//     }
// }


//Ex4

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<String> list_colors = new List<String>() { "green", "green", "green", "green", "green", "green", "green", "green", "green", "yellow", "pink", "blue", "red", "green", "pink", "yellow", "yellow", "black", "pink", "brown" };

//         static Dictionary<String, int> count_colors(List<String> colorkes)
//         {

//             Dictionary<String, int> Dictje = new Dictionary<string, int>();


//             foreach (String kleurke in colorkes)
//             {
//                 if (!Dictje.Keys.Contains(kleurke))
//                 {

//                     int counter = 0;
//                     foreach (String stringtje in colorkes)
//                     {
//                         if (stringtje == kleurke)
//                         {
//                             counter += 1;
//                         }
//                     }

//                     Dictje.Add(kleurke, counter);

//                 }
//             }

//             return Dictje;

//         }

//         static void printjeDictje(Dictionary<String, int> dictjuh)
//         {


//             foreach (KeyValuePair<string, int> test in dictjuh)
//             {
//                 WriteLine($"Key: {test.Key}, Value: {test.Value}");
//             }
//         }


//         printjeDictje(count_colors(list_colors));


//     }




// }



//Ex5
// class Program
// {
//     static void Main(string[] args)
//     {

//         Dictionary<String, int> locations = new Dictionary<string, int> { { "KWE.P.0.002", 200 }, { "KWE.P.1.103", 20 }, { "KWE.A.1.103", 60 }, { "KWE.A.1.104", 30 }, { "KWE.A.1.302", 64 }, { "KWE.A.1.301", 64 } };

//         static Dictionary<String, int> DetermineCoronaClassrooms(Dictionary<String, int> Dictje, int studs)
//         {
//             Dictionary<String, int> Dictjuh = new Dictionary<string, int>();

//             int safeSize = studs * 2;

//             foreach (KeyValuePair<String, int> lokaal in Dictje)
//             {
//                 if (lokaal.Value >= safeSize)
//                 {
//                     Dictjuh.Add(lokaal.Key, lokaal.Value);
//                     WriteLine($"{lokaal.Key} is safe with {lokaal.Value} places");
//                 }
//                 else
//                 {
//                     WriteLine("Another one bites the dust");
//                 };
//             }

//             return Dictjuh;

//         }

//         static void Result(Dictionary<String, int> locs)
//         {
//             WriteLine("Please input the amount of students");
//             int.TryParse(ReadLine(), out int students);
//             DetermineCoronaClassrooms(locs, students);
//         }

//         Result(locations);
//     }
// }


//Ex6
// class Program
// {
//     static void Main(string[] args)
//     {
//         WriteLine("Give your own treshold");
//         int.TryParse(ReadLine(), out int customTreshold);

//         Dictionary<string, List<int>> dict_aankopen = new Dictionary<String, List<int>>();
//         dict_aankopen.Add("jan", new List<int>() { 100, 50, 20 });
//         dict_aankopen.Add("piet", new List<int>() { 10, 70, 20, 4, 58, 542 });
//         dict_aankopen.Add("karel", new List<int>() { 9 });
//         dict_aankopen.Add("sandra", new List<int>() { 45, 45, 10 });

//         static List<String> GetExpensiveShoppingBaskets(Dictionary<String, List<int>> dictje, int treshold)
//         {
//             List<string> listje = new List<string>();

//             foreach (KeyValuePair<String, List<int>> klant in dictje)
//             {
//                 int ttlcost = 0;
//                 foreach (int kost in klant.Value)
//                 {
//                     ttlcost += kost;

//                 }
//                 if (ttlcost >= treshold)
//                 {
//                     listje.Add(klant.Key);
//                 }
//             }


//             return listje;
//         }

//         static void PrintNames(List<String> naamkes, int treshold)
//         {

//             WriteLine($"The following people have surpassed the treshold of {treshold}euro");

//             foreach (string name in naamkes)
//             {

//                 WriteLine(name);
//             }

//         }

//         PrintNames(GetExpensiveShoppingBaskets(dict_aankopen, customTreshold), customTreshold);

//     }
// }


//Ex7

// class Program {
//     static void Main(string[] args)
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int> { { "Jan", 3 }, { "Paul", 2 }, { "Jef", 5 }, { "Bram", 0 }, { "Pieter", 4 }, { "Koen", 0 } };



//         static void DisplayGrades(string name, int score){

//             switch(score)
//             {
//                 case 5:
//                 WriteLine($"{name} -> Ok");
//                 break;

//                 case 4:
//                 WriteLine($"{name} -> Average");
//                 break;

//                 case 3:
//                 WriteLine($"{name} -> Average");
//                 break;

//                 case 2:
//                 WriteLine($"{name} -> Weak");
//                 break;

//                 case 1:
//                 WriteLine($"{name} -> Insufficient");
//                 break;

//                 case 0:
//                 WriteLine($"{name} -> Insufficient");
//                 break;

//             }

//         }


//         static void Distribute (Dictionary<string, int> Dictjuh){
//             foreach(KeyValuePair<string,int> grade in Dictjuh)
//             {
//                 DisplayGrades(grade.Key, grade.Value);
//             }
//         }




//         Distribute(scores);






//     }
// }


//Ex 8 

// class Program{
//     static void Main(string[] args){


//         Random random = new Random();
//         int randomtje = random.Next(1,10);
//         WriteLine($"Our random number for this game will be {randomtje}");
//         bool didWin = false;
//         int counter = 0;
//         do{
//             WriteLine("Make your guess: ...");
//             int.TryParse(ReadLine(), out int UserGuess);
//             if (UserGuess == randomtje){
//                 didWin = true;
//                 WriteLine($"Congrats, you've won in {counter} tries");
//             } else{
//                 counter += 1;
//                 WriteLine("Nope, wrong guess, try again");
//             }
//         }
//         while(!didWin);




//     }
// }



// Console.WriteLine("price of the construction land: ");
// int construction = int.Parse(Console.ReadLine());

// Console.WriteLine("price of the building: ");
// int building = int.Parse(Console.ReadLine());

// Console.WriteLine("Total Price: " + total_price(construction, building));

// double total_price(int construction, int building) {
//     return (construction + building) * 1.21;
// }



Console.WriteLine("Welcome to the Clothing Store!");

Console.WriteLine("Enter the number of trousers purchased: ");
int trousers = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of T-shirts purchased: ");
int tShirts = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of vests purchased: ");
int vests = int.Parse(Console.ReadLine());


Console.WriteLine("Total Payable Amount: " + total_price(trousers, tShirts, vests));

double total_price(int trousers, int tShirts, int vests) {
    double trouserPrice = 70.5;
    double tShirtPrice = 20.89;
    double vestPrice = 100.3;

    return (trousers * trouserPrice) + (tShirts * tShirtPrice) + (vests * vestPrice);
}
