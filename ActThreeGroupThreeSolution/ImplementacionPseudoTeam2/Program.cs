using System;
namespace MyProgram
{
    public class Program
    {
        // const
        const string MsgErrorDades = "Les dades han sigut introduïdes incorrectament";
        const string MsgErrorDadesEsp = "Les dades contenten simbols no permesos";
        const string MsgUserAvatar = "Tria el avatar!Has d'introduir un nombre entre 1 i 4.";
        const string MsgUserName = "Tria un nom, sense números, que com a mínim tingui 2 lletres i com màxim 25.";
        const string MsgMaldat = "Tria el teu nivell de maldat!Has d'introduir un nombre entre 1000 i 50000.";
        const string MaldatInvalid = "El nivel de maldat no està entre 1000 i 50000";
        const int MaxMalice = 50000;
        const int MinMalice = 1000;
        const int MaxAvatar = 4;
        const int MinAvatar = 1;
        public static void Main()
        {
            // var
            string userName = "";
            string userNameArray = "";   // antes era string[]
            int userAvatar = 0;
            int userMaldat = 0;
            int polsMagica = 0;
            int numVocales = 0;
            char[] vocalesArray = new char[] { 'A', 'E', 'I', 'O', 'U' };   // antes estaba como constante

            // main
            AvatarSelector(ref userAvatar);
            userName = InputName();
            MaldatSelector(ref userMaldat);
            GameCore(userNameArray, vocalesArray,ref numVocales,ref polsMagica, userMaldat);  // se pasan los parámetros
        }

        public static void AvatarSelector(ref int userAvatar)
        {
            int userNumber = 0;
            Console.WriteLine(MsgUserAvatar);

            while (int.TryParse(Console.ReadLine(), out userNumber) && ValidNumber(MaxAvatar, MinAvatar, userNumber)) ;
        }

        public static string InputName()
        {
            string userName = "";
            //Les variables estaven declarades al demanar la funció en comptes d'en la pròpia funció.
            Console.WriteLine(MsgUserName);
            do
            {
                userName = Console.ReadLine();
                if (!(CheckUserNameLenght(userName)))
                {
                    //throw exception en comptes de writeline amb l'error
                    throw new ArgumentOutOfRangeException(MsgErrorDades);
                }

                else if (CheckSpecialChar(userName))
                {
                    throw new FormatException(MsgErrorDadesEsp);
                }
            }
            //La condició estava invertida i no comprovava caràcters especials
            while (!(CheckUserNameLenght(userName) && CheckSpecialChar(userName)));

            return userName;

        }

        static public bool CheckSpecialChar(string userName)
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
                    userName[i] == '9')) ;
            }
            return false;
        }

        private static bool CheckUserNameLenght(string userName)
        {
            return userName.Length >= 2 && userName.Length <= 25;
        }

        public static void MaldatSelector(ref int userMaldat)
        {
            int userNumber = 0;
            Console.WriteLine(MsgMaldat);

            while (int.TryParse(Console.ReadLine(), out userNumber) && ValidNumber(MaxAvatar, MinAvatar, userNumber)) ;
        }

        public static bool ValidNumber(int maxRange, int minRange, int userNum)
        {
            return userNum <= maxRange && userNum >= minRange;
        }

        public static void GameCore(string userNameArray, char[] vocalesArray, ref int numVocales, ref int polsMagica, int userMaldat)   // se pasan los parámetros
        {
            CountVowels(userNameArray, vocalesArray, ref numVocales);
            DistributeDust(ref polsMagica, numVocales, userMaldat);
        }
        
        public static void CountVowels(string userNameArray, char[] vocalesArray, ref int numVocales)
        {
            for (int i = 0; i < userNameArray.Length; i++)
            {
                for (int j = 0; j < vocalesArray.Length; j++) // he cambiado int n por int j
                {
                    if (userNameArray[i] == vocalesArray[j])
                    {
                        numVocales = numVocales + 1;
                    }
                }
            }
        }
        public static void DistributeDust(ref int polsMagica, int numVocales, int userMaldat)
        {
            if (numVocales >= 2)
            {
                polsMagica = userMaldat / 4;
            }
            else
            {
                polsMagica = ((userMaldat * 5) / 100) / 4;
            }
        }
    }
}