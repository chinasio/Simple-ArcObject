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
   Created          : 2014-10-12
  
   Last Modified By : xiangmeng
   Last Modified On : 2014-10-12
/************************************************************************/
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAO.Carto
{
    public static class FeatureLayerExtensions
    {
        /// <summary>
        /// 获取Workspace
        /// </summary>
        /// <param name="pFeaLayer"></param>
        /// <returns>FeatureLayer对应的Workspace</returns>
        public static IWorkspace GetWorkspace(this IFeatureLayer pFeaLayer)
        {
            try
            {
                if (pFeaLayer == null)
                {
                    return null;
                }
                var pWorkpace = (pFeaLayer.FeatureClass as IDataset).Workspace;
                return pWorkpace;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
