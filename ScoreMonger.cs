//Programmer: Douglas Shirilla
//Date: 01/31/2017
//Class: COP 2360
//Instructor: Dr. Spears
//Purpose: Create a program that has 5 test scores and display the average score 
//accurate to 1 decimal place

//declare namespace needed
using static System.Console;

//create ScoreMonger class
class ScoreMonger{
	
	//create main method
	static void Main(){
		
		//declare and initialize test score variables
		float testScore1=79, testScore2=95, testScore3=74, testScore4=65, testScore5=81;
		
		//compute average score
		float scoreAvg = ((testScore1 + testScore2 + testScore3 + testScore4 + testScore5) / 5);
		
		//convert average score variable to string data type for output
		string scoreString = scoreAvg.ToString("F1");
		
		//output result to console
		WriteLine("The average test score was {0}. Not bad, not amazing.", scoreString);
		
	}//end of main method
}//end of ScoreMonger class
		