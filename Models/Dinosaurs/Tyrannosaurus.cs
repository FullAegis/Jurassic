namespace Jurassic.Models.Dinosaurs;
using Dinosaurs.Attributes;

[HealthPoints(300)]
[Damage(100)]
public class Tyrannosaurus(in string name) : Dinosaur(name) {
  
}

