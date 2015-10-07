/*************************************************************************
 * 文件名称 ：bas_tenant.cs                          
 * 描述说明 ：数据实体
 * 版权信息 : Copyright (c) 2015 厦门纵云信息科技有限公司 www.zoewin.com
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace dhtmlx_webapi.Models
{    

    public class bas_tenant
    {
        
        /// <summary>
		///企业编号
		/// </summary>        
        public string tenant_id { get; set; }
        
        /// <summary>
		///企业名称
		/// </summary>        
        public string tenant_name { get; set; }
        
        /// <summary>
		///负责人
		/// </summary>        
        public string charge_person { get; set; }
        
        /// <summary>
		///联系电话
		/// </summary>        
        public string tel { get; set; }
        
        /// <summary>
		///手机号
		/// </summary>        
        public string mobile { get; set; }
        
        /// <summary>
		///传真
		/// </summary>        
        public string fax { get; set; }
        
        /// <summary>
		///地址
		/// </summary>        
        public string addr { get; set; }
        
        /// <summary>
		///是否启用
		/// </summary>        
        public bool? is_enabled { get; set; }
        
        /// <summary>
		///备注说明
		/// </summary>        
        public string memo { get; set; }
        
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

