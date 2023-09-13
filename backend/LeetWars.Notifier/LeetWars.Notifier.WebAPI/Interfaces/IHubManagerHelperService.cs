using LeetWars.Notifier.WebAPI.Models;

namespace LeetWars.Notifier.WebAPI.Interfaces;

public interface IHubManagerHelperService
{
    Task SendMessage(NotifierMessage message); 
}
