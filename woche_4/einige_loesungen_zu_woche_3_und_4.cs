using System;

namespace Struktogramm
{
	/// <summary>
	/// Zusammenfassung f�r Class1.
	/// </summary>
	class Class1
	{

		  const int EINS = 1;
		/// <summary>
		/// Der Haupteinstiegspunkt f�r die Anwendung.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//einseitig();
			//zweiseitig();
			//mehrfach1();
			//mehrfach2();
			//wiederhol1();
			//wiederhol2();
			//forSchleife();
			//badSchleife();

			//Ostern();
			//Wochentag();
			//Fahrrad();

			//SwitchTest(1);
			//SwitchTest(2);
			//SwitchTest(EINS);

			//dreiMalSchleife();
			//binaer();
			neuWochentag();

		}

		 

		static void einseitig()
		{
			//Lesen Sie zwei Zahlen ein und bestimmen Sie, ob die erste Zahl gr��er als die zweite Zahl ist 

			int ersteZahl, zweiteZahl;

			Console.WriteLine("Geben Sie die erste Zahl ein");
			ersteZahl = int.Parse(Console.ReadLine());

			Console.WriteLine("Geben Sie die zweite Zahl ein");
			zweiteZahl = int.Parse(Console.ReadLine());

			if(ersteZahl > zweiteZahl)
			{
				Console.WriteLine("Erste Zahl ist gr��er");

			}


		}
		

		static void zweiseitig()
		{
			
			// Ein Programm soll pr�fen, ob der Jahresumsatz eines Verk�ufers �ber 50000 � liegt. 
			// Wird der Umsatz �berstiegen, erh�lt der Verk�ufer eine Provision in H�he von 2500 �, 
			// ansonsten nur in H�he von 1000 �. 
			
			int Jahresumsatz = 0;
			int Provision;
			 Console.WriteLine("Gegen Sie den Jahresumsatz ein");
			Jahresumsatz = int.Parse(Console.ReadLine());

			if(Jahresumsatz > 50000)
			{
				Provision = 2500;
			}
			else
			{
				Provision = 1000;
			}

			Console.WriteLine("Provision:" + Provision);
			
			
			
		}

		static void mehrfach1()
		{
			
			// Au�endienstarbeiter besuchen Filialen in Hamburg, N�rnberg, Stuttgart 
			// und rechnen f�r diese Besuche Spesen ab. Ihr Programm soll errechnen, 
			// wie viel Spesen der Mitarbeiter erh�lt. 
			// Erfragen Sie dazu die Anzahl der Tage und den jeweiligen Ort. 
			//Pro Tag in Hamburg erh�lt er  100 �, in Stuttgart 50 � und in N�rnberg 30 �. 
			//Die Eingabe eines anderen Ortes soll eine Fehlermeldung ausgegeben . 


			Console.WriteLine("Geben Sie den Ort an");
			string ort = Console.ReadLine();

			Console.WriteLine("Geben Sie die Tage an");
			int tage = int.Parse(Console.ReadLine());

			int Spesen = 0;

			switch(ort)       
			{         
				case "Hamburg":   
					Spesen = tage * 100;
					break;  
                
				case "Stuttgart":            
					Spesen = tage * 50;
					 break;  
     
				case "N�rnberg":            
					Spesen = tage * 30;
					break;

				default:            
					Console.WriteLine("Falscher Ort, Hamburg, Stuttgart oder N�rnberg ");            
					break;      
			}

			Console.WriteLine(Spesen);


		}

		static void mehrfach2()
		{
			// Ein Programm soll folgende Abstufung vornehmen �	
			// Bei einem Umsatz von mehr als 10000 � erh�lt er  500 ��	
			// Bei einem Umsatz von mehr als 20000 � erh�lt er 1000 � �
			// Bei einem Umsatz von mehr als 30000 � erh�lt er  1500 ��	
			// Bei einem Umsatz von mehr als 40000 � erh�lt er  2000 � �	
			// Bei einem Umsatz von mehr als 50000 � erh�lt er 2500 �  


			// Hinweis: 
			// switch - case geht nur mit constants, d.h. man kann im case - Teil nicht auf < > pr�fen
			// wie es in vb m�glich w�re


			int Provision = 0;
			Console.WriteLine("Geben Sie den Umsatz an");
			int Umsatz = int.Parse(Console.ReadLine());

			if(Umsatz > 10000 & Umsatz < 20000)
			{
				Provision = 500;
			}
			else if (Umsatz >= 20000 & Umsatz < 30000)
			{
				Provision = 1000;

			}
			else if(Umsatz >= 30000 & Umsatz < 40000)
			{
				Provision = 1500;

			}
			else if(Umsatz >= 40000 & Umsatz < 50000)
			{
				Provision = 2000;
			}
			else if(Umsatz >= 50000)
			{
				Provision = 2500;
			}
			else
			{
				Console.WriteLine("Ung�ltige Eingabe");
			}

			Console.WriteLine("Provison = " + Provision);

			//oder mit Hirn

			Provision = (Umsatz / 10000) * 500;
			Console.WriteLine("Provison = " + Provision);

			
		}

