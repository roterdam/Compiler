﻿int main()
{
	if(4 == 4.0) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43 == 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4 != 4.0) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43 != 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4 > 4.0) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43 > 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(3 > 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4 >= 4.0) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43 >= 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(3 >= 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4 <= 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43 <= 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(3 <= 4.43) { PrintBool(true); } else { PrintBool(false); } PrintLine("");

	if(4.0 == 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43.43 == 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4.0 != 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43.43 != 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4.0 > 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43.43 > 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(3.43 > 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4.43 >= 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43.43 >= 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(3.43 >= 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
            
	if(4.0 <= 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(43.43 <= 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");
	if(3.43 <= 4) { PrintBool(true); } else { PrintBool(false); } PrintLine("");

    return 0;
}

void PrintBool(bool val)
{
    if (val)
    {
        PrintInt(1);
    }
    else
    {
        PrintInt(0);
    }
}