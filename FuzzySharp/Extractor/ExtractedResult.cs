using System;
using System.Collections.Generic;

namespace FuzzySharp.Extractor
{
    public class ExtractedResult<T> : IComparable<ExtractedResult<T>> 
    {

        public readonly T Value;
        public readonly double Score;
        public readonly int Index;

        public ExtractedResult(T value, double score)
        {
            Value = value;
            Score = score;
        }

        public ExtractedResult(T value, double score, int index)
        {
            Value = value;
            Score = score;
            Index = index;
        }

        public int CompareTo(ExtractedResult<T> other)
        {
            return Comparer<double>.Default.Compare(this.Score, other.Score);
        }

        public override string ToString()
        {
            if (typeof(T) == typeof(string))
            {
                return $"(string: {Value}, score: {Score}, index: {Index})";
            }
            return $"(value: {Value.ToString()}, score: {Score}, index: {Index})";
        }
    }
}
