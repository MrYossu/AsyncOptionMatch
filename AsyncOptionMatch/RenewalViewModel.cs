using System;
using System.Collections.Generic;

namespace AsyncOptionMatch {
  public class RenewalViewModel {
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<Share> Shares { get; set; }
    public List<Share> OtherShares { get; set; }

  }
}