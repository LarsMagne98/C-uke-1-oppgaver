string signal = "RED";


switch (signal)
{
    case "RED":
    case "CRIMSON":
    case "SCARLET":
        Console.WriteLine("Evacuate deck");
        break;
    case "AMBER":
    case "YELLOW":
        Console.WriteLine("Prepare crew");
        break;
    case "GREEN":
        Console.WriteLine("No emergency");
        break;
    default:
        Console.WriteLine("Unknown signal");
        break;
}

// Ferdig