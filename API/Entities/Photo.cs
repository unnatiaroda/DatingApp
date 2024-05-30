using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }
    public string Url { get; set; }
    public bool IsMain { get; set; }
    public string PublicId { get; set; }

    //Below properties make sure that:
    //the AppUserId property that will be created as foreign key from AppUser table, will not be nullable
    //and also add the onDelete behaviour which makes sure the deletion of the photos with deletion of the related user
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }

    //we mention the AppUser as an attribute here to make sure the Photos entity knows ehere to get the AppUserId as Foreign Key
}