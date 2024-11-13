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

        CheckVocals(twoVowels);

        if (twoVowels=true) ConvertirAPolsMagic();
        else DividirMaldat();
    }
}