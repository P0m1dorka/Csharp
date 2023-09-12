// See https://aka.ms/new-console-template for more information

using Loginov_CatFramework;

Random rnd = new Random();
Console.WriteLine("Hello, World!");
DisplayCAtInfo(GenerateRandomCats(10000));

void DisplayCAtInfo(Cat[] catsArr)
{
    for (int i = 0; i < catsArr.Length; i++)
    {
        catsArr[i].ToString();
        catsArr[i].FluffinessCheck();
        Console.WriteLine($"next {i+1}");
    }
}

 Cat[] GenerateRandomCats(uint count)
 {
  Cat[] massiv = new Cat[count];
  int catortiger;
  int fluffiness;
  double weight;
  for (int i = 0; i < massiv.Length; i++)
  {
      
      catortiger = rnd.Next(0, 2);
      if (catortiger == 1) //для тигров
      {
          link1:
          try
          {
              fluffiness = rnd.Next(-21,121);
              weight = Convert.ToDouble(rnd.Next(49,161));
              massiv[i] = new Tiger(fluffiness, weight);
          }
          catch
          {
              goto link1;
          }
      }
      else
      {
          link2:
          try
          {
              fluffiness = rnd.Next(-21,121);
              massiv[i] = new CuteCat(fluffiness);
          }
          catch
          {
              goto link2;
          }
          
      }
  }
  return massiv;
 }