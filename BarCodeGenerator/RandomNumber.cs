using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
namespace BarCodeGenerator
{
    class RandomNumber
    {
        public string GenerateRandom()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 10000000;
            return String.Format("{0:D7}",random);
        }

        public void SaveRandomNumbers(DataTable dt)
        {
            dt = new DataTable();
            dt.Columns.Add("Number", typeof(string));
        }
        public void AddRandomNumbers(DataTable dt,string value)
        {
            dt = new DataTable();
            dt.Rows.Add(value);
        }
    }
}
