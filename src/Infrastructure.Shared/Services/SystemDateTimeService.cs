using GLifeInc.Application.Interfaces.Services;
using System;

namespace GLifeInc.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}