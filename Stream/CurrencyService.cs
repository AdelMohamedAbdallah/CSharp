namespace C__Course.Stream
{
    internal class CurrencyService
    {
        private readonly HttpClient _httpClient;

        public CurrencyService()
        {
            _httpClient = new HttpClient();
        }
        public String GetCurrencies()
        {
            string url = "https://coinbase.com/api/v2/currencies";
            var result = _httpClient.GetStringAsync(url).Result;
            return result;
        }
        public override string ToString()
        {
            return $"{GetCurrencies()}";
        }
    }
}
