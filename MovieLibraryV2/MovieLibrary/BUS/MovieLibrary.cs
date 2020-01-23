using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.BUS
{
    enum EnumMovieGenre
    {
        Undefined, Action, Adventure, Comedy, Drama, Horror, Fiction, Documentary
    }

    enum EnumCountry
    {
        Undefined, Afghanistan, Albania, Algeria, Andorra, Angola, Argentina, Armenia,
        Australia, Austria, Azerbaijan, Bahamas, Bahrain, Bangladesh, Barbados,
        Belarus, Belgium, Belize, Benin, Bhutan, Bolivia, Botswana, Brazil, Brunei,
        Bulgaria, Canada, Uganda, Ukraine, England, USA, Uruguay, Uzbekistan
    }

    enum EnumLanguage
    {
        Undefined, english, german, portuguese, spanish
    }

    [Serializable()]
    class Date
    {
        private int year;
        //private int month;
        // private int day;

        //public int Month
        //{
        //    get { return month; }
        //    set { month = value; }
        //}
        //public int Day
        //{
        //    get { return day; }
        //    set { day = value; }
        //}
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Date()
        {
        }
        public Date(int year/*, int month, int day*/)
        {
            this.Year = year;
           // this.Month = month;
           // this.Day = day;
        }

        public override string ToString()

        //public String GetInfoDate()
        {
            return this.Year /*+ "-" + this.Month + "-" + this.Day*/ + "\n";
        }
    }

    [Serializable()]
    class MovieLibrary
    {
        private int number;
        private int duration;
        private static int counter;
        private String title;
        private DateTime regDate;
        private EnumMovieGenre genre;
        private EnumCountry country;
        private EnumLanguage language;
        private Date relDate;
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        internal EnumMovieGenre Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }
        internal EnumCountry Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
        internal EnumLanguage Language
        {
            get
            {
                return language;
            }

            set
            {
                language = value;
            }
        }

        public Date RelDate
        {
            get { return relDate; }
            set { relDate = value; }
        }
        public static int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value;
            }
        }
        public DateTime RegDate
        {
            get
            {
                return regDate;
            }

            set
            {
                regDate = value;
            }
        }
        public MovieLibrary()
        {
            counter++;
        }
            public MovieLibrary(int number, EnumMovieGenre genre, EnumCountry country, EnumLanguage language, int duration,Date relDate,DateTime regDate)
            {
               this.Number = number; this.Genre = genre; this.Country = country; this.Language = language; this.Duration=duration;
            this.RelDate = relDate; this.RegDate=regDate ; counter++;
            }

        public override string ToString()
        //public String GetInfo()
        {
            String output;
            output = this.number + "\t" + this.genre + "," + this.country + "\t" + this.language + "\t" + this.duration+"\t"+this.relDate.Year + "\n"+this.regDate;
            return output;
        }
    }
}
