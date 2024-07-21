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
                          "presbyterians, Dutch Reformed, and others.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Synod of Dort",
            DateStart = 1618,
            DateEnd = 1618,
            Url = "~/Content/Councils/Dort",
            Description = "Dort was a council of nine reformed countries convened to repudiate the teachings of Jacob " +
                          "Arminius outlined in the Articles of Remonstrance",
            Type = TimelineEventType.Council,
            Tradition = TimelineEventTradition.Calvinist,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Five Articles of Remonstrance",
            DateStart = 1610,
            DateEnd = 1610,
            Url = "~/Content/Documents/ArticlesOfRemonstrance",
            Description = "Written by 43 dutch reformed pastors after the death of Jacob Arminius in 1609, the articles of " +
                          "remonstrance articulated five points of concern with reformed theology.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Saxon Visitation Articles",
            DateStart = 1592,
            DateEnd = 1592,
            Url = "~/Content/Documents/ArticlesOfSaxony",
            Description = "Commissioned by Frederick William against crypto-calvinism, the Saxon Visitation Aritcles " +
                          "describe four points where lutherans reject reformed doctrine.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Second Helvetic Confession",
            DateStart = 1562,
            DateEnd = 1562,
            Url = "~/Content/Documents/SecondHelveticConfession",
            Description = "Originally written by Heinrich Bullinger as a private exercise, the Second Helvetic " +
                          "Confession was translated into German at the request of Frederick III. It came to be a " +
                          "popular confession among the Swiss reformed churches.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Scots Confession",
            DateStart = 1560,
            DateEnd = 1560,
            Url = "~/Content/Documents/ScotsConfession",
            Description = "Written by John Knox, the Scots Confession was the foundational document in the Scottish " +
                          "reformation and presbyterianism",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Smalcald Articles",
            DateStart = 1537,
            DateEnd = 1537,
            Url = "~/Content/Documents/SmalcaldArticles",
            Description = "The Smaldald Articles were written by Martin Luther to summarize lutheran doctrine for the " +
                          "Schmalkaldic League. They were adopted into the book of concord in 1580",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Augsburg Confession",
            DateStart = 1530,
            DateEnd = 1530,
            Url = "~/Content/Documents/AugsburgConfession",
            Description = "One of the most important reformation confessions, the Augsburg Confession was presented " +
                          "to Holy Roman Emperor Charles V after the Lutherans were summoned to explain their " +
                          "theological convictions",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Zwingli's 67 Articles",
            DateStart = 1523,
            DateEnd = 1523,
            Url = "~/Content/Documents/ArticlesOfZwingli",
            Description = "Written by Ulrich Zwingli in 1523 as a defense of his protestant theology, these articles " +
                          "would begin the Swiss Reformation.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Era() {
            Title = "The Protestant Reformation",
            Date = 1517
        },
        new TimelineInfo.Event() {
            Title = "The Four Articles of Prague",
            DateStart = 1420,
            DateEnd = 1420,
            Url = "~/Content/Documents/ArticlesOfPrague",
            Description = "Written by the followers of John Hus after his execution, the articles outline four reforms " +
                          "wanted by the proto-protestant Bohemian reformers.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Medieval
        },
        new TimelineInfo.Event() {
            Title = "The Waldensian Confession",
            DateStart = 1180,
            DateEnd = 1180,
            Url = "~/Content/Documents/WaldensianConfession",
            Description = "Written by Peter Waldo, this confession outlined the faith of the proto-protestant " +
                          "Waldensians, who would later join the reformed churches.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist,
            Era = TimelineEventEra.Medieval
        },
        new TimelineInfo.Era() {
            Title = "The Great East-West Schism",
            Date = 1054
        },
        new TimelineInfo.Event() {
            Title = "The Second Council of Orange",
            DateStart = 529,
            DateEnd = 529,
            Url = "~/Content/Councils/Orange2",
            Description = "Convened to address semi-Pelagianism, the second council of Orange emphasized the necessity " +
                          "of grace and the inability of man to seek God without grace",
            Type = TimelineEventType.Council,
            Tradition = TimelineEventTradition.Calvinist | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Epistle of Leo to Flavian",
            DateStart = 449,
            DateEnd = 449,
            Url = "~/Content/Letters/LeoToFlavian",
            Description = "Leo, the bishop of Rome, writes to Flavian, the bishop of Constantinople, in order to give " +
                          "an orthodox explanation of Christ's two natures. This letter was accepted by the Council of " +
                          "Chalcedon as orthodox Christology.",
            Type = TimelineEventType.Letter,
            Tradition = TimelineEventTradition.Calvinist | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Second Letter of Jerome to Evangelus",
            DateStart = 342,
            DateEnd = 420,
            Url = "~/Content/Letters/JeromeToEvangelus2",
            Description = "Jerome proves from the scriptures that presbyters are the same as bishops, and over deacons.",
            Type = TimelineEventType.Letter,
            Tradition = TimelineEventTradition.Calvinist | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "Augustine's Sermon on the Eucharist",
            DateStart = 407,
            DateEnd = 411,
            Url = "~/Content/Documents/AugustineOnTheEucharist",
            Description = "Augustine explains that the Eucharist is the body of Christ, that it is grapsed by faith, " +
                          "and that it is composed of believers",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Nicean Creed",
            DateStart = 325,
            DateEnd = 381,
            Url = "~/Content/Documents/NiceneCreed",
            Description = "The Nicene Creed, as expanded at the first council of Constantinople, is the most widely " +
                          "adopted creed in the world and represents the standard for orthodox Christianity.",
            Type = TimelineEventType.Document,
            Tradition = TimelineEventTradition.Calvinist | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Ancient
        }
    ];

    public IReadOnlyList<TimelineInfo> GetTimeline() {
        return Timelime;
    }
}