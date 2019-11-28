using FuzzySharp.PreProcess;

namespace FuzzySharp.SimilarityRatio.Scorer
{
    public interface IRatioScorer
    {
        double Score(string input1, string input2);
        double Score(string input1, string input2, PreprocessMode preprocessMode);
    }
}
