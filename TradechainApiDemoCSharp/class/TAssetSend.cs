﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradechainApiDemoCSharp
{
    public class TAssetSend
    {
        public TAuth auth= new TAuth();
	
	    public string asset_id { get; set; }
	    public string asset_addr_to { get; set; }
	    public string quantity { get; set; }
    }
}
