using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VoteItem : BaseDataObject
    {
        public string Occasion { set; get; }
        public double FitnessInterval { set; get; }
        public double FeelingTeamInterval { set; get; }
        public double FairplayInterval { set; get; }
        public double FeelingPersonalInterval { set; get; }
        public double RefereeOkInterval { set; get; }
    }
}
