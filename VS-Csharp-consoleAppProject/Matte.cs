public class Matte
{
    public int? Number1 { get; set; }
    public int? Number2 { get; set; }
    
    public int AddNumbers()
    {
        if (Number1.HasValue && Number2.HasValue)
        {
            return Number1.Value + Number2.Value;
        }
        else
        {
            // Handle the case where either Number1 or Number2 is null
            throw new InvalidOperationException("Both Number1 and Number2 must have values.");
        }
    }
}