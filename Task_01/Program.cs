Console.Write("Введите трехзначное число : ");
string UserNamber1 = Console.ReadLine() ?? "";
int namber_a = int.Parse(UserNamber1);

int a1 = namber_a / 10;
int a2 = a1 % 10;

Console.WriteLine(a2);