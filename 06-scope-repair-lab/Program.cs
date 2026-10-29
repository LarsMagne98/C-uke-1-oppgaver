int signalStrength = 72;

/*
if (signalStrength >= 70)
{
    string status = "STRONG";
}
else
{
    string status = "WEAK";
}

Console.WriteLine(status); // status finnes ikke her
*/

string status = "";

if (signalStrength >= 70)
{
    status = "STRONG";
}
else
{
    status = "WEAK";
}

Console.WriteLine($"Signal status: {status}");

// Ferdig
