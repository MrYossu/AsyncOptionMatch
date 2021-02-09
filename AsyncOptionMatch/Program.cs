using System.Threading.Tasks;

namespace AsyncOptionMatch {
  class Program {
    static void Main(string[] args) =>
      Task.Run(DoStuff).Wait();

    private static async Task DoStuff() {
      InvestorController controller = new();
      await controller.SetUpInvestor(1);
      // In reality, the line above would be done in one place, and the code below would be done somewhere else, but I'm combining them for simplicity
      RenewalViewModel vm = await controller.NewRenewalViewModel();
    }
  }
}