using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncOptionMatch {
  public class AppDbContext {
    // Simulates the Entity Framework application database context

    public List<Investor> Investors =>
      new() {
        new() {
          Id = 1,
          FirstName = "Jim",
          Surname = "Spriggs",
          Terms = new() {
            new() {
              Id = 11,
              Start = new(2021, 1, 1),
              End = new(2021, 12, 31),
              Shares = new() {
                new() {
                  Id = 111,
                  TermId = 11,
                  CompanyId = 1111
                }
              }
            }
          }
        }
      };

    public async Task<List<Share>> Shares() =>
      await Task.Run(() => new List<Share> {
        new() { Id = 1, Quantity = 10, CompanyId = 23 },
        new() { Id = 2, Quantity = 2, CompanyId = 42 },
      });
  }
}