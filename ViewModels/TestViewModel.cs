using CsvHelper;
using SyncFusion.Models;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SyncFusion.ViewModels
{
    public class TestViewModel
    {
        public TestViewModel()
        {
            using CsvReader csvReader = new(new StreamReader(@"C:\Users\himanshugarg\Desktop\Data1.csv"), CultureInfo.InvariantCulture);
            _ = csvReader.Context.RegisterClassMap<ModelClassMap>();
            StockPriceDetails = new ObservableCollection<Model>(csvReader.GetRecords<Model>().ToList());
        }

        public ObservableCollection<Model> StockPriceDetails { get; set; }

    }
}
