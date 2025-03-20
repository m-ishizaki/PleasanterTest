using BenchmarkDotNet.Attributes;
using RkSoftware.TinyBenchmark.Attributes;

namespace PleasanterBenchmark.Libraries.Utilities
{
    public class BenchmarkDecimals
    {
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnZero_WhenInputIsZero() => Implem.Libraries.Utilities.Decimals.TrimEndZero(0m);
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnZero_WhenInputIsZero_G29() => M(0m);

        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnSameNumber_WhenInputHasNoTrailingZeros() => Implem.Libraries.Utilities.Decimals.TrimEndZero(123.45m);
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnSameNumber_WhenInputHasNoTrailingZeros_G29() => M(123.45m);

        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputHasTrailingZeros() => Implem.Libraries.Utilities.Decimals.TrimEndZero(123.4500m);
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputHasTrailingZeros_G29() => M(123.4500m);

        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputHasTrailingZeros29() => Implem.Libraries.Utilities.Decimals.TrimEndZero(9.999_000_000_000_000_000_000_000_000m);
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputHasTrailingZeros29_G29() => M(9.999_000_000_000_000_000_000_000_000m);

        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputIsNull() => Implem.Libraries.Utilities.Decimals.TrimEndZero(null);
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputIsNull_G29() => M(null);

        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputAllowNullIsZero() => Implem.Libraries.Utilities.Decimals.TrimEndZero((decimal?)0m);
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputAllowNullIsZero_G29() => M((decimal?)0m);

        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputAllowNullHasTrailingZeros() => Implem.Libraries.Utilities.Decimals.TrimEndZero((decimal?)123.4500m);
        [TinyBenchmark]
        [Benchmark]
        public static void TrimEndZero_ShouldReturnTrimmedNumber_WhenInputAllowNullHasTrailingZeros_G29() => M((decimal?)123.4500m);


        private static string M(decimal input) => input.ToString("G29");
        private static string M(decimal? input) => input?.ToString("G29") ?? "0";

    }
}
