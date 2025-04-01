using System.Collections;         // IEnumerator
using System.Collections.Generic; // List, IEnumerable
using System.Linq;                // Enumerable.{ToList(), First()}
using Jurassic.Models.Dinosaurs;  // Dinosaur

namespace Jurassic.Models;
public class Pen {
  private List<Dinosaur> _dinosaurs = new();
  // iterator
  public IEnumerator GetEnumerator() => _dinosaurs.GetEnumerator();
  
  // array ctor
  public Pen(IEnumerable<Dinosaur> dinos) => _dinosaurs = dinos.ToList();
  
  // operator overloads
  public static Pen operator +(Pen self, in Dinosaur dinosaur) {
    self._dinosaurs.Add(dinosaur);
    return self;
  }
  
  public static Pen operator -(Pen self, Dinosaur dinosaur) {
    var id = self._dinosaurs.IndexOf(dinosaur);
    self._dinosaurs.RemoveAt(id);
    return self;
  }
  
  public static Pen operator -(Pen self, string dinoName) {
    var dino = self._dinosaurs.First(x => x.Name == dinoName);
    self._dinosaurs.Remove(dino);
    return self;
  }
}