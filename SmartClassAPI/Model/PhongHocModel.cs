﻿using SmartClassAPI.Data;
using System.Collections.Generic;

namespace SmartClassAPI.Model
{
    public class PhongHocModel
    {
        public string TenPhongHoc { get; set; }
        public string MaPhongHoc { get; set; }
        public string MoTa { get; set; }
        public int TinhTrang { get; set; }
    }
    public class PhongHocVM : PhongHocModel
    {
        public int IdPhongHoc { get; set; }
        public virtual List<MonHoc> MonHocs { get; internal set; }
    }
}
