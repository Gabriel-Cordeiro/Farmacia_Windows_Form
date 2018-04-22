using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Classes
{
    public static class auxiliar
    {

        public static string gerarDesconto(decimal? valorVenda, int? desconto)
        {
            decimal descontoValor = Convert.ToDecimal(desconto / 100.0);
            var valorComDesconto = valorVenda - (descontoValor * valorVenda);
            return valorComDesconto.ToString();
        }

        public static System.Drawing.Image ByteArrayToImage(byte[] bArray)
        {
            if (bArray == null)
                return null;

            System.Drawing.Image newImage;

            try
            {
                using (MemoryStream ms = new MemoryStream(bArray, 0, bArray.Length))
                {
                    ms.Write(bArray, 0, bArray.Length);
                    newImage = System.Drawing.Image.FromStream(ms, true);
                }
            }
            catch (Exception ex)
            {
                newImage = null;

                //Log an error here
            }

            return newImage;
        }
    }
}
