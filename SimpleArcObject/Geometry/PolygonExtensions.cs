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
    /// Class PolygonExtensions.
    /// </summary>
    public static class PolygonExtensions
    {
        /// <summary>
        /// 验证多边形是否自相交
        /// </summary>
        /// <param name="pPolygon">待验证多边形</param>
        /// <returns>自相交返回True，反之返回False</returns>
        public static bool IsSelfCross(this IPolygon pPolygon)
        {
            var bSelfInt = false;
            if (pPolygon == null)
            {
                return bSelfInt;
            }
            var pTp = pPolygon as ITopologicalOperator4;
            pTp.IsKnownSimple_2 = false;
            var eNonSimEnum = esriNonSimpleReasonEnum.esriNonSimpleOK;
            if (!pTp.get_IsSimpleEx(out eNonSimEnum))
            {
                if (eNonSimEnum == esriNonSimpleReasonEnum.esriNonSimpleSelfIntersections)
                {
                    bSelfInt = true;
                }
            }
            return bSelfInt;
        }
    }
}
