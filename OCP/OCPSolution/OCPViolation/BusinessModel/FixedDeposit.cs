using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation.BusinessModel
{
    internal class FixedDeposit
    {
        private readonly string _name;
        private readonly double _principle;
        private readonly double _duration;
        private readonly FestivalPolicyType _policyType;

        public FixedDeposit(string name,double principle,double duration,FestivalPolicyType policyType)
        {
            _name = name;
            _principle = principle;
            _duration = duration;
            _policyType = policyType;
        }

        public double CalculateRate()
        {
            if (_policyType == FestivalPolicyType.DIWALI)
                return 8;
            if (_policyType == FestivalPolicyType.NEW_YEAR)
                return 9;
            

                return 7;
        }

        public double CalculateSimpleInterest()
        {
            return (_principle * _duration * CalculateRate()) / 100;
        }

        public override string ToString()
        {
            return $"Name : {_name} \n Principle : {_principle} \n Duration : {_duration} \n " +
                $"PolicyType : {_policyType} " +
                $"\nParent type : {base.ToString()}";
        }
    }
}
