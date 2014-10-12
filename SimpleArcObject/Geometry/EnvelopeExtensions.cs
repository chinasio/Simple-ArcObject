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

namespace SAO.Geometry
{

    /// <summary>
    /// 扩展ESRI.ArcGIS.Geometry.IEnvelope
    /// </summary>
    public static class EnvelopeExtensions
    {

        /// <summary>
        /// 获取XMin,YMin,XMax,YMax格式的字符串
        /// </summary>
        /// <param name="envelope">envelope.</param>
        /// <returns>System.String.</returns>
        public static string ToCoordStrings(this IEnvelope envelope)
        {
            if (envelope == null)
            {
                return null;
            }
            var strCoord = new StringBuilder();
            strCoord.Append(envelope.XMin.ToString());
            strCoord.Append(",");
            strCoord.Append(envelope.YMin.ToString());
            strCoord.Append(",");
            strCoord.Append(envelope.XMax.ToString());
            strCoord.Append(",");
            strCoord.Append(envelope.YMax.ToString());
            return strCoord.ToString();
        }
    }
}
