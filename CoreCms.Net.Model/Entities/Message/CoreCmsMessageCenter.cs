/***********************************************************************
 *            Project: CoreCms
 *        ProjectName: 核心内容管理系统                                
 *                Web: https://www.corecms.net                      
 *             Author: 大灰灰                                          
 *              Email: jianweie@163.com                                
 *         CreateTime: 2021/1/31 21:45:10
 *        Description: 暂无
 ***********************************************************************/

using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     消息配置表
    /// </summary>
    public class CoreCmsMessageCenter
    {
        /// <summary>
        ///     序列
        /// </summary>
        [Display(Name = "序列")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public int id { get; set; }

        /// <summary>
        ///     编码
        /// </summary>
        [Display(Name = "编码")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "{0}不能超过{1}字")]
        public string code { get; set; }

        /// <summary>
        ///     启用短信
        /// </summary>
        [Display(Name = "启用短信")]
        [Required(ErrorMessage = "请输入{0}")]
        public bool isSms { get; set; }

        /// <summary>
        ///     启用站内消息
        /// </summary>
        [Display(Name = "启用站内消息")]
        [Required(ErrorMessage = "请输入{0}")]
        public bool isMessage { get; set; }

        /// <summary>
        ///     启用微信模板消息
        /// </summary>
        [Display(Name = "启用微信模板消息")]
        [Required(ErrorMessage = "请输入{0}")]
        public bool isWxTempletMessage { get; set; }
    }
}