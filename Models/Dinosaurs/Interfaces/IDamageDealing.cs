using Jurassic.Models.Dinosaurs.Attributes;

namespace Jurassic.Models.Dinosaurs.Interfaces;

public interface IDamageDealing {
  public DamageAttribute Damage { get; protected set; }
  public void DealDamage(IAttackable target);
}