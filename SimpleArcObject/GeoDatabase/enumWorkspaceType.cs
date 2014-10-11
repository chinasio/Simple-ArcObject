namespace SAO.GeoDatabase
{
    public enum enumWorkspaceType
    {
        // 摘要:
        //     自动识别数据源类型
        AutoDetect = 0,

        //
        // 摘要:
        //     本地栅格图形
        RasterFile = 1,

        //
        // 摘要:
        //     本地shp文件
        Shapefile = 2,

        //
        // 摘要:
        //     本地mdb文件
        Mdb = 3,

        //
        // 摘要:
        //     本地gdb文件
        Gdb = 4,

        //
        // 摘要:
        //     本地CAD文件
        Cad = 5,

        //
        // 摘要:
        //     SDE for Oracle
        Oracle = 6,

        //
        // 摘要:
        //     SDE for Sql
        SqlServer = 7,

        //
        // 摘要:
        //     sde for db2
        DB2 = 8,

        //
        // 摘要:
        //     SDE for PostgreSQL
        PostgreSQL = 9,
        //
        // 摘要:
        //     无法自动识别的格式
        Unknown = 10,
    }
}