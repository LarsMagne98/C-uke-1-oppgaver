bool hasSuit = true;
int oxygenPercent = 44;
int pressure = 100;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
// Brukte AI til å vise en ryddigere måte å skrive det på enn deg jeg gjorde i utgangspunktet.
bool canOpenAirlock = hasSuit
                    && !alarmActive
                    && oxygenPercent >= 30
                    && pressure is >= 90 and <= 110;

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}

// Ferdig