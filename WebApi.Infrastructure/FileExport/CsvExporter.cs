using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Application.Contracts.Infrastructure;
using WebApi.Application.Features.Events.Queries.GetEventList;

namespace WebApi.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using var streamWriter = new StreamWriter(memoryStream);

            // Create CsvConfiguration instance (you can configure it as needed)
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);

            // Use the configuration in CsvWriter constructor
            using var csvWriter = new CsvWriter(streamWriter, config);

            csvWriter.WriteRecords(eventExportDtos);

            streamWriter.Flush(); // Ensure all data is written to the MemoryStream

            return memoryStream.ToArray();
        }
    }

}
