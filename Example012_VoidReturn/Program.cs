// vid 1 nichego ne prinimaiut nichego ne vozvrawaiut

void Method1()
{
    Console.WriteLine("author Alisher");
}
// kak vyzvot method 
Method1();
// Method1; esli bez skobki vyzvat vydaet owibku 


// vid 2 nichego ne vozvrawaet no prinimaet kakie to orgumenty 

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Text soobweniya");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method2_1("text soobwenia",4);
Method2_1(count: 4, msg: "Text soobweniya"); // mojno imenen ukazat menya mesta 


//vid 3 chto to vozvrawaet no nichego ne prinimaet 
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// vid 4 chto to prinimaet chto to vozvrawaet 

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;

//     }
//     return result;

// }
// s ciklom for
string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "sms");
Console.WriteLine(res);

// cikl v cikle 

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}");
    }
    Console.WriteLine();
}