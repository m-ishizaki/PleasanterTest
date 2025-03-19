namespace PleasanterTest.Libraries.Utilities
{
    [TestClass]
    public class TestDecimals
    {
        private static void M(decimal input) => Assert.AreEqual(input.ToString("G29"), Implem.Libraries.Utilities.Decimals.TrimEndZero(input));
        private static void M(decimal? input) => Assert.AreEqual(input?.ToString("G29") ?? "0", Implem.Libraries.Utilities.Decimals.TrimEndZero(input));

        [TestMethod]
        public void TrimEndZero_ShouldReturnZero_WhenInputIsZero() => M(0m);
        [TestMethod]
        public void TrimEndZero_ShouldReturnSameNumber_WhenInputHasNoTrailingZeros() => M(123.45m);
        [TestMethod]
        public void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputHasTrailingZeros() => M(123.4500m);
        [TestMethod]
        public void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputHasTrailingZeros29() => M(9.999_000_000_000_000_000_000_000_000m);
        [TestMethod]
        public void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputIsNull() => M(null);
    }
}