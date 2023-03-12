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
string[] toThreeAndLess(string[] arr)
{
    int tempArrLength = arr.Length;
    string[] tempArr = new string[arr.Length];
    int currPos = 0;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) 
        {
            tempArr[currPos] = arr[i];
            currPos++;   
        }
    }

    string[] arrThreeAndLess = new string[currPos];
    for(int i = 0; i < currPos; i++)
    {
        arrThreeAndLess[i] = tempArr[i];
    }

    return arrThreeAndLess;
}

void pauseText()
{
    Console.WriteLine();
    Console.WriteLine("Нажмите клавишу Enter для продолжения...");
    Console.ReadLine();
    Console.WriteLine();
}


void mainMenu()
{
    string userChoice = string.Empty;
    bool getOut = false;

    

    while (getOut != true)
    {
        Console.Clear();

        Console.WriteLine("Для работы программы необходим массив строковых переменных,");
        Console.WriteLine("варианты формирования массива:");
        Console.WriteLine();
        Console.WriteLine("1. Воспользоваться тестовым массивом, имеющимся в программе");
        Console.WriteLine("2. Ввести свой набор слов вручную");
        Console.WriteLine();
        Console.WriteLine("Введите выбранный вариант (цифра '1' либо цифра '2') либо 'q' ('Q') для выхода из программы.");
        Console.WriteLine();

        userChoice = string.Empty;
        userChoice = Console.ReadLine();

        switch(userChoice)
        {
            case "1":
            {
                userChoice = string.Empty;
                Console.WriteLine();
                Console.WriteLine("Исходный массив:");
                printArray(strTestArray);
                Console.WriteLine();
                strArray = toThreeAndLess(strTestArray);
                Console.WriteLine("Новый массив, отвечающий требованиям:");
                printArray(strArray);

                pauseText();

                break;
            }

            case "2":
            {
                Console.WriteLine("Введите массив элементов строкового типа.");
                Console.WriteLine("Для упрощения задачи достаточно ввести массив как строку, разделяя слова-элементы запятыми");
                Console.WriteLine("Программа сама сформирует из них массив: ");
                Console.WriteLine();

                text = Console.ReadLine();

                strArray = InputStringArray(text);
                Console.WriteLine();
                Console.WriteLine("Введенная строка преобразована в массив: ");
                printArray(strArray);
                Console.WriteLine();

                
                strArray = toThreeAndLess(strArray);

                if(strArray.Length > 0)
                {
                    Console.WriteLine("Новый массив, отвечающий требованиям:");
                    printArray(strArray);
                }
                else
                {
                    Console.WriteLine("Введенный массив не содержит отвечающих условиям значений.");
                }

                pauseText();
                break;
            }

            case "q":
            {
                Console.WriteLine("Программа завершает работу.");
                getOut = true;
                break;
            }
        
            case "Q":
            {
                Console.WriteLine("Программа завершает работу.");
                getOut = true;
                break;
            }

            default:
            {
                Console.WriteLine("Ошибочный ввод, попробуйте ввести еще раз:");
                pauseText();
                break;
            }
        }
    }
    Console.WriteLine();
    Console.Clear();

        
}

mainMenu();