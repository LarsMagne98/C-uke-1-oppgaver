using System.Runtime.CompilerServices;

for (int cycle = 1; cycle <= 36; cycle++)
{
    // TODO: Skriv riktig resultat for cycle.
    // % 4 og 6 = 0 hver 12 syklus, så isteden for å sjekke når begge = 0, 
    // kan man heller skjekke når % 12 = 0
    // LCM heter det. source: AI.

    if (cycle % 12 == 0) 
    {
        Console.WriteLine("FULL SERVICE");
    }
    else if (cycle % 4 == 0)
    {
        Console.WriteLine("FILTER CHECK");
    }
    else if (cycle % 6 == 0)
    {
        Console.WriteLine("THRUSTER CHECK");
    }
    else
    {
        Console.WriteLine(cycle);
    }
}

// Ferdig