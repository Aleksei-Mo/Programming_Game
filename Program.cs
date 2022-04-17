// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
//Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или 
//меньше. На отгадывание дается 3 попытки.
Console.WriteLine("Hi friend! Let's play, I'm going to make a random number and you need to guess this number. You have 3 attempts.");
Console.WriteLine("Before start the game choose from the following difficulty level.");
Console.WriteLine("Beginner: range is [0...20]");
Console.WriteLine("Master: range is [0...50]");
Console.WriteLine("Ultra profi: range is [0...100]");
Console.Write("Enter the difficulty level: ");
string? diffLevel = Console.ReadLine(); // input difficulty level
int number = randomNumber(diffLevel); // make random number
Console.WriteLine("The number has already made. Try to guess!!!");
int attempt=1; // current attempt
int attemptNumber=3; // total number of the attempts
int attemptLeft = 0;// how many attempts left
int userNumber=0;


  while (attempt<=attemptNumber)
  {
    Console.Write("Enter your number: "); // input user number
    userNumber=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Attempt #"+attempt+", your number is "+userNumber);
    attemptLeft=attemptNumber-attempt;// count how many attempts left
    if (number!=userNumber)
    {
        if (number>userNumber)
        {
           Console.WriteLine("Try again! "+ attemptLeft +" attempts left. Your number is less.");
        }
        else if(number<userNumber)
        {
           Console.WriteLine("Try again! "+ attemptLeft +" attempts left. Your number is bigger.");
        }
        
    
    }
    else
    {
        Console.WriteLine("*****Win!***** You used "+ attempt + " attempt(s). Your difficulty level is "+ diffLevel);
        break; // getting out of the loop "while" in case of WIN
    }
    
    attempt++;
  }

if (attempt>3)
{
Console.WriteLine("*****GAME OVER!***** Right answer is "+ number);
}




int randomNumber(string? diffLevel)//function for searching a random number in accordance with difficalty level
{
int result=0; 
int min=0;
int max=0;

    if (diffLevel=="Beginner" ^ diffLevel=="beginner")
    {
      min=0;
      max=21;
    }
    else if (diffLevel=="Master" ^ diffLevel=="master")
    {
      min=0;
      max=51;
    }
    else if (diffLevel=="Ultra profi" ^ diffLevel=="ultra profi")
    {
      min=0;
      max=101;
    }
    else // if wrong difficalty level is choosen than we use Beginner level
    {      
      min=0;
      max=21;
    }

result= new Random().Next(min,max);
return result;
}