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
   Assembly         : SimpleArcObject
   Author           : xiangmeng
   Created          : 2014-10-10
  
   Last Modified By : xiangmeng
   Last Modified On : 2014-10-10
/************************************************************************/

using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// The Geometry namespace.
/// </summary>
namespace SAO.Geometry
{

    /// <summary>
    /// Class PointExtensions.
    /// </summary>
    public static class PointExtensions
    {
        /// <summary>
        /// 转换成X,Y[,Z]的字符串
        /// </summary>
        /// <param name="point">点对象</param>
        /// <param name="hasZ">如果为 <c>true</c>包含Z坐标，反之则不包含。</param>
        /// <returns>System.String.</returns>
        public static string ToCoordStrings(this IPoint point,bool hasZ = false)
        {
            var strCoord = new StringBuilder();
            strCoord.Append(point.X.ToString());
            strCoord.Append(",");
            strCoord.Append(point.Y.ToString());
            if (hasZ)
            {
                strCoord.Append(",");
                strCoord.Append(point.Z.ToString());
            }
            return strCoord.ToString();
        }
    }
}
