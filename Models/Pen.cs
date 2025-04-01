using Jurassic.Models.Dinosaurs;  // Dinosaur
using System.Collections.Generic; // Dictionary<TKey, TValue>
namespace Jurassic.Models;

public class Pen {
  protected Dictionary<string, Dinosaur> dinosaurs = new();
  
  public static Pen operator +(Pen self, in Dinosaur dinosaur) {
    self.dinosaurs.Add(dinosaur.Name, dinosaur);
    return self;
  }
  
  public static Pen operator -(Pen self, in Dinosaur dinosaur) {
    self.dinosaurs.Remove(dinosaur.Name);
    return self;
  }
  
  public static Pen operator -(Pen self, in string dinoName) {
    self.dinosaurs.Remove(dinoName);
    return self;
  }
}