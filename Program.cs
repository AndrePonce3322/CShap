static void Lambda(
  Func<int, int> multiplicar,
  Func<int, int> dividir,
  Func<int, int> restar,
  Func<int, int> sumar,
  int number)
{
  Console.ForegroundColor = ConsoleColor.White;
  Console.WriteLine($"\n[{number}] results:");

  int m = multiplicar(number);
  int d = dividir(number);
  int r = restar(number);
  int s = sumar(number);

  List<int> _numberList = [m, d, r, s];

  var numbersResult = from n in _numberList
                      orderby n
                      select n;

  foreach (var element in numbersResult)
  {
    Console.WriteLine(element);
  }

  Console.WriteLine("\n");
  Console.ForegroundColor = ConsoleColor.DarkBlue;
}

// Lambda Functions
Func<int, int> multiplicar = (number) => number * number;
Func<int, int> dividir = (number) => number / number;
Func<int, int> sumar = (number) => number + number;
Func<int, int> restar = (number) => number - number;

Lambda(multiplicar, dividir, restar, sumar, 13);
Lambda(multiplicar, dividir, restar, sumar, 20);
Lambda(multiplicar, dividir, restar, sumar, 50);

