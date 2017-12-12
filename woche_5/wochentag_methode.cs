Lagern Sie folgende lange Methode in mehrere kleinere Methoden aus. 



static void Wochentag()
{
	int t, m, j , MerkeMonat;
	Console.WriteLine("Geben Sie den Tag ein");
	t = int.Parse(Console.ReadLine());
	Console.WriteLine("Geben Sie den Monat ein");
	m = int.Parse(Console.ReadLine());
	MerkeMonat = m;
	Console.WriteLine("Geben Sie das Jahr  ein");
	j = int.Parse(Console.ReadLine());
	if(m <= 2)
	{
		m += 10;
		j -= 1;
	}
	else
	{
		m -= 2;
	}
	int c = j/100;
	int y = j%100;
	int h = (((26 * m -2)/10) + t + y + y/4 +c/4 -2 * c)%7;
	if(h<0)
		h +=7;
	string Tag = "";
	switch(h)
	{
		case 0:
			Tag = "Sonntag";
			break;
			
		case 1:
			Tag = "Montag";
			break;
                   
		case 2:
			Tag = "Dienstag";
			break;
		case 3:
			Tag = "Mittwoch";
			break;
		case 4:
			Tag = "Donnerstag";
			break;
		case 5:
			Tag = "Freitag";
			break;
		case 6:
			Tag = "Samstag";
			break;
	}
	Console.WriteLine("Der " + t +"." + MerkeMonat + "." + j + " ist ein " + Tag);
}


