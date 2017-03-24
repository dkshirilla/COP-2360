//Programmer: Douglas Shirilla
//Date: 02/27/2017
//Instructor: Dr. Spears
//Course: COP-2360
//Purpose: To accept user input and count the number of lower case numbers entered and the
//number of other characters along with displaying the amount of each entered to the user after
//they are finished entering values.

//declare needed namespaces for program
using static System.Console;
using System;

//declare class 
class CountLowers{
	//create main method
	static void Main(){
		//declare variables
		int lowerCase = 0, otherChar = 0; // initialize to 0
		char placeHolder;
		string response;
		//used a do while loop to ensure at least one execution
		do{
			WriteLine("Please enter a character. Uppercase, lowercase, or other>>");
			response = ReadLine();//get user input
			placeHolder = Convert.ToChar(response);
			if(char.IsLower(placeHolder))//use char.IsLower() method to test input
				{
					lowerCase++;
				}
			else if(placeHolder != '}'){
					otherChar++;
				}
		}while(placeHolder != '}');//end of loop
		//display results to user
		WriteLine("The number of lower case characters entered is " + lowerCase + 
		" and the number of other characters entered is " + otherChar + ".");
}//end of main
}//end of class CountLowers