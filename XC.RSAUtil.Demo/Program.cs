using System;
using XC.RSAUtil;
using System.Text.Json;
using System.Text;
using System.Security.Cryptography;

namespace XC.RSAUtil.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成密钥
            var key = RsaKeyGenerator.Pkcs1Key(1024, false);

            string privateKey = key[0];

            string publicKey = key[1];

            //数据
            string data = JsonSerializer.Serialize(new { userCode = "100" });

            Console.WriteLine($"原始内容:{data}");
            Console.WriteLine();

            //RSA公钥加密 
            var util = new RsaPkcs1Util(Encoding.UTF8, publicKey, null, 1024);

            string encryptData = util.Encrypt(data, RSAEncryptionPadding.Pkcs1);

            Console.WriteLine($"加密内容:{encryptData}");
            Console.WriteLine();

            //RSA私钥解密
            var util2 = new RsaPkcs1Util(Encoding.UTF8, null, privateKey, 1024);

            string decryptData = util2.Decrypt(encryptData, RSAEncryptionPadding.Pkcs1);

            Console.WriteLine($"解密内容:{decryptData}");
            Console.WriteLine();

            //RSA私钥签名

            var signData = util2.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            Console.WriteLine($"签名内容:{signData}");
            Console.WriteLine();

            //RSA公钥验签
            var verifyResult = util.VerifyData(data, signData, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            Console.WriteLine($"验证结果:{verifyResult}");
            Console.WriteLine();
        }



    }






}
