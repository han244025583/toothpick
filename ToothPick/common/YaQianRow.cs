using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 牙签行
    /// </summary>
    public class YaQianRow
    {
        /// <summary>
        /// 行Id
        /// </summary>
        public int RowId { get; set; }
        /// <summary>
        /// 前一行Id
        /// </summary>
        public int PreRowId { get; set; }
        /// <summary>
        /// 后一行Id
        /// </summary>
        public int NextRowId { get; set; }
        /// <summary>
        /// 牙签列表
        /// </summary>
        public List<YaQian> YaQians { get; set; }
    }
}
