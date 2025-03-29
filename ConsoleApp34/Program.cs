using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
	internal class Program
	{
		class Auto
		{
			public void Encender()
			{
				Console.WriteLine("El auto está encendido.");
			}

			public void Acelerar()
			{
				Console.WriteLine("El auto está en movimiento.");
			}
		}

		static void Main(string[] args)
		{
			
			Auto miAuto = new Auto();

			
			miAuto.Encender();
			miAuto.Acelerar();

			
			Console.ReadKey();
		}
	}
}