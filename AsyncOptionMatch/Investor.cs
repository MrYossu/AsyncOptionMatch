using System.Collections.Generic;

namespace AsyncOptionMatch {
  public class Investor {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public List<Term> Terms { get; set; }
  }
}