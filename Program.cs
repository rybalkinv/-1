using System.Linq;

string[] strTestArray = new string[8]{"Five","Inspect", "free", "2", "4", "no", "cap", "ball"};
string[] strArray;
string text = string.Empty;


string[] InputStringArray(string textArg)                          
                                    
{
    var data = textArg.Split(",") 
                .Select(e => e = e.Replace(" ", string.Empty))
                                                                                 
                .ToArray(); 

    return data;
}


void printArray(string[] arr)
{
    string strPrint = string.Empty;

    
        for(int i = 0; i < arr.Length; i++)
        {
            strPrint = strPrint + arr[i] + ", ";    
        }
   
    Console.WriteLine(strPrint);
}
