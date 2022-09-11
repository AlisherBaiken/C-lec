// dan text. V texte nujno vse probely zamenit na chertochki, malenkie bukvy "k" zamenit na bolwuiu "K", a bolwye bukvy "C" na "c"
// Yasna li zadacha

string text = "- Я думаю, - сказал князь, улыьаясь, - что, ежели бы вас послали вас вместо нашего милого Винценгероде, вы бы взяли приступом согласие русского короля ";
// string tex = "qwer"
//               0123
// tex [3] // r
string Replace(string text, char OldValue, char NewValue)
{
    string result = string.Empty;
    int leght = text.Length;
    for (int i = 0; i < leght; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine();

Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);