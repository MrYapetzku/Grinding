using System.Security.Cryptography;

namespace Inharitance_task_2
{
    public class SHA1Rule : IHashRule
    {
        public byte[] GetHash(byte[] input)
        {
            SHA1 sha1 = SHA1.Create();
            return sha1.ComputeHash(input);
        }
    }
}
