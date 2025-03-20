using BenchmarkDotNet.Running;
using RkSoftware.TinyBenchmark.Formatters;
using RkSoftware.TinyBenchmark.Runners;
using System.Diagnostics;


var sw = Stopwatch.StartNew();
//var _ = BenchmarkRunner.Run<PleasanterBenchmark.Libraries.Utilities.BenchmarkDecimals>();
var results = TinyBenchmarkRunner.Run<PleasanterBenchmark.Libraries.Utilities.BenchmarkDecimals>();
sw.Stop();
Console.WriteLine($"TotalSeconds: {sw.Elapsed.TotalSeconds} -");
Console.WriteLine();

TinyBenchmarkFormatter.Write(results, System.Console.WriteLine);