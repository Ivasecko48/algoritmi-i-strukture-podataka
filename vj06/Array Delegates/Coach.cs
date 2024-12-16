class Coach
{
 public string Name { get; set; }
 public string Team { get; set; }
 public Coach(string name) {
 Name = name;
 }
 public override string ToString()
 {
 return Name;
 }
}