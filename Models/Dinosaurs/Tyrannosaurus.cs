namespace Jurassic.Models.Dinosaurs;
using Dinosaurs.Attributes;

using TRex = Tyrannosaurus; // Alias for our T.rex;
[HealthPoints(69)]
public class Tyrannosaurus(in string name) : Dinosaur(name) {
  
}

