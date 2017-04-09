//Programmer: Douglas Shirilla
//Date: 04/02/2017
//Course: COP-2360
//Instructor: Dr. Spears
//Purpose: Create a program that accepts an index value from the user and pass that index to
//a method that uses a string array to produce a phrase similar to a magic 8 ball


using System;
using static System.Console;

//create class 
class Magic8Ball{
	//main
	static void Main(){
		//initilize index variable
		int index = 0;
		//loop to get valid input from user
		do{
			try{
			WriteLine("Please enter a number (1 - 5) to get your fortune>>");
			index = Convert.ToInt32(ReadLine());
			}
			catch(Exception)//catch exceptions that are not valid
			{
				WriteLine("That is not valid input!");
			}
		}while(index == 0 || index > 5 || index < 0);
		
		index--;//decrement index to fit array
		magicBall(index);//call method
	}//end of main
	
	
	//magic 8 ball method
	private static void magicBall(int index){
		//create array of phrases
		string[] fortunes = {"That will become truth.", "That will not happen.", "Maybe tomorrow.",
		"It's possible.", "Not a chance."};
		//display phrase at desired output
		WriteLine(fortunes[index]);
	}//end of method
}//end of class