//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibrary_iBeacon.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BEACON_VIDEOS
    {
        public int ID_VIDEO { get; set; }
        public string VIDEO_URL { get; set; }
        public Nullable<int> STROE_ID { get; set; }
        public Nullable<int> TYPE { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
    }
}
