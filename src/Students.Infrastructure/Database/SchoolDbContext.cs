﻿using Microsoft.EntityFrameworkCore;
using Students.Domain.Models;

namespace Students.Infrastructure.Database
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasKey((s) => s.Id)
            .HasName("PK_Student_Id");

            modelBuilder.Entity<Student>()
            .Property((s) => s.Id)
            .IsRequired();

            modelBuilder.Entity<Student>()
            .Property((s) => s.FirstName)
            .HasMaxLength(200)
            .IsRequired();

            modelBuilder.Entity<Student>()
            .Property((s) => s.LastName)
            .HasMaxLength(200)
            .IsRequired();

            modelBuilder.Entity<Student>()
            .Property((s) => s.DateOfBirth)
            .IsRequired();

            modelBuilder.Entity<Student>()
            .HasData(
                new Student { Id = 1, FirstName = "Chester", LastName = "Chester", DateOfBirth = DateTime.Parse("08/12/2013"), Gender = Gender.Male },
                new Student { Id = 2, FirstName = "Gus", LastName = "Gus", DateOfBirth = DateTime.Parse("09/04/2014"), Gender = Gender.Polygender },
                new Student { Id = 3, FirstName = "Horacio", LastName = "Horacio", DateOfBirth = DateTime.Parse("06/16/1991"), Gender = Gender.Male },
                new Student { Id = 4, FirstName = "Gav", LastName = "Gav", DateOfBirth = DateTime.Parse("12/25/2000"), Gender = Gender.Male },
                new Student { Id = 5, FirstName = "Sherye", LastName = "Sherye", DateOfBirth = DateTime.Parse("12/16/1991"), Gender = Gender.Female },
                new Student { Id = 6, FirstName = "Bonnie", LastName = "Bonnie", DateOfBirth = DateTime.Parse("08/08/1999"), Gender = Gender.Female },
                new Student { Id = 7, FirstName = "Devora", LastName = "Devora", DateOfBirth = DateTime.Parse("06/17/1965"), Gender = Gender.Female },
                new Student { Id = 8, FirstName = "Gregory", LastName = "Gregory", DateOfBirth = DateTime.Parse("02/21/1954"), Gender = Gender.Male },
                new Student { Id = 9, FirstName = "Brucie", LastName = "Brucie", DateOfBirth = DateTime.Parse("03/09/1972"), Gender = Gender.NonBinary },
                new Student { Id = 10, FirstName = "Harmonie", LastName = "Harmonie", DateOfBirth = DateTime.Parse("10/16/1986"), Gender = Gender.Female },
                new Student { Id = 11, FirstName = "Siana", LastName = "Siana", DateOfBirth = DateTime.Parse("03/16/2009"), Gender = Gender.Female },
                new Student { Id = 12, FirstName = "Ray", LastName = "Ray", DateOfBirth = DateTime.Parse("08/25/1993"), Gender = Gender.Female },
                new Student { Id = 13, FirstName = "Crissie", LastName = "Crissie", DateOfBirth = DateTime.Parse("11/27/1963"), Gender = Gender.Polygender },
                new Student { Id = 14, FirstName = "Janot", LastName = "Janot", DateOfBirth = DateTime.Parse("02/01/1962"), Gender = Gender.Female },
                new Student { Id = 15, FirstName = "Jeddy", LastName = "Jeddy", DateOfBirth = DateTime.Parse("01/11/1950"), Gender = Gender.Male },
                new Student { Id = 16, FirstName = "Smith", LastName = "Smith", DateOfBirth = DateTime.Parse("08/12/1981"), Gender = Gender.Male },
                new Student { Id = 17, FirstName = "Doro", LastName = "Doro", DateOfBirth = DateTime.Parse("08/11/1995"), Gender = Gender.Female },
                new Student { Id = 18, FirstName = "Selestina", LastName = "Selestina", DateOfBirth = DateTime.Parse("05/12/1977"), Gender = Gender.Female },
                new Student { Id = 19, FirstName = "Jillie", LastName = "Jillie", DateOfBirth = DateTime.Parse("05/01/1961"), Gender = Gender.Female },
                new Student { Id = 20, FirstName = "Gilligan", LastName = "Gilligan", DateOfBirth = DateTime.Parse("08/15/1955"), Gender = Gender.Female },
                new Student { Id = 21, FirstName = "Conan", LastName = "Conan", DateOfBirth = DateTime.Parse("09/11/1968"), Gender = Gender.Male },
                new Student { Id = 22, FirstName = "Keven", LastName = "Keven", DateOfBirth = DateTime.Parse("05/10/1987"), Gender = Gender.Male },
                new Student { Id = 23, FirstName = "Onfroi", LastName = "Onfroi", DateOfBirth = DateTime.Parse("08/07/1962"), Gender = Gender.Male },
                new Student { Id = 24, FirstName = "Jeramie", LastName = "Jeramie", DateOfBirth = DateTime.Parse("04/14/1976"), Gender = Gender.Male },
                new Student { Id = 25, FirstName = "Wilie", LastName = "Wilie", DateOfBirth = DateTime.Parse("07/09/1977"), Gender = Gender.Female },
                new Student { Id = 26, FirstName = "Reider", LastName = "Reider", DateOfBirth = DateTime.Parse("09/13/1973"), Gender = Gender.Agender },
                new Student { Id = 27, FirstName = "Gnni", LastName = "Gnni", DateOfBirth = DateTime.Parse("02/06/1989"), Gender = Gender.Female },
                new Student { Id = 28, FirstName = "Tonya", LastName = "Tonya", DateOfBirth = DateTime.Parse("02/11/1984"), Gender = Gender.Female },
                new Student { Id = 29, FirstName = "Rosamund", LastName = "Rosamund", DateOfBirth = DateTime.Parse("05/12/1942"), Gender = Gender.Female },
                new Student { Id = 30, FirstName = "Berta", LastName = "Berta", DateOfBirth = DateTime.Parse("06/06/1993"), Gender = Gender.Female },
                new Student { Id = 31, FirstName = "Dusty", LastName = "Dusty", DateOfBirth = DateTime.Parse("02/28/1981"), Gender = Gender.Female },
                new Student { Id = 32, FirstName = "Reggis", LastName = "Reggis", DateOfBirth = DateTime.Parse("10/21/2007"), Gender = Gender.Male },
                new Student { Id = 33, FirstName = "Butch", LastName = "Butch", DateOfBirth = DateTime.Parse("12/18/1986"), Gender = Gender.Male },
                new Student { Id = 34, FirstName = "Meredith", LastName = "Meredith", DateOfBirth = DateTime.Parse("05/27/1963"), Gender = Gender.Female },
                new Student { Id = 35, FirstName = "Boyd", LastName = "Boyd", DateOfBirth = DateTime.Parse("05/26/1959"), Gender = Gender.Male },
                new Student { Id = 36, FirstName = "Tamarah", LastName = "Tamarah", DateOfBirth = DateTime.Parse("09/08/1957"), Gender = Gender.Genderqueer },
                new Student { Id = 37, FirstName = "Sybil", LastName = "Sybil", DateOfBirth = DateTime.Parse("09/26/1970"), Gender = Gender.Female },
                new Student { Id = 38, FirstName = "Winn", LastName = "Winn", DateOfBirth = DateTime.Parse("04/12/1971"), Gender = Gender.Male },
                new Student { Id = 39, FirstName = "Modestine", LastName = "Modestine", DateOfBirth = DateTime.Parse("10/10/1998"), Gender = Gender.Female },
                new Student { Id = 40, FirstName = "Lamont", LastName = "Lamont", DateOfBirth = DateTime.Parse("07/17/2012"), Gender = Gender.Male },
                new Student { Id = 41, FirstName = "Gabie", LastName = "Gabie", DateOfBirth = DateTime.Parse("10/15/1969"), Gender = Gender.Female },
                new Student { Id = 42, FirstName = "Cleon", LastName = "Cleon", DateOfBirth = DateTime.Parse("08/15/2013"), Gender = Gender.Male },
                new Student { Id = 43, FirstName = "Asia", LastName = "Asia", DateOfBirth = DateTime.Parse("05/18/2010"), Gender = Gender.Female },
                new Student { Id = 44, FirstName = "Dionis", LastName = "Dionis", DateOfBirth = DateTime.Parse("07/14/1954"), Gender = Gender.Female },
                new Student { Id = 45, FirstName = "Aimil", LastName = "Aimil", DateOfBirth = DateTime.Parse("06/18/1956"), Gender = Gender.Female },
                new Student { Id = 46, FirstName = "Perry", LastName = "Perry", DateOfBirth = DateTime.Parse("06/25/1971"), Gender = Gender.Genderqueer },
                new Student { Id = 47, FirstName = "Victor", LastName = "Victor", DateOfBirth = DateTime.Parse("06/02/1970"), Gender = Gender.Male },
                new Student { Id = 48, FirstName = "Carri", LastName = "Carri", DateOfBirth = DateTime.Parse("03/17/1983"), Gender = Gender.Female },
                new Student { Id = 49, FirstName = "Jozef", LastName = "Jozef", DateOfBirth = DateTime.Parse("01/21/1941"), Gender = Gender.Male },
                new Student { Id = 50, FirstName = "Mira", LastName = "Mira", DateOfBirth = DateTime.Parse("05/20/1993"), Gender = Gender.Female },
                new Student { Id = 51, FirstName = "Gabrielle", LastName = "Gabrielle", DateOfBirth = DateTime.Parse("06/18/1964"), Gender = Gender.Female },
                new Student { Id = 52, FirstName = "Barbabas", LastName = "Barbabas", DateOfBirth = DateTime.Parse("07/30/1986"), Gender = Gender.Male },
                new Student { Id = 53, FirstName = "Farrell", LastName = "Farrell", DateOfBirth = DateTime.Parse("07/04/1965"), Gender = Gender.Male },
                new Student { Id = 54, FirstName = "Jim", LastName = "Jim", DateOfBirth = DateTime.Parse("10/18/1945"), Gender = Gender.Male },
                new Student { Id = 55, FirstName = "Pierce", LastName = "Pierce", DateOfBirth = DateTime.Parse("09/14/1983"), Gender = Gender.Male },
                new Student { Id = 56, FirstName = "Finley", LastName = "Finley", DateOfBirth = DateTime.Parse("11/24/1960"), Gender = Gender.Male },
                new Student { Id = 57, FirstName = "Laverna", LastName = "Laverna", DateOfBirth = DateTime.Parse("03/06/1946"), Gender = Gender.Female },
                new Student { Id = 58, FirstName = "Ariela", LastName = "Ariela", DateOfBirth = DateTime.Parse("09/15/2019"), Gender = Gender.Female },
                new Student { Id = 59, FirstName = "Eden", LastName = "Eden", DateOfBirth = DateTime.Parse("09/28/1955"), Gender = Gender.Agender },
                new Student { Id = 60, FirstName = "Hershel", LastName = "Hershel", DateOfBirth = DateTime.Parse("01/12/2015"), Gender = Gender.Male },
                new Student { Id = 61, FirstName = "Gene", LastName = "Gene", DateOfBirth = DateTime.Parse("11/06/2012"), Gender = Gender.Male },
                new Student { Id = 62, FirstName = "Shelly", LastName = "Shelly", DateOfBirth = DateTime.Parse("05/22/1983"), Gender = Gender.Female },
                new Student { Id = 63, FirstName = "Padgett", LastName = "Padgett", DateOfBirth = DateTime.Parse("02/08/1993"), Gender = Gender.Male },
                new Student { Id = 64, FirstName = "Reamonn", LastName = "Reamonn", DateOfBirth = DateTime.Parse("09/14/1987"), Gender = Gender.Male },
                new Student { Id = 65, FirstName = "Delinda", LastName = "Delinda", DateOfBirth = DateTime.Parse("07/26/1946"), Gender = Gender.Genderqueer },
                new Student { Id = 66, FirstName = "Gifford", LastName = "Gifford", DateOfBirth = DateTime.Parse("07/10/1960"), Gender = Gender.Male },
                new Student { Id = 67, FirstName = "Carmina", LastName = "Carmina", DateOfBirth = DateTime.Parse("07/29/2009"), Gender = Gender.Female },
                new Student { Id = 68, FirstName = "Joyce", LastName = "Joyce", DateOfBirth = DateTime.Parse("03/11/1971"), Gender = Gender.Female },
                new Student { Id = 69, FirstName = "Lucio", LastName = "Lucio", DateOfBirth = DateTime.Parse("02/11/1983"), Gender = Gender.Male },
                new Student { Id = 70, FirstName = "Claiborn", LastName = "Claiborn", DateOfBirth = DateTime.Parse("04/21/2012"), Gender = Gender.Male },
                new Student { Id = 71, FirstName = "Rivkah", LastName = "Rivkah", DateOfBirth = DateTime.Parse("03/11/1983"), Gender = Gender.Female },
                new Student { Id = 72, FirstName = "Alfy", LastName = "Alfy", DateOfBirth = DateTime.Parse("06/06/1941"), Gender = Gender.Female },
                new Student { Id = 73, FirstName = "Sorcha", LastName = "Sorcha", DateOfBirth = DateTime.Parse("01/11/1982"), Gender = Gender.Female },
                new Student { Id = 74, FirstName = "Chrisy", LastName = "Chrisy", DateOfBirth = DateTime.Parse("07/24/1964"), Gender = Gender.Male },
                new Student { Id = 75, FirstName = "Shawnee", LastName = "Shawnee", DateOfBirth = DateTime.Parse("07/17/1988"), Gender = Gender.Female },
                new Student { Id = 76, FirstName = "Mureil", LastName = "Mureil", DateOfBirth = DateTime.Parse("01/01/1974"), Gender = Gender.Female },
                new Student { Id = 77, FirstName = "Prince", LastName = "Prince", DateOfBirth = DateTime.Parse("06/04/1977"), Gender = Gender.Male },
                new Student { Id = 78, FirstName = "Lotta", LastName = "Lotta", DateOfBirth = DateTime.Parse("10/27/1987"), Gender = Gender.Female },
                new Student { Id = 79, FirstName = "Jonis", LastName = "Jonis", DateOfBirth = DateTime.Parse("03/14/1978"), Gender = Gender.Genderfluid },
                new Student { Id = 80, FirstName = "Krystalle", LastName = "Krystalle", DateOfBirth = DateTime.Parse("10/17/1996"), Gender = Gender.Female },
                new Student { Id = 81, FirstName = "Lotta", LastName = "Lotta", DateOfBirth = DateTime.Parse("11/24/2005"), Gender = Gender.Female },
                new Student { Id = 82, FirstName = "Fayre", LastName = "Fayre", DateOfBirth = DateTime.Parse("10/02/1945"), Gender = Gender.Female },
                new Student { Id = 83, FirstName = "Bone", LastName = "Bone", DateOfBirth = DateTime.Parse("05/08/1958"), Gender = Gender.Male },
                new Student { Id = 84, FirstName = "Aretha", LastName = "Aretha", DateOfBirth = DateTime.Parse("04/19/1943"), Gender = Gender.Female },
                new Student { Id = 85, FirstName = "Jewel", LastName = "Jewel", DateOfBirth = DateTime.Parse("08/29/1969"), Gender = Gender.Female },
                new Student { Id = 86, FirstName = "Jay", LastName = "Jay", DateOfBirth = DateTime.Parse("09/23/2009"), Gender = Gender.Male },
                new Student { Id = 87, FirstName = "Avery", LastName = "Avery", DateOfBirth = DateTime.Parse("12/13/1967"), Gender = Gender.Male },
                new Student { Id = 88, FirstName = "Anita", LastName = "Anita", DateOfBirth = DateTime.Parse("04/27/2019"), Gender = Gender.Female },
                new Student { Id = 89, FirstName = "Kendrick", LastName = "Kendrick", DateOfBirth = DateTime.Parse("03/02/1940"), Gender = Gender.Male },
                new Student { Id = 90, FirstName = "Babb", LastName = "Babb", DateOfBirth = DateTime.Parse("09/04/1944"), Gender = Gender.Female },
                new Student { Id = 91, FirstName = "Olag", LastName = "Olag", DateOfBirth = DateTime.Parse("03/21/1971"), Gender = Gender.Male },
                new Student { Id = 92, FirstName = "Catharina", LastName = "Catharina", DateOfBirth = DateTime.Parse("08/10/1976"), Gender = Gender.Female },
                new Student { Id = 93, FirstName = "Granthem", LastName = "Granthem", DateOfBirth = DateTime.Parse("08/03/1997"), Gender = Gender.Male },
                new Student { Id = 94, FirstName = "Aloin", LastName = "Aloin", DateOfBirth = DateTime.Parse("05/06/1946"), Gender = Gender.Male },
                new Student { Id = 95, FirstName = "Pablo", LastName = "Pablo", DateOfBirth = DateTime.Parse("08/10/1953"), Gender = Gender.Male },
                new Student { Id = 96, FirstName = "Janine", LastName = "Janine", DateOfBirth = DateTime.Parse("03/23/1963"), Gender = Gender.Female },
                new Student { Id = 97, FirstName = "Bobette", LastName = "Bobette", DateOfBirth = DateTime.Parse("04/23/1945"), Gender = Gender.Female },
                new Student { Id = 98, FirstName = "Sven", LastName = "Sven", DateOfBirth = DateTime.Parse("07/10/1959"), Gender = Gender.Male },
                new Student { Id = 99, FirstName = "De witt", LastName = "De witt", DateOfBirth = DateTime.Parse("09/15/2009"), Gender = Gender.Male },
                new Student { Id = 100, FirstName = "Charlie", LastName = "Charlie", DateOfBirth = DateTime.Parse("11/07/1973"), Gender = Gender.Male },
                new Student { Id = 101, FirstName = "Rorie", LastName = "Rorie", DateOfBirth = DateTime.Parse("08/31/1945"), Gender = Gender.Female },
                new Student { Id = 102, FirstName = "Archibold", LastName = "Archibold", DateOfBirth = DateTime.Parse("03/13/1978"), Gender = Gender.Male },
                new Student { Id = 103, FirstName = "Cordey", LastName = "Cordey", DateOfBirth = DateTime.Parse("04/10/1963"), Gender = Gender.Female },
                new Student { Id = 104, FirstName = "Constantine", LastName = "Constantine", DateOfBirth = DateTime.Parse("02/28/1960"), Gender = Gender.Female },
                new Student { Id = 105, FirstName = "Gloria", LastName = "Gloria", DateOfBirth = DateTime.Parse("03/30/2000"), Gender = Gender.Female },
                new Student { Id = 106, FirstName = "Shannah", LastName = "Shannah", DateOfBirth = DateTime.Parse("04/08/1941"), Gender = Gender.Female },
                new Student { Id = 107, FirstName = "Ingrim", LastName = "Ingrim", DateOfBirth = DateTime.Parse("11/28/1975"), Gender = Gender.Male },
                new Student { Id = 108, FirstName = "Fayette", LastName = "Fayette", DateOfBirth = DateTime.Parse("06/08/1984"), Gender = Gender.Female },
                new Student { Id = 109, FirstName = "Teddi", LastName = "Teddi", DateOfBirth = DateTime.Parse("06/17/2021"), Gender = Gender.Female },
                new Student { Id = 110, FirstName = "Gayler", LastName = "Gayler", DateOfBirth = DateTime.Parse("11/26/1994"), Gender = Gender.Male },
                new Student { Id = 111, FirstName = "Roderic", LastName = "Roderic", DateOfBirth = DateTime.Parse("04/10/2000"), Gender = Gender.Male },
                new Student { Id = 112, FirstName = "Emiline", LastName = "Emiline", DateOfBirth = DateTime.Parse("02/23/1987"), Gender = Gender.Bigender },
                new Student { Id = 113, FirstName = "Franky", LastName = "Franky", DateOfBirth = DateTime.Parse("01/26/1941"), Gender = Gender.Male },
                new Student { Id = 114, FirstName = "Winonah", LastName = "Winonah", DateOfBirth = DateTime.Parse("05/13/1999"), Gender = Gender.Female },
                new Student { Id = 115, FirstName = "Michaelina", LastName = "Michaelina", DateOfBirth = DateTime.Parse("06/17/2015"), Gender = Gender.Female },
                new Student { Id = 116, FirstName = "Brady", LastName = "Brady", DateOfBirth = DateTime.Parse("01/14/1995"), Gender = Gender.Male },
                new Student { Id = 117, FirstName = "Evangeline", LastName = "Evangeline", DateOfBirth = DateTime.Parse("01/22/2018"), Gender = Gender.Female },
                new Student { Id = 118, FirstName = "Alfi", LastName = "Alfi", DateOfBirth = DateTime.Parse("10/28/1941"), Gender = Gender.Female },
                new Student { Id = 119, FirstName = "Linell", LastName = "Linell", DateOfBirth = DateTime.Parse("01/14/2016"), Gender = Gender.Female },
                new Student { Id = 120, FirstName = "Gwenni", LastName = "Gwenni", DateOfBirth = DateTime.Parse("12/16/1942"), Gender = Gender.Female },
                new Student { Id = 121, FirstName = "Costanza", LastName = "Costanza", DateOfBirth = DateTime.Parse("12/25/1975"), Gender = Gender.Female },
                new Student { Id = 122, FirstName = "Flory", LastName = "Flory", DateOfBirth = DateTime.Parse("10/02/1974"), Gender = Gender.Female },
                new Student { Id = 123, FirstName = "Willamina", LastName = "Willamina", DateOfBirth = DateTime.Parse("06/21/1998"), Gender = Gender.Female },
                new Student { Id = 124, FirstName = "Modestia", LastName = "Modestia", DateOfBirth = DateTime.Parse("07/25/1986"), Gender = Gender.Female },
                new Student { Id = 125, FirstName = "Stacy", LastName = "Stacy", DateOfBirth = DateTime.Parse("07/07/1999"), Gender = Gender.Male },
                new Student { Id = 126, FirstName = "Edsel", LastName = "Edsel", DateOfBirth = DateTime.Parse("12/16/1968"), Gender = Gender.Male },
                new Student { Id = 127, FirstName = "Carmelita", LastName = "Carmelita", DateOfBirth = DateTime.Parse("07/06/2007"), Gender = Gender.Female },
                new Student { Id = 128, FirstName = "Wolf", LastName = "Wolf", DateOfBirth = DateTime.Parse("03/25/1947"), Gender = Gender.Male },
                new Student { Id = 129, FirstName = "Faber", LastName = "Faber", DateOfBirth = DateTime.Parse("11/29/2010"), Gender = Gender.Male },
                new Student { Id = 130, FirstName = "Leela", LastName = "Leela", DateOfBirth = DateTime.Parse("06/21/2004"), Gender = Gender.Female },
                new Student { Id = 131, FirstName = "Moishe", LastName = "Moishe", DateOfBirth = DateTime.Parse("07/10/2016"), Gender = Gender.Male },
                new Student { Id = 132, FirstName = "Linnea", LastName = "Linnea", DateOfBirth = DateTime.Parse("07/03/1981"), Gender = Gender.Genderqueer },
                new Student { Id = 133, FirstName = "Ad", LastName = "Ad", DateOfBirth = DateTime.Parse("05/12/1959"), Gender = Gender.Agender },
                new Student { Id = 134, FirstName = "Jo ann", LastName = "Jo ann", DateOfBirth = DateTime.Parse("03/14/2002"), Gender = Gender.Female },
                new Student { Id = 135, FirstName = "Zorine", LastName = "Zorine", DateOfBirth = DateTime.Parse("12/01/1951"), Gender = Gender.Female },
                new Student { Id = 136, FirstName = "Corena", LastName = "Corena", DateOfBirth = DateTime.Parse("11/22/2008"), Gender = Gender.Female },
                new Student { Id = 137, FirstName = "Madelon", LastName = "Madelon", DateOfBirth = DateTime.Parse("04/09/1975"), Gender = Gender.Female },
                new Student { Id = 138, FirstName = "Josiah", LastName = "Josiah", DateOfBirth = DateTime.Parse("11/23/1993"), Gender = Gender.Male },
                new Student { Id = 139, FirstName = "Guy", LastName = "Guy", DateOfBirth = DateTime.Parse("07/06/1996"), Gender = Gender.Male },
                new Student { Id = 140, FirstName = "Maryanne", LastName = "Maryanne", DateOfBirth = DateTime.Parse("06/25/1972"), Gender = Gender.Genderqueer },
                new Student { Id = 141, FirstName = "Vilma", LastName = "Vilma", DateOfBirth = DateTime.Parse("05/28/1979"), Gender = Gender.Female },
                new Student { Id = 142, FirstName = "Anne-corinne", LastName = "Anne-corinne", DateOfBirth = DateTime.Parse("09/20/1943"), Gender = Gender.Female },
                new Student { Id = 143, FirstName = "Edmon", LastName = "Edmon", DateOfBirth = DateTime.Parse("03/16/1984"), Gender = Gender.Male },
                new Student { Id = 144, FirstName = "Nonnah", LastName = "Nonnah", DateOfBirth = DateTime.Parse("02/11/1956"), Gender = Gender.Female },
                new Student { Id = 145, FirstName = "Kass", LastName = "Kass", DateOfBirth = DateTime.Parse("01/26/1997"), Gender = Gender.Female },
                new Student { Id = 146, FirstName = "Maurene", LastName = "Maurene", DateOfBirth = DateTime.Parse("10/17/1980"), Gender = Gender.Female },
                new Student { Id = 147, FirstName = "Mano", LastName = "Mano", DateOfBirth = DateTime.Parse("02/21/2022"), Gender = Gender.Male },
                new Student { Id = 148, FirstName = "Reeva", LastName = "Reeva", DateOfBirth = DateTime.Parse("12/01/2020"), Gender = Gender.Female },
                new Student { Id = 149, FirstName = "Russell", LastName = "Russell", DateOfBirth = DateTime.Parse("11/11/1955"), Gender = Gender.Male },
                new Student { Id = 150, FirstName = "Joela", LastName = "Joela", DateOfBirth = DateTime.Parse("07/19/2001"), Gender = Gender.Female },
                new Student { Id = 151, FirstName = "Cherri", LastName = "Cherri", DateOfBirth = DateTime.Parse("07/12/2001"), Gender = Gender.Agender },
                new Student { Id = 152, FirstName = "Marius", LastName = "Marius", DateOfBirth = DateTime.Parse("07/16/2006"), Gender = Gender.Male },
                new Student { Id = 153, FirstName = "Tabina", LastName = "Tabina", DateOfBirth = DateTime.Parse("03/01/2019"), Gender = Gender.Female },
                new Student { Id = 154, FirstName = "Mohandas", LastName = "Mohandas", DateOfBirth = DateTime.Parse("04/22/1993"), Gender = Gender.Male },
                new Student { Id = 155, FirstName = "Gladys", LastName = "Gladys", DateOfBirth = DateTime.Parse("11/25/1972"), Gender = Gender.Female },
                new Student { Id = 156, FirstName = "Latrina", LastName = "Latrina", DateOfBirth = DateTime.Parse("12/25/1978"), Gender = Gender.Polygender },
                new Student { Id = 157, FirstName = "Seth", LastName = "Seth", DateOfBirth = DateTime.Parse("06/04/1949"), Gender = Gender.Male },
                new Student { Id = 158, FirstName = "Lois", LastName = "Lois", DateOfBirth = DateTime.Parse("12/11/2009"), Gender = Gender.Female },
                new Student { Id = 159, FirstName = "Nicky", LastName = "Nicky", DateOfBirth = DateTime.Parse("08/29/1970"), Gender = Gender.Female },
                new Student { Id = 160, FirstName = "Alisander", LastName = "Alisander", DateOfBirth = DateTime.Parse("04/12/1960"), Gender = Gender.Male },
                new Student { Id = 161, FirstName = "Viole", LastName = "Viole", DateOfBirth = DateTime.Parse("10/19/2014"), Gender = Gender.Female },
                new Student { Id = 162, FirstName = "Bernice", LastName = "Bernice", DateOfBirth = DateTime.Parse("09/04/2002"), Gender = Gender.Female },
                new Student { Id = 163, FirstName = "Cordelia", LastName = "Cordelia", DateOfBirth = DateTime.Parse("02/25/2011"), Gender = Gender.Female },
                new Student { Id = 164, FirstName = "Modestia", LastName = "Modestia", DateOfBirth = DateTime.Parse("09/29/1980"), Gender = Gender.Female },
                new Student { Id = 165, FirstName = "Golda", LastName = "Golda", DateOfBirth = DateTime.Parse("08/05/1956"), Gender = Gender.Female },
                new Student { Id = 166, FirstName = "Carlynn", LastName = "Carlynn", DateOfBirth = DateTime.Parse("04/04/1949"), Gender = Gender.Female },
                new Student { Id = 167, FirstName = "Salaidh", LastName = "Salaidh", DateOfBirth = DateTime.Parse("12/02/2021"), Gender = Gender.Female },
                new Student { Id = 168, FirstName = "Maryjane", LastName = "Maryjane", DateOfBirth = DateTime.Parse("04/22/2017"), Gender = Gender.Female },
                new Student { Id = 169, FirstName = "Maurits", LastName = "Maurits", DateOfBirth = DateTime.Parse("07/30/2020"), Gender = Gender.Male },
                new Student { Id = 170, FirstName = "Ab", LastName = "Ab", DateOfBirth = DateTime.Parse("09/23/1963"), Gender = Gender.Male },
                new Student { Id = 171, FirstName = "Gideon", LastName = "Gideon", DateOfBirth = DateTime.Parse("09/04/1957"), Gender = Gender.Male },
                new Student { Id = 172, FirstName = "Laurianne", LastName = "Laurianne", DateOfBirth = DateTime.Parse("06/18/1980"), Gender = Gender.Female },
                new Student { Id = 173, FirstName = "Baillie", LastName = "Baillie", DateOfBirth = DateTime.Parse("11/19/1981"), Gender = Gender.Male },
                new Student { Id = 174, FirstName = "Keenan", LastName = "Keenan", DateOfBirth = DateTime.Parse("01/10/1954"), Gender = Gender.Male },
                new Student { Id = 175, FirstName = "Ashien", LastName = "Ashien", DateOfBirth = DateTime.Parse("09/23/1941"), Gender = Gender.Female },
                new Student { Id = 176, FirstName = "Tann", LastName = "Tann", DateOfBirth = DateTime.Parse("07/08/1987"), Gender = Gender.NonBinary },
                new Student { Id = 177, FirstName = "Mill", LastName = "Mill", DateOfBirth = DateTime.Parse("04/07/1982"), Gender = Gender.Agender },
                new Student { Id = 178, FirstName = "Alonzo", LastName = "Alonzo", DateOfBirth = DateTime.Parse("07/27/1967"), Gender = Gender.Male },
                new Student { Id = 179, FirstName = "Warren", LastName = "Warren", DateOfBirth = DateTime.Parse("11/23/1971"), Gender = Gender.Male },
                new Student { Id = 180, FirstName = "Gael", LastName = "Gael", DateOfBirth = DateTime.Parse("02/22/1993"), Gender = Gender.Agender },
                new Student { Id = 181, FirstName = "Elnar", LastName = "Elnar", DateOfBirth = DateTime.Parse("03/10/1943"), Gender = Gender.Male },
                new Student { Id = 182, FirstName = "Woodie", LastName = "Woodie", DateOfBirth = DateTime.Parse("01/07/2014"), Gender = Gender.Male },
                new Student { Id = 183, FirstName = "Ward", LastName = "Ward", DateOfBirth = DateTime.Parse("06/28/2018"), Gender = Gender.Male },
                new Student { Id = 184, FirstName = "Giana", LastName = "Giana", DateOfBirth = DateTime.Parse("01/06/2019"), Gender = Gender.Female },
                new Student { Id = 185, FirstName = "Hussein", LastName = "Hussein", DateOfBirth = DateTime.Parse("11/21/2021"), Gender = Gender.Male },
                new Student { Id = 186, FirstName = "Netti", LastName = "Netti", DateOfBirth = DateTime.Parse("02/17/2000"), Gender = Gender.Female },
                new Student { Id = 187, FirstName = "Mariejeanne", LastName = "Mariejeanne", DateOfBirth = DateTime.Parse("07/12/1977"), Gender = Gender.Female },
                new Student { Id = 188, FirstName = "Errick", LastName = "Errick", DateOfBirth = DateTime.Parse("12/30/2008"), Gender = Gender.Genderqueer },
                new Student { Id = 189, FirstName = "Erasmus", LastName = "Erasmus", DateOfBirth = DateTime.Parse("08/28/1964"), Gender = Gender.Male },
                new Student { Id = 190, FirstName = "Ermin", LastName = "Ermin", DateOfBirth = DateTime.Parse("12/05/2015"), Gender = Gender.Male },
                new Student { Id = 191, FirstName = "Elijah", LastName = "Elijah", DateOfBirth = DateTime.Parse("02/04/1958"), Gender = Gender.Male },
                new Student { Id = 192, FirstName = "Sky", LastName = "Sky", DateOfBirth = DateTime.Parse("05/25/2004"), Gender = Gender.Male },
                new Student { Id = 193, FirstName = "Marrilee", LastName = "Marrilee", DateOfBirth = DateTime.Parse("12/06/1944"), Gender = Gender.Female },
                new Student { Id = 194, FirstName = "Dorthea", LastName = "Dorthea", DateOfBirth = DateTime.Parse("10/09/2012"), Gender = Gender.Female },
                new Student { Id = 195, FirstName = "Corny", LastName = "Corny", DateOfBirth = DateTime.Parse("01/18/1942"), Gender = Gender.Female },
                new Student { Id = 196, FirstName = "Timothy", LastName = "Timothy", DateOfBirth = DateTime.Parse("08/07/2022"), Gender = Gender.Male },
                new Student { Id = 197, FirstName = "Lynnell", LastName = "Lynnell", DateOfBirth = DateTime.Parse("08/01/1960"), Gender = Gender.Female },
                new Student { Id = 198, FirstName = "Garreth", LastName = "Garreth", DateOfBirth = DateTime.Parse("11/14/1961"), Gender = Gender.Male },
                new Student { Id = 199, FirstName = "Lavena", LastName = "Lavena", DateOfBirth = DateTime.Parse("02/03/1971"), Gender = Gender.Female },
                new Student { Id = 200, FirstName = "Roy", LastName = "Roy", DateOfBirth = DateTime.Parse("12/24/1965"), Gender = Gender.Male }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
