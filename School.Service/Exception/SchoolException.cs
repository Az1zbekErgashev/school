namespace School.Service.Exception;

public class SchoolException : System.Exception
{
    public int Code { get; set; }
    public bool? Global { get; set; }

    public SchoolException(int code, string message, bool? global = true) : base(message)
    {
        Code = code;
        Global = global;
    }
}
