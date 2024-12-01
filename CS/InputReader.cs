namespace CS;

public class InputReader{
	public List<string> GetLines(string fileNumber){
		return File.ReadAllLines($@"B:\Projects\AOC2024\Inputs\{fileNumber}.txt").ToList();
	}

	public List<string> GetInputChar(List<string> lineList){
		var output  = new List<string>();
		var number = string.Empty;
		foreach (var line in lineList){
			foreach (var character in line){
				if (character != ' '){
					number += character;
				} else {
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
}
