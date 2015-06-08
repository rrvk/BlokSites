using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokSites
{
    class Site
    {
        private String siteName;
        private String list;

        public Site(String siteName, String list)
        {
            this.siteName = siteName;
            this.list = list;
        }

        public String getSiteName()
        {
            return siteName;
        }

        public String getList()
        {
            return list;
        }

        public override string ToString()
        {
            return siteName;
        }
    }
}
