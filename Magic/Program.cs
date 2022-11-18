Console.Clear.();
Console.Set.CursorPosition(10, 4);
Console.WriteLine("+");
int xa = 40, ya = 1, 
xb = 1, yb = 30, 
xc = 80; yc = 30;
Console.Set.CursorPosition(xa, ya);
Console.WriteLine("+");
Console.Set.CursorPosition(xb, yb);
Console.WriteLine("+");
Console.Set.CursorPosition(xс, yс);
Console.WriteLine("+");
int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
int what = new Random().Next(0, 3);
if (what == 0)
{
x = (x + xa) / 2;
y = (y + ya) / 2;
}
if (what == 1)
{
x = (x + xb) / 2;
y = (y + yb) / 2;
}
if (what == 2)
{
x = (x + xс) / 2;
y = (y + yс) / 2;
}
Console.Set.CursorPosition(x, y);
Console.WriteLine("+");
count++;
}