using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GoodMan.ViewModel.DTO
{
         
    public class UserInfor
    {
        public string 登入者帳號 { get; set; }
        public string 登入者姓名 { get; set; }
        public string 部門代碼 { get; set; }
        public string 部門名稱 { get; set; }
        public object 登入者系統選單 { get; set; }
        public ObservableCollection<登入者系統> 登入者系統 { get; set; }
    }

    public class 登入者系統
    {
        public string 系統代碼 { get; set; }
        public string 系統名稱 { get; set; }
        public string 系統是否使用群組 { get; set; }
        public string 選單群組是否顯示 { get; set; }
        public string 選單是否選擇法會 { get; set; }
        public string 選擇法會程式網址 { get; set; }
        public 選單群組不顯示的登入者選單[] 選單群組不顯示的登入者選單 { get; set; }
        public 選單群組不顯示的登入者角色基本權限最大化[] 選單群組不顯示的登入者角色基本權限最大化 { get; set; }
        public int 選單排序 { get; set; }
        public string 系統是否停用 { get; set; }
        public int 系統區域 { get; set; }
        public ObservableCollection<登入者群組> 登入者群組 { get; set; }
    }

    public class 選單群組不顯示的登入者選單
    {
        public string 登入者帳號 { get; set; }
        public string 群組代碼 { get; set; }
        public string 法會場次 { get; set; }
        public string 程式代碼 { get; set; }
        public string 程式名稱 { get; set; }
        public string 程式是否停用 { get; set; }
        public string 新增 { get; set; }
        public string 刪除 { get; set; }
        public string 修改 { get; set; }
        public string 查詢 { get; set; }
        public string 列印 { get; set; }
        public string right1 { get; set; }
        public string right2 { get; set; }
        public string right_r { get; set; }
        public object 程式說明 { get; set; }
        public string 系統代碼 { get; set; }
        public string 是否停用 { get; set; }
        public string 是否有特殊權限 { get; set; }
        public string 權限管制種類 { get; set; }
        public string 程式exe { get; set; }
        public string 備註 { get; set; }
        public int parentID { get; set; }
        public int id { get; set; }
        public int level { get; set; }
        public string name { get; set; }
        public int sort { get; set; }
        public int 節點流水號 { get; set; }
        public int 上層節點流水號 { get; set; }
        public int 階層 { get; set; }
        public string 節點名稱 { get; set; }
        public string 網址 { get; set; }
        public int 節點排序 { get; set; }
        public string 開啟方式 { get; set; }
        public int 系統區域設定 { get; set; }
        public string 是否顯示 { get; set; }
        public string logInfor { get; set; }
    }

    public class 選單群組不顯示的登入者角色基本權限最大化
    {
        public string 程式代碼 { get; set; }
        public string 程式名稱 { get; set; }
        public string 程式是否停用 { get; set; }
        public string 新增 { get; set; }
        public string 刪除 { get; set; }
        public string 修改 { get; set; }
        public string 查詢 { get; set; }
        public string 列印 { get; set; }
        public string right1 { get; set; }
        public string right2 { get; set; }
        public string right_r { get; set; }
    }

    public class 登入者群組
    {
        public string 群組代碼 { get; set; }
        public string 群組名稱 { get; set; }
        public string 群組備註 { get; set; }
        public string 群組是否停用 { get; set; }
        public string 群組停用原因 { get; set; }
        public object 群組停用日期時間 { get; set; }
        public string 群組轉向程式代碼 { get; set; }
        public 登入者群組對應項目[] 登入者群組對應項目 { get; set; }
        public 登入者群組角色[] 登入者群組角色 { get; set; }
        public 登入者群組角色權限最大值[] 登入者群組角色權限最大值 { get; set; }
        public 登入者群組選單[] 登入者群組選單 { get; set; }
    }

    public class 登入者群組對應項目
    {
        public string 群組代碼 { get; set; }
        public string 系統代碼 { get; set; }
        public string 群組名稱 { get; set; }
        public string 對應項目名稱 { get; set; }
        public string 對應項目值 { get; set; }
        public string 說明 { get; set; }
    }

    public class 登入者群組角色
    {
        public string 角色代碼 { get; set; }
        public string 角色名稱 { get; set; }
        public string 角色是否停用 { get; set; }
        public string 角色停用原因 { get; set; }
        public object 角色停用日期時間 { get; set; }
        public 登入者角色權限[] 登入者角色權限 { get; set; }
        public 登入者角色特殊授權[] 登入者角色特殊授權 { get; set; }
    }

    public class 登入者角色權限
    {
        public string 角色代碼 { get; set; }
        public string 程式代碼 { get; set; }
        public string 程式名稱 { get; set; }
        public string 程式是否停用 { get; set; }
        public string 是否有特殊權限 { get; set; }
        public string 新增 { get; set; }
        public string 刪除 { get; set; }
        public string 修改 { get; set; }
        public string 查詢 { get; set; }
        public string 列印 { get; set; }
        public object right1 { get; set; }
        public object right2 { get; set; }
        public object right_r { get; set; }
    }

    public class 登入者角色特殊授權
    {
        public int 流水號 { get; set; }
        public string 角色代碼 { get; set; }
        public string 特殊授權代碼 { get; set; }
        public string 特殊授權值 { get; set; }
        public string 系統代碼 { get; set; }
        public string 程式代碼 { get; set; }
        public string 特殊權限代碼 { get; set; }
        public string 特殊權限欄位 { get; set; }
        public string 特殊權限名稱 { get; set; }
        public string 特殊權限值 { get; set; }
        public string 特殊權限說明 { get; set; }
    }

    public class 登入者群組角色權限最大值
    {
        public string 程式代碼 { get; set; }
        public string 程式名稱 { get; set; }
        public string 程式是否停用 { get; set; }
        public string 新增 { get; set; }
        public string 刪除 { get; set; }
        public string 修改 { get; set; }
        public string 查詢 { get; set; }
        public string 列印 { get; set; }
        public string right1 { get; set; }
        public string right2 { get; set; }
        public string right_r { get; set; }
    }

    public class 登入者群組選單
    {
        public string 登入者帳號 { get; set; }
        public string 群組代碼 { get; set; }
        public string 法會場次 { get; set; }
        public string 程式代碼 { get; set; }
        public string 程式名稱 { get; set; }
        public string 程式是否停用 { get; set; }
        public string 新增 { get; set; }
        public string 刪除 { get; set; }
        public string 修改 { get; set; }
        public string 查詢 { get; set; }
        public string 列印 { get; set; }
        public string right1 { get; set; }
        public string right2 { get; set; }
        public string right_r { get; set; }
        public object 程式說明 { get; set; }
        public string 系統代碼 { get; set; }
        public string 是否停用 { get; set; }
        public string 是否有特殊權限 { get; set; }
        public string 權限管制種類 { get; set; }
        public string 程式exe { get; set; }
        public string 備註 { get; set; }
        public int parentID { get; set; }
        public int id { get; set; }
        public int level { get; set; }
        public string name { get; set; }
        public int sort { get; set; }
        public int 節點流水號 { get; set; }
        public int 上層節點流水號 { get; set; }
        public int 階層 { get; set; }
        public string 節點名稱 { get; set; }
        public string 網址 { get; set; }
        public int 節點排序 { get; set; }
        public string 開啟方式 { get; set; }
        public int 系統區域設定 { get; set; }
        public string 是否顯示 { get; set; }
        public string logInfor { get; set; }
    }
}