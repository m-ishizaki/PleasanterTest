using BenchmarkDotNet.Running;
using RkSoftware.TinyBenchmark.Formatters;
using RkSoftware.TinyBenchmark.Runners;
using System.Diagnostics;


var sw = Stopwatch.StartNew();
//var _ = BenchmarkRunner.Run<PleasanterBenchmark.Libraries.Utilities.BenchmarkDecimals>();
var results1 = TinyBenchmarkRunner.Run<PleasanterBenchmark.Libraries.Utilities.BenchmarkDecimals>();
var results2 = TinyBenchmarkRunner.Run<PleasanterBenchmark.Libraries.Utilities.RegexesBenchmark>();
sw.Stop();
Console.WriteLine($"TotalSeconds: {sw.Elapsed.TotalSeconds} -");
Console.WriteLine();

TinyBenchmarkFormatter.Write(results1, System.Console.WriteLine);
TinyBenchmarkFormatter.Write(results2, System.Console.WriteLine);
