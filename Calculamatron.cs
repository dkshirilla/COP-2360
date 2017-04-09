//Programmer: Douglas Shirilla
//Date: 04/02/2017
//Course: COP-2360
//Instructor: Dr. Spears
//Purpose: Create a program that takes user input for width, height, and length and pass those parameters
//to a method to return the volume of a room

using System;
using static System.Console;

//create Calculmatron class
class Calculamatron{
	
	
	static void Main(){
		//declare needed variables
		int width, height, length, volume;
		//get user input
		WriteLine("Please enter the width of the room>>");
		width = Convert.ToInt32(ReadLine());
		WriteLine("Please enter the height of the room>>");
		height = Convert.ToInt32(ReadLine());
		WriteLine("Please enter the length of the room>>");
		length = Convert.ToInt32(ReadLine());
		//pass input to method
		volume = getRoomVolume(width, height, length);
		//display result
		WriteLine("The total volume of the room is " + volume + " cubic feet.");
	}//end of main
	private static int getRoomVolume(int width, int height, int length){
		int volume;
		volume = width*height*length;
		return volume;
	}//end of method
	
}//end of class