		static void wiederhol1()
		{
			// Ein Arbeiter soll folgenderma�en bezahlt werden 
			// Sein Tageslohn verdoppelt sich an jedem Tag. 
			// Am ersten Tag erh�lt er 1 �, am 2. Tag 2 � usw. 
			// Wie viele Tage muss der Arbeiter arbeiten, bis er 40000 � verdient hat 

			// als kopfgesteuerte Schleife

			int Tag = 1;
			int Tageslohn = 1, Gesamtlohn = 1;

			while (Gesamtlohn < 40000) 
			{	Tag += 1;									// oder Tag = Tag + 1;
				Tageslohn *= 2;						    // oder Tageslohn = Tageslohn * 2;
				Gesamtlohn += Tageslohn;		// oder Gesamtlohn = Tageslohn + Gesamtlohn
			}

			Console.WriteLine("Am " + Tag + "Tag hat er " + Gesamtlohn + "verdient" );



		}


		static void wiederhol2()
		{
			// Der Chef m�chte wissen, was eine Aushilfskraft in 30 Tagen verdienen w�rde, 
			// wenn Sie am ersten Tag 40 � Lohn bek�me, am 2. Tag 5 � mehr als am ersten, 
			// am 3. Tag 5 � mehr als am 2. Tag, usw.
			
			//Mit der do-Anweisung wird eine Anweisung oder ein Anweisungsblock wiederholt ausgef�hrt, 
			// bis ein bestimmter Ausdruck zu false ausgewertet wird. 



			int Tag = 1;

			int Tageslohn = 40;
			int Gesamtlohn = Tageslohn;

			//erster Durchlauf ist bereits der 2. Tag
			do
			{
				Tag += 1;
				Tageslohn = Tageslohn + 5;
				Gesamtlohn += Tageslohn;
				
				
			}	while(Tag < 30); // solange bis Tag kleiner 30 ist

			Console.WriteLine("Am " + Tag + ". Tag hat er  " + Gesamtlohn + "  verdient" );
		}


		static void forSchleife()
		{
			
			/*
			CONST Anzahl_der_Muenzen = 100;
VAR DM5, DM2, DM01 : Word;
    Summe          : Real;
BEGIN
  ClrScr;
  WriteLn('Welche Geldst�cke ben�tige ich f�r 100 DM mit genau 100 M�nzen ?');
  WriteLn;
  FOR DM01 := 1 TO 100 DO
    FOR DM2 := 1 TO 50 DO
      FOR DM5 := 1 TO 20 DO
      BEGIN
        Summe := DM5*5+DM2*2+DM01*0.1;
        IF Summe > 99.9 THEN
          IF Summe < 100.1 THEN
            IF Anzahl_der_Muenzen = DM5+DM2+DM01 THEN
               BEGIN
                 WriteLn(' ..nun hier die L�sung Ihres Problems : ');
                 WriteLn(DM5, ' St�ck a 5.- DM M�nzen ');
                 WriteLn(DM2, ' St�ck a 2.- DM M�nzen ');
                 WriteLn(DM01,' St�ck a 10 Pfennig-M�nzen ');
               END;
       END;
  REPEAT UNTIL KeyPressed;
END.
*/


	const int Anzahl_Muenze = 50;
	int Euro2, Euro1, Cent50;
	double Summe=0;

			//Brute-Force-Ansatz
			// Es werden alle sinnvollen Kombinationen der m�nzen durchgerechnet
			Console.WriteLine("F�r 50 Euro in 50 M�nzen brauche ich: ");
			
			for(Cent50=1; Cent50 <= 100;Cent50++)
			{
				for (Euro1 = 1; Euro1 <=50; Euro1++)
				{
					for(Euro2 = 1; Euro2  <= 25; Euro2 ++)
					{
						Summe = Euro2 * 2 + Euro1 * 1 + Cent50*0.5;
						if(Summe> 49.9)
						{
							if(Summe < 50.1)
							{
								if((Euro2 + Euro1 + Cent50) == Anzahl_Muenze )
								{
									Console.WriteLine("Die L�sung des problems");
									Console.WriteLine(Euro2 + " St�ck 2 Euro-m�nzen");
									Console.WriteLine(Euro1 + " St�ck 1 Euro-m�nzen");
									Console.WriteLine(Cent50 + " St�ck 50 Cent-m�nzen");
								}
							}
						}		
					}
				}
			}

		}

