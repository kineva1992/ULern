using System.Collections.Generic;

namespace StructBenchmarking
{
    public class Experiments
    {
        public static ChartData BuildChartDataForArrayCreation(
            IBenchmark benchmark, int repetitionsCount)
        {
            return BildingCharDataForClasses(benchmark, repetitionsCount, false, "Create array");
        }

        public static ChartData BuildChartDataForMethodCall(
            IBenchmark benchmark, int repetitionsCount)
        {
            return BildingCharDataForClasses(benchmark, repetitionsCount, true, "Call method with argument");
        }
        public static ChartData BildingCharDataForClasses(IBenchmark benchmark, int repetitionsCount, bool isMethodCaller, string titleName)
        {
            var classesTimes = new List<ExperimentResult>();
            var structuresTimes = new List<ExperimentResult>();

            foreach (var size in Constants.FieldCounts)
            {
                var method = new CompariableMethods(size, isMethodCaller);
                classesTimes.Add(new ExperimentResult(size, benchmark.MeasureDurationInMs(method.Classes, repetitionsCount)));
                structuresTimes.Add(new ExperimentResult(size, benchmark.MeasureDurationInMs(method.Struktures, repetitionsCount)));
            }

            return new ChartData
            {
                Title = titleName,
                ClassPoints = classesTimes,
                StructPoints = structuresTimes

            };
        }

        //public static ChartData BuildChartDataForMethodCall(
        //    IBenchmark benchmark, int repetitionsCount)
        //{
        //    var classesTimes = new List<ExperimentResult>();
        //    var structuresTimes = new List<ExperimentResult>();
            
        //    //...

        //    return new ChartData
        //    {
        //        Title = "Call method with argument",
        //        ClassPoints = classesTimes,
        //        StructPoints = structuresTimes,
        //    };
        //}

        
    }

    public class CompariableMethods
    { 
    public ITask Classes { get; set; }
    public ITask Struktures { get; set; }

        public CompariableMethods(int size, bool isMethodCaller)
        {
            if (isMethodCaller)
            {
                Classes = new MethodCallWithClassArgumentTask(size);
                Struktures = new MethodCallWithStructArgumentTask(size);
            }

            else
            {
                Classes = new ClassArrayCreationTask(size);
                Struktures = new StructArrayCreationTask(size);
            }
        }
    }
}