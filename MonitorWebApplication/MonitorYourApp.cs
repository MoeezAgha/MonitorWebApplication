using System.Diagnostics;

namespace MonitorWebApplication
{
    public class MonitorYourApp
    {

        public static SiteResponse CheckSite(string url)
        {

            var result = new SiteResponse();

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var client = new HttpClient();
            try
            {
                var checkResponse = client.GetAsync(url).Result;

                result.status = checkResponse.IsSuccessStatusCode && checkResponse.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {
                result.status = false;
                //offline
            }

            stopWatch.Stop();
            var elapsed = stopWatch.ElapsedMilliseconds;
            result.responseTime = elapsed;
            return result;
        }


    }
}
