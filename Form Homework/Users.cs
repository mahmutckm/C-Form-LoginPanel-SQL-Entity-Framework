using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Form_Homework
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 hane olmalıdır.")]
        public string TC {  get; set; }
        [StringLength(30, ErrorMessage = "Max 30 Karakter Girilebilir")]
        public string Ad { get; set; }
        [StringLength(30, ErrorMessage = "Max 30 Karakter Girilebilir")]
        public string Soyad { get; set; }
        public string Cinsiyet {  get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Sifre {  get; set; }
        public byte[] Photo { get; set; }
        public DateTime KayıtTarih { get; set; }
        public override string ToString()
        {
            return "Id:" + Id + " " + "TC:" + TC + " " + "Ad:" + " " + Ad + " " + "Soyad:" + " " + Soyad + " " + "Şifre:" + " " + Sifre + " " + "Kayıt Zamanı:" + " " + KayıtTarih;
        }
    }
}
