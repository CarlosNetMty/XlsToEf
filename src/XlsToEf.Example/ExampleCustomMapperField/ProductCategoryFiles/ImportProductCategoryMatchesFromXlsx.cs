using System.Threading.Tasks;
using MediatR;
using XlsToEf.Example.Domain;
using XlsToEf.Import;

namespace XlsToEf.Example.ExampleCustomMapperField.ProductCategoryFiles
{
    public class ImportProductCategoryMatchesFromXlsx : IAsyncRequestHandler<DataMatchesForImportingProductCategoryData, ImportResult>
    {
        private readonly XlsxToTableImporter _xlsxToTableImporter;

        public ImportProductCategoryMatchesFromXlsx(XlsxToTableImporter xlsxToTableImporter)
        {
            _xlsxToTableImporter = xlsxToTableImporter;
        }

        public async Task<ImportResult> Handle(DataMatchesForImportingProductCategoryData message)
        {
            return await _xlsxToTableImporter.ImportColumnData<ProductCategory>(message);
        }
    }
}