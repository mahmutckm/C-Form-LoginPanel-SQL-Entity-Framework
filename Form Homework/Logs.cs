using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Homework
{
    public class Logs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 hane olmalıdır.")]
        public string TC { get; set; }
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Sifre { get; set; }
        public DateTime SistemGirisTarih { get; set; }
        public int BeniHatırla { get; set; }
        public string IPAdress {  get; set; }
        public override string ToString()
        {
            return "Id:" + Id + " " + "TC:" + TC + " " + "Sifre:" + " " + Sifre + " " + "SistemGiris:" + " " + SistemGirisTarih;
        }
    }
}
