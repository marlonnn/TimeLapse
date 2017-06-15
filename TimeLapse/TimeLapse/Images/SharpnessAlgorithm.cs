using System;
using System.Collections.Generic;
using System.Linq;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Cuda;
using Emgu.CV.Structure;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TimeLapse.Images
{
    public class SharpnessAlgorithm
    {
        /// <summary>
        /// Tenengrad梯度方法利用Sobel算子分别计算水平和垂直方向的梯度，同一场景下梯度值越高，图像越清晰。
        /// 以下是具体实现，这里衡量的指标是经过Sobel算子处理后的图像的平均灰度值，值越大，代表图像越清晰。
        /// </summary>
        /// <param name="fileName">包含文件路径的文件名</param>
        /// <returns></returns>
        public static double Tenengrad(string fileName)
        {
            Mat imageSource = CvInvoke.Imread(fileName, Emgu.CV.CvEnum.LoadImageType.Color);

            Mat imageGrey = new Mat();
            CvInvoke.CvtColor(imageSource, imageGrey, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);

            Mat imageSobel = new Mat();
            CvInvoke.Sobel(imageGrey, imageSobel, Emgu.CV.CvEnum.DepthType.Cv16U, 1, 1);

            //图像的平均灰度
            MCvScalar scalar = CvInvoke.Mean(imageSobel);
            return scalar.ToArray()[0];
        }

        /// <summary>
        /// Laplacian梯度是另一种求图像梯度的方法
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static double Laplacian(string fileName)
        {
            Mat imageSource = CvInvoke.Imread(fileName, Emgu.CV.CvEnum.LoadImageType.Color);

            Mat imageGrey = new Mat();
            CvInvoke.CvtColor(imageSource, imageGrey, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);

            Mat imageSobel = new Mat();
            CvInvoke.Laplacian(imageGrey, imageSobel, Emgu.CV.CvEnum.DepthType.Cv16U);
            //CvInvoke.Sobel(imageGrey, imageSobel, Emgu.CV.CvEnum.DepthType.Cv16U, 1, 1);

            //图像的平均灰度
            MCvScalar scalar = CvInvoke.Mean(imageSobel);
            return scalar.ToArray()[0];
        }

        public static double Variance(string fileName)
        {
            Mat imageSource = CvInvoke.Imread(fileName, Emgu.CV.CvEnum.LoadImageType.Color);

            Mat imageGrey = new Mat();
            CvInvoke.CvtColor(imageSource, imageGrey, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);

            Mat meanValueImage = new Mat();
            Mat meanStdValueImage = new Mat();

            CvInvoke.MeanStdDev(imageGrey, meanValueImage, meanStdValueImage);

            double value = GetDoubleValue(meanValueImage, 0, 0);

            return value;
        }

        public static double Test(string fileName)
        {
            Mat imageSource = CvInvoke.Imread(fileName, Emgu.CV.CvEnum.LoadImageType.Color);

            Mat imageX = new Mat();

            Mat imageY = new Mat();
            CvInvoke.Sobel(imageSource, imageX, Emgu.CV.CvEnum.DepthType.Cv32F, 1, 0);
            CvInvoke.Sobel(imageSource, imageY, Emgu.CV.CvEnum.DepthType.Cv32F, 0, 1);

            CudaInvoke.Magnitude(imageX, imageY, imageX);
            return CvInvoke.Sum(imageX).ToArray()[0];
        }

        public static double GetDoubleValue(Mat mat, int row, int col)
        {
            var value = new double[1];
            Marshal.Copy(mat.DataPointer + (row * mat.Cols + col) * mat.ElementSize, value, 0, 1);
            return value[0];
        }
    }
}
