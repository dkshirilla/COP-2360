//Programmer: Douglas Shirilla
//Date: 01/31/2017
//Class: COP 2360
//Instructor: Dr. Spears
//Purpose: Create a program that uses a variable that represents time daydreaming on the job
//and display the result in hours/minutes format


using static System.Console;

//declare class 
class DayDreaming{
	//create main method
	static void Main(){
		//declare variable to hold number of minutes daydreaming
		int numOfMinutes = 122;
		//compute the result and display it to console
		WriteLine("You daydreamed a total of {0} hours and {1} minutes today. Try coffee tomorrow.",(numOfMinutes/60), (numOfMinutes%60));
		
	}//end of main
}//end of class