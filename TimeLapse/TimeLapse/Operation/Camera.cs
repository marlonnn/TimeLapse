using System;
using System.Drawing;

namespace TimeLapse.Operation
{
    /// <summary>
    /// 相机操作抽象类
    /// </summary>
    public abstract class Camera
    {
        public abstract bool Init();
        #region Camera Setting
        public abstract double GetCameraMinFrameRate();
        public abstract double GetCameraMaxFrameRate();
        public abstract bool SetCameraFrameRate(double frameRate);
        public abstract int GetCameraPixelClock();
        public abstract bool SetCameraPixelClock(int value);
        public abstract double GetCameraMinExposureRange();
        public abstract double GetCameraMaxExposureRange();
        public abstract bool SetCameraExposureTime(double time);
        public abstract void EnableCameraAutoExposure();
        public abstract void DisableCameraAutoExposure();
        public abstract void EnableCameraAutoFramerate();
        public abstract void DisableCameraAutoFramerate();
        #endregion
        public abstract Image TakePhoto();

        public abstract bool RecordVedio(string aviFileAbsPath);

        public abstract bool StopRecordVedio();

        public abstract Bitmap GetBitMap();

        public abstract IntPtr GetLastPtr();

        public abstract bool SaveImage();

        public abstract bool SaveImage(string path, string imageName);

        public abstract bool DisplayLive(IntPtr controlHandler);

        public abstract bool FreezeLive();
        public abstract bool StopLive();
        public abstract bool ExitCamera();

        /// <summary>
        /// 设置相机是否自动对焦
        /// </summary>
        /// <param name="setEnable"></param>
        public abstract void EnableCameraAutoFoucus(bool setEnable);
    }
}
