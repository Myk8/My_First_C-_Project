-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jul 06, 2024 at 11:48 AM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `music`
--

-- --------------------------------------------------------

--
-- Table structure for table `albums`
--

CREATE TABLE `albums` (
  `ID` int(11) NOT NULL,
  `ALBUM_TITLE` varchar(100) NOT NULL,
  `ARTIST` varchar(100) NOT NULL,
  `YEAR` int(11) NOT NULL,
  `IMAGE_NAME` varchar(1000) NOT NULL,
  `DESCRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `albums`
--

INSERT INTO `albums` (`ID`, `ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES
(1, 'Pink Friday 2', 'Nicki Minaj', 1999, 'https://upload.wikimedia.org/wikipedia/en/3/39/Nicki_Minaj_-_Pink_Friday_2.png', 'Pink Friday 2 was supported by two singles, \"Super Freaky Girl\" and \"Last Time I Saw You\", the former of which marked Minaj\'s first solo number-one on the US Billboard Hot 100. Two promotional singles, \"Red Ruby da Sleeze\" and \"Bahm Bahm\", were released prior to the album. To promote the album, Minaj will embark on the Pink Friday 2 World Tour in March 2024.'),
(2, 'Pokémon 2.B.A. Master', 'John Loeffler', 1999, 'https://upload.wikimedia.org/wikipedia/en/2/29/Pok%C3%A9mon_2BA_Master.jpg', 'Pokémon 2.B.A. Master is a 1999 album, the first soundtrack album released for the English localization of the Pokémon anime.');

-- --------------------------------------------------------

--
-- Table structure for table `tracks`
--

CREATE TABLE `tracks` (
  `ID` int(11) NOT NULL,
  `track_title` varchar(100) DEFAULT NULL,
  `number` int(11) DEFAULT NULL,
  `video_url` varchar(200) DEFAULT NULL,
  `lyrics` text,
  `albums_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tracks`
--

INSERT INTO `tracks` (`ID`, `track_title`, `number`, `video_url`, `lyrics`, `albums_ID`) VALUES
(1, 'Just the Memories', 1, 'https://www.youtube.com/watch?v=z8fUmT5NyOM', 'So sweet\r\nMmm\r\nI ain\'t goin\', I ain\'t, yeah, I got a show tonight\r\nBut I ain\'t been feelin\' right, all I see is blurry lines\r\nBaby, would you tell \'em for me, I can hear them yellin\' for me\r\nTell \'em I\'m inhalin\' funny (yeah, I\'m inhalin\' funny)\r\nBaby, now you gotta do it, keep drinkin\' a lot of fluid\r\nI\'ll be here to guide you through it (I\'ll be here to guide you through it)\r\nAnd maybe I ain\'t got it in me, maybe it\'s just time to end it\r\nI\'m sorry, may God forgive me (God, forgive me)\r\nSo, so, so sad\r\nSo, so, so sad\r\nA bunch of memories (memories)\r\nA bunch of memories, baby (baby)\r\nA bunch of memories (memories)\r\nIt\'s just the memories\r\nMemories don\'t live like people do\r\nThey\'ll always \'member you\r\nThere\'s never been another you\r\nYou\r\nI \'member when I was the girl that everybody doubted\r\nWhen every label turned me down and then they laughed about it\r\nI \'member goin\' home and writin\' fifty more raps\r\nJust \'cause I knew you really wanted me to fall back\r\nI \'member one of my first crushes in the fifth grade\r\nHe got killed, stabbed in the neck with a switchblade\r\nI \'member when this girl in the hood thought she caught me slippin\'\r\nI got arrested, I assaulted with a deadly weapon\r\nThey say they hate Nicki, mad \'cause they ain\'t Nicki\r\nAll of the colors in the world, you couldn\'t paint Nicki\r\nI never tried for that, these bitches die for that\r\nI swear that, that\'s on my life, I\'d never lie for that\r\nMemories don\'t live like people do\r\nThey\'ll always \'member you\r\nThey do, they do, ooh, ooh, ooh, ooh\r\nMemories don\'t live like people do\r\nThey\'ll always \'member you\r\nThere\'s never been another you\r\nYou (memories)\r\nI told Drake that he don\'t owe me nothin\', never did\r\nI pray that Wayne always remembered that I never slid\r\nLook at all the shit that y\'all threw at me and I never dipped\r\nGreatest female rapper that ever lived and that\'s on my kid (memories)\r\nI could\'ve overdosed, could\'ve been comatose\r\nWait, hold on, Juice, I feel the baby kickin\', holy smokes\r\nI prayed for a son, my husband wanted one\r\nIf they ask about me, tell \'em I was one of one\r\nMemories don\'t live like people do (they don\'t live like people do)\r\nThey\'ll always \'member you (they\'ll always remember you)\r\nThere\'s never been another you (there\'s never been another you)\r\nTell \'em I was one of one (you)\r\nMemories don\'t live like people do\r\n(So, so, so sad)\r\nNo, no, no, no, no, no, no, no\r\n(So, so, so sad)\r\nYeah, yeah, yeah, yeah, yeah, yeah\r\n(So, so, so sad)\r\nYeah, yeah, yeah, yeah, yeah, yeah\r\nOoh\r\nHey\r\nSo\r\nYeah, yeah, yeah\r\nMemories', 1),
(2, 'Red Ruby da Sleeze', 2, 'https://www.youtube.com/watch?v=QBGX9QirWaU', 'Only on them C\'s if it\'s breeze, Red Ruby Da Sleeze\r\nChinese on my sleeve, these wannabe Chun-Lis\r\nAnyway, nǐ hǎo (nǐ hǎo)\r\nWho the fuck told bitches they was me now? (Ooh)\r\nI knew these bitches was slow, I ain\'t know these bitches senile (ooh)\r\nMarried a shooter case you niggas tried to breathe loud (brrt)\r\nBoom your face off, then I tell him, \"Cease fire\"\r\nI\'m the A-B side\r\nSeven-hundred on \'em horses when we fixin\' to leave\r\nBut I don\'t fuck with horses since Christopher Reeves\r\n(Uh-oh, uh-oh)\r\nGotta be careful when I dip, it\'s flips all in the whip\r\nIt\'s .40s with .30 clips, FN\'s with the switch\r\nGuacamole with the taco, waitin\' on El Chapo\r\nCame in the Rolls and left low in a Tahoe\r\nBad gyal don\'t die-die-die (brrt) (die-die)\r\nHunnid rounds on that grrah-ta-ta (grrah-ta-ta-ta)\r\nReal one lick a shot-ta-ta (baow)\r\nShe my lil\' vibe, my lil\' ah-ah-ah (my lil\' ahh)\r\nBad gyal don\'t run from nobody like, ah (ooh)\r\nRude boy want me touchin\' on his body like, yeah (ooh)\r\nBoy haffi dead if he ever diss me\r\nYou know what to do if he ever miss me\r\nMiss me with that na-na-na-na-na-na-na\r\nI stay with my na-na-na-na-na-na-na\r\nHis ex hit him, he like, \"Nah-nah-nah-nah-nah-nah-nah\"\r\nHe want the bad gyal sleeze like that, well, I\'m a tease like that\r\nIll na-na-na-na-na-na-na\r\nHe told me bring him that na-na-na-na-na-na-na\r\nWe don\'t be Karen like Donna-na-na-na-na-na\r\nI like it when he grab my cheeks like that (uh)\r\nWell, I\'m a freak like that\r\nBad gyal don\'t die-die-die\r\nHunnid rounds on that, grrah-ta-ta (grrah)\r\nReal one lick a shot-ta-ta (blaow)\r\nShe my lil\' vibe, my lil\' ah-ah-ah (my lil\' ahh)\r\nBad gyal don\'t run from nobody like, ah (ooh)\r\nRude boy want me touchin\' on his body like, yeah (ooh)\r\nBoy haffi dead if he ever diss me (me, yeah)\r\nYou know what to do if he ever miss me\r\nWhen the Queen leave, bitches wanna come out like a cockroach\r\nUntil I\'m cookin\' in the kitchen like a pot roast\r\nThat new Spectre, we don\'t fill pot holes\r\nDorito bitches mad that they not chose\r\nShout out my vatos\r\nShout out to hoes that\'s watchin\' me like Movados (click, click, click)\r\nAll them, all them botched face photos, why would you post those?\r\nMake a gyal duppy since I heard you like my ghost, hoes\r\nBig truck but I\'m alone like Post though\r\nCall Malone and tell him I\'m goin\' postal (brrt)\r\nThese bitches rappin\' like my blooper roll\r\nDesert Eagle if your nigga actin\' super bold\r\n(Got \'em, got \'em, got \'em) got \'em like, \"Uh-oh\"\r\nGun fingers like niggas doin\' the bogle\r\nYa fuckin\' bozo\r\nThat .40 cal\'ll make \'em dance like a go-go\r\nSuper facts, that\'s word to Super Cat\r\nWe ah rude gyal yute and we nuh tek back we chat\r\n\'Cause bitches couldn\'t walk in my Crocs, that\'s word to Dundee\r\nJust a bunch of airheads like Kelly Bundy\r\nMan, these bitches so slow, man, they slower than sloths\r\nSix-hundred horse, how you gon\' catch the boss?\r\nCaught \'em with they hand out, tryna catch the sauce\r\nThierry Mugler flow, tryna cut the cloth\r\nSee the difference is I run businesses\r\nIf I ain\'t employ you then what ya business is?\r\nI\'ll have staff roll up, like what the business is?\r\nOh, you don\'t know that my niggas kill witnesses?\r\nBad gyal don\'t die-die-die\r\nHunnid rounds on that, grrah-ta-ta (grrah)\r\nReal one lick a shot-ta-ta (blaow)\r\nShe my lil\' vibe, my lil\' ah-ah-ah (my lil\' ahh)\r\nBad gyal don\'t run from nobody like, ah (ooh)\r\nRude boy want me touchin\' on his body like, yeah (ooh)\r\nBoy haffi dead if he ever diss me (me, yeah)\r\nYou know what to do if he ever miss me\r\nIf you want me to stay\r\nI\'ll never leave\r\nIf you want me to stay\r\nWe\'ll always be\r\nIf you want me to stay\r\nLove endlessly\r\nIf you want me to stay', 1),
(3, 'Pokemon Theme', 1, 'https://www.youtube.com/watch?v=8ZdzY9TGu1c&list=PLAk3AHK4_vrEXbUpUgiRzBY-0a7vsccjc&index=1', 'I wanna be the very best\r\nLike no one ever was\r\nTo catch them is my real test\r\nTo train them is my cause\r\n\r\nI will travel across the land\r\nSearching far and wide\r\nPokemon to understand\r\nThe power that\'s inside\r\n\r\nPokemon! it\'s you and me\r\nI know it\'s my destiny,\r\nPokemon! Oh you\'re my best friend\r\nIn a world we must defend\r\nPokemon! a heart so true\r\nOur courage will pull us through,\r\n\r\nYou teach me and I\'ll teach you,\r\nPokemon! gotta catch\'em all\r\n\r\nEvery challenge along the way\r\nWith courage I will face.\r\nI will battle every day\r\nTo claim my rightful place.\r\nCome with me,\r\nThe time is right,\r\nThere\'s no better team.\r\nArm in arm we\'ll win the fight!\r\nIt\'s always been our dream!\r\n', 2),
(4, 'Toghether Forever', 10, 'https://www.youtube.com/watch?v=iqvBT9fSEHw&list=PLAk3AHK4_vrEXbUpUgiRzBY-0a7vsccjc&index=10', 'Yea-a-a-ah!\r\nYeah, y-yeah\r\n\r\n[Verse 1]\r\nYou\'ve been such a good friend\r\nI\'ve known you since I don\'t know when\r\nWe got lots of friends, but they\r\nCome and go...\r\n\r\n[Pre-Chorus 1]\r\nEven though we\'ve never said it\r\nThere\'s something that the two of us both know\r\n\r\n[Chorus]\r\nTogether forever, no matter how long\r\nFrom now until the end of time\r\nWe\'ll be together, and you can be sure\r\nThat forever and a day\r\nThat\'s how long we\'ll stay\r\nTogether and forever more\r\n\r\n[Verse 2]\r\nAlways gone the extra mile\r\nDepended on you all the while\r\nEven in the good and bad times\r\nYou will see...\r\n\r\nYou might also like\r\nWithout Me\r\nEminem\r\nBorn to Be a Winner\r\nPokémon\r\nI Want It That Way\r\nBackstreet Boys\r\n\r\n[Pre-Chorus 2]\r\nFrom now until our journey\'s end\r\nYou know you can always count on me\r\n\r\n[Chorus]\r\nTogether forever, no matter how long\r\nNow until the end of time\r\nWe\'ll be together, and you can be sure\r\nThat forever and a day\r\nThat\'s how long we\'ll stay\r\nTogether and forever more\r\n\r\n[Bridge]\r\nNo matter where our destiny leads\r\nI\'ll be there for you\r\nAlways come through\r\nAnd that you can believe!\r\n\r\n[Skit]\r\n[Ash Ketchum] Come on you guys, I gotta get another badge!\r\n[Misty] You better figure out how to repay me for my broken bike, Ash Ketchum!\r\n[Brock] Oh no, not this again!\r\n[Pikachu] Pikachu...\r\n\r\n[Chorus]\r\nTogether forever, no matter how long\r\nFrom now until the end of time\r\nWe\'ll be together, and you can be sure\r\nThat forever and a day\r\nThat\'s how long we\'ll stay\r\nTogether and forever more\r\n\r\n\r\n[Outro]\r\n(Together forever, no matter how long)\r\n(From now until the end of time) Now until the end of time\r\n(We\'ll be together, and you can be sure) Together forever\r\n(That forever and a day) Forever\r\n(That\'s how long we\'ll stay) We\'ll stay\r\n(Together forever, no matter how long) Together\r\n(From now until the end of time) Now until the end of time\r\n(We\'ll be together, and you can be sure...)', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `albums`
--
ALTER TABLE `albums`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tracks`
--
ALTER TABLE `tracks`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_tracks_albums_idx` (`albums_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `albums`
--
ALTER TABLE `albums`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tracks`
--
ALTER TABLE `tracks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tracks`
--
ALTER TABLE `tracks`
  ADD CONSTRAINT `fk_tracks_albums` FOREIGN KEY (`albums_ID`) REFERENCES `albums` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
