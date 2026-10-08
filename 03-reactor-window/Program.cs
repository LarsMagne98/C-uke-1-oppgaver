int energy = 55;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = energy is >= 40 and <= 70;


Console.WriteLine($"Reactor stable: {isStable}");

// Ferdig
