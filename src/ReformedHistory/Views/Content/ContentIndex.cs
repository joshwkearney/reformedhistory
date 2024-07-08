using ReformedHistory.Models;

namespace ReformedHistory.Views.Content;

public class ContentIndex {
    private static IReadOnlyList<TimelineInfo> Timelime { get; } = [
        new TimelineInfo.Event() {
            Title = "Westminster Confession of Faith",
            DateStart = 1646,
            DateEnd = 1646,
            Url = "~/Content/Documents/WestminsterConfession",
            Description = "Drawn up by the 1646 Westminster Assembly, the Westminster Confession is the most widely " +
                          "adopted reformed confession in the world. It is used for doctrinal standards of " +
                          "presbyterians, Dutch Reformed, and others."
        },
        new TimelineInfo.Event() {
            Title = "The Five Articles of Remonstrance",
            DateStart = 1610,
            DateEnd = 1610,
            Url = "~/Content/Documents/ArticlesOfRemonstrance",
            Description = "Written 43 dutch reformed pastors after the death of Jacob Arminius in 1609, the articles of " +
                          "remonstrance articulated five points of concern with reformed theology."
        },
        new TimelineInfo.Event() {
            Title = "Second Helvetic Confession",
            DateStart = 1562,
            DateEnd = 1562,
            Url = "~/Content/Documents/SecondHelveticConfession",
            Description = "Originally written by Heinrich Bullinger as a private exercise, the Second Helvetic " +
                          "Confession was translated into German at the request of Frederick III. It came to be a " +
                          "popular confession among the Swiss reformed churches."
        },
        new TimelineInfo.Era() {
            Title = "The Protestant Reformation",
            Date = 1517
        },
        new TimelineInfo.Event() {
            Title = "The Second Council of Orange",
            DateStart = 529,
            DateEnd = 529,
            Url = "~/Content/Councils/Orange2",
            Description = "Convened to address semi-Pelagianism, the second council of Orange emphasized the necessity " +
                          "of grace and the inability of man to seek God without grace"
        },
        new TimelineInfo.Event() {
            Title = "The Epistle of Leo to Flavian",
            DateStart = 449,
            DateEnd = 449,
            Url = "~/Content/Letters/LeoToFlavian",
            Description = "Leo, the bishop of Rome, writes to Flavian, the bishop of Constantinople, in order to give " +
                          "an orthodox explanation of Christ's two natures. This letter was accepted by the Council of " +
                          "Chalcedon as orthodox Christology."
        },
        new TimelineInfo.Event() {
            Title = "The Second Letter of Jerome to Evangelus",
            DateStart = 342,
            DateEnd = 420,
            Url = "~/Content/Letters/JeromeToEvangelus2",
            Description = "Jerome proves from the scriptures that presbyters are the same as bishops, and over deacons."
        },
        new TimelineInfo.Event() {
            Title = "The Nicean Creed",
            DateStart = 325,
            DateEnd = 381,
            Url = "~/Content/Documents/NiceneCreed",
            Description = "The Nicene Creed, as expanded at the first council of Constantinople, is the most widely " +
                          "adopted creed in the world and represents the standard for orthodox Christianity."
        }
    ];

    public IReadOnlyList<TimelineInfo> GetTimeline() {
        return Timelime;
    }
}