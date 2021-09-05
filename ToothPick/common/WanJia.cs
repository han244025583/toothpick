using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 玩家
    /// </summary>
    public class WanJia
    {
        /// <summary>
        /// 玩家ID
        /// </summary>
        public string WjId { get; set; }
        /// <summary>
        /// 玩家名称
        /// </summary>
        public string WjName { get; set; }
        /// <summary>
        /// 牙签列表
        /// </summary>
        public List<YaQian> YaQians { get; set; }
        /// <summary>
        /// 是否输家true-是，false-否，默认false
        /// </summary>
        public bool IsLoser { get; set; }
    }
}
