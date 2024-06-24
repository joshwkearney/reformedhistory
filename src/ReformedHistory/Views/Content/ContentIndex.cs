using ReformedHistory.Models;

namespace ReformedHistory.Views.Content;

public class ContentIndex {
    private static IReadOnlyList<TimelineEventModel> Timelime { get; } = [
        new TimelineEventModel() {
            Title = "Westminster Confession of Faith",
            DateStart = 1646,
            DateEnd = 1646,
            Url = "~/Content/Documents/WestminsterConfession",
            Description = "Drawn up by the 1646 Westminster Assembly, the Westminster Confession is the most widely " +
                          "adopted reformed confession in the world. It is used for doctrinal standards of " +
                          "presbyterians, Dutch Reformed, and others."
        },
        new TimelineEventModel() {
            Title = "The Epistle of Leo to Flavian",
            DateStart = 449,
            DateEnd = 449,
            Url = "~/Content/Letters/LeoToFlavian",
            Description = "Leo, the bishop of Rome, writes to Flavian, the bishop of Constantinople, in order to give " +
                          "an orthodox explanation of Christ's two natures. This letter was accepted by the Council of " +
                          "Chalcedon as orthodox Christology."
        },
        new TimelineEventModel() {
            Title = "The Second Letter of Jerome to Evangelus",
            DateStart = 342,
            DateEnd = 420,
            Url = "~/Content/Letters/JeromeToEvangelus2",
            Description = "Jerome proves from the scriptures that presbyters are the same as bishops, and over deacons."
        },
        new TimelineEventModel() {
            Title = "The Nicean Creed",
            DateStart = 325,
            DateEnd = 381,
            Url = "~/Content/Documents/NiceneCreed",
            Description = "The Nicene Creed, as expanded at the first council of Constantinople, is the most widely " +
                          "adopted creed in the world and represents the standard for orthodox Christianity."
        }
    ];

    public IReadOnlyList<TimelineEventModel> GetTimeline() {
        return Timelime;
    }
}