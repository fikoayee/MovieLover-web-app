using Microsoft.AspNetCore.Identity;
using MovieLover.Data.Static;
using MovieLover.Models;

namespace MovieLover.Data
{
    public class MovieLoverSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MovieLoverContext>();
                context.Database.EnsureCreated();


                // actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            
                            FullName = "Keanu Reeves", // 1
                            DateOfBirth = new DateTime(1964, 09, 2),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNGJmMWEzOGQtMWZkNS00MGNiLTk5NGEtYzg1YzAyZTgzZTZmXkEyXkFqcGdeQXVyMTE1MTYxNDAw._V1_.jpg",
                            Biography = "Keanu Charles Reeves, whose first name means \"cool breeze over the mountains\" in Hawaiian, was born September 2, 1964 in Beirut, Lebanon. He is the son of Patricia Taylor, a showgirl and costume designer, and Samuel Nowlin Reeves, a geologist. Keanu's father was born in Hawaii, of British, Portuguese, Native Hawaiian, and Chinese ancestry, and Keanu's mother is originally from England. After his parents' marriage dissolved, Keanu moved with his mother and younger sister, Kim Reeves, to New York City, then Toronto. Stepfather #1 was Paul Aaron, a stage and film director - he and Patricia divorced within a year, after which she went on to marry (and divorce) rock promoter Robert Miller and hair salon owner Jack Bond. Reeves never reconnected with his biological father. In high school, Reeves was lukewarm toward academics but took a keen interest in ice hockey (as team goalie, he earned the nickname \"The Wall\") and drama. He eventually dropped out of school to pursue an acting career.\r\n\r\nAfter a few stage gigs and a handful of made-for-TV movies, he scored a supporting role in the Rob Lowe hockey flick Youngblood (1986), which was filmed in Canada. Shortly after the production wrapped, Reeves packed his bags and headed for Hollywood. Reeves popped up on critics' radar with his performance in the dark adolescent drama, W zakolu rzeki (1986), and landed a supporting role in the Oscar-nominated Dangerous Liaisons (1988) with director Stephen Frears.\r\n\r\nHis first popular success was the role of totally rad dude Ted \"Theodore\" Logan in Bill & Ted's Excellent Adventure (1989). The wacky time-travel movie became something of a cultural phenomenon, and audiences would forever confuse Reeves's real-life persona with that of his doofy on-screen counterpart. He then joined the casts of Ron Howard's comedy, Parenthood (1989) and Lawrence Kasdan's I Love You to Death (1990).\r\n\r\nOver the next few years, Reeves tried to shake the Ted stigma with a series of highbrow projects. He played a slumming rich boy opposite River Phoenix's narcoleptic male hustler in My Own Private Idaho (1991), an unlucky lawyer who stumbles into the vampire's lair in Dracula (1992), and Shakespearean party-pooper Don John in Much Ado About Nothing (1993).\r\n\r\nIn 1994, the understated actor became a big-budget action star with the release of Speed (1994). Its success heralded an era of five years in which Reeves would alternate between small films, like Feeling Minnesota (1996) and The Last Time I Committed Suicide (1997), and big films like Spacer w chmurach (1995) and The Devil's Advocate (1997). (There were a couple misfires, too: Johnny Mnemonic (1995) and Chain Reaction (1996).) After all this, Reeves did the unthinkable and passed on the Speed sequel, but he struck box-office gold again a few years later with the Wachowski siblings' cyberadventure, The Matrix (1999).\r\n\r\nNow a bonafide box-office star, Keanu would appear in a string of smaller films -- among them The Replacements (2000), The Watcher (2000), The Gift (2000), Sweet November (2001), and Hardball (2001) - before The Matrix Reloaded (2003) and The Matrix Revolutions (2003) were both released in 2003.\r\n\r\nSince the end of The Matrix trilogy, Keanu has divided his time between mainstream and indie fare, landing hits with Something's Gotta Give (2003), The Lake House (2006), and Królowie ulicy (2008). He's kept Matrix fans satiated with films such as Constantine (2005), A Scanner Darkly (2006), and The Day the Earth Stood Still (2008). And he's waded back into art-house territory with Ellie Parker (2005), Thumbsucker (2005), Prywatne życie Pippy Lee (2009), and Henry's Crime (2010).\r\n\r\nMost recently, as post-production on the samurai epic 47 Ronin (2013) waged on, Keanu appeared in front of the camera in Side by Side (2012), a documentary on celluloid and digital filmmaking, which he also produced. He also directed another Asian-influenced project, Man of Tai Chi (2013).\r\n\r\nIn 2014, Keanu played the title role in the action revenge film John Wick (2014), which became popular with critics and audiences alike. He reprised the role in John Wick: Chapter 2 (2017), taking the now-iconic character to a better opening weekend and even more enthusiastic reviews than the first go-around.\r\n\r\nAs of 2022, Reeves is 58-years-old. He is still active in the film industry to this day, and he seems to have no plans to retire.",
                            PlaceOfBirthCity = "Beirut",
                            PlaceOfBirthCountry = "Lebanon",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Laurence Fishburne", // 2
                            DateOfBirth = new DateTime(1961, 07, 30),
                            ImageURL = "https://static.wikia.nocookie.net/warner-bros-entertainment/images/6/6b/Laurence_Fishburne.jpg/revision/latest?cb=20211022204754",
                            Biography = "Critically hailed for his forceful, militant, authoritative figures and one of Hollywood's most talented and versatile performers, Laurence (John) Fishburne III has been the recipient of numerous awards, including a number of NAACP Image honors.\r\n\r\nBorn in Augusta, Georgia on July 30, 1961, to Hattie Bell (Crawford), a teacher, and Laurence John Fishburne, Jr., a juvenile corrections officer. His mother transplanted her family to Brooklyn after his parents divorced. At the age of 10, the young boy appeared in his first play, \"In My Many Names and Days,\" at a cramped little theater space in Manhattan. He continued on but managed to avoid the trappings of a child star per se, considering himself more a working child actor at the time. Billing himself as Larry Fishburne during this early phase, he never studied or was trained in the technique of acting.\r\n\r\nIn 1973, at the age of 12, young Laurence won a recurring role on the daytime soap One Life to Live (1968) that lasted three seasons. He subsequently made his film debut in the ghetto-themed Cornbread, Earl and Me (1975). At 14 Francis Ford Coppola cast him in Czas Apokalipsy (1979), which filmed for two years in the Philippines. Laurence didn't work for another year and a half after that long episode. A graduate of Lincoln Square Academy, Coppola was impressed enough with Laurence to hire him again down the line with featured roles in Rumble Fish (1983), Cotton Club (1984) and Kamienne ogrody (1987).\r\n\r\nThroughout the 1980s, he continued to build up his film and TV credit list with featured roles despite little fanfare. A recurring role as Cowboy Curtis on the kiddie show Pee-wee's Playhouse (1986) helped him through whatever lean patches there were at the time. TV guest appearances at this time included \"Trapper John,\" \"M*A*S*H*,\" \"Hill Street Blues,\" \"Miami Vice,\" \"Spenser: For Hire\" and \"The Equalizer.\"\r\n\r\nWith the new decade (1990s) came out-and-out stardom for Laurence. A choice lead in John Singleton's urban tale Boyz n the Hood (1991) catapulted him immediately into the front of the film ranks. Set in LA's turbulent South Central area, his potent role as a morally minded divorced father who strives to rise above the ignorance and violence of his surroundings, Laurence showed true command and the ability to hold up any film.\r\n\r\nOn stage, Laurence would become invariably linked to playwright August Wilson and his 20th Century epic African-American experience after starring for two years as the eruptive ex-con in \"Two Training Running.\" For this powerful, mesmerizing performance, Laurence won nearly every prestigious theater award in the books (Tony, Outer Critics Circle, Drama Desk and Theatre World). It was around the time of this career hallmark that he began billing himself as \"Laurence\" instead of \"Larry.\" More awards and accolades came his way. In addition to an Emmy for the pilot episode of the series \"Tribeca,\" he was nominated for his fine work in the quality mini-movies The Tuskegee Airmen (1995) and Miss Evers' Boys (1997).\r\n\r\nOn the larger screen, both Laurence and Angela Bassett were given Oscar nominations for their raw, seething portrayals of rock stars Ike and Tina Turner in the film Tina (1993). To his credit, he managed to take an extremely repellent character and make it a sobering and captivating experience. A pulp box-office favorite as well, he originated the role of Morpheus, Keanu Reeves' mentor, in the exceedingly popular futuristic sci-fi The Matrix (1999), best known for its ground-breaking special effects. He wisely returned for its back-to-back sequels.\r\n\r\nInto the millennium, Laurence extended his talents by making his screenwriting and directorial debut in Once in the Life (2000), in which he also starred. The film is based on his own critically acclaimed play \"Riff Raff,\" which he staged five years earlier. In 1999, he scored a major theater triumph with a multi-racial version of \"The Lion in Winter\" as Henry II opposite Stockard Channing's Eleanor of Acquitaine. On film, Fishburne has appeared in a variety of interesting roles in not-always-successful films. Never less than compelling, a few of his more notable parts include an urban speed chess player in Searching for Bobby Fischer (1993); a military prisoner in Kompania karna (1990); a college professor in Singleton's Higher Learning (1995); a CIA operative in Bad Company (1995); the title role in Otello (1995) (he was the first black actor to play the part on film); a spaceship rescue team leader in the sci-fi horror Event Horizon (1997); a Depression-era gangster in Gangster (1997); a dogged police sergeant in Clint Eastwood's Rzeka tajemnic (2003); a spelling bee coach in Akeelah and the Bee (2006); and prominent roles in the mainstream films Predators (2010) and Contagion (2011). He returned occasionally to the theatre. In April 2008, he played Thurgood Marshall in the one-man show \"Thurgood\" and won a Drama Desk Award. It was later transferred to the TV screen and earned an Emmy nomination.\r\n\r\nIn the fall of 2008, Fishburne replaced William Petersen as the male lead investigator on the popular CBS drama CSI: Kryminalne zagadki Las Vegas (2000), but left the show in 2011 to refocus on films and was in turn replaced by Ted Danson. Having since had a regular role as \"Pops\" in the comedy Black-ish (2014), he has also been seen on the bigger screen in the Superman movies Man of Steel (2013) and Batman kontra Superman: Świt sprawiedliwości (2016) as Daily Planet chief Perry White; played a hired assassin in the thriller Standoff (2016); portrayed a minister and former Vietnam War vet in Last Flag Flying (2017); and essayed the role of a revengeful prison warden in Imprisoned (2018).",
                            PlaceOfBirthCity = "Augusta, Georgia",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Carrie-Anne Moss", // 3
                            DateOfBirth = new DateTime(1967, 08, 21),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTYxMjgwNzEwOF5BMl5BanBnXkFtZTcwNTQ0NzI5Ng@@._V1_.jpg",
                            Biography = "Carrie-Anne Moss was born and raised in Vancouver, Canada. At age 20, after studying at the American Academy of Dramatic Arts, she moved to Europe to pursue a career in modeling. While in Spain she was cast in the TV show Dark Justice which was produced in Barcelona for its first season and Los Angeles for its second. Once in LA, Carrie-Anne was cast in other series regular opportunities like Matrix (which coincidentally presaged the movie that would later make her famous), and then Aaron Spelling's Models Inc.\r\n\r\nCarrie-Anne's work was gaining attention when the late great Mali Finn brought her in to audition for The Wachowski's, who offered her the opportunity to create the iconic cyber warrior \"Trinity\". Alongside her \"One\" Keanu Reeves, in stride with Laurence Fishburne and the multifaceted Hugo Weaving. Carrie-Anne Moss galvanized her place in cinematic history in one of the highest grossing sci-fi action franchises of all time.\r\n\r\nCarrie-Anne began receiving a wide range of scripts but it was the complex screenplay Memento that stirred her creative senses and once meeting the then unknown writer/director Christopher Nolan, it was without hesitation that she accepted the role of \"Natalie\" in Nolan's directorial debut. Her remarkable performance won her the coveted Spirit Award for Best Supporting Female that year.\r\n\r\nProminent directors and producers continued to pursue her. She survived with Val Kilmer on the Red Planet for Warner Bros; sweetened Lasse Hallstrom's multi Oscar nominated Chocolat for Miramax and tracked Sir Ben Kingsley in Paramount's Suspect Zero. She mothered Shia LaBeouf in DreamWork's box-office hit Disturbia; and together with Samuel L. Jackson, led the intense interrogation of Michael Sheen in Sony's Unthinkable.\r\n\r\nCarrie-Anne continued to collaborate on independent projects including The Chumscrubber with Ralph Fiennes and Glenn Close; the comedy noir Mini's First Time also starring Alec Baldwin and Luke Wilson; Snow Cake the touching drama with Sigourney Weaver and Alan Rickman; Fireflies in the Garden in the company of Ryan Reynolds, Julia Roberts and Willem Defoe; and the retro zombie rom-com Fido along with Billy Connelly and Dylan Baker.\r\n\r\nThroughout her career, Carrie-Anne has joined compelling television projects such as Ryan Murphy's Pretty Handsome; CBS's Vegas for James Mangold and Marvel's Jessica Jones as \"Jerry Hogarth\" for show runner Melissa Rosenberg. She recently finished acting and also producing in her second season, the bi-lingual English/Norwegian detective crime series Wisting, as an FBI agent set in the Norwegian landscape.\r\n\r\nNext up, Carrie-Anne returns once again to star as \"Trinity\" in the much anticipated fourth installment of Lana Wachowski's Matrix Resurrections opposite Keanu Reeves for Warner Bros, which launches globally December 22, 2021",
                            PlaceOfBirthCity = "Vancouver",
                            PlaceOfBirthCountry = "Canada",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Yahya Abdul-Mateen II", // 4
                            DateOfBirth = new DateTime(1986, 07, 15),
                            ImageURL = "https://i.guim.co.uk/img/media/a2de15e8e7eb6992a4ebb73a14735fabcaa9a02a/0_97_3755_2253/master/3755.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=f0190f3f818f64ec0ec92c70ac11f149",
                            Biography = "Yahya Abdul-Mateen II is an American actor. He portrayed David Kane, the Black Manta in the DC Extended Universe Aquaman films and Bobby Seale in the Netflix historical legal drama The Trial of the Chicago 7. For his portrayal of Cal Abar in the HBO limited series Watchmen, he won a Primetime Emmy Award for Outstanding Supporting Actor in a Limited Series or Movie. He also starred in an episode of The Handmaid's Tale and Black Mirror. Abdul-Mateen portrayed incarnations of Morpheus and Agent Smith in The Matrix Resurrections.",
                            PlaceOfBirthCity = "New Orleans, Louisiana",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Mike Myers", // 5
                            DateOfBirth = new DateTime(1963, 05, 25),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTY0MTM1MTM5Nl5BMl5BanBnXkFtZTcwNzA1OTM3MQ@@._V1_UY1200_CR82,0,630,1200_AL_.jpg",
                            Biography = "Michael John Myers was born in 1963 in Scarborough, Ontario, to Alice E. (Hind), an officer supervisor, and Eric Myers, an insurance agent. His parents were both English, and had served in the Royal Air Force and British Army, respectively.Myers' television career really started in 1988, when he joined Saturday Night Live (1975), where he spent six seasons. He brought to life many memorable characters, such as Dieter and Wayne Cambell. His major movies include Wayne's World (1992), Wayne's World 2 (1993), So I Married an Axe Murderer (1993), the Austin Powers movies and The Cat in the Hat (2003).",
                            PlaceOfBirthCity = "Scarborough",
                            PlaceOfBirthCountry = "Canada",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Eddie Murphy", //6 
                            DateOfBirth = new DateTime(1961, 4, 3),
                            ImageURL = "https://flxt.tmsimg.com/assets/1227_v9_bb.jpg",
                            Biography = "Edward Regan Murphy was born April 3, 1961 in Brooklyn, New York, to Lillian Lynch (born: Lillian Laney), a telephone operator, and Charles Edward Murphy, a transit police officer who was also an amateur comedian and actor. After his father died, his mother married Vernon Lynch, a foreman at a Breyer's Ice Cream plant. His brothers are Charlie Murphy & Vernon Lynch Jr. Eddie had aspirations of being in show business since he was a child. A bright kid growing up in the streets of New York, Murphy spent a great deal of time on impressions and comedy stand-up routines rather than academics. His sense of humor and wit made him a stand out amongst his classmates at Roosevelt Junior-Senior High School. By the time he was fifteen, Murphy worked as a stand-up comic on the lower part of New York, wooing audiences with his dead-on impressions of celebrities and outlooks on life.\r\n\r\nIn the early 1980s, at the age of 19, Murphy was offered a contract for the Not-Ready-For-Prime-Time Players of Saturday Night Live (1975), where Murphy exercised his comedic abilities in impersonating African American figures and originating some of the show's most memorable characters: Velvet Jones, Mr. Robinson, and a disgruntled and angry Gumby. Murphy made his feature film debut in 48 Hrs. (1982), alongside Nick Nolte. The two's comedic and antagonistic chemistry, alongside Murphy's believable performance as a streetwise convict aiding a bitter, aging cop, won over critics and audiences. The next year, Murphy went two for two, with another hit, pairing him with John Landis, who later became a frequent collaborator with Murphy in Coming to America (1988) and Beverly Hills Cop III (1994). Beverly Hills Cop (1984) was the film that made Murphy a box-office superstar and most notably made him a celebrity worldwide, and it remains one of the all-time biggest domestic blockbusters in motion-picture history. Murphy's performance as a young Detroit cop in pursuit of his friend's murderers earned him a third consecutive Golden Globe nomination. Axel Foley became one of Murphy's signature characters. On top of his game, Murphy was unfazed by his success, that is until his box office appeal and choices in scripts resulted into a spotty mix of hits and misses into the late 1980s and early 1990s.\r\n\r\nFilms like The Golden Child (1986) and Beverly Hills Cop II (1987) were critically panned but were still massive draws at the box office. In 1989, Murphy, coming off another hit, Coming to America (1988), found failure with his directorial debut, Noce Harlemu (1989). Another 48 Hrs. (1990), his turn as a hopeless romantic in Boomerang (1992) and as a suave vampire in Vampire In Brooklyn did little to resuscitate his career. However, his remake of Jerry Lewis's Gruby i chudszy (1996) brought Murphy's drawing power back into fruition. From there, Murphy rebounded with occasional hits and misses but has long proven himself as a skilled comedic actor with laudable range pertaining to characterizations and mannerisms. Though he has grown up a lot since his fast-lane rise as a superstar in the 1980s, Murphy has lived the Hollywood lifestyle with controversy, criticism, scandal, and the admiration of millions worldwide for his talents. As Murphy had matured throughout the years, learning many lessons about the Hollywood game in the process, he settled down with more family-oriented humor with Doctor Dolittle (1998), Mulan (1998), Bowfinger (1999), and the animated smash Shrek (2001), in a supporting role that showcased Murphy's comedic personality and charm. Throughout the 2000s, he further starred in the hits The Haunted Mansion (2003), Shrek 2 (2004), Dreamgirls (2006) (for which he was nominated for a Best Supporting Actor Oscar), Norbit (2007), Shrek 3 (2007), and Shrek Forever After (2010).\r\n\r\nMurphy was married to Nicole Mitchell Murphy from 1993 to 2006. Murphy has ten children.",
                            PlaceOfBirthCity = "Brooklyn, New York City, New York",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Cameron Diaz", //7
                            DateOfBirth = new DateTime(1972, 08, 30),
                            ImageURL = "https://images.zwierciadlo.pl/_resource/res/path/45/8a/458abe9c-a252-4584-a62c-5876241582cd_f750x750",
                            Biography = "A tall, strikingly attractive blue-eyed natural blonde, Cameron Diaz was born in 1972 in San Diego, the daughter of a Cuban-American father and a German mother. Self described as \"adventurous, independent and a tough kid,\" Cameron left home at 16 and for the next 5 years lived in such varied locales as Japan, Australia, Mexico, Morocco, and Paris. Returning to California at the age of 21, she was working as a model when she auditioned for a big part in Maska (1994). To her amazement and despite having no previous acting experience, she was cast as the female lead in the film opposite Jim Carrey. Over the next 3 years, she honed her acting skills in such low budget independent films as The Last Supper (1995); Feeling Minnesota (1996); and Head Above Water (1996). She returned to main stream films in My Best Friend's Wedding (1997), in which she held her own against veteran actress Julia Roberts. She earned full fledged star status in 1998 for her performance in the box office smash There's Something About Mary (1998). With her name near the top on virtually every list of Hollyood's sexiest actresses, and firmly established as one of filmdom's hottest properties and most sought after actresses, Cameron Diaz appears to possess everything necessary to become one of the super stars of the new century.",
                            PlaceOfBirthCity = "San Diego, California",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Emma Watson", //8
                            DateOfBirth = new DateTime(1990, 4, 15),
                            ImageURL = "https://i.pinimg.com/originals/88/aa/b9/88aab93b1948c13d6acb878ced5e182e.jpg",
                            Biography = "Emma Charlotte Duerre Watson was born in Paris, France, to British parents, Jacqueline Luesby and Chris Watson, both lawyers. She moved to Oxfordshire when she was five, where she attended the Dragon School. From the age of six, Emma knew that she wanted to be an actress and, for a number of years, she trained at the Oxford branch of Stagecoach Theatre Arts, a part-time theatre school where she studied singing, dancing and acting. By the age of ten, she had performed and taken the lead in various Stagecoach productions and school plays.\r\n\r\nIn 1999, casting began for Harry Potter and the Sorcerers Stone (2001), the film adaptation of British author J.K. Rowling's bestselling novel. Casting agents found Emma through her Oxford theatre teacher. After eight consistent auditions, producer David Heyman told Emma and fellow applicants, Daniel Radcliffe and Rupert Grint, that they had been cast for the roles of the three leads, Hermione Granger, Harry Potter and Ron Weasley. The release of Harry Potter and the Sorcerer's Stone (2001) was Emma's cinematic screen debut. The film broke records for opening-day sales and opening-weekend takings and was the highest-grossing film of 2001. Critics praised the film and the performances of the three leading young actors. The highly distributed British newspaper, 'The Daily Telegraph', called her performance \"admirable\". Later, Emma was nominated for five awards for her performance in the film, winning the Young Artist Award for Leading Young Actress in a Feature Film.\r\n\r\nAfter the release of the first film of the highly successful franchise, Emma became one of the most well-known actresses in the world. She continued to play the role of Hermione Granger for nearly ten years, in all of the following Harry Potter films: Harry Potter and the Sorcerer's Stone (2001), Harry Potter and the Chamber of Secrets (2002), Harry Potter and the Prisoner of Azkaban (2004), Harry Potter and the Goblet of Fire (2005), Harry Potter and the Order of the Phoenix (2007), Harry Potter and the Half-Blood Prince (2009), Harry Potter and the Deathly Hallows: Part 1 (2010), and Harry Potter and the Deathly Hallows: Part 2 (2011). Emma acquired two Critics' Choice Award nominations from the Broadcast Film Critics Association for her work in Harry Potter And The Prisoner Of Azkaban and Harry Potter And The Goblet Of Fire. The completion of the seventh and eight movies saw Emma receive nominations in 2011 for a Nickelodeon Kids' Choice Award, and for Best Actress at the Jameson Empire Awards. The Harry Potter franchise won the BAFTA for Outstanding British Contribution to Cinema in February 2011.\r\n\r\n2011 saw Emma in Simon Curtis's My Week with Marilyn (2011), alongside a stellar cast of Oscar nominees including Michelle Williams as Marilyn Monroe and Kenneth Branagh as Sir Laurence Olivier, in addition to Eddie Redmayne, Dame Judi Dench, Dougray Scott, Zoe Wanamaker, Toby Jones and Dominic Cooper. Chronicling a week in Marilyn Monroe's life, the film featured Emma in the supporting role of Lucy, a costume assistant to Colin Clark (Redmayne). The film was released by The Weinstein Company and was nominated for a Golden Globe for Best Motion Picture - Comedy or Musical. In 2012 Emma was seen in Stephen Chbosky's adaptation of his coming-of-age novel The Perks of Being a Wallflower (2012), starring opposite Logan Lerman and Ezra Miller. This independent drama centered around Charlie (Lerman), an introverted freshman who is taken under the wings of two seniors (Watson and Miller) who welcome him to the real world. The film premiered at the 2012 Toronto International Film Festival and received rave reviews. The film won the People's Choice Award for Favourite Dramatic Movie and Emma also picked up the People's Choice Award for Favourite Dramatic Movie Actress. Emma was awarded a second time for this role with the Best Supporting Actress Award at the San Diego Film Critics Society Awards where the film also won the Best Ensemble Performance Award.\r\n\r\nIn summer 2013, Emma starred in Sofia Coppola's American satirical black comedy crime film, The Bling Ring (2013), opposite Katie Chang and Israel Broussard. The film took inspiration from real events and followed a group of teenagers who, obsessed with fashion and fame, burgled the homes of celebrities in Los Angeles. The film opened the Un Certain Regard section of the 2013 Cannes Film Festival. Emma also appeared in a cameo role as herself in Seth Rogen's apocalypse comedy This Is The End (2013). The film tells the story about what happens to some of Hollywood's best loved celebrities when the apocalypse strikes during a party at James Franco's house.\r\n\r\nIn 2014, Emma was seen in Darren Aronofsky's Noe: Wybrany przez Boga (2014), opposite Russell Crowe, Jennifer Connelly, Ray Winstone, Douglas Booth, Logan Lerman, and Anthony Hopkins. The film told the epic, biblical tale of Noah and the ark. Emma plays the role of Ila, a young woman who develops a close relationship with Noah's son, Shem (Booth). Noah made an outstanding $300m since its release in March. In 2015, Emma starred in Regression (2015), written and directed by Alejandro Amenábar. Also headlined by Oscar-nominated Ethan Hawke, and set in Minnesota in 1990, Regression tells the story of Detective Bruce Kenner (Hawke), who investigates the case of young Angela, played by Emma, who accuses her father of sexual abuse.\r\n\r\nIn 2012, Emma was honored with the Calvin Klein Emerging Star Award at the ELLE Women in Hollywood Awards. In 2013, Emma was awarded the Trailblazer Award at the MTV Movie Awards in April and was honored with the GQ Woman of the Year Award at the GQ Awards in September. Further to her acting career, Emma is a Goodwill Ambassador for the UN, promoting gender equality and the empowerment of women. Emma graduated from Brown University in May 2014.\r\n\r\nIn 2017, Emma starred in the live-action Disney fantasy Beauty and the Beast (2017), one of the biggest movies of all time in the U.S., and the dramatic thriller The Circle (2017).",
                            PlaceOfBirthCity = "Paris",
                            PlaceOfBirthCountry = "France",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Rupert Grint", //9
                            DateOfBirth = new DateTime(1988, 8, 24),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNTNhODBmODktNjViNC00MTM2LWExMzUtNzY3MTY5NWI1ZDE4XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg",
                            Biography = "Rupert Alexander Lloyd Grint was born in Harlow, Essex, England, the elder son of Joanne (Parsons) and Nigel Grint, who dealt in memorabilia. The first of 5 children, Rupert has one brother and three sisters.\r\n\r\nRupert grew up in Hertfordshire, the English county directly to the north of London, conveniently placed for commuting to Leavesden Film Studios. Before successfully auditioning for the Harry Potter films, Rupert attended Richard Hale Secondary School in Hertford: here he took an active interest in school plays, being cast as Rumplestilskin in the Brothers Grimm fairy tales. He was also a regular attendee at weekend drama classes at Top Hat Stage School, also in Hertford.\r\n\r\nTime at school was limited, as Rupert was needed on set for the Harry Potter films, where all of the child actors were tutored for four hours a day on set, to keep up with legal requirements. During the summer of 2004, he took his GCSE (General Certificate of Secondary Education) exams and completed his formal education.",
                            PlaceOfBirthCity = "Stevenage, Hertfordshire",
                            PlaceOfBirthCountry = "England, UK",

                        },
                        new ActorModel()
                        {
                            
                            FullName = "Daniel Radcliffe", //10
                            DateOfBirth = new DateTime(1989, 7, 23),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BZmE0NzNiNzQtYTVlYS00MjljLWE4MTgtYzYxNjU2NjZkM2M4XkEyXkFqcGdeQXVyNjY5NDgzNjQ@._V1_.jpg",
                            Biography = "Daniel Jacob Radcliffe was born on July 23, 1989 in Fulham, London, England, to casting agent Marcia Gresham (née Jacobson) and literary agent Alan Radcliffe. His father is from a Northern Irish Protestant background, while his mother was born in South Africa, to a Jewish family (from Lithuania, Poland, Russia, and Germany). Daniel began performing in small school productions as a young boy. Soon enough, he landed a role in David Copperfield (1999), as the young David Copperfield. A couple of years later, he landed a role as Mark Pendel in The Tailor of Panama (2001), the son of Harry and Louisa Pendel (Geoffrey Rush and Jamie Lee Curtis). Curtis had indeed pointed out to Daniel's mother that he could be Harry Potter himself. Soon afterwards, Daniel was cast as Harry Potter by director, Chris Columbus in the film that hit theaters in November 16, 2001, Harry Potter and the Sorcerer's Stone (2001). He was recognized worldwide after this film was released. Pleasing audiences and critics everywhere, filming on its sequel, Harry Potter and the Chamber of Secrets (2002), commenced shortly afterwards. He appeared again as Harry in Harry Potter and the Prisoner of Azkaban (2004) directed by Alfonso Cuarón, and then appeared in Harry Potter and the Goblet of Fire (2005) directed by Mike Newell. Shortly afterwards, he finished filming December Boys (2007) in Adelaide, Australia, Kangaroo Island, and Geelong, Australia which began on the 14 November 2005 and ended sometime in December. On January 27, 2006, he attended the South Bank Awards Show to present the award for \"Breakthrough Artist of the Year\" to Billie Piper. Daniel reprised his famous character once again for the next installment of the Harry Potter series, Harry Potter and the Order of the Phoenix (2007). In February 2007, he took on his first stage role in the West End play Equus, to worldwide praise from fans and critics alike. Also that year, he starred in the television movie My Boy Jack (2007), which aired on 11 November 2007 in the UK.\r\n\r\nAfter voicing a character in an episode of the animated television series The Simpsons in late 2010, Radcliffe debuted as J. Pierrepont Finch in the 2011 Broadway revival How to Succeed in Business Without Really Trying, a role previously held by Broadway veterans Robert Morse and Matthew Broderick. Other cast members included John Larroquette, Rose Hemingway and Mary Faber. Both the actor and production received good reviews, with USA Today commenting: \"Radcliffe ultimately succeeds not by overshadowing his fellow cast members, but by working in conscientious harmony with them - and having a blast in the process.\" Radcliffe's performance in the show earned him Drama Desk Award, Drama League Award and Outer Critics Circle Award nominations. The production itself later received nine Tony Award nominations. Radcliffe left the show on 1 January 2012. His first post-Harry Potter project was the 2012 horror film The Woman in Black, adapted from the 1983 novel by Susan Hill. The film was released on 3 February 2012 in the United States and Canada, and was released on 10 February in the UK. Radcliffe portrays a man sent to deal with the legal matters of a mysterious woman who has just died, and soon after he begins to experience strange events from the ghost of a woman dressed in black. He has said he was \"incredibly excited\" to be part of the film and described the script as \"beautifully written\".\r\n\r\nIn 2013, he portrayed American poet Allen Ginsberg in the thriller drama Kill Your Darlings (2013), directed by John Krokidas. He also starred in an Irish-Canadian romantic comedy film The F Word directed by Michael Dowseand written by Elan Mastai, based on TJ Dawe and Michael Rinaldi's play Toothpaste and Cigars and then he starred in an American dark fantasy horror film directed by Alexandre Aja Horns. Both of the films premiered at the 38th Toronto International Film Festival. Radcliffe also performed at the Noël Coward Theatre in the stage play revival of Martin McDonagh's dark comedy The Cripple of Inishmaan as the lead, Billy Claven, for which he won the WhatsOnStage Award for Best Actor in a Play. In 2015, Radcliffe starred as Igor in a science fiction horror film Victor Frankenstein (2015), directed by Paul McGuigan and written by Max Landis, which was based on contemporary adaptations of Mary Shelley's 1818 novel Frankenstein. In 2016, he appeared as a wealthy villain in the mystery/action film Now You See Me 2 (2016), and as an oftentimes mobile corpse in the indie fantasy Swiss Army Man (2016).\r\n\r\nNow being one of the world's most recognizable people, Daniel leads a somewhat normal life. He has made friends working on the Harry Potter films, which include his co-stars Rupert Grint and Emma Watson.",
                            PlaceOfBirthCity = "Fulham, London",
                            PlaceOfBirthCountry = "England, UK",

                        },
                        new ActorModel()
                        {

                            FullName = "Elijah Wood", //11
                            DateOfBirth = new DateTime(1981, 1, 28),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTM0NDIxMzQ5OF5BMl5BanBnXkFtZTcwNzAyNTA4Nw@@._V1_.jpg",
                            Biography = "Elijah Wood is an American actor best known for portraying Frodo Baggins in Peter Jackson's blockbuster Lord of the Rings film trilogy. In addition to reprising the role in The Hobbit series, Wood also played Ryan in the FX television comedy Wilfred (2011) and voiced Beck in the Disney XD animated television series TRON: Uprising (2012).\r\n\r\nBorn Elijah Jordan Wood on 28 January, 1981, in Cedar Rapids, Iowa, Wood is the son of Debbie (Krause) and Warren Wood, who ran a delicatessen. He has an older brother, Zach, and a younger sister, Hannah Wood. He is of English, German, Austrian, and Danish descent. Demonstrating a gift for performing at a young age, Wood's natural talent inspired his mother to take him to an International Modeling and Talent Association annual convention in Los Angeles. Soon after, he began to get bookings for small parts on television.\r\n\r\nAlthough his first credit was a small part in Back to the Future Part II (1989), Wood's first major film role was in the 'Barry Levinson' historical family drama Avalon (1990). Following that, Wood became an in-demand child actor, appearing in a number of major films such as Paradise (1991), Radio Flyer (1992) and The Good Son (1993), in which he co-starred with Macaulay Culkin. This was followed by the first role for which he received top-billing, North (1994). Although the film was widely condemned and a disaster at the box office, Elijah was praised as the only good thing to come out of it.\r\n\r\nIn 1996 Elijah starred in a movie remake of an old TV show, Flipper (1996). Many critics wondered if his ability as a child actor to capture an audience was wearing thin, as had many child actors', but Wood deftly transitioned into a versatile performer with roles such as the endlessly curious Mikey Carver in Ang Lee' ensemble film The Ice Storm (1997), as well as parts in popcorn flicks like Deep Impact (1998) and Oni (1998). In 1999, Elijah was in three movies that never made it into wide release: The Bumblebee Flies Anyway (1999) (released on satellite TV), Black & White (1999) (released on home video) and Chain of Fools (2000).\r\n\r\nWood's work in Peter Jackson's film adaptations of J.R.R. Tolkien's The Lord of the Rings: The Fellowship of the Ring (2001), The Lord of the Rings: The Two Towers (2002), and The Lord of the Rings: The Return of the King (2003), provided a major boost to his career. The actor followed his work in the astronomically successful trilogy with a broad range of interesting screen roles and voice work, including a supporting role in Michel Gondry's Eternal Sunshine of the Spotless Mind (2004), as well as the part of a sinister mute sociopath in Sin City (2005). His voice work has been featured in such animated films as Happy Feet (2006) and 9 (2009), as well as on television series including American Dad! (2005) and Robot Chicken (2001). Wood also played Ad-Rock in the Beastie Boys' comedic video for Beastie Boys: Fight for Your Right Revisited (2011).\r\n\r\nAn avid music fan, Wood founded Simian records and released its first album, New Magnetic Wonder by The Apples in Stereo, in 2007.",
                            PlaceOfBirthCity = " Cedar Rapids, Iowa",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Ian McKellen", //12
                            DateOfBirth = new DateTime(1939, 5, 25),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTQ2MjgyNjk3MV5BMl5BanBnXkFtZTcwNTA3NTY5Mg@@._V1_.jpg",
                            Biography = "Widely regarded as one of greatest stage and screen actors both in his native Great Britain and internationally, twice nominated for the Oscar and recipient of every major theatrical award in the UK and US, Ian Murray McKellen was born on May 25, 1939 in Burnley, Lancashire, England, to Margery Lois (Sutcliffe) and Denis Murray McKellen, a civil engineer and lay preacher. He is of Scottish, Northern Irish, and English descent. During his early childhood, his parents moved with Ian and his older sister, Jean, to the mill town of Wigan. It was in this small town that young Ian rode out World War II. He soon developed a fascination with acting and the theatre, which was encouraged by his parents. They would take him to plays, those by William Shakespeare, in particular. The amateur school productions fostered Ian's growing passion for theatre.\r\n\r\nWhen Ian was of age to begin attending school, he made sure to get roles in all of the productions. At Bolton School in particular, he developed his skills early on. Indeed, his first role in a Shakespearian play was at Bolton, as Malvolio in \"Twelfth Night\". Ian soon began attending Stratford-upon-Avon theatre festivals, where he saw the greats perform: Laurence Olivier, Wendy Hiller, John Gielgud, Ralph Richardson and Paul Robeson. He continued his education in English Drama, but soon it fell by the wayside as he concentrated more and more on performing. He eventually obtained his Bachelor of Arts in 1961, and began his career in earnest.\r\n\r\nMcKellen began working in theatre over the next few years. Very few people knew of Ian's homosexuality; he saw no reason to go public, nor had he told his family. They did not seem interested in the subject and so he saw no reason to bring it up. In 1988, Ian publicly came out of the closet on the BBC Radio 4 program, while discussing Margaret Thatcher's \"Section 28\" legislation, which made the promotion of homosexuality as a family relationship by local authorities an offense. It was reason enough for McKellen to take a stand. He has been active in the gay rights movement ever since.",
                            PlaceOfBirthCity = "Burnley, Lancashire",
                            PlaceOfBirthCountry = "England, UK",

                        },
                        new ActorModel()
                        {

                            FullName = "Orlando Bloom", //13
                            DateOfBirth = new DateTime(1977, 1, 13),
                            ImageURL = "https://fwcdn.pl/ppo/83/46/8346/449891.2.jpg",
                            Biography = "Orlando Jonathan Blanchard Copeland Bloom was born on January 13, 1977 in Canterbury, Kent, England. His mother, Sonia Constance Josephine Bloom (née Copeland), was born in Kolkata, India, to an English family then-resident there. The man he first knew as his father, Harry Bloom, was a legendary political activist who fought for civil rights in South Africa. But Harry died of a stroke when Orlando was only four years old. After that, Orlando and his older sister, Samantha Bloom, were raised by their mother and family friend, Colin Stone. When Orlando was 13, Sonia revealed to him that Colin is actually the biological father of Orlando and his sister; the two were conceived after an agreement by his parents, since Harry, who suffered a stroke in 1975, was unable to have children.\r\n\r\nOrlando attended St. Edmund's School in Canterbury but struggled in many courses because of dyslexia. He did embrace the arts, however, and enjoyed pottery, photography and sculpturing. He also participated in school plays and was active at his local theater. As a teen, Orlando landed his first job: he was a clay trapper at a pigeon shooting range. Encouraged by his mother, he and his sister began studying poetry and prose, eventually giving readings at Kent Festival. Orlando and Samantha won many poetry and Bible reciting competitions. Then Orlando, who always idolized larger-than-life characters, gravitated towards serious acting. At the age of 16, he moved to London and joined the National Youth Theatre, spending two seasons there and gaining a scholarship to train with the British American Drama Academy. Like many young actors, he also auditioned for a number of television roles to further his career, landing bit parts in British television shows Casualty (1986), Midsomer Murders (1997) and Smack the Pony (1999). He also appeared in the critically acclaimed movie Wilde (1997).\r\n\r\nHe then attended the Guildhall School of Music and Drama. It was there, in 1998, that Orlando fell three stories from a rooftop terrace and broke his back. Despite fears that he would be permanently paralyzed, he quickly recovered and returned to the stage. As fate would have it, seated in the audience one night in 1999 was a director named Peter Jackson. After the show, he met with Orlando and asked him to audition for his new set of movies. After graduating from Guildhall, Orlando began work on the \"Lord of the Rings\" trilogy, spending 18 months in New Zealand bringing to life \"Legolas\", a part which made him a household name. Today, he is one of the busiest and most sought-after actors in the industry.",
                            PlaceOfBirthCity = "Canterbury, Kent",
                            PlaceOfBirthCountry = "England, UK",

                        },
                        new ActorModel()
                        {

                            FullName = "Viggo Mortensen", //14
                            DateOfBirth = new DateTime(1958, 10, 20),
                            ImageURL = "https://thumbs.dreamstime.com/b/viggo-mortensen-na-afi-fest-pokaz-drogi-kt%C3%B3ry-odby%C5%82-si%C4%99-w-chi%C5%84skim-teatrze-graumans-hollywood-usa-dniu-listopada-r-229887186.jpg",
                            Biography = "Since his screen debut as a young Amish farmer in Peter Weir's Witness (1985), Viggo Mortensen's career has been marked by a steady string of well-rounded performances.\r\n\r\nMortensen was born in New York City, to Grace Gamble (Atkinson) and Viggo Peter Mortensen, Sr. His father was Danish, his mother was American, and his maternal grandfather was Canadian. His parents met in Norway. They wed and moved to New York, where Viggo, Jr. was born, before moving to South America, where Viggo, Sr. managed chicken farms and ranches in Venezuela and Argentina. Two more sons were born, Charles and Walter, before the marriage grew increasingly unhappy. When Viggo was seven, his parents sent him to a a strict boarding school, isolated in the foothills of the mountains of Argentina. Then, at age eleven, his parents divorced. His mother moved herself and the children back to her home state of New York.\r\n\r\nViggo attended Watertown High School, and became a very good student and athlete. He graduated in 1976 and went on to St. Lawrence University in Canton, New York. After graduation, he moved to Denmark - driven by the need for a defining purpose in life. He began writing poetry and short stories while working many odd jobs, from dock worker to flower seller. In 1982, he fell in love and followed his girlfriend back to New York City, hoping for a long romance and a writing career. He got neither. In New York, Viggo found work waiting tables and tending bar and began taking acting classes, studying with Warren Robertson. He appeared in several plays and movies, and eventually moved to Los Angeles, where his performance in \"Bent\" at the Coast Playhouse earned him a Drama-logue Critic's Award.\r\n\r\nHe made his film debut with a small part in Witness (1985). He appeared in Salvation!: Have You Said Your Prayers Today? (1987) and married his co-star, Exene Cervenka. The two had a son, Henry Mortensen. But after nearly eleven years of marriage, the couple divorced.\r\n\r\nIn 1999, Viggo got a phone call about a movie he did not know anything about: \"The Lord of the Rings.\" At first, he didn't want to do it, because it would mean time away from his son. But Henry, a big fan of the books, told his father he shouldn't turn down the role. Viggo accepted the part and immediately began work on the project, which was already underway. Eventually, the success of \"The Lord of the Rings\" made him a household name - a difficult consequence for the ever private and introspective Viggo.\r\n\r\nCritics have continually recognized his work in over thirty movies, including such diverse projects as Jane Campion's Portret damy (1996), Sean Penn's The Indian Runner (1991), Brian De Palma's Carlito's Way (1993), Ridley Scott's G.I. Jane (1997), Tony Scott's Crimson Tide (1995), Andrew Davis's A Perfect Murder (1998), Ray Loriga's La pistola de mi hermano (1997), Tony Goldwyn's A Walk on the Moon (1999), and Peter Farrelly's Green Book (2018).\r\n\r\nMortensen is also an accomplished poet, photographer and painter.",
                            PlaceOfBirthCity = "Manhattan, New York City, New York",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Al Pacino", //15
                            DateOfBirth = new DateTime(1940, 4, 25),
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Al_Pacino_2016_%2830401544240%29.jpg/640px-Al_Pacino_2016_%2830401544240%29.jpg",
                            Biography = "Alfredo James \"Al\" 'Pacino established himself as a film actor during one of cinema's most vibrant decades, the 1970s, and has become an enduring and iconic figure in the world of American movies.\r\n\r\nHe was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors.\r\n\r\nAfter appearing in a string of plays in supporting roles, Pacino finally attained success off-Broadway with Israel Horovitz's \"The Indian Wants the Bronx\", winning an Obie Award for the 1966-67 season. That was followed by a Tony Award for \"Does the Tiger Wear a Necktie?\" His first feature films made little departure from the gritty realistic stage performances that earned him respect: he played a drug addict in Narkomani (1971) after his film debut in Me, Natalie (1969). The role of Michael Corleone in The Godfather (1972) was one of the most sought-after of the time: Robert Redford, Warren Beatty, Jack Nicholson, Ryan O'Neal, Robert De Niro and a host of other actors either wanted it or were mentioned, but director Francis Ford Coppola wanted Pacino for the role.\r\n\r\nCoppola was successful but Pacino was reportedly in constant fear of being fired during the very difficult shoot. The film was a monster hit that earned Pacino his first Academy Award nomination for Best Supporting Actor. However, instead of taking on easier projects for the big money he could now command, Pacino threw his support behind what he considered tough but important films, such as the true-life crime drama Serpico (1973) and the tragic real-life bank robbery film Dog Day Afternoon (1975). He was nominated three consecutive years for the \"Best Actor\" Academy Award. He faltered slightly with Bobby Deerfield (1977), but regained his stride with And Justice for All (1979), for which he received another Academy Award nomination for Best Actor. Unfortunately, this would signal the beginning of a decline in his career, which produced flops like Cruising (1980) and Autor! Autor! (1982).\r\n\r\nPacino took on another vicious gangster role and cemented his legendary status in the ultra-violent cult film Scarface (1983), but a monumental mistake was about to follow. Revolution (1985) endured an endless and seemingly cursed shoot in which equipment was destroyed, weather was terrible, and Pacino fell ill with pneumonia. Constant changes in the script further derailed the project. The Revolutionary War-themed film, considered among the worst films ever made, resulted in awful reviews and kept him off the screen for the next four years. Returning to the stage, Pacino did much to give back and contribute to the theatre, which he considers his first love. He directed a film, The Local Stigmatic (1990), but it remains unreleased. He lifted his self-imposed exile with the striking Sea of Love (1989) as a hard-drinking policeman. This marked the second phase of Pacino's career, being the first to feature his now famous dark, owl eyes and hoarse, gravelly voice.\r\n\r\nReturning to the Corleones, Pacino made Ojciec chrzestny III (1990) and earned raves for his first comedic role in the colorful adaptation Dick Tracy (1990). This earned him another Academy Award nomination for Best Supporting Actor, and two years later he was nominated for Glengarry Glen Ross (1992). He went into romantic mode for Frankie and Johnny (1991). In 1992, he finally won the Academy Award for Best Actor for his amazing performance in Scent of a Woman (1992). A mixture of technical perfection (he plays a blind man) and charisma, the role was tailor-made for him, and remains a classic.\r\n\r\nThe next few years would see Pacino becoming more comfortable with acting and movies as a business, turning out great roles in great films with more frequency and less of the demanding personal involvement of his wilder days. Carlito's Way (1993) proved another gangster classic, as did the epic crime drama Heat (1995) directed by Michael Mann and co-starring Robert De Niro. He directed the film adaptation of Shakespeare's Sposób na Szekspira (1996). During this period, City Hall (1996), Donnie Brasco (1997) and The Devil's Advocate (1997) all came out. Reteaming with Mann and then Oliver Stone, he gave commanding performances in Informator (1999) and Any Given Sunday (1999).\r\n\r\nIn the 2000s, Pacino starred in a number of theatrical blockbusters, including Ocean's Thirteen (2007), but his choice in television roles (the vicious, closeted Roy Cohn in the HBO miniseries Anioły w Ameryce (2003) and his sensitive portrayal of Jack Kevorkian, in the television movie You Don't Know Jack (2010)) are reminiscent of the bolder choices of his early career. Each television project garnered him an Emmy Award for Outstanding Lead Actor in a Miniseries or a Movie.\r\n\r\nNever wed, Pacino has a daughter, Julie Marie, with acting teacher Jan Tarrant, and a set of twins with former longtime girlfriend Beverly D'Angelo. His romantic history includes Jill Clayburgh, Veruschka von Lehndorff, Carole Mallory, Debra Winger, Tuesday Weld, Marthe Keller, Carmen Cervera, Kathleen Quinlan, Lyndall Hobbs, Penelope Ann Miller, and a two-decade intermittent relationship with \"Godfather\" co-star Diane Keaton. He currently lives with Argentinian actress Lucila Solá, who is 36 years his junior.\r\n\r\nAs of 2022, Pacino is 82-years-old. He has never retired from acting, and continues to appear regularly in film.",
                            PlaceOfBirthCity = "Manhattan, New York City, New York",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Marlon Brando", //16
                            DateOfBirth = new DateTime(1924, 4, 3),
                            ImageURL = "https://fr.web.img4.acsta.net/r_1280_720/medias/nmedia/18/35/35/84/18401897.jpg",
                            Biography = "Marlon Brando is widely considered the greatest movie actor of all time, rivaled only by the more theatrically oriented Laurence Olivier in terms of esteem. Unlike Olivier, who preferred the stage to the screen, Brando concentrated his talents on movies after bidding the Broadway stage adieu in 1949, a decision for which he was severely criticized when his star began to dim in the 1960s and he was excoriated for squandering his talents. No actor ever exerted such a profound influence on succeeding generations of actors as did Brando. More than 50 years after he first scorched the screen as Stanley Kowalski in the movie version of Tennessee Williams' A Streetcar Named Desire (1951) and a quarter-century after his last great performance as Col. Kurtz in Francis Ford Coppola's Czas Apokalipsy (1979), all American actors are still being measured by the yardstick that was Brando. It was if the shadow of John Barrymore, the great American actor closest to Brando in terms of talent and stardom, dominated the acting field up until the 1970s. He did not, nor did any other actor so dominate the public's consciousness of what WAS an actor before or since Brando's 1951 on-screen portrayal of Stanley made him a cultural icon. Brando eclipsed the reputation of other great actors circa 1950, such as Paul Muni and Fredric March. Only the luster of Spencer Tracy's reputation hasn't dimmed when seen in the starlight thrown off by Brando. However, neither Tracy nor Olivier created an entire school of acting just by the force of his personality. Brando did.\r\n\r\nMarlon Brando, Jr. was born on April 3, 1924, in Omaha, Nebraska, to Marlon Brando, Sr., a calcium carbonate salesman, and his artistically inclined wife, the former Dorothy Julia Pennebaker. \"Bud\" Brando was one of three children. His ancestry included English, Irish, German, Dutch, French Huguenot, Welsh, and Scottish; his surname originated with a distant German immigrant ancestor named \"Brandau.\" His oldest sister Jocelyn Brando was also an actress, taking after their mother, who engaged in amateur theatricals and mentored a then-unknown Henry Fonda, another Nebraska native, in her role as director of the Omaha Community Playhouse. Frannie, Brando's other sibling, was a visual artist. Both Brando sisters contrived to leave the Midwest for New York City, Jocelyn to study acting and Frannie to study art. Marlon managed to escape the vocational doldrums forecast for him by his cold, distant father and his disapproving schoolteachers by striking out for The Big Apple in 1943, following Jocelyn into the acting profession. Acting was the only thing he was good at, for which he received praise, so he was determined to make it his career - a high-school dropout, he had nothing else to fall back on, having been rejected by the military due to a knee injury he incurred playing football at Shattuck Military Academy, Brando Sr.'s alma mater. The school booted Marlon out as incorrigible before graduation.\r\n\r\nActing was a skill he honed as a child, the lonely son of alcoholic parents. With his father away on the road, and his mother frequently intoxicated to the point of stupefaction, the young Bud would play-act for her to draw her out of her stupor and to attract her attention and love. His mother was exceedingly neglectful, but he loved her, particularly for instilling in him a love of nature, a feeling which informed his character Paul in Last Tango in Paris (1972) (\"Last Tango in Paris\") when he is recalling his childhood for his young lover Jeanne. \"I don't have many good memories,\" Paul confesses, and neither did Brando of his childhood. Sometimes he had to go down to the town jail to pick up his mother after she had spent the night in the drunk tank and bring her home, events that traumatized the young boy but may have been the grain that irritated the oyster of his talent, producing the pearls of his performances. Anthony Quinn, his Oscar-winning co-star in Viva Zapata! (1952) told Brando's first wife Anna Kashfi, \"I admire Marlon's talent, but I don't envy the pain that created it.\"\r\n\r\nBrando enrolled in Erwin Piscator's Dramatic Workshop at New York's New School, and was mentored by Stella Adler, a member of a famous Yiddish Theatre acting family. Adler helped introduce to the New York stage the \"emotional memory\" technique of Russian theatrical actor, director and impresario Konstantin Stanislavski, whose motto was \"Think of your own experiences and use them truthfully.\" The results of this meeting between an actor and the teacher preparing him for a life in the theater would mark a watershed in American acting and culture.",
                            PlaceOfBirthCity = " Omaha, Nebraska",
                            PlaceOfBirthCountry = "United States of America",
                            DateOfDeath = new DateTime(2004, 7, 1)

                        },
                        new ActorModel()
                        {

                            FullName = "James Caan", //17
                            DateOfBirth = new DateTime(1940, 3, 26),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTI5NjkyNDQ3NV5BMl5BanBnXkFtZTcwNjY5NTQ0Mw@@._V1_.jpg",
                            Biography = "A masculine and enigmatic actor whose life and movie career have had more ups and downs than the average rollercoaster and whose selection of roles has arguably derailed him from achieving true superstar status, James Caan is New York-born and bred. He was born in the Bronx, to Sophie (Falkenstein) and Arthur Caan, Jewish immigrants from Germany. His father was a meat dealer and butcher. The athletically gifted Caan played football at Michigan State University while studying economics, holds a black belt in karate and for several years was even a regular on the rodeo circuit, where he was nicknamed \"The Jewish Cowboy\". However, while studying at Hofstra University, he became intrigued by acting and was interviewed and accepted at Sanford Meisner's Neighborhood Playhouse. He then won a scholarship to study under acting coach Wynn Handman and began to appear in several off-Broadway productions, including \"I Roam\" and \"Mandingo\". He made his screen debut as a sailor in Irma la Douce (1963) and began to impress audiences with his work in Red Line 7000 (1965) and the western El Dorado (1966) alongside John Wayne and Robert Mitchum. Further work followed in Journey to Shiloh (1968) and in the sensitive The Rain People (1969). However, audiences were moved to tears as he put in a heart-rending performance as cancer-stricken Chicago Bears running back Brian Piccolo in the highly rated made-for-TV film Brian's Song (1971). With these strong performances under his belt, Francis Ford Coppola then cast him as hot-tempered gangster Santino \"Sonny\" Corleone in the Mafia epic The Godfather (1972). The film was an enormous success, Caan scored a Best Supporting Actor nomination and, in the years since, the role has proven to be the one most fondly remembered by his legion of fans. He reprised the role for several flashback scenes in the sequel The Godfather Part II (1974) and then moved on to several very diverse projects. These included a cop-buddy crime partnership with Alan Arkin in the uneven Freebie and the Bean (1974), a superb performance as a man playing for his life in The Gambler (1974) alongside Lauren Hutton, and pairing with Barbra Streisand in Funny Lady (1975). Two further strong lead roles came up for him in 1975, first as futuristic sports star \"Jonathon E\" questioning the moral fiber of a sterile society in Rollerball (1975) and teaming up with Robert Duvall in the Sam Peckinpah spy thriller The Killer Elite (1975). Unfortunately, Caan's rising star sputtered badly at this stage of his career, and several film projects failed to find fire with either critics or audiences. These included such failures as the hokey Harry and Walter Go to New York (1976), the quasi-western Comes a Horseman (1978) and the saccharine Chapter Two (1979). However, he did score again with the stylish Michael Mann-directed heist movie Thief (1981).",
                            PlaceOfBirthCity = "The Bronx, New York",
                            PlaceOfBirthCountry = "United States of America",
                            DateOfDeath = new DateTime(2022, 7, 6)

                        },
                        new ActorModel()
                        {

                            FullName = "Robert De Niro", //18
                            DateOfBirth = new DateTime(1943, 8, 17),
                            ImageURL = "https://cdn.britannica.com/00/213300-050-ADF31CD9/American-actor-Robert-De-Niro-2019.jpg",
                            Biography = "One of the greatest actors of all time, Robert De Niro was born on August 17, 1943 in Manhattan, New York City, to artists Virginia (Admiral) and Robert De Niro Sr. His paternal grandfather was of Italian descent, and his other ancestry is Irish, English, Dutch, German, and French. He was trained at the Stella Adler Conservatory and the American Workshop. De Niro first gained fame for his role in Bang the Drum Slowly (1973), but he gained his reputation as a volatile actor in Mean Streets (1973), which was his first film with director Martin Scorsese. He received an Academy Award for Best Supporting Actor for his role in The Godfather Part II (1974) and received Academy Award nominations for best actor in Taxi Driver (1976), The Deer Hunter (1978) and Cape Fear (1991). He received the Academy Award for Best Actor for his role as Jake LaMotta in Raging Bull (1980).\r\n\r\nDe Niro has earned four Golden Globe Award nominations for Best Actor - Motion Picture Musical or Comedy, for his work in New York, New York (1977), opposite Liza Minnelli, Midnight Run (1988), Analyze This (1999) and Meet the Parents (2000). Other notable performances include Brazil (1985), The Untouchables (1987), Backdraft (1991), Frankenstein (1994), Heat (1995), Casino (1995) and Jackie Brown (1997). At the same time, he also directed and starred in such films as Prawo Bronxu (1993) and The Good Shepherd (2006). De Niro has also received the AFI Lifetime Achievement Award in 2003 and the Golden Globe Cecil B. DeMille Award in 2010.\r\n\r\nAs of 2022, De Niro is 79-years-old. He has never retired from acting, and continues to work regularly in mostly film.",
                            PlaceOfBirthCity = " New York City, New York",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Robert Duvall", //19
                            DateOfBirth = new DateTime(1931, 1, 5),
                            ImageURL = "https://musicimage.xboxlive.com/catalog/video.contributor.9b9b0000-0200-11db-89ca-0019b92a3933/image?locale=es-es&target=circle",
                            Biography = "Veteran actor and director Robert Selden Duvall was born on January 5, 1931, in San Diego, CA, to Mildred Virginia (Hart), an amateur actress, and William Howard Duvall, a career military officer who later became an admiral. Duvall majored in drama at Principia College (Elsah, IL), then served a two-year hitch in the army after graduating in 1953. He began attending The Neighborhood Playhouse School of the Theatre In New York City on the G.I. Bill in 1955, studying under Sanford Meisner along with Dustin Hoffman, with whom Duvall shared an apartment. Both were close to another struggling young actor named Gene Hackman. Meisner cast Duvall in the play \"The Midnight Caller\" by Horton Foote, a link that would prove critical to his career, as it was Foote who recommended Duvall to play the mentally disabled \"Boo Radley\" in To Kill a Mockingbird (1962). This was his first \"major\" role since his 1956 motion picture debut as an MP in Somebody Up There Likes Me (1956), starring Paul Newman.\r\n\r\nDuvall began making a name for himself as a stage actor in New York, winning an Obie Award in 1965 playing incest-minded longshoreman \"Eddie Carbone\" in the off-Broadway revival of Arthur Miller's \"A View from the Bridge\", a production for which his old roommate Hoffman was assistant director. He found steady work in episodic TV and appeared as a modestly billed character actor in films, such as Arthur Penn's The Chase (1966) with Marlon Brando and in Robert Altman's Countdown (1967) and Francis Ford Coppola's Deszczowi ludzie (1969), in both of which he co-starred with James Caan.\r\n\r\nHe was also memorable as the heavy who is shot by John Wayne at the climax of True Grit (1969) and was the first \"Maj. Frank Burns\", creating the character in Altman's Korean War comedy M*A*S*H (1970). He also appeared as the eponymous lead in George Lucas' directorial debut, THX 1138 (1971). It was Francis Ford Coppola, casting The Godfather (1972), who reunited Duvall with Brando and Caan and provided him with his career breakthrough as mob lawyer \"Tom Hagen\". He received the first of his six Academy Award nominations for the role.\r\n\r\nThereafter, Duvall had steady work in featured roles in such films as The Godfather Part II (1974), Elita zabójców (1975), Network (1976), The Seven-Per-Cent Solution (1976) and The Eagle Has Landed (1976). Occasionally this actor's actor got the chance to assay a lead role, most notably in Tomorrow (1972), in which he was brilliant as William Faulkner's inarticulate backwoods farmer. He was less impressive as the lead in Badge 373 (1973), in which he played a character based on real-life NYPD detective Eddie Egan, the same man his old friend Gene Hackman had won an Oscar for playing, in fictionalized form as \"Popeye Doyle\" in The French Connection (1971).\r\n\r\nIt was his appearance as \"Lt. Col. Kilgore\" in another Coppola picture, Czas Apokalipsy (1979), that solidified Duvall's reputation as a great actor. He got his second Academy Award nomination for the role, and was named by the Guinness Book of World Records as the most versatile actor in the world. Duvall created one of the most memorable characters ever assayed on film, and gave the world the memorable phrase, \"I love the smell of napalm in the morning!\"\r\n\r\nSubsequently, Duvall proved one of the few established character actors to move from supporting to leading roles, with his Oscar-nominated turns in The Great Santini (1979) and Tender Mercies (1983), the latter of which won him the Academy Award for Best Actor. Now at the summit of his career, Duvall seemed to be afflicted with the fabled \"Oscar curse\" that had overwhelmed the careers of fellow Academy Award winners Luise Rainer, Rod Steiger and Cliff Robertson. He could not find work equal to his talents, either due to his post-Oscar salary demands or a lack of perception in the industry that he truly was leading man material. He did not appear in Ojciec chrzestny III (1990), as the studio would not give in to his demands for a salary commensurate with that of Al Pacino, who was receiving $5 million to reprise Michael Corleone.\r\n\r\nHis greatest achievement in his immediate post-Oscar period was his triumphant characterization of grizzled Texas Ranger Gus McCrae in the TV mini-series Lonesome Dove (1989), for which he received an Emmy nomination. He received a second Emmy nomination and a Golden Globe for his portrayal of Soviet dictator Iosif Stalin in Stalin (1992), and a third Emmy nomination playing Nazi war criminal Adolf Eichmann in The Man Who Captured Eichmann (1996).\r\n\r\nThe shakeout of his career doldrums was that Duvall eventually settled back into his status as one of the premier character actors in the industry, rivaled only by his old friend Gene Hackman. Duvall, unlike Hackman, also has directed pictures, including the documentary We're Not the Jet Set (1977), Angelo My Love (1983) and Assassination Tango (2002). As a writer-director, Duvall gave himself one of his most memorable roles, that of the preacher on the run from the law in The Apostle (1997), a brilliant performance for which he received his third Best Actor nomination and fifth Oscar nomination overall. The film brought Duvall back to the front ranks of great actors, and was followed by a Best Supporting Actor Oscar nod for A Civil Action (1998).",
                            PlaceOfBirthCity = "San Diego, California",
                            PlaceOfBirthCountry = "United States of America",
                        },
                        new ActorModel()
                        {

                            FullName = "Diane Keaton", //20
                            DateOfBirth = new DateTime(1946, 1, 5),
                            ImageURL = "https://cdn.britannica.com/90/205790-050-2C5E5478/Diane-Keaton-2007.jpg",
                            Biography = "Diane Keaton was born Diane Hall in Los Angeles, California, to Dorothy Deanne (Keaton), an amateur photographer, and John Newton Ignatius \"Jack\" Hall, a civil engineer and real estate broker. She studied Drama at Santa Ana College, before dropping out in favor of the Neighborhood Playhouse in New York. After appearing in summer stock for several months, she got her first major stage role in the Broadway rock musical \"Hair\". As understudy to the lead, she gained attention by not removing any of her clothing. In 1968, Woody Allen cast her in his Broadway play \"Play It Again, Sam,\" which had a successful run. It was during this time that she became involved with Allen and appeared in a number of his films. The first one was Play It Again, Sam (1972), the screen adaptation of the stage play. That same year Francis Ford Coppola cast her as Kay in the Oscar-winning The Godfather (1972), and she was on her way to stardom. She reprized that role in the film's first sequel, The Godfather Part II (1974). She then appeared with Allen again in Sleeper (1973) and Love and Death (1975).\r\n\r\nIn 1977, she broke away from her comedy image to appear in the chilling Looking for Mr. Goodbar (1977), which won her a Golden Globe nomination. It was the same year that she appeared in what many regard as her best performance, in the title role of Annie Hall (1977), which Allen wrote specifically for her (her real last name is Hall, and her nickname is Annie), and what an impact she made. She won the Oscar and the British Award for Best Actress, and Allen won the Directors Award from the DGA. She started a fashion trend with her unisex clothes and was the poster girl for a lot of young males. Her mannerisms and awkward speech became almost a national craze. The question being asked, though, was, \"Is she just a lightweight playing herself, or is there more depth to her personality?\" For whatever reason, she appeared in but one film a year for the next two years and those films were by Allen. When they broke up she was next involved with Warren Beatty and appeared in his film Reds (1981), as the bohemian female journalist Louise Bryant. For her performance, she received nominations for the Academy Award and the Golden Globe. For the rest of the 1980s she appeared infrequently in films but won nominations in three of them. Attempting to break the typecasting she had fallen into, she took on the role of a confused, somewhat naive woman who becomes involved with Middle Eastern terrorists in The Little Drummer Girl (1984). To offset her lack of movie work, Diane began directing. She directed the documentary Heaven (1987), as well as some music videos. For television she directed an episode of the popular, but strange, Twin Peaks (1990).\r\n\r\nIn the 1990s, she began to get more mature roles, though she reprized the role of Kay Corleone in the third \"Godfather\" epic, The Godfather Part III (1990). She appeared as the wife of Steve Martin in the hit Father of the Bride (1991) and again in Father of the Bride Part II (1995). In 1993 she once again teamed with Woody Allen in Manhattan Murder Mystery (1993), which was well received. In 1995 she received high marks for Unstrung Heroes (1995), her first major feature as a director.",
                            PlaceOfBirthCity = "Los Angeles, California",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Andy Garcia", //21
                            DateOfBirth = new DateTime(1956, 4, 12),
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRi8KvoK_gxz4dQKdhVarjHdU6u5j-0WYTBVz0_cEqAFSrm82Mr90BWHm69iH0phneW-V0&usqp=CAU",
                            Biography = "One of Hollywood's most private and guarded leading men, Andy Garcia has created iconic characters while at the same time staying true to his acting roots and personal projects.\r\n\r\nGarcia was born Andrés Arturo García Menéndez on April 12, 1956, in Havana, Cuba, to Amelie Menéndez, a teacher of English, and René García Núñez, an attorney and avocado farmer. Garcia's family was relatively affluent. However, when he was two years old, Fidel Castro came to power, and the family fled to Miami Beach. Forced to work menial jobs for a while, the family started a fragrance company that was eventually worth more than a million dollars. He attended Natilus Junior High School and later at Miami Beach Senior High School. Andy was a popular student in school, a good basketball player and good-looking. He dreamed of playing professional baseball. In his senior year, though, he contracted mononucleosis and hepatitis, and unable to play sports, he turned his attention to acting.\r\n\r\nHe studied acting with Jay W. Jensen. Jensen was a South Florida legend, counting among his numerous students, Brett Ratner, Roy Firestone, Mickey Rourke, and Luther Campbell. Following his positive high school experiences in acting, he continued his drama studies at Florida International University.\r\n\r\nSoon, he was headed out to Hollywood. His first break came as a gang member on the very first episode of the popular TV series Hill Street Blues (1981). His role as a cocaine kingpin in 8 Million Ways to Die (1986) put him on the radar of Brian De Palma, who was casting for his gangster classic The Untouchables (1987). At first, he envisioned Garcia as Al Capone's sadistic henchman Frank Nitti, but fearing typecasting as a gangster, Garcia campaigned for the role of \"George Stone\", the Italian cop who gets accepted into Eliot Ness' famous band of lawmen. Garcia's next notable role came in Black Rain (1989) by acclaimed director Ridley Scott, as the partner of police detective Michael Douglas. He then co-starred with Richard Gere in Internal Affairs (1990), directed by Mike Figgis. In 1989, Francis Ford Coppola was casting for the highly anticipated third installment of his \"Godfather\" films. Ojciec chrzestny III (1990) included one of the most sought-after roles in decades, the hot-headed son of \"Sonny Corleone\" and mob protégé of \"Michael Corloene\", \"Vincent Mancini\". A plum role for any young rising star, the role was campaigned for by a host of actors. Val Kilmer, Alec Baldwin, Vincent Spano, Charlie Sheen, and even Robert De Niro (who wanted the role changed to accommodate his age) were all beaten out by the up-and-coming Garcia. His performance was Oscar-nominated as Best Supporting Actor, and secured him international stardom and a place in cinematic history. Now a leading man, he starred in such films as Jennifer 8 (1992) and Hero (1992). He won raves for his role as the husband of Meg Ryan in When a Man Loves a Woman (1994) and gave another charismatic gangster turn in Things to Do in Denver When You're Dead (1995). He then returned in Night Falls on Manhattan (1996), directed by Sidney Lumet, as well as portraying legendary mobster Lucky Luciano in Gangster (1997). In perhaps his most mainstream role, he portrayed a cop in the action film Desperate Measures (1998). Garcia then starred in a few lower-profile projects that didn't do much for his career, but things turned around in 2001, with the first of many projects being his role as a cold casino owner in Ocean's Eleven (2001), directed by Steven Soderbergh. Seeing his removal from Cuba as involuntary, Garcia is proud of his heritage which influences his life and work. One such case is his portrayal of renowned Cuban trumpet player Arturo Sandoval in For Love or Country: The Arturo Sandoval Story (2000). He is an extremely private man, and strong believer in old-fashioned chivalry. Married to his wife, Maria Victoria, since 1982, the couple has three daughters. One of the most talented leading men around, Garcia has had a unique career of staying true to his own ideals and thoughts on acting. While some would have used some of the momentum he has acquired at different points in his career to get rich off lightweight projects, Garcia has stayed true to stories and films that aspire to something more. But with a presence and style that never seem old, a respect from directors and film buffs, alike, Andy Garcia will be remembered for a long time in film history.",
                            PlaceOfBirthCity = "Havana",
                            PlaceOfBirthCountry = "Cuba"

                        },
                        new ActorModel()
                        {

                            FullName = "Macaulay Culkin", // 22
                            DateOfBirth = new DateTime(1980, 8, 26),
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCm-oeoiWvFYbqxjLE3FW4Ve6vLdZKECkQdLYjCcHTUAkA46lcP73n-VKlbb5bSv1ftgE&usqp=CAU",
                            Biography = "Macaulay Culkin, one of the most famous American child stars, was born on August 26, 1980 in New York City, New York, USA, as the third of seven children of his father Kit Culkin (a former stage and child actor and also Macaulay's former manager) and mother Patricia Brentrup. He is the brother of Shane Culkin, Dakota Culkin, Kieran Culkin, Quinn Culkin, Christian Culkin, and Rory Culkin, most of whom have also acted. Macaulay's mother, who is from North Dakota, is of German and Norwegian descent. Macaulay's father, from Manhattan, has Irish, German, English, Swiss-German, and French ancestry.\r\n\r\n\"Mack\", as he's known to his close friends and family, first came into showbiz at the age of 4, appearing in a string of Off-Broadway shows such as the New York City Ballet's The Nutcracker and, by 8 years-old, the films Rocket Gibraltar (1988) and See You in the Morning (1989), which included him in the rare company of kids who have received rave reviews from The New Yorker and The New York Times.\r\n\r\nBy the age of 9, the young actor had nearly upstaged star John Candy in Uncle Buck (1989) (his deadpan interrogation of Candy was Buck's funniest scene). Then, in 1990, writer John Hughes turned his finished Home Alone (1990) script over to director Chris Columbus with a suggestion to consider Culkin for the lead. Though Macaulay was the first kid Columbus saw, he was skeptical about having him in the lead and saw over 200 other possible actors and he admitted that no one came as close to being as good as Culkin. By the callback interview, Mack had memorized two scenes, and Columbus was sure he found his \"Kevin McCallister\". The movie grossed more than $285 million in the US alone, becoming one of the highest grossing movies of all time and making Macaulay Culkin one of the biggest movie stars of the time.\r\n\r\nHis next big project was My Girl (1991) in which he played \"Thomas J. Sennett\", a boy who seems to be allergic to everything. Despite some controversy over the ending, the film was released anyway and proved to be another hit film for Mack (and featured his very first kiss). In 1992 came Home Alone 2: Lost in New York (1992), which grossed more than $172 million in the US alone. In 1993 came The Good Son (1993), which was the first role to depart from his cute kid comedies. He played a murderous little demon named Henry. He got the role when his powerhouse negotiator/manager/father Kit Culkin said that he would pull Mack out of Home Alone 2: Lost in New York (1992) unless he was given the psychotic boy lead in The Good Son (1993). He was also given a salary of $5 million for the film.\r\n\r\nIn 1994, at the age of 14, came a string of duds, The Pagemaster (1994), Getting Even with Dad (1994) and Richie milioner (1994). He was paid $8 million for the last two, the highest salary ever paid for a child star. Many people believed Mack had lost his touch, though, because he was no longer that cute tiny kid they saw in Kevin sam w domu (1990). In 1995 his parents, who were never married, separated and started a greedy legal battle over the custody of their kids and Mack's fortune. In 1996, the young actor had reportedly said he wouldn't accept any roles until his parents settled their custody dispute. That case would not be resolved until April 1997 when Kit Culkin relinquished control to Brentrup.\r\n\r\nIn 1998, Macaulay married actress Rachel Miner, but separated in 2000 because Rachel wanted to start a family and Mack wanted to get back into acting. There has been a gap of eight years since 1994's Richie milioner (1994), and although he made a 'comeback' on stage in 2001, appearing in a London production of \"Madame Melville\", and also portrayed Michael Alig in Party Monster (2003); with an estimated fortune of $17 million he clearly never has to work again - if the roles don't appeal to him.",
                            PlaceOfBirthCity = "New York City, New York",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Joe Pesci", // 23
                            DateOfBirth = new DateTime(1943, 2, 9),
                            ImageURL = "https://cdn.gracza.pl/galeria/mdb/o/25168703.jpg",
                            Biography = "Compact Italian-American actor Joe Pesci was born February 9, 1943 in Newark, New Jersey, to Mary (Mesce), a part-time barber, and Angelo Pesci, a bartender and forklift driver. Pesci first broke into entertainment as a child actor, and by the mid-1950s, was starring on the series \"Star Time Kids\". In the mid-1960s, he released a record under the stage name Joe Ritchie titled \"Little Joe Sure Can Sing\", and was also playing guitar with several bands, including Joey Dee and The Starliters. He even joined with his friend Frank Vincent to start a vaudeville-style comedy act, but met with limited success (interestingly, Pesci and Vincent would later go on to co-star in several gangster films together, including Goodfellas (1990) and Casino (1995).\r\n\r\nPesci's first film role was as an uncredited dancer in Hey, Let's Twist! (1961) and then he had to wait another 15 years for a minor role in The Death Collector (1976). His work in the second film was seen by Robert De Niro, who convinced director Martin Scorsese to cast him as Joey LaMotta in the epic boxing film Raging Bull (1980), which really got him noticed in Hollywood. He played opposite Rodney Dangerfield in Easy Money (1983), was with buddy DeNiro again in Once Upon a Time in America (1984), nearly stole the show as con man Leo Getz in Lethal Weapon 2 (1989) and scored a Best Supporting Actor Oscar playing the psychotic Tommy DeVito in Goodfellas (1990).\r\n\r\nHis comedic talents shone again in the mega-popular Kevin sam w domu (1990), and he put in a terrific performance as co-conspirator David Ferrie in JFK (1991). Pesci was back again as Leo Getz for Lethal Weapon 3 (1992), and was still a bumbling crook in Kevin sam w Nowym Jorku (1992), and had a minor role in the Robert De Niro-directed A Bronx Tale (1993). He was lured back by Scorsese to play another deranged gangster named Nicky (based on real-life hood Tony Spilotro [aka \"The Ant\"]) in the violent Casino (1995), and starred in the comedies 8 Heads in a Duffel Bag (1997) and Gone Fishin' (1997), although both failed to fire at the box office.\r\n\r\nPesci returned again as fast-talking con man Leo Getz in Lethal Weapon 4 (1998). In 1999, he announced his retirement from acting and since then, he appeared only occasionally in films, including a cameo appearance in The Good Shepherd (2006). He also appeared in the music documentary I Go Back Home: Jimmy Scott (2016).",
                            PlaceOfBirthCity = "Newark, New Jersey",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Daniel Stern", // 24
                            DateOfBirth = new DateTime(1957, 8, 28),
                            ImageURL = "https://vodflix.tv/images/people/11511.jpg",
                            Biography = "Daniel Stern was born in Bethesda, Maryland, to a social worker father and a day care manager mother. He has been acting professionally since the age of seventeen. Following his high school graduation, he auditioned for the Washington Shakespeare Festival seeking a job as a lighting engineer but ended up as \"a strolling player with a lute\" in their production of \"As You Like It.\" Shortly thereafter, he made his way to New York where he \"took a couple of acting lessons\" and began to assemble an impressive portfolio of such off-Broadway credits as \"Split,\" \"Frankie and Annie,\" \"The Mandrake,\" and \"The Old Glory.\" In addition, director Peter Yates cast him as one of the four Indiana teenagers in the highly acclaimed film Breaking Away (1979). Variety in acting roles appeals to Stern. Following \"Breaking Away,\" he appeared in Woody Allen's Stardust Memories (1980), Claudia Weill's It's My Turn (1980) and John Schlesinger's Honky Tonk Freeway (1981) before returning to New York to appear off-Broadway in the two character play \"How I Got That Story,\" which led to critical acclaim and a starring role in Barry Levinson's Diner (1982). Other film credits include I'm Dancing as Fast as I Can (1982), Blue Thunder (1983), Hannah and Her Sisters (1986), The Boss' Wife (1986), The Milagro Beanfield War (1988), Born in East L.A. (1987) and D.O.A. (1988) In addition to his voice-over work on the series, Stern directed several episodes of the popular and critically acclaimed television comedy, The Wonder Years (1988).",
                            PlaceOfBirthCity = "Bethesda, Maryland",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Jack Nicholson", // 25
                            DateOfBirth = new DateTime(1937, 4, 22),
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Jack_Nicholson_2001.jpg/640px-Jack_Nicholson_2001.jpg",
                            Biography = "ack Nicholson, an American actor, producer, director and screenwriter, is a three-time Academy Award winner and twelve-time nominee. Nicholson is also notable for being one of two actors - the other being Michael Caine - who have received an Oscar nomination in every decade from the '60s through the '00s.\r\n\r\nNicholson was born on April 22, 1937, in Neptune, New Jersey. He was raised believing that his grandmother was his mother, and that his mother, June Frances Nicholson, a showgirl, was his older sister. He discovered the truth in 1975 from a Time magazine journalist who was researching a profile on him. His real father is believed to have been either Donald Furcillo, an Italian American showman, or Eddie King (Edgar Kirschfeld), born in Latvia and also in show business. Jack's mother's ancestry was Irish, and smaller amounts of English, German, Scottish, and Welsh.\r\n\r\nNicholson made his film debut in a B-movie titled The Cry Baby Killer (1958). His rise in Hollywood was far from meteoric, and for years, he sustained his career with guest spots in television series and a number of Roger Corman films, including The Little Shop of Horrors (1960).",
                            PlaceOfBirthCity = "Neptune, New Jersey",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Shelley Duvall", // 26
                            DateOfBirth = new DateTime(1949, 7, 7),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNjE4MTY1Mzk0N15BMl5BanBnXkFtZTgwOTQzNDE2MDE@._V1_.jpg",
                            Biography = "Shelley Alexis Duvall was born in Fort Worth, Texas, the first child to Bobbie Ruth (Massengale, 1929-2020), a real estate broker, and Robert Richardson Duvall (1919-1994), a lawyer. At the time of her birth, her mother was visiting her grandmother in Fort Worth, though Duvall was raised in Houston. During her childhood, Shelley's mother humorously gave Shelley the nickname \"Manic Mouse\", because she would often run around her house and tip over furniture. Shelley however was more than a mouse, but rather quite the little artist. Her favorite thing to do when she was very young was draw. She also has three brothers: Scott, Shane, and Stewart.\r\n\r\nShelley graduated from Waltrip High School in Texas and at first became a cosmetics salesperson. It was in 1970 when Shelley was discovered by talent scouts at a local party. Director Robert Altman wanted to cast Shelley in a film that he was making during the time. Shelley had experience in acting in high school plays at the time and took Altman's offer and she appeared in her first film Brewster McCloud. Altman was so fascinated by her performance that she appeared in his next films including: McCabe and Mrs. Miller in 1971, Thieves Like Us in 1974, and Nashville in 1975. Aside from these three successful films, Duvall's acting blossomed in her leading role as Mille Lammoroux in 3 Women in 1977. Duvall's acting was so superb that she won Best Actress at the 1977 Cannes Film Festival. Shelley also starred as Bernice in Joan Micklin Silver's Bernice Bobs Her Hair in 1976, and had a cameo in Woody Allen's Annie Hall in 1977. In the same year, Shelley also hosted an episode of Saturday Night Live.\r\n\r\nWhen the 1980s hit, Duvall's career was just beginning. She is famously known for playing the role of \"Wendy Torrance\" in Stanley Kubrick's The Shining with Jack Nicholson. During the making of this film, Kubrick psychologically tormented Duvall, causing her immense stress and affecting her mental state. He would often ignore her entirely during filming or would put in her situations which caused her immense fear and distress. The most obvious example is when Kubrick shot the famous \"baseball bat scene\" with Duvall and Nicholson 127 times, which is the world record for most number of takes in any film set.\r\n\r\nIn January of 1979, Robert Altman would offer Duvall yet another role in one of his films. Only the role was a certain role that Altman believed she was born to play. That certain role was \"Olive Oyl\" in the real life version of Popeye. Shelley was skeptical at first on accepting the role, due to bad memories as a child of negatively being called \"Olive Oyl\" in grade school. She fortunately decided to take the role and performed admirably. Shelley also sings several songs in this film. The most famous ones would be \"He's Large\" and \"He Needs Me\" which also appeared in the film Punch Drunk Love.",
                            PlaceOfBirthCity = "Houston, Texas",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Danny Lloyd", // 27
                            DateOfBirth = new DateTime(1972, 10, 13),
                            ImageURL = "https://www.themoviedb.org/t/p/w500/1wDA4ePrWnCX4T6aJpnFqQRa3Xk.jpg",
                            Biography = "Danny Lloyd was selected for the role of Danny Torrance in Stanley Kubrick's The Shining (1980) because of his ability to concentrate for extended periods of time. Because of his age (6) and the genre of The Shining (1980) Danny was closely guarded by Kubrick during filming and didn't know it was a horror film until several years later. Despite his notoriety and his famous line \"Redrum! Redrum!\" Danny made only one more film and stated that he wasn't interested in an acting career.",
                            PlaceOfBirthCity = "Chicago, Illinois",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "Neve Campbell", // 28
                            DateOfBirth = new DateTime(1973, 10, 3),
                            ImageURL = "https://publish.purewow.net/wp-content/uploads/sites/2/2022/12/Neve-Campbell-Black-Shiny-Dress-CAT.jpg?resize=720%2C780",
                            Biography = "Neve Campbell was born and raised in Guelph, Ontario, to Marnie (Neve), a Dutch-born psychologist and yoga instructor (from Amsterdam), and Gerry Campbell, a Scottish-born teacher (from Glasgow). Campbell first came to our TV screens in the hit Drama series Party of Five (1994). Described as TV's most believable teenager, her first major film role came in the form of innocent victim \"Sidney Prescott\" in Scream (1996), the film which re-defined the slasher genre.\r\n\r\nShe joined the cast of the acclaimed series House of Cards In 2016, playing Leann Harvey, shortly after in 2018 she starred opposite Dwayne Johnson in the action movie Skyscraper.\r\n\r\nMany film offers came Neve's way but, as she was filming Party of Five (1994) for nine months of the year, the filming schedules often clashed. So in 2000, she announced that she was to leave the award-winning show to concentrate on a film career. Working in many genres, her film credits include the romantic comedy Three to Tango (1999) alongside Matthew Perry. She is an animal lover and describes herself as having a dry, often offensive sense of humor.",
                            PlaceOfBirthCity = "Guelph, Ontario",
                            PlaceOfBirthCountry = "Canada"

                        },
                        new ActorModel()
                        {

                            FullName = "Courteney Cox", // 29
                            DateOfBirth = new DateTime(1964, 6, 15),
                            ImageURL = "https://fwcdn.pl/ppo/00/23/23/450031.3.jpg",
                            Biography = "Courteney Cox was born on June 15th, 1964 in Birmingham, Alabama, into an affluent Southern family. She is the daughter of Courteney (Bass) and Richard Lewis Cox (1930-2001), a businessman. She was the baby of the family with two older sisters (Virginia and Dottie) and an older brother, Richard, Jr. She was raised in an exclusive society town, Mountain Brook, Alabama. Courteney was the archetypal daddy's girl, and therefore was understandably devastated when, in 1974, her parents divorced, and her father moved to Florida.\r\n\r\nShe became a rebellious teen, and did not make things easy for her mother, and new stepfather, New York businessman Hunter Copeland. Now, she is great friends with both. She attended Mountain Brook High School, where she was a cheerleader, tennis player and swimmer. In her final year, she received her first taste of modeling. She appeared in an advert for the store, Parisians. Upon graduation, she left Alabama to study architecture and interior design at Mount Vernon College. After one year she dropped out to a pursue a modeling career in New York, after being signed by the prestigious Ford Modelling Agency. She appeared on the covers of teen magazines such as Tiger Beat and Little Miss, plus numerous romance novels. She then moved on to commercials for Maybeline, Noxema, New York Telephone Company and Tampax.\r\n\r\nWhile modeling, she attended acting classes, as her real dream and ambition was to be an actress. In 1984, she landed herself a small part in one episode of As the World Turns (1956) as a young débutante named Bunny. Her first big break, however, was being cast by Brian De Palma in the Bruce Springsteen video \"Dancing in The Dark\". In 1985, she moved to LA to star alongside Dean Paul Martin in Misfits of Science (1985). It was a flop, but a few years later, she was chosen out of thousands of hopefuls to play Michael J. Fox's girlfriend, psychology major Lauren Miller in Family Ties (1982).\r\n",
                            PlaceOfBirthCity = "Birmingham, Alabama",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "David Arquette", // 30
                            DateOfBirth = new DateTime(1971, 9, 8),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjEzODYyNjg3NV5BMl5BanBnXkFtZTcwMzYwOTgyNg@@._V1_.jpg",
                            Biography = "The youngest of five, David Arquette was born in Winchester, Virginia and is part of the illustrious Arquette family, whose work has spread over several generations. His parents, Lewis Arquette, an actor, and Brenda Denaut (née Nowak), an acting teacher and therapist, had 4 other children: Rosanna Arquette, Richmond Arquette, Patricia Arquette, and Alexis Arquette, all actors. His paternal grandfather, Cliff Arquette, was also an entertainer. David's mother was from an Ashkenazi Jewish family (from Poland and Russia), while David's father had French-Canadian, Swiss-German, and English ancestry.\r\n\r\nLike his siblings, Arquette started working at an early age, and his first major role came as Luke Perry's character's best friend in the hit film Buffy the Vampire Slayer (1992). But his major break both personally and professionally didn't come until 1996 when he was cast in the slasher flick Scream (1996) starring opposite close friend Drew Barrymore, Neve Campbell and more importantly Friends (1994), with Courteney Cox who he married in San Francisco in the summer of 1999. Scream (1996) earned worldwide success and acclaim as did Arquette for his role as lovable simple cop \"Dewey\". His role proved to be so popular that in the original script his character was meant to die, but due to test audiences response to Dewey the script was changed and he returned for both Scream 2 (1997) and Scream 3 (2000). Usually known for his goofiness in more mainstream roles, his greatest performances and reviews have come for his indie films such as Johns (1996), Dream with the Fishes (1997) and The Grey Zone (2001). David and wife Courteney Cox reside in LA and produce their own DIY show Mix It Up (2003) because of their love for home improvement.",
                            PlaceOfBirthCity = "Winchester, Virginia",
                            PlaceOfBirthCountry = "United States of America",

                        },
                        new ActorModel()
                        {

                            FullName = "James Stewart", // 31
                            DateOfBirth = new DateTime(1908, 5, 20),
                            ImageURL = "https://spokeo.pl/storage/profile/h632/6ddAOltmbCHIJKdZZwys9nDfuEx.jpg",
                            Biography = "James Maitland Stewart was born on May 20, 1908, in Indiana, Pennsylvania, to Elizabeth Ruth (Johnson) and Alexander Maitland Stewart, who owned a hardware store. He was of Scottish, Ulster-Scots, and some English descent. Stewart was educated at a local prep school, Mercersburg Academy, where he was a keen athlete (football and track), musician (singing and accordion playing), and sometime actor.\r\n\r\nIn 1929, he won a place at Princeton University, where he studied architecture with some success and became further involved with the performing arts as a musician and actor with the University Players. After graduation, engagements with the University Players took him around the northeastern United States, including a run on Broadway in 1932. But work dried up as the Great Depression deepened, and it was not until 1934, when he followed his friend Henry Fonda to Hollywood, that things began to pick up.\r\n",
                            PlaceOfBirthCity = "Indiana, Pennsylvania",
                            PlaceOfBirthCountry = "United States of America",
                            DateOfDeath = new DateTime(1997, 7, 2)
                            

                        },
                        new ActorModel()
                        {

                            FullName = "Donna Reed", // 32
                            DateOfBirth = new DateTime(1921, 1, 27),
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/9/93/DOnnaREed.jpg",
                            Biography = "Donna Reed was born in the midwestern town of Denison, Iowa, on January 27, 1921, as Donna Belle Mullenger. A small town - a population of less than 3,000 people - Denison was located by the Boyer River, and was the county seat of Crawford County. Donna grew up as a farm girl, much like many young girls in western Iowa, except for one thing - Donna was very beautiful. That wasn't to say that others weren't as pretty, it's just that Donna's beauty stood out from all the other local girls, so much so that she won a beauty contest in Denison. Upon graduation from high school Donna left for college in Los Angeles, in the hopes of eventually entering movies. While at Los Angeles City College, she pursued her dream by participating in several college stage productions. In addition to the plays, she also won the title of Campus Queen. At one of those stage plays Donna was spotted by an MGM talent scout and was signed to a contract. Her first film was a minor role in MGM's The Get-Away (1941). That was followed by a small part in Babes on Broadway (1941), with Mickey Rooney and Judy Garland as a secretary. Afterwards, MGM began giving her better parts, in films such as The Bugle Sounds (1942), The Courtship of Andy Hardy (1942) and The Man from Down Under (1943). In 1944 she received second billing playing Carol Halliday in See Here, Private Hargrove (1944), a comedy about a reporter drafted into the army who eventually meets up with Donna's character as a worker in the canteen. The following year Donna starred in The Picture of Dorian Gray (1945), her best role to date. It was a love story set in London in 1890. It got mixed critical reviews but did well at the box-office. Donna was now one of the leading ladies of Hollywood. In 1946 she starred in what is probably her best-known role, as the wife of James Stewart in the classic Życie jest cudowne (1946). This timeless story is a holiday staple to this day. The film also starred Lionel Barrymore and Thomas Mitchell. The next year Donna starred as Ann Daniels in Paramount's Beyond Glory (1948) with Alan Ladd, which did well at the box-office. Her next role was the strongest she had had yet--Chicago Deadline (1949), again with Ladd. It was one of the best mystery dramas to come out of Hollywood in a long time, and did very well at the box office. As the 1940s faded out and the 1950s stormed in, Donna's roles got bigger but were mainly of the wholesome, girl-next-door type. In 1953, however, she starred as the hostess Alma in the widely acclaimed From Here to Eternity (1953). She was so good in that film she was nominated for and won the Academy Award for Best Supporting Actress, beating out such veterans as Thelma Ritter and Marjorie Rambeau. The film itself won for Best Picture and remains a classic to this day. Later that year Donna starred in The Caddy (1953), a comedy with Jerry Lewis and Dean Martin. Three years later she landed the role of Sacajawea in The Far Horizons (1955), the story of the Lewis and Clark Expedition, starring Charlton Heston and Fred MacMurray. After finishing The Whole Truth (1958), Donna began her own TV series (produced by her husband), The Donna Reed Show (1958), a hit that ran for eight years. She was so effective in the show that she was nominated for TV's prestigious Emmy Award as Best Actress every year from 1959-1962. She was far more popular in TV than on the screen. After the run of the program, Donna took some time away from show business before coming back in a couple of made-for-TV movies (in 1974, she had made a feature called Welcome to Arrow Beach (1973), but it was never released). She did get the role of Ellie Ewing Farlow in the hit TV series Dallas (1978) during the 1984-85 season. It was to be her final public performance. On January 14, 1986, less than two weeks before her 65th birthday, she died of pancreatic cancer in Beverly Hills, California. Grover Asmus, her husband, created the Donna Reed Foundation for the Performing Arts in her hometown of Denison. The foundation helps others who desire a career in the arts. Donna never forgot her roots. She was still a farm girl at heart.",
                            PlaceOfBirthCity = "Denison, Iowa",
                            PlaceOfBirthCountry = "United States of America",
                            DateOfDeath = new DateTime(1986, 1, 14)
                            

                        },
                        new ActorModel()
                        {

                            FullName = "Lionel Barrymore", // 33
                            DateOfBirth = new DateTime(1878, 4, 28),
                            ImageURL = "https://m.media-amazon.com/images/I/51PCUDAmr8L._AC_SY1000_.jpg",
                            Biography = "Famed actor, composer, artist, author and director. His talents extended to the authoring of the novel \"Mr. Cartonwine: A Moral Tale\" as well as his autobiography. In 1944, he joined ASCAP, and composed \"Russian Dances\", \"Partita\", \"Ballet Viennois\", \"The Woodman and the Elves\", \"Behind the Horizon\", \"Fugue Fantasia\", \"In Memorium\", \"Hallowe'en\", \"Preludium & Fugue\", \"Elegie for Oboe, Orch.\", \"Farewell Symphony (1-act opera)\", \"Elegie (piano pieces)\", \"Rondo for Piano\" and \"Scherzo Grotesque\".",
                            PlaceOfBirthCity = "Philadelphia, Pennsylvania",
                            PlaceOfBirthCountry = "United States of America",
                            DateOfDeath = new DateTime(1954, 11, 15)

                        },
                        new ActorModel()
                        {

                            FullName = "test", // 34
                            DateOfBirth = new DateTime(1940, 3, 26),
                            ImageURL = "https://ijp.pan.pl/wp-content/uploads/2020/04/test.jpg",
                            Biography = "test",
                            PlaceOfBirthCity = "test",
                            PlaceOfBirthCountry = "test"

                        },
                    });
                    context.SaveChanges();
                }

                // producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<ProducerModel>()
                    {
                        new ProducerModel()
                        {
                            FullName = "Steven Spielberg", //1
                            DateOfBirth = new DateTime(1946, 12, 18),
                            Biography = "One of the most influential personalities in the history of cinema, Steven Spielberg is Hollywood's best known director and one of the wealthiest filmmakers in the world. He has an extraordinary number of commercially successful and critically acclaimed credits to his name, either as a director, producer or writer since launching the summer blockbuster with Jaws (1975), and he has done more to define popular film-making since the mid-1970s than anyone else.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTY1NjAzNzE1MV5BMl5BanBnXkFtZTYwNTk0ODc0._V1_.jpg",
                            PlaceOfBirthCity = "Cincinnati, Ohio",
                            PlaceOfBirthCountry = "United States of America"
                        },
                        new ProducerModel()
                        {
                            FullName = "Lana Wachowski", //2
                            DateOfBirth = new DateTime(1965, 6, 21),
                            Biography = "Born to mother Lynne, a nurse, and father Ron, a businessman of Polish descent, Wachowski grew up in Chicago and formed a tight creative relationship with her sister Lilly. After the siblings dropped out of college, they started a construction business and wrote screenplays. Their 1995 script, Assasins(1995), was made into a movie, leading to a Warner Bros contract. After that time, the Wachowskis devoted themselves to their movie careers. In 2012, during interviews for Cloud Atlas and in her acceptance speech for the Human Rights Campaign's Visibility Award, Lana spoke about her experience of being a transgender woman, sacrificing her much cherished anonymity out of a sense of responsibility. Lana is known to be extremely well-read, loves comic books and exploring ideas of imaginary worlds, and was inspired by Stanley Kubrick's 2001: A Space Odyssey (1968) in creating Cloud Atlas.",
                            ImageURL = "https://vodflix.tv/images/people/9340.jpg",
                            PlaceOfBirthCity = "Chicago, Illinois",
                            PlaceOfBirthCountry = "United States of America"
                        },
                        new ProducerModel()
                        {
                            FullName = "Andrew Adamson", //3
                            DateOfBirth = new DateTime(1966, 12, 1),
                            Biography = "Andrew Adamson was born on December 1, 1966 in Auckland, New Zealand. He is a producer and director, known for Shrek 2 (2004), Shrek (2001) and The Chronicles of Narnia: The Lion, the Witch and the Wardrobe (2005). He has been married to Gyulnara Karaeva since January 16, 2016. He was previously married to Nikki Donald.",
                            ImageURL = "https://cdn.gracza.pl/galeria/mdb/o/460475593.jpg",
                            PlaceOfBirthCity = "Auckland",
                            PlaceOfBirthCountry = "New Zealand"
                        },
                        new ProducerModel()
                        {
                            FullName = "Chris Miller", //4
                            DateOfBirth = new DateTime(1968, 1, 20),
                            Biography = "Chris Miller is an American film director, storyboard artist, and voice actor best known for his work with DreamWorks Animation. Following a stint working with Ralph Bakshi on his film Cool World (1992), he would begin his career at DreamWorks as a storyboard artist on films Antz (1998) and Shrek (2001) before being promoted to head of story on Shrek 2 (2004). This led to him becoming the director of two subsequent entries in the franchise, those being Shrek the Third (2007) and Puss in Boots (2011). Miller is also known for his role as Kowalski in the Madagascar film series (except for The Penguins of Madagascar (2008), where he was voiced by Jeff Bennett instead), and has voiced numerous characters in other DreamWorks movies.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTg4MDQ3MjE3MV5BMl5BanBnXkFtZTcwOTc1MDY0Nw@@._V1_.jpg",
                            PlaceOfBirthCity = "Washington D.C.",
                            PlaceOfBirthCountry = "United States of America"
                        },
                        new ProducerModel()
                        {
                            FullName = "Mike Mitchell", //5
                            DateOfBirth = new DateTime(1970, 10, 18),
                            Biography = "Mike Mitchell was born in Oklahoma city to parents, Robert Mitchell, and Julia Baker. He graduated from Putnam City North High School, having been deeply involved with their arts programs. He then left behind his small town and moved to Las Angeles to attend the California Institute of the Arts. During his time in college, animators were in high demand. This led him into television, working for distinguished film makers such as Tim Burton and Spike Jonze.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjMwNDkwNTcyN15BMl5BanBnXkFtZTgwODA1NjU4MDI@._V1_.jpg",
                            PlaceOfBirthCity = "Oklahoma City, Oklahoma",
                            PlaceOfBirthCountry = "United States of America"
                        },
                        new ProducerModel()
                        {
                            FullName = "Chris Columbus", //6
                            DateOfBirth = new DateTime(1958, 9, 10),
                            Biography = "Born in Pennsylvania and raised in Ohio, Chris Columbus was first inspired to make movies after seeing \"The Godfather\" at age 15. After enrolling at NYU film school, he sold his first screenplay (never produced) while a sophomore there. After graduation Columbus tried to sell his fourth script, \"Gremlins\", with no success, until Steven Spielberg optioned it; Columbus moved to Los Angeles for a year during rewrites on the project in Spielberg's bungalow at Universal. After writing two more scripts for Spielberg, \"The Goonies\" and \"Young Sherlock Holmes\", Columbus' own directing career was launched a few years later with \"Adventures in Babysitting\". He is best known to audiences as the director of the runaway hit \"Home Alone\", written and produced by John Hughes its sequel \"Home Alone 2\", and most recently \"Mrs. Doubtfire\".",
                            ImageURL = "https://static.wikia.nocookie.net/disney/images/1/14/Chris_Columbus.jpg/revision/latest?cb=20180817162633",
                            PlaceOfBirthCity = "Spangler, Pennsylvania",
                            PlaceOfBirthCountry = "United States of America"
                        },
                        new ProducerModel()
                        {
                            FullName = "Alfonso Cuarón", //7
                            DateOfBirth = new DateTime(1961, 11, 28),
                            Biography = "Alfonso Cuarón Orozco was born on November 28th 1961 in Mexico City, Mexico. From an early age, he yearned to be either a film director or an astronaut. However, he did not want to enter the army, so he settled for directing. He didn't receive his first camera until his twelfth birthday, and then immediately started to film everything he saw, showing it afterwards to everyone. In his teen years, films were his hobby. Sometimes he said to his mother he would go to a friend's home, when in fact he would go to the cinema. His ambition was to know every theatre in the city. Near his house there were two studios, Studios Churubusco and Studios 212. After finishing school, Cuarón decided to study cinema right away. He tried to study at C.C.C. (Centro de Capacitación Cinematográfica) but wasn't accepted because at that time they weren't accepting students under twenty-four years old. His mother didn't support that idea of cinema, so he studied philosophy in the morning and in the afternoon he went to the C.U.E.C. (Centro Universitario de Estudios Cinematográficos). During that time he met many people who would later become his collaborators and friends. One of them was Luis Estrada. Cuaron also became good friends with Carlos Marcovich and Emmanuel Lubezki. Luis Estrada directed a short called \"Vengance is Mine\", on which Alfonso and Emmanuel collaborated. The film was in English, a fact which bothered many teachers of the C.U.E.C. such as Marcela Fernández Violante. The disagreement caused such arguments that in 1985, Alfonso was expelled from the university.\r\n\r\nDuring his time studying at C.U.E.C. he met Mariana Elizondo, and with her he had his first son, Jonás Cuarón. After Alfonso was expelled, he thought he could never be a director and so went on to work in a Museum so he could sustain his family. One day, José Luis García Agraz and Fernando CáMara went to the museum and made an offer to Cuarón. They asked him to work as cable person in \"La víspera (1982)\", a job which was to prove to be his salvation. After that he was assistant director in Garcia Agraz's \"Nocaut (1984)\", as well as numerous other films.\r\n\r\nHe was also second unit director in \"Gaby: Historia prawdziwa (1987)\", and co-wrote and directed some episodes in the series \"A Hora Marcada (1967)\". One New Year's Eve, he decided he would not continue to be an assistant director, and with his brother Carlos started writing what would be his first feature film: \"Sólo con tu pareja (1991)\" (Love in the time of Hysteria). After the screenplay was written, the problem became how to get financial backing for the movie. I.M.C.I.N.E. (Instituto Mexicano de Cinematografia), which supports movies financially, had already decided which projects it would support that year, much to Alfonso's initial chagrin. However, the director of one of those already-chosen projects was unable to direct it, so his project was canceled, and \"Sólo con tu pareja\" took its place. Despite this being chosen, there was a lot of tension between Alfonso and the I.M.C.I.N.E. executives. Nevertheless, after the movie was finished, it was a huge success. In Toronto festival the films won many awards, and Alfonso started to be noticed by Hollywood producers. Sydney Pollack was the first one to invite him to shoot in Hollywood. He proposed a feature film to be directed by Alfonso, but the project didn't work and was canceled. Alfonso moved to Los Angeles without anything concrete, and stayed with some friends, as he had no money. Soon after that, Pollack called him again to direct an episode called \"Fallen Angels: Murder, Obliquely (1993)\" of the series \"Fallen Angels (1993)\", that was the first job he had in U.S., and also the first time he worked with Alan Rickman.\r\n\r\nAfter a while, and no real directing jobs, Alfonso wanted to direct something as he needed money. He finally signed a contract with Warner Brothers to direct the film Addicted to Love (1995). However, one night, he read the screenplay for another film, A Little Princess (1995) and fell in love with it. He talked to Warner Brothers and after some meetings he gave up directing \"Addicted to Love\" in order to do \"A Little Princess\". Even thought it wasn't a great box office success, the film received two nominations for the Oscars, and won many other awards. After \"A Little Princess\" Alfonso developed a project with Richard Gere starring. The project was canceled, but Cuarón got an offer from Twentieth Century Fox to direct the modern adaptation of the Charles Dickens' classic Wielkie nadzieje (1998). He initially didn't want to direct it but the studio insisted, and in the end he accepted it. The experience was very painful and difficult for him mainly because there was never a definitive screenplay.\r\n\r\nHe then reunited with producer Jorge Vergara and founded both Anhelo Productions and Moonson Productions. Anhelo's first picture was also Alfonso's next film, the erotic road movie \"Y tu mamá también (2001)\", which was a huge success. During the promotion of the film in Venice, Alfonso met the cinema critic Annalisa Bugliani. They started dating and married that same year. \"Children of Men (2006)\" was to be Alfonso's next film, a futuristic, dystopian story. During the pre-production of the film, Warner Brothers invited Alfonso to direct the third Harry Potter film, \"Harry Potter and the Prisoner of Azkaban (2004)\", an offer which he accepted after some consideration. The film would prove to be the greatest box office success of his career.\r\n\r\nIn 2003, he had a daughter named Tess Bu Cuarón, and in February 2005 another son, called Olmo Teodoro Cuarón. Alfonso Cuarón signed a three-year first-look deal with Warner Brothers, which allowed his films to be distributed world-wide. He directed one five-minute segment of the anthology film Paris, je t'aime (2006) with Nick Nolte and Ludivine Sagnier. His next project, the futuristic film Children of Men (2006) with Clive Owen, Julianne Moore and Michael Caine premiered at the Venice Film Festival in 2006 having been nominated for three Academy Awards. After his youngest son was diagnosed with autism and the divorce from Annalisa Bugliani he took a break from directing and settled in London where he plans to work on his next projects.\r\n\r\nIn 2013, Alfonso directed the space thriller Gravity (2013), which would go win 7 academy awards.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Alfonso_Cuar%C3%B3n%2C_President_jury_Venezia_72_%2825805089406%29_%28cropped%29.jpg",
                            PlaceOfBirthCity = "Mexico City, Distrito Federal",
                            PlaceOfBirthCountry = "Mexico"
                        },
                        new ProducerModel()
                        {
                            FullName = "Mike Newell", //8
                            DateOfBirth = new DateTime(1942, 3, 28),
                            Biography = "Attended Cambridge University. Three year training course at Granada Television, with intention of going into theatre. Graduated to directing TV plays, building strong reputation for work with David Hare, David Edgar, Hohn, John Osborne, Jack Rosenthal.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTgzNDI1ODc4N15BMl5BanBnXkFtZTYwNjg3NTc1._V1_.jpg",
                            PlaceOfBirthCity = "St. Albans, Hertfordshire",
                            PlaceOfBirthCountry = "England, UK"
                        },  
                        new ProducerModel()
                        {
                            FullName = "David Yates", //9
                            DateOfBirth = new DateTime(1963, 10, 8),
                            Biography = "David Yates was born on October 8, 1963 in St. Helens, Merseyside, England, UK. He is a director and producer, known for Harry Potter and the Order of the Phoenix (2007), Harry Potter and the Deathly Hallows: Part 2 (2011) and The Legend of Tarzan (2016).",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTY2NTU4NjY4M15BMl5BanBnXkFtZTYwNjIxOTI1._V1_.jpg",
                            PlaceOfBirthCity = "St. Helens, Merseyside",
                            PlaceOfBirthCountry = "England, UK"
                        },
                        new ProducerModel()
                        {
                            FullName = "Peter Jackson", //10
                            DateOfBirth = new DateTime(1961, 10, 31),
                            Biography = "Sir Peter Jackson made history with The Lord of the Rings trilogy, becoming the first person to direct three major feature films simultaneously. The Fellowship of the Ring, The Two Towers and The Return of the King were nominated for and collected a slew of awards from around the globe, with The Return of the King receiving his most impressive collection of awards. This included three Academy Awards® (Best Adapted Screenplay, Best Director and Best Picture), two Golden Globes (Best Director and Best Motion Picture-Drama), three BAFTAs (Best Adapted Screenplay, Best Film and Viewers' Choice), a Directors Guild Award, a Producers Guild Award and a New York Film Critics Circle Award.\r\n\r\nAs a follow up to The Lord of the Rings trilogy, in 2005, Jackson directed, wrote, and produced King Kong, for Universal Pictures. The film grossed over $500 million and won three Oscars®.\r\n\r\nJackson previously received widespread acclaim for his 1994 feature Heavenly Creatures, which received an Academy Award® nomination for Best Screenplay. Other film credits include The Frighteners, starring Michael J. Fox; the adult puppet feature Meet the Feebles; and Braindead, which won 16 international science fiction awards, including the Saturn. Jackson also co-directed the television documentary Forgotten Silver, which also hit the film festival circuit.\r\n\r\nJackson directed the Academy Award®-nominated The Lovely Bones, an adaptation of the acclaimed best-selling novel by Alice Sebold and produced the worldwide sci-fi hit District 9. He was a producer on Steven Spielberg's The Adventures of Tintin: The Secret of the Unicorn in 2011, with two more films set to come out in the future.\r\n\r\nHis most recent films include producer of 2018's action film Mortal Engines, based on a post-apocalyptic world where cities ride on wheels and consume each other to survive. Following Mortal Engines, he produced They Shall Not Grow Old, a documentary on World War I with never-before-seen footage. BAFTA nominated the film for Best Documentary, and it won the award for Outstanding Achievement in Sound Editing from the Motion Picture Sound Editors.\r\n\r\nJackson's next project is the music documentary The Beatles: Get Back, which he directed and produced, due to be released August, 2021.\r\n\r\nJackson works closely with partner Dame Fran Walsh, with whom he shares his writing and producing credits, as well as a family. Jackson has a special interest in WWI memorabilia and is the proud owner of several aircraft from that era.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Peter_Jackson_SDCC_2014.jpg/800px-Peter_Jackson_SDCC_2014.jpg",
                            PlaceOfBirthCity = "Pukerua Bay, North Island",
                            PlaceOfBirthCountry = "New Zealand"
                        },  
                        new ProducerModel()
                        {
                            FullName = "Francis Ford Coppola", //11
                            DateOfBirth = new DateTime(1939, 4, 7),
                            Biography = "Francis Ford Coppola was born in 1939 in Detroit, Michigan, but grew up in a New York suburb in a creative, supportive Italian-American family. His father, Carmine Coppola, was a composer and musician. His mother, Italia Coppola (née Pennino), had been an actress. Francis Ford Coppola graduated with a degree in drama from Hofstra University, and did graduate work at UCLA in filmmaking. He was training as assistant with filmmaker Roger Corman, working in such capacities as sound-man, dialogue director, associate producer and, eventually, director of Dementia 13 (1963), Coppola's first feature film. During the next four years, Coppola was involved in a variety of script collaborations, including writing an adaptation of \"This Property is Condemned\" by Tennessee Williams (with Fred Coe and Edith Sommer), and screenplays for Is Paris Burning? (1966) and Patton (1970), the film for which Coppola won a Best Original Screenplay Academy Award. In 1966, Coppola's 2nd film brought him critical acclaim and a Master of Fine Arts degree. In 1969, Coppola and George Lucas established American Zoetrope, an independent film production company based in San Francisco. The company's first project was THX 1138 (1971), produced by Coppola and directed by Lucas. Coppola also produced the second film that Lucas directed, American Graffiti (1973), in 1973. This movie got five Academy Award nominations, including one for Best Picture. In 1971, Coppola's film The Godfather (1972) became one of the highest-grossing movies in history and brought him an Oscar for writing the screenplay with Mario Puzo The film was a Best Picture Academy Award-winner, and also brought Coppola a Best Director Oscar nomination. Following his work on the screenplay for The Great Gatsby (1974), Coppola's next film was The Conversation (1974), which was honored with the Golden Palm Award at the Cannes Film Festival, and brought Coppola Best Picture and Best Original Screenplay Oscar nominations. Also released that year, The Godfather Part II (1974), rivaled the success of The Godfather (1972), and won six Academy Awards, bringing Coppola Oscars as a producer, director and writer. Coppola then began work on his most ambitious film, Apocalypse Now (1979), a Vietnam War epic that was inspired by Joseph Conrad's Heart of Darkness (1993). Released in 1979, the acclaimed film won a Golden Palm Award at the Cannes Film Festival, and two Academy Awards. Also that year, Coppola executive produced the hit The Black Stallion (1979). With George Lucas, Coppola executive produced Sobowtór (1980), directed by Akira Kurosawa, and Mishima: A Life in Four Chapters (1985), directed by Paul Schrader and based on the life and writings of Yukio Mishima. Coppola also executive produced such films as The Escape Artist (1982), Hammett (1982) The Black Stallion Returns (1983), Barfly (1987), Wind (1992), The Secret Garden (1993), etc.\r\n\r\nHe helped to make a star of his nephew, Nicolas Cage. Personal tragedy hit in 1986 when his son Gio died in a boating accident. Francis Ford Coppola is one of America's most erratic, energetic and controversial filmmakers.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTM5NDU3OTgyNV5BMl5BanBnXkFtZTcwMzQxODA0NA@@._V1_.jpg",
                            PlaceOfBirthCity = "Detroit, Michigan",
                            PlaceOfBirthCountry = "United States of America"
                        },       
                        new ProducerModel()
                        {
                            FullName = "Stanley Kubrick", //12
                            DateOfBirth = new DateTime(1928, 7, 26),
                            Biography = "Stanley Kubrick was born in Manhattan, New York City, to Sadie Gertrude (Perveler) and Jacob Leonard Kubrick, a physician. His family were Jewish immigrants (from Austria, Romania, and Russia). Stanley was considered intelligent, despite poor grades at school. Hoping that a change of scenery would produce better academic performance, Kubrick's father sent him in 1940 to Pasadena, California, to stay with his uncle, Martin Perveler. Returning to the Bronx in 1941 for his last year of grammar school, there seemed to be little change in his attitude or his results. Hoping to find something to interest his son, Jack introduced Stanley to chess, with the desired result. Kubrick took to the game passionately, and quickly became a skilled player. Chess would become an important device for Kubrick in later years, often as a tool for dealing with recalcitrant actors, but also as an artistic motif in his films.\r\n\r\nJack Kubrick's decision to give his son a camera for his thirteenth birthday would be an even wiser move: Kubrick became an avid photographer, and would often make trips around New York taking photographs which he would develop in a friend's darkroom. After selling an unsolicited photograph to Look Magazine, Kubrick began to associate with their staff photographers, and at the age of seventeen was offered a job as an apprentice photographer.\r\n\r\nIn the next few years, Kubrick had regular assignments for \"Look\", and would become a voracious movie-goer. Together with friend Alexander Singer, Kubrick planned a move into film, and in 1950 sank his savings into making the documentary Day of the Fight (1951). This was followed by several short commissioned documentaries (Flying Padre (1951), and (The Seafarers (1953), but by attracting investors and hustling chess games in Central Park, Kubrick was able to make Fear and Desire (1953) in California.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Kubrick_on_the_set_of_Barry_Lyndon_%281975_publicity_photo%29_crop.jpg/1200px-Kubrick_on_the_set_of_Barry_Lyndon_%281975_publicity_photo%29_crop.jpg",
                            PlaceOfBirthCity = "New York City, New York",
                            PlaceOfBirthCountry = "United States of America",
                            DateOfDeath = new DateTime(1999, 3, 7)
                            
                        },    
                        new ProducerModel()
                        {
                            FullName = "Wes Craven", //13
                            DateOfBirth = new DateTime(1939, 8, 2),
                            Biography = "Wes Craven has become synonymous with genre bending and innovative horror, challenging audiences with his bold vision. Wesley Earl Craven was born in Cleveland, Ohio, to Caroline (Miller) and Paul Eugene Craven. He had a midwestern suburban upbringing. His first feature film was The Last House on the Left (1972), which he wrote, directed, and edited. Craven reinvented the youth horror genre again in 1984 with the classic A Nightmare on Elm Street (1984), a film he wrote and directed. And though he did not direct any of its five sequels, he deconstructed the genre a decade later, writing and directing the audacious Nowy koszmar Wesa Cravena (1994), which was nominated as Best Feature at the 1995 Independent Spirit Awards, and introduced the concept of self-reflexive genre films to the world.\r\n\r\nIn 1996 Craven reached a new level of success with the release of Scream (1996). The film, which sparked the phenomenal trilogy, was the winner of MTV's 1996 Best Movie Award and grossed more than $100 million domestically, as did Scream 2 (1997). Between Scream 2 and Scream 3 (2000), Craven, offered the opportunity to direct a non-genre film for Miramax, helmed Music of the Heart (1999), a film that earned Meryl Streep an Academy Award nomination for Best Actress. That same year, in the midst of directing, Craven completed his first novel, \"The Fountain Society,\" published by Simon & Shuster. Recent works include the 2005 psychological thriller Red Eye (2005), and a short rom-com segment for the ensemble product, Paris, je t'aime (2006).\r\n\r\nIn later years, Craven also produced remakes of two of his earlier films for his genre fans, The Hills Have Eyes (2006) and The Last House on the Left (2009). Craven has always had an eye for discovering fresh talent, something that contributes to the success of his films. While casting A Nightmare on Elm Street, Craven discovered the then unknown Johnny Depp. Craven later cast Sharon Stone in her first starring role for his film Deadly Blessing. He even gave Bruce Willis his first featured role in an episode of TV's mid-80's edition of The Twilight Zone. In My Soul to Take (2010), Craven once again brought together a cast of up-and-coming young teens, including Max Thieriot, in whom he saw the spark of stardom. The film marked Craven's first collaboration with wife and producer Iya Labunka, who also produced with him the highly anticipated production of Scream 4.\r\n\r\nCraven's Scream 4 (2011) reunited the director with Dimension Films and Kevin Williamson, as well as with stars Neve Campbell, Courteney Cox and David Arquette, to re-boot the beloved franchise. Craven again exhibited his knack for spotting important talent, with a cast of young actors bringing us a totally new breed of Woodsboro high schoolers, including Emma Robert and Hayden Pannetierre.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjEyNzIwNDcwNl5BMl5BanBnXkFtZTcwNTQ1NTI5NA@@._V1_.jpg",
                            PlaceOfBirthCity = "Cleveland, Ohio",
                            PlaceOfBirthCountry = "United States of America",
                            DateOfDeath = new DateTime(2015, 08, 30)
                            
                        },
                        new ProducerModel()
                        {
                            FullName = "Frank Capra", // 14
                            DateOfBirth = new DateTime(1897, 5, 18),
                            Biography = "One of seven children, Frank Capra was born on May 18, 1897, in Bisacquino, Sicily. On May 10, 1903, his family left for America aboard the ship Germania, arriving in New York on May 23rd. \"There's no ventilation, and it stinks like hell. They're all miserable. It's the most degrading place you could ever be,\" Capra said about his Atlantic passage. \"Oh, it was awful, awful. It seems to always be storming, raining like hell and very windy, with these big long rolling Atlantic waves. Everybody was sick, vomiting. God, they were sick. And the poor kids were always crying.\"\r\n\r\nThe family boarded a train for the trip to California, where Frank's older brother Benjamin was living. On their journey, they subsisted on bread and bananas, as their lack of English made it impossible for them to ask for any other kind of foodstuffs. On June 3, the Capra family arrived at the Southern Pacific station in Los Angeles, at the time, a small city of approximately 102,000 people. The family stayed with Capra's older brother Benjamin, and on September 14, 1903, Frank began his schooling at the Castelar Elementary school.\r\n\r\nIn 1909, he entered Los Angeles' Manual Arts High School. Capra made money selling newspapers in downtown L.A. after school and on Saturdays, sometimes working with his brother Tony. When sales were slow, Tony punched Frank to attract attention, which would attract a crowd and make Frank's papers sell quicker. Frank later became part of a two-man music combo, playing at various places in the red light district of L.A., including brothels, getting paid a dollar per night, performing the popular songs. He also worked as a janitor at the high school in the early mornings. It was at high school that he became interested in the theater, typically doing back-stage work such as lighting.\r\n\r\nCapra's family pressured him to drop out of school and go to work, but he refused, as he wanted to partake fully of the American Dream, and for that he needed an education. Capra later reminisced that his family \"thought I was a bum. My mother would slap me around; she wanted me to quit school. My teachers would urge me to keep going....I was going to school because I had a fight on my hands that I wanted to win.\"\r\n\r\nCapra graduated from high school on January 27, 1915, and in September of that year, he entered the Throop College of Technology (later the California Institute of Technology) to study chemical engineering. The school's annual tuition was $250, and Capra received occasional financial support from his family, who were resigned to the fact they had a scholar in their midst. Throop had a fine arts department, and Capra discovered poetry and the essays of Montaigne, which he fell in love with, while matriculating at the technical school. He then decided to write.\r\n\r\n\"It was a great discovery for me. I discovered language. I discovered poetry. I discovered poetry at Caltech, can you imagine that? That was a big turning point in my life. I didn't know anything could be so beautiful.\" Capra penned \"The Butler's Failure,\" about an English butler provoked by poverty to murder his employer, then to suicide.\"\r\n\r\nCapra was singled out for a cash award of $250 for having the highest grades in the school. Part of his prize was a six-week trip across the U.S. and Canada. When Capra's father, Turiddu, died in 1916, Capra started working at the campus laundry to make money.\r\n\r\nAfter the U.S. Congress declared War on Germany on April 6, 1917, Capra enlisted in the Army, and while he was not a naturalized citizen yet, he was allowed to join the military as part of the Coastal Artillery. Capra became a supply officer for the student soldiers at Throop, who have been enrolled in a Reserve Officers Training Corps program. At his enlistment, Capra discovered he was not an American citizen; he became naturalized in 1920.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTQ1NjE0NzgzNV5BMl5BanBnXkFtZTYwODg0MjI2._V1_.jpg",
                            PlaceOfBirthCity = "La Quinta, California",
                            PlaceOfBirthCountry = " United States of America",
                            DateOfDeath = new DateTime(1991, 9, 3)
                        },
                    });
                    context.SaveChanges();
                }

                // movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>()
                    {
                        // MATRIX 1-4  --------------------------------------------------------------------------
                        new MovieModel()
                        {
                            Name = "The Matrix",
                            MovieCategory = MovieCategory.Sciencefiction,
                            Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                            ReleaseDate = new DateTime(1999, 03, 31),
                            Price = 6.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 2,
                            LengthHours = 2,
                            LengthMinutes = 16,

                        },
                        new MovieModel()
                        {
                            Name = "The Matrix Reloaded",
                            MovieCategory = MovieCategory.Sciencefiction,
                            Description = "Freedom fighters Neo, Trinity and Morpheus continue to lead the revolt against the Machine Army, unleashing their arsenal of extraordinary skills and weaponry against the systematic forces of repression and exploitation.",
                            ReleaseDate = new DateTime(2003, 05, 15),
                            Price = 6.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BODE0MzZhZTgtYzkwYi00YmI5LThlZWYtOWRmNWE5ODk0NzMxXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 2,
                            LengthHours = 2,
                            LengthMinutes = 18,

                        },
                        new MovieModel()
                        {
                            Name = "The Matrix Revolutions",
                            MovieCategory = MovieCategory.Sciencefiction,
                            Description = "The human city of Zion defends itself against the massive invasion of the machines as Neo fights to end the war at another front while also opposing the rogue Agent Smith.",
                            ReleaseDate = new DateTime(2003, 11, 5),
                            Price = 7.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNzNlZTZjMDctZjYwNi00NzljLWIwN2QtZWZmYmJiYzQ0MTk2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                            ProducerId = 2,
                            LengthHours = 2,
                            LengthMinutes = 9,

                        },
                        new MovieModel()
                        {
                            Name = "The Matrix Resurrections",
                            MovieCategory = MovieCategory.Sciencefiction,
                            Description = "Return to a world of two realities: one, everyday life; the other, what lies behind it. To find out if his reality is a construct, to truly know himself, Mr. Anderson will have to choose to follow the white rabbit once more.",
                            ReleaseDate = new DateTime(2021, 12, 22),
                            Price = 11.49,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMGJkNDJlZWUtOGM1Ny00YjNkLThiM2QtY2ZjMzQxMTIxNWNmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg",
                            ProducerId = 2,
                            LengthHours = 2,
                            LengthMinutes = 28,

                        },
                        // SHREK 5-8  --------------------------------------------------------------------------
                         new MovieModel()
                        {
                        Name = "Shrek",
                        MovieCategory = MovieCategory.ForKids,
                        Description = "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.",
                        ReleaseDate = new DateTime(2001, 05, 18),
                        Price = 5.99,
                        ImageURL = "https://i-viaplay-com.akamaized.net/viaplay-prod/993/800/1613762117-f07774c22a81b35740522f9e1b18e1e03331bc19.jpg?width=400&height=600",
                        ProducerId = 3,
                        LengthHours = 1,
                        LengthMinutes = 30,


                        },
                        new MovieModel()
                        {
                            Name = "Shrek 2",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek and Fiona travel to the Kingdom of Far Far Away, where Fiona's parents are King and Queen, to celebrate their marriage. When they arrive, they find they are not as welcome as they thought they would be.",
                            ReleaseDate = new DateTime(2004, 05, 19),
                            Price = 6.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMDJhMGRjN2QtNDUxYy00NGM3LThjNGQtMmZiZTRhNjM4YzUxL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 3,
                            LengthHours = 1,
                            LengthMinutes = 45,


                        },
                        new MovieModel()
                        {
                            Name = "Shrek the Third",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Reluctantly designated as the heir to the land of Far, Far Away, Shrek hatches a plan to install the rebellious Artie as the new king while Princess Fiona tries to fend off a coup d'état by the jilted Prince Charming.",
                            ReleaseDate = new DateTime(2007, 05, 18),
                            Price = 7.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BOTgyMjc3ODk2MV5BMl5BanBnXkFtZTcwMjY0MjEzMw@@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 4,
                            LengthHours = 1,
                            LengthMinutes = 33,
                        },
                        new MovieModel()
                        {
                            Name = "Shrek Forever After",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Rumpelstiltskin tricks a mid-life crisis burdened Shrek into allowing himself to be erased from existence and cast in a dark alternate timeline where Rumpelstiltskin rules supreme.",
                            ReleaseDate = new DateTime(2010, 05, 21),
                            Price = 8.99,
                            ImageURL = "https://ecsmedia.pl/c/shrek-forever-after-b-iext47705115.jpg",
                            ProducerId = 5,
                            LengthHours = 1,
                            LengthMinutes = 35,

                        },
                        // HARRY POTTER 9-16  --------------------------------------------------------------------------
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Sorcerer's Stone",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.",
                            ReleaseDate = new DateTime(2001, 11, 4),
                            Price = 11.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNmQ0ODBhMjUtNDRhOC00MGQzLTk5MTAtZDliODg5NmU5MjZhXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_.jpg",
                            ProducerId = 6,
                            LengthHours = 2,
                            LengthMinutes = 32,

                        },
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Chamber of Secrets",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "An ancient prophecy seems to be coming true when a mysterious presence begins stalking the corridors of a school of magic and leaving its victims paralyzed.",
                            ReleaseDate = new DateTime(2002, 11, 3),
                            Price = 10.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjE0YjUzNDUtMjc5OS00MTU3LTgxMmUtODhkOThkMzdjNWI4XkEyXkFqcGdeQXVyMTA3MzQ4MTc0._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 6,
                            LengthHours = 2,
                            LengthMinutes = 41,

                        },
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Prisoner of Azkaban",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "Harry Potter, Ron and Hermione return to Hogwarts School of Witchcraft and Wizardry for their third year of study, where they delve into the mystery surrounding an escaped prisoner who poses a dangerous threat to the young wizard.",
                            ReleaseDate = new DateTime(2004, 05, 23),
                            Price = 6.49,
                            ImageURL = "https://www.themoviedb.org/t/p/w500/aWxwnYoe8p2d2fcxOqtvAtJ72Rw.jpg",
                            ProducerId = 7,
                            LengthHours = 2,
                            LengthMinutes = 22,

                        },
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Goblet of Fire",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "Harry Potter finds himself competing in a hazardous tournament between rival schools of magic, but he is distracted by recurring nightmares.",
                            ReleaseDate = new DateTime(2005, 11, 6),
                            Price = 9.19,
                            ImageURL = "https://images.moviesanywhere.com/d489bfce9aef55a5271d8a7d7d42bdb6/d265259e-3386-4a1e-b95f-cc52f30ee6fb.jpg",
                            ProducerId = 8,
                            LengthHours = 2,
                            LengthMinutes = 37,

                        },
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Order of the Phoenix",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "With their warning about Lord Voldemort's return scoffed at, Harry and Dumbledore are targeted by the Wizard authorities as an authoritarian bureaucrat slowly seizes power at Hogwarts.",
                            ReleaseDate = new DateTime(2007, 06, 28),
                            Price = 11.25,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTM0NTczMTUzOV5BMl5BanBnXkFtZTYwMzIxNTg3._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 9,
                            LengthHours = 2,
                            LengthMinutes = 18,

                        },
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Half-Blood Prince",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "As Harry Potter begins his sixth year at Hogwarts, he discovers an old book marked as \"the property of the Half-Blood Prince\" and begins to learn more about Lord Voldemort's dark past.",
                            ReleaseDate = new DateTime(2009, 7, 6),
                            Price = 14.49,
                            ImageURL = "https://4.bp.blogspot.com/-6pd8DDB3eQM/WAfB1--N_9I/AAAAAAAAJFU/761vui1jenYFfqGuDeXgjGyps52J8mw3ACLcB/s1600/potter6.jpg",
                            ProducerId = 9,
                            LengthHours = 2,
                            LengthMinutes = 33,

                        },
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Deathly Hallows: Part 1",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "As Harry, Ron and Hermione race against time and evil to destroy the Horcruxes, they uncover the existence of the three most powerful objects in the wizarding world: the Deathly Hallows.",
                            ReleaseDate = new DateTime(2010, 11, 11),
                            Price = 8.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTQ2OTE1Mjk0N15BMl5BanBnXkFtZTcwODE3MDAwNA@@._V1_.jpg",
                            ProducerId = 9,
                            LengthHours = 2,
                            LengthMinutes = 26,

                        },
                        new MovieModel()
                        {
                            Name = "Harry Potter and the Deathly Hallows: Part 2",
                            MovieCategory = MovieCategory.Fantasy,
                            Description = "Harry, Ron, and Hermione search for Voldemort's remaining Horcruxes in their effort to destroy the Dark Lord as the final battle rages on at Hogwarts.",
                            ReleaseDate = new DateTime(2011, 7, 7),
                            Price = 8.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMGVmMWNiMDktYjQ0Mi00MWIxLTk0N2UtN2ZlYTdkN2IzNDNlXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_.jpg",
                            ProducerId = 9,
                            LengthHours = 2,
                            LengthMinutes = 10,

                        },
                        // LORD OF THE RINGS 17-19  --------------------------------------------------------------------------
                        new MovieModel()
                        {
                            Name = "The Lord of the Rings: The Fellowship of the Ring",
                            MovieCategory = MovieCategory.Adventure,
                            Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                            ReleaseDate = new DateTime(2001, 12, 10),
                            Price = 6.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_.jpg",
                            ProducerId = 10,
                            LengthHours = 2,
                            LengthMinutes = 58,

                        },
                        new MovieModel()
                        {
                            Name = "The Lord of the Rings: The Two Towers",
                            MovieCategory = MovieCategory.Adventure,
                            Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                            ReleaseDate = new DateTime(2002, 12, 5),
                            Price = 8.49,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                            ProducerId = 10,
                            LengthHours = 2,
                            LengthMinutes = 59,

                        },
                        new MovieModel()
                        {
                            Name = "The Lord of the Rings: The Return of the King",
                            MovieCategory = MovieCategory.Adventure,
                            Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                            ReleaseDate = new DateTime(2003, 12, 1),
                            Price = 8.49,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                            ProducerId = 10,
                            LengthHours = 3,
                            LengthMinutes = 21,

                        },
                        // THE GODFATHER 20-22  --------------------------------------------------------------------------
                        new MovieModel()
                        {
                            Name = "The Godfather",
                            MovieCategory = MovieCategory.Drama,
                            Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                            ReleaseDate = new DateTime(1972, 03, 14),
                            Price = 10.19,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                            ProducerId = 11,
                            LengthHours = 2,
                            LengthMinutes = 55,

                        },
                        new MovieModel()
                        {
                            Name = "The Godfather Part II",
                            MovieCategory = MovieCategory.Drama,
                            Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                            ReleaseDate = new DateTime(1999, 03, 24),
                            Price = 9.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                            ProducerId = 11,
                            LengthHours = 3,
                            LengthMinutes = 22,

                        },
                        new MovieModel()
                        {
                            Name = "The Godfather Part III",
                            MovieCategory = MovieCategory.Drama,
                            Description = "Follows Michael Corleone, now in his 60s, as he seeks to free his family from crime and find a suitable successor to his empire.",
                            ReleaseDate = new DateTime(1999, 03, 24),
                            Price = 8.99,
                            ImageURL = "https://m.media-amazon.com/images/I/41KYQSW61YL._AC_SY580_.jpg",
                            ProducerId = 11,
                            LengthHours = 2,
                            LengthMinutes = 42,

                        },
                        // HOME ALONE 23-24  --------------------------------------------------------------------------
                        new MovieModel()
                        {
                            Name = "Home Alone",
                            MovieCategory = MovieCategory.Comedy,
                            Description = "An eight-year-old troublemaker, mistakenly left home alone, must defend his home against a pair of burglars on Christmas eve.",
                            ReleaseDate = new DateTime(1990, 11, 10),
                            Price = 3.99,
                            ImageURL = "https://www.tvguide.com/a/img/catalog/provider/1/2/1-9441893422.jpg",
                            ProducerId = 6,
                            LengthHours = 1,
                            LengthMinutes = 43,

                        },
                       new MovieModel()
                        {
                            Name = "Home Alone 2: Lost in New York",
                            MovieCategory = MovieCategory.Comedy,
                            Description = "One year after Kevin McCallister was left home alone and had to defeat a pair of bumbling burglars, he accidentally finds himself stranded in New York City - and the same criminals are not far behind.",
                            ReleaseDate = new DateTime(1992, 11, 15),
                            Price = 3.49,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNDI1MzM0Y2YtYmIyMS00ODE3LTlhZjEtZTUyNmEzMTNhZWU5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 6,
                            LengthHours = 2,

                        },
                       // THE SHINING 25 --------------------------------------------------------------------------
                       new MovieModel()
                        {
                            Name = "The Shining",
                            MovieCategory = MovieCategory.Horror,
                            Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.\r\n\r\n",
                            ReleaseDate = new DateTime(1980, 05, 23),
                            Price = 4.19,
                            ImageURL = "https://flxt.tmsimg.com/assets/p40_p_v8_ar.jpg",
                            ProducerId = 12,
                            LengthHours = 2,
                            LengthMinutes = 26,

                        },
                       // SCREAM 26-29 --------------------------------------------------------------------------
                       new MovieModel()
                        {
                            Name = "Scream",
                            MovieCategory = MovieCategory.Horror,
                            Description = "A year after the murder of her mother, a teenage girl is terrorized by a new killer, who targets the girl and her friends by using horror films as part of a deadly game.\r\n\r\n",
                            ReleaseDate = new DateTime(1996, 12, 18),
                            Price = 3.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjA2NjU5MTg5OF5BMl5BanBnXkFtZTgwOTkyMzQxMDE@._V1_.jpg",
                            ProducerId = 13,
                            LengthHours = 1,
                            LengthMinutes = 51,

                        },
                       new MovieModel()
                        {
                            Name = "Scream 2",
                            MovieCategory = MovieCategory.Horror,
                            Description = "Two years after the first series of murders, as Sidney acclimates to college life, someone donning the Ghostface costume begins a new string of killings.",
                            ReleaseDate = new DateTime(1997, 12, 10),
                            Price = 2.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTIxNTMzNzYtNzA3NC00MzgwLTlhNGYtMDEyYTNlZjcwZTNiXkEyXkFqcGdeQXVyNDAxNjkxNjQ@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 13,
                            LengthHours = 2,

                        },
                       new MovieModel()
                        {
                            Name = "Scream 3",
                            MovieCategory = MovieCategory.Horror,
                            Description = "While Sidney and her friends visit the Hollywood set of Stab 3, the third film based on the Woodsboro murders, another Ghostface killer rises to terrorize them.",
                            ReleaseDate = new DateTime(2000, 02, 3),
                            Price = 2.99,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMDljNmI1YzctNjJlZC00NzZlLWFlZTgtMDE4MjJiMDk0ZGY4XkEyXkFqcGdeQXVyMjg3MDQ0Mjk@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 13,
                            LengthHours = 1,
                            LengthMinutes = 56,

                        },
                       new MovieModel()
                        {
                            Name = "Scream 4",
                            MovieCategory = MovieCategory.Horror,
                            Description = "Ten years have passed, and Sidney Prescott, who has put herself back together thanks in part to her writing, is visited by the Ghostface Killer.",
                            ReleaseDate = new DateTime(2011, 04, 11),
                            Price = 2.49,
                            ImageURL = "https://assets.upflix.pl/media/plakat/2011/krzyk-4__300_427.jpg",
                            ProducerId = 13,
                            LengthHours = 1,
                            LengthMinutes = 51,

                        },
                       // IT'S WONDERFUL LIFE 30 --------------------------------------------------------------------------
                       new MovieModel()
                        {
                            Name = "It's a Wonderful Life",
                            MovieCategory = MovieCategory.Romance,
                            Description = "An angel is sent from Heaven to help a desperately frustrated businessman by showing him what life would have been like if he had never existed.",
                            ReleaseDate = new DateTime(1946, 12, 20),
                            Price = 8.99,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/2/25/It%27s_a_Wonderful_Life_%281946_poster%29.jpeg",
                            ProducerId = 14,
                            LengthHours = 2,
                            LengthMinutes = 10,

                        },                                          
                    });
                    context.SaveChanges();
                }

                //actors&movies
                if (!context.ActorsMovies.Any())
                {
                    context.ActorsMovies.AddRange(new List<ActorMovieModel>()
                    {
                        // MATRIX --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 1,
                            ActorId = 1
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 1,
                            ActorId = 2
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 1,
                            ActorId = 3
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 2,
                            ActorId = 1
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 2,
                            ActorId = 2
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 2,
                            ActorId = 3
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 3,
                            ActorId = 1
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 3,
                            ActorId = 2
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 3,
                            ActorId = 3
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 4,
                            ActorId = 1
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 4,
                            ActorId = 3
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 4,
                            ActorId = 4
                        },
                       // SHREK --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 5,
                            ActorId = 4
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 5,
                            ActorId = 5
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 5,
                            ActorId = 6
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 6,
                            ActorId = 4
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 6,
                            ActorId = 5
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 6,
                            ActorId = 6
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 7,
                            ActorId = 4
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 7,
                            ActorId = 5
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 7,
                            ActorId = 6
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 8,
                            ActorId = 4
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 8,
                            ActorId = 5
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 8,
                            ActorId = 6
                        },
                        // HARRY POTTER --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 9,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 9,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 9,
                            ActorId = 9
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 10,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 10,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 10,
                            ActorId = 9
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 11,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 11,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 11,
                            ActorId = 9
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 12,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 12,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 12,
                            ActorId = 9
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 13,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 13,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 13,
                            ActorId = 9
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 14,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 14,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 14,
                            ActorId = 9
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 15,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 15,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 15,
                            ActorId = 9
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 16,
                            ActorId = 10
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 16,
                            ActorId = 8
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 16,
                            ActorId = 9
                        },
                        // LORD OF THE RINGS --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 17,
                            ActorId = 11,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 17,
                            ActorId = 12
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 17,
                            ActorId = 13
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 18,
                            ActorId = 11
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 18,
                            ActorId = 12
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 18,
                            ActorId = 14
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 19,
                            ActorId = 11
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 19,
                            ActorId = 12
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 19,
                            ActorId = 14
                        },
                        // THE GODFATHER --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 20,
                            ActorId = 15,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 20,
                            ActorId = 16
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 20,
                            ActorId = 17
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 21,
                            ActorId = 15,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 21,
                            ActorId = 18
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 21,
                            ActorId = 19
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 22,
                            ActorId = 15,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 22,
                            ActorId = 20
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 22,
                            ActorId = 21
                        },
                         // HOME ALONE --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 23,
                            ActorId = 22,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 23,
                            ActorId = 23
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 23,
                            ActorId = 24
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 24,
                            ActorId = 22,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 24,
                            ActorId = 23
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 24,
                            ActorId = 24
                        },
                          // THE SHINING --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 25,
                            ActorId = 25,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 25,
                            ActorId = 26
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 25,
                            ActorId = 27
                        },
                          // SCREAM --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 26,
                            ActorId = 28,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 26,
                            ActorId = 29
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 26,
                            ActorId = 30
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 27,
                            ActorId = 28,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 27,
                            ActorId = 29
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 27,
                            ActorId = 30
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 28,
                            ActorId = 28,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 28,
                            ActorId = 29
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 28,
                            ActorId = 30
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 29,
                            ActorId = 28,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 29,
                            ActorId = 29
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 29,
                            ActorId = 30
                        },
                          // IT'S A WONDERFUL TIME --------------------------------------------------------------------------
                        new ActorMovieModel()
                        {
                            MovieId = 30,
                            ActorId = 31,
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 30,
                            ActorId = 32
                        },
                        new ActorMovieModel()
                        {
                            MovieId = 30,
                            ActorId = 33
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
               
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Admins
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<UserModel>>();
                var adminUser = await userManager.FindByEmailAsync("admin@mlover.com");
                if (adminUser == null)
                {
                    var newAdminUser = new UserModel()
                    {
                        FullName = "admin user",
                        UserName = "admin",
                        Email = "admin@mlover.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Sddldz123!");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                //Users

                var user = await userManager.FindByEmailAsync("fdziubek@gmail.com");
                if (user == null)
                {
                    var newUser = new UserModel()
                    {
                        FullName = "Filip Dziubek",
                        UserName = "fifi",
                        Email = "fdziubek@gmail.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newUser, "Sddldz123!");
                    await userManager.AddToRoleAsync(newUser, UserRoles.User);
                }
            }
        }
    }
}
