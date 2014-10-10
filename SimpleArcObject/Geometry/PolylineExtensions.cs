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
    /// 扩展ESRI.ArcGIS.Geometry.IPolyline
    /// </summary>
    public static class PolylineExtensions
    {
        /// <summary>
        /// To the coord strings.
        /// </summary>
        /// <param name="polyline">The polyline.</param>
        /// <returns>System.String.</returns>
        public static string ToCoordStrings(this IPolyline polyline)
        {
            var points = polyline as IPointCollection;

            return points.ToCoordStrings();
        }

        /// <summary>
        /// 验证是否自相交
        /// </summary>
        /// <param name="polyline">The polyline.</param>
        /// <returns>如果自相交，则为true，反之为false</returns>
        public static bool IsSelfCross(this IPolyline polyline)
        {
            var isSelfCross = false;
            if (polyline == null)
            {
                return isSelfCross;
            }
            ITopologicalOperator2 topological = polyline as ITopologicalOperator2;
            topological.IsKnownSimple_2 = false;
            bool bol = topological.IsSimple;           
            // 注意,下面的两次取值,不重复,若删除,则判断将会产生错误
            bol = topological.IsSimple;
            if (bol == false)
            {
                isSelfCross = true;
            }
            else
                isSelfCross = false;
            return isSelfCross;
        }
    }
}
