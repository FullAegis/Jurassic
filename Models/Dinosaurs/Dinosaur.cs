using System;

namespace Jurassic.Models.Dinosaurs;
using Dinosaurs.Interfaces;
using Dinosaurs.Attributes;

public abstract class Dinosaur(in string name) : IAttackable {
  private readonly Guid _guid = Guid.NewGuid();
  
  public string Name { get; set; } = name;
  public HealthPointsAttribute HealthPoints { get; set; }
  public DamageAttribute? Damage { get; set; }
  
  public override bool Equals(object? obj) => obj switch {
    Guid g => _guid.Equals(g),
    Dinosaur other => _guid.Equals(other._guid),
    _ => false
  };
  
  public void Attacked(in IDamageDealing by) => by.Attack(this);

  public static bool operator ==(in Dinosaur self, object? other) => self.Equals(other);
  public static bool operator !=(in Dinosaur self, object? other) => !(self == other);
}