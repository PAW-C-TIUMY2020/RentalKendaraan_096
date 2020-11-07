using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_096.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        [Required(ErrorMessage = "Id Jaminan wajib diisi!")]
        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Nama Jaminan wajib diisi!")]
        public string NamaJaminan { get; set; }

        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
