namespace CS;

public class InputReader{
	public List<string> GetLines(string fileNumber){
		return File.ReadAllLines($@"B:\Projects\AOC2024\Inputs\{fileNumber}.txt").ToList();
	}

	public List<string> GetInputChar(List<string> lineList){
		var output = new List<string>();
		var number = string.Empty;
		foreach (var line in lineList){
			foreach (var character in line){
				if (character != ' '){
					number += character;
				}
				else{
					if (number != string.Empty){
						output.Add(number);
						number = string.Empty;
					}
				}
			}
			output.Add(number);
			number = string.Empty;
		}
		return output;
	}

	public int[] GetSingleInputChar(string line){
		var number = string.Empty;
		var output = new List<int>();
		foreach (var character in line){
			if (character != ' '){
				number += character;
			} else {
				if (number != string.Empty){
					output.Add(Convert.ToInt32(number));
					number = string.Empty;
				}
			}
		}
		output.Add(Convert.ToInt32(number));
		return output.ToArray();
	}
}