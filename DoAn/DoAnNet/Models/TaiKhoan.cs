//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;

    public partial class TaiKhoan
    {
        [Required(ErrorMessage = "   *(User name is required)")]
        [StringLength(50, ErrorMessage = "Chieu dai ten khong qua 50 ki tu")]
        [Display(Name = "User name")]
        public string TenTaiKhoan { get; set; }
        [Required(ErrorMessage = "   *(Password is required)")]
        [StringLength(255)]
        [Display(Name = "Password")]
        public string MatKhau { get; set; }

        public string Email { get; set; }
        public string Quyen { get; set; }

        [Display(Name = "Display name")]
        public string TenHienThi { get; set; }
    }
}
