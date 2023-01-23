
string loop = "Itterate";
List<int> overWeightsCost = new List<int>();

while (loop == "Itterate") 
{
    Console.WriteLine("1. Validate the permissible carrying capacity.");
    Console.WriteLine("2. Exit and Display.");
    string input = Console.ReadLine();

    switch(input)
    {
        case "1":
            Console.Write("Enter Total Weight: ");
            int totalWeight = int.Parse(Console.ReadLine());

            if (totalWeight > 23)
            {
                int overWeight = totalWeight - 23;
                Console.WriteLine($"Additional carriage weight: {overWeight}");
                overWeightsCost.Add(overWeight * 15);
            }
            else
            {
                Console.WriteLine("Acceptable Weight.");
            }
            break;
        case "2":
            int sum = 0;
            int[] overWeightsArray = overWeightsCost.ToArray();
            Array.Sort(overWeightsArray);
            Array.Reverse(overWeightsArray);
            Array.ForEach(overWeightsArray, Weight => Console.WriteLine(Weight));
            Array.ForEach(overWeightsArray, Weight => sum += Weight);
            Console.WriteLine($"Total Amount Collected: {sum}");
            loop = "STOP";
            break;
        default:
            Console.WriteLine("Invalid Entry!");
            break;
    }
}







