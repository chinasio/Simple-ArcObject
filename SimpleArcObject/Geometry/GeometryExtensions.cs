using ESRI.ArcGIS.Geometry;

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

/// <summary>
/// The Geometry namespace.
/// </summary>
namespace SAO.Geometry
{
    /// <summary>
    /// Class GeometryExtensions.
    /// </summary>
    public static class GeometryExtensions
    {
        /// <summary>
        /// 返回图形中心点
        /// </summary>
        /// <param name="pGeometry"></param>
        /// <returns></returns>
        public static IPoint GetCenterPoint(this IGeometry pGeometry)
        {
            if (pGeometry == null)
            {
                return null;
            }
            if (pGeometry.GeometryType == esriGeometryType.esriGeometryPoint)
            {
                return pGeometry as IPoint;
            }
            else
            {
                IPoint pPnt = new PointClass() 
                {
                    X = (pGeometry.Envelope.XMax + pGeometry.Envelope.XMin) / 2, 
                    Y = (pGeometry.Envelope.YMax + pGeometry.Envelope.YMin) / 2 
                };
                return pPnt;
            }
        }
    }
}