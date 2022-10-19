//Chris Martinez
//10/18/22
//Asking Question - Revamp
//I re-created the program from the original one, this time around I added a boolean. The program kicks you out, when you wish to not play no more., and it also allows you to replay when you choose yes., a step up from the original program i had. 


// Console.Clear();
// string name = "";
// string time = "";
// Console.WriteLine("What is your name?");
// name = Console.ReadLine();
// Console.WriteLine("What time you woke up today?");
// time = Console.ReadLine();
// Console.Clear();
// Console.WriteLine(name + " you woke up today at " + time);

Console.Clear();
bool playing = true;
int wrong = 0;
bool number;
string no = "";
while(playing)
{
    Console.WriteLine("Hello what is your name?");
    string MyName = Console.ReadLine();
            number = Int32.TryParse(MyName, out wrong);
        if(number == true){
            Console.WriteLine("please enter a name not a number.");
        }else
        {
            Console.WriteLine("What time did you wake up today?,  " + MyName + "!");
            no = Console.ReadLine();
            Console.WriteLine($"{MyName} you woke up at {no}");
        }
            Console.WriteLine("would you like to play again? type in yes or no");
            no = Console.ReadLine();
        if(no == "no")
        {
            playing = false;
        }
        // Console.WriteLine("Wanna Play again");

}
