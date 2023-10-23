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
                            BookCover = "https://m.media-amazon.com/images/I/71pHyX6kWBL._AC_UF1000,1000_QL80_.jpg"
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
                            BookCover = "https://images-eu.ssl-images-amazon.com/images/I/81do8jEsnSL._AC_UL600_SR600,600_.jpg"
                        },

                        new Book()
                        {
                            Title = "The call of wild",
                            Summary = "This triumphant tale of survival follows the adventures of Buck, half-St. Bernard and half-Scottish sheepdog, " +
                            "who is forced into the brutal life of a sled-dog during the heady days of the Alaska gold rush.",
                            PublishDate = new DateTime(1903, 07, 01),
                            Price = 4.95M,
                            PublisherId = 1,
                            Genre = BookGenre.Advanture,
                            BookCover = "https://images.macmillan.com/folio-assets/interiors-images/9780812504323.IN01.jpg"
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
                            Genre = BookGenre.Advanture,
                            BookCover = "https://m.media-amazon.com/images/I/51Zlm66XqFL.jpg"
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
                            Genre = BookGenre.Fiction,
                            BookCover = "https://m.media-amazon.com/images/I/51Z1pStyLKL.jpg"
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
                            Genre = BookGenre.Advanture,
                            BookCover = "https://m.media-amazon.com/images/I/81DjVGXzZpL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "The sea wolf",
                            Summary = "Humphrey van Weyden, is a literary critic who is a survivor of " +
                            "an ocean collision and who comes under the dominance of Wolf Larsen, the powerful and amoral sea captain who rescues him.",
                            PublishDate = new DateTime(1904, 06, 25),
                            Price = 2.71M,
                            PublisherId = 2,
                            Genre = BookGenre.Fiction,
                            BookCover = "https://m.media-amazon.com/images/I/91cuLLigVtL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "The iron heel",
                            Summary = "a futuristic world in which the division between the classes has deepened, creating a " +
                            "menacing oligarchy that rules through terror.",
                            PublishDate = new DateTime(1908, 10, 13),
                            Price = 7.99M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture,
                            BookCover = "https://m.media-amazon.com/images/I/51AuCR91cML._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "The son of the wolf",
                            Summary = "\"The Son Of The Wolf\" is a collection of short stories, all with a common subject - the northern part of the American continent, " +
                            "the pursuit of gold during the rush in Yukon, and mainly the dealings between the locals (Native Americans) and the European settlers",
                            PublishDate = new DateTime(1922, 06, 11),
                            Price = 4.45M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture,
                            BookCover = "https://m.media-amazon.com/images/I/61hucM7lYXL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "Brown wolf",
                            Summary = "Some stupid stories",
                            PublishDate = new DateTime(1920, 06, 11),
                            Price = 6.94M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture,
                            BookCover = "https://m.media-amazon.com/images/I/61l19Rr+4XL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "The white silence",
                            Summary = "The story chronicles the travels of three people across the Northland " +
                            "Trail on the Yukon, as they try to reach civilization before spring.",
                            PublishDate = new DateTime(1899, 02, 16),
                            Price = 5.13M,
                            PublisherId = 2,
                            Genre = BookGenre.Advanture,
                            BookCover = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTEhMWFRUXGiEbGBgXGCMeHxshHiAeISMkISIgICkhHiImIyAeJDIiJiouLzEvICE2OTQtOCkuMSwBCgoKDQ0NDw0NDiwaIBosLC4sLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLP/AABEIARUAtgMBIgACEQEDEQH/xAAcAAACAwEBAQEAAAAAAAAAAAAFBgAEBwMBAgj/xABEEAACAgEDAgUCBQMBBAgEBwABAgMRBAASIQUxBhMiQVEyYQcUI3GBQlKRoTNiseEVFyRDdILB0SWS8PEWVHJzsrPC/8QAFQEBAQAAAAAAAAAAAAAAAAAAAAH/xAAUEQEAAAAAAAAAAAAAAAAAAAAA/9oADAMBAAIRAxEAPwDHur4RhkZDytna1VuAJANe3bse2quPCzsEUEsxAUD3J7aKnGmzckBPXLMQTZ4s/USfauSfjWn9B8OdOwJ4RkFmyWp42diq8VuoCx8gWLNcaBI8Rfh3m4eN+YlRDECA5VuUJJWiCAe9CxY7a7eGfA+RkRSv5iYyIu6R5iUO39jR2V3bsTx7a2XqfV5T5aJjy5u9yyN5f6MY/oJ/vr2LdqugdKf4mzxSLHDkRPEWQ3lS+kl05CkDgpZqhZ5FV30GV9I8PTTcqo2kWCeN1VwvvZ0yR+DYpPOjxxJNOpUgofQiii43NQLDkc1zWtAwmjxsbGkWNZJZkDRsi8ISvewOF9qFkH+TqnjrDAjPMAZXPmFImYEtfG5V5KmuQwI0CT4DzVxpJJ2hkmMbfpECiS1rdjk1Vkcir0X8XeCer5bLM1TllUhEO30ntQNKK4scVov1TxRDhwCdGV83IJeJVAKwjbsNgCuwNAjn/XSZ0v8AEPqMQyI45t/nt3cbirMeSnso7+nkD2GgLeGPw46pjz+YYFU7XRbkU2WUjuCaoWbPxoH4j8O5HT8h1mAkdYxJ+m5raSFt+zEXYIBH+NOfgf8AEnLAeARR5BAJjdm8snbxbBVo38gA8C776SoczKzc2XKyJAqElJ5XUmKNGsbKHtXCqOSaPydBU6H0zJzZiAxj8wFS7WiVVhOOKI7L2PGmuDpr4h8hJzJBLujJcCK0Gx5GLOLWMblDJ3Ylxrvj9XwPP86Od5Ex4V8tBGVZjC1RrR/vU8sBxXtq51jomT1DEwI1W5pPMllL2u3e123F0poUBZrQMPQM5JomkDyyNIzPjpFGD5IPpAJPoBVaUDsouhZvXxleEumnHTHaEnOkRlUPK0kqMQdrOVPpUMAeQAAT99eeGfDLxzNFKqDGWICSm/SkYAAMPpZJLNbjydt12154vy48XDdsN0gDFYi4ULPPybVSBagKSd59R+R3IK+K+D0ONmYpmdTHHzHAxHYH3I9z39uNfXU/FOYrY486SORIhLlOSLYyUwUg+kBRdCuLGktcGSWXFOPCXkdbC/VvKO1MR7DgA3xxpyzVxunNJNmbczPchhj7tyQn3aYigT/uAcUAOOdAX6CZZwcgQyovP6bG2KuCRJuYFi3c125+wOmPAjRItzn8uxRTJ5hpiaNUQwBJrlBzx2HGsexvGWdJlecmQ3nNweBs2+yhCNu0ft/OjPXOhZk4j3u5VTuVC1hPckfv/jQPOP4zmgUhIo34sPvKoW92KMCQCedoa/uNZ51IM7PNM6NLM5d2U/PsB7ACgPsNV8tpXVIApUbqZx8DTF0rwxCKZDvC8bSeb0C90ESRylY3Pr7BuRprlyUx2SPMfywRasDV6Y87pcZApQm0e3fS9keGvzx/W+lOxB5rQC8mVW/UEpNkgG+41NWpIYQPLRCqoaH31NAqfhtJszoGMLSKXCcHsWIQkLfP1AEews+2tm8T9V6fIBFkSRqY5CFlB3Mki8lbH0tVrtY88/Gsa8PdWTHByo4kMsTUjEbfLtCqk0aYsS5+bUE8CtU+nZ5SKaLIDFcpN+4gNtkDEpIv7+oH3on40B/qHj8r54wsjJx03L5ESKoRQpcEEX6QRs7Dv3HFlj6b1yTqGAmR1ehh4j2XFh8twCFQDgVz6iO5+KNZR5LeW+40Qy+kjlmYH37ChZ573px8QvPnnDwMWIrDBEAFJAG7nfK7dgDRq+eDxzoOi/iS8ksv/ZEaJ62Qq5Xy1RaAWhV1ySBz8aNZm1+nrl4rbUSYrKVWyQUU7Tu7AMSltxwDWrPhPwDHjESvIJpaJFKNoFEEgnkmj7WOb0LyOmnFSfEygcfESX8xIqnd5gK1HHGxrcWIPftXxoM+ydxmaRCBZv1OGIvvZAAP8DXyyuin0kMGsmu3cDv2v1Vr76rCrTVBt2SUyIjFtu7shJAJYdjp38G9BjnVcvPkBhidseYP6QsaREghhRLBiqiuefnQLsccUUqGGS0VQjSudoDnlgo+AK+fm9Pk3St6Y8Uyqq5MRijiIIEbkFlkYCgZOSdxFi60GTpON1RslsVZAsA9DOwBkaRiI0otSoKJsncfc6LeN8+83pcEtptALqrGxvIjHqHvSmj9zoAX4ceGJG83Mk4XE3CJdoPmy0fTz3ANWfkr99aamL5GMnn5KwqxjiICkyNtFLGnI2kuWctRIBqgBeqA6ecPKQM6/lUAMSKW3MykszyHbwDISTfcha4B0H6t1wHMO5SjrIsMUtLJsEoJBWNioVP7mX1E+50HHxRlZw6niI5VcQZCCAAj9W63SEXukIs25FAkfOrI8NGHGCPKsSgOpmkIQrEzkkRg9nlUKhY8Ko97rV0Z2VDkA5+3yVW7xwrO49mZJCZQD/uk7TXtzpe6r+JWO0jv+WnAv0gsps/LFt1VxQXj76BnhwBjxPFgYjYySoN+TvAdQeaDyepAOw9N8k1YAOdDpDY0jTqdu3lqPmlr7/A/diavRzp/WsKSKWZsiZJLvy5wCCf91koi/ufbtrl4bxnynyHm/TgdCpbdaj+0WTffQLMHU2kyRPLw54X0gAAdhxxemKfr+TZJoWKB+2jHhvwWYI48p0EkXG0E2zE8WB7H41fzvCEM8nlwlQGTfXmX6QefUCdvqv6vbQKn/wCI02qqjay/UT76rS4rySxnElZ3c8qnP+AL126xg4kWW0ESnaieoiTf5jXztBY0CeBzyOeBpg6fgtxlRoIC7niIkAH/AHTwSt8V2P30A3/pTL84Yw+v+tnNVXf9j9tNfS8aaRCElVB2J78++qHQ/Ci+a88zNK7sWLX7k89u3Pt7aOZ2KvlvBE3lsFsV99AAXMxIbRmMrA+ojnnU0nZSI/6cD1sJ3H5OpoOjeExlhsrFVExEIidgWNEIp3iwCSN1MfkE83WuMXQmTcqyYzLC6tv3BonAQWNrkK+40SOTwa07+HvC/UYOlz48BWTzZTuQmqT0htt/1Gueartpj6H02ODEDu8LvCpkG6IEqT2A5sHkXQHLX76BI8HeGMVJW/MtjzMoO5HvbG1FxuHIWlD2CTzt7UQavXvGRKn8qIGhemWNscMzhAFO4lQvo5pSKAqie2nTF6VUe5sQNh5CMZY0HqLObLk9wRRqjQs/as78c+FsaDIWPEnYJLH5qo5HpQkAqCSDYpmKnkgAe2gCdP8AFc8czZckvmSmNkjBAYCxXA+lAKHYe5rnVxOovIYsnOU5MSE7UaSjLJQPq4JK8KLqva640ObN8/HjhESu2O5AloDdG11u+4P+n31onRvAEhTe8a7SgC7juAWuyjvzZ4uudBw6l+HkixDK2tNnysJViWjGi2vpbj1Gv6uOfbTP4O8EeZ0xcbNXy4/NZpFHBkKyNXq77TS0RRr/ADrt4Q6m+FEuHy5QWJpX9IDEgA1ZpWoH4vVfqg6nkS+qbbtTe0UHBDDgBS5Abf3sE8aA03h3p+E8zQEQsVEske/0qIg1NR+mgzHvXuBpD8RZmHBLF1DKTzsmQgxQFqEKICEd17k0FpeBZvRDxX0TqrLDNFixurPvlhu2JYDiQFuUAH93dj8DVjE8HZUsYbL8xZi5kkAkiRPegTTOFA42iqH7XoM/zvHuXI18F5F4UbxtL9jt3FJDVcsvx7aZMaAuQM3H87y9rQug8slxRKdjS+5o+x+2us3gvEBLZGdgIWP1Q8OrfV6QGIJFd9oPfTKeooWYRxM4MayqRdP6qJVvZvcg6BV6/wBFmzsnzptorhNhZa7cWxPqH2C/Pck665nhdJCElKyOhLBvLG4DizL7tXHF6duqReWN/l+YXcWpNHtRYfcfGr0OBzuKjkek+/8A5tAkH8N5c9IMjzYlSzuiWPagAsArXcmhevvC6EMSf8vlqWjP+zSM/Wf6eP8A6rTh0mOETLAsksLcyCP/ALpuedpIq75q9MWTh48kg3EGRRfcbgO3PwNBi/izxouK5RFyPPjBVFkI8uI9vgFyLvdrK0llkYqC1ubIF+on7Dv3r+dbr+LcUYEePIfMMisYi1Hy6oXwNx/fSx0rwpjxR/mJpBSc7qs0K5jQUd133v8A00AnwR4JzJIjOItsd8Fu5oGzXcAV9+fbTp03xNExjWOEN5fEdNsNKRW7g2ff/lrzxH16bCl8mLIIlamAA3bUb3kLCizcUAOPc9tdeh+CJPLtCkbO4dpZQfSDyUVeCWurP0j20BqDxA88ZEaJuQklgu0Ekc8dr+TpYxYZjIZWYEmw32H205QJFGDCzhyv1CEfPy5IW/t30L6pgkWIQAPgG/3599Bl/UumQwSuC3DMWA/fU0Rz/CWbkTOUh3gew9v8nU0GiZM2SnlPDIVSIKzxFtpK92H++RRoe9jnRXpfS8bIilexkIykrL2cHm1IFUy8V/y1j+B17PyZBICmQEYAx0SAfaS9oocWLYc9ga0+5CzyReXBMsQbk40JAL0RvZWb1/1DcDdigtE3oOaZGTPiiNZmEUQRJZAvpEbL6gDw+9KAsWbaz7aROj9BabyZJYT5aRSuxZiTMwLA/dWRKbYfjtydaR4a3PuxpoCETduIJ2yEVtYre5S200lmuO+q4xQMmaUJC0KrUiPYU0KDXzRJNE0e/PGgXPBvhaORvzrEPDEq+RjKVS2KB/1GuiB7se5vtVaceneMsHIjErzMo+nYQQA3HC1wwscG9DupeJ4YsPy5emtCrROoaONSiKSy+kmue1hitk2L1lPQWYqPLWO4tp8xltlsgdtxVVF2WI/xWg1LxT1pY1EiRFw3oKyUnpJ5K0DzY/1199e8W+ViTRecPPVR5ah1aaNhXNrwyD70fYjWf9VzvPKKPzG3hDvPmNKw/qRFpeTwNt2L51Wh6K8OQMXJ2raiNXjptkj8hH7WxPDVe01zWg0bo2XL+W8zIzpi7jfJJuVVCLyu3cNq9zZq/a+1rHiPxdisvl4+SUD/AO0P6juxPcvKeSDwNoWqFduNA+kZMrdRMfTVLxyMFKzMCshApiT2AvcRV8fI419+N+iwLKzxRsFjCtKwOyNgSFCxKV3AkhqbsQNwFG9AKleGEebDP5s6v5g8qPbGtnncWAJ4sBQPf+NEOn+PnSNt+8sxIKoQqBbB9J+pGv8Ag6FYfkzON8ZWGwGWJgBEpNAlmB9X+81+/wAgaaen9PjwJg0cUGRaB1MlsYjuYEUCKYEVuI5+ONA0nxDl5UGO8OA8vo3xsW5DKSL9gRwb59xr5l69OsOLNlTrBJkKZE2gnaABW5fewfpA9vvwl9D6jlpFJiwmWJMiZfUCPQK/VJPstC7A7DTj1CKLNl2wyoj+UI4Qy7tiDgUQRtZqJINcFdBU6X44ZZimQhSJh5uM0nBINgWfYMQSPjto94/xtnSzkee0Ms7pxFwJN30qT32gEng6pZPgeKVjJlyvG21FCMys3p4oRoOE28Ad+LLG61VyOpeVGFwcRT5Z2wSZMpkC801IG2xiqrk9/toAeN4JndakldpPSVJBZgB9SbiaA7VXzo8fBKbkJR2AQ7i0xG6z6eRXCnv82dWD4vmRXGVsxWVwSFHmFg1EMoC1tsMCABy3cVWrHVOuo0bKBLtlaj5zqGPFnYiklqAq+KJ7caAH/wBK5GX1GOR0jljxysSkKNruppiO5Is9rrgaeM3peTNL5zTT8jhBjrUdf2nd/k//AEAWPj5AwjJFF6wxbGxVjpgQdqM/JbsLJse9gdxVx8Dq8zmTJyo8KNfX5MLbmAHc7EJJP7k/sNA4dS8LIYQ4mkjZPUWlFg1/cLFf50M6y0iCFY8iJm5jlKpxvCk2SbKL27e/F664Seam58kzJIwRLDf00Au2/qYKWJK2DuIr2IPhLTsgMrL/AEx8k/A7n44Y+/J7cAP8EZ/lxncCNwH6spJ3VdLXBDcknuOe/wAe6r9SyEO0RybHq3IRZCp/tYHizd7u/H31NBhWLPPCdiTyxQM6kuoYAgEENXBJAN0OdaDJHOVaVc+PKYyK4MEUaTH07b5CMrAXa2RVk9zpd8VYuRHi47TZPnQ7VGIA1BBwSaHIZe3q7iiCaoGvDviDMzkC5DBYkU+ZOy7i59goJC2BdkXwCe+gN4nWxPjRwM8m2LLjLeu3dL7SUq7FLlQAGJv7UddMnqMrtMcTJVGVmMsco4jFekrSbmUEAjdx6mDc8DzC6JFLFHLHISrbj5XlhKV1+hEk9PksoqxZNgkj2+iVxmyHlHaMJ5nHngOVAF7ys22rsgGwwPc6D48edWi6pDiQ4no8z1lm9CAALuBIPBB4Ioi1ofOhR6UmMi/l4oJzbwplSAf7YGjGQCFAosd7kggf5FZHh5i6RbXbGB2sYWXzGDkEek8nbwTfA5/l98NeBWglRjM2RjJZKswC2AaPG0NySNxPaxRvQLHQ/KiLy4kORkOI/VJHIjwwolFthYhlYeyEjg8GjobD4rV5Y44ghRQ5jnyUDncwLCw17NrE0ba65L61DrXh6cQvj4uLEmPKwLhDQFj1GlIJ/tpe49vY5H4vVkiR4o4YsbIJi2RqyjdCaBdmUb2s+ohQLFc1oD/SelyOs+bMknkzooR4CkUpQlVbbHW0q3YgVx8aseLentTYiRq0CuqybsmWdobHBVSdkRArvZG40CL0tdByppIkj3PvwwXAmeoWj3CqXvuBNrXf/iV6rFkeU0gnj25Ad0CqyxDeNzMBRpj6wKO4lSex0Cn4w6KMaLG2yq+4SBlU2Y2UqSpP9X1KbrveiHXOqwBcc47yeYkCB9psPZAbdd7Wq+ef6eO+uaRIcaKKNfzE4jdptigeWlgABxe4/NC/a9WPBX5+OpMKMzKrbpE2fpsE9IB9IDMe9qxrgmjoB8XWH9Ue4xQSGpSwJKq3sTW+iPii3HIB05YHiGaLGWTHX8nGoYrHFjblkAutzBmkLGqJLIAf7tF/HvTcSbNiyZspYxJCsRx1UF23XXevSLB9zY47Cs76hNN0yeWBJlZ1AUAFwqEi2IUkKGBAHNjntoGPrcyLB+cX8xD50nlyeYgDKxQEMFBB2n1Ac2O/c6tjxeidOLGJRIp8uIovDcHcq/KR+hQxvkN86zjJ6jkZjjznkmIFgf0qPc0BQ+51xgzJPRTb6O1IyCe/uvFdwPvegbfw/wAweeJchkZI1pzMx4WiLNk+5Hp/bT30/OxquGSHJZyVWWVyhs/07UAI4FBQwuvfWcqj4rsssBbKk4EJTcG97K0dxvsPf50weEeiJKSXby55EMkzFQAEZqRI17c16iOwsaBwHUUbcsk0hAXy2gxwYVUjg/Sm9vccuR9tAYvCGJIFnxXnpX5j3BgpBBIdJNpN/AP3519Jg/l5WMRJ3kblLHbfP03dEn212zupJA0M84VHMrRxxo4bfRreSANwqgOO7H40BDrPXhhMvmYyEAKNyekEL2BBJojuCPitBMn8VY1K+VCqKxHmKtlmXjdzxRrsdffUej5HUlmkEm1BexSPjWPSoyllbupo/YjQb5138RcPH8tscfmWkQFkCgbB/TvYjl+SK7/P3msa6IzEG1BHsTrzQdpOjz5EhKwiOo1dmIKoQQdrix6VeqHtfuNNPheOSWOOGOVYlVr2UWBpQS0gUhjVjhOPVdbhelXpvibIhhMf1RspQE2CKBoBgeyMwbb29jwTqtgdbaLhkEiM4c7uGDDuUdeUJr2+BoPrN6tL5h3TSN5LN5BQkKln+kN6lWgKXj27aeOkeJoJ4Gacu+QDH5gmryuWRPMuNVO1aDFW979RvSxiLhziefJ89AZxTb97BCHbZz6nc0Bvbge+i3R+rY8rthYOMsCzLtMs0lu3Y+r0mzf0oCBuruaoHvoea0kBlxSkij0o8isilrN0u7coHxuA5vgcAp4aWXzHjyGg2zcbISFojkNtLFmPzR9tK8WKmFHPG8gxxvIjActsDre5kYWva67Uavm9Aep9PaHJM+NEEhjeMCWRtskh7sYin0qV9Pb0gjm+wN/iifN6Xi5MrTl3mkVIJ0NgAEn1LdKaFcWD7/BH4LzdRmwo50xXJhlcem1BkC2zRggE2bqwSWugAdcfFHVocmSERySu0QvyGLHZuU7TuINOCRZ9XF3zoZ0nOl6XI8sscSShGSCMEHzLo+bIyEjaq8CgCxavYnQXGxMVWeD8y0zBBAchoTJIqgFXEe5ikag+iwpYXe7VPPfBhCYi5E0j7j5e5124zG28wsi07k8bOfSSO9aS+m9TaOPJ3kkyoUF8rbMC37EgapYme0fAVBbBt20WK+D2Hz++gePBnRH9WZJKhgG9fLMwRpttuy8sACaY0fvz8GPDfj7AxRLHBFkRLIBQYr5YIXggEnYbJBNMSAD30hRp+Yf1MHAaya2tQH9QA+fg331VwsLcZVDlpIyNgUWGFncb7AKOf50Gk9P/ABW/RlmnTzciyqoeAq+mq4+k01+9gex0IwHlzZZ8zHxZJp3BQb1HkxI0e2w1/wC0Q8gm7B7XoLj9OjdXlV6YFUZeCQeLfYo3GMk7fj576c26/JjYUCRp5MkYVvLEcbLJEzU0m42w7ULCHkcaBLxvD8xiKop5u2CtcncEA2FkANN/9jq30nogiCyZNkSgxBWVg0brVFq7Lw1Fd37fDn0zqWIJIHjlj8yNNsP6hDqpsekuCCQGcEc2FHPqGinVMfF6hLDFFPucsxWZ0sNtBtI2NXRBJCCv3rgPPBHhzpuPlRTrl+ZOVY7XYemxtHp2hge/LEXZ41X6j0lRmZU+DJFHHQRw9tclXagqdi39zfNVph8L+EosQquRFFLLKPWyJajgk2TTNZ7bhxzrv4lxsWXHmjCRxEDaHVlWTjkcAXtJ42/fQYx0rLyElkE881RliDDRJcmqBYHYDZO6uOw5OqPUOoMJC7IsjOgRSQf0lH9KXQ3kd2I7knudaqPD+OkcWROvLDkoeW2Le2iNvr4u75o8EaXen9OaV5BFDEY25ZpE37D32jcbHFXz8H3rQe9F/ER9zBgsStSqpsRxrfckAszH3Yg/AA0u5nhpcjJkeMtItgyGgi2/I2hm3kEdrFnvxxppiwcTHyU/MYG2he/HlJQn7o/0/wDlb+NdospWlfyiFS+GKhXauwLKO57WToF/pHSEx3kWVgFHCi7r31NOr+HjQRMRx/V2+fuOD31NBS6Ri9NwsSXFmxJTI5VJfM2mQo9WyMoraqndSEn+brO+peHd8rR4GPkNAo3PLLHT7d3Jr2UCva+NaX1nw4JYWfELRziN5WEpMgc0boknynW+30/A99Z70jxr1LeAJztCU5CRkhCO3qUBtBy8TeCZop1XHhZ0mA8oK2/aSL2u9AbqG6uBR+x0PXAkw3Uh4nnYbfKDAkeYrDkg8MpA9+DXOnPG8a5MeAu6Bpgok2s1eg90dlUUwAPc9vUNInXMCa/zMoVhLUj7DflmQmlfj0sQpIH7aDtJ13Lmkd0J3eSUYABj5fG62YEnsKskgUAaGmDB8UTJAyTxskKOFjJAfa/DOhLAuAw9QK/Sfn2V8Tp7N5f5XzJXk9BASiHqyopiWFdyaGm7K8KZEkC4zpJB5bPKTIwZewDE0d9CuGCnvyO1hW6h4TM3Vvy2MsmMsi+bb2TGu0ljd+peODfvXtpgj8BY8yCdppGgk2hZItop/pIIY8bpAV54tl++2v1nEXJmimaSVH8ry1ixGQ2i+mo2JG8Em+eSD2Fa+ulwSR7+ntvGJLZdW9P5YekmRZJK3bTy1ADddA6AT0jwaLZog8ph3iRnhJUm2VDFEaZiu07i/pDFQQaOqMnhIPJBjIztmZDEk7CkSCrPdAzn5IoCjx20U8KdVMbNBkvIOnsWeGRtyzIS+1ZImX1IxJBa6U8335KDon5TIaGDNp8pNq5WRfMbEljBt3KzEcMWZWHNDkHQKg6ZFBkPj+dGVjNPMtsXZRysY9+bXmhxZPHNTCw8ZPMDyH1WDTEBBfYkfUf3/wAaOL4dgQbUaBNrUJXmuSU0apV/2aj+3aWNg2eNLYMjwzxIQY4mEr8/Vt9FrYuqrgj40A/pU8iSgxmyD/DC+xFiwTWnPqvVYsk4rKTAWuN027asDkOKDxs20cnsL450pZRWSVmiSk455Per3E/z7V/Gml0ixxiSSoZHQ+hPS0ci3bBuBxV0RffnjQVuodGiWOYo7yLC/lhVO4k7Q0hRlG3aCb5HIB1S8OGd2EaZKxqh3hmlEe0gVYs96NUPbjTycDEkFWY1EO+MxikKC7Ui/UyWAz1u20ea4G+EulSfl5neDz4opKMcaqzWPezW5Bfe74sAjQMfWPG0BWSOfLICoF245tpZLslWClVUe5J5JbvQta6f4ohWRTGs0iICGkCkcHtZbftA92Nn4ruOOR4Vjdi1bUYAnZW+FiLIYcI6i63dxzxXOryeGRitHJHPGrIQwpgNw7H6d31X/Ug+xOgc4fDMjYif9sU0pdG4MY3GybLEufuW51TwOqpjwqIYzkJR9UQaQs7HkE0CzmgTQocAdtLvjTr2ZI4iWOKJFU1BuolT2+x+5479hoH06CWVKmeaIxj9MBnCCuNisvpBb4NH7itA4y9Vkkha4tnmHaoYeofuO4P20wdOjjhjUNsAVbdmPAA5JJ9tIo8b5UTpDcisVFAFCjk/UaYV9QKnnijohlePSx8vIhRYWtWEkQVrWrogUSDZ4PavnQF/+np/NY4yyGNhakEBWXj1ANQ9/wB9TRDF8QYKoFhkVYx9IMJYgewNHg/+lfA1NBned4tncRY2HMYo/LETs8aiRhW1hK1kEIouxVc/GuePiOmHlYLLE/lyqRIrC5C4Air3ZSWQgmlojm+NU+l+Fm/NtBJKAh9XqbY0yfV2PqUld1kjg8C9NL9DiK5f5UvjgIIAk2wbTaMTuXcWiOxakbsxP93AAfDHVcvpzNHlQyyYjgq8fZULc2GKkD3Brjk3oY2PjzOYUljiQH9OWaozSA0jre0kkkeZf/E6buhdSjwUeBFmlZ2Cl5YkIF1SX524oOTwObsa98SY0LTzzzRrGdi/mVceY4Y2irEP9m4chWDnbW3kg7hoL/4eYEQEX5ZQKUGbIVf1N7i2jDcBUTsT34qjrPutmKPKyI5I5InBfZK5YSMfbcv0kN9gODo5kdUzsZEXKeeLFfeYwEWKz3Rh5R3jimIJriudfUbYGU6JEnm5cq/qGmbc4WwU3UAT7iu/AvQUeqddMUOH5Rm9FPNFKnpRgeChIsKwsCmo0RWiHX+sxvkszys2K+QWKSFjH5ZCFwjDlqarjA4IXtrzAkPUMdsLLUx5MR2RzMpVQUBIV6F9gfTRvuORoT4n6ZMh80KkmNGBGJFZWDEnczADkOzh2Nj0ggEdtAewunzQTLkzyrEZI1VAymsiM0oDoVbyR9J9Q55A11kxWy8NdtuJnZnQuFA8stFcIZSo9IFngglSeOy91/xbLnZSziogI9nlq7MKTcVL8AMbNj9tUsPqL4qxSeUxUbQHBKkMAGIDDhqu/ULG6ja2CBjxt0+SFIiuOowompHSUsxJ9ncksv2AUKPjQDomdCom8wbn2BoQQCN6kdyRYUL3HF6P4/4gSGRrTHSNgxkUxWuQBdCQAEhiONwIo8/vw6ljdPKNJi47K8yqVWaQ7YPdtm029jtv7fGgr9NwMZ0jyd6+qYrJjmRYwgIZjtL2aoUG9u2vOr+IYvLkhWD0HiImZnaKvcMR6r+OK1f8O+FpVX9eBmjmKxegB2QWHLJV7rC8stirHfRnH8O4kuVPFiYkI/LIWdsuR/1NykAKikKF3cbrsGr+NAqeAetNitIzt+kEYlTyCxVgB70W4GqeF4laBkeHcrKrKdrbbVqtQRz7Dn5Gvnq2ZCYmjSEI5Ib9Nm2LXcU3JrtfsffvofH09SUBmQF+fchP/wBfwe3Avg+2g0nwpF/0tkTZCSeS6RoNh5sVTH08kWKurPF6udOhTfEGu93qjY+WvANEODZB9t1k37a6/hD4ZljMsobbvVhE4N+nsTwdh5FgXfF1WuPWclpZy83dRt9TG6X+7tzfN6Dri4s0k5XqCJAgYncVrYnsI2BZXJFUfYWTdaqLOkvmR+XPGjOHG9SkabGGxmVl9QIC7ye1njRvoPUGUn6HDxhQkgsHnlT78ijY1exmhC7JWKmzW0NJGi9qtwZF+K/YEaBE8R4rSdUXyytBo9jRUdyggA2lLbHdYHzzRJ069V6YZA8TFLCsaHJjVvSvYECq+pu49uTV1+gsu2WJVlaPcFeAhGKmv6UYBuABRHcdtBZOs5PmGoTI4BVWnTa3PcXQJFgMCQeR99BT6f8AhvNTSw5EeOXYEwyWQgIFW3ptz3oCgCdTRDIYzwiLqEjKVkZkIaiRyFvywosg/GpoFuHoU8bt5BBimUpv7yhQ6klI3PHFANdULHbn66DGIMqebJ3+bjUFS9ieWxCgDcPUp9W4ml7971rnTsY4eE3nyeY4V2sm9oNlUBPsopR899Zp4phTJjhHUc78u1ssZC+mUbiV3cemgQCSdt1oL83TMZxHJK52Im5UUIKG4uG9RJIqwgrlRXsNVet4yMI5pl3x7r8qL9MpGaVA7AHe61uNjgtpM62DiuiNJuiZyVuNh5fl2fK2EngkrRVqpge2rPh552yVkMTKkoMckJJ70CWAPK/SCCeQVHfQe5XRJWlL45WQOoeN3HPu6oW5VyRYvsdnNXWhhEi5H5eSM4ZFORGGbaSLvap4NWb7DRyXrWZiKQsaNFuIBRSGUD1GiT2rdyAR3PHA1ydep5TGbDx1b0bAyBT6R2ALm2IHc8m/20F/NyJMlRjNG6lnDPOHUeaQuxHa++0EHueeeK1WGYXWWB4fIEVIZDbmYpdPIlbZgoDMPcHbRN6+8bwfkIySZmW8TijtWnNEEFQOysAeb45PB08+G+mjFg/LzIrQyKGiklpqsL6G3ClJAA7UK0CD1bAleKFOm7Gi/wBpEIQAzsgPmGQEb9y2oCm+D76XZJZZsf8ALnzDKJ3kOOyfQrKLcsRe6+B8C/nRDrfSciLKKyQFBCTKI0lrdHwAYzdswHcjmq4404eEvEWNOYmyJ5ZPMDCQzRqfy7rtKnzAn0tyeTQ44FaDLl6JJx6WIujaMB3o2a7X76ZvDPRhJLHHJjyTs17FUny0rmi1iiK5v54s62abFj2BxIZUYhWK7SKc977Hnk/7wvVaGaLaBHIjqhLM7GxuBG3cAfUaU8gXwPvoAfhOc9PQJtC+a29t/qYcV9IPccmh30f6jmzySxnbG0DIQTtBEp77HJraGHG082f2OvnJ6Cvm+b5yDzaDMSK9Zssu5q+rgULrS91ndizyZMTvLBDFUimQDd7m1I2OhHI9+DR5Ggxjr/RcnHl2ZELQlvUqntRPZT2IB40PimKH3BHt/wC/7a3bJ8KY+bGsnm/qna8ZJLiMFi+wLdBSvABHeuaBAA9Y8EyhmZkWZCEVnWmdiLrZQAQN2bubH+QBeEfE8wx5MaFxH2dm3UaBo+Wt0SV4Pv786uQYrPVksT23fSPv+33rudD4PDhx5DI2O00SKS4j+oV2IJHqrgnj502eB86ZSI4IwWmYb1dLBUgAjvar3a776Bi8L9ALxrKWTcDRB7ILFm+10bA99CvxB6HlYn/aGYT44I3MAA0dkAWOdwuuee/bTl07p+yJ4sRzEyybiygMZFUnj18EE8EijX+dZH1rxJM/UZF6lumWMhVjBKRoR6ltb5Ivnue2gM42VltPGlvGW9yyhHsbrpfoYduBzzp7y81sSAnNdX2j0LJTFj7AN9QOlboSnIAyjDewUQtgOt8VzditEfFnVemq6NMjFyKK3Z9uLPb99BJfDWLnquSzS4pPG1juU+9r2Opq3gdeimhQAkqvZT/T/OpoA5izseL81Mr5caQEFVYbYwps8H6jX9YBIHPFaUvFmUjQwzPeThSWisW/UiINnaT9LUD6TwQPtoP4Y8UdTwZFZPOkj/rhdXKOObHI4PJO4e/e+2jfjjLi6lFFPDjTQ5jy7ZoArCNwL2s7lVTdVeq7AJB7A6AXmdOlixY8iL/tGMspaGRueyqFDobPoooQOP8AGrsXieN2/NRwiJ/NSRwsxc+obK2nlgW3HYLPueOdEsfpQWJMS13DGYSq6M8URLiUvuBp2B4UC/350u9d8NtA0M0Kh95Uq0RcAk8hWDENFQ9Js3+3uGs4a4OUFkaNGm2xtJHXr/UQFVI7m1b5I0Q8TSyCNUxodrlrVvpKKKFjkDua5NayCfGyMSVfLgMkigTMixFVicnmO/qfaNotTd33089CinlTJfMSYF/LDx7zarIvPl/2HgEqfteghygg4WONnkCblj9Ppvhuzf8AmvvXbXTqUYZX3+ZE28u0nmAozV6ioA4rkDcVq71U8SdNaIS5GPHH5MYpFJcysQwFbRfJ59R7jSh4kz3nELxxTMBf6W2S1bgXsIq6sblO0m750DV0wQyx40K/rSlXhGbI6nYNzcIp3At2r7dia0s+Lcbp0CHHiaSKdWKz75SwY0D9CnbTWPVQArterHTIp4mnj9an0vAxjIR/LtvSNvpRlABBP1BQDY1aycjEmkczxkP5cf5WaOCT9NgSbkVhRIIUNZIIHAFnQIyRzC0/UjavoQsAR3HpB20e+rOCnkyieLI3SfSVZdu0urKQwbgcE0dOPVCVGHOj5M8Pmbsn0OSpIZbjDLujU03pv2WtC/EPg6WKXfEHbGlVmB23XNlaI3EEgbeP20A6eDLC4rLE7bXZYHjcua9TbR9VHv8ATXAJrRPIn6kTHPkpHDjb7WKSRI42Jvdwzbmb39QP8a4Y3RnLhXjaJaWR5Ah5XjavcWx4HcVbdudNrZblyq+ZIUpT7CVa4BYgKTw3+0shrG4e4DvDWSmF5kq50aQEEtCoaRRwSuwkABgxv0n3PB019M8TQTIzFTj7E4CkOyjuSwS9h967iyK0s9Y8JrkKAnmYcbc1Ku4KSez7VO0H2O817j4+ovBUmJGzK4AofUrMrKP96NDV+9r9tAx9CONP6ROryqxkDKakUEkjeON4bkbSOQRx8WcbpP5kGWLy42sKY0Bj9IFEnsb7Haf2Os1x8ZZ5/KEIhH1KUMix7/lWoUf4Fa0rw1jTrDI2SYmlU1HICWZQPdmFWK9jwdAM8Q/moposdctojHQjlRAo27eVYfSa73+2s5ysNfOmVslMgGTeZivqZ/cA3/r203eN/EokWo8aaVgdpm8sqWrstKKK32J50nwyMu4vhzKXPK+STf8ANDQP/RPEiY5i3lDGlE7OCTz39idUfxPgxc8x5OMzM6qQyqtd/mvfVPo/W8EMFl6XOOeCxkofxX/HTm3UokgeWDpu6JfqPq4/irP8aDMEz2hVURWU1zZrU08YeVi5El5HT1ij22r1IbNjiq+Dd6mg2QDUrXupoPkjXyGGvs6znxP4KgTEzp3VXl8qWTzSo3lqZr3dxXAABoADQaIWGpuH+dZf0DwPDkYuLOoVJo2Dh1QAmhVEjkizfN9tURj4uN1yQO0MCCOJgW2qAzBtxW+FJrkjvoNeDDUB1knWhizdbxjitC4aMtIYirDzA60x28b67MedfXj7p2NH1TELiJFljkMpYCnYMg3NfBaieToNaBGpu0g+COl4qZU8vT5QYbEciJwm5Fu0rgj10SPcEaIfiV4ZXNwpAqj8xGpeF+zAiiVB70wG0j9vjQNu4a83j51ifVOlQ5XRIs2FF8zGCuyqoFxqfXGwHdRbGj9/k6dOoJBL0cKqpIHVUhBUEK70iFQPp2Eg2OwBOgeCw7XqBh8j41lfiDwxFB0Sf0gtGheNqG5TajcD33MO5vntq1hZfTT0p4ZJsUny2YRlkG1wpohb4e+bHN/fQaXuGoWA1mn4Z9Ghm6WFmjR1dQzAqOW2j1H3Lj+7uKGhP4ceGEy+noZKayrurCxKQGC+YTywWyQDx20GxA68DDWQdY8NY8fWIIFjTy2xwWXYNpO8i9tbbr3rRLxB4FgxcLPZFXYVeaNQoHluFoFP7SAKsfJ/bQadu17rFehdKwJoMTbLGmZuVkaMDf8Apjcd5BujVEm+SNbLighFDGzXJ+ToO2vK17qaDytTXupoJqampoJpY/ELPjj6fkq7ANJDIiL7uxQ0FHcnTPrjPAHUq3IPfQK/4a5scmBGUdW28NR+kgcgj2P2OlOPNx5uvy+tWV0iVD7OyhrCnsxFjtrTcHp0UPEahQfjQDxL1CGGaNBCJsl1ZkUttAVaBLNTFRZAFKSSeBwdAo9fy8deu4io6+mMo3PAcuKUntur2/bXvjzq+MerYgaVdsaSJIb4RiycMewPpPGmLB6wMp5IZ8PZlQAFY2ktGB5BWTaCOPlQRx++q/RvEUXUHdPyTBoiyVI4+tDVem6F8bv9DoPkeIen4+Ui4jpJJkPc2w7gFCH1EjgMSqKB7/Gn5TYB0h+HOtQZeQ8Rw2jaByjbnDU612A7jn6uPbTP4k6s2LA84iMqxgs6qwVgoFki+D+1jQZzJitjdQn6cUvFyXGQvxtJJaP9jJXH9tj3154RxpYshumSBiuLIxjY9nEg9J/8sZYfuw9xo7J45Vo4clsFzGWQbw6kx+YQASP3IuidX+veK4sSaGWeCoJTsXJDA7bFjetAqDyLs1Wg5/irkxx9LyIiwDPHtjXuzEEdgOTXv8ao4c+IOkPMXXaY3UG+7FWG0D+6+NvfTL4r6uIMVp/JM8Sjc4VgDt+RfDftY1Uxer48eJ5xiMYc7REvJZmNKq9gWP8Agc2aF6Be/DHrEEXSQ0kqqEARrPIbb9Nd9x9h76+/wRyFOD5YPrSg6Hhl79x3F6tydZkxkeVenAwAEyGGctIF9zsMYVq96f2NXqdS8TY+F5EsOKXjySFR0cL6iLpg3bj359/5AJ4h61AeuwN5q7ViEZa/SH8w+nd23fa9Nv4ldQjj6dkh3AMkTLGPd2I4Cj3OqCddiny44MnDaNnQtHJvDqaIFcUQeR7adHxlK7CPTVVoMt8OdU6WMCGTJmjDxeoCz5gIWiAo5sixVaf/AAr1Y5WNHKy7WKgso7AkA1/F67R9Ax1FLGAPgat4WGkS7Y1Cr8DQWdTU1NBNTU1NBNTU1NBNea915oJpO8aeGWyZYsjGmEWZADsumV0JBKup/pv3H3046UvEHR8oZS5mHIC2wRyQyXsdVJIII5VgWPzegq+FvE7S5LYudAIM1FB9JtJFPFoe4/Y6H/hYB52f/wCJn/8A7W0Sw+g5D5DZspRcjaFS1JRALpQNwYiySSSCTXYADVPwb0DOxJcgs0biZncMUK07tu7Bj6bJ4u/voOP4dD/4h1P/AMVJ/wD500+Oj/8ADsz/AMPJ/wDxOlLoPh7qeLkZMqvC/nuZCTERTN3oCTgcD311k6B1KWDLSWWPzMkFWcxmgu3aFRA/pobjZJ5YnnQDvC0meMTF8tI3xww80KhDMpjPcliCN226APbTH47xY5YcSJgDG8+1h7UYZgdD+hdN6tjYogRoLUUrmIk9qBoOBf8AFarN4W6j5GMiyx3jvvAaMsXYhgxZt4oNvY0BdnvoobLmyYWNl9KynLDyHbDlb/vI6+gn+9e2rHjuYpL0le0Zea/jftUL/oz/AOTpr8X+Fx1HCEUgCTLTRv8A2OP9dp7EfH7anV/CS5eCmNMSsiUySL9Ubr2Yf+330QxGBDFsIBQrtIPYgijf8azf8TY0XH6d+WKFDkhkPdSDG5FUeRXwdGsJOrBPImaIgDb50aHeR2sAtsVvvzXejod4q8HZUkWLHjNGkeOwdIyhaiF2gFiw9IWxVX99AT6K+acn/taR+R5aeUyLtVSC269zMdx9PN1207az7rPTuqzxJEWhVAyFwkZBYIwatxcgAkc8aecJGCKHNtXP76Cxr3XmvdBNTU1NBNTU1NBNTU1NBNTU1NBNLviKWVZsRY5mjWWXy3ACmwEd+Nykg2oF/BPvRDFpV6jkfmMvGjjDXjzs0tqRQETAG/cEuAPnn4OgNZPUUjliia90pIUgcChfJ9r9vk645nVwjOqRvKY1DOEr0g2QPURbEAnaOar5F1M/o0kjSybkEloYG9XoCEGmF+qzuPFcNX311bAmSWSWJkqZV3q1+l1G0MtfVxQKmvpHI50HTN6yI5DH5cjNsDjbt9VmgoBYHdfzQqzfGiURJAJBFjsasf44/wAaA9R6C8kyzCUK8ce2OTbbB7skgUrK30snFj3BqjsO7aN1bq5rtf2v20APw3JKZswSTPIsc3loGCDaNiP/AEqCTbkWT2A97Jv5nU9jmNI2lkChyiFQQpJAJ3MByVYAXztPxoXjdMzIzlNHJj7p5PMUlXpPQqCxfr+kHuPfVtulypP58TqzNEsUgksbvLLFWBUcG3axVGx2rQfT+IoRHFNZ8qVtm+uEbkU4PK+oFTxwe9a6z9YCRySGN6R9hHps8gWPVVc/N/bVZOh7Yo4hsdPMd5g4P6nm+YXodhbSE0bFcfcck6DIuI2Msu8l7V5LJChwVDHuxCgLuPJqzzoLo63GBLvDRtCAXVhyAb2kbSQwaiBV8gjuK17j9V3SeU8TxuVLorFTvVSAa2sRYLKCDXcaq5nQPO89pGp5lRAV/wC7ETF0q/qIdi1kD2Htqxj4MhlSabYXjRkXZdHeVLE32vYtDmueToPnp/Xo5ghjVjudkYGgY2UEkOCb9uCLBFEcEHRkaXMLoDJNDPvAdVKzKoO2TghDzyGWyL9wSD2FMmgmpqamgmpqamgmpqamgyuH8Z4DJsbEnT1bWJKmj9gCS1+wHf20RH4mEEb8DIjB7eYVU/8Ay/UP8ce9ayDxDnRLlynBt5JHVBOl8Fu6xL/T7ANR49xpt6Z0uXMiGDkcSNHu8y7I2nhn+CDwe986B+k/EOIMF8piSqsfWtDcSKu6LL6SQDxuGrGZ43WLLixHx5Q8iht3dQDfuO5FcjWW+HZFEYjco9SNFOL43C1EiH5KkcjuK+NdPzMsCqcpneKtgl5LQMNy81yynkGrIHPtoG3r/wCMePjZMmOcaaQo23cpWiaHa+ftq7J+KmOrQhoJgst+o16aruPqrn49tKuJ0vGxY0yJCMiRlsTbgRIf6eT6Wrgc0ePnSbmdVlyWyJ5HKZDDYsIFMkRP9N8bjxwOToNayfxVhUbhAxUhqJdVsqLI54vj50Pb8accEbsTIC7Q2/ggAi+3vXY/fSJPhPjSJEI0ymIJKsu5RdHcOOHX3NfbRrocRlx1WZ959UZpdypGyFAR8SBiSRY7N9tA3Yv4qxSeXtxJyZELr27D4Jrcfbi6116h+JoikdPyU7KiBzIpXbR/1HNr+4/nWUdOVJDGs+RtRCqYvOzfH5lFxxag1f8ABvV7reS2TJPjSuzPE58maI7VkQIGdPTwXIuUexO4DuNBpWR+KWMkioUJDqrKyyLR3fNkba5s8/665wfipGylxiTbAR69y7aJAJu69Ni/+R1mvQvDaSeSHZ8iRgzJtlKh1WiqC+F3LdfcEGjpsy+q4xx96xNj4ighmZVXkcbEUGy18cj5vQNf/WGglMLQOkoNbWdRYItWUn6lPax2JF9xr4i/EMmOWQ4GQojJFGrJuu31KD7MRX31knQ+qwPEMbMd2hZqx5xw8BP394/tzR4qtMmDjZ8LWQs8fl+iZa/UU8qVBPY+6+xI7g8A++H/AMQY8qZoRA8W1PMLSOv03XYEkG/6TR1UzPxPWNn3YGaIkNGUxED/AAea++lzxfKkYizDAkzzRGNmh9PJqtwNqSGHvXbg6W8oYmVuEQnVxSlGd/U1Em13bCorghgT8HQab078UcCcARPchNCMnax/ax/po71TxCIMeTJeJvLjUMaIuiRdD7a/Mni/pf5SRFWJoWHqBIYX7gqxdgR/g6ePDf4sq2O0PUgZG4jLqPrjPDbgOCQOfvoNX6X44xchQ0Dq4IutwVr+Cpojvqx0/wASec5RImLC754tSQRdVfH8g2Nfl6XOjgmnSFUljLsEc2SUu1q+x7c9+/OtR8C+IWaBpvLk8vd5JAf6WI2rJz3LWEY/YdudBo3UPGDQECXEmXcaU2Dehfij8UcfBYpNDKXoFAo9Li6JDmhx7/fjVDwr4/jyHfBzAIp0PloSp2yFeONwIB4sg/eidL/4m5EkGPJHm1kpMCI7VQ2NIQSuxhRKcAG7Jrk3wQvf9fmL/wDlJ/8A5l/99TWBCInkDXugecfMjPVMaZYpFiBUgiy/l805FkKB3/YXrQ8tJcfEyWxxvnlJ3G/UI2PGz59gf3vXFOhOjyzY2Qv5jIjUKNgCqgF2gJBI4+KrSnkdTycKSHFMkc2533OCwDq9AAggMqjmh2I7caAl4Pw1ij3RxOZX/wBo8tCOJvcJ/TY57Et+2mLqGKbUGnQsJQN3G6tjj/JQn/8AcPwdJGX1jMEjHJj87HQFJFVQgQXVjm9vb7aNeIooMbCSbGea3IkMU7C3ApWMY70A1E9j6T3GgBeMMdUQQ7mixZm8yIqpePeL3Lt+uFwTyAWBu6Glrp+JN6fKhkE92r+5NjaE+96a+neMsaaRYp0C4715gkNnev0Op+lNvbnuDzq7+IXXRD5UCwqcdgP1U/rT3UfDAff4POgpdQzZizhmjkn8reXRzuXmmRl7Iy8Ejsav3OivS+v5cAVYExE8xQvmSyhCfks7NtNexHP20i9Mxkpwsj7SNwYLyfVwK/aro+9Xzox1PBLiGGaNlSMMm72ZyN9qffv2HyO96A50+WLLnYZccJjipGeNxIh3k2Y2A2qRwT39+2ueTA+O+QjIGhl9UcyoWWL9PZE6nbQoek9vq76V+vZkuNGuPGhRFPLkUSf/AEP/AC05eA+owZWE0DSusyKwYe7KefQO1+3IJHtV6BRfxHLhSmKIcQTrIgJNLtFfYsrA+47H551f8OZcfUcmXz/LWSRg6oF4c/1BAQVVjXb+qz71r78UeH7dcgBfy8gSJGCF9u30EbBTgiuLuyrcnSbiY80c4iVWWa9m2iGs/b2Pv9v40D31PwwZpW/KTwZLJHuKGQelU7qyACttdu/HzpY6N4ylgtPLV8ZxT47E7TdWVPLI33H+NVM/p0uNKROGNd5Izd377j3sXw1ap5JjMcdRojljbhm5HFWD6RV91/nQPfiSKVsVMnDZ5cP6pYW+qMnmmA52/cccX86CYPXEjFEBVlFblJLR17Ff6lv3HPP2rXJczLxDFKnpMKbDRDo6kk+oDgqQR3+3YjX11/EgyIDl4ZCAEefjE8xM3Fr8oT7/ALA0e4d/+sDJjdo2EWRj8DyJv1Y6H9pNEfxr2JOk5pPL9NmPaz5uOT/o6X/IH30orCCL3Dt9/wDX99VjoGXrvgnLxl80oJsc8ieA+ZGR82v0/wA1o94B8dQ4yfl8yFnhpgGj704oqynhh8GwR970o9C8RZWG2/GneInuByp/dTan+Rps6a8PV5BG+PHBk/U02P6PMUXdx/Ru99w/xoAPjPqqTThIZWkx4kCQsy7WIoE7r5vdYv7DVXq3iOfJhginYOINwRyLemrhmPJArgaZevfh+0bIsDbmPBVuDY7/AGHJA78/zpOzulyxSPHIhVk+ofH3/btz9xoKqykdtTR7A8KZOSsf5WIzMVZnCEErtbb6vZb4oXzydTQaz1HrkSToZ5qo3Eq7kYooNq9AKCSSpVCbNH34UfFSCXIeaMSAEgizudVUAcnv/wCtVydLHiDxQ+VBDHLGBLEbM1nc4oBbHYH5Yd6Hxov0Xxa7p5TpHdfV/d7m7Nk9/toDeLP+bxxEykvEyh5FO0lH4AJu/bknv21Y6ljx5rSKu7diqI0UgMrBAV2CiTtBbdZHNg38GPACRuJiILkVCWW6ZlHK7b4PI18wYSJI3UUka9ltGRtVhR3obFgkGr+a0GN9Y6e8EnluK4BHwQee/Yn2JHFg6rRliVTlhfpWzVn4+NaR4l6BFkZjyJv8kRg2eTvbnbfHKkkXyL0ZxfDRg2xJI0KyJuJQLIHbsylqsWPg1/6hn6dSbHkWIxI4Rw0itYDkAULU/SODx3I50x5nVXyYFmIUMX8uRbJUE35be55FqT/uD7U1eKvCEE0CFX4Q1vYABqFEbl9Pf/j20ieGcdoZ3ilBEclxkFh9O4EFSeNymmF96r30DnjZsT4ET5EkSSBCH/MMtPXHoq2e/bgn5+Tleb1RQ4OOPL2k7WXg/wAe9aa/FUjveLNEhlRg0bK1eYp5DISaax/T3o8Higi5UI3lUBJB5HxWg2Xw5FJPjxtk7SmVGW80AUjLtQEc8Pfxxe48Xo503oMCOIxHHFOAX8xbJlX6Wc2LDWT6dx5P34yjwB4tjxGkTL8ySDY2yH6k3tV2CeARfbV3wt17zW8p96woVmG00sOxuxPfaRSiuzUaJ0GtR42HAhSTGkk83u8qBw1gesxk7E9gKFkKo0NyvBOBhNHKwpXNIrKfQTVDcSVQHtTGiTx30rL4skh8yOISSyyDeoBsb3b0JJ2LrtsjkUQB78fPSfxPlSbyskhPMOycNvAjIJ/UBDMRd7SFPZQeNA59e6niwYmTGESN2hIMbfpAgg8be3t/TYPHFHWGeDUxmykTLIETqylmYqqEjgsRXF8fzftrUvFnVcvFgC4eJAmMkZJMlyOvt+mSw9FFWG0fN9iNYcToHPrnhYxzuicKJtm9ASg4BUBmYBibU0Pnvxpfz+mtG5Vlau4I9Vj5vj50d8PeOZIQkWQi5ECsCEfkigRSk8Ac9q/xovNJDIgfEd5I1G2SFywCg9woFspawN5BA9XNUNAqdC6DJllooELSL6iSaAXcF+e9m/mgfjU6hgZPTcplJMc0LcOPY0CCD25Bv9jrVPCxgkjMMEH6asDsIU3wT9RHrJsjmqHPN8NErscd45E9CgFYtyl1UcUaBtFFckE/txoM66N+KDMl5uOku0FfMiIR/URfp+kk1347a7+Jep4c8Ev5SVfOlK1FIlNIDxtBF7iSbHamB+Todn9UxPNkjyYpIwjVa1IjduCCiuLA7j/npSlzceLMaXHiLwbiY0lPIB7cj3B7H9r0G5eGIsmLHjTy03bQXaPhroCnX2YAUT70NTWaS+LpmVJQVt73Gt1EUKJbndQB/YjXugTMhBzx9CitHvB/SYWmTzU8wEK1EkDk9uNeamg1/wDEDFXp4XJwwIiqhCo7MLAHc8UDX31x6XlvJjSzbtrKyBQACtvySQQQ3xR1NTQXMUsYlZipkXfTKiqLW6O2q5BFj5F8XoP1vqT4wBSixQvGdoHluCAWoCjZO4jgXr3U0Gb9FzsiPqXl/mH/AFHPmbaUPfqNpRTk/bVjxtkFJVZAqltxfaKBKsQpAHC0PjU1NBx8QQtkCKRnI/QB21wAGACjtQG4/wDDSjjTFGse3+upqaDlM9kmqv20w+BfVNJGfoaF9w+aXcP8Gj/GpqaB2HSoV6aOoupdoTt8smgymRV+qtykXYYcgj440qfiTEqZflLuqONRbtuY2Se5F0LAANnjvzqamg+fCniaVWXElubGlpGidj6d3AKHuhF+3B9xoP4n6YMbLmx1YsI5CgYiiQD7/fXmpoBWjHhbNaHLhdebYKwPZlf0sCPcEHU1NA4eISHEwohobEbAkFTExUHirJBrm+2kvpnU5o8hJ45XWYMKkuz2977iuKPFa91NB89bkJbk2eWJ+Sxsn/Ohh1NTQaP+GnUYPKkhyMUTqG3qS5XaWAB7A32GvNTU1B//2Q=="
                        },

                        new Book()
                        {
                            Title = "Hamlet",
                            Summary = "Prince Hamlet and his revenge against his uncle, Claudius, who has murdered " +
                            "Hamlet's father in order to seize his throne and marry Hamlet's mother.",
                            PublishDate = new DateTime(1599, 01, 01),
                            Price = 6.24M,
                            PublisherId = 2,
                            Genre = BookGenre.Drama,
                            BookCover = "https://m.media-amazon.com/images/I/51IWerpjMGL._AC_UF1000,1000_QL80_.jpg"
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
                            Genre = BookGenre.Tragedy,
                            BookCover = "https://m.media-amazon.com/images/I/61UXvbWjAXL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "Romeo & Juliet",
                            Summary = "Romeo and Juliet is a famous tragedy written by William Shakespeare early in his career " +
                            "about the romance between two Italian youths from feuding families.",
                            PublishDate = new DateTime(1597, 01, 01),
                            Price = 6.99M,
                            PublisherId = 3,
                            Genre = BookGenre.Tragedy,
                            BookCover = "https://m.media-amazon.com/images/I/61JyXbe8fQL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "Macbeth",
                            Summary = "\"Macbeth is one of Shakespeare's finest plays, and presents a man's conscience and the " +
                            "effect of guilt on his mind. A dark and bloody play.",
                            PublishDate = new DateTime(1603, 11, 03),
                            Price = 5.24M,
                            PublisherId = 3,
                            Genre = BookGenre.Tragedy,
                            BookCover = "https://m.media-amazon.com/images/I/51BuxHpRnHL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "King Lear",
                            Summary = "King Lear is a tragedy based on the chronicle history of a pre-Roman, Celtic king of Britain. " +
                            "In Shakespeare's play, Lear, intending to retire, stages a love test for his three daughters...",
                            PublishDate = new DateTime(1606, 12, 26),
                            Price = 8.01M,
                            PublisherId = 3,
                            Genre = BookGenre.Tragedy,
                            BookCover = "https://m.media-amazon.com/images/I/61N3qfKWO-L._AC_UF1000,1000_QL80_.jpg"
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
                            Genre = BookGenre.Drama,
                            BookCover = "https://m.media-amazon.com/images/I/71lSxMk7i8L._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "News of a kidnapping",
                            Summary = "News of a Kidnapping is a deeply personal account that pays tribute to the author's " +
                            "friends Maruja Pachón, one of the people kidnapped by Escobar's men, and her husband, Alberto Villamizar.",
                            PublishDate = new DateTime(1996, 07, 23),
                            Price = 15.10M,
                            PublisherId = 3,
                            Genre = BookGenre.Nonfiction,
                            BookCover = "https://m.media-amazon.com/images/I/81+fMn6rBYL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "Big momma's funeral",
                            Summary = "\"Big Mama's Funeral\" is a long short story by Gabriel García Márquez that " +
                            "satirizes Latin American life and culture. It displays the exaggeration associated with magic realism.",
                            PublishDate = new DateTime(1962, 07, 23),
                            Price = 10.00M,
                            PublisherId = 3,
                            Genre = BookGenre.Fiction,
                            BookCover = "https://m.media-amazon.com/images/I/419JAESRCQL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "One hundred years of solitude",
                            Summary = "The Buendía family, whose patriarch, José Arcadio Buendía, founded the fictitious town of Macondo...",
                            PublishDate = new DateTime(1967, 05, 05),
                            Price = 8.03M,
                            PublisherId = 3,
                            Genre = BookGenre.Drama,
                            BookCover = "https://m.media-amazon.com/images/I/81MI6+TpYkL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "No one writes to Colonel",
                            Summary = " García Márquez considered it his best book, saying that he had to write One Hundred Years of " +
                            "Solitude so that people would read No One Writes to the Colonel.",
                            PublishDate = new DateTime(1961, 05, 05),
                            Price = 17.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fiction,
                            BookCover = "https://m.media-amazon.com/images/I/61MBS+yT+cL._AC_UF350,350_QL50_.jpg"
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the Philosopher's stone",
                            Summary = "The book is about 11 year old Harry Potter, who receives a letter saying that he is invited to attend Hogwarts, " +
                            "school of witchcraft and wizardry.",
                            PublishDate = new DateTime(1997, 06, 26),
                            Price = 9.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/51Ppi-8kISL.jpg"
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the chamber of secrets",
                            Summary = "The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of " +
                            "messages on the walls of the school's corridors warn that the \"Chamber of Secrets\" has been opened...",
                            PublishDate = new DateTime(1998, 11, 05),
                            Price = 9.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/81S0LnPGGUL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the prisoner of Azkaban",
                            Summary = "The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. " +
                            "Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban...",
                            PublishDate = new DateTime(1999, 07, 08),
                            Price = 9.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/81f7bXC-tTL._AC_UF1000,1000_QL80_.jpg"
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the goblet of fire",
                            Summary = "It follows Harry Potter, a wizard in his fourth year at Hogwarts School of Witchcraft and Wizardry, " +
                            "and the mystery surrounding the entry of Harry's name into the Triwizard Tournament, in which he is forced to compete.",
                            PublishDate = new DateTime(2000, 07, 08),
                            Price = 9.50M,
                            PublisherId = 1,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/513TQ4ihqqL.jpg"
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the order of Phoenix",
                            Summary = "It follows Harry Potter's struggles through his fifth year at Hogwarts School of Witchcraft and Wizardry, " +
                            "including the surreptitious return of the antagonist Lord Voldemort, O.W.L. exams, and an obstructive Ministry of Magic",
                            PublishDate = new DateTime(2003, 06, 21),
                            Price = 9.50M,
                            PublisherId = 2,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/519jC3ZUisL.jpg"
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the Half-Blood prince",
                            Summary = " Harry Potter learns a lot about Lord Voldemort's past, and Harry Potter prepares for the final battle against " +
                            "his nemesis with the help of Headmaster Dumbledore. But in that time, Voldemort returns to power, and makes a plan to destroy Harry.",
                            PublishDate = new DateTime(2005, 07, 16),
                            Price = 9.50M,
                            PublisherId = 3,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/81p2+4nYtkL._AC_UF1000,1000_QL80_.jpg"
                        },


                        new Book()
                        {
                            Title = "Harry Potter and the deathly hallows",
                            Summary = "He finally kills the bad person",
                            PublishDate = new DateTime(2007, 07, 21),
                            Price = 9.50M,
                            PublisherId = 4,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/51V6zvaRjkL.jpg"
                        },

                        new Book()
                        {
                            Title = "Harry Potter and the cursed child",
                            Summary = "His stupid boy returns Voldemort",
                            PublishDate = new DateTime(2016, 07, 31),
                            Price = 9.50M,
                            PublisherId = 1,
                            Genre = BookGenre.Fantasy,
                            BookCover = "https://m.media-amazon.com/images/I/71fX7PG24hL._AC_UF1000,1000_QL80_.jpg"
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
