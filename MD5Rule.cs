using System;
using System.Security.Cryptography;

namespace Inharitance_task_2
{
    public class MD5Rule : IHashRule
    {
        public byte[] GetHash(byte[] input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            MD5 md5 = MD5.Create();
            return md5.ComputeHash(input);
        }
    }
}
