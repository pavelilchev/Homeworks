﻿
using System;

namespace Problem2.Animals
{
	public class Frog : Animal
	{
		public Frog(string name, int age, string gender)
			: base(name, age, gender)
		{
		}
		
		public override void ProduceSound()
		{
			Console.WriteLine("{0} said kvakva", this.GetType().Name);
		}
	}
}
