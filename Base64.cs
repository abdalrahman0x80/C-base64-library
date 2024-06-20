using System;
using System.Text;
namespace Base64
{
    class EncodingAndDecoding
    {
        public string encode(string e)
        {
            byte[] encoder = Encoding.UTF8.GetBytes(e);
            string Converter = Convert.ToBase64String(encoder);
            return Converter;
        }
        public string decode(string e)
        {
            var base64 = Convert.FromBase64String(e);
            string GetString = Encoding.UTF8.GetString(base64);
            return GetString;


        }
    }
}