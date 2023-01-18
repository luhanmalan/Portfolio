try
{
    // Get input from user
    Console.WriteLine("Please enter a phrase to convert to an acronym: ");
    String input = Console.ReadLine();

    //Optional exclusions
    String exclusions = input.Replace("and", "");
    String[] wordArray = exclusions.Split(' ');
    Console.WriteLine(wordArray.Length);

    // Loop through sentence
    String acronym = "";
    for(int i = 0; i < wordArray.Length; i++)
    {
        if(wordArray[i] != "")
        {
            acronym += wordArray[i][0];
        }
    }
    acronym = acronym.ToUpper();

    Console.WriteLine("Your acronym is: " + acronym);


}
catch(Exception e)
{
    Console.WriteLine(e.ToString());
}