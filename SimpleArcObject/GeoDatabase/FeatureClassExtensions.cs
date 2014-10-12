using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SAO.GeoDatabase
{
    public static class FeatureClassExtensions
    {
        public static IEnumerable<IFeature> GetFeatures(this IFeatureClass featureClass,
                                                        IQueryFilter queryFilter = null, enumRecyclingPolicy policy = enumRecyclingPolicy.DoNotRecycle)
        {
            IFeatureCursor featureCursor =
                featureClass.Search(queryFilter, enumRecyclingPolicy.Recycle == policy);

            IFeature feature;
            while (null != (feature = featureCursor.NextFeature()))
            {
                yield return feature;
            }

            if (Marshal.IsComObject(featureCursor))
            {
                Marshal.ReleaseComObject(featureCursor);
            }
        }
    }
}
