using Domain.Common;
using Domain.Entities.Catalogs;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hotels;

[PrimaryKey(nameof(Id), nameof(HotelId))]
public class HotelGuest : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int HotelId { get; set; }
    public int GuestTypeId { get; set; }

    [ForeignKey(nameof(GuestTypeId))]
    public GuestType Guest { get; set; }

    [ForeignKey(nameof(HotelId))]
    public Hotel Hotel { get; set; }
}
