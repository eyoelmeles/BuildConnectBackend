﻿using BuildConnectBackend.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildConnectBackend.Model
{
    public class MaterialReport : BaseModel
    {
        [Required]
        public string TypeOfMaterial { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
        [Required]
        public string Unit { get; set; } = string.Empty;
        [Required]
        public string Delivered { get; set; } = string.Empty;
        [Required]
        public string Remark { get; set; } = string.Empty;
        [Required]
        public DateTime ToDate { get; set; }
        public Guid DailyReportId { get; set; }
        [ForeignKey("DailyReportId")]
        public DailyReport DailyReport { get; set; }
    }
}

