using NATKSchedule.DTO;

namespace NATKSchedule.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
       startDate, DateTime endDate);
    }
}
