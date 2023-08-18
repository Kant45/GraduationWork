namespace GraduationWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipment")]
    public partial class Equipment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Вид { get; set; }

        [StringLength(50)]
        public string Тип { get; set; }

        [StringLength(50)]
        public string Модель { get; set; }

        [StringLength(50)]
        public string Компания { get; set; }

        [StringLength(50)]
        public string Филиал { get; set; }

        [StringLength(50)]
        public string Статус { get; set; }

        [StringLength(50)]
        public string Сотрудник { get; set; }

        [Column("Серийный номер")]
        [StringLength(50)]
        public string Серийный_номер { get; set; }

        [Column("Инвентарный номер")]
        [StringLength(50)]
        public string Инвентарный_номер { get; set; }

        [Column("Номер партии")]
        [StringLength(50)]
        public string Номер_партии { get; set; }

        [StringLength(50)]
        public string Место { get; set; }

        [Column("Код продукта")]
        [StringLength(50)]
        public string Код_продукта { get; set; }

        public int? Количество { get; set; }

        [Column("Стоимость (руб.)")]
        public decimal? Стоимость__руб__ { get; set; }

        [Column("Сумма (руб.)")]
        public decimal? Сумма__руб__ { get; set; }

        [StringLength(50)]
        public string Поставщик { get; set; }

        [Column("Сервисная организация")]
        [StringLength(50)]
        public string Сервисная_организация { get; set; }

        [Column("Дата инвентаризации", TypeName = "date")]
        public DateTime? Дата_инвентаризации { get; set; }

        [Column("Гарантия до", TypeName = "date")]
        public DateTime? Гарантия_до { get; set; }

        [Column("Лицензия до", TypeName = "date")]
        public DateTime? Лицензия_до { get; set; }

        [Column("Дата списания", TypeName = "date")]
        public DateTime? Дата_списания { get; set; }

        [Column("Дата создания", TypeName = "date")]
        public DateTime? Дата_создания { get; set; }

        [Column("Id заказа")]
        public long? Id_заказа { get; set; }

        [Column("Не участвует в инвентаризации")]
        public bool? Не_участвует_в_инвентаризации { get; set; }

        [StringLength(50)]
        public string Домен { get; set; }

        [Column("Сетевое имя")]
        [StringLength(50)]
        public string Сетевое_имя { get; set; }

        [Column("IP адрес")]
        [StringLength(50)]
        public string IP_адрес { get; set; }

        [Column("MAC адрес")]
        [StringLength(50)]
        public string MAC_адрес { get; set; }

        [StringLength(50)]
        public string Изменил { get; set; }

        [Column("Дата изменения")]
        public DateTime? Дата_изменения { get; set; }
    }
}
