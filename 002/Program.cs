// Написать программу масштабирования фигуры.
//Тут для тех кто далеко улетел, чтобы задавались вершины
// фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
void PrintIn(string message)
{
    Console.WriteLine(message);
}


PrintIn("Введите координаты фигуры");
string input=Console.ReadLine();
PrintIn("Введите коэфициент масштабирования");
int k=int.Parse(Console.ReadLine());
int count=input.Length;
char output=input[0];
for (int i = 0; i < count; i=i+5)
{
       
      //1ый из выживыших вариантов
      //output=output+input[i]+input[i+1]*k+input[i+2]+input[i+3]*k+input[i+4];
     
     //2о1 вариант, на коэффициенте 0,5 сломался
      Console.Write($"({input[i+1]*k},{input[i+3]*k})");

       //3ий из выживших вариантов, не может Char() в double перевести, хотя в этой версии Char переменных вообще нет >_<
       //double r1=Convert.ToDouble(input[i+1]);
       //double r2=Convert.ToDouble(input[i+3]);
       //Console.Write($"({r1*k},{r2*k})");
       

        
}