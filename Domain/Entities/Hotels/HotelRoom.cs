using Domain.Common;
using Domain.Entities.Administration;
using Domain.Entities.Catalogs;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

[PrimaryKey(nameof(Id), nameof(HotelId))]
public class HotelRoom : BaseEntity 
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int HotelId { get; set; }

    public int RoomTypeId { get; set; }

    public int RoomNumber { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }

    [ForeignKey(nameof(RoomTypeId))]
    public RoomType RoomType { get; set; }
}