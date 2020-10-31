using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_096.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [Key]
        [DisplayName("ID")]
        public int IdPeminjaman { get; set; }
        [DisplayName("Tanggal Peminjaman")]
        public DateTime? TglPeminjaman { get; set; }
        [DisplayName("Kendaraan")]
        public int? IdKendaraan { get; set; }
        [DisplayName("Customer")]

        public int? IdCostumer { get; set; }
        [DisplayName("Jaminan")]

        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }
        [DisplayName("Customer")]

        public Customer IdCostumerNavigation { get; set; }
        [DisplayName("Jaminan")]

        public Jaminan IdJaminanNavigation { get; set; }
        [DisplayName("Kendaraan")]

        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
