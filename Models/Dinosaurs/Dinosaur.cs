using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Jurassic.Models.Dinosaurs.Interfaces; // IEquatable
namespace Jurassic.Models.Dinosaurs;
using Dinosaurs.Attributes;

public abstract class Dinosaur(in string name) 
  : IEquatable<string>, IEquatable<Dinosaur>, IAttackable {
  public required string Name { get; set; } = name;
  public required HealthPointsAttribute HealthPoints { get; set; }
  public DamageAttribute? Damage { get; set; }



  public static implicit operator string(Dinosaur dinosaur) => dinosaur.Name;
  
  public bool Equals(string? name) => name is not null && Name == name; 
  public bool Equals(Dinosaur? other) => other is not null && Equals(other.Name);
  public override bool Equals(object? obj) => obj switch {
    string => Equals(Name),
    Dinosaur other => Equals(other),
    _ => false
  };
                                           
  public override int GetHashCode() => Name.GetHashCode();
  public void Attacked(in IDamageDealing by) => by.DealDamage(this);

  public static bool operator ==(in Dinosaur self, object? other) => self.Equals(other);
  public static bool operator !=(in Dinosaur self, object? other) => !(self == other);
}