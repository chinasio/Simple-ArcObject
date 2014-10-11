using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SAO.GeoDatabase
{
    public static class SelectionSetExtensions
    {
        public static IEnumerable<IFeature> GetFeatures(this ISelectionSet set, IQueryFilter filter = null, enumRecyclingPolicy policy = enumRecyclingPolicy.DoNotRecycle)
        {
            ICursor cursor;
            set.Search(filter, enumRecyclingPolicy.Recycle == policy, out cursor);
            var featureCursor = (IFeatureCursor)cursor;

            IFeature feature;
            while (null != (feature = featureCursor.NextFeature()))
            {
                yield return feature;
            }

            if (Marshal.IsComObject(cursor))
            {
                Marshal.ReleaseComObject(cursor);
            }
        }
    }
}
