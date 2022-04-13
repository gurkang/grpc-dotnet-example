namespace testAddGRPC.Services
{
    public class MarketService
    {
        public Task<market.Market> Market(market.Market market)
        {
            var languages = new List<market.Language>();
            languages.Add(new market.Language());
            return Task.FromResult(new market.Market
            {
                Code = "123",
                Languages = languages,
                Name = "123"
            });
        }
    }
}
