string CreateRandomString(int MinStrLen, int MaxStrLen)
{
    Random random = new Random();
    string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    int SymbolsLen = random.Next(MinStrLen, MaxStrLen);
    char[] strSymbols = new char[SymbolsLen];

    for (int i = 0; i < strSymbols.Length; i++)
    {
        strSymbols[i] = symbols[random.Next(symbols.Length)];
    }
    return new String(strSymbols);
}
string str = CreateRandomString(2,5);
System.Console.WriteLine(str);
