using System;
using System.Collections.Generic;

namespace PRand
{
  public class SemiRand 
  {
    private HashSet<int> set;
    private Random r = new Random();

    public SemiRand() {}

    public int NextInt(int max, int[] l) {
      if(max < 1) {
        throw new ArgumentOutOfRangeException("Max must be greater than or equal to 1");
      }
      //check if size of l is == max, throw error
      set = new HashSet<int>(l.Length);
      foreach(var numb in l) {
        set.Add(numb);
      }
      int next;
      do {
        next = r.Next(max);
      } while(set.Contains(next));
      return next;
    }
  }
}