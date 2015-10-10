namespace OnlineTvDatabase.Core
{
    public sealed class Language
    {
        public int? LanguageId { get; }

        public string Abbreviation { get; }

        public Language()
        {
            Abbreviation = "all";
        }

        private Language(int languageId, string abbreviation)
        {
            LanguageId = languageId;
            Abbreviation = abbreviation;
        }

        public static readonly Language English = new Language(7, "en");

        public static readonly Language Swedish = new Language(8, "sv");

        public static readonly Language Norse = new Language(9, "no");

        public static readonly Language Danish = new Language(10, "da");

        public static readonly Language Finnish = new Language(11, "fi");

        public static readonly Language Dutch = new Language(13, "nl");

        public static readonly Language German = new Language(14, "de");

        public static readonly Language Italian = new Language(15, "it");

        public static readonly Language Spanish = new Language(16, "es");

        public static readonly Language French = new Language(17, "fr");

        public static readonly Language Polish = new Language(18, "pl");

        public static readonly Language Hungarian = new Language(19, "hu");

        public static readonly Language Greek = new Language(20, "el");

        public static readonly Language Turkish = new Language(21, "tr");

        public static readonly Language Russian = new Language(22, "ru");

        public static readonly Language Hebrew = new Language(24, "he");

        public static readonly Language Japanese = new Language(25, "ja");

        public static readonly Language Portuguese = new Language(26, "pt");

        public static readonly Language Chinese = new Language(27, "zh");

        public static readonly Language Czech = new Language(28, "cs");

        public static readonly Language Slovenian = new Language(30, "sl");

        public static readonly Language Croatian = new Language(31, "hr");

        public static readonly Language Korean = new Language(32, "ko");

        public override string ToString()
        {
            return Abbreviation;
        }
    }
}
