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
    /// Class PointCollectionExtensions.
    /// </summary>
    public static class PointCollectionExtensions
    {
        public static string ToCoordStrings(this IPointCollection points)
        {
            if (points == null || points.PointCount == 0)
            {
                return null;
            }
            var strCoord = new StringBuilder();
            for (var i = 0; i < points.PointCount; i++)
            {
                var pt = points.get_Point(i);
                if (pt == null)
                {
                    continue;
                }
                if (strCoord.Length > 0)
                {
                    strCoord.Append(",");
                }
                strCoord.Append(pt.ToCoordStrings());
            }
            return strCoord.ToString();
        }
    }
}
