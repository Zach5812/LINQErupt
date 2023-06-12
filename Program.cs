List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
// First Eruption in Chile
// First Eruption in Chile
IEnumerable<Eruption> firstChile = eruptions.Where(eruption => eruption.Location == "Chile").Take(1);
PrintEach(firstChile);
// First Hawaii
IEnumerable<Eruption> firstHawaii = eruptions.Where(eruption => eruption.Location == "Hawaiian Is").Take(1);
PrintEach(firstHawaii);
// First Greenland
Eruption? greenland = eruptions.FirstOrDefault(eruption => eruption.Location == "Greenland");
// List<Eruption> firstGreenland = eruptions.Where(eruption => eruption.Location == "Greenland").Take(1).ToList();
if (greenland != null)
{
    Console.WriteLine(greenland.ToString());
}
else
{

    Console.WriteLine("None Available");
}
// New Zealand
IEnumerable<Eruption> newZealand = eruptions.Where(eruption => eruption.Location == "New Zealand").Where(eruption => eruption.Year >= 1900).Take(1);
PrintEach(newZealand);
// Elevation over 2000
IEnumerable<Eruption> elevation = eruptions.Where(eruption => eruption.ElevationInMeters >= 2000);
PrintEach(elevation);
// Print highest elevation
int elevationHigh = eruptions.Max(eruption => eruption.ElevationInMeters);
PrintEach(elevation);
Console.WriteLine(elevationHigh);
// Print name of highest elevation
// string highestEl = eruptions.Where(eruption => eruption.ElevationInMeters == elevationHigh).Select(eruption => eruption.Volcano).ToString();
Eruption? highestEl = eruptions.FirstOrDefault(eruption => eruption.ElevationInMeters == elevationHigh);
Console.WriteLine(highestEl.Volcano);

// Eruptions that start with L and how many
IEnumerable<Eruption> startsWithL = eruptions.Where(eruption=> eruption.Volcano.StartsWith("L"));
PrintEach(startsWithL);
Console.WriteLine("STARTS WITH L");
Console.WriteLine(startsWithL.Count());

// All Volcano names in alphabetical
IEnumerable<string> alpha = eruptions.Select(eruptions => eruptions.Volcano).OrderBy(eruptions=> eruptions);
Console.WriteLine(String.Join(", ", alpha));

// Sum of all elevations
int sum =eruptions.Sum(eruption=> eruption.ElevationInMeters);
Console.WriteLine(sum);

// Any in year 2000?
bool year = eruptions.Any(eruption=> eruption.Year == 2000);
Console.WriteLine(year);

// First 3 strato
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano").Take(3);
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

// Alpha before year 1000
IEnumerable<string> alphabetically = eruptions.Where(eruptions => eruptions.Year <1000).Select(eruptions => eruptions.Volcano).OrderBy(eruptions=> eruptions);
Console.WriteLine(String.Join(", ", alphabetically));




// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("*********");
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

