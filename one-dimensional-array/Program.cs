//One Dimensional Arrays in C#
Console.WriteLine(" "+"Int Data Types One Dimensional Array");
int[] numbers = new int[5];

numbers[0] = 5;
numbers[1] = 6;
numbers[2] = 7;
numbers[3] = 8;
numbers[4] = 9;

for(int i = 0; i < numbers.Length; i++)

{
    Console.WriteLine(" "+numbers[i]);

}

string[] books = new string[5];
books[0] = "physics";
books[1] = "Biology";
books[2] = "chemistry";
books[3] = "zoology";
books[4] = "C#";

Console.WriteLine(" "+"For Loop Apply in One Dimensional Array::");

for(int j = 1; j < books.Length; j++)
{
    Console.WriteLine(" "+books[j]);

}

Console.WriteLine(" "+"While Loop Apply in One Dimensional Array::");

int k=0;
while (k < books.Length)
{
    Console.WriteLine(" "+books[k]);
    k++; 
}
Console.WriteLine(" "+"Do-While Loop Array:::");

int doWhileLoop = 0;
do
{
    Console.WriteLine(" "+books[doWhileLoop]);
    doWhileLoop++;
}
while (doWhileLoop < books.Length);

Console.WriteLine(" "+"For Each Loop::");


foreach (int i in numbers)
{

    Console.WriteLine(" "+ i);

}