using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_aile")]
    public partial class WorkAile
    {
        [Key]
        [Column("stuid")]
        [StringLength(11)]
        public string Stuid { get; set; }
        [Column("anne_hayat")]
        [StringLength(20)]
        public string AnneHayat { get; set; }
        [Column("baba_hayat")]
        [StringLength(20)]
        public string BabaHayat { get; set; }
        [Column("ebeveyn_durum")]
        [StringLength(20)]
        public string EbeveynDurum { get; set; }
        [Column("stu_yasam")]
        [StringLength(20)]
        public string StuYasam { get; set; }
        [Column("stu_kardes")]
        public int? StuKardes { get; set; }
        [Column("aile_gecim1")]
        [StringLength(5)]
        public string AileGecim1 { get; set; }
        [Column("aile_Sayi")]
        public int? AileSayi { get; set; }
        [Column("anne_ad")]
        [StringLength(50)]
        public string AnneAd { get; set; }
        [Column("anne_is")]
        [StringLength(30)]
        public string AnneIs { get; set; }
        [Column("anne_calisiyor")]
        [StringLength(30)]
        public string AnneCalisiyor { get; set; }
        [Column("anne_isyeri")]
        [StringLength(50)]
        public string AnneIsyeri { get; set; }
        [Column("anne_tel")]
        [StringLength(10)]
        public string AnneTel { get; set; }
        [Column("anne_gorev")]
        [StringLength(30)]
        public string AnneGorev { get; set; }
        [Column("anne_net_maas", TypeName = "money")]
        public decimal? AnneNetMaas { get; set; }
        [Column("anne_emekli")]
        [StringLength(5)]
        public string AnneEmekli { get; set; }
        [Column("anne_net_gelir", TypeName = "money")]
        public decimal? AnneNetGelir { get; set; }
        [Column("anne_diger")]
        [StringLength(30)]
        public string AnneDiger { get; set; }
        [Column("anne_toplam", TypeName = "money")]
        public decimal? AnneToplam { get; set; }
        [Column("baba_ad")]
        [StringLength(50)]
        public string BabaAd { get; set; }
        [Column("baba_is")]
        [StringLength(30)]
        public string BabaIs { get; set; }
        [Column("baba_calisiyor")]
        [StringLength(30)]
        public string BabaCalisiyor { get; set; }
        [Column("baba_isyeri")]
        [StringLength(50)]
        public string BabaIsyeri { get; set; }
        [Column("baba_tel")]
        [StringLength(10)]
        public string BabaTel { get; set; }
        [Column("baba_gorev")]
        [StringLength(30)]
        public string BabaGorev { get; set; }
        [Column("baba_net_maas", TypeName = "money")]
        public decimal? BabaNetMaas { get; set; }
        [Column("baba_emekli")]
        [StringLength(5)]
        public string BabaEmekli { get; set; }
        [Column("baba_net_gelir", TypeName = "money")]
        public decimal? BabaNetGelir { get; set; }
        [Column("baba_diger")]
        [StringLength(30)]
        public string BabaDiger { get; set; }
        [Column("baba_toplam", TypeName = "money")]
        public decimal? BabaToplam { get; set; }
        [Column("es_ad")]
        [StringLength(50)]
        public string EsAd { get; set; }
        [Column("es_is")]
        [StringLength(30)]
        public string EsIs { get; set; }
        [Column("es_calisiyor")]
        [StringLength(30)]
        public string EsCalisiyor { get; set; }
        [Column("es_isyeri")]
        [StringLength(50)]
        public string EsIsyeri { get; set; }
        [Column("es_tel")]
        [StringLength(10)]
        public string EsTel { get; set; }
        [Column("es_gorev")]
        [StringLength(30)]
        public string EsGorev { get; set; }
        [Column("es_net_maas", TypeName = "money")]
        public decimal? EsNetMaas { get; set; }
        [Column("es_emekli")]
        [StringLength(5)]
        public string EsEmekli { get; set; }
        [Column("es_net_gelir", TypeName = "money")]
        public decimal? EsNetGelir { get; set; }
        [Column("es_diger")]
        [StringLength(30)]
        public string EsDiger { get; set; }
        [Column("es_toplam", TypeName = "money")]
        public decimal? EsToplam { get; set; }
        [Column("aile_gecim2")]
        [StringLength(5)]
        public string AileGecim2 { get; set; }
        [Column("aile_gecim3")]
        [StringLength(5)]
        public string AileGecim3 { get; set; }
        [Column("aile_gecim4")]
        [StringLength(55)]
        public string AileGecim4 { get; set; }
        [Column("stu_yasam1")]
        [StringLength(50)]
        public string StuYasam1 { get; set; }
        [Column("anne_tc")]
        [StringLength(11)]
        public string AnneTc { get; set; }
        [Column("baba_tc")]
        [StringLength(11)]
        public string BabaTc { get; set; }
        [Column("es_tc")]
        [StringLength(11)]
        public string EsTc { get; set; }
    }
}
