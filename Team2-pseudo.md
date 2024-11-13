# Pseudocodi

```
Program
	const
		integer minCharNum =  1;
		integer maxCharNum = 4;
		integer minCharUser = 2;
		integer maxCharUser = 25;
	 	integer maxEvil = 1000;
		integer minEvil = 50000;
		string INSERTCHARACTERNUM = “Insereix el numero de selecció: [1-4]”;
		string INSERTUSERNAME = “Insereix el nom del personatje: llargada[2-25]”;
		string INSERTEVIL =  “Insereix el nivell de maldat: [1000-50000]”;
	endConst
	var		
		integer characterNum = 0;
		integer maldat = 0;
		string nomUser = “”;
		integer maldatAvatar = 0;   
		integer polsPersona = 0;
		integer maldatPersona = 0;
		integer vocals=0;
		bool characterSpecial = false;
		bool dosVocals = false;
	endVar

	write(INSERTCHARACTERNUM);

	while (!(characterNum >= maxCharNum && characterNum <= minCharNum))
		characterNum = int Read();	
	endwhile

	write(INSERTUSERNAME);

	while ( !(nomUser.Length <= minCharUser && nomUser.Length >= maxCharUser) )
		nomUser = Read();
	
		if (characterSpecial(nomUser)) 
			nomUser = “”;
		endif
	endwhile
	
	write(INSERTEVIL);

	while ( !(maldat >= minEvil && maldat <= maxEvil) )
		maldat = int Read();
	endwhile

	CheckVocals(dosVocals);

	if (dosVocals=true)
		ConvertirAPolsMagic();
	endIf
	if (dosVocals=false)
		DividirMaldat();
	endif

	function DividirMaldat (integer maldatPersona by value, integer)
			maldatAvatar = maldat / 10 * 8;
			maldatPersona = maldat / 20;
	endFunction

	function characterSpecial(nomUser)
		Regex;  // [^\w\s.!@$%^&*()\-\/] //
	endFunction

	function ConvertirAPolsMagic (integer polsPersona by reference, integer maldatAvatar by reference)
			maldatAvatar = maldat % 4;
			polsPersona = maldat / 4;
	endFunction

	function CheckVocals (bool dosVocals by reference)	
		foreach (char c in nombre.ToLower())            
					if (c == 'a' )                
						vocals = vocals + 1;                
			endif
					if (c == 'e' )
						vocals = vocals + 1;
			endif
					if (c == 'i' )
						vocals = vocals + 1;
			endif
					if (c == 'o' )
						vocals = vocals + 1;
			endif
					if (c == 'u' )
						vocals = vocals + 1;
			endif           
		dosVocals = vocal >= 2;
	endFunction
endProgram
```