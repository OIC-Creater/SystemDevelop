
using System.Security.Cryptography;


namespace SystemDevelop.Model
{
    class KeyContainer
    {
        private void CreateKey(string keyContainerName)
        {
            //新規鍵の設定
            int size = 1024;
            CspParameters parameters = new CspParameters()
            {
                KeyContainerName = keyContainerName
            };

            // 新規鍵の生成
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(size, parameters);
            //公開鍵をXMLで取得
            string publickey = csp.ToXmlString(false);
            //秘密鍵をXMLで取得
            string privateKey = csp.ToXmlString(true);

        }
        private void DeleteKey(string keyContainerName)
        {
            //コンテナー名の指定
            CspParameters parameters = new CspParameters()
            {
                KeyContainerName = keyContainerName
            };

            //キーコンテナーから鍵を削除
            using (RSACryptoServiceProvider csp = new RSACryptoServiceProvider(parameters))
            {
                csp.PersistKeyInCsp = false;
                csp.Clear();

            }


        }
  
    }

}