		static void badSchleife()
		{
				int i, j;
				for (i=1; i<=10; i++) 
				{ // Schleife A
					Console.WriteLine("A1: i = " + i);
					 i = 5;
					Console.WriteLine("A2: i = " + i);
					for (i = 7; i<=20; i++) 
					{ // Schleife B
						Console.WriteLine("B1: i " + i);
						 i = i + 2;
						Console.WriteLine("B2: i " + i);
					}
				 }

			Console.ReadLine();
		}

		static void SwitchTest(int zahl)
		{
			
		
			switch (zahl)
			{
				case EINS:
				{
					Console.WriteLine("Testergebnis: "+ EINS);
					break;
				}
				case 2:
				{
					Console.WriteLine ("Testergebnis: "+ 2);
					break;
				}
			}
		

		}

		static void dreiMalSchleife()
		{

			Console.WriteLine("Gib mir eine Zahl");
			int n = int.Parse(Console.ReadLine());



			// Die gleiche Ausgabe kann nur durch einen Trick bei der for-Schleife erreicht werden 
			// bzw. die Austrittsbedingungen m�ssen beachtet werden

			// i wird �ber den Schleifenrumpf erh�ht und muss deshalb nicht explizit
			// innerhalb der Schleife um 1 erh�ht werden

			Console.WriteLine("for-Schleife");
			int i = 4;
			for(; i<=2*n; i++)
			{
				//um ein korrektes Ergebnis zu erhalten musste hinter die 1 ein D(ouble) geschreiben werden
				

				Console.WriteLine(1/(2*i+1D));
			}

			//////////////////////////////////
			

				Console.WriteLine("do-while-Schleife");
			int k = 3;
			do
			{
				k = k +1;
				Console.WriteLine(1/(2*k+1D));
			} while(k<2*n);


			//////////////////////////////////

				Console.WriteLine("while-Schleife");

			int j = 3;
			while(j<2*n)
			{
				j += 1;
				Console.WriteLine(1/(2*j+1D));

			}

		}

			public static void binaer()
			{
				int zahl = 56987;
				int merke = zahl;
				string binaer = "";
				// Variable, die den Rest der Division durch 2 speichert
				int rest;
				do
				{
					// Der Rest kann bei modulo  immer nur 1 oder 0 sein.
					rest = zahl % 2;
					zahl = zahl / 2;
					// Zusammensetzen des Strings zur Binaerdarstellung
					binaer = rest + binaer;
				} while (zahl > 0);
				Console.WriteLine (merke + " dezimal ist: " + binaer + " binaer");
			}


		static void Ostern()
		{

			int j, a, b, c, d,  e, m, n, s, tag, monat;

			Console.WriteLine("Geben ie eine Jahreszahl ein");
			 j = int.Parse(Console.ReadLine());

			a = j % 19;
			b = j%4;
			c = j %7;
			
			m = (8*(j/100) + 13)/25 -2;
			s = j/100 - j/400 -2;
			m = (15 + s - m)%30;
			n = (6+s)%7;

			d = (m +19 * a)%30;
			if(d==29)
			{
				
				d = 28;
			}
			else if(d==28 & a >=11)
			{
				d = 27;
			}

			e = (2 * b + 4 * c + 6 * d + n)%7;

			tag = 21 + d + e +1;
		
			if(tag > 31)
			{
				tag = tag%31;
				monat = 4;
			}
			else
			{
				monat = 3;
			}

//Im Jahr 2001 ist der Ostersonntag am 15.4.
			Console.WriteLine("Im Jahr" + j + "ist der Ostersonntag am " + tag + ". " + monat + ". ");

		}


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


		public static void Fahrrad()
		{	
			int m = 0;
			for (int i = 0; i<10;i++) 
			{
				for (int j = 0; j < 10; j++) 
				{
					for (int k = 0; k < 10; k++) 
					{
						if (i!=j && i!=k && j!=k) 
						{
							Console.Write(""+i+j+k+" ");
							m++;
							if (m%10 == 0) Console.WriteLine("");
						}
					}
				}
			}
		}
	}
}
