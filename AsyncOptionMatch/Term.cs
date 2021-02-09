using System;
using System.Collections.Generic;

namespace AsyncOptionMatch {
  public class Term {
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<Share> Shares { get; set; }
  }
}