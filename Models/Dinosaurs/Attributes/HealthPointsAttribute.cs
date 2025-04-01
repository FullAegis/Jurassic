using System;
using System.Diagnostics; // Attribute
namespace Jurassic.Models.Dinosaurs.Attributes;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
public sealed class HealthPointsAttribute(int max) : Attribute {
  private readonly int _kMax = max;
  private int _field = max;
  public int Current { get => _field; set => _field = int.Clamp(value, 0, _kMax); }
  
  public static implicit operator int(in HealthPointsAttribute hp) => hp.Current;
  public static explicit operator HealthPointsAttribute(in int hp) => new(hp);
  
  /// <summary>
  ///  Heal
  /// </summary>
  /// <param name="self"></param>
  /// <param name="amount">Points to add</param>
  /// <returns>self after healing</returns>
  public static HealthPointsAttribute operator +(in HealthPointsAttribute self, in int amount) {
    self.Current += amount;
    return self;
  }
  
  /// <summary>
  ///  Take damage
  /// </summary>
  /// <param name="self">the target getting hit</param>
  /// <param name="dmg">The DamageAttribute of the attacker</param>
  /// <returns>self after healing</returns>
  public static HealthPointsAttribute operator -(HealthPointsAttribute self, DamageAttribute dmg) {
    self.Current -= (byte) dmg;
    return self;
  }
}