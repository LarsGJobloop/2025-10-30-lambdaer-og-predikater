List<int> numbers = [1, 2, 3, 4, 5];

var evens = numbers.Where(NumberQuestions.isPrime);

foreach (var number in evens)
{
  Console.WriteLine(number);
}