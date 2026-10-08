using System.Security.Cryptography;

string dockingCode = "alt annet";
string instruction = "";

// TODO: Bruk switch statement til å sette instruction.
// En moderne switch. isteden for case/break switch.
instruction = dockingCode switch
{
    "NORTH" => "Dock at gate 1",
    "EAST" => "Dock at gate 2",
    "SERVICE" => "Dock at maintenance bay",
    "CLOSED" => "Hold position",
    _ => "Unknown docking code"    
};

Console.WriteLine(instruction);


// Ferdig