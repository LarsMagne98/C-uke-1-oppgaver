int energy = 55;
string classification = "";

// TODO: Sett classification med if / else if / else.

if (energy < 20)
{
    classification = "Dormant";
}
else if (energy is >= 20 and <= 49)
{
    classification = "Stable";
}
else if (energy is >= 50 and <= 79)
{
    classification = "Unstable";
}
else if (energy >= 80)
{
    classification = "Critical";
}
else
{
    Console.WriteLine("ERROR!");
}

Console.WriteLine($"Classification: {classification}");

// Ferdig
