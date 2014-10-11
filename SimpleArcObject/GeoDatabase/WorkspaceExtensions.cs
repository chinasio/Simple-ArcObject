using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;

namespace SAO.GeoDatabase
{
    public static class WorkspaceExtensions
    {
        #region 获取工作空间中的对象

        /// <summary>
        /// 判断工作空间中是否存在数据集或要素类
        /// </summary>
        /// <param name="wks">工作空间</param>
        /// <param name="name">数据集或要素类或表名称</param>
        /// <param name="dsType">数据集类型，不支持esriDTAny类型，如为esriDTAny,esriDTContainer,esriDTGeo类型强制返回false</param>
        /// <returns>存在返回true，反之返回false</returns>
        public static bool IsDatasetExists(this IWorkspace wks, string name, esriDatasetType dsType)
        {
            if (string.IsNullOrEmpty(name) || Convert.ToInt32(dsType) <= 3)
            {
                return false;
            }
            try
            {
                var wks2 = wks as IWorkspace2;
                if (wks2 == null)
                {
                    return false;
                }
                return wks2.get_NameExists(dsType, name);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 打开属性表
        /// 只针对gdb有效，即mdb，gdb以及sde
        /// </summary>
        /// <param name="wks"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ITable GetTable(this IWorkspace wks, string name)
        {
            try
            {
                var featureWks = wks as IFeatureWorkspace;
                if (featureWks != null)
                {
                    return featureWks.OpenTable(name);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 打开要素类
        /// </summary>
        /// <param name="wks"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IFeatureClass GetFeatureClass(this IWorkspace wks, string name)
        {
            try
            {
                var featureWks = wks as IFeatureWorkspace;
                if (featureWks != null)
                {
                    return featureWks.OpenFeatureClass(name);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 打开要素数据集集合
        /// </summary>
        /// <param name="wks"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IFeatureDataset GetFeatureDataset(this IWorkspace wks, string name)
        {
            try
            {
                var featureWks = wks as IFeatureWorkspace;
                if (featureWks != null)
                {
                    return featureWks.OpenFeatureDataset(name);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 打开栅格目录
        /// </summary>
        /// <param name="wks"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IRasterCatalog GetRasterCatalog(this IWorkspace wks, string name)
        {
            try
            {
                var rasterWks = wks as IRasterWorkspaceEx;
                if (rasterWks != null)
                {
                    return rasterWks.OpenRasterCatalog(name);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 打开栅格数据集
        /// </summary>
        /// <param name="wks"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IRasterDataset GetGDBRasterDataset(this IWorkspace wks, string name)
        {
            try
            {
                var rasterWks = wks as IRasterWorkspaceEx;
                if (rasterWks != null)
                {
                    return rasterWks.OpenRasterDataset(name);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 打开栅格数据集，
        /// 适用于本地文件型栅格文件
        /// </summary>
        /// <param name="wks"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IRasterDataset GetFileRasterDataset(this IWorkspace wks, string name)
        {
            try
            {
                var rasterWks = wks as IRasterWorkspace;
                if (rasterWks != null)
                {
                    return rasterWks.OpenRasterDataset(name);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        #endregion 获取工作空间中的对象


        public static IEnumerable<string> GetDSNames(this IWorkspace pWorkspace, esriDatasetType type = esriDatasetType.esriDTAny)
        {
            var pNames = pWorkspace.get_DatasetNames(type);
            pNames.Reset();
            var dsname = pNames.Next();
            while (dsname != null)
            {
                yield return pNames.Next().Name;
            }
        }
    }
}