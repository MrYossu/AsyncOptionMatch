using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageExt;

namespace AsyncOptionMatch {
  public class InvestorController {
    private readonly AppDbContext _appDbContext;
    private Option<Investor> _investor;

    public InvestorController() =>
      _appDbContext = new();

    public async Task SetUpInvestor(int id) =>
      _investor = _appDbContext.Investors.FirstOrDefault(i => i.Id == id);

    public async Task<RenewalViewModel> NewRenewalViewModel() =>
      _investor.Match(
       async inv => {
          Term latestTerm = inv.Terms.OrderByDescending(ila => ila.End).First();
          List<Share> shares = await _appDbContext.Shares();
          return new RenewalViewModel {
            Start = latestTerm.End.AddDays(1),
            End = latestTerm.End.AddYears(1),
            Shares = latestTerm.Shares.Select(s => new Share {
              Id = s.Id,
              Quantity = s.Quantity,
              CompanyId = s.CompanyId,
            }).ToList(),
            OtherShares = shares,
          };
        },
        new RenewalViewModel());
  }
}