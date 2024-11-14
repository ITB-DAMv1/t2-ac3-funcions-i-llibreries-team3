//namespace t2_ac3_funcions_i_llibreries_team3;
using System;

class ActThreeGroupThreeCsMain
{
    static void Main(string[] args)
    {
        const int MinCharNum = 1;
        const int MaxCharNum = 4;
        const int MinCharUser = 2;
        const int MaxCharUser = 25;
        const int MaxEvil = 1000;
        const int MinEvil = 50000;
        const string InsertCharacterNumTxt = "Insereix el numero de selecció: [1-4]";
        const string InsertCharacterUsernameTxt = "Insereix el nom del personatje: llargada[2-25]";
        const string InsertEvilTxt = "Insereix el nivell de maldat: [1000-50000]";

        string userName = "";
        int characterNum = 0;
        int malice = 0;
        int avatarMalice = 0;
        int personDust = 0;
        int personMalice = 0;

        int vowels = 0;
        bool characterSpecial = false;
        bool twoVowels = false;

        Console.WriteLine(InsertCharacterNumTxt);

        while (!(characterNum >= MaxCharNum && characterNum <= MinCharNum))
        {
            characterNum = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(InsertCharacterUsernameTxt);

        while (!(userName.Length <= MinCharUser && userName.Length >= MaxCharUser))
        {
            userName = Console.ReadLine();

            if (CharacterSpecial(userName)) userName = "";
        }

        Console.WriteLine(InsertEvilTxt);

        while (!(malice >= MinEvil && malice <= MaxEvil))
        {
            malice = int.Parse(Console.ReadLine());
        }

        CheckVowels(ref twoVowels);

        if (twoVowels == true) ConvertirAPolsMagic();
        else DividirMaldat();
    }

    static public bool CharacterSpecial(string userName)
    {
        userName = userName.ToLower();
        for (int i = 0; i < userName.Length; i++)
        {
            if (!(userName[i] == 'a' ||
                userName[i] == 'b' ||
                userName[i] == 'c' ||
                userName[i] == 'd' ||
                userName[i] == 'e' ||
                userName[i] == 'f' ||
                userName[i] == 'g' ||
                userName[i] == 'h' ||
                userName[i] == 'i' ||
                userName[i] == 'j' ||
                userName[i] == 'k' ||
                userName[i] == 'l' ||
                userName[i] == 'm' ||
                userName[i] == 'n' ||
                userName[i] == 'o' ||
                userName[i] == 'p' ||
                userName[i] == 'q' ||
                userName[i] == 'r' ||
                userName[i] == 's' ||
                userName[i] == 't' ||
                userName[i] == 'u' ||
                userName[i] == 'v' ||
                userName[i] == 'w' ||
                userName[i] == 'x' ||
                userName[i] == 'y' ||
                userName[i] == 'z' ||
                userName[i] == '0' ||
                userName[i] == '1' ||
                userName[i] == '2' ||
                userName[i] == '3' ||
                userName[i] == '4' ||
                userName[i] == '5' ||
                userName[i] == '6' ||
                userName[i] == '7' ||
                userName[i] == '8' ||
                userName[i] == '9'))
            {
                return true;
            }
        }
        return false;
    }
    public static void CheckVowels(bool twoVowels, ref string userName, ref int vowels)
    {
        foreach (char c in userName.ToLower())
        {
            if (c == 'a')
                vowels = vowels + 1;
            else if (c == 'e')
                vowels = vowels + 1;
            else if (c == 'i')
                vowels = vowels + 1;
            else if (c == 'o')
                vowels = vowels + 1;
            else if (c == 'u')
                vowels = vowels + 1;
        }
        if (vowels >= 2) twoVowels = true;
    }
}