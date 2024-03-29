﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace CIDFares.Library.Code.Extensions
{
    public static class ComprimirImagenExtensions
    {
        public static Image VaryQualityLevel(this Image image, long value)
        {
            using (Bitmap bmp1 = new Bitmap(image))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(GetImageFormat(image));
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, value);
                myEncoderParameters.Param[0] = myEncoderParameter;
                MemoryStream ms = new MemoryStream();
                bmp1.Save(ms, jpgEncoder, myEncoderParameters);
                return Image.FromStream(ms);
            }
        }

        public static Image VaryQualityLevel(this Bitmap image, long value)
        {
            try
            {
                using (image)
                {
                    ImageCodecInfo jpgEncoder = GetEncoder(GetImageFormat(image));
                    System.Drawing.Imaging.Encoder myEncoder =
                        System.Drawing.Imaging.Encoder.Quality;
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);

                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, value);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, jpgEncoder, myEncoderParameters);
                    return Image.FromStream(ms);
                }
            }
            catch (Exception EX)
            {

                throw EX;
            }
        }

        public static ImageCodecInfo GetEncoder(this ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public static ImageFormat GetImageFormat(this Image img)
        {
            using (img)
            {
                return img.RawFormat;
            }
        }

        public static ImageFormat GetImageFormat(this Bitmap img)
        {
            using (img)
            {
                return img.RawFormat;
            }
        }

        public static Bitmap SaveJpeg(string path, Image img, int quality, bool Guardar)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, quality);
            // JPEG image codec 
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            if (Guardar)
                img.Save(path, jpegCodec, encoderParams);
            return new Bitmap(img);
        }

        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }

        public static string ToBase64String(this Bitmap bmp, ImageFormat imageFormat)
        {
            string base64String = string.Empty;

            MemoryStream memoryStream = new MemoryStream();
            bmp.Save(memoryStream, imageFormat);

            memoryStream.Position = 0;
            byte[] byteBuffer = memoryStream.ToArray();

            memoryStream.Close();

            base64String = Convert.ToBase64String(byteBuffer);
            byteBuffer = null;

            return base64String;
        }

        public static string ToBase64String(this Image bmp, ImageFormat imageFormat)
        {
            string base64String = string.Empty;

            MemoryStream memoryStream = new MemoryStream();
            bmp.Save(memoryStream, imageFormat);

            memoryStream.Position = 0;
            byte[] byteBuffer = memoryStream.ToArray();

            memoryStream.Close();

            base64String = Convert.ToBase64String(byteBuffer);
            byteBuffer = null;

            return base64String;
        }

        public static Image ImageBase64ToImage(this string imageBase64)
        {
            byte[] bytes = Convert.FromBase64String(imageBase64);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }
    }
}
