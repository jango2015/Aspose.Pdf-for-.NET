using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using System.Collections;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions
{
    public class ExtractLinks
    {
        public static void Run()
        {
            // ExStart:ExtractLinks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();
            // Open document
            Document document = new Document(dataDir+ "ExtractLinks.pdf");
            // Extract actions
            Page page = document.Pages[1];
            AnnotationSelector selector = new AnnotationSelector(new LinkAnnotation(page, Aspose.Pdf.Rectangle.Trivial));
            page.Accept(selector);
            IList list = selector.Selected;
            Annotation annotation = (Annotation)list[0];
            dataDir = dataDir + "ExtractLinks_out_.pdf";
            // Save updated document
            document.Save(dataDir);
            // ExEnd:ExtractLinks
            Console.WriteLine("\nLinks extracted successfully.\nFile saved at " + dataDir);
            
        }
    }
}