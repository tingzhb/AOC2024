namespace CS;

public class Day02{
	enum Steps{
		Increasing,
		Decreasing,
		Unset
	}
	const string Day = "02";

	static readonly InputReader InputReader = new();
	readonly List<string> lineList = InputReader.GetLines(Day);
	int safe;

	public void RunSolution(){
		foreach (var line in lineList){
			CheckSteps(line);
		}
		Console.WriteLine(safe);
	}

	void CheckSteps(string inputLine){
		bool safeEntry = true;
		var numbers = InputReader.GetSingleInputChar(inputLine);
		Steps steps = Steps.Unset;

		for (var i = 1; i < numbers.Length; i++){
			if (numbers[i] == numbers[i - 1]){
				Console.WriteLine("NOT INCREASING");
				safeEntry = false;
				break;
			}
			if (numbers[i] < numbers[i - 1]){
				Console.WriteLine("INCREASING");
				if (steps == Steps.Decreasing){
					Console.WriteLine("CHANGE!");
					safeEntry = false;
					break;
				}
				steps = Steps.Increasing;

			}
			if (numbers[i] > numbers[i - 1]){
				Console.WriteLine("DECREASING");
				if (steps == Steps.Increasing){
					Console.WriteLine("CHANGE!");
					safeEntry = false;
					break;
				}
				steps = Steps.Decreasing;
			}
			if (MathF.Abs(numbers[i] - numbers[i - 1]) > 3){
				safeEntry = false;
				break;
			}
		}
		if (safeEntry){
			Console.WriteLine("SAFE!");
			safe++;
		}
	}
}

