// See https://aka.ms/new-console-template for more information

using Interpolation;

Console.WriteLine("Hello, World!");


var id = 0;

while (id < 4) 
{
	var expected = $"{id++}: " +
						$"{Grid.GetColumn()}x{Grid.GetRow()} " +
						$"{Grid.GetColumnSpan()}x{Grid.GetRowSpan()}";

	Console.WriteLine(expected);
}