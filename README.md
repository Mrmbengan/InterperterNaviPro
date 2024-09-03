# InterperterNaviPro
Interperter
Utmaning
Vi skall bygga en ”Interpreter”, en matematisk tolkare. Tolkaren består av en 
huvudfunktion, samt ett valfritt antal sub-funktioner. Utgångspunkten är följande 
kodskelett:
public static void main()
{
string expression = ”1 + (36 / 2) / (3 * 3) - 2”;
string result = evaluateExpression(expression);
Console.WriteLine(”Epression: ”+expression);
Console.WriteLine(”Result: ”+result);
Console.ReadLine();
}
Tolkaren skall klara av följande räknesätt i oändligt antal nivåer:
• +
• -
• /
• *
Uttrycket i kodskelettet ovan skall endast ses som ett exempel. För korrekt resultat så 
skall vilket uttryck som helst kunna utvärderas i funktionen. Koden skall vara 
språkoberoende, så referenser till externa bibliotek är inte tillåtna. Det är heller inte 
tillåtet att använda ChatGPT som informationskälla