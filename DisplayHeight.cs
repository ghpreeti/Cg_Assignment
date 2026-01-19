class DisplayHeight
{
    public static string Category(int height)
    {
        if(height<150) return "Short";
        else if(height>=150 && height<180) return "Average";
        else return "Tall";
    }
}