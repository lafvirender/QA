using System;
using System.Linq;
using HtmlAgilityPack;
using System.IO;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Reporting
{
    public class Reporter
    {
        private string _testName;

        public Reporter(string testName)
        {
            _testName = testName;
        }        

        public void ReportResult(VerificationInfo verifyInfo)
        {
            InsertResult(_testName, verifyInfo);
            TakeScreenshotIfFail();
        }

        private void InsertResult(string testName, VerificationInfo verifyInfo)
        {
            string filePath = CreateResultDirectoryAndFileIfNotExists();
            UpdateResultInFile(filePath, testName, verifyInfo);
        }

        private string CreateResultDirectoryAndFileIfNotExists()
        {
            String Todaysdate = DateTime.Now.ToString("dd-MMM-yyyy");
            string filePath = Directory.GetCurrentDirectory() + "\\" + Todaysdate + "\\" + "Results.html";
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + Todaysdate))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + Todaysdate);      
            }

            if (!File.Exists(filePath))
            {
                var resFile = File.Create(filePath);
                resFile.Close();
                CreateTemplateForResultInsertion(filePath);
            }
            return filePath;
        }

        public void CreateTemplateForResultInsertion(string filePath)
        {
            HtmlDocument resultFile = new HtmlDocument();
            resultFile.Load(filePath);
            HtmlNode htmlNode = resultFile.CreateElement("html");
            HtmlNode headNode = resultFile.CreateElement("head");
            HtmlNode bodyNode = resultFile.CreateElement("body");
            htmlNode.AppendChild(headNode);
            htmlNode.AppendChild(bodyNode);
            resultFile.DocumentNode.AppendChild(htmlNode);

            resultFile.DocumentNode.SelectSingleNode("//head").AppendChild(HtmlNode.CreateNode("<style></style>"));
            resultFile.DocumentNode.SelectSingleNode("//head/style").InnerHtml = HtmlDocument.HtmlEncode("table { width: 100 %; }" 
                                                                                                         + "table, th, td {border: 1px solid black; border-collapse: collapse; }"
                                                                                                         + "th, td { padding: 5px; text-align: left; }"
                                                                                                         + "table#Results tr:nth-child(even) { background-color: #eee;}"
                                                                                                         + "table#Results tr:nth-child(odd) { background-color:#fff;}"
                                                                                                         + "table#Results th {background-color: black; color: white;}");
            resultFile.DocumentNode.SelectSingleNode("//body").AppendChild(HtmlNode.CreateNode("<table></table>"));
            resultFile.DocumentNode.SelectSingleNode("//body/table").SetAttributeValue("id", "Results");
            resultFile.DocumentNode.SelectSingleNode("//body/table").AppendChild(HtmlNode.CreateNode("<tr></tr>"));
            resultFile.DocumentNode.SelectSingleNode("//body/table").FirstChild.AppendChild(HtmlNode.CreateNode("<th>TestName</th>"));
            resultFile.DocumentNode.SelectSingleNode("//body/table").FirstChild.AppendChild(HtmlNode.CreateNode("<th>Results</th>"));
            resultFile.DocumentNode.SelectSingleNode("//body/table").FirstChild.AppendChild(HtmlNode.CreateNode("<th>Actual</th>"));
            resultFile.DocumentNode.SelectSingleNode("//body/table").FirstChild.AppendChild(HtmlNode.CreateNode("<th>Expected</th>"));
            resultFile.DocumentNode.SelectSingleNode("//body/table").FirstChild.AppendChild(HtmlNode.CreateNode("<th>Comments</th>"));

            StreamWriter stWriter = new StreamWriter(filePath);
            resultFile.Save(stWriter);
            stWriter.Close();
        }

        private void UpdateResultInFile(string filePath, string testName, VerificationInfo verifyInfo)
        {
            HtmlDocument resultFile = new HtmlDocument();
            resultFile.Load(filePath);
            resultFile.GetElementbyId("Results").AppendChild(HtmlNode.CreateNode("<tr></tr>"));
            resultFile.GetElementbyId("Results").ChildNodes.Last().AppendChild(HtmlNode.CreateNode("<td>" + testName + "</td>"));
            resultFile.GetElementbyId("Results").ChildNodes.Last().AppendChild(HtmlNode.CreateNode("<td>" + verifyInfo.Result + "</td>"));
            resultFile.GetElementbyId("Results").ChildNodes.Last().AppendChild(HtmlNode.CreateNode("<td>" + verifyInfo.Actual + "</td>"));
            resultFile.GetElementbyId("Results").ChildNodes.Last().AppendChild(HtmlNode.CreateNode("<td>" + verifyInfo.Expected + "</td>"));
            resultFile.GetElementbyId("Results").ChildNodes.Last().AppendChild(HtmlNode.CreateNode("<td>" + verifyInfo.Message + "</td>"));

            StreamWriter stWriter = new StreamWriter(filePath);
            resultFile.Save(stWriter);
            stWriter.Close();
        }

        public void TakeScreenshotIfFail()
        {

        }
    }
}
