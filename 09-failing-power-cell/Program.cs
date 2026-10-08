int charge = 25;
int drainPerCycle = 5;

// TODO: Bruk while til å simulere utladingen.

while (charge > 0)
{
    Console.WriteLine($"Remaining charge: {charge}");
    charge -= drainPerCycle;
}

Console.WriteLine("Power cell offline.");

// Ferdig