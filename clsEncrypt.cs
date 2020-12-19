using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

public class clsEncrypt
{
    public clsEncrypt()
    {
    }

    public string Ekrip(string TEKS)
    {
        //BASE 64
        byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(TEKS);
        string pass_64 = System.Convert.ToBase64String(plainTextBytes);
        //----------------------

        //MD5
        MD5 md5Hash = new MD5CryptoServiceProvider();
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pass_64));

        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        string pass_md5 = sBuilder.ToString().Substring(0, 20);
        //---------------------------

        return pass_md5;
    }

    public static string filterString(string PARAM)
    {
        Regex badCharReplace = new Regex(@"[<>"";*?$^|+#!=]");
        string goodChars = badCharReplace.Replace(PARAM, "").Replace("'", "''");

        string filteredStr = goodChars;
        return filteredStr;
    }
}