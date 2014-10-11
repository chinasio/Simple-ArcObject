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
