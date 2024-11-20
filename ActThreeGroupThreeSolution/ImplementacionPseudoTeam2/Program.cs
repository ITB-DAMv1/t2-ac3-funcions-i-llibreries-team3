using System;
namespace MyProgram
{
    public class Program
    {
        // const
        const string MsgErrorDades = "Les dades han sigut introduïdes incorrectament";
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
            bool flag = false;
            int polsMagica = 0;
            int numVocales = 0;
            char[] vocalesArray = new char[] { 'A', 'E', 'I', 'O', 'U' };   // antes estaba como constante

            // main
            AvatarSelector(ref userAvatar);
            NameSelector(ref userName, userNameArray);
            MaldatSelector(ref userMaldat);
            GameCore(userNameArray, vocalesArray, numVocales, flag, polsMagica, userMaldat);  // se pasan los parámetros
           
            
        }
        public static void MaldatSelector(ref int userMaldat)
        {
            bool flag = true;
            int userNumber = 0;
            Console.WriteLine(MsgMaldat);
            
            do
            {
                do
                {
                    if (int.TryParse(Console.ReadLine(), out userNumber)) flag = false;
                } while (flag == true);
            } while (CheckRange(MaxMalice, MinMalice, userNumber));
        }

        public static bool CheckRange(int maxRange, int minRange, int userNum)
        {
            return userNum <= maxRange && userNum >= minRange;
        }

        public static void AvatarSelector(ref int userAvatar)
        {
            bool flag = true;
            int userNumber = 0;
            Console.WriteLine(MsgUserAvatar);

            do
            {
                do
                {
                    if (int.TryParse(Console.ReadLine(), out userNumber)) flag = false;
                } while (flag == true);
            } while (CheckRange(MaxAvatar, MinAvatar, userNumber));
        }
        public static void NameSelector(ref string userName, string userNameArray)
        {
            //Les variables estaven declarades al demanar la funció en comptes d'en la pròpia funció.
            Console.WriteLine(MsgUserName);
            do
            {
                userName = Console.ReadLine();
                if (!(userName.Length >= 2 && userName.Length <= 25))
                {
                    Console.WriteLine(MsgErrorDades);
                }
            } while (!(userName.Length >= 2 && userName.Length <= 25));
            //La condició estava invertida
            userNameArray = userName;
            //havien igualat al revès
        }
        public static void GameCore(string userNameArray, char[] vocalesArray, int numVocales, bool flag, int polsMagica, int userMaldat)   // se pasan los parámetros
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

            if (numVocales >= 2)
            {
                flag = true;
            }

            if (flag)
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