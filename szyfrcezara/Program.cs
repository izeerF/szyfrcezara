string alfabet = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUWYZŹŻ";
Console.WriteLine("Podaj wzór kodu do szyfrowania:");

int szyfr;
Int32.TryParse(Console.ReadLine(), out szyfr);



Console.WriteLine("Podaj Tekst do zaszyfrowania");
string tekst = Console.ReadLine().Replace(" ", "");
tekst = tekst.ToUpper();
string wyjscie = "";
for (int i = 0; i < tekst.Length; i++)
{
    alfabet = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUWYZŹŻ";
    var poszyfr = (alfabet.IndexOf(tekst[i])+szyfr)%alfabet.Length;
    wyjscie += alfabet[poszyfr].ToString();
}
Console.WriteLine(wyjscie);