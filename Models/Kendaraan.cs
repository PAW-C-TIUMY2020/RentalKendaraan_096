using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_096.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        [Required(ErrorMessage = "Id Kendaraan wajib diisi!")]
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan wajib diisi!")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi wajib diisi!")]
        public string NoPolisi { get; set; }

        [Required(ErrorMessage = "No Stnk wajib diisi!")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public string NoStnk { get; set; }

        [Required(ErrorMessage = "Id Jenis Kendaraan wajib diisi!")]
        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan wajib diisi!")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
