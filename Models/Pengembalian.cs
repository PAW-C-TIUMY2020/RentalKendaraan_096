using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_096.Models
{
    public partial class Pengembalian
    {

        [Required(ErrorMessage = "Id Pengembalian wajib diisi!")]
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tgl Pengembalian wajib diisi!")]
        public DateTime? TglPengembalian { get; set; }

        [Required(ErrorMessage = "Id Peminjaman wajib diisi!")]
        public int? IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Id Kondisi wajib diisi!")]
        public int? IdKondisi { get; set; }

        [Required(ErrorMessage = "Denda wajib diisi!")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
