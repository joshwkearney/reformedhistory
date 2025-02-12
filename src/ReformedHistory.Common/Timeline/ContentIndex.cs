using ReformedHistory.Models;
using System;

namespace ReformedHistory.Views.Content;

public class ContentIndex {
    private static IReadOnlyList<TimelineInfo> Timelime { get; } = [
        new TimelineInfo.Event() {
            Title = "Westminster Shorter Catechism",
            DateStart = 1647,
            DateEnd = 1647,
            Url = "~/Content/Catechisms/WestminsterShorter",
            Description = "The Westminster Shorter Catechism, written alongside the longer, was based upon the Heidelberg " +
                          "Catechism and Calvin's Geneva Catechism to instruct children and families on the Christian faith. " +
                          "It provides a concise summary of Reformed doctrine and is capable of being memorized at any age.",
            Type = TimelineEventType.Catechism,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Westminster Larger Catechism",
            DateStart = 1647,
            DateEnd = 1647,
            Url = "~/Content/Catechisms/WestminsterLarger",
            Description = "The Westminster Larger Catechism, written alongside the shorter, " +
                          "was designed to supplement and expand upon the contents of the Shorter. It presents " +
                          "a full and balanced summary of the Christian faith and is more suitable for those who " +
                          "have attained some level of spiritual maturity",
            Type = TimelineEventType.Catechism,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Westminster Confession of Faith",
            DateStart = 1646,
            DateEnd = 1646,
            Url = "~/Content/Confessions/WestminsterConfession",
            Description = "Drawn up by the 1646 Westminster Assembly, the Westminster Confession is the most widely " +
                          "adopted reformed confession in the world. It is used for doctrinal standards of " +
                          "presbyterians, Dutch Reformed, and others.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed,
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
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Five Articles of Remonstrance",
            DateStart = 1610,
            DateEnd = 1610,
            Url = "~/Content/Confessions/ArticlesOfRemonstrance",
            Description = "Written by 43 dutch reformed pastors after the death of Jacob Arminius in 1609, the articles of " +
                          "remonstrance articulated five points of concern with reformed theology.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Saxon Visitation Articles",
            DateStart = 1592,
            DateEnd = 1592,
            Url = "~/Content/Confessions/ArticlesOfSaxony",
            Description = "Commissioned by Frederick William against crypto-calvinism, the Saxon Visitation Aritcles " +
                          "describe four points where lutherans reject reformed doctrine.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "39 Articles of Religion",
            DateStart = 1571,
            DateEnd = 1571,
            Url = "~/Content/Confessions/ThirtyNineArticles",
            Description = "Written after Henry VIII broke with the Roman church, the 39 articles created a via media " +
                          "between catholic and protestant doctrine, and would be the standard for the Church of England",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Anglican | TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Heidelberg Catechism",
            DateStart = 1563,
            DateEnd = 1563,
            Url = "~/Content/Catechisms/Heidelberg",
            Description = "Commissioned by Frederick III to unite the faith of his territories, the Heidelberg " +
                          "catechism would quickly become the greatest of the reformed catechisms, and is one of the " +
                          "three forms of unity of the reformed churches in Europe.",
            Type = TimelineEventType.Catechism,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Second Helvetic Confession",
            DateStart = 1562,
            DateEnd = 1562,
            Url = "~/Content/Confessions/SecondHelveticConfession",
            Description = "Originally written by Heinrich Bullinger as a private exercise, the Second Helvetic " +
                          "Confession was translated into German at the request of Frederick III. It came to be a " +
                          "popular confession among the Swiss reformed churches.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Belgic Confession",
            DateStart = 1561,
            DateEnd = 1561,
            Url = "~/Content/Confessions/BelgicConfession",
            Description = "Written by Guido de Brès before his martyrdom, the Belgic confession is the primary " +
                          "confession of the Dutch reformed church, and also one of the Three Forms of Unity.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Scots Confession",
            DateStart = 1560,
            DateEnd = 1560,
            Url = "~/Content/Confessions/ScotsConfession",
            Description = "Written by John Knox, the Scots Confession was the foundational document in the Scottish " +
                          "reformation and presbyterianism",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Smalcald Articles",
            DateStart = 1537,
            DateEnd = 1537,
            Url = "~/Content/Confessions/SmalcaldArticles",
            Description = "The Smaldald Articles were written by Martin Luther to summarize lutheran doctrine for the " +
                          "Schmalkaldic League. They were adopted into the book of concord in 1580",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "The Augsburg Confession",
            DateStart = 1530,
            DateEnd = 1530,
            Url = "~/Content/Confessions/AugsburgConfession",
            Description = "One of the most important reformation confessions, the Augsburg Confession was presented " +
                          "to Holy Roman Emperor Charles V after the Lutherans were summoned to explain their " +
                          "theological convictions",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Zwingli's 67 Articles",
            DateStart = 1523,
            DateEnd = 1523,
            Url = "~/Content/Confessions/ArticlesOfZwingli",
            Description = "Written by Ulrich Zwingli in 1523 as a defense of his protestant theology, these articles " +
                          "would begin the Swiss Reformation.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.Event() {
            Title = "Luther's Ninety-Five Theses",
            DateStart = 1517,
            DateEnd = 1517,
            Url = "~/Content/Confessions/95Theses",
            Description = "Written by Martin Luther in 1517 to address the practice of selling " +
                          "indulgences, the ninety-five thesis presented a critique of the medieval church that " +
                          "kicked off the protestant reformation.",
            Type = TimelineEventType.Letter,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Reformation
        },
        new TimelineInfo.EraBoundary() {
            Title = "The Protestant Reformation",
            Date = 1517,
            Era = TimelineEventEra.Reformation | TimelineEventEra.Medieval
        },
        new TimelineInfo.Event() {
            Title = "The Four Articles of Prague",
            DateStart = 1420,
            DateEnd = 1420,
            Url = "~/Content/Confessions/ArticlesOfPrague",
            Description = "Written by the followers of John Hus after his execution, the articles outline four reforms " +
                          "wanted by the proto-protestant Bohemian reformers.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Medieval
        },
        new TimelineInfo.Event() {
            Title = "The Waldensian Confession",
            DateStart = 1180,
            DateEnd = 1180,
            Url = "~/Content/Confessions/WaldensianConfession",
            Description = "Written by Peter Waldo, this confession outlined the faith of the proto-protestant " +
                          "Waldensians, who would later join the reformed churches.",
            Type = TimelineEventType.Confession,
            Tradition = TimelineEventTradition.Reformed,
            Era = TimelineEventEra.Medieval
        },
        new TimelineInfo.EraBoundary() {
            Title = "The Great East-West Schism",
            Date = 1054,
            Era = TimelineEventEra.Ancient | TimelineEventEra.Medieval
        },
        new TimelineInfo.Event() {
            Title = "The Second Council of Orange",
            DateStart = 529,
            DateEnd = 529,
            Url = "~/Content/Councils/Orange2",
            Description = "Convened to address semi-Pelagianism, the second council of Orange emphasized the necessity " +
                          "of grace and the inability of man to seek God without grace",
            Type = TimelineEventType.Council,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Council of Chalcedon",
            DateStart = 451,
            DateEnd = 451,
            Url = "~/Content/Councils/Chalcedon",
            Description = "Chalcedon sought to uphold the two natures of Christ without confusion or admixture against " +
                          "the monophysites, the error opposite of Nestorianism",
            Type = TimelineEventType.Council,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
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
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Council of Ephesus",
            DateStart = 431,
            DateEnd = 431,
            Url = "~/Content/Councils/Ephesus",
            Description = "Called in 431 to address the teachings of Nestorius, the Council of Ephesus " +
                          "reaffirmed unity of Christ's two natures, that Christ's person is fully God, and the " +
                          "propriety of calling Mary the mother of God.",
            Type = TimelineEventType.Council,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Second Epistle of Cyril to Nestorius",
            DateStart = 430,
            DateEnd = 430,
            Url = "~/Content/Letters/CyrilToNestorius2",
            Description = "Cyril again writes to Nestorius on behalf of a council convened at Alexandria, urging him " +
                          "to repent of his heresy and layout out right doctrine",
            Type = TimelineEventType.Letter,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The First Epistle of Cyril to Nestorius",
            DateStart = 429,
            DateEnd = 429,
            Url = "~/Content/Letters/CyrilToNestorius1",
            Description = "Cyril, the bishop of Alexandria, admonishes Nestorius for his seperation of the two " +
                          "natures of Christ, and refusing to say Mary is the mother of God.",
            Type = TimelineEventType.Letter,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Second Letter of Jerome to Evangelus",
            DateStart = 420,
            DateEnd = 420,
            Url = "~/Content/Letters/JeromeToEvangelus2",
            Description = "Jerome proves from the scriptures that presbyters are the same as bishops, and over deacons.",
            Type = TimelineEventType.Letter,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "Augustine's Sermon on the Eucharist",
            DateStart = 411,
            DateEnd = 411,
            Url = "~/Content/Sermons/AugustineOnTheEucharist",
            Description = "Augustine explains that the Eucharist is the body of Christ, that it is grapsed by faith, " +
                          "and that it is composed of believers",
            Type = TimelineEventType.Sermon,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The First Council of Constantinople",
            DateStart = 381,
            DateEnd = 381,
            Url = "~/Content/Councils/Constantinople1",
            Description = "Called by Emporer in 381 to reaffirm the Nicean faith, the first council of Constantinople " +
                          "expanded the Nicean creed's section on the Holy Spirit. This was a local eastern " +
                          "synod that was recognized as ecumenical at Chalcedon in 451.",
            Type = TimelineEventType.Council,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "Athanasius On Luke 10:22 and Matthew 11:27",
            DateStart = 330,
            DateEnd = 330,
            Url = "~/Content/Commentaries/AthanasiusOnLuke1022Matthew1127",
            Description = "Combatting the Arian heresy, Athansius writes on Luke 10:22 and Matthew 11:27 seeking to prove the " +
                          "eternal unity of the Father and the Son, and to refute the Arian interpretation of these passages.",
            Type = TimelineEventType.Commentary,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        },
        new TimelineInfo.Event() {
            Title = "The Council of Nicea",
            DateStart = 325,
            DateEnd = 325,
            Url = "~/Content/Councils/Nicea",
            Description = "Called by Emporer Constantine in 325 to address the Arian controversy, the Council of Nicea " +
                          "reaffirmed the divinity of Christ and defined what would become the Nicean Creed.",
            Type = TimelineEventType.Council,
            Tradition = TimelineEventTradition.Reformed | TimelineEventTradition.Lutheran  | TimelineEventTradition.Anglican,
            Era = TimelineEventEra.Ancient
        }
	];

    public IReadOnlyList<TimelineInfo> GetTimeline() {
        return Timelime;
    }
}