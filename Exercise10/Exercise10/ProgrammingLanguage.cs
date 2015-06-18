namespace Exercise10
{
    public class ProgrammingLanguage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }

        public override string ToString()
        {
            return string.Format("(Released: {0})  {1}", ReleaseYear, Name);
        }
    }
}