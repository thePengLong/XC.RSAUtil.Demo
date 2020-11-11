using System;
using System.Collections.Generic;
using System.Text;

namespace XC.RSAUtil.Demo
{
    /// <summary>
    /// RsaKeyGenerator 用来生成key
    /// </summary>
    public static class CreateKey
    {
        /// <summary>
        /// 生成Pkcs1格式的密钥
        /// </summary>
        /// <param name="keySize">密钥大小，一般为2048/1024</param>
        /// <param name="format">生成的密钥是否格式化，格式化为前加--BEGIN RSA PRIVATE KEY--END RSA PRIVATE KEY--</param>
        /// <returns></returns>
        public static Tuple<string, string> CreatePkcs1Key(int keySize = 1024, bool format = false)
        {
            var key = RsaKeyGenerator.Pkcs1Key(1024, true);

            string privateKey = key[0];

            string publicKey = key[1];

            return Tuple.Create(privateKey, publicKey);
        }

        /// <summary>
        /// 生成Pkcs8格式的密钥
        /// </summary>
        /// <returns></returns>
        public static Tuple<string, string> CreatePkcs8Key(int keySize = 1024, bool format = false)
        {
            var key = RsaKeyGenerator.Pkcs8Key(keySize, format);

            string privateKey = key[0];

            string publicKey = key[1];

            return Tuple.Create(privateKey, publicKey);
        }

        /// <summary>
        /// 生成Xml格式的密钥
        /// </summary>
        /// <returns></returns>
        public static Tuple<string, string> CreateXmlKeyKey(int keySize = 1024)
        {
            var key = RsaKeyGenerator.XmlKey(keySize);

            string privateKey = key[0];

            string publicKey = key[1];

            return Tuple.Create(privateKey, publicKey);
        }
    }
}
