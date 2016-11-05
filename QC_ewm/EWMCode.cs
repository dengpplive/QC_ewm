using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace EWMCode
{
    public class EWMCode
    {
        public static Bitmap ToQRCode(string strText, string filename)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            qrCodeEncoder.QRCodeVersion = 7;
            qrCodeEncoder.QRCodeScale = 4;
            //生成图像
            return qrCodeEncoder.Encode(strText, Encoding.Default);
        }

        public static string FromQRCode(Bitmap img)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            String decodedString = decoder.decode(new QRCodeBitmapImage(img), Encoding.Default);
            return decodedString;
        }
    }
}
