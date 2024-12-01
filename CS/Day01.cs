namespace CS;

public class Day01 {
	
	const string Day = "01";

	static readonly InputReader InputReader = new();
	readonly List<string> charList = InputReader.GetInputChar(InputReader.GetLines(Day));

	readonly List<int> leftList = new();
	readonly List<int> rightList = new();

	public void RunSolution(){
		for (var i = 0; i < charList.Count; i++){
			if (i % 2 == 0){
				leftList.Add(Convert.ToInt32(charList[i]));
			} else {
				rightList.Add(Convert.ToInt32(charList[i]));
			}
		}
		GetSimilarity();
		GetDelta();
	}
	
	void GetSimilarity(){
		int score = 0;
		foreach (var leftItem in leftList){
			int counter = 0;
			foreach (var rightItem in rightList){
				if (leftItem == rightItem){
					counter++;
				}
			}
			score += leftItem * counter;
		}
		Console.WriteLine(score);
	}
	void GetDelta(){
		int delta = 0;


		leftList.Sort();
		rightList.Sort();


		for (var i = 0; i < rightList.Count; i++){
			delta += (int)MathF.Abs(rightList[i] - leftList[i]);
		}
		Console.WriteLine(delta);
	}
}
