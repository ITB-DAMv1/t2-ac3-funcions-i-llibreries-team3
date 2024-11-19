using System;
namespace MyProgram
{
    public class Program
    {
        public static void Main()
        {
            // const 
            const string MsgErrorDades = "Les dades han sigut introduïdes incorrectament";
            const string MsgUserAvatar = "Tria el avatar!Has d'introduir un nombre entre 1 i 4.";
            const string MsgUserName = "Tria un nom, sense números, que com a mínim tingui 2 lletres i com màxim 25.";
            const string MsgMaldat = "Tria el teu nivell de maldat!Has d'introduir un nombre entre 1000 i 50000.";
            const string MaldatInvalid = "El nivel de maldat no està entre 1000 i 50000";

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
            AvatarSelector(ref userAvatar, MsgUserAvatar);
            NameSelector(MsgUserName, ref userName, MsgErrorDades, userNameArray);
            MaldatSelector(ref userMaldat, MsgMaldat, MaldatInvalid);
            GameCore(userNameArray, vocalesArray, numVocales, flag, polsMagica, userMaldat);  // se pasan los parámetros
           
            
        }
        public static void MaldatSelector(ref int userMaldat, string MsgMaldat, string MaldatInvalid)
        {
            Console.WriteLine(MsgMaldat);
            userMaldat = int.Parse(Console.ReadLine());


            while (!((userMaldat < 50000) && (userMaldat > 1000)))
            {
                Console.WriteLine(MaldatInvalid);
                userMaldat = int.Parse(Console.ReadLine());
            }
        }
        public static void AvatarSelector(ref int userAvatar, string MsgUserAvatar)
        {
            Console.WriteLine(MsgUserAvatar);

            //añadidos parentesis externos para que funcione while !(userAvatar >= 1 && userAvatar <= 4)
            while (!(userAvatar >= 1 && userAvatar <= 4))
            {
                userAvatar = int.Parse(Console.ReadLine());
            }
        }
        public static void NameSelector(string MsgUserName, ref string userName, string MsgErrorDades, string userNameArray)
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