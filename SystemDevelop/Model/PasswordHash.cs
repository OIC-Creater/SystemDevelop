using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SystemDevelop.Model
{
    /// <summary>
    /// passwordをハッシュ化するためのクラス
    /// </summary>
    public class PasswordHash
    {
        //hash用のprovider
        static readonly SHA256CryptoServiceProvider hashProvider = new SHA256CryptoServiceProvider();

        //passwordをハッシュ化する
        public string Hash(string password)
        {
            return string.Join("", hashProvider.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => $"{x:x2}"));
        }
    }
}
