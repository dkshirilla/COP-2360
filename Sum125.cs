//Programmer: Douglas Shirilla
//Date: 02/27/2017
//Instructor: Dr. Spears
//Course: COP 2360
//Purpose: Create a program that calculates the sum of the integers between 1 to 125
//without using a formula and display the result 

//declare namespace
using static System.Console;
using System;
//create class
class Sum125{
	//create main method
	static void Main(){
		int total = 0;//counter variable
		for(int x = 1; x <= 125; x++){
			total += x;//accumulator
		}
		WriteLine("The sum of all the integers from 1 to 125 is {0}", total);//display result
	}
}