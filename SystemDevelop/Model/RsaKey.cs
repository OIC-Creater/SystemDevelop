
using System.Security.Cryptography;

namespace SystemDevelop.Model
{
    class RsaKey
    {
        /// <summary>
        /// キーコンテナー名の指定して新規RSA鍵を生成
        /// </summary>
        /// <param name="keyContainerName">キーコンテナー</param>
        private void CreateKey(string keyContainerName)
        {
            //新規鍵の設定
            int size = 1024;
            CspParameters parameters = new CspParameters()
            {
                KeyContainerName = keyContainerName
            };
            //新規鍵の生成
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(size, parameters);
            //公開鍵をXMLで取得
            string publickkey = csp.ToXmlString(false);
            //秘密鍵をXMLで取得
            string privateKey = csp.ToXmlString(true);
        }
        /// <summary>
        /// キーコンテナー名を指定してRSA鍵の削除
        /// </summary>
        /// <param name="keyContainerName">キーコンテナー</param>
        private void DeleteKey(string keyContainerName)
        {
            CspParameters parameters = new CspParameters()
            {
                KeyContainerName = keyContainerName
            };
            using (var csp = new RSACryptoServiceProvider(parameters))
            {
                csp.PersistKeyInCsp = false;
                csp.Clear();
            }
        }
    }
}
