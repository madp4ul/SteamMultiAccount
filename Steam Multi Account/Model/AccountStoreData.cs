using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Multi_Account.Model
{
    public class AccountStoreData
    {
        private const string PROOF_PHRASE = "decrypted";
        [JsonProperty]
        public List<Login> Accounts { get; set; }
        [JsonProperty]
        private string DecryptionProof { get; set; }

        public AccountStoreData(IEnumerable<Login> logins = null)
        {
            Accounts = logins?.ToList() ?? new List<Login>();
        }

        public bool IsPasswordCorrect(string password)
        {
            string decrypted;

            return StringCipher.TryDecrypt(DecryptionProof, password, out decrypted) && decrypted == PROOF_PHRASE;
        }

        public static AccountStoreData Create(Login[] logins, string password)
        {
            var data = new AccountStoreData(logins);
            data.DecryptionProof = StringCipher.Encrypt(PROOF_PHRASE, password);
            return data;
        }

        public static AccountStoreData Restore(Login[] logins, string encryptedProof)
        {
            var data = new AccountStoreData(logins);
            data.DecryptionProof = encryptedProof;
            return data;
        }
    }
}
