using PalindromCheck;
using System.Numerics;
//minchev 34 araga
//Palin p  = new Palin("gaaggbnkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk");
string input = "aba";
Console.WriteLine(PalinCheck(input));
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
bool PalinCheck(string input)
{
    List<char> output = new();
    foreach (char c in input)
    {
        switch (c)
        {
            case ' ':
                break;
            case ',':
                break;
            case ';':
                break;
            case ':':
                break;
            case '.':
                break;
            default: output.Add(c); break;
        }

    }
    string newinput = "";
    foreach (char c in output)
    {
        newinput += c;
    }
    newinput = newinput.ToLower();
    if (newinput.Length == 1)
    {
        return true;
    }
    List<int> CountList = new();
    List<char> templettters = new();
    for (int i = 0; i < newinput.Length; i++)
    {
        if (templettters.Contains(newinput[i]))
        {
            continue;
        }
        else
        {
            CountList.Add(newinput.Count(t => t == newinput[i]));
            templettters.Add(newinput[i]);
        }
    }

    if (CountList.Count(t => t % 2 == 1) > 1)//>1 sovorakani hamar isk >2 ete gone mi haty character karas hanes
    {
        return false;
    }
    else if (CountList.Count(t => t % 2 == 0) > 0 && CountList.Count(t => t % 2 == 1) == 0)
    {
        return true;
    }
    else if (CountList.Count(t => t % 2 == 1) == 1)
    {
        return true;
    }
    return true;
}

