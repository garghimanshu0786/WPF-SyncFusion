using CsvHelper.Configuration;
using System;

namespace SyncFusion.Models
{
    public class Model
    {
        public DateTime Date { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public float Open { get; set; }
        public float Close { get; set; }
    }

    public class ModelClassMap : ClassMap<Model>
    {
        public ModelClassMap()
        {
            _ = Map(m => m.Date).Name(" DATE1");
            _ = Map(m => m.High).Name(" HIGH_PRICE");
            _ = Map(m => m.Low).Name(" LOW_PRICE");
            _ = Map(m => m.Open).Name(" OPEN_PRICE");
            _ = Map(m => m.Close).Name(" CLOSE_PRICE");
        }
    }

}
