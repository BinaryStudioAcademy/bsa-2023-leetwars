namespace LeetWars.Notifier.WebAPI.Models;

public class Test
{
    public string TestName { get; set; }
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
    public string Duration { get; set; }

    public Test(string testName, bool isSuccess, string duration)
    {
        TestName = testName;
        IsSuccess = isSuccess;
        Duration = duration;
    }
}
