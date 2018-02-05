﻿using Jil;

namespace Raygun.Druid4Net
{
  internal class TopNRequest : IDruidRequest<TopNRequestData>
  {
    public TopNRequestData RequestData { get; private set; }

    public string Body { get; private set; }

    public void Build<TQueryType>(TQueryType queryDescriptor) where TQueryType : ITopNQueryDescriptor
    {
      var qd = queryDescriptor as TopNQueryDescriptor;

      RequestData = new TopNRequestData(qd.QueryType, qd.DataSourceValue, qd.DimensionValue, qd.MetricSpecValue, qd.GranularityValue, qd.ThresholdValue, qd.IntervalsValue, qd.FilterValue, qd.AggregationSpecsValue, qd.PostAggregationSpecsValue, qd.ContextValue);

      Body = JSON.SerializeDynamic(RequestData);
    }
  }
}
