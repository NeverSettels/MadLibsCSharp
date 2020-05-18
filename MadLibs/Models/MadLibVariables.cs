namespace Madlib.models
{
  public class MadVariable
  {
    public string Noun1 { get; set; }
    public string Noun2 { get; set; }
    public string Verb1 { get; set; }
    public string Verb2 { get; set; }
    public MadVariable(string noun1, string noun2, string verb1, string verb2)
    {
      Noun1 = noun1;
      Noun2 = noun2;
      Verb1 = verb1;
      Verb2 = verb2;
    }
  }
}