using System;
using App.Metrics;
using App.Metrics.Timer;

namespace AppMetricsTest
{
    public static class MetricsLibrary
    {
        public static TimerOptions FooProcessTimer => new TimerOptions
        {
            Context = "AppMetricsTest",
            DurationUnit = TimeUnit.Milliseconds,
            MeasurementUnit = Unit.Calls,
            Name = "Processing Foo",
            RateUnit = TimeUnit.Seconds
        };
    }
}