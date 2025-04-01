using Jurassic.Models.Dinosaurs.Attributes;

namespace Jurassic.Models.Dinosaurs;

[HealthPoints(420)]
[Damage(69)]
public class Triceratops(in string name) : Dinosaur(name) {
  
}