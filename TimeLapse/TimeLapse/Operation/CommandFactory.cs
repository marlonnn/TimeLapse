using System.Collections.Generic;

namespace TimeLapse.Operation
{
    /// <summary>
    /// 命令工厂
    /// 存放所有相机和运动平台命令字典，键为命令名称，值为具体命令对象
    /// 提供创建具体命令方法（从命令字典中提取）
    /// </summary>
    /// <remarks>
    /// 公司：CII-TECH
    /// 作者：钟文               
    /// 创建日期：2017-4-19   
    /// </remarks>
    public class CommandFactory
    {
        //命令队列
        public CommandQueue CommandQueue { get; set; }

        //命令字典，存放所有操作指令
        public Dictionary<string, Command> CommandRepertory { private get; set; }

        public CommandFactory(CommandQueue CommandQueue, Dictionary<string, Command> CommandRepertory)
        {
            this.CommandQueue = CommandQueue;
            this.CommandRepertory = CommandRepertory;
        }

        /// <summary>
        /// 创建具体命令方法
        /// </summary>
        /// <typeparam name="T">命令类型</typeparam>
        /// <param name="commandName">命令名称</param>
        /// <returns></returns>
        public T CreateCommand<T>(string commandName) where T : Command
        {
            T command = (T)CommandRepertory[commandName];
            command.CommandName = commandName;
            return command;
        }
    }
}
