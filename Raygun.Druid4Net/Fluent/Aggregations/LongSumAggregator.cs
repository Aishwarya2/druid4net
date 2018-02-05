﻿namespace Raygun.Druid4Net
{
  public class LongSumAggregator : SumAggregator
  {
    public override string Type => "longSum";

    public LongSumAggregator(string name, string fieldName) 
      : base (name, fieldName)
    {
    }
  }
}