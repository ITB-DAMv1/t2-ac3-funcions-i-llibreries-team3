```
program
    const
        string PickAvatarTxt = “Escull un avatar entre [1-4]”;
        string InvalidAvatarTxt = “Opció incorrecta, intenta-ho un altre cop”;
        
        string ChooseNameTxt = “Escriu un nom per a l'avatar (2-25 caràcters, sense
        caràcters especials):”;
        string InvalidNameTxt = “El nom no és vàlid”;
        
        string ChooseMaliceTxt = “Introdueix el nivell de maldat (1000 a 50000):”;
        string InvalidMalice = “Opció incorrecta, intenta-ho un altre cop”;
        
        string TotalMaliceTxt = "El total de malicia es: ";
        string ModuleMaliceTxt = " i el restant es: ";
        
        string Vowels = "aeiou";
    endconst
    
    var
        string name = "";
        int userMalice = 0;
    endvar
    
    ChooseAvatar();
    ChooseNameAvatar(name);
    ChooseMalice(userMalice);
    DistributeMalice(userMalice, name);
endprogram

function ChooseAvatar():
    var
        bool validAvatar = false;
        integer userAvatar = 0;
    endvar
    
    while (!validAvatar):
        write (PickAvatarTxt);
        userAvatar = read();
        if (userAvatar >= 1)&& (userAvatar <= 4):
            validAvatar = true;
    
        else
            write (InvalidAvatarTxt);
        endif
	endwhile
endfunction




function ChooseNameAvatar(string userName by reference):
    var
        bool validName = false;
        string userName = 0;
    endvar
    
    while (!validName):
        write (ChooseNameTxt);
        userName = read();
        if (userName.Lenght >= 2 && userName.Lenght <= 25)
            validName = true;
            
        else
            write (InvalidNameTxt);
        endif
    endwhile
endfunction




function ChooseMalice(int userMalice by reference):    
    
    
    var
        bool validMalice = false;
        integer userMalice = 0;
    endvar
    
    while (!validMalice):
        write (ChooseMaliceTxt);
        userMalice = read();
        if (userMalice >= 1000) && (userMalice <= 50000):
            validMalice = true;
        else
            write (InvalidMalice);
        endif
    endwhile
endfunction

function DistributeMalice(userMalice by value, name by value)
    var
         bool vowelsValid = false;
         int maliceModule = 0;
         int reducedMalice = userMalice * 0.05;
    endvar
    
    Checkvowels(vowelsValid, name);
    
    if(vowelsValid)
        maliceModule= userMalice % 4;
        userMalice = userMalice / 4;
        
        write (TotalMaliceTxt + userMalice + ModuleMaliceTxt + maliceModule);
    else
        maliceModule= reducedMalice % 4;
        reducedMalice = reducedMalice / 4;
        userMalice = userMalice * 0.95;
        maliceModule = userMalice + maliceModule;
        
        write(TotalMaliceTxt + reducedMalice + ModuleMaliceTxt + maliceModule);        
    endif
endfunction

function Checkvowels(vowelsValid by reference, name by value)
    var
        int count = 0;
    endvar
    
    for int i = 0 to name.Lenght
        i = i+1;
        
        if(ToLower(name[i]) == Vowels[0] || 
        ToLower(name[i]) == Vowels[1] || 
        ToLower(name[i]) == Vowels[2] || 
        ToLower(name[i]) == Vowels[3] ||  
        ToLower(name[i]) == Vowels[4])
            count++;
        endif
    endfor
	
	if(count >= 2)
		vowelsValid = true;
	endif
endfunction
```
