namespace Jurassic.Models.Dinosaurs.Attributes;
using System; // Attribute


[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class DamageAttribute(byte damage = 10) : Attribute {
  private static readonly byte kMin = 1, kMax = Byte.MaxValue;
  
  public byte Value { get; private init; } = byte.Clamp(damage, kMin, kMax); 
  public static implicit operator byte(in DamageAttribute d) => d.Value;
}