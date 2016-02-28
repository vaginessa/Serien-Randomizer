using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SouthPark_Randomizer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Episode[] ep;     // South Park
        private Episode[] fam;    // Family Guy
        private Episode[] amer ;
        private Random rand;
        public MainWindow()
        {
            InitializeComponent();
            ep = new Episode[267];
            fam = new Episode[263];
            amer = new Episode[195] ;
            rand = new Random();
            Init();          
        }
        private void Init()
        {
            #region SouthPark
            //Season 1
            ep[0] = new Episode(1, 1, "Cartman Gets An Anal Probe", "http://www.southpark.de/alle-episoden/s01e01-cartman-und-die-analsonde", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e01-cartman-gets-an-anal-probe_4x3.jpg?width=320");
            ep[1] = new Episode(1, 2, "Weight Gain 4000", "http://www.southpark.de/alle-episoden/s01e02-wie-werde-ich-zum-kampfkoloss", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e03-volcano_4x3.jpg?width=320");
            ep[2] = new Episode(1, 3, "Volcano", "http://www.southpark.de/alle-episoden/s01e03-knall-endlich-den-hasen-ab", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e02-weight-gain-4000_4x3.jpg?width=320");
            ep[3] = new Episode(1, 4, "Big Gay Al's Big Gay Boat Ride", "http://www.southpark.de/alle-episoden/s01e04-ein-heim-f%C3%BCr-tiertunten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e04-big-gay-als-big-gay-boat-ride_4x3.jpg?width=320");
            ep[4] = new Episode(1, 5, "An Elephant Makes Love to a Pig", "http://www.southpark.de/alle-episoden/s01e05-tanz-der-mutanten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e05-an-elephant-makes-love-to-a-pig_4x3.jpg?width=320");
            ep[5] = new Episode(1, 6, "Death", "http://www.southpark.de/alle-episoden/s01e06-wer-killt-opa", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e06-death_4x3.jpg?width=320");
            ep[6] = new Episode(1, 7, "Pinkeye", "http://www.southpark.de/alle-episoden/s01e07-her-mit-dem-hirn", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e07-pinkeye_4x3.jpg?width=320");
            ep[7] = new Episode(1, 8, "Damien", "http://www.southpark.de/alle-episoden/s01e08-damien", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e09-starvin-marvin_4x3.jpg?width=320");
            ep[8] = new Episode(1, 9, "Starvin' Marvin", "http://www.southpark.de/alle-episoden/s01e09-ein-fettwanst-in-%C3%A4thiopien", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e10-mr-hankey-the-christmas-poo_4x3.jpg?width=320");
            ep[9] = new Episode(1, 10, "Mr. Hankey, the CHristmas Poo", "http://www.southpark.de/alle-episoden/s01e10-mr-hankey-der-weihnachtskot", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e08-damien_4x3.jpg?width=320");
            ep[10] = new Episode(1, 11, "Tom's Rhinoplasty", "http://www.southpark.de/alle-episoden/s01e11-geil-auf-miss-ellen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e11-toms-rhinoplasty_4x3.jpg?width=320");
            ep[11] = new Episode(1, 12, "Mecha-Streisand", "http://www.southpark.de/alle-episoden/s01e12-robo-streisand", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e12-mecha-streisand_4x3.jpg?width=320");
            ep[12] = new Episode(1, 13, "Cartman's Mom is a Dirty Slut", "http://www.southpark.de/alle-episoden/s01e13-cartmans-mama-ist-eine-schlampe", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-1/south-park-s01e13-cartmans-mom-is-a-dirty-slut_4x3.jpg?width=320");

            //Season 2
            ep[13] = new Episode(2, 1, "Terrance and Phillip in Not Without my Anus", "http://www.southpark.de/alle-episoden/s02e01-terrance-philipp-zeigen-pupse-gegen-saddam", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e01-terrance-and-phillip-in-not-without-my-anus_4x3.jpg?width=320");
            ep[14] = new Episode(2, 2, "Cartman's Mom is still a dirty Slut", "http://www.southpark.de/alle-episoden/s02e02-und-noch-immer-ist-cartmans-mama-eine-schlampe", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e02-cartmans-mom-is-still-a-dirty-slut_4x3.jpg?width=320");
            ep[15] = new Episode(2, 3, "ChickenLover", "http://www.southpark.de/alle-episoden/s02e03-rauf-aufs-huhn", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e04-ikes-wee-wee_4x3.jpg?width=320");
            ep[16] = new Episode(2, 4, "Ike's Wee Wee", "http://www.southpark.de/alle-episoden/s02e04-kampf-um-die-vorhaut", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e03-chickenlover_4x3.jpg?width=320");
            ep[17] = new Episode(2, 5, "Conjoined Fetus Lady", "http://www.southpark.de/alle-episoden/s02e05-sch%C3%B6ner-w%C3%A4r-ne-warze", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e05-conjoined-fetus-lady_4x3.jpg?width=320");
            ep[18] = new Episode(2, 6, "The Mexican Staring Frog of Southern Sri Lanka", "http://www.southpark.de/alle-episoden/s02e06-jesus-verliert-einschaltquoten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e06-the-mexican-staring-frog-of-southern-sri-lanka_4x3.jpg?width=320");
            ep[19] = new Episode(2, 7, "City on the Edge od Forever", "http://www.southpark.de/alle-episoden/s02e07-griff-in-die-geschichte", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e07-city-on-the-edge-of-forever-flashbacks_4x3.jpg?width=320");
            ep[20] = new Episode(2, 8, "Summer Sucks", "http://www.southpark.de/alle-episoden/s02e08-tote-hose", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e08-summer-sucks_4x3.jpg?width=320");
            ep[21] = new Episode(2, 9, "Chef's Salty Chocolate Balls", "http://www.southpark.de/alle-episoden/s02e09-mr-hankey-gegen-den-mist-aus-hollywood", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e09-chefs-chocolate-salty-balls_4x3.jpg?width=320");
            ep[22] = new Episode(2, 10, "Chickenplox", "http://www.southpark.de/alle-episoden/s02e10-der-wind-hat-mir-ne-pocke-erz%C3%A4hlt", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e10-chickenpox_4x3.jpg?width=320");
            ep[23] = new Episode(2, 11, "Roger Ebert Should Lay Off the Fatty Foods", "http://www.southpark.de/alle-episoden/s02e11-voll-das-geheimnis", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e11-roger-ebert-should-lay-off-the-fatty-foods_4x3.jpg?width=320");
            ep[24] = new Episode(2, 12, "Clubhouses", "http://www.southpark.de/alle-episoden/s02e12-streit-scheidung-und-ein-happy-end-in-25-minuten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e12-clubhouses_4x3.jpg?width=320");
            ep[25] = new Episode(2, 13, "Cow Days", "http://www.southpark.de/alle-episoden/s02e13-coole-k%C3%BChe", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e13-cow-days_4x3.jpg?width=320");
            ep[26] = new Episode(2, 14, "Chef Aid", "http://www.southpark.de/alle-episoden/s02e14-kohle-f%C3%BCr-den-chefkoch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e14-chef-aid_4x3.jpg?width=320");
            ep[27] = new Episode(2, 15, "Spookyfish", "http://www.southpark.de/alle-episoden/s02e15-b%C3%B6ser-b%C3%B6ser-fisch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e15-spookyfish_4x3.jpg?width=320");
            ep[28] = new Episode(2, 16, "Merry Christmas Charlie Manson!", "http://www.southpark.de/alle-episoden/s02e16-rohe-weihnachten-charlie-manson", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e16-merry-christmas-charlie-manson_4x3.jpg?width=320");
            ep[29] = new Episode(2, 17, "Gnomes", "http://www.southpark.de/alle-episoden/s02e17-b%C3%B6se-buben-bringen-beistand", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e17-gnomes_4x3.jpg?width=320");
            ep[30] = new Episode(2, 18, "Prehistoric Ice Man", "http://www.southpark.de/alle-episoden/s02e18-wem-geh%C3%B6rt-der-typ-aus-dem-eis", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-2/south-park-s02e18-prehistoric-ice-man_4x3.jpg?width=320");

            //Season 3
            ep[31] = new Episode(3, 1, "Rainforest Shmainforest", "http://www.southpark.de/alle-episoden/s03e01-regenwald-regenwald-du-l%C3%A4sst-mich-v%C3%B6llig-kalt", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e01-rainforest-shmainforest_4x3.jpg?width=320");
            ep[32] = new Episode(3, 2, "Spontaneous Combustion", "http://www.southpark.de/alle-episoden/s03e02-spontane-selbstentz%C3%BCndung", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e03-the-succubus_4x3.jpg?width=320");
            ep[33] = new Episode(3, 3, "The Succubus", "http://www.southpark.de/alle-episoden/s03e03-chefkoch-liebt-nen-sukkubus", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e05-jakovasaurs_4x3.jpg?width=320");
            ep[34] = new Episode(3, 4, "Tweek VS Craig", "http://www.southpark.de/alle-episoden/s03e04-tweek-gegen-craig", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e04-tweek-vs-craig_4x3.jpg?width=320");
            ep[35] = new Episode(3, 5, "Jakovasaurus", "http://www.southpark.de/alle-episoden/s03e04-tweek-gegen-craig", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e06-sexual-harassment-panda_4x3.jpg?width=320");
            ep[36] = new Episode(3, 6, "Sexual Harassment Panda", "http://www.southpark.de/alle-episoden/s03e06-ich-f%C3%BChl-mich-voll-bel%C3%A4stigt", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e07-cat-orgy_4x3.jpg?width=320");
            ep[37] = new Episode(3, 7, "Cat Orgy", "http://www.southpark.de/alle-episoden/s03e07-katzenorgie-teil-1", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e08-two-guys-naked-in-a-hot-tub_4x3.jpg?width=320");
            ep[38] = new Episode(3, 8, "Two Guys Naked in a Hot Tub", "http://www.southpark.de/alle-episoden/s03e08-wenn-der-vater-mit-dem-vater-teil-2", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e09-jewbilee_4x3.jpg?width=320");
            ep[39] = new Episode(3, 9, "Jewbilee", "http://www.southpark.de/alle-episoden/s03e09-beschnittene-pfadfinder-teil-3", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e12-korns-groovy-pirate-ghost-mystery_4x3.jpg?width=320");
            ep[40] = new Episode(3, 10, "Chinpoko Mon", "http://www.southpark.de/alle-episoden/s03e10-chinpokomon", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e10-chinpoko-mon_4x3.jpg?width=320");
            ep[41] = new Episode(3, 11, "Starvin' Marvin in Space", "http://www.southpark.de/alle-episoden/s03e11-hungriger-hugos-mission-im-all", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e13-hooked-on-monkey-fonics_4x3.jpg?width=320");
            ep[42] = new Episode(3, 12, "Korn's Groovy Pirate Ghost Mystery", "http://www.southpark.de/alle-episoden/s03e12-korns-echt-abgefahrene-geisterstory", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e11-starvin-marvin-in-space_4x3.jpg?width=320");
            ep[43] = new Episode(3, 13, "Hooked on Monkey Fonics", "http://www.southpark.de/alle-episoden/s03e13-vorsicht-vor-dem-wahren-leben", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e14-the-red-badge-of-gayness_4x3.jpg?width=320");
            ep[44] = new Episode(3, 14, "The Red Badge of Gayness", "http://www.southpark.de/alle-episoden/s03e14-fackeln-im-sturm-f%C3%BCr-arme", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e15-mr-hankeys-christmas-classics_4x3.jpg?width=320");
            ep[45] = new Episode(3, 15, "Mr. Hankey's Christmas Classics", "http://www.southpark.de/alle-episoden/s03e15-halleluja-mr-hankeys-klassische-weihnachten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e16-are-you-there-god-its-me-jesus_4x3.jpg?width=320");
            ep[46] = new Episode(3, 16, "Are You There God? It's Me, Jesus", "http://www.southpark.de/alle-episoden/s03e16-hallo-gott-hier-ist-jesus", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e17-world-wide-recorder-concert_4x3.jpg?width=320");
            ep[47] = new Episode(3, 17, "World Wide Recorder Concert", "http://www.southpark.de/alle-episoden/s03e17-jetzt-gibts-was-auf-die-ohren", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-3/south-park-s03e16-are-you-there-god-its-me-jesus_4x3.jpg?width=320");

            //Season 4
            ep[48] = new Episode(4, 1, "Cartman's Silly Hate Crime 2000", "http://www.southpark.de/alle-episoden/s04e01-die-lustige-geschichte-%C3%BCber-ein-verbrechen-aus-hass", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e01-cartmans-silly-hate-crime-2000_4x3.jpg?width=320");
            ep[49] = new Episode(4, 2, "The Tooth Fairy's Tats 2000", "http://www.southpark.de/alle-episoden/s04e02-zahnfee-mafia-co", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e02-the-tooth-fairys-tats-2000_4x3.jpg?width=320");
            ep[50] = new Episode(4, 3, "Quintuples 2000", "http://www.southpark.de/alle-episoden/s04e03-opa-macht-die-oma-tot", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e03-quintuplets-2000_4x3.jpg?width=320");
            ep[51] = new Episode(4, 4, "Timmy 2000", "http://www.southpark.de/alle-episoden/s04e04-alle-macht-den-drogen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e04-timmy-2000_4x3.jpg?width=320");
            ep[52] = new Episode(4, 5, "Pip", "http://www.southpark.de/alle-episoden/s04e05-gro%C3%9Fe-erwartungen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e05-pip_4x3.jpg?width=320");
            ep[53] = new Episode(4, 6, "Cartman Joins NAMBLA", "http://www.southpark.de/alle-episoden/s04e06-kennys-karma-52", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e06-cartman-joins-nambla_4x3.jpg?width=320");
            ep[54] = new Episode(4, 7, "Cherokee Hair Tampons", "http://www.southpark.de/alle-episoden/s04e07-nicht-ohne-meine-niere", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e07-cherokee-hair-tampons_4x3.jpg?width=320");
            ep[55] = new Episode(4, 8, "Chef Goes Nanners", "http://www.southpark.de/alle-episoden/s04e08-flaggenkrieg", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e08-chef-goes-nanners_4x3.jpg?width=320");
            ep[56] = new Episode(4, 9, "Something you can do with your Finger", "http://www.southpark.de/alle-episoden/s04e09-flutschfinger-on-tour", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e09-something-you-can-do-with-your-finger_4x3.jpg?width=320");
            ep[57] = new Episode(4, 10, "Do the Handicapped go to Hell?", "http://www.southpark.de/alle-episoden/s04e10-ist-die-h%C3%B6lle-behindertengerecht", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e10-do-the-handicapped-go-to-hell_4x3.jpg?width=320");
            ep[58] = new Episode(4, 11, "Probably", "http://www.southpark.de/alle-episoden/s04e11-wird-wohl", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e11-probably_4x3.jpg?width=320");
            ep[59] = new Episode(4, 12, "Fourth Grade", "http://www.southpark.de/alle-episoden/s04e12-4-klasse", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e12-fourth-grade_4x3.jpg?width=320");
            ep[60] = new Episode(4, 13, "Trapper Keeper", "http://www.southpark.de/alle-episoden/s04e13-widerstand-ist-zwecklos", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e13-trapper-keeper_4x3.jpg?width=320");
            ep[61] = new Episode(4, 14, "Helen Keller! The Musical", "http://www.southpark.de/alle-episoden/s04e14-helen-keller-das-musical", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e14-helen-keller-the-musical_4x3.jpg?width=320");
            ep[62] = new Episode(4, 15, "Fat Camp", "http://www.southpark.de/alle-episoden/s04e15-die-krazy-kenny-show", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e15-fat-camp_4x3.jpg?width=320");
            ep[63] = new Episode(4, 16, "The Wacky Molestation Adventure", "http://www.southpark.de/alle-episoden/s04e16-abenteuer-missbrauch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e16-the-wacky-molestation-adventure_4x3.jpg?width=320");
            ep[64] = new Episode(4, 17, "A Very Crappy Christmas", "http://www.southpark.de/alle-episoden/s04e17-und-keiner-lacht-zur-weihnachtsnacht", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-4/south-park-s04e17-a-very-crappy-christmas_4x3.jpg?width=320");

            //Season 5
            ep[65] = new Episode(5, 1, "Scott Tenorman Must Die", "http://www.southpark.de/alle-episoden/s05e01-scott-tenorman-muss-sterben", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e01-scott-tenorman-must-die_4x3.jpg?width=320");
            ep[66] = new Episode(5, 2, "It Hits The Fan", "http://www.southpark.de/alle-episoden/s05e02-verfluchtes-fluchwort", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e02-it-hits-the-fan_4x3.jpg?width=320");
            ep[67] = new Episode(5, 3, "Cripple Fight", "http://www.southpark.de/alle-episoden/s05e03-kr%C3%BCppel-keile", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e03-cripple-fight_4x3.jpg?width=320");
            ep[68] = new Episode(5, 4, "Super Best Friends (Not Available)", "", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e04-super-best-friends_4x3.jpg?width=320");
            ep[69] = new Episode(5, 5, "Terrance and Phillip: Behind The Blow", "http://www.southpark.de/alle-episoden/s05e05-hinter-dem-furz", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e05-terrance-and-phillip-behind-the-blow_4x3.jpg?width=320");
            ep[70] = new Episode(5, 6, "Cartmanland", "http://www.southpark.de/alle-episoden/s05e06-cartmanland", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e06-cartmanland_4x3.jpg?width=320");
            ep[71] = new Episode(5, 7, "Proper Condom Use", "http://www.southpark.de/alle-episoden/s05e07-hundemelken", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e07-proper-condom-use_4x3.jpg?width=320");
            ep[72] = new Episode(5, 8, "Towelie", "http://www.southpark.de/alle-episoden/s05e08-ein-bisschen-kiffen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e08-towelie_4x3.jpg?width=320");
            ep[73] = new Episode(5, 9, "Osama Bin Laden Has Farty Pants", "http://www.southpark.de/alle-episoden/s05e09-osama-hat-nix-in-der-hose", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e09-osama-bin-laden-has-farty-pants_4x3.jpg?width=320");
            ep[74] = new Episode(5, 10, "How to Eat With Your Butt", "http://www.southpark.de/alle-episoden/s05e10-arschgesichter", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e10-how-to-eat-with-your-butt_4x3.jpg?width=320");
            ep[75] = new Episode(5, 11, "The Entity", "http://www.southpark.de/alle-episoden/s05e11-was-ist-es-wann-kann-ich-es-kaufen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e11-the-entity_4x3.jpg?width=320");
            ep[76] = new Episode(5, 12, "Here Comes The Neighorhood", "http://www.southpark.de/alle-episoden/s05e12-will-smith-bringt-reiches-pack-nach-south-park", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e12-here-comes-the-neighborhood_4x3.jpg?width=320");
            ep[77] = new Episode(5, 13, "Kenny Dies", "http://www.southpark.de/alle-episoden/s05e13-kennys-tod", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e13-kenny-dies_4x3.jpg?width=320");
            ep[78] = new Episode(5, 14, "Butter's Very Own Episode", "http://www.southpark.de/alle-episoden/s05e14-butters-das-bin-ich", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-5/south-park-s05e14-butters-very-own-episode_4x3.jpg?width=320");

            //Season 6
            ep[79] = new Episode(6, 1, "Freak Strike", "http://www.southpark.de/alle-episoden/s06e01-freakshow", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e01-freak-strike_4x3.jpg?width=320");
            ep[80] = new Episode(6, 2, "Jared Has Aids", "http://www.southpark.de/alle-episoden/s06e02-jared-hat-aides", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e02-jared-has-aides_4x3.jpg?width=320");
            ep[81] = new Episode(6, 3, "Asspen", "http://www.southpark.de/alle-episoden/s06e03-skifahren-ist-f%C3%BCrn-arsch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e03-asspen_4x3.jpg?width=320");
            ep[82] = new Episode(6, 4, "The New Terrance And Phillip Movie Trailer", "http://www.southpark.de/alle-episoden/s06e04-die-russel-crowe-show-mit-pr%C3%BCgel-um-die-welt", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e04-the-new-terrance-and-phillip-movie-trailer_4x3.jpg?width=320");
            ep[83] = new Episode(6, 5, "Fun With Veal", "http://www.southpark.de/alle-episoden/s06e05-vaginitis-ohne-kalbfleisch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e05-fun-with-veal_4x3.jpg?width=320");
            ep[84] = new Episode(6, 6, "Professor Chaos", "http://www.southpark.de/alle-episoden/s06e06-professor-chaos", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e06-professor-chaos_4x3.jpg?width=320");
            ep[85] = new Episode(6, 7, "The Simpsons Alreday Did It", "http://www.southpark.de/alle-episoden/s06e07-das-gabs-doch-schon-bei-den-simpsons", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e07-the-simpsons-already-did-it_4x3.jpg?width=320");
            ep[86] = new Episode(6, 8, "Red Catholic Love", "http://www.southpark.de/alle-episoden/s06e08-nur-k%C3%B6rperliche-liebe-im-vatikan", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e08-red-hot-catholic-love_4x3.jpg?width=320");
            ep[87] = new Episode(6, 9, "Free Hat", "http://www.southpark.de/alle-episoden/s06e09-gr%C3%B6%C3%9Fer-digitaler-und-umgeschnitten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e09-free-hat_4x3.jpg?width=320");
            ep[88] = new Episode(6, 10, "Bebe's Boobs Destroy Society", "http://www.southpark.de/alle-episoden/s06e10-bebes-br%C3%BCste-bringen-krieg", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e10-bebes-boobs-destroy-society_4x3.jpg?width=320");
            ep[89] = new Episode(6, 11, "Child Abduction Is Not Funny", "http://www.southpark.de/alle-episoden/s06e11-mongolen-vor-south-park", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e11-child-abduction-is-not-funny_4x3.jpg?width=320");
            ep[90] = new Episode(6, 12, "A Ladder To Heaven", "http://www.southpark.de/alle-episoden/s06e12-eine-leiter-zum-himmel", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e12-a-ladder-to-heaven_4x3.jpg?width=320");
            ep[91] = new Episode(6, 13, "The Return of The Fellowship of the Ring to the Two Towers", "http://www.southpark.de/alle-episoden/s06e13-die-r%C3%BCckkehr-der-gef%C3%A4hrten-des-rings-zu-den-zwei-t%C3%BCrmen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e13-the-return-of-the-fellowship-of-the-ring-to-the-two-towers_4x3.jpg?width=320");
            ep[92] = new Episode(6, 14, "The Death Camp Of Tolerance", "http://www.southpark.de/alle-episoden/s06e14-todescamp-der-toleranz", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e14-the-death-camp-of-tolerance_4x3.jpg?width=320");
            ep[93] = new Episode(6, 15, "The Biggest Douce in the Universe", "http://www.southpark.de/alle-episoden/s06e15-kenny-ist-in-cartman-drin", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e15-the-biggest-douche-in-the-universe_4x3.jpg?width=320");
            ep[94] = new Episode(6, 16, "My Future SElf n'Me", "http://www.southpark.de/alle-episoden/s06e16-mein-zukunfts-ich-und-ich", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e16-my-future-self-n-me_4x3.jpg?width=320");
            ep[95] = new Episode(6, 17, "Red Sleight Down", "http://www.southpark.de/alle-episoden/s06e17-weihnachten-im-irak-blut-wunder", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-6/south-park-s06e17-red-sleigh-down_4x3.jpg?width=320");

            //Season 7
            ep[96] = new Episode(7, 1, "I'm a Little Bit Country", "http://www.southpark.de/alle-episoden/s07e01-fehlgeburt-einer-nation", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e01-im-a-little-bit-country_4x3.jpg?width=320");
            ep[97] = new Episode(7, 2, "Krazy Kripples", "http://www.southpark.de/alle-episoden/s07e02-guter-kr%C3%BCppel-schlechter-kr%C3%BCppel", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e02-krazy-kripples_4x3.jpg?width=320");
            ep[98] = new Episode(7, 3, "Toilet Paper", "http://www.southpark.de/alle-episoden/s07e03-das-schweigen-des-klopapiers", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e03-toilet-paper_4x3.jpg?width=320");
            ep[99] = new Episode(7, 4, "Cancelled", "http://www.southpark.de/alle-episoden/s07e04-wird-die-erde-eingestellt", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e04-cancelled_4x3.jpg?width=320");
            ep[100] = new Episode(7, 5, "Fat Butt and Pancake Head", "http://www.southpark.de/alle-episoden/s07e05-j-lo-das-doppelte-flittchen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e05-fat-butt-and-pancake-head_4x3.jpg?width=320");
            ep[101] = new Episode(7, 6, "Lil' Crime Stoppers", "http://www.southpark.de/alle-episoden/s07e06-kleine-kriminale", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e06-lil-crime-stoppers_4x3.jpg?width=320");
            ep[102] = new Episode(7, 7, "Red Man's Greed", "http://www.southpark.de/alle-episoden/s07e07-unglaublich-geldgeile-ureinwohner", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e07-red-mans-greed_4x3.jpg?width=320");
            ep[103] = new Episode(7, 8, "South Park Is Gay", "http://www.southpark.de/alle-episoden/s07e08-schwule-verschw%C3%B6rung", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e08-south-park-is-gay_4x3.jpg?width=320");
            ep[104] = new Episode(7, 9, "Christian Rock Hard", "http://www.southpark.de/alle-episoden/s07e09-christen-rocken-fett", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e09-christian-rock-hard_4x3.jpg?width=320");
            ep[105] = new Episode(7, 10, "Grey Dawn", "http://www.southpark.de/alle-episoden/s07e10-revolution-der-alten-s%C3%A4cke", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e10-grey-dawn_4x3.jpg?width=320");
            ep[106] = new Episode(7, 11, "Casa Bonita", "http://www.southpark.de/alle-episoden/s07e11-casa-bonita", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e11-casa-bonita_4x3.jpg?width=320");
            ep[107] = new Episode(7, 12, "All About Mormons", "http://www.southpark.de/alle-episoden/s07e12-mormonen-machen-sich-was-vor", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e12-all-about-mormons_4x3.jpg?width=320");
            ep[108] = new Episode(7, 13, "Butt Out", "http://www.southpark.de/alle-episoden/s07e13-kippe-weg", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e13-butt-out_4x3.jpg?width=320");
            ep[109] = new Episode(7, 14, "Raisins", "http://www.southpark.de/alle-episoden/s07e14-wir-sind-grufties", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e14-raisins_4x3.jpg?width=320");
            ep[110] = new Episode(7, 15, "It's Christmas in Canada", "http://www.southpark.de/alle-episoden/s07e15-bl%C3%B6der-die-kanadier-nie-klingen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-7/south-park-s07e15-its-christmas-in-canada_4x3.jpg?width=320");

            //Season 8
            ep[111] = new Episode(8, 1, "Good Times With Weapons", "http://www.southpark.de/alle-episoden/s08e01-spiel-und-spa%C3%9F-mit-waffen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e01-good-times-with-weapons_4x3.jpg?width=320");
            ep[112] = new Episode(8, 2, "AWESOM-O", "http://www.southpark.de/alle-episoden/s08e02-geilomat", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e02-awesom-o_4x3.jpg?width=320");
            ep[113] = new Episode(8, 3, "Up the Down Steroid", "http://www.southpark.de/alle-episoden/s08e03-mit-der-spritze-an-die-spitze", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e03-up-the-down-steroid_4x3.jpg?width=320");
            ep[114] = new Episode(8, 4, "The Passion of The Jew", "http://www.southpark.de/alle-episoden/s08e04-die-passion-des-juden", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e04-the-passion-of-the-jew_4x3.jpg?width=320");
            ep[115] = new Episode(8, 5, "You Got F'd in the A", "http://www.southpark.de/alle-episoden/s08e05-voll-in-den-ar-gefickt", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e05-you-got-fd-in-the-a_4x3.jpg?width=320");
            ep[116] = new Episode(8, 6, "Goobacks", "http://www.southpark.de/alle-episoden/s08e06-immigranten-aus-der-zukunft", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e06-goobacks_4x3.jpg?width=320");
            ep[117] = new Episode(8, 7, "The Jeffersons", "http://www.southpark.de/alle-episoden/s08e07-die-jeffersons", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e07-the-jeffersons_4x3.jpg?width=320");
            ep[118] = new Episode(8, 8, "Douche And Turd", "http://www.southpark.de/alle-episoden/s08e08-w%C3%A4hl-oder-stirb", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e08-douche-and-turd_4x3.jpg?width=320");
            ep[119] = new Episode(8, 9, "Something Wall Mart This Way Comes", "http://www.southpark.de/alle-episoden/s08e09-das-b%C3%B6se-kommt-auf-wall-marts-sohlen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e09-something-wall-mart-this-way-comes_4x3.jpg?width=320");
            ep[120] = new Episode(8, 10, "Pre-School", "http://www.southpark.de/alle-episoden/s08e10-vorschule", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e10-pre-school_4x3.jpg?width=320");
            ep[121] = new Episode(8, 11, "Quest For Ratings", "http://www.southpark.de/alle-episoden/s08e11-kampf-um-quoten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e11-quest-for-ratings_4x3.jpg?width=320");
            ep[122] = new Episode(8, 12, "Stupid Spoiled Whore Video Playset", "http://www.southpark.de/alle-episoden/s08e12-lasst-uns-schlampen-spielen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e12-stupid-spoiled-whore-video-playset_4x3.jpg?width=320");
            ep[123] = new Episode(8, 13, "Cartman's Incredible Gift", "http://www.southpark.de/alle-episoden/s08e13-cartmans-unglaubliche-gabe", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e13-cartmans-incredible-gift_4x3.jpg?width=320");
            ep[124] = new Episode(8, 14, "Woodland Critter Christmas", "http://www.southpark.de/alle-episoden/s08e14-weihnacht-im-walde", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-8/south-park-s08e14-woodland-critter-christmas_4x3.jpg?width=320");

            //Season 9
            ep[125] = new Episode(9, 1, "Mr. Garrison's Fancy New Vagina", "http://www.southpark.de/alle-episoden/s09e01-mr-garrisons-schicke-neue-vagina", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e01-mr-garrisons-fancy-new-vagina_4x3.jpg?width=320");
            ep[126] = new Episode(9, 2, "Die Hippy, Die", "http://www.southpark.de/alle-episoden/s09e02-stirb-hippie-stirb", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e02-die-hippie-die_4x3.jpg?width=320");
            ep[127] = new Episode(9, 3, "Wing", "http://www.southpark.de/alle-episoden/s09e03-die-supergeile-talentagentur", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e03-wing_4x3.jpg?width=320");
            ep[128] = new Episode(9, 4, "Best Friends Forever", "http://www.southpark.de/alle-episoden/s09e04-abfs-allerbeste-freunde", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e04-best-friends-forever_4x3.jpg?width=320");
            ep[129] = new Episode(9, 5, "The Losing Edge", "http://www.southpark.de/alle-episoden/s09e05-siegertypen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e05-the-losing-edge_4x3.jpg?width=320");
            ep[130] = new Episode(9, 6, "The Death Of Eric Cartman", "http://www.southpark.de/alle-episoden/s09e06-der-tod-von-eric-cartman", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e06-the-death-of-eric-cartman_4x3.jpg?width=320");
            ep[131] = new Episode(9, 7, "Erection Day", "http://www.southpark.de/alle-episoden/s09e07-lattenfieber", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e07-erection-day_4x3.jpg?width=320");
            ep[132] = new Episode(9, 8, "Two Days Before the Day After Tomorrow", "http://www.southpark.de/alle-episoden/s09e08-der-treibhauseffekt", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e08-two-days-before-the-day-after-tomorrow_4x3.jpg?width=320");
            ep[133] = new Episode(9, 9, "Majorine", "http://www.southpark.de/alle-episoden/s09e09-das-weissagungsger%C3%A4t", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e09-marjorine_4x3.jpg?width=320");
            ep[134] = new Episode(9, 10, "Follow That Egg", "http://www.southpark.de/alle-episoden/s09e10-ei-fersucht", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e10-follow-that-egg_4x3.jpg?width=320");
            ep[135] = new Episode(9, 11, "Ginger Kids", "http://www.southpark.de/alle-episoden/s09e11-im-k%C3%B6rper-des-feindes", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e11-ginger-kids_4x3.jpg?width=320");
            ep[136] = new Episode(9, 12, "Trapped in the Closet", "http://www.southpark.de/alle-episoden/s09e12-schrankgefl%C3%BCster", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e12-trapped-in-the-closet_4x3.jpg?width=320");
            ep[137] = new Episode(9, 13, "Free Willzyx", "http://www.southpark.de/alle-episoden/s09e13-free-willzyx", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e13-free-willzyx_4x3.jpg?width=320");
            ep[138] = new Episode(9, 14, "Bloody Mary", "http://www.southpark.de/alle-episoden/s09e14-bloody-mary", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-9/south-park-s09e14-bloody-mary_4x3.jpg?width=320");

            //Season 10
            ep[139] = new Episode(10, 1, "The Return Of Chef", "http://www.southpark.de/alle-episoden/s10e01-the-return-of-chefkoch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e01-the-return-of-chef_4x3.jpg?width=320");
            ep[140] = new Episode(10, 2, "Smug Alert!", "http://www.southpark.de/alle-episoden/s10e02-snobwarnung", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e02-smug-alert_4x3.jpg?width=320");
            ep[141] = new Episode(10, 3, "Cartoon Wars Part 1 (Not Available)", "", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e03-cartoon-wars-part-i_4x3.jpg?width=320");
            ep[142] = new Episode(10, 4, "Cartoon Wars Part 2 (Not Available)", "", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e04-cartoon-wars-part-ii_4x3.jpg?width=320");
            ep[143] = new Episode(10, 5, "A Million Little Fibers", "http://www.southpark.de/alle-episoden/s10e05-viel-frottee-um-nichts", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e05-a-million-little-fibers_4x3.jpg?width=320");
            ep[144] = new Episode(10, 6, "ManBearPig", "http://www.southpark.de/alle-episoden/s10e06-mannb%C3%A4rschwein", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e06-manbearpig_4x3.jpg?width=320");
            ep[145] = new Episode(10, 7, "Tsst", "http://www.southpark.de/alle-episoden/s10e07-tsst", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e07-tsst_4x3.jpg?width=320");
            ep[146] = new Episode(10, 8, "Make Love, Not Warcraft", "http://www.southpark.de/alle-episoden/s10e08-make-love-not-warcraft", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e08-make-love-not-warcraft_4x3.jpg?width=320");
            ep[147] = new Episode(10, 9, "Mystery of the Urinal Deuce", "http://www.southpark.de/alle-episoden/s10e09-schei%C3%9F-paranoia", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e09-mystery-of-the-urinal-deuce_4x3.jpg?width=320");
            ep[148] = new Episode(10, 10, "Miss Teacher Bangs A Boy", "http://www.southpark.de/alle-episoden/s10e10-schuljungen-report", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e10-miss-teacher-bangs-a-boy_4x3.jpg?width=320");
            ep[149] = new Episode(10, 11, "Hell On Earth 2006", "http://www.southpark.de/alle-episoden/s10e11-die-h%C3%B6lle-auf-erden", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e11-hell-on-earth-2006_4x3.jpg?width=320");
            ep[150] = new Episode(10, 12, "Go God Go", "http://www.southpark.de/alle-episoden/s10e12-gott-ist-tot", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e12-go-god-go_4x3.jpg?width=320");
            ep[151] = new Episode(10, 13, "Go God Go XII", "http://www.southpark.de/alle-episoden/s10e13-gott-ist-tot-ii", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e13-go-god-go-xii_4x3.jpg?width=320");
            ep[152] = new Episode(10, 14, "Stanley's Cup", "http://www.southpark.de/alle-episoden/s10e14-stanleys-cup", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-10/south-park-s10e14-stanleys-cup_4x3.jpg?width=320");

            //Season 11
            ep[153] = new Episode(11, 1, "With Apologies to Jesse Jackson", "http://www.southpark.de/alle-episoden/s11e01-bitte-ein-n", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e01-with-apologies-to-jesse-jackson_4x3.jpg?width=320");
            ep[154] = new Episode(11, 2, "Cartman Sucks", "http://www.southpark.de/alle-episoden/s11e02-cartman-sucks", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e03-lice-capades_4x3.jpg?width=320");
            ep[155] = new Episode(11, 3, "Lice Capades", "http://www.southpark.de/alle-episoden/s11e03-laustrophobie", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e04-the-snuke_4x3.jpg?width=320");
            ep[156] = new Episode(11, 4, "The Snuke", "http://www.southpark.de/alle-episoden/s11e04-hillary-24", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e05-fantastic-easter-special_4x3.jpg?width=320");
            ep[157] = new Episode(11, 5, "Fantastic Easter Special", "http://www.southpark.de/alle-episoden/s11e05-der-osterhasen-code", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e06-d-yikes_4x3.jpg?width=320");
            ep[158] = new Episode(11, 6, "D-Yikes!", "http://www.southpark.de/alle-episoden/s11e06-lesbos", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e07-night-of-the-living-homeless_4x3.jpg?width=320");
            ep[159] = new Episode(11, 7, "Night of the Living Homeless", "http://www.southpark.de/alle-episoden/s11e07-die-nacht-der-lebenden-obdachlosen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e08-le-petit-tourette_4x3.jpg?width=320");
            ep[160] = new Episode(11, 8, "Le Petit Tourette", "http://www.southpark.de/alle-episoden/s11e08-ein-bisschen-tourette", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e08-le-petit-tourette_4x3.jpg?width=320");
            ep[161] = new Episode(11, 9, "More Crap", "http://www.southpark.de/alle-episoden/s11e09-das-gro%C3%9Fe-gesch%C3%A4ft", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e09-more-crap_4x3.jpg?width=320");
            ep[162] = new Episode(11, 10, "Imaginationland", "http://www.southpark.de/alle-episoden/s11e10-fantasieland", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e10-imaginationland_4x3.jpg?width=320");
            ep[163] = new Episode(11, 11, "Imaginationland II", "http://www.southpark.de/alle-episoden/s11e11-fantasieland-episode-ii", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e11-imaginationland-episode-ii_4x3.jpg?width=320");
            ep[164] = new Episode(11, 12, "Imaginationland III", "http://www.southpark.de/alle-episoden/s11e12-fantasieland-episode-iii", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e12-imaginationland-episode-iii_4x3.jpg?width=320");
            ep[165] = new Episode(11, 13, "Guitar Queer-O", "http://www.southpark.de/alle-episoden/s11e13-guitar-queer-o", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e13-guitar-queer-o_4x3.jpg?width=320");
            ep[166] = new Episode(11, 14, "The List", "http://www.southpark.de/alle-episoden/s11e14-die-liste", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-11/south-park-s11e14-the-list_4x3.jpg?width=320");

            //Season 12
            ep[167] = new Episode(12, 1, "Tonsil Trouble", "http://www.southpark.de/alle-episoden/s12e01-%C3%A4rger-mit-den-mandeln", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e01-tonsil-trouble_4x3.jpg?width=320");
            ep[168] = new Episode(12, 2, "Britney's New Look", "http://www.southpark.de/alle-episoden/s12e02-britneys-neuer-look", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e02-britneys-new-look_4x3.jpg?width=320");
            ep[169] = new Episode(12, 3, "Major Boobage", "http://www.southpark.de/alle-episoden/s12e03-katerstimmung", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e03-major-boobage_4x3.jpg?width=320");
            ep[170] = new Episode(12, 4, "Canada On Strike", "http://www.southpark.de/alle-episoden/s12e04-kanada-im-streik", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e04-canada-on-strike_4x3.jpg?width=320");
            ep[171] = new Episode(12, 5, "Eek, A Penis!", "http://www.southpark.de/alle-episoden/s12e05-huch-ein-penis", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e05-eek-a-penis_4x3.jpg?width=320");
            ep[172] = new Episode(12, 6, "Over Loggin", "http://www.southpark.de/alle-episoden/s12e06-keine-verbindung", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e06-over-logging_4x3.jpg?width=320");
            ep[173] = new Episode(12, 7, "Super Fun Time", "http://www.southpark.de/alle-episoden/s12e07-super-phun-thyme", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e07-super-fun-time_4x3.jpg?width=320");
            ep[174] = new Episode(12, 8, "The China Problem", "http://www.southpark.de/alle-episoden/s12e08-das-china-problem", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e08-the-china-probrem_4x3.jpg?width=320");
            ep[175] = new Episode(12, 9, "Breast Cancer Show Ever", "http://www.southpark.de/alle-episoden/s12e09-busenfeinde", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e09-breast-cancer-show-ever_4x3.jpg?width=320");
            ep[176] = new Episode(12, 10, "Pandemic", "http://www.southpark.de/alle-episoden/s12e10-pandemic", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e10-pandemic_4x3.jpg?width=320");
            ep[177] = new Episode(12, 11, "Pandemic 2: The Startling", "http://www.southpark.de/alle-episoden/s12e11-pandemic-2-the-startling", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e11-pandemic-2-the-startling_4x3.jpg?width=320");
            ep[178] = new Episode(12, 12, "About Lst Night...", "http://www.southpark.de/alle-episoden/s12e12-obamas-eleven", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e12-about-last-night_4x3.jpg?width=320");
            ep[179] = new Episode(12, 13, "Elementary School Musical", "http://www.southpark.de/alle-episoden/s12e13-elementary-school-musical", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e13-elementary-school-musical_4x3.jpg?width=320");
            ep[180] = new Episode(12, 14, "The Ungroundable", "http://www.southpark.de/alle-episoden/s12e14-butters-im-bann-der-d%C3%A4monen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-12/south-park-s12e14-the-ungroundable_4x3.jpg?width=320");

            //Season 13
            ep[181] = new Episode(13, 1, "The Ring", "http://www.southpark.de/alle-episoden/s13e01-der-ring", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e01-the-ring_4x3.jpg?width=320");
            ep[182] = new Episode(13, 2, "The Coon", "http://www.southpark.de/alle-episoden/s13e02-der-coon", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e02-the-coon_4x3.jpg?width=320");
            ep[183] = new Episode(13, 3, "Margaritaville", "http://www.southpark.de/alle-episoden/s13e03-margaritaville", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e03-margaritaville_4x3.jpg?width=320");
            ep[184] = new Episode(13, 4, "Eat, Pray, Queef", "http://www.southpark.de/alle-episoden/s13e04-queeft-los", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e04-eat-pray-queef_4x3.jpg?width=320");
            ep[185] = new Episode(13, 5, "Fishsticks", "http://www.southpark.de/alle-episoden/s13e05-leck-mich-am-st%C3%A4bchen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e05-fishsticks_4x3.jpg?width=320");
            ep[186] = new Episode(13, 6, "Pinewood Derby", "http://www.southpark.de/alle-episoden/s13e06-pinewood-derby", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e06-pinewood-derby_4x3.jpg?width=320");
            ep[187] = new Episode(13, 7, "Fatbeard", "http://www.southpark.de/alle-episoden/s13e07-k%C3%A4ptn-fettbart", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e07-fatbeard_4x3.jpg?width=320");
            ep[188] = new Episode(13, 8, "Dead Celebrities", "http://www.southpark.de/alle-episoden/s13e08-tote-promis", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e08-dead-celebrities_4x3.jpg?width=320");
            ep[189] = new Episode(13, 9, "Butters' Bottom Bitch", "http://www.southpark.de/alle-episoden/s13e09-butters-bottom-bitch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e09-butters-bottom-bitch_4x3.jpg?width=320");
            ep[190] = new Episode(13, 10, "W.T.F", "http://www.southpark.de/alle-episoden/s13e10-wtf", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e10-wtf_4x3.jpg?width=320");
            ep[191] = new Episode(13, 11, "Whale Whores", "http://www.southpark.de/alle-episoden/s13e11-whale-whores", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e11-whale-whores_4x3.jpg?width=320");
            ep[192] = new Episode(13, 12, "The F Word", "http://www.southpark.de/alle-episoden/s13e12-schwule-schwuchteln", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e12-the-f-word_4x3.jpg?width=320");
            ep[193] = new Episode(13, 13, "Dances With Smurfs", "http://www.southpark.de/alle-episoden/s13e13-schlumpfentanz", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e13-dances-with-smurfs_4x3.jpg?width=320");
            ep[194] = new Episode(13, 14, "Pee", "http://www.southpark.de/alle-episoden/s13e14-pi-pi", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-13/south-park-s13e14-pee_4x3.jpg?width=320");

            //Season 14
            ep[195] = new Episode(14, 1, "Sexual Healing", "http://www.southpark.de/alle-episoden/s14e01-sexual-healing", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e01-sexual-healing_4x3.jpg?width=320");
            ep[196] = new Episode(14, 2, "The Tale of Scrotie McBoogerballs", "http://www.southpark.de/alle-episoden/s14e02-als-die-kacke-pipi-musste", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e02-the-tale-of-scrotie-mcboogerballs_4x3.jpg?width=320");
            ep[197] = new Episode(14, 3, "Medicinal Fried Chicken", "http://www.southpark.de/alle-episoden/s14e03-thc-versus-kfc", " http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e03-medicinal-fried-chicken_4x3.jpg?width=320");
            ep[198] = new Episode(14, 4, "You Have 0 Friends", "http://www.southpark.de/alle-episoden/s14e04-du-hast-0-freunde", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e04-you-have-0-friends_4x3.jpg?width=320 ");
            ep[199] = new Episode(14, 5, "200 (Not Available)", "", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e05-200_4x3.jpg?width=320");
            ep[200] = new Episode(14, 6, "201 (Not Available)", "", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e06-201_4x3.jpg?width=320");
            ep[201] = new Episode(14, 7, "Crippled Summer", "http://www.southpark.de/alle-episoden/s14e07-kr%C3%BCppel-camp", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e07-crippled-summer_4x3.jpg?width=320");
            ep[202] = new Episode(14, 8, "Poor and Stupid", "http://www.southpark.de/alle-episoden/s14e08-arm-aber-d%C3%A4mlich", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e08-poor-and-stupid_4x3.jpg?width=320");
            ep[203] = new Episode(14, 9, "It's a Jersey Thing", "http://www.southpark.de/alle-episoden/s14e09-son-jersey-ding", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e09-its-a-jersey-thing_4x3.jpg?width=320");
            ep[204] = new Episode(14, 10, "Insheeption", "http://www.southpark.de/alle-episoden/s14e10-messie-syndrom", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e10-insheeption_4x3.jpg?width=320");
            ep[205] = new Episode(14, 11, "Coon 2: Hindsight", "http://www.southpark.de/alle-episoden/s14e11-der-coon-2", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e11-coon-2-hindsight_4x3.jpg?width=320");
            ep[206] = new Episode(14, 12, "Mysterion Rises", "http://www.southpark.de/alle-episoden/s14e12-mysterion-schl%C3%A4gt-zur%C3%BCck", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e12-mysterion-rises_4x3.jpg?width=320");
            ep[207] = new Episode(14, 13, "Coon vs Coon & Friends", "http://www.southpark.de/alle-episoden/s14e13-coon-vs-coon-friends", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e13-coon-vs-coon-friends_4x3.jpg?width=320");
            ep[208] = new Episode(14, 14, "Creme Fraiche", "http://www.southpark.de/alle-episoden/s14e14-crme-fraiche", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-14/south-park-s14e14-creme-fraiche_4x3.jpg?width=320");

            //Season 15
            ep[209] = new Episode(15, 1, "HUMANCENTiPAD", "http://www.southpark.de/alle-episoden/s15e01-humancentipad", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e01-humancentipad_4x3.jpg?width=320");
            ep[210] = new Episode(15, 2, "Funnybot", "http://www.southpark.de/alle-episoden/s15e02-funnybot", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e02-funnybot_4x3.jpg?width=320");
            ep[211] = new Episode(15, 3, "Pudding Royal", "http://www.southpark.de/alle-episoden/s15e03-pudding-royal", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e03-royal-pudding_4x3.jpg?width=320");
            ep[212] = new Episode(15, 4, "T.M.I", "http://www.southpark.de/alle-episoden/s15e04-tmi", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e04-tmi_4x3.jpg?width=320");
            ep[213] = new Episode(15, 5, "Crack-Baby Basketball", "http://www.southpark.de/alle-episoden/s15e05-crack-baby-basketball", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e05-crack-baby-athletic-association_4x3.jpg?width=320");
            ep[214] = new Episode(15, 6, "City Shushi", "http://www.southpark.de/alle-episoden/s15e06-city-sushi", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e06-city-sushi_4x3.jpg?width=320");
            ep[215] = new Episode(15, 7, "You're Getting Old", "http://www.southpark.de/alle-episoden/s15e07-h%C3%B6rt-sich-wie-schei%C3%9Fe-an", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e07-youre-getting-old_4x3.jpg?width=320");
            ep[216] = new Episode(15, 8, "Ass Burgers", "http://www.southpark.de/alle-episoden/s15e08-arschburger", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e08-ass-burgers_4x3.jpg?width=320");
            ep[217] = new Episode(15, 9, "The Last Of The Meheecans", "http://www.southpark.de/alle-episoden/s15e09-der-letzte-meheekaner", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e09-the-last-of-the-meheecans_4x3.jpg?width=320");
            ep[218] = new Episode(15, 10, "Bass to Mouth", "http://www.southpark.de/alle-episoden/s15e10-barsch-zu-mund", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e10-bass-to-mouth_4x3.jpg?width=320");
            ep[219] = new Episode(15, 11, "Broadway Bro Down", "http://www.southpark.de/alle-episoden/s15e11-broadway-bros", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e11-broadway-bro-down_4x3.jpg?width=320");
            ep[220] = new Episode(15, 12, "1 %", "http://www.southpark.de/alle-episoden/s15e12-one-percent", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e12-one-percent_4x3.jpg?width=320");
            ep[221] = new Episode(15, 13, "A History Channel Thanksgiving", "http://www.southpark.de/alle-episoden/s15e13-erntedank-und-doku-drama", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e13-a-history-channel-thanksgiving_4x3.jpg?width=320");
            ep[222] = new Episode(15, 14, "The Poor Kid", "http://www.southpark.de/alle-episoden/s15e14-immer-%C3%A4rger-mit-proll-trash", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-15/south-park-s15e14-the-poor-kid_4x3.jpg?width=320");

            //Season 16
            ep[223] = new Episode(16, 1, "Reverse Cowgirl", "http://www.southpark.de/alle-episoden/s16e01-r%C3%BCckw%C3%A4rts-reiten", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e01-reverse-cowgirl_4x3.jpg?width=320");
            ep[224] = new Episode(16, 2, "Cash For Gold", "http://www.southpark.de/alle-episoden/s16e02-wer-hat-zuerst-gerochen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e02-cash-for-gold_4x3.jpg?width=320");
            ep[225] = new Episode(16, 3, "Faith Hilling", "http://www.southpark.de/alle-episoden/s16e03-faith-hilling", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e03-faith-hilling_4x3.jpg?width=320");
            ep[226] = new Episode(16, 4, "Jewpacabra", "http://www.southpark.de/alle-episoden/s16e04-judapacabra", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e04-jewpacabra_4x3.jpg?width=320");
            ep[227] = new Episode(16, 5, "Butterballs", "http://www.southpark.de/alle-episoden/s16e05-butters-eier", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e05-butterballs_4x3.jpg?width=320");
            ep[228] = new Episode(16, 6, "I Should Have Never Gone Ziplining", "http://www.southpark.de/alle-episoden/s16e06-ziplining", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e06-i-should-have-never-gone-ziplining_4x3.jpg?width=320");
            ep[229] = new Episode(16, 7, "Cartman Finds Love", "http://www.southpark.de/alle-episoden/s16e07-armor-eric", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e07-cartman-finds-love_4x3.jpg?width=320");
            ep[230] = new Episode(16, 8, "Sarcastaball", "http://www.southpark.de/alle-episoden/s16e08-sarcastaball", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e08-sarcastaball_4x3.jpg?width=320");
            ep[231] = new Episode(16, 9, "Raising The Bar", "http://www.southpark.de/alle-episoden/s16e09-eine-hohle-bar", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e09-raising-the-bar_4x3.jpg?width=320");
            ep[232] = new Episode(16, 10, "Insecurity", "http://www.southpark.de/alle-episoden/s16e10-gasmaske", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e10-insecurity_4x3.jpg?width=320");
            ep[233] = new Episode(16, 11, "Going Native", "http://www.southpark.de/alle-episoden/s16e11-urlaub-mit-kenny-butters", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e11-going-native_4x3.jpg?width=320");
            ep[234] = new Episode(16, 12, "A Nightmare On Face Time", "http://www.southpark.de/alle-episoden/s16e12-ein-alptraum-an-halloween", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e12-a-nightmare-on-face-time_4x3.jpg?width=320");
            ep[235] = new Episode(16, 13, "A Scause For Applause", "http://www.southpark.de/alle-episoden/s16e13-ein-toller-applaus", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e13-a-scause-for-applause_4x3.jpg?width=320");
            ep[236] = new Episode(16, 14, "Obama Wins!", "http://www.southpark.de/alle-episoden/s16e14-w%C3%A4hlt-obama", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-16/south-park-s16e14-obama-wins_4x3.jpg?width=320");

            //Season 17
            ep[237] = new Episode(17, 1, "Let Go, Let Gov", "http://www.southpark.de/alle-episoden/s17e01-lass-los-die-nsa-liebt-dich", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e01-let-go-let-gov_4x3.jpg?width=320");
            ep[238] = new Episode(17, 2, "Informative Murder Porn", "http://www.southpark.de/alle-episoden/s17e02-infotainment-m%C3%B6rderpornos", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e02-informative-murder-porn_4x3.jpg?width=320");
            ep[239] = new Episode(17, 3, "World War Zimmerman", "http://www.southpark.de/alle-episoden/s17e03-world-war-zimmerman", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e03-world-war-zimmerman_4x3.jpg?width=320");
            ep[240] = new Episode(17, 4, "Goth Kids 3: Dawn Of The Posers", "http://www.southpark.de/alle-episoden/s17e04-goth-kids-3-dawn-of-the-posers", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e04-goth-kids-3-dawn-of-the-posers_4x3.jpg?width=320");
            ep[241] = new Episode(17, 5, "Taming Strange", "http://www.southpark.de/alle-episoden/s17e05-die-z%C3%A4hmung-des-widerspenstigen-spaltes", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e05-taming-strange_4x3.jpg?width=320");
            ep[242] = new Episode(17, 6, "Ginger Cow", "http://www.southpark.de/alle-episoden/s17e06-ginger-kuh", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e06-ginger-cow_4x3.jpg?width=320");
            ep[243] = new Episode(17, 7, "Black Friday", "http://www.southpark.de/alle-episoden/s17e07-die-red-robin-hochzeit", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e07-black-friday_4x3.jpg?width=320");
            ep[244] = new Episode(17, 8, "A Song of Ass and Fire", "http://www.southpark.de/alle-episoden/s17e08-das-lied-von-arsch-und-feuer", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e08-a-song-of-ass-and-fire_4x3.jpg?width=320");
            ep[245] = new Episode(17, 9, "Titties and Dragons", "http://www.southpark.de/alle-episoden/s17e09-titten-und-drachen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e09-titties-and-dragons_4x3.jpg?width=320");
            ep[246] = new Episode(17, 10, "The Hobbit", "http://www.southpark.de/alle-episoden/s17e10-der-hobbit", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-17/south-park-s17e10-the-hobbit_4x3.jpg?width=320");

            //Season 18
            ep[247] = new Episode(18, 1, "Go Found Yourself", "http://www.southpark.de/alle-episoden/s18e01-leckt-euch-selbst", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e01-go-fund-yourself_4x3.jpg?width=320");
            ep[248] = new Episode(18, 2, "Gluten Free Ebola", "http://www.southpark.de/alle-episoden/s18e02-glutenfreies-ebola", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e02-gluten-free-ebola_4x3.jpg?width=320");
            ep[249] = new Episode(18, 3, "The Cissy", "http://www.southpark.de/alle-episoden/s18e03-die-cissy", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e03-the-cissy_4x3.jpg?width=320");
            ep[250] = new Episode(18, 4, "Handicar", "http://www.southpark.de/alle-episoden/s18e04-handicar", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e04-handicar_4x3.jpg?width=320");
            ep[251] = new Episode(18, 5, "The Magic Bush", "http://www.southpark.de/alle-episoden/s18e05-der-magische-busch", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e05-the-magic-bush_4x3.jpg?width=320");
            ep[252] = new Episode(18, 6, "Freemium Isn't Free", "http://www.southpark.de/alle-episoden/s18e06-freemium-gibts-nicht-umsonst", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e06-freemium-isnt-free_4x3.jpg?width=320");
            ep[253] = new Episode(18, 7, "Grounded Vindaloop", "http://www.southpark.de/alle-episoden/s18e07-die-hausarrest-schleife", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e07-grounded-vindaloop_4x3.jpg?width=320");
            ep[254] = new Episode(18, 8, "Cock Magic", "http://www.southpark.de/alle-episoden/s18e08-piep-hahn-magic", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e08-cock-magic_4x3.jpg?width=320");
            ep[255] = new Episode(18, 9, "#REHASH", "http://www.southpark.de/alle-episoden/s18e09-hashtag-aufw%C3%A4rmen", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e09-rehash_4x3.jpg?width=320");
            ep[256] = new Episode(18, 10, "#HappyHolograms", "http://www.southpark.de/alle-episoden/s18e10-happyholograms", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-18/south-park-s18e10-happy-holograms_4x3.jpg?width=320");

            //Season 19
            ep[257] = new Episode(19, 1, "Stunning And Brave", "http://www.southpark.de/alle-episoden/s19e01-stunning-and-brave", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e01-stunning-and-brave_4x3.jpg?width=320");
            ep[258] = new Episode(19, 2, "Where My Country Gone?", "http://www.southpark.de/alle-episoden/s19e02-where-my-country-gone", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e02-where-my-country-gone_4x3.jpg?width=320");
            ep[259] = new Episode(19, 3, "The City Part Of Town", "http://www.southpark.de/alle-episoden/s19e03-the-city-part-of-town", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e03-the-city-part-of-town_4x3.jpg?width=320");
            ep[260] = new Episode(19, 4, "You're Not Yelping", "http://www.southpark.de/alle-episoden/s19e04-youre-not-yelping", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e04-youre-not-yelping_4x3.jpg?width=320");
            ep[261] = new Episode(19, 5, "Safe Space", "http://www.southpark.de/alle-episoden/s19e05-safe-space", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e05-safe-space_4x3.jpg?width=320");
            ep[262] = new Episode(19, 6, "Tweek x Craig", "http://www.southpark.de/alle-episoden/s19e06-tweek-x-craig", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e06-tweek-x-craig_4x3.jpg?width=320");
            ep[263] = new Episode(19, 7, "Naughty Ninjas", "http://www.southpark.de/alle-episoden/s19e07-naughty-ninjas", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e07-naughty-ninjas_4x3.jpg?width=320");
            ep[264] = new Episode(19, 8, "Sponsored Content", "http://www.southpark.de/alle-episoden/s19e08-sponsored-content", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e08-sponsored-content_4x3.jpg?width=320");
            ep[265] = new Episode(19, 9, "Truth And Advertising", "http://www.southpark.de/alle-episoden/s19e09-truth-and-advertising", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e08-sponsored-content_4x3.jpg?width=320");
            ep[266] = new Episode(19, 10, "PC Principal Final Justice", "http://www.southpark.de/alle-episoden/s19e10-pc-principal-final-justice", "http://southparkstudios.mtvnimages.com/images/shows/south-park/episode-thumbnails/season-19/south-park-s19e10-pc-principal-final-justice_4x3.jpg?width=320");

            #endregion

            #region Family Guy

            //Season 1
            fam[0] = new Episode(1, 1, "Death Has a Shadow", "http://www.kisspanda.net/family-guy-season-1-episode-1-death-has-a-shadow/");
            fam[1] = new Episode(1, 2, "I Never Met the Dead Man", "http://www.kisspanda.net/family-guy-season-1-episode-2-i-never-met-the-dead-man/");
            fam[2] = new Episode(1, 3, "Chitty Chitty Death Bang", "http://www.kisspanda.net/family-guy-season-1-episode-3-chitty-chitty-death-bang/");
            fam[3] = new Episode(1, 4, "Mind Over Murder", "http://www.kisspanda.net/family-guy-season-1-episode-4-mind-over-murder/");
            fam[4] = new Episode(1, 5, "A Hero Sits Next Door", "http://www.kisspanda.net/family-guy-season-1-episode-5-a-hero-sits-next-door/");
            fam[5] = new Episode(1, 6, "The Son Also Draws", "http://www.kisspanda.net/family-guy-season-1-episode-6-the-son-also-draws/");
            fam[6] = new Episode(1, 7, "Brian: Portrait of a Dog", "http://www.kisspanda.net/family-guy-season-1-episode-7-brian-portrait-of-a-dog/");

            //Season 2
            fam[7] = new Episode(2, 1, "Peter, Peter, Caviar Eater", "http://www.kisspanda.net/family-guy-season-1-episode-7-brian-portrait-of-a-dog/");
            fam[8] = new Episode(2, 2, "Holy Crap", "http://www.kisspanda.net/family-guy-season-2-episode-2-holy-crap/");
            fam[9] = new Episode(2, 3, "Da Boom", "http://www.kisspanda.net/family-guy-season-2-episode-3-da-boom/");
            fam[10] = new Episode(2, 4, "Brian in Love", "http://www.kisspanda.net/family-guy-season-2-episode-4-brian-in-love/");
            fam[11] = new Episode(2, 5, "Love Thy Trophy", "http://www.kisspanda.net/family-guy-season-2-episode-5-love-thy-trophy/");
            fam[12] = new Episode(2, 6, "Death Is a Bitch", "http://www.kisspanda.net/family-guy-season-2-episode-6-death-is-a-bitch/");
            fam[13] = new Episode(2, 7, "The King is Dead", "http://www.kisspanda.net/family-guy-season-2-episode-7-the-king-is-dead/");
            fam[14] = new Episode(2, 8, "I Am Peter, Hear Me Roar", "http://www.kisspanda.net/family-guy-season-2-episode-8-i-am-peter-hear-me-roar/");
            fam[15] = new Episode(2, 9, "If I'm Dying' I'm Lyin'", "http://www.kisspanda.net/family-guy-season-2-episode-9-if-im-dyin-im-lyin/");
            fam[16] = new Episode(2, 10, "Running Mates", "http://www.kisspanda.net/family-guy-season-2-episode-10-running-mates/");
            fam[17] = new Episode(2, 11, "A Picture Is Worth 1000 Bucks", "http://www.kisspanda.net/family-guy-season-2-episode-11-a-picture-is-worth-1000-bucks/");
            fam[18] = new Episode(2, 12, "Fifteen Minutes of Shame", "http://www.kisspanda.net/family-guy-season-2-episode-12-fifteen-minutes-of-shame/");
            fam[19] = new Episode(2, 13, "Road to Rhode Island", "http://www.kisspanda.net/family-guy-season-2-episode-13-road-to-rhode-island/");
            fam[20] = new Episode(2, 14, "Let's Go to the Hop", "http://www.kisspanda.net/family-guy-season-2-episode-14-lets-go-to-the-hop/");
            fam[21] = new Episode(2, 15, "Dammit Janet", "http://www.kisspanda.net/family-guy-season-2-episode-15-dammit-janet/");
            fam[22] = new Episode(2, 16, "There's Something About Paulie", "http://www.kisspanda.net/family-guy-season-2-episode-16-theres-something-about-paulie/");
            fam[23] = new Episode(2, 17, "He's Too Sexy for His Fat", "http://www.kisspanda.net/family-guy-season-2-episode-17-hes-too-sexy-for-his-fat/");
            fam[24] = new Episode(2, 18, "E. Peterbus Unum", "http://www.kisspanda.net/family-guy-season-2-episode-18-e-peterbus-unum/");
            fam[25] = new Episode(2, 19, "The Story on Page One", "http://www.kisspanda.net/family-guy-season-2-episode-19-the-story-on-page-one/");
            fam[26] = new Episode(2, 20, "Wasted Talen", "http://www.kisspanda.net/family-guy-season-2-episode-20-wasted-talent/");
            fam[27] = new Episode(2, 21, "Fore, Father", "http://www.kisspanda.net/family-guy-season-2-episode-21-fore-father/");

            //Season 3
            fam[28] = new Episode(3, 1, "The Thin White Line", "http://www.kisspanda.net/family-guy-season-3-episode-1-the-thin-white-line/");
            fam[29] = new Episode(3, 2, "Brian Does Hollywood", "http://www.kisspanda.net/family-guy-season-3-episode-2-brian-does-hollywood/");
            fam[30] = new Episode(3, 3, "Mr. Griffin Goes to Washington", "http://www.kisspanda.net/family-guy-season-3-episode-3-mr-griffin-goes-to-washington/");
            fam[31] = new Episode(3, 4, "One If by Clam, Two If by Seas", "http://www.kisspanda.net/family-guy-season-3-episode-4-one-if-by-clam-two-if-by-sea/");
            fam[32] = new Episode(3, 5, "And the Wiener Is...", "http://www.kisspanda.net/family-guy-season-3-episode-5-and-the-wiener-is/");
            fam[33] = new Episode(3, 6, "Death Lives", "http://www.kisspanda.net/family-guy-season-3-episode-6-death-lives/");
            fam[34] = new Episode(3, 7, "Lethal Weapons", "http://www.kisspanda.net/family-guy-season-3-episode-7-lethal-weapons/");
            fam[35] = new Episode(3, 8, "The Kiss Seen Around the World", "http://www.kisspanda.net/family-guy-season-3-episode-8-the-kiss-seen-around-the-world/");
            fam[36] = new Episode(3, 9, "Mr. Saturday Knight", "http://www.kisspanda.net/family-guy-season-3-episode-9-mr-saturday-knight/");
            fam[37] = new Episode(3, 10, "A Fish Out of Water", "http://www.kisspanda.net/family-guy-season-3-episode-10-a-fish-out-of-water/");
            fam[38] = new Episode(3, 11, "Emission Impossible", "http://www.kisspanda.net/family-guy-season-3-episode-11-emission-impossible/");
            fam[39] = new Episode(3, 12, "To Love and Die in Dixie", "http://www.kisspanda.net/family-guy-season-3-episode-12-to-love-and-die-in-dixie/");
            fam[40] = new Episode(3, 13, "Screwed the Pooch", "http://www.kisspanda.net/family-guy-season-3-episode-13-screwed-the-pooch/");
            fam[41] = new Episode(3, 14, "Peter Griffin: Husband, Father...Brother?", "http://www.kisspanda.net/family-guy-season-3-episode-14-peter-griffin-husband-father-brother/");
            fam[42] = new Episode(3, 15, "Ready, Willing and Disabled", "http://www.kisspanda.net/family-guy-season-3-episode-15-ready-willing-and-disabled/");
            fam[43] = new Episode(3, 16, "A Very Special Family Guy Freaking' Christmas", "http://www.kisspanda.net/family-guy-season-3-episode-16-a-very-special-family-guy-freakin-christmas/");
            fam[44] = new Episode(3, 17, "Brian Wallows and Peter's Swallows", "http://www.kisspanda.net/family-guy-season-3-episode-17-brian-wallows-and-peters-swallows/");
            fam[45] = new Episode(3, 18, "From Method to Madness", "http://www.kisspanda.net/family-guy-season-3-episode-18-from-method-to-madness/");
            fam[46] = new Episode(3, 19, "Stuck Together, Torn Apart", "http://www.kisspanda.net/family-guy-season-3-episode-19-stuck-together-torn-apart/");
            fam[47] = new Episode(3, 20, "Road to Europe", "http://www.kisspanda.net/family-guy-season-3-episode-20-road-to-europe/");
            fam[48] = new Episode(3, 21, "Family Guy Viewer Mail #1", "http://www.kisspanda.net/family-guy-season-3-episode-21-family-guy-viewer-mail-1/");
            fam[49] = new Episode(3, 22, "When You Wish Upon a Weinstein", "http://www.kisspanda.net/family-guy-season-3-episode-22-when-you-wish-upon-a-weinstein/");

            //Season 4
            fam[50] = new Episode(4, 1, "North By North Quahog", "http://www.kisspanda.net/family-guy-season-4-episode-1-north-by-north-quahog/");
            fam[51] = new Episode(4, 2, "Fast Times at Buddy Cianci Jr. High", "http://www.kisspanda.net/family-guy-season-4-episode-2-fast-times-at-buddy-cianci-jr-high/");
            fam[52] = new Episode(4, 3, "Blind Ambition", "http://www.kisspanda.net/family-guy-season-4-episode-3-blind-ambition/");
            fam[53] = new Episode(4, 4, "Don't Make Me Over", "http://www.kisspanda.net/family-guy-season-4-episode-4-dont-make-me-over/");
            fam[54] = new Episode(4, 5, "The Cleveland-Loretta Quagmire", "http://www.kisspanda.net/family-guy-season-4-episode-5-the-cleveland-loretta-quagmire/");
            fam[55] = new Episode(4, 6, "Petarded", "http://www.kisspanda.net/family-guy-season-4-episode-6-petarded/");
            fam[56] = new Episode(4, 7, "Brian the Bachelor", "http://www.kisspanda.net/family-guy-season-4-episode-7-brian-the-bachelor/");
            fam[57] = new Episode(4, 8, "8 Simple Rules For Buying My Teenage Daughter", "http://www.kisspanda.net/family-guy-season-4-episode-8-8-simple-rules-for-buying-my-teenage-daughter/");
            fam[58] = new Episode(4, 9, "Breaking Out Is Hard to Do", "http://www.kisspanda.net/family-guy-season-4-episode-9-breaking-out-is-hard-to-do/");
            fam[59] = new Episode(4, 10, "Model Misbehaviour", "http://www.kisspanda.net/family-guy-season-4-episode-10-model-misbehavior/");
            fam[60] = new Episode(4, 11, "Peter's Got Woods", "http://www.kisspanda.net/family-guy-season-4-episode-11-peters-got-woods/");
            fam[61] = new Episode(4, 12, "The Perfect Castaway", "http://www.kisspanda.net/family-guy-season-4-episode-12-the-perfect-castaway/");
            fam[62] = new Episode(4, 13, "Jungle Love", "http://www.kisspanda.net/family-guy-season-4-episode-13-jungle-love/");
            fam[63] = new Episode(4, 14, "PTV", "http://www.kisspanda.net/family-guy-season-4-episode-14-ptv/");
            fam[64] = new Episode(4, 15, "Brian Goes Back to College", "http://www.kisspanda.net/family-guy-season-4-episode-15-brian-goes-back-to-college/");
            fam[65] = new Episode(4, 16, "The Courtship of Stewie's Father", "http://www.kisspanda.net/family-guy-season-4-episode-16-the-courtship-of-stewies-father/");
            fam[66] = new Episode(4, 17, "Fat Guy Strangler", "http://www.kisspanda.net/family-guy-season-4-episode-17-fat-guy-strangler/");
            fam[67] = new Episode(4, 18, "The Father, the Son and the Holy Fonz", "http://www.kisspanda.net/family-guy-season-4-episode-18-the-father-the-son-and-the-holy-fonz/");
            fam[68] = new Episode(4, 19, "Brian Swings & Sings", "http://www.kisspanda.net/family-guy-season-4-episode-19-brian-sings-swings/");
            fam[69] = new Episode(4, 20, "Patriot Games", "http://www.kisspanda.net/family-guy-season-4-episode-20-patriot-games/");
            fam[70] = new Episode(4, 21, "I Take Thee, Quagmire", "http://www.kisspanda.net/family-guy-season-4-episode-21-i-take-thee-quagmire/");
            fam[71] = new Episode(4, 22, "Sibling Rivalry", "http://www.kisspanda.net/family-guy-season-4-episode-22-sibling-rivalry/");
            fam[72] = new Episode(4, 23, "Deep Throats", "http://www.kisspanda.net/family-guy-season-4-episode-23-deep-throats/");
            fam[73] = new Episode(4, 24, "Peterotica", "http://www.kisspanda.net/family-guy-season-4-episode-24-peterotica/");
            fam[74] = new Episode(4, 25, "You May Now Kiss the... Uh ..Guy Who Receives", "http://www.kisspanda.net/family-guy-season-4-episode-25-you-may-now-kiss-the-uh-guy-who-receives/");
            fam[75] = new Episode(4, 26, "Petergeist", "http://www.kisspanda.net/family-guy-season-4-episode-26-petergeist/");
            fam[76] = new Episode(4, 27, "Untitled Griffin Family History", "http://www.kisspanda.net/family-guy-season-4-episode-27-untitled-griffin-family-history/");
            fam[77] = new Episode(4, 28, "Stewie B. Goode", "http://www.kisspanda.net/family-guy-season-4-episode-28-stewie-b-goode/");
            fam[78] = new Episode(4, 29, "Bango Was His Name. Oh!", "http://www.kisspanda.net/family-guy-season-4-episode-29-bango-was-his-name-oh/");
            fam[79] = new Episode(4, 30, "Stu & Stewie's Excellent Adventure", "http://www.kisspanda.net/family-guy-season-4-episode-30-stu-stewies-excellent-adventure/");

            //Season 5
            fam[80] = new Episode(5, 1, "Stewie Loves Lois", "http://www.kisspanda.net/family-guy-season-5-episode-1-stewie-loves-lois/") ;
            fam[81] = new Episode(5, 2, "Mother Tucker", "http://www.kisspanda.net/family-guy-season-5-episode-2-mother-tucker/") ;
            fam[82] = new Episode(5, 3, "Hell Comes to Quahog", "http://www.kisspanda.net/family-guy-season-5-episode-3-hell-comes-to-quahog/") ;
            fam[83] = new Episode(5, 4, "Saving Private Brian", "http://www.kisspanda.net/family-guy-season-5-episode-4-saving-private-brian/") ;
            fam[84] = new Episode(5, 5, "Whistle While Your Wife Works", "http://www.kisspanda.net/family-guy-season-5-episode-5-whistle-while-your-wife-works/") ;
            fam[85] = new Episode(5, 6, "Prick Up Your Ears", "http://www.kisspanda.net/family-guy-season-5-episode-6-prick-up-your-ears/") ;
            fam[86] = new Episode(5, 7, "Chick Cancer", "http://www.kisspanda.net/family-guy-season-5-episode-7-chick-cancer/") ;
            fam[87] = new Episode(5, 8, "Barely Legal", "http://www.kisspanda.net/family-guy-season-5-episode-8-barely-legal/") ;
            fam[88] = new Episode(5, 9, "Road to Rupert", "http://www.kisspanda.net/family-guy-season-5-episode-9-road-to-rupert/") ;
            fam[89] = new Episode(5, 10, "Peter's Two Dads", "http://www.kisspanda.net/family-guy-season-5-episode-10-peters-two-dads/") ;
            fam[90] = new Episode(5, 11, "The Tan Aquatic with Steve Zissou", "http://www.kisspanda.net/family-guy-season-5-episode-11-the-tan-aquatic-with-steve-zissou/") ;
            fam[91] = new Episode(5, 12, "Airport 07", "http://www.kisspanda.net/family-guy-season-5-episode-12-airport-07/") ;
            fam[92] = new Episode(5, 13, "Bill & Peter's Bogus Journey", "http://www.kisspanda.net/family-guy-season-5-episode-13-bill-peters-bogus-journey/") ;
            fam[93] = new Episode(5, 14, "No Meals On Wheels", "http://www.kisspanda.net/family-guy-season-5-episode-14-no-meals-on-wheels/") ;
            fam[94] = new Episode(5, 15, "Boys Do Cry", "http://www.kisspanda.net/family-guy-season-5-episode-15-boys-do-cry/") ;
            fam[95] = new Episode(5, 16, "No Chris Left Behind", "http://www.kisspanda.net/family-guy-season-5-episode-16-no-chris-left-behind/") ;
            fam[96] = new Episode(5, 17, "It Takes a Village Idiot, and I Married One", "http://www.kisspanda.net/family-guy-season-5-episode-17-it-takes-a-village-idiot-and-i-married-one/") ;
            fam[97] = new Episode(5, 18, "Meet the Quagmires", "http://www.kisspanda.net/family-guy-season-5-episode-18-meet-the-quagmires/") ;

            //Season 6
            fam[98] = new Episode(6, 1 ,"Blue Harvest", "http://www.kisspanda.net/family-guy-season-6-episode-1-blue-harvest/") ;
            fam[99] = new Episode(6, 2, "Movin' Out (Brians Song)", "http://www.kisspanda.net/family-guy-season-6-episode-2-movin-out-brians-song/") ;
            fam[100] = new Episode(6, 3, "Believe It Or Not, Joe's Walking On Air", "http://www.kisspanda.net/family-guy-season-6-episode-3-believe-it-or-not-joes-walking-on-air/") ;
            fam[101] = new Episode(6, 4, "Stewie Kills Lois", "http://www.kisspanda.net/family-guy-season-6-episode-4-stewie-kills-lois/") ;
            fam[102] = new Episode(6, 5, "Lois Kills Stewie", "http://www.kisspanda.net/family-guy-season-6-episode-5-lois-kills-stewie/") ;
            fam[103] = new Episode(6, 6, "Padre de Familia", "http://www.kisspanda.net/family-guy-season-6-episode-6-padre-de-familia/") ;
            fam[104] = new Episode(6, 7, "Peter's Daughter", "http://www.kisspanda.net/family-guy-season-6-episode-7-peters-daughter/") ;
            fam[105] = new Episode(6, 8, "McStroke", "http://www.kisspanda.net/family-guy-season-6-episode-8-mcstroke/") ;
            fam[106] = new Episode(6, 9, "Back to the Woods", "http://www.kisspanda.net/family-guy-season-6-episode-9-back-to-the-woods/") ;
            fam[107] = new Episode(6, 10, "Play It Again, Brian", "http://www.kisspanda.net/family-guy-season-6-episode-10-play-it-again-brian/") ;
            fam[108] = new Episode(6, 11, "The Former Life of Brian", "http://www.kisspanda.net/family-guy-season-6-episode-11-the-former-life-of-brian/") ;
            fam[109] = new Episode(6, 12, "Long John Peter", "http://www.kisspanda.net/family-guy-season-6-episode-12-long-john-peter/") ;

            //Season 7
            fam[110] = new Episode(7, 1, "Love Blactually", "http://www.kisspanda.net/family-guy-season-7-episode-1-love-blactually/") ;
            fam[111] = new Episode(7, 2, "I Dream of Jesus", "http://www.kisspanda.net/family-guy-season-7-episode-2-i-dream-of-jesus/") ;
            fam[112] = new Episode(7, 3, "Road to Germany", "http://www.kisspanda.net/family-guy-season-7-episode-3-road-to-germany/") ;
            fam[113] = new Episode(7, 4, "Baby not on Board", "http://www.kisspanda.net/family-guy-season-7-episode-4-baby-not-on-board/") ;
            fam[114] = new Episode(7, 5, "The Man with Two Brains", "http://www.kisspanda.net/family-guy-season-7-episode-5-the-man-with-two-brians/") ;
            fam[115] = new Episode(7, 6, "Tales of a Third Grade Nothing", "http://www.kisspanda.net/family-guy-season-7-episode-6-tales-of-a-third-grade-nothing/") ;
            fam[116] = new Episode(7, 7, "Ocean's Three and a Half", "http://www.kisspanda.net/family-guy-season-7-episode-7-oceans-three-and-a-half/") ;
            fam[117] = new Episode(7, 8, "Family Gay", "http://www.kisspanda.net/family-guy-season-7-episode-8-family-gay/") ;
            fam[118] = new Episode(7, 9, "The Juice is Loose!", "http://www.kisspanda.net/family-guy-season-7-episode-9-the-juice-is-loose/") ;
            fam[119] = new Episode(7, 10, "FOX-y Lady", "http://www.kisspanda.net/family-guy-season-7-episode-10-fox-y-lady/") ;
            fam[120] = new Episode(7, 11, "Not All Dogs Go to Heaven", "http://www.kisspanda.net/family-guy-season-7-episode-11-not-all-dogs-go-to-heaven/") ;
            fam[121] = new Episode(7, 12, "420", "http://www.kisspanda.net/family-guy-season-7-episode-13-stew-roids/") ;
            fam[122] = new Episode(7, 13, "Stew-Roids", "http://www.kisspanda.net/family-guy-season-7-episode-13-stew-roids/") ;
            fam[123] = new Episode(7, 14, "We Love You Conrad", "http://www.kisspanda.net/family-guy-season-7-episode-14-we-love-you-conrad/") ;
            fam[124] = new Episode(7, 15, "Three Kings", "http://www.kisspanda.net/family-guy-season-7-episode-15-three-kings/") ;
            fam[125] = new Episode(7, 16, "Peter's Progress", "http://www.kisspanda.net/family-guy-season-7-episode-16-peters-progress/") ;

            //Season 8
            fam[126] = new Episode(8, 1, "Road to the Multiverse", "http://www.kisspanda.net/family-guy-season-8-episode-1-road-to-the-multiverse/") ;
            fam[127] = new Episode(8, 2, "Family Goy", "http://www.kisspanda.net/family-guy-season-8-episode-2-family-goy/") ;
            fam[128] = new Episode(8, 3, "Spies Reminiscent of Us", "http://www.kisspanda.net/family-guy-season-8-episode-3-spies-reminiscent-of-us/") ;
            fam[129] = new Episode(8, 4, "Brian's Got a Brand New Bag", "http://www.kisspanda.net/family-guy-season-8-episode-4-brians-got-a-brand-new-bag/") ;
            fam[130] = new Episode(8, 5, "Hannah Banana", "http://www.kisspanda.net/family-guy-season-8-episode-5-hannah-banana/") ;
            fam[131] = new Episode(8, 6, "Quagmire's Baby", "http://www.kisspanda.net/family-guy-season-8-episode-6-quagmires-baby/") ;
            fam[132] = new Episode(8, 7, "Jerome Is the New Black", "http://www.kisspanda.net/family-guy-season-8-episode-7-jerome-is-the-new-black/") ;
            fam[133] = new Episode(8, 8, "Dog Gone", "http://www.kisspanda.net/family-guy-season-8-episode-8-dog-gone/") ;
            fam[134] = new Episode(8, 9, "Business Guy", "http://www.kisspanda.net/family-guy-season-8-episode-9-business-guy/") ;
            fam[135] = new Episode(8, 10, "Big Man on Hippocampus", "http://www.kisspanda.net/family-guy-season-8-episode-10-big-man-on-hippocampus/") ;
            fam[136] = new Episode(8, 11, "Dial Meg for Murder", "http://www.kisspanda.net/family-guy-season-8-episode-11-dial-meg-for-murder/") ;
            fam[137] = new Episode(8, 12, "Extra Large Medium", "http://www.kisspanda.net/family-guy-season-8-episode-12-extra-large-medium/") ;
            fam[138] = new Episode(8, 13, "Go, Stewie, Go!", "http://www.kisspanda.net/family-guy-season-8-episode-13-go-stewie-go/") ;
            fam[139] = new Episode(8, 14, "Peter-assment", "http://www.kisspanda.net/family-guy-season-8-episode-14-peter-assment/") ;
            fam[140] = new Episode(8, 15, "Brian Griffin's House of Payne", "http://www.kisspanda.net/family-guy-season-8-episode-15-brian-griffins-house-of-payne/") ;
            fam[141] = new Episode(8, 16, "April in Quahog", "http://www.kisspanda.net/family-guy-season-8-episode-16-april-in-quahog/") ;
            fam[142] = new Episode(8, 17, "Brian & Stewie", "http://www.kisspanda.net/family-guy-season-8-episode-17-brian-stewie/") ;
            fam[143] = new Episode(8, 18, "Quagmire's Dad", "http://www.kisspanda.net/family-guy-season-8-episode-18-quagmires-dad/") ;
            fam[144] = new Episode(8, 19, "The Splendid Source", "http://www.kisspanda.net/family-guy-season-8-episode-19-the-splendid-source/") ;
            fam[145] = new Episode(8, 20, "Something, Something, Dark Side", "http://www.kisspanda.net/family-guy-season-8-episode-20-something-something-something-dark-side/") ;
            fam[146] = new Episode(8, 21, "Partial Terms of Endearment", "http://www.kisspanda.net/family-guy-season-8-episode-21-partial-terms-of-endearment/") ;

            //Season 9 
            fam[147] = new Episode(9, 1, "And Then There Were Fewer", "http://www.kisspanda.net/family-guy-season-9-episode-1-and-then-there-were-fewer/") ;
            fam[148] = new Episode(9, 2, "Excellence in Broadcasting", "http://www.kisspanda.net/family-guy-season-9-episode-2-excellence-in-broadcasting/") ;
            fam[149] = new Episode(9, 3, "Welcome Back Carter", "http://www.kisspanda.net/family-guy-season-9-episode-3-welcome-back-carter/") ;
            fam[150] = new Episode(9, 4, "Halloween on Spooner Street", "http://www.kisspanda.net/family-guy-season-9-episode-4-halloween-on-spooner-street/") ;
            fam[151] = new Episode(9, 5, "Baby, You Knock Me Out", "http://www.kisspanda.net/family-guy-season-9-episode-5-baby-you-knock-me-out/") ;
            fam[152] = new Episode(9, 6, "Brian Writes a Bestseller", "http://www.kisspanda.net/family-guy-season-9-episode-6-brian-writes-a-bestseller/") ;
            fam[153] = new Episode(9, 7, "Road to the Northpole", "http://www.kisspanda.net/family-guy-season-9-episode-7-road-to-the-north-pole/") ;
            fam[154] = new Episode(9, 8, "New Kidney in Town", "http://www.kisspanda.net/family-guy-season-9-episode-8-new-kidney-in-town/") ;
            fam[155] = new Episode(9, 9, "And I'm Joyce Kinney", "http://www.kisspanda.net/family-guy-season-9-episode-9-and-im-joyce-kinney/") ;
            fam[156] = new Episode(9, 10, "Friends of Peter G.", "http://www.kisspanda.net/family-guy-season-9-episode-10-friends-of-peter-g/") ;
            fam[157] = new Episode(9, 11, "German Guy", "http://www.kisspanda.net/family-guy-season-9-episode-11-german-guy/") ;
            fam[158] = new Episode(9, 12, "The Hand That Rocks the Wheelchair", "http://www.kisspanda.net/family-guy-season-9-episode-12-the-hand-that-rocks-the-wheelchair/") ;
            fam[159] = new Episode(9, 13, "Trading Places", "http://www.kisspanda.net/family-guy-season-9-episode-13-trading-places/") ;
            fam[160] = new Episode(9, 14, "Tiegs for Two", "http://www.kisspanda.net/family-guy-season-9-episode-14-tiegs-for-two/") ;
            fam[161] = new Episode(9, 15, "Brothers & Sisters", "http://www.kisspanda.net/family-guy-season-9-episode-15-brothers-sisters/") ;
            fam[162] = new Episode(9, 16, "The Big Bang Theory", "http://www.kisspanda.net/family-guy-season-9-episode-16-the-big-bang-theory/") ;
            fam[163] = new Episode(9, 17, "Foreign Affairs", "http://www.kisspanda.net/family-guy-season-9-episode-17-foreign-affairs/") ;
            fam[164] = new Episode(9, 18, "Episode VI: It's a Trap", "http://www.kisspanda.net/family-guy-season-9-episode-18-episode-vi-its-a-trap/") ;

            //Season 10 
            fam[165] = new Episode(10, 1, "Lottery Fever", "http://www.kisspanda.net/family-guy-season-10-episode-1-lottery-fever/") ;
            fam[166] = new Episode(10, 2, "Seahorse Seashell Party", "http://www.kisspanda.net/family-guy-season-10-episode-2-seahorse-seashell-party/") ;
            fam[167] = new Episode(10, 3, "Screams of Silence: The Story of Brenda Q", "http://www.kisspanda.net/family-guy-season-10-episode-3-screams-of-silence-the-story-of-brenda-q/") ;
            fam[168] = new Episode(10, 4, "Stewie Goes For a Drive", "http://www.kisspanda.net/family-guy-season-10-episode-4-stewie-goes-for-a-drive/") ;
            fam[169] = new Episode(10, 5, "Back to the Pilot", "http://www.kisspanda.net/family-guy-season-10-episode-5-back-to-the-pilot/") ;
            fam[170] = new Episode(10, 6, "Thanksgiving", "http://www.kisspanda.net/family-guy-season-10-episode-6-thanksgiving/") ;
            fam[171] = new Episode(10, 7, "Amish Guy", "http://www.kisspanda.net/family-guy-season-10-episode-7-amish-guy/") ;
            fam[172] = new Episode(10, 8, "Cool Hand Peter", "http://www.kisspanda.net/family-guy-season-10-episode-8-cool-hand-peter/") ;
            fam[173] = new Episode(10, 9, "Grumpy Old Man", "http://www.kisspanda.net/family-guy-season-10-episode-9-grumpy-old-man/") ;
            fam[174] = new Episode(10, 10, "Meg and Quagmire", "http://www.kisspanda.net/family-guy-season-10-episode-10-meg-and-quagmire/") ;
            fam[175] = new Episode(10, 11, "The Blind Side", "http://www.kisspanda.net/family-guy-season-10-episode-11-the-blind-side/") ;
            fam[176] = new Episode(10, 12, "Livin' On A Prayer", "http://www.kisspanda.net/family-guy-season-10-episode-12-livin-on-a-prayer/") ;
            fam[177] = new Episode(10, 13, "Tom Tucker: The Man and His Dream", "http://www.kisspanda.net/family-guy-season-10-episode-13-tom-tucker-the-man-and-his-dream/") ;
            fam[178] = new Episode(10, 14, "Be Careful What You Wish For", "http://www.kisspanda.net/family-guy-season-10-episode-14-be-careful-what-you-fish-for/") ;
            fam[179] = new Episode(10, 15, "Burning Down the Bayit", "http://www.kisspanda.net/family-guy-season-10-episode-15-burning-down-the-bayit/") ;
            fam[180] = new Episode(10, 16, "Killer Queen", "http://www.kisspanda.net/family-guy-season-10-episode-16-killer-queen/") ;
            fam[181] = new Episode(10, 17, "Forget Me Not", "http://www.kisspanda.net/family-guy-season-10-episode-17-forget-me-not/") ;
            fam[182] = new Episode(10, 18, "You Can't Do That on Television, Peter", "http://www.kisspanda.net/family-guy-season-10-episode-18-you-cant-do-that-on-television-peter/") ;
            fam[183] = new Episode(10, 19, "Mr. & Mrs. Stewie", "http://www.kisspanda.net/family-guy-season-10-episode-19-mr-mrs-stewie/") ;
            fam[184] = new Episode(10, 20, "Leggo My Meg-O", "http://www.kisspanda.net/family-guy-season-10-episode-20-leggo-my-meg-o/") ;
            fam[185] = new Episode(10, 21, "Tea Peter", "http://www.kisspanda.net/family-guy-season-10-episode-21-tea-peter/") ;
            fam[186] = new Episode(10, 22, "Viewer Mail #2", "http://www.kisspanda.net/family-guy-season-10-episode-22-viewer-mail-2/") ;
            fam[187] = new Episode(10, 23, "Internal Affairs", "http://www.kisspanda.net/family-guy-season-10-episode-23-internal-affairs/") ;

            //Season 11
            fam[188] = new Episode(11, 1, "Into Fat Air", "http://www.kisspanda.net/family-guy-season-11-episode-1-into-fat-air/") ;
            fam[189] = new Episode(11, 2, "Ratings Guy", "http://www.kisspanda.net/family-guy-season-11-episode-2-ratings-guy/") ;
            fam[190] = new Episode(11, 3, "The Old Man and the Big C", "http://www.kisspanda.net/family-guy-season-11-episode-3-the-old-man-and-the-big-c/") ;
            fam[191] = new Episode(11, 4, "Yug Yilmaf", "http://www.kisspanda.net/family-guy-season-11-episode-4-yug-ylimaf/") ;
            fam[192] = new Episode(11, 5, "Joe's Revenge", "http://www.kisspanda.net/family-guy-season-11-episode-5-joes-revenge/") ;
            fam[193] = new Episode(11, 6, "Lois Comes Out of Her Shell", "http://www.kisspanda.net/family-guy-season-11-episode-6-lois-comes-out-of-her-shell/") ;
            fam[194] = new Episode(11, 7, "Friend Without Benefits", "http://www.kisspanda.net/family-guy-season-11-episode-7-friends-without-benefits/") ;
            fam[195] = new Episode(11, 8, "Jesus, Mary and Joseph!", "http://www.kisspanda.net/family-guy-season-11-episode-8-jesus-mary-and-joseph/") ;
            fam[196] = new Episode(11, 9, "Space Cadet", "http://www.kisspanda.net/family-guy-season-11-episode-9-space-cadet/") ;
            fam[197] = new Episode(11, 10, "Brian's Play", "http://www.kisspanda.net/family-guy-season-11-episode-10-brians-play/") ;
            fam[198] = new Episode(11, 11, "The Giggity Wife", "http://www.kisspanda.net/family-guy-season-11-episode-11-the-giggity-wife/") ;
            fam[199] = new Episode(11, 12, "Valentine's Day in Quahog", "http://www.kisspanda.net/family-guy-season-11-episode-12-valentines-day-in-quahog/") ;
            fam[200] = new Episode(11, 13, "Chris Cross", "http://www.kisspanda.net/family-guy-season-11-episode-13-chris-cross/") ;
            fam[201] = new Episode(11, 14, "Call Girl", "http://www.kisspanda.net/family-guy-season-11-episode-14-call-girl/") ;
            fam[202] = new Episode(11, 15, "Turban Cowboy", "http://www.kisspanda.net/family-guy-season-11-episode-15-turban-cowboy/") ;
            fam[203] = new Episode(11, 16, "12 and a Half Angry Man", "http://www.kisspanda.net/family-guy-season-11-episode-16-12-and-a-half-angry-men/") ;
            fam[204] = new Episode(11, 17, "Bigfat", "http://www.kisspanda.net/family-guy-season-11-episode-17-bigfat/") ;
            fam[205] = new Episode(11, 18, "Total Recall", "http://www.kisspanda.net/family-guy-season-11-episode-18-total-recall/") ;
            fam[206] = new Episode(11, 19, "Save the Clam", "http://www.kisspanda.net/family-guy-season-11-episode-19-save-the-clam/") ;
            fam[207] = new Episode(11, 20, "Farmer Guy", "http://www.kisspanda.net/family-guy-season-11-episode-20-farmer-guy/") ;
            fam[208] = new Episode(11, 21, "Roads to Vegas", "http://www.kisspanda.net/family-guy-season-11-episode-21-roads-to-vegas/") ;
            fam[209] = new Episode(11, 22, "No County Club for Old Men", "http://www.kisspanda.net/family-guy-season-11-episode-22-no-country-club-for-old-men/") ;

            //Season 12
            fam[210] = new Episode(12, 1, "Finders Keepers", "http://www.kisspanda.net/family-guy-season-12-episode-1-finders-keepers/") ;
            fam[211] = new Episode(12, 2, "Vestigial Peter", "http://www.kisspanda.net/family-guy-season-12-episode-2-vestigial-peter/") ;
            fam[212] = new Episode(12, 3, "Quagmire's Quagmire", "http://www.kisspanda.net/family-guy-season-12-episode-3-quagmires-quagmire/") ;
            fam[213] = new Episode(12, 4, "A Fistful Of Meg", "http://www.kisspanda.net/family-guy-season-12-episode-4-a-fistful-of-meg/") ;
            fam[214] = new Episode(12, 5, "Boopa-dee Bappa-dee", "http://www.kisspanda.net/family-guy-season-12-episode-5-boopa-dee-bappa-dee/") ;
            fam[215] = new Episode(12, 6, "Life of Brian", "http://www.kisspanda.net/family-guy-season-12-episode-6-life-of-brian/") ;
            fam[216] = new Episode(12, 7, "Into Harmony's Way", "http://www.kisspanda.net/family-guy-season-12-episode-7-into-harmonys-way/") ;
            fam[217] = new Episode(12, 8, "Christmas Guy", "http://www.kisspanda.net/family-guy-season-12-episode-8-christmas-guy/") ;
            fam[218] = new Episode(12, 9, "Peter Problems", "http://www.kisspanda.net/family-guy-season-12-episode-9-peter-problems/") ;
            fam[219] = new Episode(12, 10, "Grimm Job", "http://www.kisspanda.net/family-guy-season-12-episode-10-grimm-job/") ;
            fam[220] = new Episode(12, 11, "Brian's a Bad Father", "http://www.kisspanda.net/family-guy-season-12-episode-11-brians-a-bad-father/") ;
            fam[221] = new Episode(12, 12, "Mom's The Word", "http://www.kisspanda.net/family-guy-season-12-episode-12-moms-the-word/") ;
            fam[222] = new Episode(12, 13, "3 Acts of God", "http://www.kisspanda.net/family-guy-season-12-episode-13-3-acts-of-god/") ;
            fam[223] = new Episode(12, 14, "Fresh Heir", "http://www.kisspanda.net/family-guy-season-12-episode-14-fresh-heir/") ;
            fam[224] = new Episode(12, 15, "Secondhand Spoke", "http://www.kisspanda.net/family-guy-season-12-episode-15-secondhand-spoke/") ;
            fam[225] = new Episode(12, 16, "Herpe, the Love Sore", "http://www.kisspanda.net/family-guy-season-12-episode-16-herpe-the-love-sore/") ;
            fam[226] = new Episode(12, 17, "The Most Interesting Man in the World", "http://www.kisspanda.net/family-guy-season-12-episode-17-the-most-interesting-man-in-the-world/") ;
            fam[227] = new Episode(12, 18, "Baby Got Black", "http://www.kisspanda.net/family-guy-season-12-episode-18-baby-got-black/") ;
            fam[228] = new Episode(12, 19, "Meg Stinks!", "http://www.kisspanda.net/family-guy-season-12-episode-19-meg-stinks/") ;
            fam[229] = new Episode(12, 20, "He's Bla-ack!", "http://www.kisspanda.net/family-guy-season-12-episode-20-hes-bla-ack/") ;
            fam[230] = new Episode(12, 21, "Chap Stewie", "http://www.kisspanda.net/family-guy-season-12-episode-21-chap-stewie/") ;

            //Seson 13
            fam[231] = new Episode(13, 1, "The Simpsons Guy", "http://www.kisspanda.net/family-guy-season-13-episode-1-the-simpsons-guy/") ;
            fam[232] = new Episode(13, 2, "Book of Joe", "http://www.kisspanda.net/family-guy-season-13-episode-2-book-of-joe/") ;
            fam[233] = new Episode(13, 3, "Baking Bad", "http://www.kisspanda.net/family-guy-season-13-episode-3-baking-bad/") ;
            fam[234] = new Episode(13, 4, "Brian the Closer", "http://www.kisspanda.net/family-guy-season-13-episode-4-brian-the-closer/") ;
            fam[235] = new Episode(13, 5, "Turkey Guys", "http://www.kisspanda.net/family-guy-season-13-episode-5-turkey-guys/") ;
            fam[236] = new Episode(13, 6, "The 2000 Year Old Virgin", "http://www.kisspanda.net/family-guy-season-13-episode-6-the-2000-year-old-virgin/") ;
            fam[237] = new Episode(13, 7, "Stewie, Chris & Brian's Excellent Adventure", "http://www.kisspanda.net/family-guy-season-13-episode-7-stewie-chris-brians-excellent-adventure/") ;
            fam[238] = new Episode(13, 8, "Our Idiot Brian", "http://www.kisspanda.net/family-guy-season-13-episode-8-our-idiot-brian/") ;
            fam[239] = new Episode(13, 9, "This Little Piggy", "http://www.kisspanda.net/family-guy-season-13-episode-9-this-little-piggy/") ;
            fam[240] = new Episode(13, 10, "Quagmire's Mom", "http://www.kisspanda.net/family-guy-season-13-episode-10-quagmires-mom/") ;
            fam[241] = new Episode(13, 11, "Encyclopedia Griffin", "http://www.kisspanda.net/family-guy-season-13-episode-11-encyclopedia-griffin/") ;
            fam[242] = new Episode(13, 12, "Stewie Is Enceinte", "http://www.kisspanda.net/family-guy-season-13-episode-12-stewie-is-enceinte/") ;
            fam[243] = new Episode(13, 13, "Dr. C and the Woman", "http://www.kisspanda.net/family-guy-season-13-episode-13-dr-c-and-the-women/") ;
            fam[244] = new Episode(13, 14, "JOLO", "http://www.kisspanda.net/family-guy-season-13-episode-14-jolo/") ;
            fam[245] = new Episode(13, 15, "Once Bitten", "http://www.kisspanda.net/family-guy-season-13-episode-15-once-bitten/") ;
            fam[246] = new Episode(13, 16, "Roasted Guy", "http://www.kisspanda.net/family-guy-season-13-episode-16-roasted-guy/") ;
            fam[247] = new Episode(13, 17, "Fighting Irish", "http://www.kisspanda.net/family-guy-season-13-episode-17-fighting-irish/") ;
            fam[248] = new Episode(13, 18, "Take My Wife", "http://www.kisspanda.net/family-guy-season-13-episode-18-take-my-wife/") ;

            //Season 14
            fam[249] = new Episode(14, 1, "Pilling Them Softly", "http://www.kisspanda.net/family-guy-season-14-episode-1-pilling-them-softly/") ;
            fam[250] = new Episode(14, 2, "Papa Has a Rollin' Son", "http://www.kisspanda.net/family-guy-season-14-episode-2-papa-has-a-rollin-son/") ;
            fam[251] = new Episode(14, 3, "Guy, Robot", "http://www.kisspanda.net/family-guy-season-14-episode-3-guy-robot/") ;
            fam[252] = new Episode(14, 4, "Peternormal Activity", "http://www.kisspanda.net/family-guy-season-14-episode-4-peternormal-activity/") ;
            fam[253] = new Episode(14, 5, "Peter, Chris & Brian", "http://www.kisspanda.net/family-guy-season-14-episode-5-peter-chris-brian/") ;
            fam[254] = new Episode(14, 6, "Peter's Sister", "http://www.kisspanda.net/family-guy-season-14-episode-6-peters-sister/") ;
            fam[255] = new Episode(14, 7, "Hot Pocker-Dial", "http://www.kisspanda.net/family-guy-season-14-episode-7-hot-pocket-dial/") ;
            fam[256] = new Episode(14, 8, "Brokeback Swanson", "http://www.kisspanda.net/family-guy-season-14-episode-8-brokeback-swanson/") ;
            fam[257] = new Episode(14, 9, "A Shot in the Dark", "http://www.kisspanda.net/family-guy-season-14-episode-9-a-shot-in-the-dark/") ;
            fam[258] = new Episode(14, 10, "Candy, Quahog Marshmallow", "http://www.kisspanda.net/family-guy-season-14-episode-10-candy-quahog-marshmallow/") ;
            fam[259] = new Episode(14, 11, "The Peanut Butter King", "http://www.kisspanda.net/family-guy-season-14-episode-11-the-peanut-butter-kid/") ;
            fam[260] = new Episode(14, 12, "Scammed Yankees", "http://www.kisspanda.net/family-guy-season-14-episode-12-scammed-yankees/") ;
            fam[261] = new Episode(14, 13, "An App A Day", "http://www.kisspanda.net/family-guy-season-14-episode-13/") ;
            fam[262] = new Episode(14, 14, "Underage Peter", "http://www.kisspanda.net/family-guy-season-14-episode-14-underage-peter/") ;

            #endregion

            #region American Dad
            //Staffel 1
            amer[0] = new Episode(1, 1, "Pilot", "http://geektv.me/watch/55433") ;
            amer[1] = new Episode(1, 2, "Threat Levels", "http://geektv.me/watch/55432") ;
            amer[2] = new Episode(1, 3, "Stan Knows Best", "http://geektv.me/watch/55431") ;
            amer[3] = new Episode(1, 4, "Francine's Flashback", "http://geektv.me/watch/55430") ;
            amer[4] = new Episode(1, 5, "Roger Codger", "http://geektv.me/watch/55429") ;
            amer[5] = new Episode(1, 6, "Homeland Insecurity", "http://geektv.me/watch/55427") ;
            amer[6] = new Episode(1, 7, "Deacon Stan, Jesus Man", "http://geektv.me/watch/55426") ;
            amer[7] = new Episode(1, 8, "Bullocks to Stan", "http://geektv.me/watch/55425") ;
            amer[8] = new Episode(1, 9, "A Smith in the Hand", "http://geektv.me/watch/55424") ;
            amer[9] = new Episode(1, 10, "All About Steve", "http://geektv.me/watch/55423") ;
            amer[10] = new Episode(1, 11, "Con Heir", "http://geektv.me/watch/55422") ;
            amer[11] = new Episode(1, 12, "Stan of Arabia Part I", "http://geektv.me/watch/55421") ;
            amer[12] = new Episode(1, 13, "Stan of Arabia Part II", "http://geektv.me/watch/55420") ;
            amer[13] = new Episode(1, 14, "Stannie Get Your Gun", "http://geektv.me/watch/55419") ;
            amer[14] = new Episode(1, 15, "Star Trek", "http://geektv.me/watch/55418") ;
            amer[15] = new Episode(1, 16, "Not Particulary Desperate Housewife", "http://geektv.me/watch/55417") ;
            amer[16] = new Episode(1, 17, "Rough Trade", "http://geektv.me/watch/55416") ;
            amer[17] = new Episode(1, 18, "Fiances With Wolves", "http://geektv.me/watch/55415") ;
            amer[18] = new Episode(1, 19, "It's Good to Be the Queen", "http://geektv.me/watch/55414") ;
            amer[19] = new Episode(1, 20, "Roger'n' Me", "http://geektv.me/watch/55413") ;
            amer[20] = new Episode(1, 21, "Helping Handis", "http://geektv.me/watch/55412") ;
            amer[21] = new Episode(1, 22, "With Friends Like Steve's", "http://geektv.me/watch/55411") ;
            amer[22] = new Episode(1, 23, "Tears of a Clooney", "http://geektv.me/watch/55410") ;

            //Staffel 2
            amer[23] = new Episode(2, 1, "Camp Refoogee", "http://geektv.me/watch/55409") ;
            amer[24] = new Episode(2, 2, "The American Dad After School Special", "http://geektv.me/watch/55408") ;
            amer[25] = new Episode(2, 3, "Failure Is Not a Factory-installed Option", "http://geektv.me/watch/55407") ;
            amer[26] = new Episode(2, 4, "Lincoln Lover", "http://geektv.me/watch/55406") ;
            amer[27] = new Episode(2, 5, "Dungeons and Wagons", "http://geektv.me/watch/55405") ;
            amer[28] = new Episode(2, 6, "Iced, Iced Babys", "http://geektv.me/watch/55404") ;
            amer[29] = new Episode(2, 7, "Of Ice and Men", "http://geektv.me/watch/55403") ;
            amer[30] = new Episode(2, 8, "Irregarding Steve", "http://geektv.me/watch/55402") ;
            amer[31] = new Episode(2, 9, "The Best Christmas Story Never", "http://geektv.me/watch/55401") ;
            amer[32] = new Episode(2, 10, "Bush Comes To Dinner", "http://geektv.me/watch/55400") ;
            amer[33] = new Episode(2, 11, "American Dream Factory", "http://geektv.me/watch/55399") ;
            amer[34] = new Episode(2, 12, "A.T. The Abusive Terrestrial", "http://geektv.me/watch/55398") ;
            amer[35] = new Episode(2, 13, "Black Mystery Month", "http://geektv.me/watch/55397") ;
            amer[36] = new Episode(2, 14, "An Apocalypse to Remember", "http://geektv.me/watch/55396") ;
            amer[37] = new Episode(2, 15, "Four Little Words", "http://geektv.me/watch/55395") ;
            amer[38] = new Episode(2, 16, "When a Stan Loves a Woman", "http://geektv.me/watch/55394") ;
            amer[39] = new Episode(2, 17, "I Can't Stan You", "http://geektv.me/watch/55393") ;
            amer[40] = new Episode(2, 18, "The Magnificant Steven", "http://geektv.me/watch/55392") ;
            amer[41] = new Episode(2, 19, "Joint Custody", "http://geektv.me/watch/55391") ;

            //Staffel 3
            amer[42] = new Episode(3, 1, "The Vacation Goo", "http://geektv.me/watch/55390") ;
            amer[43] = new Episode(3, 2, "Meter Made", "http://geektv.me/watch/55389") ;
            amer[44] = new Episode(3, 3, "Dope And Faith", "http://geektv.me/watch/55388") ;
            amer[45] = new Episode(3, 4, "Big Trouble in Little Langley", "http://geektv.me/watch/55387") ;
            amer[46] = new Episode(3, 5, "Haylias", "http://geektv.me/watch/1561") ;
            amer[47] = new Episode(3, 6, "The 42-Year-Old Virgin", "http://geektv.me/watch/55386") ;
            amer[48] = new Episode(3, 7, "Surro-Gate", "http://geektv.me/watch/55385") ;
            amer[49] = new Episode(3, 8, "The Most Adequate Christmas Ever", "http://geektv.me/watch/55384") ;
            amer[50] = new Episode(3, 9, "Frannie 911", "http://geektv.me/watch/55383") ;
            amer[51] = new Episode(3, 10, "Tearjerker", "http://geektv.me/watch/55382") ;
            amer[52] = new Episode(3, 11, "Oedipal Panties", "http://geektv.me/watch/55381") ;
            amer[53] = new Episode(3, 12, "Widowmaker", "http://geektv.me/watch/55380") ;
            amer[54] = new Episode(3, 13, "Red October Sky", "http://geektv.me/watch/55379") ;
            amer[55] = new Episode(3, 14, "Office Spaceman", "http://geektv.me/watch/55378") ;
            amer[56] = new Episode(3, 15, "Stanny Slickers II: The Legend of Ollie's Gold", "http://geektv.me/watch/55377") ;
            amer[57] = new Episode(3, 16, "Spring Break Up", "http://geektv.me/watch/55376") ;

            //Staffel 4
            amer[58] = new Episode(4, 1, "1600 Candles", "http://geektv.me/watch/55375") ;
            amer[59] = new Episode(4, 2, "The One That Got Away", "http://geektv.me/watch/55374") ;
            amer[60] = new Episode(4, 3, "One Little Word", "http://geektv.me/watch/55373") ;
            amer[61] = new Episode(4, 4, "Choosy Wives Choose Smith", "http://geektv.me/watch/55372") ;
            amer[62] = new Episode(4, 5, "Escape from Pearl Bailey", "http://geektv.me/watch/55371") ;
            amer[63] = new Episode(4, 6, "Pulling Double Booty", "http://geektv.me/watch/55370") ;
            amer[64] = new Episode(4, 7, "Phantom of the Telethon", "http://geektv.me/watch/55369") ;
            amer[65] = new Episode(4, 8, "Chimdale", "http://geektv.me/watch/1580") ;
            amer[66] = new Episode(4, 9, "Stan Time", "http://geektv.me/watch/55368") ;
            amer[67] = new Episode(4, 10, "Family Affairy", "http://geektv.me/watch/55367") ;
            amer[68] = new Episode(4, 11, "Live and Let Fry", "http://geektv.me/watch/55366") ;
            amer[69] = new Episode(4, 12, "Roy Roger McFreely", "http://geektv.me/watch/55365") ;
            amer[70] = new Episode(4, 13, "Jack's Black", "http://geektv.me/watch/55364") ;
            amer[71] = new Episode(4, 14, "Bar Mitzvah Hustle", "http://geektv.me/watch/55363") ;
            amer[72] = new Episode(4, 15, "Wife Insurance", "http://geektv.me/watch/55362") ;
            amer[73] = new Episode(4, 16, "Delorean Story-An", "http://geektv.me/watch/55361") ;
            amer[74] = new Episode(4, 17,  "Every Which Way But Lose", "http://geektv.me/watch/55360") ;
            amer[75] = new Episode(4, 18, "Weiner of Our Discontent", "http://geektv.me/watch/55359") ;
            amer[76] = new Episode(4, 19, "Daddy Queerest", "http://geektv.me/watch/55358") ;
            amer[77] = new Episode(4, 20, "Stan's Night Out", "http://geektv.me/watch/55357") ;

            //Staffel 5
            amer[78] = new Episode(5, 1, "In Country... Club", "http://geektv.me/watch/55356") ;
            amer[79] = new Episode(5, 2, "Moon Over Isla Island", "http://geektv.me/watch/55355") ;
            amer[80] = new Episode(5, 3, "Home Adrone", "http://geektv.me/watch/55354") ;
            amer[81] = new Episode(5, 4, "Brains, Brains and Automobiles", "http://geektv.me/watch/55353") ;
            amer[82] = new Episode(5, 5, "Man in the Moonbounce", "http://geektv.me/watch/55352") ;
            amer[83] = new Episode(5, 6, "Shallow Vows", "http://geektv.me/watch/55351") ;
            amer[84] = new Episode(5, 7, "My Morning Straitjacket", "http://geektv.me/watch/55350") ;
            amer[85] = new Episode(5, 8, "G-String Circus", "http://geektv.me/watch/55349") ;
            amer[86] = new Episode(5, 9, "Rapture's Delight", "http://geektv.me/watch/55348") ;
            amer[87] = new Episode(5, 10, "Don't Look a Smith Horse in the Mouth", "http://geektv.me/watch/55347") ;
            amer[88] = new Episode(5, 11, "A Jones For a Smith", "http://geektv.me/watch/55346") ;
            amer[89] = new Episode(5, 12, "May the Best Stan Win", "http://geektv.me/watch/55345") ;
            amer[90] = new Episode(5, 13, "Return of the Bling", "http://geektv.me/watch/55344") ;
            amer[91] = new Episode(5, 14, "Cops & Roger", "http://geektv.me/watch/55343") ;
            amer[92] = new Episode(5, 15, "Merlot Down Dirty Shame", "http://geektv.me/watch/55342") ;
            amer[93] = new Episode(5, 16, "Bully for Steve", "http://geektv.me/watch/55341") ;
            amer[94] = new Episode(5, 17, "An Incident at Owl Creek", "http://geektv.me/watch/55340") ;
            amer[95] = new Episode(5, 18, "Great Space Roaster", "http://geektv.me/watch/55339") ;

            //Staffel 6
            amer[96] = new Episode(6, 1, "100 A.D", "http://geektv.me/watch/55338") ;
            amer[97] = new Episode(6, 2, "Son of Stan", "http://geektv.me/watch/55337") ;
            amer[98] = new Episode(6, 3, "Best Little Horror House in Langley Falls", "http://geektv.me/watch/55336") ;
            amer[99] = new Episode(6, 4, "Stan's Food Restaurant", "http://geektv.me/watch/55335") ;
            amer[100] = new Episode(6, 5, "White Rice", "http://geektv.me/watch/55334") ;
            amer[101] = new Episode(6, 6, "There Will Be Bad Blood", "http://geektv.me/watch/55333") ;
            amer[102] = new Episode(6, 7, "The People vs. Martin Sugar", "http://geektv.me/watch/55332") ;
            amer[103] = new Episode(6, 8, "For Whom the Sleight Bell Tolls", "http://geektv.me/watch/55331") ;
            amer[104] = new Episode(6, 9, "Fart-Break Hotel", "http://geektv.me/watch/55330") ;
            amer[105] = new Episode(6, 10, "Stanny Boy and Frantastic", "http://geektv.me/watch/1620") ;
            amer[106] = new Episode(6, 11, "A Pinata Named Desire", "http://geektv.me/watch/55329") ;
            amer[107] = new Episode(6, 12, "You Debt Your Life", "http://geektv.me/watch/55328") ;
            amer[108] = new Episode(6, 13, "I Am the Walrus", "http://geektv.me/watch/55327") ;
            amer[109] = new Episode(6, 14, "School Lies", "http://geektv.me/watch/1624") ;
            amer[110] = new Episode(6, 15, "License To Till", "http://geektv.me/watch/55326") ;
            amer[111] = new Episode(6, 16, "Jenny Fromdabloc", "http://geektv.me/watch/55325") ;
            amer[112] = new Episode(6, 17, "Home Wrecker", "http://geektv.me/watch/55324") ;
            amer[113] = new Episode(6, 18, "Flirting With Disaster", "http://geektv.me/watch/55323") ;
            amer[114] = new Episode(6, 19, "Gorillas in the Mist", "http://geektv.me/watch/55322") ;

            //Staffel 7
            amer[115] = new Episode(7, 1, "Hot Water", "http://geektv.me/watch/55321") ;
            amer[116] = new Episode(7, 2, "Hurricane!", "http://geektv.me/watch/55320") ;
            amer[117] = new Episode(7, 3, "A Ward Show", "http://geektv.me/watch/55319") ;
            amer[118] = new Episode(7, 4, "The Worst Stand", "http://geektv.me/watch/55318") ;
            amer[119] = new Episode(7, 5, "Virtual In-Sanity", "http://geektv.me/watch/55317") ;
            amer[120] = new Episode(7, 6, "The Scarlet Getter", "http://geektv.me/watch/55316") ;
            amer[121] = new Episode(7, 7, "Season's Beatings", "http://geektv.me/watch/55315") ;
            amer[122] = new Episode(7, 8, "The Unbrave One", "http://geektv.me/watch/55314") ;
            amer[123] = new Episode(7, 9, "Stanny Tendergrass", "http://geektv.me/watch/55313") ;
            amer[124] = new Episode(7, 10, "Wheels & the Legman an the Case of Granpa's Key", "http://geektv.me/watch/55312") ;
            amer[125] = new Episode(7, 11, "Old Stan in the Mountain", "http://geektv.me/watch/55311") ;
            amer[126] = new Episode(7, 12, "The Wrestler", "http://geektv.me/watch/55310") ;
            amer[127] = new Episode(7, 13, "Dr. Klaustus", "http://geektv.me/watch/55309") ;
            amer[128] = new Episode(7, 14, "Stan's Best Friend", "http://geektv.me/watch/55308") ;
            amer[129] = new Episode(7, 15, "Less Money, Mo' Problems", "http://geektv.me/watch/55307") ;
            amer[130] = new Episode(7, 16, "The Kidney Stays in the Picture", "http://geektv.me/watch/55306") ;
            amer[131] = new Episode(7, 17, "Ricky Spanish", "http://geektv.me/watch/55305") ;
            amer[132] = new Episode(7, 18, "Toy Whorey", "http://geektv.me/watch/55304") ;

            //Staffel 8
            amer[133] = new Episode(8, 1, "Love, AD Style", "http://geektv.me/watch/55201") ;
            amer[134] = new Episode(8, 2, "Killer Vacation", "http://geektv.me/watch/55200") ;
            amer[135] = new Episode(8, 3, "Can I Be Frank With You?", "http://geektv.me/watch/55437") ;
            amer[136] = new Episode(8, 4, "American Stepdad", "http://geektv.me/watch/55197") ;
            amer[137] = new Episode(8, 5, "Why Can't We Be Friends", "http://geektv.me/watch/55198") ;
            amer[138] = new Episode(8, 6, "Adventures in Hayleysitting", "http://geektv.me/watch/55199") ;
            amer[139] = new Episode(8, 7, "National Treasure 4: Baby Franny: She's Doing Well - The Hole Story", "http://geektv.me/watch/55436") ;
            amer[140] = new Episode(8, 8, "Finger Lenting Good", "http://geektv.me/watch/55196") ;
            amer[141] = new Episode(8, 9, "The Adventures of Twill Ongebone and His Boy Jabari", "http://geektv.me/watch/55435") ;
            amer[142] = new Episode(8, 10, "Blood Crieth Unto Heaven", "http://geektv.me/watch/55195") ;
            amer[143] = new Episode(8, 11, "Max Jets", "http://geektv.me/watch/55194") ;
            amer[144] = new Episode(8, 12, "Naked to the Limit, One More Time", "http://geektv.me/watch/55193") ;
            amer[145] = new Episode(8, 13, "For Black Eyes Only", "http://geektv.me/watch/62504") ;
            amer[146] = new Episode(8, 14, "Spelling Bee My Baby", "http://geektv.me/watch/62716") ;
            amer[147] = new Episode(8, 15, "The Missing Kink", "http://geektv.me/watch/62088") ;
            amer[148] = new Episode(8, 16, "The Boring Identity", "http://geektv.me/watch/55192") ;
            amer[149] = new Episode(8, 17, "The Full Cognitive Radaction of Avery Bullock by the Coward Stan Smith", "http://geektv.me/watch/60923") ;
            amer[150] = new Episode(8, 18, "Lost in Space", "http://geektv.me/watch/61194") ;
            amer[151] = new Episode(8, 19, "Da Flippity Flop", "http://geektv.me/watch/60858") ;

            //Staffel 9
            amer[152] = new Episode(9, 1, "Steve and Snot's Test-Tubular Adventure", "http://geektv.me/watch/52934") ;
            amer[153] = new Episode(9, 2, "Poltergasm", "http://geektv.me/watch/52933") ;
            amer[154] = new Episode(9, 3, "Buck, Wild", "http://geektv.me/watch/52297") ;
            amer[155] = new Episode(9, 4, "Crotchwalkers", "http://geektv.me/watch/52296") ;
            amer[156] = new Episode(9, 5, "Kung Pao Turkey", "http://geektv.me/watch/51816") ;
            amer[157] = new Episode(9, 6, "Independent Movie", "http://geektv.me/watch/1642") ;
            amer[158] = new Episode(9, 7, "Faking Bad", "http://geektv.me/watch/51594") ;
            amer[159] = new Episode(9, 8, "Ministrel Krampus", "http://geektv.me/watch/51460") ;
            amer[160] = new Episode(9, 9, "Vision: Impossible", "http://geektv.me/watch/51357") ;
            amer[161] = new Episode(9, 10, "Familyland", "http://geektv.me/watch/51219") ;
            amer[162] = new Episode(9, 11, "Cock of the Sleepwalk", "http://geektv.me/watch/50484") ;
            amer[163] = new Episode(9, 12, "Introducing the Naughty Stewardess", "http://geektv.me/watch/49408") ;
            amer[164] = new Episode(9, 13, "I Ain't No Holodeck Boy", "http://geektv.me/watch/49292") ;
            amer[165] = new Episode(9, 14, "Stan Goes on the Pill", "http://geektv.me/watch/49203") ;
            amer[166] = new Episode(9, 15, "Honey, I'M Homeland", "http://geektv.me/watch/49079") ;
            amer[167] = new Episode(9, 16, "She Swill Survive", "http://geektv.me/watch/48960") ;
            amer[168] = new Episode(9, 17, "Rubberneckers", "http://geektv.me/watch/48714") ;
            amer[169] = new Episode(9, 18, "Permanent Record Wrecker", "http://geektv.me/watch/64534") ;
            amer[170] = new Episode(9, 19, "New Glances with Genevieve Vavance", "http://geektv.me/watch/85467") ;
            amer[171] = new Episode(9, 20, "The Longset Distance Relationship", "http://geektv.me/watch/88643") ;

            //Staffel 10
            amer[172] = new Episode(10, 1, "Roger Passes the Bar", "http://geektv.me/watch/394403") ;
            amer[173] = new Episode(10, 2, "A Boy Named Michael", "http://geektv.me/watch/394396") ;
            amer[174] = new Episode(10, 3, "Blagsnarst, a Love Story", "http://geektv.me/watch/395789") ;

            //Staffel 11
            amer[175] = new Episode(11, 1, "Blonde Ambition", "http://geektv.me/watch/406810") ;
            amer[176] = new Episode(11, 2, "CIAPOW", "http://geektv.me/watch/409238") ;
            amer[177] = new Episode(11, 3, "Scents and Sensei-Billy", "http://geektv.me/watch/410654") ;
            amer[178] = new Episode(11, 4, "Big Stan on Campus", "http://geektv.me/watch/412582") ;
            amer[179] = new Episode(11, 5, "Now and Gwen", "http://geektv.me/watch/415158") ;
            amer[180] = new Episode(11, 6, "Dreaming of a White Porsche Christmas", "http://geektv.me/watch/417294") ;
            amer[181] = new Episode(11, 7, "LGBSteve", "http://geektv.me/watch/457726") ;
            amer[182] = new Episode(11, 8, "Morning Mimosa", "http://geektv.me/watch/456942") ;
            amer[183] = new Episode(11, 9, "My Affair Lady", "http://geektv.me/watch/454273") ;
            amer[184] = new Episode(11, 10, "A Star Is Reborn", "http://geektv.me/watch/454114") ;
            amer[185] = new Episode(11, 11, "Manhatten Magical Muder Mystery Tour", "http://geektv.me/watch/456569") ;
            amer[186] = new Episode(11, 12, "The Shrink", "http://geektv.me/watch/457420") ;
            amer[187] = new Episode(11, 13, "Holy Shit, Jeff's Back!", "http://geektv.me/watch/509377") ;
            amer[188] = new Episode(11, 14, "American Fung", "http://geektv.me/watch/509379") ;
            amer[189] = new Episode(11, 15, "Seizures Suit Stanny", "http://geektv.me/watch/509302") ;

            //Staffel 12
            amer[190] = new Episode(12, 1, "Roots", "http://geektv.me/watch/602439") ;
            amer[191] = new Episode(12, 2, "The Life Aquatic with Steve Smith", "http://geektv.me/watch/605020") ;
            amer[192] = new Episode(12, 3, "Hayley Smith, Seal Team Six", "http://geektv.me/watch/607339");
            amer[193] = new Episode(12, 4, "N.S.A (No Snoops Allowed)", "http://geektv.me/watch/610081") ;
            amer[194] = new Episode(12, 5, "Stan Smith as Keanu Reeves as Stanny Utah in Point Breakers", "http://geektv.me/watch/613091") ;            
            #endregion

            #region Futurama
            
            #endregion
        }

        private int getIndex()
        {
            int k ;

            switch(SerieComboBox.SelectedIndex)
            {
                #region SouthPark
                case 0:   //South Park
                    switch(SeasoncomboBox.SelectedIndex)
                    {
                        case 0:
                        k = 0;
                        break;
                    case 1:
                        k = 13;
                        break;
                    case 2:
                        k = 31;
                        break;
                    case 3:
                        k = 48;
                        break;
                    case 4:
                        k = 65;
                        break;
                    case 5:
                        k = 79;
                        break;
                    case 6:
                        k = 96;
                        break;
                    case 7:
                        k = 111;
                        break;
                    case 8:
                        k = 125;
                        break;
                    case 9:
                        k = 139;
                        break;
                    case 10:
                        k = 153;
                        break;
                    case 11:
                        k = 167;
                        break;
                    case 12:
                        k = 181;
                        break;
                    case 13:
                        k = 195;
                        break;
                    case 14:
                        k = 209;
                        break;
                    case 15:
                        k = 223;
                        break;
                    case 16:
                        k = 237;
                        break;
                    case 17:
                        k = 247;
                        break;
                    case 18:
                        k = 257;
                        break;
                    default:
                        k = 0;
                        break;
                    }
                    break ;
                #endregion

                #region Family Guy
                case 1:
                    switch(SeasoncomboBox.SelectedIndex)
                    {
                        case 0:
                            k = 0;
                            break;
                        case 1:
                            k = 7;
                            break;
                        case 2:
                            k = 28;
                            break;
                        case 3:
                            k = 50;
                            break;
                        case 4:
                            k = 80;
                            break;
                        case 5:
                            k = 98;
                            break;
                        case 6:
                            k = 110;
                            break;
                        case 7:
                            k = 126;
                            break;
                        case 8:
                            k = 147;
                            break;
                        case 9:
                            k = 165;
                            break;
                        case 10:
                            k = 188;
                            break;
                        case 11:
                            k = 210;
                            break;
                        case 12:
                            k = 231;
                            break;
                        case 13:
                            k = 249;
                            break;
                        default:
                            k = 0;
                            break;
                    }
                    break ;
                #endregion

                #region American Dad
                case 2:
                    switch(SeasoncomboBox.SelectedIndex)
                    {
                        case 0:
                            k = 0;
                        break ;
                        case 1:
                            k = 23 ;
                        break ;
                        case 2:
                            k = 42 ;
                        break ;
                        case 3:
                            k = 58 ;
                        break ;
                        case 4:
                            k = 78 ;
                        break ;
                        case 5:
                            k = 96 ;
                        break ;
                        case 6:
                            k = 115 ;
                        break ;
                        case 7:
                            k = 133 ;
                        break ;
                        case 8:
                            k = 152 ;
                        break ;
                        case 9:
                            k = 172 ;
                        break ;
                        case 10:
                            k = 175 ;
                        break ;
                        case 11:
                            k = 190 ;
                        break ;
                        default:
                            k = 0;
                        break ;
                    }
                    break ;
                #endregion

                #region Futurama
                case 3:
                    switch(SeasoncomboBox.SelectedIndex)
                    {
                        case 0:
                            k = 0;
                            break ;
                        case 1:
                            k = 13 ;
                            break ;
                        case 2:
                            k = 33 ;
                            break ;
                        case 3:
                            k = 48 ;
                            break ;
                        case 4:
                            k = 60 ;
                            break ;
                        case 5:
                            k = 76 ;
                            break ;
                        case 6:
                            k = 102 ;
                            break ;
                        default:
                            k = 0;
                            break ;
                    }
                    break ;
                #endregion

                default:
                    k = 0;
                    break ;

            }
            return k ;
        }


        // Richtige Anzahl an Folgen für ausgewählte Season
        private void SeasonChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = 0, j, k;
            k = FolgecomboBox.SelectedIndex;
            
            switch(SerieComboBox.SelectedIndex)
            {
                #region SouthPark
                case 0:         
                switch (SeasoncomboBox.SelectedIndex)
                { 
                    case 0:
                        i = 13;
                        break;

                    case 1:
                        i = 18;
                        break;

                    case 2:
                        i = 17;
                        break;

                    case 3:
                        i = 17;
                        break;

                    case 4:
                        i = 14;
                        break;

                    case 5:
                        i = 17;
                        break;

                    case 6:
                        i = 15;
                        break;

                    case 7:
                        i = 14;
                        break;

                    case 8:
                        i = 14;
                        break;

                    case 9:
                        i = 14;
                        break;

                    case 10:
                        i = 14;
                        break;

                    case 11:
                        i = 14;
                        break;

                    case 12:
                        i = 14;
                        break;

                    case 13:
                        i = 14;
                        break;

                    case 14:
                        i = 14;
                        break;

                    case 15:
                        i = 14;
                        break;

                    case 16:
                        i = 10;
                        break;

                    case 17:
                        i = 10;
                        break;

                    case 18:
                        i = 10;
                        break;

                    default:
                        i = 0;
                        break;
                }
                break;
                #endregion

                #region FamilyGuy
                case 1:           //Family Guy
                    switch(SeasoncomboBox.SelectedIndex)
                    {
                        case 0:
                            i = 7;
                            break;
                        case 1:
                            i = 21;
                            break;
                        case 2:
                            i = 22;
                            break;
                        case 3:
                            i = 30;
                            break;
                        case 4:
                            i = 18;
                            break;
                        case 5:
                            i = 12;
                            break;
                        case 6:
                            i = 16;
                            break;
                        case 7:
                            i = 21;
                            break;
                        case 8:
                            i = 18;
                            break;
                        case 9:
                            i = 23;
                            break;
                        case 10:
                            i = 22;
                            break;
                        case 11:
                            i = 21;
                            break;
                        case 12:
                            i = 18;
                            break;
                        case 13:
                            i = 14;
                            break;

                        default:
                            i = 0;
                            break;
                            
                    }
                    break;
                    #endregion

                    #region American Dad
                    case 2:
                        switch(SeasoncomboBox.SelectedIndex)
                        {
                            case 0:
                                i = 23 ;
                                break ;
                            case 1:
                                i = 19 ;
                                break ;
                            case 2:
                                i = 16 ;
                                break ;
                            case 3:
                                i = 20 ;
                                break ;
                            case 4:
                                i = 18 ;
                                break ;
                            case 5:
                                i = 19 ;
                                break ;
                            case 6:
                                i = 18 ;
                                break ;
                            case 7:
                                i = 19 ;
                                break ;
                            case 8:
                                i = 20 ;
                                break ;
                            case 9:
                                i = 3 ;
                                break ;
                            case 10:
                                i = 15 ;
                                break ;
                            case 11:
                                i = 5 ;
                                break ;
                            default:
                                i = 0;
                                break ;
                        }
                        break ;
                    #endregion

                    #region Futurama
                    case 3:
                        switch(SeasoncomboBox.SelectedIndex)
                        {
                            case 0:
                                i = 13 ;
                                break ;
                            case 1:
                                i = 20 ;
                                break ;
                            case 2:
                                i = 15 ;
                                break ;
                            case 3:
                                i = 12 ;
                                break ;
                            case 4:
                                i = 16 ;
                                break ;
                            case 5:
                                i = 26 ;
                                break ;
                            case 6:
                                i = 26 ;
                                break ;
                            default:
                                i = 0;
                                break ;
                        }
                        break ;
                    #endregion

                    default:
                        break ;
            }       

            FolgecomboBox.Items.Clear();

            for (j = 1; j < i + 1; j++)
            {               
                FolgecomboBox.Items.Add(j);
            }

            if(FolgecomboBox.Items.Count < k)
            {
                FolgecomboBox.SelectedIndex = -1;
                textBox.Text = "";
                fImage.Source = null;
            }
            else
            {
                FolgecomboBox.SelectedIndex = k;
            }
        }

        // Titel der Folge eintragen
        private void FolgeChanged(object sender, SelectionChangedEventArgs e)
        {
            int k = getIndex() ;
            k += FolgecomboBox.SelectedIndex ;
            try
            {
                switch (SerieComboBox.SelectedIndex)
                {
                    #region SouthPark
                    case 0:  //South Park
                        textBox.Text = ep[k].name ;
                        fImage.Source = ep[k].image ;
                        break;
                    #endregion

                    #region FamilyGuy
                    case 1:   //Family Guy
                        textBox.Text = fam[k].name ;
                        fImage.Source = null ;
                        break;
                    #endregion

                    #region American Dad
                    case 2:
                        textBox.Text = amer[k].name ;
                        fImage.Source = null ;
                        break ;
                    #endregion

                    #region Futurama
                    case 3:
                        textBox.Text = futu[k].name ;
                        fImage.Source = null ;
                        break ;
                    #endregion
                    default:
                        k = 0;
                        break;
                }     
            }
            catch(Exception)
            {
                textBox.Text = "" ;
                fImage.SOurce = null ;
                FolgecomboBox.SelectedIndex = -1 ;
            }   
        }

        private void OpenClick(object sender, RoutedEventArgs e)
        {
            int k = getIndex();
            k += FolgecomboBox.SelectedIndex ;

            try
            {
                switch (SerieComboBox.SelectedIndex)
                {
                    case 0:  //South Park
                        ep[k].Open();
                        break;

                    case 1:  //Family Guy
                        fam[k].Open();
                        break;

                    case 2:  //American Dad
                        amer[k].Open();
                        break;

                    case 3:    //Futurama
                        futu[k].Open() ;
                        break ;

                    default:
                        break;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Link nicht verfügbar");
            }  
        }

        private void RandomClick(object sender, RoutedEventArgs e)
        {
            int s = 0, f = 0;

            switch (SerieComboBox.SelectedIndex)
            {
                case 0:
                    s = rand.Next(0, 19);
                    SeasoncomboBox.SelectedIndex = s;
                    f = rand.Next(0, FolgecomboBox.Items.Count);
                    break;

                case 1:
                    s = rand.Next(0, 14);
                    SeasoncomboBox.SelectedIndex = s;
                    f = rand.Next(0, FolgecomboBox.Items.Count);
                    break;

                case 2:
                    s = rand.Next(0, 12);
                    SeasoncomboBox.SelectedIndex = s;
                    f = rand.Next(0, FolgecomboBox.Items.Count);
                    break;

                case 3:
                    s = rand.Next(0, 7) ;
                    SeasoncomboBox.SelectedIndex = s ;
                    f = rand.Next(0, FolgecomboBox.Items.Count) ;
                    break ;

                default:
                    s = -1;
                    SeasoncomboBox.SelectedIndex = s;
                    f = -1;
                    break;
            }

            FolgecomboBox.SelectedIndex = f;
        }

        private void SerieChanged(object sender, SelectionChangedEventArgs e)
        {
            int i;
            switch(SerieComboBox.SelectedIndex)
            {
                case 0:
                    i = 19;
                    break;
                case 1:
                    i = 14;
                    break;
                case 2:
                    i = 12 ;
                break ;
                case 3:
                    i = 7 ;
                    break ;
                default:
                    i = 0;
                    break;
            }

            SeasoncomboBox.Items.Clear();

            for(int j = 1; j < i+1; j++)
            {
                SeasoncomboBox.Items.Add(j);
            }

            SeasoncomboBox.SelectedIndex = -1;
        }

        private void ComplRandClick(object sender, RoutedEventArgs e)
        {
            int s, f, se ;
            se = rand.Next(0, 4) ;
            SerieComboBox.SelectedIndex = se;

            switch(se)
            {
                case 0:
                    s = rand.Next(0, 19) ;
                    SeasoncomboBox.SelectedIndex = s;
                    f = rand.Next(0, FolgecomboBox.Items.Count) ;
                    break ;

                case 1:
                    s = rand.Next(0, 14) ;
                    SeasoncomboBox.SelectedIndex = s;
                    f = rand.Next(0, FolgecomboBox.Items.Count) ;
                    break ;

                case 2:
                    s = rand.Next(0, 12) ;
                    SeasoncomboBox.SelectedIndex = s;
                    f = rand.Next(0, FolgecomboBox.Items.Count) ;
                    break ;

                case 3:
                    s = rand.Next(0, 7) ;
                    SeasoncomboBox.SelectedIndex = s ;
                    f = rand.Next(0, FolgecomboBox.Items.Count) ;
                    break ;

                default:
                    s = -1;
                    SeasoncomboBox.SelectedIndex = s;
                    f = -1 ;
                    break ;
            }

            FolgecomboBox.SelectedIndex = f ;
        }
    }
}
