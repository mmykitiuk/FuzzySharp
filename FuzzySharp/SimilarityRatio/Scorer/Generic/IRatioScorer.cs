using System;

namespace FuzzySharp.SimilarityRatio.Scorer.Generic
{
    public interface IRatioScorer<in T> where T : IEquatable<T>
    {
        double Score(T[] input1, T[] input2);
    }
}
