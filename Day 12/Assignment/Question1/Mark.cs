namespace Question1
{
    class Mark
    {

        public string SubjectName;
        public int MarkObtained;
        public int MaximumMark;

        public override string ToString()
        {
            return $"Subject: {SubjectName}, Obtained: {MarkObtained}, Maximum: {MaximumMark}";
        }
    }
}
