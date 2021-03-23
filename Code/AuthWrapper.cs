using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestIdeas
{
    public class AuthWrapper
    {
        /// <summary>
        /// MDS tenant id.
        /// </summary>
        private static readonly string MDSTenant = "cdc5aeea-15c5-4db6-b079-fcadd2505dc2";

        /// <summary>
        /// MDS client id.
        /// </summary>
        private static readonly string ApplicationId = "72747f78-e00e-4971-981b-8a3e136bef94";

        /// <summary>
        /// MDS resource id.
        /// </summary>
        private static readonly string MDSResourceId = "3e9313d0-debc-4f0d-85a7-171f92333ba1";

        public async Task<string> GetMDSToken()
        {
            var authorityUrl = $"https://login.microsoftonline.com/{MDSTenant}";
            var authenticationContext = new AuthenticationContext(authorityUrl);

            var certs = GetPassThroughCertificates();
            var creds = new ClientAssertionCertificate(ApplicationId, certs[0]);
            var result = await authenticationContext.AcquireTokenAsync(MDSResourceId, creds).ConfigureAwait(false);
            return result.AccessToken;
        }

        public async Task<string>

        private static IReadOnlyList<X509Certificate2> GetPassThroughCertificates()
        {
            var certificateFiles = Directory.GetFiles(@"PassThroughCertificates", "*.pfx", SearchOption.TopDirectoryOnly);
            var passThroughCerts = new List<X509Certificate2>(certificateFiles.Length);

            foreach (var pfxFile in certificateFiles)
            {
                var passPhraseFile = pfxFile.Replace("pfx", "txt");
                passThroughCerts.Add(new X509Certificate2(File.ReadAllBytes(pfxFile), File.ReadAllText(passPhraseFile)));
            }

            return passThroughCerts;
        }

    }
}
