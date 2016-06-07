using System;

namespace RasterMaSys.Util
{
   public class SearchCondition
   {
    
       public SearchCondition()
       {
           this.SensorType = null;
        
           this.StartRowId = null;
           this.EndRowId = null;
           this.StartColId = null;
           this.EndColId = null;
           this.CloudAge = null;
       }

       public string SensorType
       { get; set; }

       public DateTime RsStarTime
       { get; set; }
       public DateTime RsEndTime
       { get; set; }

       public short? StartRowId
       { get; set; }

       public short? EndRowId
       { get; set; }

       public short? StartColId
       { get; set; }

       public short? EndColId
       { get; set; }

       public double? CloudAge
       { get; set; }
   }
}
