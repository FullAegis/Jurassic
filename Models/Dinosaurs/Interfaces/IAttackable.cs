namespace Jurassic.Models.Dinosaurs.Interfaces;
using Dinosaurs.Attributes; // HP

public interface IAttackable {
  public HealthPointsAttribute HealthPoints { get; set; }
  public void Attacked(in IDamageDealing by);
}