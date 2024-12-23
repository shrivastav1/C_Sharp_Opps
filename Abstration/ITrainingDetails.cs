using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstration
{
    public interface ITrainingDetails
    {
        string GetTrainername(string trainerName);
        int CalculateTotalHours(int days, int hoursPerDay);
    }
}
