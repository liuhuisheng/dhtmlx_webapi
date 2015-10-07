/*************************************************************************
 * 文件名称 ：bas_app.cs                          
 * 描述说明 ：数据实体
 * 版权信息 : Copyright (c) 2015 厦门纵云信息科技有限公司 www.zoewin.com
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace dhtmlx_webapi.Models
{    

    public class bas_app
    {
        
        /// <summary>
		///应用编码
		/// </summary>        
        public string app_id { get; set; }
        
        /// <summary>
		///应用名称
		/// </summary>        
        public string app_name { get; set; }
        
        /// <summary>
		///应用英文名
		/// </summary>        
        public string app_name_en { get; set; }
        
        /// <summary>
		///类型
		/// </summary>        
        public string app_type { get; set; }
        
        /// <summary>
		///当前版本
		/// </summary>        
        public string version { get; set; }
        
        /// <summary>
		///发布日期
		/// </summary>        
        public DateTime? publish_date { get; set; }
        
        /// <summary>
		///状态
		/// </summary>        
        public bool? status { get; set; }
        
        /// <summary>
		///登陆页面logo
		/// </summary>        
        public string login_img { get; set; }
        
        /// <summary>
		///框架页面logo
		/// </summary>        
        public string logo_icon { get; set; }
        
        /// <summary>
		///描述
		/// </summary>        
        public string memo { get; set; }
        
        /// <summary>
		///是否多租户模式
		/// </summary>        
        public bool? is_multitenant { get; set; }
        
        /// <summary>
		///是否平台应用
		/// </summary>        
        public bool? is_use_platform { get; set; }
        
        /// <summary>
		///创建人
		/// </summary>        
        public string create_person { get; set; }
        
        /// <summary>
		///创建日期
		/// </summary>        
        public DateTime? create_date { get; set; }
        
        /// <summary>
		///更新人
		/// </summary>        
        public string update_person { get; set; }
        
        /// <summary>
		///更新日期
		/// </summary>        
        public DateTime? update_date { get; set; }
         
    }
}

