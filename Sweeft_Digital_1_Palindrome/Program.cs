static string sPalindrome(string PalindromeInputString ) {
string _reversestr = string.Empty;


if (PalindromeInputString != null)
{
    for (int i = PalindromeInputString.Length - 1; i >= 0; i--)
    {
        _reversestr += PalindromeInputString[i].ToString();
    }
    if (_reversestr == PalindromeInputString)
    {
        Console.WriteLine("String is Palindrome");
    }
    else
    {
        Console.WriteLine("String is not Palindrome");
    }
}

    return _reversestr;
}



Console.Write("Enter a string : ");
string Palindrome = Console.ReadLine();
sPalindrome(Palindrome);