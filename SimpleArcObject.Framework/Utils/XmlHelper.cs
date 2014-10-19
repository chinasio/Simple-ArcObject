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

using SOA.Utils;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SimpleArcObject.Framework.Utils
{
    /// <summary>
    /// XML辅助类，用于XML与对象之间转换
    /// </summary>
    public static class XmlHelper
    {
        private static ILogger logger = LogManager.GetLogger("XmlHelper");

        public static byte[] XmlSerializeInternal(object obj, Encoding encoding)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            XmlSerializer ser = new XmlSerializer(obj.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                using (XmlTextWriter writer = new XmlTextWriter(ms, encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    ser.Serialize(writer, obj);
                    writer.Close();
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// 将一个对象序列化为XML字符串
        /// </summary>
        /// <param name="o">要序列化的对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>序列化产生的XML字符串</returns>
        public static string XmlSerialize(object o, Encoding encoding)
        {
            byte[] bytes = XmlSerializeInternal(o, encoding);
            return encoding.GetString(bytes);
        }

        /// <summary>
        /// 将一个对象按XML序列化的方式写入到一个文件
        /// </summary>
        /// <param name="o">要序列化的对象</param>
        /// <param name="path">保存文件路径</param>
        /// <param name="encoding">编码方式</param>
        public static void XmlSerializeToFile(object o, string path, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");

            byte[] bytes = XmlSerializeInternal(o, encoding);
            File.WriteAllBytes(path, bytes);
        }

        /// <summary>
        /// 从XML字符串中反序列化对象
        /// </summary>
        /// <typeparam name="T">结果对象类型</typeparam>
        /// <param name="s">包含对象的XML字符串</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>反序列化得到的对象</returns>
        public static T XmlDeserialize<T>(string s, Encoding encoding)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentNullException("s");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            XmlSerializer mySerializer = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(s)))
            {
                using (StreamReader sr = new StreamReader(ms, encoding))
                {
                    return (T)mySerializer.Deserialize(sr);
                }
            }
        }

        /// <summary>
        /// 读入一个文件，并按XML的方式反序列化对象。
        /// </summary>
        /// <typeparam name="T">结果对象类型</typeparam>
        /// <param name="path">文件路径</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>反序列化得到的对象</returns>
        public static T XmlDeserializeFromFile<T>(string path, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            string xml = File.ReadAllText(path, encoding);
            return XmlDeserialize<T>(xml, encoding);
        }

        /// <summary>
        /// 反序列化指定位置的xml文件（读取）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T XmlDeserialize<T>(string path)
        {
            FileStream fs = null;
            T obj = default(T);
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                obj = (T)xs.Deserialize(fs);
                fs.Close();
                return obj;
            }
            catch (Exception ex)
            {
                if (fs != null)
                    fs.Close();
                logger.Error(ex.Message);
                return obj;
                //throw new Exception("Xml文件反序列化失败，请查看日志!");
            }
        }

        public static void XmlSerialize<T>(string path, T obj) where T : class
        {
            FileStream fs = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, obj);
                obj = null;
                fs.Close();
            }
            catch (Exception ex)
            {
                if (fs != null)
                    fs.Close();
                logger.Error("Xml文件序列化失败，请查看日志!" + ex.Message);
                //throw new Exception("Xml文件序列化失败，请查看日志!");
            }
        }
    }
}