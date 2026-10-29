int energy = 50;
string classification = "";


if (energy < 20)
{
    classification = "Dormant";
}
else if (energy <= 49)
{
    classification = "Stable";
}
else if (energy <= 79)
{
    classification = "Unstable";
}
else
{
    classification = "Critical";
}

Console.WriteLine($"Classification: {classification}");

// Ferdig
