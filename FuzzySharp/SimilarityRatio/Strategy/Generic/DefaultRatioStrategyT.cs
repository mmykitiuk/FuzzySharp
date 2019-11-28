using System;

namespace FuzzySharp.SimilarityRatio.Strategy.Generic
{
    internal class DefaultRatioStrategy<T> where T : IEquatable<T>
    {
        public static double Calculate(T[] input1, T[] input2)
        {
            return (double) Math.Round(100 * Levenshtein.GetRatio(input1, input2));
        }
    }
}
