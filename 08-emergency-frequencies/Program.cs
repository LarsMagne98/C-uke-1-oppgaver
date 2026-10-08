string signal = "RED";

// TODO: Lag switch med kombinerte case-labels.

string message = signal switch
{
    "RED" or "CRIMSON" or "SCARLET" => "Evacuate deck",
    "AMBER" or "YELLOW"             => "Prepare crew",
    "GREEN"                         => "No emergency",
    _                               => "Unknown signal"
};

Console.WriteLine(message);

// Ferdig