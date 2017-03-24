//Programmer: Douglas Shirilla
//Date: 02/14/2017
//Course: COP-2360
//Instructor: Dr. Spears
//Purpose: To create a program that accepts user input about themselves and their fish and
//calculates the daily fee to take care of their pet. After that, the program displays all
//entered information along with the calculated fee that is determined by the size of the fish.

using System;
using static System.Console;

//create class FishORama
class FishORama{
	//declare constants for fish size
	const int SMALL_SIZE = 10;
	const int MEDIUM_SIZE = 20;
	const int LARGE_SIZE = 30;
	
	//declare constants for daily care fee
	const int SMALL_PRICE = 7;
	const int MEDIUM_PRICE = 12;
	const int LARGE_PRICE = 16;
	const int EXPENSIVE_PRICE = 20;
	
	//create main method
	static void Main(){
		//declare variables for user input 
		string customerName, fishName, fishSpecies, fishLengthInput;
		int fishCost, fishLength;
		
		//get information from user
		WriteLine("Please enter your name>> ");
		customerName = ReadLine();
		WriteLine("Plese enter the fish's name>> ");
		fishName = ReadLine();
		WriteLine("Please enter the species of your fish>> ");
		fishSpecies = ReadLine();
		WriteLine("Please enter the length of your fish (in inches)>> ");
		fishLengthInput = ReadLine();
		//convert fish lengh input into int data type
		fishLength = Convert.ToInt32(fishLengthInput);
		//decision tree to determine daily care cost
		if(fishLength > LARGE_SIZE)
			fishCost = EXPENSIVE_PRICE;
		else	
			if( fishLength > MEDIUM_SIZE)
				fishCost = LARGE_PRICE;
			else
				if(fishLength >= SMALL_SIZE)
					fishCost =  MEDIUM_PRICE;
				else
					fishCost = SMALL_PRICE;
		//display output to user
		WriteLine("Thank you for your patronage " + customerName + ", we ensure you that " + fishName +
					" of the species " + fishSpecies + " will be well taken care of." + " The daily fee that you will" +
					" need to pay for their care is $" + fishCost + ".");
		}//end of main
	}//end of class					
		
		