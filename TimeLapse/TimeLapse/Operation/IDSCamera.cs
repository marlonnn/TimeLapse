using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation
{
    public class IDSCamera : Camera
    {
        private static Camera s_instance;
        private IDSCamera() { }

        public static Camera getInstance()
        {
            if (s_instance == null)
            {
                s_instance = new IDSCamera();
            }
            return s_instance;
        }

        private uEye.Camera camera;
        private uEye.Defines.Status statusRet = 0;
        private IntPtr displayHandle;

        /// <summary>
        /// 初始化相机
        /// </summary>
        /// <returns></returns>
        public override bool Init()
        {
            camera = new uEye.Camera();

            // Open Camera
            statusRet = camera.Init();
            if (statusRet != uEye.Defines.Status.Success)
            {
                SetError("Camera initializing failed");
                return false;
            }

            // Allocate Memory
            statusRet = camera.Memory.Allocate();
            if (statusRet != uEye.Defines.Status.Success)
            {
                SetError("Allocate Memory failed");
                return false;
            }

            // start capture
            if (uEye.Defines.Status.Success == camera.Acquisition.Capture())
            {
                return true;
            }
            else
            {
                SetError("Capture live show from camera failed!");
                return false;
            }

        }
        #region Setting
        /// <summary>
        /// 获取相机可设置的最小帧率
        /// </summary>
        /// <returns></returns>
        public override double GetCameraMinFrameRate()
        {
            if (camera == null)
            {
                return 0;
            }

            uEye.Defines.Status statusRet;
            uEye.Types.Range<Double> range;

            statusRet = camera.Timing.Framerate.GetFrameRateRange(out range);

            return range.Minimum;
        }

        /// <summary>
        /// 获取相机可设置的最大帧率
        /// </summary>
        /// <returns></returns>
        public override double GetCameraMaxFrameRate()
        {
            if (camera == null)
            {
                return 0;
            }
            uEye.Defines.Status statusRet;
            uEye.Types.Range<Double> range;

            statusRet = camera.Timing.Framerate.GetFrameRateRange(out range);

            return range.Maximum;
        }

        /// <summary>
        /// 设置相机帧率
        /// </summary>
        /// <param name="frameRate"></param>
        /// <returns></returns>
        public override bool SetCameraFrameRate(double frameRate)
        {
            if (camera == null)
            {
                return false;
            }
            camera.Timing.Framerate.Set(frameRate);
            return true;
        }

        /// <summary>
        /// 获取相机像素时钟
        /// </summary>
        /// <returns></returns>
        public override int GetCameraPixelClock()
        {
            if (camera == null)
            {
                return 0;
            }
            int result = 0;
            camera.Timing.PixelClock.Get(out result);

            return result;
        }

        /// <summary>
        /// 设置相机像素时钟
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool SetCameraPixelClock(int value)
        {
            if (camera == null)
            {
                return false;
            }
            camera.Timing.PixelClock.Set(value);
            return true;
        }

        /// <summary>
        /// 获取相机可设置的最小曝光时间
        /// </summary>
        /// <returns></returns>
        public override double GetCameraMinExposureRange()
        {
            if (camera == null)
            {
                return 0;
            }
            uEye.Types.Range<Double> range;
            camera.Timing.Exposure.GetRange(out range);
            return range.Minimum;
        }

        /// <summary>
        /// 获取相机可设置的最大曝光时间
        /// </summary>
        /// <returns></returns>
        public override double GetCameraMaxExposureRange()
        {
            if (camera == null)
            {
                return 0;
            }
            uEye.Types.Range<Double> range;
            camera.Timing.Exposure.GetRange(out range);
            return range.Maximum;
        }

        /// <summary>
        /// 设置相机曝光时间
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public override bool SetCameraExposureTime(double time)
        {
            if (camera == null)
            {
                return false;
            }
            camera.Timing.Exposure.Set(time);
            return true;
        }

        /// <summary>
        /// 使能相机自动曝光时间调整
        /// </summary>
        public override void EnableCameraAutoExposure()
        {
            if (camera == null)
            {
                return;
            }
            camera.AutoFeatures.Software.Shutter.SetEnable(true);
        }

        /// <summary>
        /// 关闭相机自动曝光功能
        /// </summary>
        public override void DisableCameraAutoExposure()
        {
            if (camera == null)
            {
                return;
            }
            camera.AutoFeatures.Software.Shutter.SetEnable(false);
        }

        /// <summary>
        /// 使能相机自动帧率设置
        /// </summary>
        public override void EnableCameraAutoFramerate()
        {
            if (camera == null)
            {
                return;
            }
            camera.AutoFeatures.Software.Framerate.SetEnable(true);
        }

        /// <summary>
        /// 关闭相机自动帧率设置
        /// </summary>
        public override void DisableCameraAutoFramerate()
        {
            if (camera == null)
            {
                return;
            }
            camera.AutoFeatures.Software.Framerate.SetEnable(false);
        }
        #endregion


        /// <summary>
        /// 设置相机是否自动对焦
        /// </summary>
        /// <param name="setEnable"></param>
        public override void EnableCameraAutoFoucus(bool setEnable)
        {
            if (camera == null)
            {
                return;
            }
            camera.Focus.Auto.SetEnable(setEnable);
        }

        public override System.Drawing.Image TakePhoto()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 保存图片到默认目录
        /// </summary>
        /// <returns></returns>
        public override bool SaveImage()
        {
            if (camera == null)
            {
                return false;
            }
            if (uEye.Defines.Status.Success == camera.Image.Save(""))
            {
                return true;
            }

            return false;
        }
        public override Bitmap GetBitMap()
        {
            uEye.Defines.Status statusRet = 0;

            // Get last image memory
            Int32 s32LastMemId;
            Int32 s32Width;
            Int32 s32Height;
            statusRet = camera.Memory.GetLast(out s32LastMemId);
            statusRet = camera.Memory.Lock(s32LastMemId);
            statusRet = camera.Memory.GetSize(s32LastMemId, out s32Width, out s32Height);

            Bitmap MyBitmap;
            statusRet = camera.Memory.ToBitmap(s32LastMemId, out MyBitmap);


            // clone bitmap
            Rectangle cloneRect = new Rectangle(0, 0, s32Width, s32Height);
            System.Drawing.Imaging.PixelFormat format = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            Bitmap cloneBitmap = MyBitmap.Clone(cloneRect, format);

            // unlock image buffer
            statusRet = camera.Memory.Unlock(s32LastMemId);
            return cloneBitmap;
        }

        public override IntPtr GetLastPtr()
        {
            uEye.Defines.Status statusRet = 0;
            // Get last image memory
            IntPtr lastPtr;
            statusRet = camera.Memory.GetLast(out lastPtr);
            return lastPtr;
        }

        /// <summary>
        /// 保存图片到给定位置
        /// </summary>
        /// <param name="path"></param>
        /// <param name="imageName"></param>
        /// <returns></returns>
        public override bool SaveImage(string path, string imageName)
        {
            if (!IsInited())
            {
                return false;
            }
            //uEye.Defines.Status statusRet = 0;

            //// Get last image memory
            //Int32 s32LastMemId;
            //Int32 s32Width;
            //Int32 s32Height;
            //statusRet = camera.Memory.GetLast(out s32LastMemId);
            //statusRet = camera.Memory.Lock(s32LastMemId);
            //statusRet = camera.Memory.GetSize(s32LastMemId, out s32Width, out s32Height);

            //Bitmap MyBitmap;
            //statusRet = camera.Memory.ToBitmap(s32LastMemId, out MyBitmap);

            //// clone bitmap
            //Rectangle cloneRect = new Rectangle(0, 0, s32Width, s32Height);
            //System.Drawing.Imaging.PixelFormat format = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            //Bitmap cloneBitmap = MyBitmap.Clone(cloneRect, format);

            //// unlock image buffer
            //statusRet = camera.Memory.Unlock(s32LastMemId);
            //// text on Bitmap
            //string waterText = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //PointF firstLocation = new PointF(10f, 10f);
            //using (Graphics graphics = Graphics.FromImage(cloneBitmap))
            //{
            //    using (Font arialFont = new Font("Arial", 50))
            //    {
            //        // write text and image
            //        graphics.DrawString(waterText, arialFont, Brushes.Aqua, firstLocation);
            //    }
            //}
            if (!(path.EndsWith("/") || path.EndsWith("\\")))
            {
                path += "/";
            }
            //cloneBitmap.Save(path + imageName);
            if (uEye.Defines.Status.Success == camera.Image.Save(path + imageName))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 启动相机，在给定的显示控件ControlHandler显示
        /// </summary>
        /// <param name="controlHandler"></param>
        /// <returns></returns>
        public override bool DisplayLive(IntPtr controlHandler)
        {
            if (camera == null)
            {
                SetError("Please init the camera first!");
                return false;
            }

            this.displayHandle = controlHandler;


            //connect capture live video to the control and show
            camera.EventFrame += OnFrameEvent;

            return true;
        }

        /// <summary>
        /// 暂停相机拍摄
        /// </summary>
        /// <returns></returns>
        public override bool FreezeLive()
        {
            if (!IsInited())
                return false;

            if (uEye.Defines.Status.Success == camera.Acquisition.Freeze())
                return true;
            else
                return false;

        }
        /// <summary>
        /// 暂定相机拍摄
        /// </summary>
        /// <returns></returns>
        public override bool StopLive()
        {
            if (!IsInited())
                return true;
            if (uEye.Defines.Status.Success == camera.Acquisition.Stop())
                return true;
            else
                return false;

        }

        /// <summary>
        /// 开始记录视频到指定avi文件
        /// </summary>
        /// <param name="aviFileAbsPath"></param>
        /// <returns></returns>
        public override bool RecordVedio(string aviFileAbsPath)
        {

            statusRet = camera.Video.Start(aviFileAbsPath);
            if (statusRet != uEye.Defines.Status.SUCCESS)
            {
                SetError("Could not start video recording");
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// 停止记录视频并保存
        /// </summary>
        /// <returns></returns>
        public override bool StopRecordVedio()
        {
            if (!IsInited())
                return true;
            if (uEye.Defines.Status.Success == camera.Video.Stop())
                return true;
            else
                return false;
        }

        /// <summary>
        /// 退出相机
        /// </summary>
        /// <returns></returns>
        public override bool ExitCamera()
        {
            if (camera == null)
                return true;

            camera.Exit();
            camera = null;
            displayHandle = IntPtr.Zero;
            return true;
        }

        /// <summary>
        /// 绑定视频输出流到指定控件上，并开始输出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFrameEvent(object sender, EventArgs e)
        {
            uEye.Camera Camera = sender as uEye.Camera;

            Int32 s32MemID;
            Camera.Memory.GetActive(out s32MemID);

            Camera.Display.Render(s32MemID, displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
        }

        /// <summary>
        /// 检查相机是否初始化
        /// </summary>
        /// <returns></returns>
        private bool IsInited()
        {
            return
                (camera == null || displayHandle == null || displayHandle == IntPtr.Zero)
                ? false : true;
        }

        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="message"></param>
        private void SetError(string message)
        {
            LogHelper.GetLogger<IDSCamera>().Error(message);
        }

    }
}
