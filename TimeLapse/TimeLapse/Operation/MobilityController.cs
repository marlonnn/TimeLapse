using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation
{
    public abstract class MobilityController
    {

        /// <summary>
        /// 初始化移动控制系统
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        public abstract bool Init(string ipAddress);

        /// <summary>
        /// 设置移动单位，移动单位为控制器最小移动距离*r
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public abstract bool SetResolution(int r);

        /// <summary>
        /// 回到零点
        /// </summary>
        /// <returns></returns>
        public abstract bool GoHome();
        /// <summary>
        /// 获取移动系统A轴位置
        /// </summary>
        /// <returns></returns>
        public abstract float GetPositionA();
        /// <summary>
        /// 获取移动系统A轴位置误差
        /// </summary>
        /// <returns></returns>
        public abstract float GetErrorPositionA();
        /// <summary>
        /// 获取移动系统B轴位置
        /// </summary>
        /// <returns></returns>
        public abstract float GetPositionB();
        /// <summary>
        /// 获取移动系统B轴位置误差
        /// </summary>
        /// <returns></returns>
        public abstract float GetErrorPositionB();
        /// <summary>
        /// 获取移动系统C轴位置
        /// </summary>
        /// <returns></returns>
        public abstract float GetPositionC();
        /// <summary>
        /// 获取移动系统C轴位置误差
        /// </summary>
        /// <returns></returns>
        public abstract float GetErrorPositionC();
        /// <summary>
        /// 设置移动系统A轴速度
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public abstract bool SetSpeedA(int speed);
        /// <summary>
        /// 设置移动系统B轴速度
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public abstract bool SetSpeedB(int speed);
        /// <summary>
        /// 设置移动系统C轴速度
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public abstract bool SetSpeedC(int speed);
        public abstract bool MoveAWithSpeed(int speed);
        public abstract bool MoveBWithSpeed(int speed);
        public abstract bool MoveCWithSpeed(int speed);
        public abstract bool StopMove();
        public abstract bool StopMoveA();
        public abstract bool StopMoveB();
        public abstract bool StopMoveC();

        /// <summary>
        /// A轴移动len距离
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public abstract bool MoveA(int len);
        /// <summary>
        /// B轴移动len距离
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public abstract bool MoveB(int len);
        /// <summary>
        /// C轴移动len距离
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public abstract bool MoveC(int len);
        /// <summary>
        /// 移动A,B,C轴到绝对位置
        /// </summary>
        /// <param name="posA"></param>
        /// <param name="posB"></param>
        /// <param name="posC"></param>
        /// <returns></returns>
        public abstract bool MoveAbsolute(int posA, int posB, int posC);

        /// <summary>
        /// 移动A,B轴到绝对位置
        /// </summary>
        /// <param name="posA"></param>
        /// <param name="posB"></param>
        /// <returns></returns>
        public abstract bool MoveAbsolute(int posA, int posB);
        /// <summary>
        /// 移动A轴到绝对位置pos
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public abstract bool MoveAbsoluteA(float pos);
        /// <summary>
        /// 移动B轴到绝对位置pos
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public abstract bool MoveAbsoluteB(float pos);
        /// <summary>
        /// 移动C轴到绝对位置pos
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public abstract bool MoveAbsoluteC(float pos);
        /// <summary>
        /// 等待A轴移动结束
        /// </summary>
        /// <returns></returns>
        public abstract bool WaitAMoveCompleted();
        /// <summary>
        /// 等待B轴移动结束
        /// </summary>
        /// <returns></returns>
        public abstract bool WaitBMoveCompleted();
        /// <summary>
        /// 等待C轴移动结束
        /// </summary>
        /// <returns></returns>
        public abstract bool WaitCMoveCompleted();
        /// <summary>
        /// 关闭移动控制系统
        /// </summary>
        /// <returns></returns>
        public abstract bool CloseGCLib();

    }
}
