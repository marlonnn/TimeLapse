using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeLapse.Operation
{
    /// <summary>
    /// Singleton HDS Mobility Controller
    /// </summary>
    public class HDSMobilityController : MobilityController
    {

        private Gclib gclib;

        #region 常用命令
        private float ResolutionX = 10000;//光栅分辨率
        private float ResolutionY = 20000;//光栅分辨率
        private float ResolutionZ = 20000;//光栅分辨率
        public string DEFAULT_IP_ADDRESS = "10.0.0.100";//默认IP      
        public string AXIS_ENABLE = "SH";//轴使能，使外界力不能移动轴+（A,B）
        public string AXIS_RELEASE = "MO";//释放 电机关断
        public string STOP = "ST";//停止所有动作
        public string EXCUATE = "BG";//执行动作
        public string GO_HOME = "FIB";//回零
        public string AXIS_A = "A";//代表X轴
        public string AXIS_B = "B";//代表Y轴
        public string AXIS_C = "C";//代表Z轴
        public string GET_POS = "_TP";//得到当前位置
        public string GET_POS_ERROR = "_TE";//得到当前位置误差
        public string ABS_MOVE = "PA";//绝对移动
        public string RELATIVE_MOVE = "PR";//相对移动  
        public string WATCH_OPERATOR = "MG ";//查看操作数
        public string START_MOTION = "_BG";//开始运动
        #endregion
        private static Mutex mutex = new Mutex();
        /// <summary>
        /// 初始化控制器，启动私服电机
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        public override bool Init(string ipAddress)
        {

            //初始化gclib
            gclib = new Gclib();
            //根据ip地址打开控制器
            try
            {
                mutex.WaitOne();
                gclib.GOpen(ipAddress + " --direct --subscribe ALL");
                gclib.GCommand("pRESX=" + ResolutionX.ToString());
                gclib.GCommand("pRESY=" + ResolutionY.ToString());
                gclib.GCommand("pRESZ=" + ResolutionZ.ToString());
                gclib.GCommand(STOP);
                gclib.GCommand(AXIS_RELEASE);
                //轴使能
                gclib.GCommand(AXIS_ENABLE);
                mutex.ReleaseMutex();
            }
            catch (Exception ex)
            {
                LogHelper.GetLogger<HDSMobilityController>().Error(string.Format("init error, error message is: {0}", ex.Message));
                return false;
            }

            //gclib.GCommand("SHABC");
            return true;
        }

        /// <summary>
        /// 设置光栅分辨率
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public override bool SetResolution(int r)
        {
            ResolutionX = r;
            return true;
        }

        /// <summary>
        /// 设置光栅分辨率
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public override bool SetResolutionX(int r)
        {
            ResolutionX = r;
            return true;
        }

        /// <summary>
        /// 设置光栅分辨率
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public override bool SetResolutionY(int r)
        {
            ResolutionY = r;
            return true;
        }

        /// <summary>
        /// 设置光栅分辨率
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public override bool SetResolutionZ(int r)
        {
            ResolutionZ = r;
            return true;
        }

        /// <summary>
        /// 归零
        /// </summary>
        /// <returns></returns>
        public override bool GoHome()
        {
            if (gclib == null)
                return false;
            mutex.WaitOne();
            gclib.GCommand("XQ#HOMEALL");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 获取X轴位置
        /// </summary>
        /// <returns></returns>
        public override float GetPositionA()
        {
            float result = 0;
            if (gclib == null)
            {
                return result;
            }
            try
            {
                mutex.WaitOne();
                string str_posA = gclib.GCommand(WATCH_OPERATOR + GET_POS + AXIS_A);
                mutex.ReleaseMutex();
                result = float.Parse(str_posA);
            }
            catch
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// 获取X轴位置偏差
        /// </summary>
        /// <returns></returns>
        public override float GetErrorPositionA()
        {
            float result = 0;
            if (gclib == null)
            {
                return result;
            }
            try
            {
                mutex.WaitOne();
                string strPosError = gclib.GCommand(WATCH_OPERATOR + GET_POS_ERROR + AXIS_A);
                mutex.ReleaseMutex();
                result = float.Parse(strPosError);
            }
            catch
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// 获取Y轴位置
        /// </summary>
        /// <returns></returns>
        public override float GetPositionB()
        {
            float result = 0;
            if (gclib == null)
            {
                return result;
            }

            try
            {
                mutex.WaitOne();
                string str_posB = gclib.GCommand(WATCH_OPERATOR + GET_POS + AXIS_B);
                mutex.ReleaseMutex();
                result = float.Parse(str_posB);
            }
            catch
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// 获取Y轴位置偏差
        /// </summary>
        /// <returns></returns>
        public override float GetErrorPositionB()
        {
            float result = 0;
            if (gclib == null)
            {
                return result;
            }
            try
            {
                mutex.WaitOne();
                string strPosError = gclib.GCommand(WATCH_OPERATOR + GET_POS_ERROR + AXIS_B);
                mutex.ReleaseMutex();
                result = float.Parse(strPosError);
            }
            catch
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// 获取Z轴位置
        /// </summary>
        /// <returns></returns>
        public override float GetPositionC()
        {
            float result = 0;
            if (gclib == null)
            {
                return result;
            }

            try
            {
                mutex.WaitOne();
                string str_pos = gclib.GCommand(WATCH_OPERATOR + GET_POS + AXIS_C);
                mutex.ReleaseMutex();
                result = float.Parse(str_pos);
            }
            catch
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// 获取Z轴位置偏差
        /// </summary>
        /// <returns></returns>
        public override float GetErrorPositionC()
        {
            float result = 0;
            if (gclib == null)
            {
                return result;
            }
            try
            {
                mutex.WaitOne();
                string strPosError = gclib.GCommand(WATCH_OPERATOR + GET_POS_ERROR + AXIS_C);
                mutex.ReleaseMutex();
                result = float.Parse(strPosError);
            }
            catch
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// 设置A轴速度为n个编码里程计*分辨率/s
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public override bool SetSpeedA(int speed)
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GCommand("SP" + speed * ResolutionX);
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 设置B轴速度为n个编码历程计*分辨率/s
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public override bool SetSpeedB(int speed)
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GCommand("SPB" + speed * ResolutionY);
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 设置C轴速度为n个编码里程计*分辨率/s
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public override bool SetSpeedC(int speed)
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GCommand("SPC" + speed * ResolutionZ);
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 设置X轴相对移动速度为speed*分辨率，并开始运动
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public override bool MoveAWithSpeed(int speed)
        {
            if (speed == 0)
                return true;
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置相对移动位移
            gclib.GCommand("JG" + speed * ResolutionX);
            //开始移动
            gclib.GCommand("BGA");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 设置Y轴相对移动速度为speed*分辨率，并开始运动
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public override bool MoveBWithSpeed(int speed)
        {
            if (speed == 0)
                return true;
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置相对移动位移
            gclib.GCommand("JG," + speed * ResolutionY);
            //开始移动
            gclib.GCommand("BGB");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 设置Z轴相对移动速度为speed*分辨率，并开始运动
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public override bool MoveCWithSpeed(int speed)
        {
            if (speed == 0)
                return true;
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置相对移动位移
            gclib.GCommand("JG,," + speed * ResolutionZ);
            //开始移动
            gclib.GCommand("BGC");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 停止所有轴运动
        /// </summary>
        /// <returns></returns>
        public override bool StopMove()
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GCommand("ST");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 停止X轴运动
        /// </summary>
        /// <returns></returns>
        public override bool StopMoveA()
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GCommand("STA");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 停止Y轴运动
        /// </summary>
        /// <returns></returns>
        public override bool StopMoveB()
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GCommand("STB");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 停止Z轴运动
        /// </summary>
        /// <returns></returns>
        public override bool StopMoveC()
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GCommand("STC");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 发送命令，使A轴从当前位置开始移动分辨率*n个编码里程计，数值可以为负数
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public override bool MoveA(int len)
        {
            if (len == 0)
                return true;
            CheckAndThrowGclibNullException();
            try
            {
                mutex.WaitOne();
                //设置相对移动位移
                gclib.GCommand("PR" + len * ResolutionX);
                //开始移动
                gclib.GCommand("BGA");
                mutex.ReleaseMutex();
            }
            catch (Exception e)
            {

                Console.WriteLine("Move A failed!");
                return false;
                throw e;
            }

            return true;
        }

        /// <summary>
        /// 发送命令，使B轴从当前位置开始移动分辨率*n个编码里程计，数值可以为负数
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public override bool MoveB(int len)
        {
            if (len == 0)
                return true;
            CheckAndThrowGclibNullException();
            try
            {
                mutex.WaitOne();
                //设置相对移动位移
                gclib.GCommand("PR," + len * ResolutionY);
                //开始移动
                gclib.GCommand("BGB");
                mutex.ReleaseMutex();
            }
            catch (Exception e)
            {
                Console.WriteLine("Move B failed!");
                return false;
                throw e;
            }

            return true;
        }

        /// <summary>
        /// 发送命令，使C轴从当前位置开始移动分辨率*n个编码里程计，数值可以为负数
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public override bool MoveC(int len)
        {
            if (len == 0)
                return true;
            CheckAndThrowGclibNullException();
            try
            {
                mutex.WaitOne();
                //设置相对移动位移
                gclib.GCommand("PR,," + len * ResolutionZ);
                //开始移动
                gclib.GCommand("BGC");
                mutex.ReleaseMutex();
            }
            catch (Exception)
            {
                Console.WriteLine("Move C failed!");
                return false;
                throw;
            }

            return true;
        }

        /// <summary>
        /// 使XYZ轴移动到绝对坐标(posA,posB,posC)
        /// </summary>
        /// <param name="posA"></param>
        /// <param name="posB"></param>
        /// <param name="posC"></param>
        /// <returns></returns>
        public override bool MoveAbsolute(int posA, int posB, int posC)
        {

            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置绝对移动位移
            gclib.GCommand("PA" + posA * ResolutionX + "," + posB * ResolutionY + "," + posC * ResolutionZ);
            //开始移动
            gclib.GCommand("BGABC");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 使XY轴移动到绝对坐标(posA,posB)
        /// </summary>
        /// <param name="posA"></param>
        /// <param name="posB"></param>
        /// <returns></returns>
        public override bool MoveAbsolute(int posA, int posB)
        {

            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置绝对移动位移
            gclib.GCommand("PA" + posA * ResolutionX + "," + posB * ResolutionY);
            //开始移动
            gclib.GCommand("BGAB");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 发送命令，使A轴移动到系统绝对位置pos(resolution*pos个编码里程计)
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public override bool MoveAbsoluteA(float pos)
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置相对移动位移
            gclib.GCommand("PA" + pos * ResolutionX);
            //开始移动
            gclib.GCommand("BGA");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 发送命令，使B轴移动到系统绝对位置pos(resolution*pos个编码里程计)
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public override bool MoveAbsoluteB(float pos)
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置相对移动位移
            gclib.GCommand("PA," + pos * ResolutionY);
            //开始移动
            gclib.GCommand("BGB");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 发送命令，使C轴移动到系统绝对位置pos(resolution*pos个编码里程计)
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public override bool MoveAbsoluteC(float pos)
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            //设置相对移动位移
            gclib.GCommand("PA,," + pos);
            //开始移动
            gclib.GCommand("BGC");
            mutex.ReleaseMutex();
            return true;
        }

        /// <summary>
        /// 等待A轴运动结束
        /// </summary>
        /// <returns></returns>
        public override bool WaitAMoveCompleted()
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GMotionComplete("A");
            mutex.ReleaseMutex();
            //float result = gclib.GCommandIsFinished(WATCH_OPERATOR + START_MOTION + AXIS_A);
            //while (result != 0)
            //{
            //    result = gclib.GCommandIsFinished(WATCH_OPERATOR + START_MOTION + AXIS_A);
            //}
            return true;
        }

        /// <summary>
        /// 等待B轴运动结束
        /// </summary>
        /// <returns></returns>
        public override bool WaitBMoveCompleted()
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GMotionComplete("B");
            mutex.ReleaseMutex();
            //float result = gclib.GCommandIsFinished(WATCH_OPERATOR + START_MOTION + AXIS_B);
            //while (result != 0)
            //{
            //    result = gclib.GCommandIsFinished(WATCH_OPERATOR + START_MOTION + AXIS_B);
            //}
            return true;
        }

        /// <summary>
        /// 等待C轴运动结束
        /// </summary>
        /// <returns></returns>
        public override bool WaitCMoveCompleted()
        {
            CheckAndThrowGclibNullException();
            mutex.WaitOne();
            gclib.GMotionComplete("C");
            mutex.ReleaseMutex();
            //float result = gclib.GCommandIsFinished(WATCH_OPERATOR + START_MOTION + AXIS_C);
            //while (result != 0)
            //{
            //    result = gclib.GCommandIsFinished(WATCH_OPERATOR + START_MOTION + AXIS_C);
            //}
            return true;
        }

        /// <summary>
        /// 关闭控制器
        /// </summary>
        /// <returns></returns>
        public override bool CloseGCLib()
        {
            if (gclib != null)
            {
                mutex.WaitOne();
                gclib.GCommand(AXIS_RELEASE);
                gclib.GClose();
                mutex.ReleaseMutex();
            }
            return true;
        }

        /// <summary>
        /// 检查gclib是否存在
        /// </summary>
        private void CheckAndThrowGclibNullException()
        {
            if (gclib == null)
                throw new Exception("Please init move controller first!");
        }
    }
}
