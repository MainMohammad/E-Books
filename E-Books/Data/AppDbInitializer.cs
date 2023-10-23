using E_Books.Models;
using E_Books.Data.Enums;

namespace E_Books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreatedAsync();

                //Seeding Authors...
                if(!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            Name = "Amie Kaufman",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "Amie Kaufman is an Australian author.Kaufman grew up in both Ireland and Melbourne, Australia. She earned undergraduate degrees, " +
                            "with honours, in law, history and literature. Later, she earned a Master's Degree in conflict resolution, and worked for seven years as a " +
                            "mediator before becoming a full-time author. She is as of May 2018 a PhD candidate in Creative Writing. She lives in Melbourne, " +
                            "Australia with her husband and dog.",
                            ProfileURL = "https://res.akamaized.net/domain/image/fetch/t_web/https://static.domain.com.au/twr/production/uploads/2017/08/25024719/TWR-30-Aug-Q-and-A-Amie-Kaufman-1950x1299-web.jpg"
                        },

                        new Author()
                        {
                            Name = "Meagan Spooner",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "Meagan Spooner was raised in the United States and graduated from Thomas " +
                            "Jefferson High School for Science and Technology. She graduated from Hamilton College with a degree in playwriting.",
                            ProfileURL = "https://www.davidhigham.co.uk/wp-content/uploads/1359475655Meagan_Spooner.jpg",
                        },
                        
                        new Author()
                        {
                            Name = "Sona Charaipotra",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "Charaipotra is Indian-American, born to two pediatrician parents. Despite family hopes of becoming a doctor, " +
                            "she chose to become a writer. She has two siblings. " +
                            "Charaipotra attended Rutgers University with a double major in journalism and American studies. " +
                            "She earned a master's degree in dramatic writing and South Asian diaspora studies from NYU in 2006.",
                            ProfileURL = "https://mpd-biblio-authors.imgix.net/200067795.jpg"
                        },

                        new Author()
                        {
                            Name = "Dhonielle Clayton",
                            Age = DateTime.Now.Year - 1983,
                            Biography = "Clayton was born in Washington, D.C. She went to Our Lady Of Good Counsel in Wheaton, Maryland. " +
                            "She received a Bachelor of Arts from Wake Forest University in 2005, " +
                            "a Master of Arts from Hollins University in 2008, and Master of Fine Arts in creative writing from The New School in 2012.",
                            ProfileURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpEuDCDU3x_EjzIFsdSjPT_fT5n8ODm9dO9A&usqp=CAU"
                        },

                        new Author()
                        {
                            Name = "Rebecca Albertalli",
                            Age = DateTime.Now.Year - 1982,
                            Biography = "Albertalli was born and raised in the Atlanta metropolitan area, with her sister Caroline and brother Sam; " +
                            "where she still lives with her husband Brian, and two sons, Owen and Henry." +
                            "Albertalli attended Wesleyan University and majored in psychology, " +
                            "before moving to Washington, D.C., and earning her Doctor of Psychology degree from George Washington University.",
                            ProfileURL = "https://www.loc.gov/static/managed-content/uploads/sites/7/2020/08/Albertalli-Becky.jpg"
                        },

                        new Author()
                        {
                            Name = "Adam Silvera",
                            Age = DateTime.Now.Year - 1990,
                            Biography = "Adam Silvera was born and raised in the South Bronx in New York City. His mother, Persi Rosa, is Puerto Rican and a social worker. " +
                            "Silvera started writing when he was around 10 or 11, initially working on fan fiction." +
                            "\r\n\r\nSilvera has worked as a barista, bookseller, and reviewer for Shelf Awareness before becoming a published writer.",
                            ProfileURL = "https://images.squarespace-cdn.com/content/v1/52bd29c9e4b013dbd6fc9a1c/1565225132084-13KP2Q4AQ5QVK3MKFAFA/AdamSilveraFace+2019.jpg"
                        },

                        new Author()
                        {
                            Name = "Ellen Oh",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "Ellen Oh (née Ha) is a Korean-American author, and founding member and CEO of the non-profit We Need Diverse Books. " +
                            "She is the award winning author of young adult and middle grade novels including the Prophecy trilogy, also known as the Dragon King Chronicles, " +
                            "a series of fantasy, young adult novels based on Korean folklore.",
                            ProfileURL = "https://www.ellenoh.com/wp-content/uploads/2022/08/EllenOh-author2.jpg"
                        },

                        new Author()
                        {
                            Name = "Elise Chapman",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "Elsie Chapman grew up in Prince George, Canada, and has a degree in English literature from the University of British Columbia. She is the author of the YA novels Dualed, " +
                            "Divided, and Along the Indigo, the middle grade novel All the Ways Home, " +
                            "and the coeditor of A Thousand Beginnings and Endings and Hungry Hearts. She currently lives in Tokyo, Japan, with her family",
                            ProfileURL = "https://wikizilla.org/w/images/a/ae/E_Chapman.png"
                        },

                        new Author()
                        {
                            Name = "Aisha Saeed",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "Aisha Saeed is an award-winning and New York Times bestselling author of books for children. " +
                            "Her middle grade novel Amal Unbound (Penguin) received multiple starred reviews and was a Global Read Aloud for 2018. " +
                            "Her picture book, Bilal Cooks Daal (Simon and Schuster) received an APALA honor. Aisha is also a founding member of the nonprofit We Need Diverse Books™. " +
                            "She lives in Atlanta, Georgia with her family",
                            ProfileURL = "https://aishasaeed.com/wp-content/uploads/sb-instagram-feed-images/273587277_651850442937274_2375084039378534560_nfull.jpg"
                        },

                        new Author()
                        {
                            Name = "Jenny Hendriks",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "No bio available!",
                            ProfileURL = "https://m.media-amazon.com/images/S/amzn-author-media-prod/s5755doh9nk1rpnai1rc1ag62q.jpg"
                        },

                        new Author()
                        {
                            Name = "Ted Caplan",
                            Age = DateTime.Now.Year - 1995,
                            Biography = "Ted Caplan has been working in the film industry for over twenty years as a writer, sound designer, and music editor.",
                            ProfileURL = "https://m.media-amazon.com/images/S/amzn-author-media-prod/4tr2roocucj11hnppm2glv0isu.jpg"
                        },

                        new Author()
                        {
                            Name = "Cathrine Doyle",
                            Age = DateTime.Now.Year - 1990,
                            Biography = "Catherine Doyle was born in the West of Ireland in 1990. She holds a BA in Psychology and an MA in English.",
                            ProfileURL = "https://m.media-amazon.com/images/S/amzn-author-media-prod/q7ji6j8mlgkefp6c1k4ub2ffpl._SX511_CR0%2C0%2C511%2C511_.jpg"
                        },

                        new Author()
                        {
                            Name = "Kathrine Webber",
                            Age = DateTime.Now.Year - 1987,
                            Biography = "Katherine Webber is an author of young-adult books. Her novel Wing Jones will be published in the UK (Walker Books) and in the US.",
                            ProfileURL = "https://files.datathistle.com/images/2022/06/10/e55205cd7960ce1eb303f99156d4fcd6846750f3-original-LST496403.jpg"
                        },

                        new Author()
                        {
                            Name = "Jack London",
                            Age = 1916 - 1876,
                            Biography = "John Griffith Chaney, better known as Jack London, was an American novelist, journalist and activist. " +
                            "A pioneer of commercial fiction and American magazines, " +
                            "he was one of the first American authors to become an international celebrity and earn a large fortune from writing.",
                            ProfileURL = "https://m.media-amazon.com/images/M/MV5BNTViNTcyYzQtOGFjNS00NjgyLTk5OWUtZDQxNTFjZmUxNTYzL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTc4MzI2NQ@@._V1_.jpg"
                        },

                        new Author()
                        {
                            Name = "William Shakespear",
                            Age = 1616 - 1564,
                            Biography = "William Shakespeare was an English playwright, poet and actor. He is widely regarded as the greatest writer " +
                            "in the English language and the world's pre-eminent dramatist. " +
                            "He is often called England's national poet and the \"Bard of Avon\"",
                            ProfileURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/William_Shakespeare_by_John_Taylor.jpg/640px-William_Shakespeare_by_John_Taylor.jpg"
                        },

                        new Author()
                        {
                            Name = "Gabriel García Márquez",
                            Age = 2014- 1927,
                            Biography = "Gabriel José de la Concordia García Márquez was a Colombian novelist, " +
                            "short-story writer, screenwriter, " +
                            "and journalist, known affectionately as Gabo or Gabito throughout Latin America.",
                            ProfileURL = "https://upload.wikimedia.org/wikipedia/commons/0/0f/Gabriel_Garcia_Marquez.jpg"
                        },

                        new Author()
                        {
                            Name = "J.K. Rowling",
                            Age = DateTime.Now.Year - 1965,
                            Biography = "Joanne Rowling CH OBE FRSL, best known by her pen name J. K. Rowling, is a British author and philanthropist. " +
                            "She wrote Harry Potter, a seven-volume fantasy series published from 1997 to 2007",
                            ProfileURL = "https://m.media-amazon.com/images/S/amzn-author-media-prod/8cigckin175jtpsk3gs361r4ss.jpg"
                        },

                        new Author()
                        {
                            Name = "George R.R Martin",
                            Age = DateTime.Now.Year - 1948,
                            Biography = "George Raymond Richard Martin, also known as GRRM, is an " +
                            "American novelist, screenwriter, television producer and short story writer.",
                            ProfileURL = "https://cdn.britannica.com/05/223205-050-8931FF28/American-writer-George-RR-Martin-2011.jpg"
                        },

                        new Author()
                        {
                            Name = "Arthur Conan",
                            Age = 1930 - 1859,
                            Biography = "Sir Arthur Ignatius Conan Doyle KStJ, DL was a British writer and physician. " +
                            "He created the character Sherlock Holmes in 1887 for A Study in Scarlet.",
                            ProfileURL = "https://m.media-amazon.com/images/M/MV5BMzI0NjQ1ODg1NF5BMl5BanBnXkFtZTgwOTc2OTI1MDE@._V1_.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                //Seeding Publishers...
                if(!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            Name = "Harper Collins",
                            Description = "HarperCollins Publishers LLC is an American publishing company that is considered to " +
                            "be one of the \"Big Five\" English-language publishers.",
                            Address = "U.S, New York, 195 Broadway",
                            Email = "consumercare@harpercollins.com",
                            LogoURL = "https://educationalcentre.al/shop/image/cache/catalog/akademiket/xigfvg-600x315.jpg"
                        },

                        new Publisher()
                        {
                            Name = "Simon & Schuster",
                            Description = "Simon & Schuster Inc is an American publishing company and a subsidiary of Paramount Global. " +
                            "It was founded in New York City on January 2, 1924, by Richard L. Simon and M. Lincoln Schuster.",
                            Address = "1230 Avenue of the Americas, New York, NY, 10020-1513, USA",
                            Email = "Info@SimonandSchuster.us",
                            LogoURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwFSfwYNXX60tC0toR7LVw8EdQZSK3K6J4YA&usqp=CAU"
                        },

                        new Publisher()
                        {
                            Name = "Penguin random house",
                            Description = "Penguin Random House is a cultural institution dedicated to serving our communities " +
                            "beyond the books we publish. Through our campaigns, partnerships, " +
                            "and internal initiatives, we strive to shape a more equitable, diverse, and sustainable world.",
                            Address = "1745 Broadway in Manhattan",
                            Email = "consumerservices@penguinrandomhouse.com",
                            LogoURL = "https://giveabook.org.uk/wp-content/uploads/2020/01/PRH.png"
                        },

                        new Publisher()
                        {
                            Name = "Macmillan",
                            Description = "Macmillan Publishers is a leading publishing company and home to some " +
                            "of the world's most cherished authors and creators. Our imprints publish a wide " +
                            "range of genres and formats for every kind of reader — from adult fiction and " +
                            "nonfiction to many inspired children's books.",
                            Address = "Equitable Life Building, 120 Broadway, New York, NY 10271, USA",
                            Email = "consumerservices@macmillan.com",
                            LogoURL = "https://s3.amazonaws.com/company-photo.theladders.com/9310/435052b8-e9ba-4445-93fa-82bbb623ae0d.jpg"
                        }
                    });
                }

                //Seeding Book stores...
                if(!context.BookStores.Any())
                {
                    context.BookStores.AddRange(new List<BookStore>()
                    {
                        new BookStore()
                        {
                            Name = "Strand",
                            Address = "828 Broadway, New York, NY 10003, USA",
                            Telephone = "+1 212-473-1452",
                            LogoURL = "https://blogs.baruch.cuny.edu/fro10pr1c/files/2010/11/StrandLogo.jpg"
                        },

                        new BookStore()
                        {
                            Name = "The Corner book store",
                            Address = "1313 Madison Ave, New York, NY 10128, USA",
                            Telephone = "+1 212-831-3554",
                            LogoURL = "https://www.wanderherway.com/wp-content/uploads/2020/10/IMG_2924-1024x683.jpg"
                        },

                        new BookStore()
                        {
                            Name = "Rizzoli Bookstore",
                            Address = "1133 Broadway, New York, NY 10010, USA",
                            Telephone = "+1 212-759-2424",
                            LogoURL = "https://twelve-books.com/cdn/shop/collections/rizzoli-logo_large.jpg?v=1649411303"
                        }
                    });
                }

                //Seeding books...
                if(!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Title = "Beyond the end of the world",
                            Summary = "Tragedy looms as the cloudland engines falter and mist rains terror on the surface, " +
                            "and in their desperation to reunite and save their people, Nimh and North face one" +
                            " ultimate question: can they defy their love and their destiny to save their homes?",
                            PublishDate = new DateTime(2022, 01, 18),
                            Price = 9.04M,
                            PublisherId = 1,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://images.pangobooks.com/images/9a466610-c587-4d7c-a649-338b0ad92e8c?quality=85&width=1200&crop=1%3A1"
                        },

                        new Book()
                        {
                            Title = "Tiny pretty things",
                            Summary = "Tiny Pretty Things is set in the world of an elite ballet academy and charts the rise " +
                            "and fall of young adults who live far from their homes, each standing on the verge of greatness or ruin.",
                            PublishDate = new DateTime(2016, 07, 12),
                            Price = 11.55M,
                            PublisherId = 1,
                            Genre = BookGenre.Fiction,
                            BookCover = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReArvAUZJtqQMJTX8XMNJ82TT_Y5Bi9eCKS0YNrOcBMF7MVZf7KagqeLmPUtJ2HxBgGEc&usqp=CAU"
                        },

                        new Book()
                        {
                            Title = "Heres to us",
                            Summary = "Arthur is in New York for a dream internship on Broadway, with a boyfriend back at " +
                            "home that he couldn't be happier with. But when he comes upon " +
                            "Ben cuddled up with a mystery boy, he starts to wonder if his feelings for Ben ever truly went away.",
                            PublishDate = new DateTime(2022, 11, 29),
                            Price = 2.15M,
                            PublisherId = 1,
                            Genre = BookGenre.Fiction,
                            BookCover = "https://img1.od-cdn.com/ImageType-400/0293-1/B84/4DF/C7/%7BB844DFC7-5712-42C9-B1AB-580B6A4D895D%7DImg400.jpg"
                        },

                        new Book()
                        {
                            Title = "A thousand beginnings and endings",
                            Summary = "The stories within this anthology cover and explore a number of themes all while allowing " +
                            "the each author to bring a unique spin to their favorite folktales & stories!",
                            PublishDate = new DateTime(2020, 01, 14),
                            Price = 1.73M,
                            PublisherId = 1,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/51R-s+QdP-L.SX316.SY480._SL500_.jpg"
                        },

                        new Book()
                        {
                            Title = "Yes, No maybe so",
                            Summary = "a story about how two individuals with different personalities come together to work on political matters. " +
                            "The two main characters, " +
                            "Jamie Goldberg and Maya Rehman spend a lot of time together and eventually fall for each other.",
                            PublishDate = new DateTime(2020, 02, 04),
                            Price = 1.18M,
                            PublisherId = 1,
                            Genre = BookGenre.Romance,
                            BookCover = "https://m.media-amazon.com/images/I/71BGiWlLvkL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "Save Steve",
                            Summary = "Steve Stevenson is a jerk. That might not be a cool thing to say about someone with cancer, but it’s true. Yeah, " +
                            "he throws legendary parties and is the most popular guy in school, but he also loves humiliating pranks and Cardi B, and he doesn’t recycle. " +
                            "Worst of all, he’s dating Kaia—the girl of nice guy Cam’s dreams.",
                            PublishDate = new DateTime(2020, 08, 30),
                            Price = 7.40M,
                            PublisherId = 1,
                            Genre = BookGenre.Fiction,
                            BookCover = ""
                        },

                        new Book()
                        {
                            Title = "Twin crowns",
                            Summary = "Wren Greenrock has always known that one day she’d steal her sister’s place on the throne. Trained from birth to return to the palace " +
                            "and avenge her parents’ murder, she’ll do anything to become queen and protect the community of witches who raised her. Or she would, " +
                            "if only a certain guard wasn’t quite so distractingly attractive, and if her reckless magic would stop causing trouble...",
                            PublishDate = new DateTime(2023, 04, 04),
                            Price = 11.17M,
                            PublisherId = 1,
                            Genre = BookGenre.Fantasy,
                            BookCover = ""
                        },

                        new Book()
                        {
                            Title = "The call of wild",
                            Summary = "This triumphant tale of survival follows the adventures of Buck, half-St. Bernard and half-Scottish sheepdog, " +
                            "who is forced into the brutal life of a sled-dog during the heady days of the Alaska gold rush.",
                            PublishDate = new DateTime(1903, 07, 01),
                            Price = 4.95M,
                            PublisherId = 1,
                            Genre = BookGenre.Advanture
                        },

                        new Book()
                        {
                            Title = "White fang",
                            Summary = "It follows the story of a wolf-dog hybrid, White Fang, as he embarks on a journey of self-discovery. After his mother " +
                            "is killed by a group of Native Americans, White Fang is adopted by a man named Grey Beaver, who teaches him " +
                            "the way of the wild and introduces him to the harsh realities of life. White Fang is then sold to a cruel and abusive owner, but...",
                            PublishDate = new DateTime(1906, 05, 02),
                            Price = 6.95M,
                            PublisherId = 1,
                            Genre = BookGenre.Advanture
                        },

                        new Book()
                        {
                            Title = "Martin Eden",
                            Summary = "A young working class seaman, he struggles to become a successful writer. Rejected repeatedly by publishers, he continues to submit his work. Along the way, " +
                            "he educates himself with the help of his love interest, Ruth, an upper class student whose parents disdain Eden. " +
                            "He finally achieves success but despairs that people value him only for his fame, and not for himself.",
                            PublishDate = new DateTime(1909, 09, 05),
                            Price = 9.76M,
                            PublisherId = 2,
                            Genre = BookGenre.Fiction
                        },

                        new Book()
                        {
                            Title = "To build a fire",
                            Summary = "This superb volume brings together twenty-five of London's finest, including a dozen of his great " +
                            "Klondike stories, vivid tales of the Far North were rugged " +
                            "individuals, such as the Malemute Kid face the violence of man and nature during the Gold Rush Days.",
                            PublishDate = new DateTime(1908, 08, 01),
                            Price = 1.35M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture
                        },

                        new Book()
                        {
                            Title = "The sea wolf",
                            Summary = "Humphrey van Weyden, is a literary critic who is a survivor of " +
                            "an ocean collision and who comes under the dominance of Wolf Larsen, the powerful and amoral sea captain who rescues him.",
                            PublishDate = new DateTime(1904, 06, 25),
                            Price = 2.71M,
                            PublisherId = 2,
                            Genre = BookGenre.Fiction
                        },

                        new Book()
                        {
                            Title = "The iron heel",
                            Summary = "a futuristic world in which the division between the classes has deepened, creating a " +
                            "menacing oligarchy that rules through terror.",
                            PublishDate = new DateTime(1908, 10, 13),
                            Price = 7.99M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture
                        },

                        new Book()
                        {
                            Title = "The son of the wolf",
                            Summary = "\"The Son Of The Wolf\" is a collection of short stories, all with a common subject - the northern part of the American continent, " +
                            "the pursuit of gold during the rush in Yukon, and mainly the dealings between the locals (Native Americans) and the European settlers",
                            PublishDate = new DateTime(1922, 06, 11),
                            Price = 4.45M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture
                        },

                        new Book()
                        {
                            Title = "Brown wolf",
                            Summary = "Some stupid stories",
                            PublishDate = new DateTime(1920, 06, 11),
                            Price = 6.94M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture
                        },

                        new Book()
                        {
                            Title = "The white silence",
                            Summary = "The story chronicles the travels of three people across the Northland " +
                            "Trail on the Yukon, as they try to reach civilization before spring.",
                            PublishDate = new DateTime(1899, 02, 16),
                            Price = 5.13M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture
                        },

                        new Book()
                        {
                            Title = "Hamlet",
                            Summary = "Prince Hamlet and his revenge against his uncle, Claudius, who has murdered " +
                            "Hamlet's father in order to seize his throne and marry Hamlet's mother.",
                            PublishDate = new DateTime(1599, 01, 01),
                            Price = 6.24M,
                            PublisherId = 2,
                            Genre = BookGenre.Drama
                        },

                        new Book()
                        {
                            Title = "Othelo",
                            Summary = "A Moorish general in command of the armed forces of Venice who earns the " +
                            "enmity of his ensign Iago by passing him over for a promotion. " +
                            "Partly for revenge and partly out of pure evil, Iago plots to convince Othello that Desdemona, his wife, has been unfaithful to him.",
                            PublishDate = new DateTime(1601, 01, 01),
                            Price = 2.50M,
                            PublisherId = 3,
                            Genre = BookGenre.Tragedy
                        },

                        new Book()
                        {
                            Title = "Romeo & Juliet",
                            Summary = "Romeo and Juliet is a famous tragedy written by William Shakespeare early in his career " +
                            "about the romance between two Italian youths from feuding families.",
                            PublishDate = new DateTime(1597, 01, 01),
                            Price = 6.99M,
                            PublisherId = 3,
                            Genre = BookGenre.Tragedy
                        },

                        new Book()
                        {
                            Title = "Macbeth",
                            Summary = "\"Macbeth is one of Shakespeare's finest plays, and presents a man's conscience and the " +
                            "effect of guilt on his mind. A dark and bloody play.",
                            PublishDate = new DateTime(1603, 11, 03),
                            Price = 5.24M,
                            PublisherId = 3,
                            Genre = BookGenre.Tragedy
                        },

                        new Book()
                        {
                            Title = "King Lear",
                            Summary = "King Lear is a tragedy based on the chronicle history of a pre-Roman, Celtic king of Britain. " +
                            "In Shakespeare's play, Lear, intending to retire, stages a love test for his three daughters...",
                            PublishDate = new DateTime(1606, 12, 26),
                            Price = 8.01M,
                            PublisherId = 3,
                            Genre = BookGenre.Tragedy
                        },

                        new Book()
                        {
                            Title = "Venus & Adonis",
                            Summary = "The poem tells the story of Venus, the goddess of Love; of her unrequited love; and of her attempted seduction of Adonis.",
                            PublishDate = new DateTime(1593, 05, 05),
                            Price = 3.14M,
                            PublisherId = 3,
                            Genre = BookGenre.Drama
                        },

                        new Book()
                        {
                            Title = "I sell my dreams",
                            Summary = "Frau Frieda turned her skills as a psychic to earn a livelihood. She was hired by a woman in Vienna where she was given a " +
                            "salary, a room to stay and adequate meals every day. ",
                            PublishDate = new DateTime(1980, 05, 05),
                            Price = 5.62M,
                            PublisherId = 3,
                            Genre = BookGenre.Drama
                        },

                        new Book()
                        {
                            Title = "News of a kidnapping",
                            Summary = "News of a Kidnapping is a deeply personal account that pays tribute to the author's " +
                            "friends Maruja Pachón, one of the people kidnapped by Escobar's men, and her husband, Alberto Villamizar.",
                            PublishDate = new DateTime(1996, 07, 23),
                            Price = 15.10M,
                            PublisherId = 3,
                            Genre = BookGenre.Nonfiction
                        },

                        new Book()
                        {
                            Title = "Big momma's funeral",
                            Summary = "\"Big Mama's Funeral\" is a long short story by Gabriel García Márquez that " +
                            "satirizes Latin American life and culture. It displays the exaggeration associated with magic realism.",
                            PublishDate = new DateTime(1962, 07, 23),
                            Price = 10.00M,
                            PublisherId = 3,
                            Genre = BookGenre.Fiction
                        },

                        new Book()
                        {
                            Title = "One hundred years of solitude",
                            Summary = "The Buendía family, whose patriarch, José Arcadio Buendía, founded the fictitious town of Macondo...",
                            PublishDate = new DateTime(1967, 05, 05),
                            Price = 8.03M,
                            PublisherId = 3,
                            Genre = BookGenre.Drama
                        },

                        new Book()
                        {
                            Title = "No one writes to Colonel",
                            Summary = " García Márquez considered it his best book, saying that he had to write One Hundred Years of " +
                            "Solitude so that people would read No One Writes to the Colonel.",
                            PublishDate = new DateTime(1961, 05, 05),
                            Price = 17.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fiction
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the Philosopher's stone",
                            Summary = "The book is about 11 year old Harry Potter, who receives a letter saying that he is invited to attend Hogwarts, " +
                            "school of witchcraft and wizardry.",
                            PublishDate = new DateTime(1997, 06, 26),
                            Price = 9.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fantasy
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the chamber of secrets",
                            Summary = "The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of " +
                            "messages on the walls of the school's corridors warn that the \"Chamber of Secrets\" has been opened...",
                            PublishDate = new DateTime(1998, 11, 05),
                            Price = 9.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fantasy
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the prisoner of Azkaban",
                            Summary = "The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. " +
                            "Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban...",
                            PublishDate = new DateTime(1999, 07, 08),
                            Price = 9.50M,
                            PublisherId = 4,
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the goblet of fire",
                            Summary = "It follows Harry Potter, a wizard in his fourth year at Hogwarts School of Witchcraft and Wizardry, " +
                            "and the mystery surrounding the entry of Harry's name into the Triwizard Tournament, in which he is forced to compete.",
                            PublishDate = new DateTime(2000, 07, 08),
                            Price = 9.50M,
                            PublisherId = 1,
                            Genre = BookGenre.Fantasy
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the order of Phoenix",
                            Summary = "It follows Harry Potter's struggles through his fifth year at Hogwarts School of Witchcraft and Wizardry, " +
                            "including the surreptitious return of the antagonist Lord Voldemort, O.W.L. exams, and an obstructive Ministry of Magic",
                            PublishDate = new DateTime(2003, 06, 21),
                            Price = 9.50M,
                            PublisherId = 2,
                            Genre = BookGenre.Fantasy
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the Half-Blood prince",
                            Summary = " Harry Potter learns a lot about Lord Voldemort's past, and Harry Potter prepares for the final battle against " +
                            "his nemesis with the help of Headmaster Dumbledore. But in that time, Voldemort returns to power, and makes a plan to destroy Harry.",
                            PublishDate = new DateTime(2005, 07, 16),
                            Price = 9.50M,
                            PublisherId = 3,
                            Genre = BookGenre.Fantasy
                        },


                        new Book()
                        {
                            Title = "Harry Potter and the deathly hallows",
                            Summary = "He finally kills the bad person",
                            PublishDate = new DateTime(2007, 07, 21),
                            Price = 9.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fantasy
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the cursed child",
                            Summary = "His stupid boy returns Voldemort",
                            PublishDate = new DateTime(2016, 07, 31),
                            Price = 9.50M,
                            PublisherId = 1,
                            Genre = BookGenre.Fantasy
                        }
                    });
                }

                //Assigning books to its author/authors
                if (!context.Authors_Books.Any())
                {
                    context.Authors_Books.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },

                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 1
                        },

                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 2
                        },

                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 2
                        },

                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 3
                        },

                        new Author_Book()
                        {
                            AuthorId = 6,
                            BookId = 3
                        },

                        new Author_Book()
                        {
                            AuthorId = 7,
                            BookId = 4
                        },

                        new Author_Book()
                        {
                            AuthorId = 8,
                            BookId = 4
                        },

                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 5
                        },

                        new Author_Book()
                        {
                            AuthorId = 9,
                            BookId = 5
                        },

                        new Author_Book()
                        {
                            AuthorId = 10,
                            BookId = 6
                        },

                        new Author_Book()
                        {
                            AuthorId = 11,
                            BookId = 6
                        },

                        new Author_Book()
                        {
                            AuthorId = 12,
                            BookId = 7
                        },

                        new Author_Book()
                        {
                            AuthorId = 13,
                            BookId = 7
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 8
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 9
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 10
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 11
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 12
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 13
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 14
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 15
                        },

                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 16
                        },

                        new Author_Book()
                        {
                            AuthorId = 15,
                            BookId = 17
                        },

                        new Author_Book()
                        {
                            AuthorId = 15,
                            BookId = 18
                        },

                        new Author_Book()
                        {
                            AuthorId = 15,
                            BookId = 19
                        },

                        new Author_Book()
                        {
                            AuthorId = 15,
                            BookId = 20
                        },

                        new Author_Book()
                        {
                            AuthorId = 15,
                            BookId = 21
                        },

                        new Author_Book()
                        {
                            AuthorId = 15,
                            BookId = 22
                        },

                        new Author_Book()
                        {
                            AuthorId = 16,
                            BookId = 23
                        },

                        new Author_Book()
                        {
                            AuthorId = 16,
                            BookId = 24
                        },

                        new Author_Book()
                        {
                            AuthorId = 16,
                            BookId = 25
                        },

                        new Author_Book()
                        {
                            AuthorId = 16,
                            BookId = 26
                        },

                        new Author_Book()
                        {
                            AuthorId = 16,
                            BookId = 27
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 28
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 29
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 30
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 31
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 32
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 33
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 34
                        },

                        new Author_Book()
                        {
                            AuthorId = 17,
                            BookId = 35
                        },
                    });
                }

                //Storing Books in bookstores
                if (!context.BookStores_Books.Any())
                {
                    context.BookStores_Books.AddRange(new List<BookStore_Book>()
                    {
                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 1
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 2
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 3
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 4
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 5
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 6
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 7
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 8
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 9
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 10
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 11
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 12
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 13
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 1,
                            BookId = 14
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 7
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 8
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 9
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 10
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 11
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 12
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 13
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 14
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 15
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 16
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 17
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 18
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 19
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 20
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 2,
                            BookId = 21
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 17
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 18
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 19
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 20
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 21
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 22
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 23
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 24
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 25
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 26
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 27
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 28
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 29
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 30
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 31
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 32
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 33
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 34
                        },

                        new BookStore_Book()
                        {
                            BookStoreId = 3,
                            BookId = 35
                        },
                    });
                }
            }
        }
    }
}
