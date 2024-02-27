//Multiple Inheritance
class CSStudent : Student, IGradeable
{
    public CSStudent(string name, byte rn, string pTitle)
        : base(name, rn)
    {
        ProjectTitle = pTitle;
    }

    public string ProjectTitle { get; set; }

    public string InternWork { get; set; }

    public double GetGrade()=> 3.6;
}
