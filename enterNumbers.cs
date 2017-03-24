//Programmer: Douglas Shirilla
//Date: 03/21/2017
//Course: COP-2360
//Instructor: Dr. Spears
//Purpose: Create a program that accepts user input as numbers 1-10 and 0 to quit and store them into an array.
//Then find the sum and average of those numbers and display the numbers along with the difference of each number
//from the average of only the numbers that were entered.


using System;
using static System.Console;

//create class enterNumbers
class enterNumbers{
	//create main method
	static void Main(){
		int[] userNums = new int[10];//declare int array
		int userNum = 1;//initialize user input variable
		int sum = 0;// initialize sum variable/accumulator
		string placeHolder;//variable for user input before conversion to integer
		int i;//variable for loops
		double average = 0;//variable to hold average computation
		
		//get user input and determine if it isn't 0
		WriteLine("Please enter a number 1-10 or 0 to quit>> ");
		placeHolder = ReadLine();
		userNum = Convert.ToInt32(placeHolder);
		
		//end program if user entered 0 for first value
		if (userNum == 0)
			WriteLine("You didn't enter any numbers. Goodbye.");
		
		else//input first value and enter loops for filling array with values
		{
			userNums[0] = userNum;//add first value to array
			sum += userNums[0];//add first value to sum 
			
			for(i = 1; i < 10 && userNum != 0; i++)//loop for filling array until the user enters a 0
			{
				WriteLine("Please enter another number 1-10 or 0 to quit>> ");
				placeHolder = ReadLine();
				userNum = Convert.ToInt32(placeHolder);//convert user input into an int
				userNums[i] = userNum;
				sum += userNums[i];//add entered value to sum accumulator
			}
			
			
			WriteLine("The sum is " + sum);//display the sum of entered values
			average = sum/(i-1);//calculate average of values entered divided by i which is the number of values entered
			WriteLine("The average is " + Math.Round(average));//display the average to user
			
			
			for(i = 0; i < userNums.Length; i++)//loop to display the value and the difference to user
			{
				if (userNums[i] == 0)
					continue;//continue loop if there are left over 0 values in array
				else
					WriteLine("The difference of " + userNums[i] + " from the average of "
				+ average + " is " + (average - userNums[i]));//display final result to user
			}
		}//end of code block for filling and displaying array and calcuations
	}//end of main
}//end of enterNumbers class