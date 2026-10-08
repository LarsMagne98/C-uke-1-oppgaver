string transmission = "AB#CD##EF";
int interferenceCount = 0;

// TODO: Bruk foreach over transmission.

foreach (var sign in transmission) {
    if (sign == '#')
    {
        interferenceCount++;
    }
}

Console.WriteLine($"Interference markers: {interferenceCount}");

// Ferdig