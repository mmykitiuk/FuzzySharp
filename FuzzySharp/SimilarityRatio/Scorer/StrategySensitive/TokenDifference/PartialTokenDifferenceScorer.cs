using System;
using FuzzySharp.SimilarityRatio.Strategy.Generic;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenDifferenceScorer : TokenDifferenceScorerBase
    {
        protected override Func<string[], string[], double> Scorer => PartialRatioStrategy<string>.Calculate;
    }
}
