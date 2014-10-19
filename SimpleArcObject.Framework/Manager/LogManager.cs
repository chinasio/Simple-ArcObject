/*************************************************************************
Copyright 2014 Xiang Meng
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at
       http://www.apache.org/licenses/LICENSE-2.0
   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   Assembly         : SimpleArcObject.Framework
   Author           : xiangmeng
   Created          : 2014-10-19
   Last Modified By : xiangmeng
   Last Modified On : 2014-10-19
/************************************************************************/

using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SimpleArcObject.Framework.Manager
{
    /// <summary>
    /// 日志管理类
    /// </summary>
    public static class LogManager
    {
        static LogManager()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string configPath = Application.ExecutablePath + ".config";//GetConfigPath(executingAssembly);
            if (!File.Exists(configPath))
            {
                string str2 = executingAssembly.FullName.Split(new char[] { ',' })[0];
                string name = str2 + "." + str2 + ".dll.config";
                Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name);
                if (manifestResourceStream == null)
                {
                    throw new FileNotFoundException("config");
                }
                XmlConfigurator.Configure(manifestResourceStream);
            }
            else
            {
                XmlConfigurator.Configure(new FileInfo(configPath));
            }
        }

        private static string GetConfigPath(Assembly ass)
        {
            Uri uri = new Uri(ass.CodeBase + ".config");
            return uri.LocalPath;
        }

        /// <summary>
        /// 获取Logger对象
        /// </summary>
        /// <param name="name">日志需要记录的对象名称，一般传入类名</param>
        /// <returns>ILogger.</returns>
        public static ILogger GetLogger(string name)
        {
            return new SimpleArcObject.Framework.Manager.Logger(log4net.LogManager.GetLogger(name));
        }
    }

    /// <summary>
    /// 日志接口
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 传入调试信息
        /// </summary>
        /// <param name="message">日志消息</param>
        void Debug(string message);

        void Error(Exception ex);

        void Error(string message);

        void Info(string message);
    }

    internal class Logger : ILogger
    {
        private ILog iLog;

        public Logger(ILog iLog)
        {
            this.iLog = iLog;
        }

        public void Debug(string message)
        {
            this.iLog.Debug(message);
        }

        public void Error(Exception exception)
        {
            if (exception.InnerException != null)
            {
                this.Error(exception.InnerException);
            }
            string str = string.Format("[{0}],系统执行过程中发生异常:异常类型{1},异常信息:{2},异常堆栈{3}", new object[] { DateTime.Now.ToShortTimeString(), exception.GetType().ToString(), exception.Message, exception.StackTrace });
            Console.WriteLine(str);
            this.Error(str);
        }

        /// <summary>
        /// 错误消息
        /// </summary>
        /// <param name="message">消息</param>
        public void Error(string message)
        {
            this.iLog.Error(message);
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="message">消息</param>
        public void Info(string message)
        {
            this.iLog.Info(message);
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="message">消息</param>
        public void Warn(string message)
        {
            this.iLog.Warn(message);
        }
    }
}