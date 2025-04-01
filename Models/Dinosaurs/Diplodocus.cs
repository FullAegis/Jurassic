
using Jurassic.Models.Dinosaurs.Interfaces;

namespace Jurassic.Models.Dinosaurs;
using Jurassic.Models.Dinosaurs.Attributes;

[HealthPoints(42)]
[Damage(0)]
public class Diplodocus(in string name) : Dinosaur(name) {
  public void Attack(IAttackable _) {
    // Deals 0 damage, 💀
  }
}