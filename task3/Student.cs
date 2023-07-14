class Student
{
    public string FullName;
    public int Grade;
    public double[] Scores;

    public double Average()
    {
        double sum  = 0;
        foreach (var elem in Scores)
        {
            sum += elem;          
        }
        return sum /(double) Scores.Length;
    }
}