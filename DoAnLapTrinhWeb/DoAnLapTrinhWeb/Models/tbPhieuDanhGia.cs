﻿using Microsoft.AspNetCore.Identity;

namespace DoAnLapTrinhWeb.Models
{
    public class tbPhieuDanhGia
    {
        public int Id { get; set; }

        public int sachId { get; set; }
        public tbSach tbSach { get; set; }


        public long diem { get; set; }

        public string userId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
