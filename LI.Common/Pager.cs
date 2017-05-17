using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LI.Common
{
    /// <summary>
    /// 分页类
    /// </summary>
    public class Pager
    {
        private int _pageSize = 20;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        private int _absolutePage = 1;
        public int AbsolutePage
        {
            get { return _absolutePage; }
            set { _absolutePage = value; }
        }
    }
}
