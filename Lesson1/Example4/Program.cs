int a = 10;
int b = a++; //b=a=10 => a++=10+1=11
int c = ++a; //++a=11+1=12 => c=a=12

Console.WriteLine("a = " + a); //12
Console.WriteLine("b = " + b); //10
Console.WriteLine("c = " + c); //12

