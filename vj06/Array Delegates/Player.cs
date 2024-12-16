class Player
{
 public int Number { get; set; }
 public string Name { get; set; }
 public int Score { get; set; }
 public Player(int number, string name, int score) {
 Number = number;
 Name = name;
 Score = score;
 }
 public override string ToString()
 {
 return Number + ". " + Name + ": " + Score;
 }
}

