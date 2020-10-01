using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinhvien5tot.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage = "Hãy điền tên tài khoản", AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Hãy điền mật khẩu", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Mật khẩu lớn hoen 8 ký tự")]
        public string Password { get; set; }
        //[Compare("Password", ErrorMessage = "Confirm password dose not match.")]
        //[DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        //public virtual string ConfirmPassword
        //{
        //    get;
        //    set;
        //}
        [Required(ErrorMessage = "Hãy điền tên đầy đủ của bạn", AllowEmptyStrings = false)]
        [Display(Name = "Họ và tên")]
        public string Hoten { get; set; }
        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
        
        [Display(Name = "Lớp")]
        public string Lop { get; set; }
        [Display(Name = "Khoá")]
        public string Khoa { get; set; }
        [Display(Name = "Mã số sinh viên")]
        public int MaSoSinhVien { get; set; }
        [Display(Name = "Viện đào tạo")]
        public string Vien { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        public string SoDT { get; set; }
        [Display(Name = "SecurityString")]
        public string SecurityString { get; set; }

        [Display(Name = "Quyền")]
        public string Quyen { get; set; }

    }
}