using E_Books.Models;

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
                            Name = "",
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
            }
        }
    }
}
