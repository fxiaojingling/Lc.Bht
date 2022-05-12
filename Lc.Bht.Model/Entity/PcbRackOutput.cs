﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
//     author CHENGE
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace Lc.Bht.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pcb_rack_output")]
    public class PcbRackOutput
    {
          public PcbRackOutput()
          {
          }

           /// <summary>
           /// 描述 : ID唯一标识 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "ID唯一标识")]           
           public string id {get;set;}

           /// <summary>
           /// 描述 : OK/NG 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "OK/NG")]           
           public string result_flag {get;set;}

           /// <summary>
           /// 描述 : 流程码 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "流程码")]           
           public string flow_code {get;set;}

           /// <summary>
           /// 描述 : 下一站工作点 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "下一站工作点")]           
           public string next_stop {get;set;}

           /// <summary>
           /// 描述 : 结果信息 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "结果信息")]           
           public string result_message {get;set;}

           /// <summary>
           /// 描述 : 制令单号 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "制令单号")]           
           public string mo_num {get;set;}

           /// <summary>
           /// 描述 : 工单号 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "工单号")]           
           public string wo_num {get;set;}

           /// <summary>
           /// 描述 : 主板料号 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "主板料号")]           
           public string mboard_code {get;set;}

           /// <summary>
           /// 描述 : 创建时间 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建时间")]           
           public DateTime? creation_time {get;set;}

           /// <summary>
           /// 描述 : 更新时间 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "更新时间")]           
           public DateTime? updata_time {get;set;}

    }
}