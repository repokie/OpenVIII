﻿namespace OpenVIII
{
        public partial class IGM_Junction
        {
            private class IGMData_GF_Group : IGMData_Group
            {
                public IGMData_GF_Group(params IGMData[] d) : base( d) => Hide();
            }
        }
    
}