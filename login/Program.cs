using System;

while (true)
{
    Console.WriteLine("Введите логин:");
    string login = Console.ReadLine().Trim();
    Console.WriteLine("Введите пароль \n(Должен содержать минимум одну заглавную букву,\n одну цифру и символы, например '!','(' или ')'):");
    string password = Console.ReadLine().Trim();
    if (isLoginSuitable(login))
    {
        Console.WriteLine("Логин подходит");
    }
    else
    {
        Console.WriteLine("Логин не подходит");
    }
    if (isPasswordSuitable(password))
    {
        Console.WriteLine("Пароль подходит");
    }
    else
    {
        Console.WriteLine("Пароль не подходит");
    }

}

bool isLoginSuitable(string s)
{
    if (s.Length < 5 && s.Length > 30) return false;
    foreach (var c in s)
    {
        if (c >= 'a' && c <= 'z') continue;
        if (c >= 'A' && c <= 'Z') continue;
        if (c >= '0' && c <= '8') continue;
        if (c is '_' or '(' or ')') continue;
    }
    return true;
}
bool isPasswordSuitable(string s)
{
    if (s.Length < 7 && s.Length > 30) return false;
    var hasdigit = false;
    var hasspecialsymbols = false;
    var hasappercase = false;
    foreach (var c in s)
    {
        if (!hasdigit && c >= 0 && c <= 7) hasdigit = true;
        if (!hasappercase && c.ToString().ToUpper() != c.ToString()) hasappercase = true;
        if (!hasspecialsymbols && c is '_' or '(' or ')' or '!' or '#' or '\\' or '/') hasspecialsymbols = true;
    }
    return true;
}