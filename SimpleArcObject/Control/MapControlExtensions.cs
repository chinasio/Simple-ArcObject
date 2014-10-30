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
using ESRI.ArcGIS.Controls;
using SOA.Utils;
using System.Collections.Generic;
using System.Linq;

namespace SAO.Control
{
    public static class MapControlExtensions
    {
        private static ILogger pLogger = LogManager.GetLogger("MapControlExtensions");
        #region 获取图层

        /// <summary>
        /// 获取图层
        /// </summary>
        /// <param name="mapControl">The map control.</param>
        /// <returns>IEnumerable&lt;ILayer&gt;.</returns>
        public static IEnumerable<ILayer> GetLayers(this AxMapControl mapControl)
        {
            for (int i = 0; i < mapControl.LayerCount; i++)
            {
                var layer = mapControl.get_Layer(i);
                if (layer != null)
                    yield return layer;
            }
        }

        /// <summary>
        /// 获取要素图层
        /// </summary>
        /// <param name="mapControl">The map control.</param>
        /// <returns>IEnumerable&lt;IFeatureLayer&gt;.</returns>
        public static IEnumerable<IFeatureLayer> GetFeatureLayers(this AxMapControl mapControl)
        {
            return from layer in mapControl.GetLayers()
                   where layer is IFeatureLayer
                   select layer as IFeatureLayer;
        }

        /// <summary>
        /// 根据名称获取图层
        /// </summary>
        /// <param name="mapControl">The map control.</param>
        /// <param name="layerName">Name of the layer.</param>
        /// <returns>ILayer.</returns>
        public static ILayer GetLayerByName(this AxMapControl mapControl, string layerName)
        {
            var layerFinded = from layer in mapControl.GetLayers() where layer.Name == layerName select layer;
            if (layerFinded == null || layerFinded.Count() == 0)
                return null;
            else if (layerFinded.Count() > 1)
                return null;
            else
                return layerFinded.First();
        }

        /// <summary>
        /// 根据要素名称获取要素图层
        /// </summary>
        /// <param name="mapControl">The map control.</param>
        /// <param name="layerName">图层名称</param>
        /// <returns>IFeatureLayer.</returns>
        public static IFeatureLayer GetFeatureLayerByName(this AxMapControl mapControl, string layerName)
        {
            var layerFinded = from layer in mapControl.GetFeatureLayers() where layer.Name == layerName select layer;
            if (layerFinded == null || layerFinded.Count() == 0)
                return null;
            else if (layerFinded.Count() > 1)
                return null;
            else
                return layerFinded.First();
        }

        /// <summary>
        /// 获取图层序号
        /// </summary>
        /// <param name="mapControl">The map control.</param>
        /// <param name="layerName">图层名称</param>
        /// <returns>如果找到，则返回index，未找到，则返回-1</returns>
        public static int GetLayerIndex(this AxMapControl mapControl, string layerName)
        {
            for (int i = 0; i < mapControl.LayerCount; i++)
            {
                if (mapControl.get_Layer(i).Name == layerName)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// 获取图层序号
        /// </summary>
        /// <param name="mapControl">The map control.</param>
        /// <param name="layer">图层</param>
        /// <returns>如果找到，则返回index，未找到，则返回-1</returns>
        public static int GetLayerIndex(this AxMapControl mapControl, ILayer layer)
        {
            return mapControl.GetLayerIndex(layer.Name);
        }
        #endregion 获取图层
        /// <summary>
        /// 清除选择集
        /// </summary>
        /// <param name="mapControl"></param>
        public static void ClearSelection(this AxMapControl mapControl)
        {
            mapControl.Map.ClearSelection();
            var pActioveView = mapControl.Map as IActiveView;
            if (pActioveView == null)
                return;
            pActioveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, pActioveView.Extent);
        }

    }
}