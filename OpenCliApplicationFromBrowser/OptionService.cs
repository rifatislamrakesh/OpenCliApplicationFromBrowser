using System.Text.RegularExpressions;

namespace OpenCliApplicationFromBrowser
{
    public static class OptionService
    {
        public static void RunOptions(Options options)
        {
            if (options.Open && !string.IsNullOrEmpty(options.Invoice))
            {
                Console.WriteLine("Opening application with Invoice: " + ExtractInvoiceId(options.Invoice));
            }
            else if (options.Open)
            {
                Console.WriteLine("No Invoice found!");
            }
            else
            {
                Console.WriteLine("No valid commands!");
            }
        }

        private static string ExtractInvoiceId(string url)
        {
            const string pattern = "invoiceid=([A-Za-z0-9-]+)";

            Match match = Regex.Match(url, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return "";
        }
    }
}