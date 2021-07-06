using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProccessing
{
    static class ImageProc
    {
        public static byte[] Bitmap32ToByteArray(this Bitmap srcBmp)
        {
            var bmp = new Bitmap(srcBmp);

            BitmapData bmpData =
                bmp.LockBits
                (
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite,
                    PixelFormat.Format32bppArgb
                );

            int wdh = bmp.Width;
            int hgt = bmp.Height;
            int pixSize = wdh * hgt * 4; // 32bitARGB

            // bitmapデータ先頭アドレス
            IntPtr ptr = bmpData.Scan0;

            byte[] pixArray = new byte[pixSize]; // 入力用配列

            // Bitmapデータをソース配列へコピー
            // （コピー元アドレス、コピー先配列、コピー先配列先頭、コピー要素数）
            Marshal.Copy(ptr, pixArray, 0, pixSize);

            bmp.UnlockBits(bmpData);

            bmp.Dispose();

            return pixArray;

        }

        public static void ByteArrayToBitmap32(this byte[] pixArray, ref Bitmap dstBmp)
        {
            Rectangle rect = new Rectangle(0, 0, dstBmp.Width, dstBmp.Height);
            BitmapData bmpData =
                dstBmp.LockBits(rect, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb
                );

            // Bitmapの先頭アドレスを取得
            IntPtr ptr = bmpData.Scan0;

            // Bitmapへコピー
            Marshal.Copy(pixArray, 0, ptr, pixArray.Length);

            dstBmp.UnlockBits(bmpData);
        }

        public static Bitmap Thresholding(this Bitmap srcBmp, byte threshold)
        {
            /*** 1. Bitmap => ByteArray化 ***/
            byte[] srcArray = srcBmp.Bitmap32ToByteArray();

            /*** 2. 画像処理 ***/
            int wdh = srcBmp.Width;
            int hgt = srcBmp.Height;
            int stride = wdh * 4;
            int pixSize = wdh * hgt * 4; // 32bitARGB

            byte[] dstArray = new byte[pixSize]; // 出力用配列

            byte thresValue;

            // デスト配列に書き込み
            for (int y = 0; y < hgt; y++)
            {
                for (int x = 0; x < wdh; x++)
                {
                    int index = y * stride + 4 * x;

                    byte B = srcArray[index + 0];
                    byte G = srcArray[index + 1];
                    byte R = srcArray[index + 2];
                    byte A = srcArray[index + 3];

                    var p = (R + G + B) / 3;

                    if (p <= threshold)
                        thresValue = 255;
                    else
                        thresValue = 0;

                    dstArray[index + 0] = thresValue;
                    dstArray[index + 1] = thresValue;
                    dstArray[index + 2] = thresValue;
                    dstArray[index + 3] = A;
                }
            }

            /*** 3. ByteArray => Bitmap化 ***/
            var dstBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
            ByteArrayToBitmap32(dstArray, ref dstBmp);

            return dstBmp;
        }

        public static Bitmap AlphaChannel(this Bitmap srcBmp, byte alphaValue)
        {
            /*** 1. Bitmap => ByteArray化 ***/
            byte[] srcArray = srcBmp.Bitmap32ToByteArray();

            /*** 2. 画像処理 ***/
            int wdh = srcBmp.Width;
            int hgt = srcBmp.Height;
            int stride = wdh * 4;
            int pixSize = wdh * hgt * 4; // 32bitARGB

            byte[] dstArray = new byte[pixSize]; // 出力用配列

            byte thresValue;

            // デスト配列に書き込み
            for (int y = 0; y < hgt; y++)
            {
                for (int x = 0; x < wdh; x++)
                {
                    int index = y * stride + 4 * x;

                    dstArray[index + 0] = srcArray[index + 0];
                    dstArray[index + 1] = srcArray[index + 1];
                    dstArray[index + 2] = srcArray[index + 2];
                    dstArray[index + 3] = alphaValue;

                }
            }

            /*** 3. ByteArray => Bitmap化 ***/
            var dstBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
            ByteArrayToBitmap32(dstArray, ref dstBmp);

            return dstBmp;
        }

        public static Bitmap GrayScale(this Bitmap srcBmp, GrayScaleFilter grayScaleKind)
        {
            /*** 1. Bitmap => ByteArray化 ***/
            byte[] srcArray = srcBmp.Bitmap32ToByteArray();

            /*** 2. 画像処理 ***/
            int wdh = srcBmp.Width;
            int hgt = srcBmp.Height;
            int stride = wdh * 4;
            int pixSize = wdh * hgt * 4; // 32bitARGB

            byte[] dstArray = new byte[pixSize]; // 出力用配列

            // デスト配列に書き込み
            for (int y = 0; y < hgt; y++)
            {
                for (int x = 0; x < wdh; x++)
                {
                    int index = y * stride + 4 * x;

                    byte B = srcArray[index + 0];
                    byte G = srcArray[index + 1];
                    byte R = srcArray[index + 2];
                    byte A = srcArray[index + 3];

                    var grayValue = 0;
                    switch (grayScaleKind)
                    {
                        case GrayScaleFilter.R:
                            grayValue = R;
                            break;
                        case GrayScaleFilter.G:
                            grayValue = G;
                            break;
                        case GrayScaleFilter.B:
                            grayValue = B;
                            break;
                        case GrayScaleFilter.C:
                            grayValue = 255 - R;
                            break;
                        case GrayScaleFilter.M:
                            grayValue = 255 - G;
                            break;
                        case GrayScaleFilter.Y:
                            grayValue = 255 - B;
                            break;
                    }

                    dstArray[index + 0] = (byte)grayValue;
                    dstArray[index + 1] = (byte)grayValue;
                    dstArray[index + 2] = (byte)grayValue;
                    dstArray[index + 3] = A;

                }
            }

            /*** 3. ByteArray => Bitmap化 ***/
            var dstBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
            ByteArrayToBitmap32(dstArray, ref dstBmp);

            return dstBmp;
        }

        public static Bitmap Contrast(this Bitmap srcBmp, decimal amount, byte threshold)
        {
            /*** 1. Bitmap => ByteArray化 ***/
            byte[] srcArray = srcBmp.Bitmap32ToByteArray();

            /*** 2. 画像処理 ***/
            int wdh = srcBmp.Width;
            int hgt = srcBmp.Height;
            int stride = wdh * 4;
            int pixSize = wdh * hgt * 4; // 32bitARGB

            byte[] dstArray = new byte[pixSize]; // 出力用配列
            byte[] LUT = new byte[256]; //ルックアップテーブル


            // ルックアップテーブル作成
            for (int i = 0; i < LUT.Length; i++)
            {
                double e = (double)(amount * (-i + threshold));
                LUT[i] = (byte)(255 / (1 + Math.Exp(e)));
            }

            // デスト配列に書き込み
            for (int y = 0; y < hgt; y++)
            {
                for (int x = 0; x < wdh; x++)
                {
                    int index = y * stride + 4 * x;

                    byte B = srcArray[index + 0];
                    byte G = srcArray[index + 1];
                    byte R = srcArray[index + 2];
                    byte A = srcArray[index + 3];

                    dstArray[index + 0] = LUT[B];
                    dstArray[index + 1] = LUT[G];
                    dstArray[index + 2] = LUT[R];
                    dstArray[index + 3] = A;

                }
            }

            /*** 3. ByteArray => Bitmap化 ***/
            var dstBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
            ByteArrayToBitmap32(dstArray, ref dstBmp);

            return dstBmp;
        }

        public static Bitmap GammaCorrection(this Bitmap srcBmp, byte min, byte max, decimal gamma)
        {
            /*** 1. Bitmap => ByteArray化 ***/
            byte[] srcArray = srcBmp.Bitmap32ToByteArray();

            /*** 2. 画像処理 ***/
            int wdh = srcBmp.Width;
            int hgt = srcBmp.Height;
            int stride = wdh * 4;
            int pixSize = wdh * hgt * 4; // 32bitARGB

            byte[] dstArray = new byte[pixSize]; // 出力用配列
            byte[] LUT = new byte[256]; //ルックアップテーブル

            double b;
            double exp;
            double linear;

            // ルックアップテーブル作成
            for (int i = 0; i < LUT.Length; i++)
            {
                if (i < min)
                {
                    LUT[i] = 0;
                }
                else if (i > max)
                {
                    LUT[i] = 255;
                }
                else
                {
                    linear = (byte)(255 * (i - min) / (max - min));
                    b = linear / 255;
                    exp = 1 / (double)gamma;
                    LUT[i] = (byte)(255 * Math.Pow(b, exp));
                }
            }

            // デスト配列に書き込み
            for (int y = 0; y < hgt; y++)
            {
                for (int x = 0; x < wdh; x++)
                {
                    int index = y * stride + 4 * x;

                    byte B = srcArray[index + 0];
                    byte G = srcArray[index + 1];
                    byte R = srcArray[index + 2];
                    byte A = srcArray[index + 3];

                    dstArray[index + 0] = LUT[B];
                    dstArray[index + 1] = LUT[G];
                    dstArray[index + 2] = LUT[R];
                    dstArray[index + 3] = A;

                }
            }

            /*** 3. ByteArray => Bitmap化 ***/
            var dstBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
            ByteArrayToBitmap32(dstArray, ref dstBmp);

            return dstBmp;
        }

        /// <summary>
        /// ヒストグラム配列の作成
        /// <para>[, 0] = R頻度</para>
        /// <para>[, 1] = G頻度</para>
        /// <para>[, 2] = B頻度</para>
        /// </summary>
        /// <param name="srcBmp"></param>
        /// <returns></returns>
        public static int[][] CreateRgbHistgramArray(this Bitmap srcBmp)
        {
            /*** 1. Bitmap => ByteArray化 ***/
            byte[] srcPix = srcBmp.Bitmap32ToByteArray();

            int wdh = srcBmp.Width;
            int hgt = srcBmp.Height;
            int stride = wdh * 4;

            /*** 2. 処理 ***/
            // LUT: Look Up Table
            var LUT = new int[3][];
            LUT[0] = new int[256]; //R
            LUT[1] = new int[256]; //G
            LUT[2] = new int[256]; //B

            // RGB各輝度値の頻度を記録
            for (int y = 0; y < hgt; y++)
            {
                for (int x = 0; x < wdh; x++)
                {
                    int index = y * stride + 4 * x;

                    byte B = srcPix[index + 0];
                    byte G = srcPix[index + 1];
                    byte R = srcPix[index + 2];

                    LUT[0][R] += 1;
                    LUT[1][G] += 1;
                    LUT[2][B] += 1;
                }
            }

            return LUT;
        }
    }
}
