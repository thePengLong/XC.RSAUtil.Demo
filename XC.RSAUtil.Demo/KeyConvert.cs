using System;
using System.Collections.Generic;
using System.Text;
using XC.RSAUtil;

namespace XC.RSAUtil.Demo
{
    /// <summary>
    /// RsaKeyConvert 用来做xml，pkcs1，pkcs8密钥的转化
    /// </summary>
    public static class KeyConvert
    {
        /// <summary>
        /// xml转成pkcs1
        /// </summary>
        public static void XmlToPkcs1()
        {
            //生成xml密钥
            var keyList = RsaKeyGenerator.XmlKey(1024);

            var xmlPrivateKey = keyList[0];

            var xmlPublicKey = keyList[1];

            //xml私钥转pkcs1私钥
            var pkcs1PrivateKey = RsaKeyConvert.PrivateKeyXmlToPkcs1(xmlPrivateKey);
            //xml公钥转pkcs1公钥
            var pkcs1PublicKey= RsaKeyConvert.PublicKeyXmlToPem(xmlPublicKey);
        }

        /// <summary>
        /// xml转成pkcs8
        /// </summary>
        public static void XmlToPkcs8()
        {
            //生成xml密钥
            var keyList = RsaKeyGenerator.XmlKey(1024);

            var xmlPrivateKey = keyList[0];

            var xmlPublicKey = keyList[1];

            //xml私钥转pkcs8私钥
            var pkcs1PrivateKey = RsaKeyConvert.PrivateKeyXmlToPkcs8(xmlPrivateKey);
            //xml公钥转pkcs8公钥
            var pkcs1PublicKey = RsaKeyConvert.PublicKeyXmlToPem(xmlPublicKey);
        }

        /// <summary>
        /// pkcs1转成xml
        /// </summary>
        public static void Pkcs1ToXml()
        {
            //生成pkcs1密钥
            var keyList = RsaKeyGenerator.Pkcs1Key(1024,false);

            var pkcs1PrivateKey = keyList[0];

            var pkcs1PublicKey = keyList[1];
            //pkcs1私钥转xml私钥
            var xmlPrivateKey = RsaKeyConvert.PrivateKeyPkcs1ToXml(pkcs1PrivateKey);
            //pkcs1公钥转xml公钥
            var xmlPublicKey = RsaKeyConvert.PublicKeyPemToXml(pkcs1PublicKey);
        }

        /// <summary>
        /// pkcs1转成pkcs8
        /// </summary>
        public static void Pkcs1ToPkcs8()
        {
            //生成pkcs1密钥
            var keyList = RsaKeyGenerator.Pkcs1Key(1024, false);

            var pkcs1PrivateKey = keyList[0];

            var pkcs1PublicKey = keyList[1];

            //pkcs1密钥转pkcs8公钥
            var pkcs8PrivateKey = RsaKeyConvert.PrivateKeyPkcs1ToPkcs8(pkcs1PrivateKey);
            //pkcs1到pkcs8不用转公钥
            
        }

        /// <summary>
        /// pkcs8转成xml
        /// </summary>
        public static void Pkcs8ToXml()
        {
            //生成pkcs8密钥
            var keyList = RsaKeyGenerator.Pkcs8Key(1024, false);

            var pkcs8PrivateKey = keyList[0];

            var pkcs8PublicKey = keyList[1];
            //pkcs8私钥转xml私钥
            var xmlPrivateKey = RsaKeyConvert.PrivateKeyPkcs8ToXml(pkcs8PrivateKey);
            //pkcs8公钥转xml公钥
            var xmlPublicKey = RsaKeyConvert.PublicKeyPemToXml(pkcs8PublicKey);
        }

        /// <summary>
        /// pkcs8转成pkcs1
        /// </summary>
        public static void Pkcs8ToPkcs1()
        {
            //生成pkcs1密钥
            var keyList = RsaKeyGenerator.Pkcs8Key(1024, false);

            var pkcs8PrivateKey = keyList[0];

            var pkcs8PublicKey = keyList[1];

            //pkcs1密钥转xml公钥
            var pkcs1PrivateKey = RsaKeyConvert.PrivateKeyPkcs8ToPkcs1(pkcs8PrivateKey);
            //pkcs1到pkcs8不用转公钥

        }
    }
}
