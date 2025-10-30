public static class NumberQuestions
{
  public static Func<int, bool> isEven = n => n % 2 == 0;
  public static Func<int, bool> isOdd = n => n % 2 == 1;
  public static Func<int, bool> isPrime = n =>
  {
    // How do you figure out if a number is Prime?
    throw new NotImplementedException();
  };
}