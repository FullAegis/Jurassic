using System;                    // Console
using Jurassic.Models;           // Pen
using Jurassic.Models.Dinosaurs; // Have a guess

namespace Jurassic;

using TRex = Tyrannosaurus; // I'm lazy
public static class Program {
  public static void Main(string[] args) {
    var ben = new Diplodocus("Ben");
    var jon = new Triceratops("Jon");
    var bob = new TRex("Bob");
    
    var pen = new Pen([ben, jon, bob]);
    
    foreach (var dino in pen) {
      Console.WriteLine(dino);
    }
  }
  
}
