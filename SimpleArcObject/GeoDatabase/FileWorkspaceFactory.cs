using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geodatabase;
using System.IO;
using System.Windows.Forms;

namespace SAO.GeoDatabase
{
    public class FileWorkspaceFactory
    {
        private static enumWorkspaceType AutoDetectFile(string path)
        {
            var ext = Path.GetExtension(path).ToLower();
            switch (ext)
            {
                case "mdb":
                    return enumWorkspaceType.Mdb;

                case "dxf":
                case "dwg":
                    return enumWorkspaceType.Cad;

                case "shp":
                    return enumWorkspaceType.Shapefile;

                case "img":
                case "tif":
                case "tiff":
                    return enumWorkspaceType.RasterFile;
                case "":
                    return enumWorkspaceType.Gdb;

                default:
                    return enumWorkspaceType.AutoDetect;
            }
        }

        /// <summary>
        /// 创建工作空间工厂
        /// </summary>
        /// <returns></returns>
        private static IWorkspaceFactory CreateWksFactory(enumWorkspaceType fileWksType)
        {
            IWorkspaceFactory wksFactory = null;
            switch (fileWksType)
            {
                case enumWorkspaceType.Shapefile:
                    wksFactory = new ShapefileWorkspaceFactoryClass();
                    break;

                case enumWorkspaceType.Gdb:
                    wksFactory = new FileGDBWorkspaceFactoryClass();
                    break;

                case enumWorkspaceType.Mdb:
                    wksFactory = new AccessWorkspaceFactoryClass();
                    break;

                case enumWorkspaceType.Cad:
                    wksFactory = new CadWorkspaceFactoryClass();
                    break;

                case enumWorkspaceType.RasterFile:
                    wksFactory = new RasterWorkspaceFactoryClass();
                    break;

                default:
                    break;
            }
            return wksFactory;
        }

        public static IWorkspace OpenFromFile(string path, enumWorkspaceType fileWksType = enumWorkspaceType.AutoDetect, bool isRelative = false)
        {
            if (isRelative)
                path += Application.StartupPath + "\\";
            //不存在的路径
            if (!Exists(path, fileWksType))
                return null;
            //识别类型
            if (fileWksType == enumWorkspaceType.AutoDetect)
                fileWksType = AutoDetectFile(path);
            var wksFactory = CreateWksFactory(fileWksType);
            //无法识别的类型
            if (wksFactory == null)
                return null;
            IWorkspace workspace = null;
            try
            {
                if (fileWksType == enumWorkspaceType.Cad
                    || fileWksType == enumWorkspaceType.Shapefile
                    || fileWksType == enumWorkspaceType.RasterFile)
                {
                    //todo是否已经被其他用户打开
                    workspace = wksFactory.OpenFromFile(Path.GetDirectoryName(path), 0);
                }
                else
                {
                    workspace = wksFactory.OpenFromFile(path, 0);
                }
                return workspace;
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("0x80040228"))
                {
                    //"ArcEngine没有进行初始化Lincense";
                }
                else
                {
                }
            }
            return workspace;
        }

        public static bool Exists(string path, enumWorkspaceType fileWksType = enumWorkspaceType.AutoDetect)
        {
            switch (fileWksType)
            {
                case enumWorkspaceType.AutoDetect:
                case enumWorkspaceType.RasterFile:
                    if (Directory.Exists(path) || File.Exists(path))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enumWorkspaceType.Cad:
                case enumWorkspaceType.Shapefile:
                case enumWorkspaceType.Mdb:
                    return File.Exists(path);

                case enumWorkspaceType.Gdb:
                    return Directory.Exists(path);

                default:
                    break;
            }
            return false;
        }
    }
}