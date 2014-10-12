using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using System.Collections.Generic;
using System.Linq;

namespace SAO.Control
{
    public static class MapControlExtensions
    {
        #region 获取图层

        public static IEnumerable<ILayer> GetLayers(this AxMapControl mapControl)
        {
            for (int i = 0; i < mapControl.LayerCount; i++)
            {
                var layer = mapControl.get_Layer(i);
                if (layer != null)
                    yield return layer;
            }
        }

        public static IEnumerable<IFeatureLayer> GetFeatureLayers(this AxMapControl mapControl)
        {
            return from layer in mapControl.GetLayers()
                   where layer is IFeatureLayer
                   select layer as IFeatureLayer;
        }

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

        #endregion 获取图层


    }
}