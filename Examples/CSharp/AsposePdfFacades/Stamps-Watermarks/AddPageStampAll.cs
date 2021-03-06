using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddPageStampAll
    {
        public static void Run()
        {
            // ExStart:AddPageStampAll
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            // Create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            // Open Document
            fileStamp.BindPdf(dataDir + "AddPageStampAll.pdf"); 

            // Create stamp
            Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();
            stamp.BindPdf(dataDir+ "temp.pdf", 1);
            stamp.SetOrigin(200, 200);
            stamp.Rotation = 90.0F;
            stamp.IsBackground = true;

            // Add stamp to PDF file
            fileStamp.AddStamp(stamp);

            // Save updated PDF file
            fileStamp.Save(dataDir + "AddPageStampAll_out_.pdf");

            // Close fileStamp
            fileStamp.Close();
            // ExEnd:AddPageStampAll
            
        }
    }
}