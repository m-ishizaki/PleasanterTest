namespace PleasanterTest.Libraries.Utilities
{
    [TestClass]
    public class TestDecimals
    {
        private static void M1(decimal input) => Assert.AreEqual(input.ToString("G29"), Implem.Libraries.Utilities.Decimals.TrimEndZero(input));
        private static void M2(decimal? input) => Assert.AreEqual(input?.ToString("G29") ?? "0", Implem.Libraries.Utilities.Decimals.TrimEndZero(input));

        [TestMethod]
        public void TrimEndZero_NotNullable_WhenInputIsZero() => M1(0m);
        [TestMethod]
        public void TrimEndZero_NotNullable_WhenInputHasNoTrailingZeros() => M1(123.45m);
        [TestMethod]
        public void TrimEndZero_NotNullable_WhenInputHasTrailingZeros() => M1(123.4500m);
        [TestMethod]
        public void TrimEndZero_NotNullable_WhenInputHasTrailingZeros29() => M1(9.999_000_000_000_000_000_000_000_000m);
        [TestMethod]
        public void TrimEndZero_Nullable_WhenInputIsZero() => M2(0m);
        [TestMethod]
        public void TrimEndZero_Nullable_WhenInputHasNoTrailingZeros() => M2(123.45m);
        [TestMethod]
        public void TrimEndZero_Nullable_WhenInputHasTrailingZeros() => M2(123.4500m);
        [TestMethod]
        public void TrimEndZero_Nullable_WhenInputHasTrailingZeros29() => M2(9.999_000_000_000_000_000_000_000_000m);
        [TestMethod]
        public void TrimEndZero_Nullable_WhenInputIsNull() => M2(null);
    }
}